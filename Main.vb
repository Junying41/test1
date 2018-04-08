Public Class Main

    Dim My_Icon1 As Icon                '定义图标用于表示托盘图标
    Dim My_Icon2 As Icon                '定义图标用于表示托盘图标
    Private My_Icon As Boolean = False  '用于托盘动态显示的标志
    Private My_Image As Boolean = False '用于左侧栏锁的显示动态显示的标志
    Dim CLoseFlag As Boolean = False    '用于表示什么时候才关闭主窗体
    Dim HideFlag As Boolean = False     '用于表示双击托盘图标主窗体的显示于隐藏
    '主窗体Load
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadIcon()
        LoadSource()
        TreeView1.ExpandAll()
    End Sub

    '初始化工作
    Private Sub LoadIcon()
        Dim BitMap As System.Drawing.Bitmap
        BitMap = ImageList1.Images("BookIconOne.ico")
        My_Icon1 = System.Drawing.Icon.FromHandle(BitMap.GetHicon())
        BitMap = ImageList1.Images("BookIconTow.ico")
        My_Icon2 = System.Drawing.Icon.FromHandle(BitMap.GetHicon())
    End Sub

    '在点击菜单栏，左侧栏以及工具栏上的About时显示系统的关于对话框
    Private Sub LoadSource()
        statusTime.Text = "当前时间:" & Now.ToLongDateString & Now.ToLongTimeString
        cmenueIcon.Items(2).Enabled = False
    End Sub


    '用定时其timerIcon控制托盘图标的动态显示效果
    '控制下方状态栏上时间的显示
    Private Sub timerIco_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerIco.Tick

        statusTime.Text = "当前时间:" & Now.ToLongDateString & Now.ToLongTimeString
        If My_Icon = False Then
            My_Icon = True
            ntIcon.Icon = My_Icon1
        Else
            My_Icon = False
            ntIcon.Icon = My_Icon2
        End If
    End Sub
    '点击退出系统并判断是不是要退出系统
    Private Sub menueExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueExit.Click
        Me.Hide()
        Me.tsmenueRestore.Enabled = True

    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CLoseFlag = False Then
            Me.Hide()
            Me.tsmenueRestore.Enabled = True
            e.Cancel = True
        End If
    End Sub

    '****************************************************************************
    '*******************************  左侧栏  *********************************** 
    '****************************************************************************
#Region "左侧栏的显示与关闭"
    '点击“图标叉”关闭左侧栏
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        CloseLeft()
    End Sub

    '用菜单项中的“打开左侧栏”打开或关闭左侧栏
    Private Sub menueCloseLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueCloseLeft.Click
        CloseLeft()
    End Sub
    '控制左侧栏的打开或关闭
    Private Sub CloseLeft()
        If LeftPanel.Visible = False Then
            LeftPanel.Visible = True
            menueCloseLeft.Text = "关闭左侧栏"
        Else
            LeftPanel.Visible = False
            menueCloseLeft.Text = "打开左侧栏"
        End If
    End Sub
    '用timerLeftPanel 来控制左侧栏的显示状态
    Private Sub timerLeftPanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerLeftPanel.Tick
        Dim CursorPos As System.Drawing.Point
        Dim Distance As Integer
        Dim RightPos As Integer
        CursorPos = MousePosition
        RightPos = CursorPos.X - Me.Left
        Distance = RightPos - Me.LeftPanel.Width
        If Math.Abs(Distance) < 20 Or (RightPos < 230 And Distance < 0) Then ' Me.LeftWindow.Width - 
            If LeftPanel.Width < 230 Then
                LeftPanel.Width += 10
            End If
        ElseIf RightPos > 240 Then
            If LeftPanel.Width > 15 Then
                Me.LeftPanel.Width -= 10
            End If
        End If
    End Sub
    '判断左侧边栏的图标是该显示Lock还是UnLock
    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click

        If My_Image = False Then
            btnLock.Image = ImageList1.Images("UnLock.ico")
            My_Image = True
            timerLeftPanel.Enabled = True
        Else
            btnLock.Image = ImageList1.Images("Lock.ico")
            My_Image = False
            timerLeftPanel.Enabled = False
            LeftPanel.Width = 230
        End If

    End Sub

#End Region
    '****************************************************************************

    '用左侧栏中的节点控制
    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Select Case e.Node.Name
            Case "nodeAbout"
                Help()
            Case "nodeSelectChangeUser"
                ManageUser()
            Case "nodeChangPwd"
                ChangePwd()
            Case "nodeSelectChangeTaff"
                ManageTaff()
            Case "nodeAddTaff"
                ManageTaff()
            Case "nodeDeleteTaff"
                ManageTaff()
            Case "nodeAddBook"
                AddBook()
            Case "nodeChangeBook"
                ManageBook()
            Case "nodeDelteBook"
                ManageBook()
            Case "nodeBookBorrow"
                BookFind()
            Case "nodeBookFind"
                BookFind()
            Case "nodeWindowDie"
                MdiLayDie()
            Case "nodeWindowHorizon"
                MdiLayHorizon()
            Case "nodeWindowVertify"
                MdiLayVertify()
            Case "nodeWindowIcon"
                MdiLayIcon()
            Case "nodeAddUser"
                AddUser()
            Case "nodeDeleteUser"
                ManageUser()
            Case "nodeBorrowAdvance"
                BookFind()
            Case "nodeHelpMain"
                Help()
        End Select
    End Sub


    '修改密码
    Private Sub menueChangePwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueChangePwd.Click
        ChangePwd()
    End Sub
    Private Sub tsChangPwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsChangPwd.Click
        ChangePwd()
    End Sub
    Private Sub ChangePwd()
        Dim frmChangPwdDlg As Form = frmChangPwd
        frmChangPwdDlg.MdiParent = Me
        frmChangPwdDlg.Show()
        frmChangPwdDlg.Focus()
    End Sub


    '用户管理
    Private Sub menueSelectChangeUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueSelectChangeUser.Click
        ManageUser()
    End Sub
    Private Sub tsManageUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsManageUser.Click
        ManageUser()
    End Sub
    '删除用户
    Private Sub menueDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueDeleteUser.Click
        ManageUser()
    End Sub
    Private Sub ManageUser()
        If UserKind = OwerKind.User Then
            MsgBox("您的权限不足！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "消息")
            Exit Sub
        End If
        Dim frmUserManageDlg As Form = frmUserManage
        frmUserManageDlg.MdiParent = Me
        frmUserManageDlg.Show()
        frmUserManageDlg.Focus()
    End Sub
    '添加用户
    Private Sub menueAddUser_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueAddUser.Click
        AddUser()
    End Sub
    Private Sub AddUser()
        If UserKind = OwerKind.User Then
            MsgBox("您的权限不足！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "消息")
            Exit Sub
        End If
        Dim frmAddUserDlg As Form = frmAddUser
        frmAddUserDlg.MdiParent = Me
        frmAddUserDlg.Show()
        frmAddUserDlg.Focus()
    End Sub


    '员工管理
    '添加员工
    Private Sub menueAddTaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueAddTaff.Click
        ManageTaff()
    End Sub
    '删除员工
    Private Sub menueDeleteTaff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menueDeleteTaff.Click
        ManageTaff()
    End Sub
    '查找编辑用户
    Private Sub menueSelectChangeTaff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menueSelectChangeTaff.Click
        ManageTaff()
    End Sub
    Private Sub tsManageTaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsManageTaff.Click
        ManageTaff()
    End Sub
    Private Sub ManageTaff()
        If UserKind = OwerKind.User Then
            MsgBox("权限不足操作非法!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            Exit Sub
        End If
        Dim TaffTable As New DataTable

        TaffTable = Taff.SelectUser(Taff.UserID)
        If TaffTable.Rows(0).Item(7).ToString <> "超级用户" Then
            MsgBox("权限不足操作非法!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            Exit Sub
        End If

        Dim frmTaffManageDlg As Form = frmTaffManage
        frmTaffManageDlg.MdiParent = Me
        frmTaffManageDlg.Show()
        frmTaffManageDlg.Focus()
    End Sub


    '显示About帮助对话框
    Private Sub menueAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueAbout.Click
        About()
    End Sub
    Private Sub tsHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHelp.Click
        About()
    End Sub
    Private Sub About()
        Dim frmAboutDlg As Form = frmAbout
        frmAboutDlg.MdiParent = Me
        frmAboutDlg.Show()
        frmAboutDlg.Focus()
    End Sub


    '添加图书
    Private Sub menueAddBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueAddBook.Click
        AddBook()
    End Sub
    Private Sub tsAddBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAddBook.Click
        AddBook()
    End Sub
    Private Sub AddBook()
        If UserKind = OwerKind.User Then
            MsgBox("权限不足！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "消息")
            Exit Sub
        End If
        Dim frmAdd As Form = frmAddBook
        frmAdd.MdiParent = Me
        frmAdd.Show()
        frmAdd.Focus()
    End Sub


    '修改图书
    Private Sub menueChangBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueChangBook.Click
        ManageBook()
    End Sub
    Private Sub tsChangeBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsChangeBook.Click
        ManageBook()
    End Sub

    '删除书籍
    Private Sub tsDeleteBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDeleteBook.Click
        ManageBook()

    End Sub
    Private Sub menueDeleteBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueDeleteBook.Click
        ManageBook()
    End Sub
    Private Sub ManageBook()
        If UserKind = OwerKind.User Then
            MsgBox("权限不足！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "消息")
            Exit Sub
        End If
        Dim frmDelete As Form = frmBookManage
        frmDelete.MdiParent = Me
        frmDelete.Show()
        frmDelete.Focus()
    End Sub

    '图书查询
    Private Sub menueFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueFind.Click
        BookFind()
    End Sub
    Private Sub tsBookFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsBookFind.Click
        BookFind()
    End Sub

    Private Sub BookFind()
        'Dim frmBorrow As Form = frmBookSelect
        'frmBorrow.MdiParent = Me
        'frmBorrow.Show()
        'frmBorrow.Focus()
    End Sub

    '借阅图书
    Private Sub menueBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueBorrow.Click
        BookFind()
    End Sub
    Private Sub tsBookBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBookBorrow.Click
        BookFind()
    End Sub
    '预约图书
    Private Sub menueBorrowAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BookFind()
    End Sub
    '托盘选项关闭系统
    Private Sub tsmenueClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmenueClose.Click
        If MsgBox("你真的想退出系统吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "退出系统") = MsgBoxResult.Yes Then
            CLoseFlag = True
            Application.Exit()
        End If

    End Sub
    Private Sub ntIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ntIcon.MouseDoubleClick
        If HideFlag = True Then
            Me.Visible = True
            tsmenueRestore.Enabled = False
            HideFlag = False
        Else
            Me.Visible = False
            tsmenueRestore.Enabled = True
            HideFlag = True
        End If

    End Sub
    Private Sub tsmenueHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmenueHide.Click
        Me.Hide()
        cmenueIcon.Items(2).Enabled = True
    End Sub
    Private Sub tsmenueRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmenueRestore.Click
        Me.Show()
        tsmenueRestore.Enabled = False
    End Sub
    '子窗体重叠
    Private Sub menueDie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueDie.Click
        MdiLayDie()
    End Sub
    Private Sub tsDie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDie.Click
        MdiLayDie()
    End Sub
    Private Sub MdiLayDie()
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    '子窗体平铺
    Private Sub menueHorizon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueHorizon.Click
        MdiLayHorizon()
    End Sub
    Private Sub tsHorizon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHorizon.Click
        MdiLayHorizon()
    End Sub
    Private Sub MdiLayHorizon()
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    '子窗体垂直平铺
    Private Sub menueVertify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueVertify.Click
        MdiLayVertify()
    End Sub
    Private Sub tsVertify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsVertify.Click
        MdiLayVertify()
    End Sub
    Private Sub MdiLayVertify()
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    '子窗体排列图标
    Private Sub menueShowIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueShowIcon.Click
        MdiLayIcon()
    End Sub
    Private Sub tsIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsIcon.Click
        MdiLayIcon()
    End Sub
    Private Sub MdiLayIcon()
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    '关闭所有子窗体
    Private Sub menueCloseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueCloseAll.Click
        MdiLayClose()
    End Sub
    Private Sub MdiLayClose()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    '关闭工具栏或打开工具栏
    Private Sub menueCloseTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueCloseTool.Click
        If toolbar.Visible = True Then
            toolContainer.Height = 26       '通过设置toolContain的高度来控制工具栏的显示
            toolbar.Visible = False
            menueCloseTool.Text = "打开工具栏"
        Else
            toolContainer.Height = 48       '通过设置toolContain的高度来控制工具栏的显示
            toolbar.Visible = True
            menueCloseTool.Text = "关闭工具栏"
        End If
    End Sub
    '关闭状态栏或打开关闭栏
    Private Sub menueCloseStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueCloseStatus.Click
        If statusbar.Visible = True Then
            statusbar.Visible = False
            menueCloseStatus.Text = "打开状态栏"
        Else
            statusbar.Visible = True
            menueCloseStatus.Text = "关闭状态栏"
        End If
    End Sub
    '显示帮助
    Private Sub menueHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menueHelp.Click
        Help()
    End Sub
    Private Sub Help()
        Dim helptxt As String = Application.StartupPath + "\Help.html"
        Process.Start("iexplore.exe", helptxt)
    End Sub
End Class
Public Class frmBookBorrow
    Dim BorrowUserID As String
    Dim BorrowUserKind As OwerKind
    '借阅事件
    Private Sub btnBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrow.Click
        '如果当前用户是管理员的话就要判断是为什么人借
        If IsUserValid() = False Then
            Exit Sub
        End If
        If txtStation2.Text.Trim <> "已预约" Then
            DBBorrow.BorrowBook(BorrowUserID, txtBookID.Text, BorrowUserKind, "借阅")
        Else
            '查看借阅信息表看是不是本用户预约的该书，是的话就借阅成功，并修改状态为未预约
            If IsUser() Then
                ' Book.UpdateBook(txtBookID.Text.Trim, "已借出")
                Book.UpdateBook(txtBookID.Text.Trim, "未预借")
                ' DBBorrow.RturnBook(BorrowUserID, BorrowUserKind, txtBookID.Text.Trim)
                DBBorrow.BorrowBook(BorrowUserID, txtBookID.Text.Trim, BorrowUserKind, "借阅")
            Else
                MsgBox("已预约图书，无法借阅！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "消息")
                '借阅，预约按钮变成不可用状态
                btnAdvanceBorrow.Enabled = False
                btnBorrow.Enabled = False
                Exit Sub
            End If
        End If

        Book.UpdateBook(txtBookID.Text.Trim, "已借出")
        MsgBox("借阅成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "消息")
        '借阅成功后借阅按钮变成不可用状态
        btnBorrow.Enabled = False
        '重新绑定数据
        BandData()
    End Sub
    '判断用户是否合法
    Private Function IsUserValid() As Boolean
        '如果当前用户是管理员的话就要判断是为什么人借书
        If UserKind = OwerKind.Taff Then
            Select Case txtPersonKind.Text.Trim
                Case "普通用户"
                    If IsExist() = False Then
                        Return False
                    End If
                Case "管理员"
                    If IsExist() = False Then
                        Return False
                    End If
                Case "本用户"
                    BorrowUserID = UserName
                    BorrowUserKind = UserKind
            End Select
        End If
        Return True
    End Function
    '判断用户是否存在
    Private Function IsExist() As Boolean
        '查找用户表,或者是员工表看是否又对应的用户存在
        If txtPerson.Text.Trim = "" Then
            MsgBox("用户ID不能为空！", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "消息")
            Return False
        Else
            Dim table As DataTable
            If txtPersonKind.Text.Trim = "普通用户" Then
                table = User.SelectUser(txtPerson.Text.Trim)
            Else
                table = Taff.SelectUser(txtPerson.Text.Trim)
            End If
            If table.Rows.Count <= 0 Then
                MsgBox("用户不存在请重新填写！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "消息")
                txtPerson.Text = ""
                Return False
            Else
                BorrowUserID = txtPerson.Text.Trim
                If txtPersonKind.Text.Trim = "普通用户" Then
                    BorrowUserKind = OwerKind.User
                Else
                    BorrowUserKind = OwerKind.Taff
                End If
            End If
        End If
        Return True
    End Function
    'Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    '    Me.Close()
    '    frmBookSelect.Visible = True
    'End Sub

    'Private Sub frmBookBorrow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    '原始查找窗体再次显示
    '    My.Forms.frmBookSelect.Visible = True
    'End Sub

    Private Sub frmBookBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '如果数据不存在绑定失败就退出
        If BandData() = False Then
            Exit Sub
        End If
        txtPersonKind.SelectedIndex = 0
        '初始化借阅用户为当前用户
        BorrowUserID = UserName
        BorrowUserKind = UserKind
        '设置窗体样式
        If UserKind = OwerKind.User Then
            Dim Position As Point
            labPerson.Visible = False
            labPersonKind.Visible = False
            txtPerson.Visible = False
            txtPersonKind.Visible = False
            Me.Height = 320
            '为按钮设置新的位置
            '借阅按钮
            Position = btnBorrow.Location
            Position.Y = 240
            btnBorrow.Location = Position
            '预借按钮
            Position = btnCancel.Location
            Position.Y = 240
            btnCancel.Location = Position
            '取消按钮
            Position = btnAdvanceBorrow.Location
            Position.Y = 240
            btnAdvanceBorrow.Location = Position
        End If
        If txtStation.Text.Trim = "在馆不可借" Then
            MsgBox("图书现在处于不可借状态！", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "信息")
            btnBorrow.Enabled = False
            btnAdvanceBorrow.Enabled = False
        ElseIf txtStation.Text.Trim = "已借出" Then
            btnBorrow.Enabled = False
        ElseIf txtStation.Text.Trim = "在馆可借" Then
            btnAdvanceBorrow.Enabled = False
        End If
        If txtStation2.Text.Trim = "已预约" Then
            btnAdvanceBorrow.Enabled = False
        End If
    End Sub
    '预约按钮的事件
    Private Sub btnAdvanceBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvanceBorrow.Click
        '如果当前用户是管理员的话就要判断是为什么人预借
        If IsUserValid() = False Then
            Exit Sub
        End If
        If IsUser() Then
            If txtStation.Text.Trim = "已借出" Then 'Or 
                MsgBox("你已经借阅了这本书，暂时不能预约！", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "消息")
                '预约失败预约按钮变成不可用状态
                btnAdvanceBorrow.Enabled = False
                Exit Sub
            End If
        End If
        Book.UpdateBook(txtBookID.Text.Trim, "已预约")
        DBBorrow.BorrowBook(BorrowUserID, txtBookID.Text, BorrowUserKind, "预约")
        Book.UpdateBook(txtBookID.Text.Trim, "已预约")
        MsgBox("预借成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "消息")
        '预约成功后预约按钮变成不可用状态
        btnAdvanceBorrow.Enabled = False
        '重新绑定数据
        BandData()
    End Sub
    '初始绑定借阅书籍的数据到窗体上或借阅后预约后重新绑定数据
    Private Function BandData() As Boolean
        Dim Table As New DataTable
        Dim dr As DataRow
        '使得信息不可编辑
        txtAuthor.Enabled = False
        txtBookID.Enabled = False
        txtISBN.Enabled = False
        txtName.Enabled = False
        txtPrice.Enabled = False
        txtTemp.Enabled = False
        txtTime.Enabled = False
        txtStation.Text = False
        txtStation.Enabled = False
        txtStation2.Enabled = False

        'Table = Book.SelectBook(My.Forms.frmBookSelect.BorrowBookID)

        If Table.Rows.Count > 0 Then
            dr = Table.Rows(0)
            With Me
                .txtBookID.Text = dr("bookid").ToString.Trim
                .txtISBN.Text = dr("ISBN").ToString.Trim
                .txtName.Text = dr("bookname").ToString.Trim
                .txtPrice.Text = dr("price").ToString.Trim
                .txtAuthor.Text = dr("author").ToString.Trim
                .txtTime.Text = dr("time").ToString.Trim
                .txtTemp.Text = dr("remark").ToString.Trim
                .txtStation.Text = dr("station").ToString.Trim
                .txtStation2.Text = dr("station1").ToString.Trim
                .txtBookID.Enabled = False
            End With
        Else
            btnBorrow.Enabled = False
            Return False
        End If
        Return True
    End Function
    '判断要借阅的用户是不是就是当前登陆的用户
    Private Function IsUser() As Boolean
        Dim table As DataTable
        table = DBBorrow.SelectBookUser(txtBookID.Text.Trim)
        If table IsNot Nothing Then
            If table.Rows.Count > 0 Then
                If table.Rows(0).Item("userid") = BorrowUserID And table.Rows(0).Item("userkind") = BorrowUserKind Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class

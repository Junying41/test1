Public Class frmTaffManage
    '定义一个枚举类型变量来表示应该执行什么样的操作
    Dim CmdKind As EditKind = EditKind.Other
    '确定键根据判断之前按下的键来决定执行什么对应的操作
    '如果之前按下的是"修改"那么就执行相应的修改命令
    '如果之前按下的是"添加"那么就执行相应的添加命令
    '如果之前按下的是"删除"那么就执行相应的删除命令
    '否则就直接退出窗体
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If CmdKind = EditKind.Update Then
            '修改员工信息
            With Me
                If Valid() = False Then
                    Exit Sub
                End If
                Dim TaffEdit As New DbTaff(.txtID.Text.Trim, .txtPwd.Text.Trim)
                TaffEdit.Birthday = .txtBirthday.Text.Trim
                TaffEdit.Right1 = "读写"
                TaffEdit.Right2 = txtKind.Text.Trim
                TaffEdit.Picture = ""
                TaffEdit.Mail = txtMail.Text.Trim
                TaffEdit.Home = txtHomeAddress.Text.Trim
                TaffEdit.RealName = txtName.Text.Trim
                If TaffEdit.UpdateUser(TaffEdit) = False Then
                    MsgBox("更新数据出错，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
                Else
                    MsgBox("修改成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "信息")
                    Band()
                    CmdKind = EditKind.Other
                End If
            End With
        ElseIf CmdKind = EditKind.Insert Then
            '添加新的员工
            If Valid() = False Then
                Exit Sub
            End If
            With Me
                Dim TaffEdit As New DbTaff(.txtID.Text.Trim, .txtPwd.Text.Trim)
                TaffEdit.Birthday = .txtBirthday.Text.Trim
                TaffEdit.Right1 = "读写"
                TaffEdit.Right2 = txtKind.Text.Trim
                TaffEdit.Picture = ""
                TaffEdit.Mail = txtMail.Text.Trim
                TaffEdit.Home = txtHomeAddress.Text.Trim
                TaffEdit.RealName = txtName.Text.Trim
                If TaffEdit.AddUser(TaffEdit) = False Then
                    MsgBox("插入数据出错，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
                Else
                    MsgBox("增加用户成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "信息")
                    Band()
                    CmdKind = EditKind.Other
                End If
            End With
        Else
            Me.Finalize()
            Me.Close()
        End If
    End Sub

    '如果之前按下的是命令没有执行完毕那么就继续执行其它相应命令
    '否则就直接退出窗体
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If CmdKind = EditKind.Other Then
            Me.Close()
            Exit Sub
        End If
        CmdKind = EditKind.Other
        Band()
    End Sub

    Private Sub frmTaffManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Band()
    End Sub

    '重新绑定数据或初始化TreeView和窗体上的数据
    Private Sub Band()
        CmdKind = EditKind.Other
        Dim SqlStr As String
        '查找出所有的员工
        SqlStr = "select * from tbTaff"
        Dim TaffTable As New DataTable
        Dim DView As DataView
        Dim dr As DataRowView

        TaffTable = DBOperation.DBOperate(SqlStr, "")
        DView = New DataView(TaffTable)

        treeTaff.Nodes.Clear()
        For Each dr In DView
            treeTaff.Nodes.Add(dr.Item("userid"))
        Next
        treeTaff.ExpandAll()
        dr = DView.Item(0)

        treeTaff.SelectedImageIndex = 1
        '调用函数SelectDetail来显示具体信息
        SelectDetail(dr)

        EnableFalse()
    End Sub

    '选择用户并显示用户的具体信息
    Private Sub treeTaff_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeTaff.AfterSelect
        CmdKind = EditKind.Other
        Dim SqlStr As String
        SqlStr = "select * from tbTaff where userid='" & e.Node.Text.ToString.Trim & "'"
        Dim TaffTable As New DataTable
        Dim DView As DataView
        Dim dr As DataRowView

        TaffTable = DBOperation.DBOperate(SqlStr, "")
        DView = New DataView(TaffTable)
        dr = DView.Item(0)
        SelectDetail(dr)
        EnableFalse()
    End Sub

    '修改员工信息
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        CmdKind = EditKind.Update
        EnableTrue()
    End Sub

    '添加新的员工
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        CmdKind = EditKind.Insert
        EnableTrue()
        txtID.Enabled = True
        Clear()
    End Sub

    ' 删除员工
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If CmdKind <> EditKind.Other Then
            MsgBox("非法操作，请结束其它编辑再试！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "信息")
            Exit Sub
        End If
        '删除员工信息
        Taff.DelUser(txtID.Text.Trim)
        If txtID.Text.Trim = "Admin" Then
            MsgBox("系统的超级用户不能被删除！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "警告")
            Exit Sub
        End If
        MsgBox("删除用户成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "信息")
        Band()
    End Sub

    '显示职工的的具体信息
    Private Sub SelectDetail(ByVal dr As DataRowView)
        With Me
            .txtName.Text = dr.Item("name").ToString
            .txtHomeAddress.Text = dr.Item("home").ToString
            .txtID.Text = dr.Item("userid").ToString
            .txtBirthday.Text = dr.Item("birthday").ToString
            .txtPolityKind.Text = "中共党员"
            .txtSex.SelectedIndex = 0
            .txtPwd.Text = dr.Item("pwd").ToString
            .txtTemp.Text = "暂时为空"
            .txtKind.Text = dr.Item("right2").ToString
            .txtMail.Text = dr.Item("mail").ToString
        End With
        dr = Nothing
    End Sub

    '验证窗体上的信息是否符合要求
    Private Function Valid() As Boolean
        With Me
            If .txtID.Text.Trim = "" Then
                MsgBox("用户ID不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
                Return False
            End If
            If .txtName.Text.Trim = "" Then
                MsgBox("真实名不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
                Return False
            End If
            If .txtPwd.Text.Trim = "" Then
                MsgBox("密码不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
                Return False
            End If
            If txtMail.Text.Trim <> "" And DBUser.ValidateEmail(txtMail.Text.Trim) = False Then
                MsgBox("邮箱格式错误，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
                Return False
            End If
            Return True
        End With
    End Function

    '使得窗体上的控件处于不可编辑状态
    Private Sub EnableFalse()
        With Me
            .txtPolityKind.Enabled = False
            .txtName.Enabled = False
            .txtKind.Enabled = False
            .txtID.Enabled = False
            .txtPwd.Enabled = False
            .txtSex.Enabled = False
            .txtTemp.Enabled = False
            .txtHomeAddress.Enabled = False
            .txtBirthday.Enabled = False
            .txtMail.Enabled = False
        End With
    End Sub

    '使得窗体上的控件处于可编辑状态
    Private Sub EnableTrue()
        With Me
            .txtPolityKind.Enabled = True
            .txtName.Enabled = True
            .txtKind.Enabled = True
            .txtPwd.Enabled = True
            .txtSex.Enabled = True
            .txtTemp.Enabled = True
            .txtHomeAddress.Enabled = True
            .txtBirthday.Enabled = True
            .txtMail.Enabled = True
        End With
    End Sub

    '使得窗体上的控件上的文字清空以便添加新的员工
    Private Sub Clear()
        With Me
            .txtPolityKind.Text = ""
            .txtName.Text = ""
            .txtKind.Text = ""
            .txtID.Text = ""
            .txtPwd.Text = ""
            .txtSex.Text = ""
            .txtTemp.Text = ""
            .txtHomeAddress.Text = ""
            .txtBirthday.Text = ""
        End With
    End Sub
End Class
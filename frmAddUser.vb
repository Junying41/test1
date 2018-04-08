Public Class frmAddUser

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim UserAdd As New DBUser("", "")
        Dim Sqlstr As String = ""
        Dim Table As New DataTable
        If txtRealName.Text.Trim = "" Then
            MsgBox("真实名不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        ElseIf txtUserID.Text.Trim = "" Then
            MsgBox("用户名不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        ElseIf txtPwd.Text.Trim = "" Or txtAgainPwd.Text.Trim <> txtPwd.Text.Trim Then
            MsgBox("密码填写错误，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
            txtAgainPwd.Text = ""
            txtPwd.Text = ""
            txtPwd.Focus()
            Exit Sub
        Else
            UserAdd.UserID = txtUserID.Text.Trim
            UserAdd.Password = txtPwd.Text.Trim
            UserAdd.RealName = txtRealName.Text.Trim
            UserAdd.Right1 = "可读"
            UserAdd.Right2 = "无权限"
            If txtMail.Text.Trim <> "" And DBUser.ValidateEmail(txtMail.Text.Trim) = False Then
                MsgBox("邮箱格式错误，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
                Fail()
                Exit Sub
            End If
            UserAdd.Mail = txtMail.Text.Trim
            UserAdd.Home = txtHome.Text.Trim
            UserAdd.Birthday = txtBirthday.Text.Trim

            If UserAdd.AddUser(UserAdd) = False Then
                Fail()
                Exit Sub
            Else
                MsgBox("新用户添加成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "信息")
            End If
        End If

        Me.Close()
    End Sub
    '清空文本框的内容
    Private Sub Fail()
        txtAgainPwd.Text = ""
        txtBirthday.Text = ""
        txtHome.Text = ""
        txtMail.Text = ""
        txtPwd.Text = ""
        txtRealName.Text = ""
        txtUserID.Text = ""
        txtRealName.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
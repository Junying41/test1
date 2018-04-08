Public Class frmChangeUser
    Private Sub frmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmUserManage.EditId <> "" Then
            Dim Table As New DataTable
            Dim dr As DataRow
            Table = User.SelectUser(frmUserManage.EditId)
            If Table.Rows.Count > 0 Then
                dr = Table.Rows(0)
                With Me
                    .txtRealName.Text = dr("name").ToString
                    .txtUserID.Text = dr("userid").ToString
                    .txtPwd.Text = dr("pwd").ToString
                    .txtAgainPwd.Text = dr("pwd").ToString
                    .txtMail.Text = dr("mail").ToString
                    .txtHome.Text = dr("home").ToString
                    .txtBirthday.Text = dr("birthday").ToString
                    .txtUserID.Enabled = False
                End With
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim UserAdd As New DBUser("", "")
        Dim Sqlstr As String = ""
        Dim Table As New DataTable

        If txtRealName.Text.Trim = "" Then
            MsgBox("真实名不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        ElseIf txtPwd.Text.Trim = "" Or txtAgainPwd.Text.Trim <> txtPwd.Text.Trim Then
            MsgBox("密码填写错误，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
            txtAgainPwd.Text = ""
            txtPwd.Text = ""
            txtPwd.Focus()
            Exit Sub
        Else                 
            If txtMail.Text.Trim <> "" And DBUser.ValidateEmail(txtMail.Text.Trim) = False Then
                MsgBox("邮箱格式错误，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
                txtMail.Text = ""
                Exit Sub
            End If
            UserAdd.Right1 = "可读"
            UserAdd.Right2 = "无权限"
            UserAdd.UserID = txtUserID.Text.Trim
            UserAdd.Password = txtPwd.Text.Trim
            UserAdd.RealName = txtRealName.Text.Trim
            UserAdd.Mail = txtMail.Text.Trim
            UserAdd.Home = txtHome.Text.Trim
            UserAdd.Birthday = txtBirthday.Text.Trim
        End If
        If UserAdd.UpdateUser(UserAdd) = False Then
            MsgBox("修改用户信息失败！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "信息")
            Exit Sub
        End If

        MsgBox("修改用户信息成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "信息")
        frmUserManage.Band()
        Me.MdiParent.Focus()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Finalize()
        Me.Close()
    End Sub
End Class
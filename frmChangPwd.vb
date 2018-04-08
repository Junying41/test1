Public Class frmChangPwd

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtOldPwd.Text.Trim = "" Then
            MsgBox("旧密码不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            Exit Sub
        ElseIf txtNewPwd.Text.Trim = "" Then
            MsgBox("新密码不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            Exit Sub
        ElseIf txtNewAgain.Text.Trim = "" Then
            MsgBox("重复新密码不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            Exit Sub
        ElseIf txtOldPwd.Text.Trim <> UserPwd Then
            MsgBox("旧密码输入有误，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            txtOldPwd.Text = ""
            txtOldPwd.Focus()
            Exit Sub
        ElseIf txtNewPwd.Text.Trim <> txtNewAgain.Text.Trim Then
            MsgBox("新密码填写错误，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            txtNewPwd.Text = ""
            txtNewAgain.Text = ""
            txtNewPwd.Focus()
            Exit Sub
        End If
        If UserKind = OwerKind.User Then
            User.ChangePwd(txtNewPwd.Text.Trim)
        Else
            Taff.ChangePwd(txtNewPwd.Text.Trim)
        End If
        UserPwd = txtNewPwd.Text.Trim

        MsgBox("密码修改成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "信息")

        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
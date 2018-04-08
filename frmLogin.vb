Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim frmMain As Form = Main

        If txtUserName.Text.Trim = "" Or txtUserPwd.Text.Trim = "" Then
            MsgBox("用户名或密码为空,请重新填写!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            lbAttachCode.Text = DBUser.AttachCode() '使得验证码重新生成
            Exit Sub
        End If

        If txtAttachCode.Text.Trim.ToUpper <> lbAttachCode.Text.Trim.ToUpper Then
            MsgBox("验证码不正确,请重新填写!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            lbAttachCode.Text = DBUser.AttachCode() '使得验证码重新生成
            Exit Sub
        End If

        If txtKind.SelectedItem.ToString.Trim = "" Then
            MsgBox("没有选择登陆类型,请重新填写!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
            lbAttachCode.Text = DBUser.AttachCode() '使得验证码重新生成
            Exit Sub
        End If

        '记录用户信息
        '普通用户登陆
        If txtKind.SelectedIndex = 0 Then
            UserKind = OwerKind.User
            User = New DBUser(txtUserName.Text.Trim, txtUserPwd.Text.Trim)
            UserName = User.UserID
            UserPwd = User.Password
            If User.LoginConfirm Then
                MsgBox("登陆成功,欢迎光临", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "登陆成功")
            Else
                MsgBox("用户名或密码不正确，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
                lbAttachCode.Text = DBUser.AttachCode() '使得验证码重新生成
                Exit Sub
            End If
            '管理员和超级用户登陆
        Else
            UserKind = OwerKind.Taff
            Taff = New DbTaff(txtUserName.Text.Trim, txtUserPwd.Text.Trim)
            UserName = Taff.UserID
            UserPwd = Taff.Password
            If Taff.LoginConfirm Then
                MsgBox("登陆成功,欢迎光临", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "登陆成功")
            Else
                MsgBox("用户名或密码不正确,请重新填写!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "警告")
                lbAttachCode.Text = DBUser.AttachCode() '使得验证码重新生成
                Exit Sub
            End If
            User = New DBUser("", "")
        End If

        frmMain.Show()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbAttachCode.Text = DBUser.AttachCode() '生成验证码
        txtKind.SelectedIndex = 0 '默认用户类型为普通用户
    End Sub

    Private Sub btGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet.Click
        lbAttachCode.Text = DBUser.AttachCode()
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class

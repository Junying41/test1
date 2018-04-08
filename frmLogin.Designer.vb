<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserPwd As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtUserPwd = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAttachCode = New System.Windows.Forms.TextBox()
        Me.lbAttachCode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKind = New System.Windows.Forms.ComboBox()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(67, 12)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(50, 18)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "User(&U):"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(48, 66)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(66, 14)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password(&P):"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(123, 12)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(158, 20)
        Me.txtUserName.TabIndex = 1
        '
        'txtUserPwd
        '
        Me.txtUserPwd.Location = New System.Drawing.Point(123, 64)
        Me.txtUserPwd.Name = "txtUserPwd"
        Me.txtUserPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPwd.Size = New System.Drawing.Size(158, 20)
        Me.txtUserPwd.TabIndex = 2
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(42, 218)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(64, 36)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "Ok(&O)"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(252, 218)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(64, 36)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel(&C)"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(67, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAttachCode
        '
        Me.txtAttachCode.Location = New System.Drawing.Point(123, 115)
        Me.txtAttachCode.Name = "txtAttachCode"
        Me.txtAttachCode.Size = New System.Drawing.Size(67, 20)
        Me.txtAttachCode.TabIndex = 3
        '
        'lbAttachCode
        '
        Me.lbAttachCode.AutoSize = True
        Me.lbAttachCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbAttachCode.ForeColor = System.Drawing.Color.Crimson
        Me.lbAttachCode.Location = New System.Drawing.Point(196, 116)
        Me.lbAttachCode.Name = "lbAttachCode"
        Me.lbAttachCode.Size = New System.Drawing.Size(36, 15)
        Me.lbAttachCode.TabIndex = 8
        Me.lbAttachCode.Text = "Code"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(49, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Types User"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKind
        '
        Me.txtKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtKind.FormattingEnabled = True
        Me.txtKind.Items.AddRange(New Object() {"普通用户", "管理员"})
        Me.txtKind.Location = New System.Drawing.Point(123, 160)
        Me.txtKind.Name = "txtKind"
        Me.txtKind.Size = New System.Drawing.Size(154, 21)
        Me.txtKind.TabIndex = 4
        '
        'btnGet
        '
        Me.btnGet.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGet.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnGet.Location = New System.Drawing.Point(252, 112)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(25, 25)
        Me.btnGet.TabIndex = 10
        Me.btnGet.Text = "R"
        Me.btnGet.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(364, 282)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.txtKind)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbAttachCode)
        Me.Controls.Add(Me.txtAttachCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtUserPwd)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAttachCode As System.Windows.Forms.TextBox
    Friend WithEvents lbAttachCode As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKind As System.Windows.Forms.ComboBox
    Friend WithEvents btnGet As System.Windows.Forms.Button
    'Friend WithEvents SourceDataSet As LibraryManage.SourceDataSet
    'Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents UserTableAdapter As LibraryManage.SourceDataSetTableAdapters.UserTableAdapter
    ' Friend WithEvents TableAdapterManager As LibraryManage.SourceDataSetTableAdapters.TableAdapterManager

End Class

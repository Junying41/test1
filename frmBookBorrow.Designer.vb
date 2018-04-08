<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookBorrow
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStation = New System.Windows.Forms.TextBox()
        Me.btnAdvanceBorrow = New System.Windows.Forms.Button()
        Me.txtStation2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.labPerson = New System.Windows.Forms.Label()
        Me.labPersonKind = New System.Windows.Forms.Label()
        Me.txtPersonKind = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(95, 281)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(75, 31)
        Me.btnBorrow.TabIndex = 0
        Me.btnBorrow.Text = "In borrowing"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(375, 281)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 31)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "ok"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(343, 107)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(185, 20)
        Me.txtTime.TabIndex = 59
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(332, 62)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(196, 20)
        Me.txtPrice.TabIndex = 56
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(332, 12)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(196, 20)
        Me.txtBookID.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(265, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Product Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(291, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Book ID"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(82, 154)
        Me.txtTemp.Multiline = True
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(177, 92)
        Me.txtTemp.TabIndex = 60
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(83, 108)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(176, 20)
        Me.txtAuthor.TabIndex = 58
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(83, 60)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(176, 20)
        Me.txtISBN.TabIndex = 53
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(82, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(177, 20)
        Me.txtName.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Comments "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "ISBN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Book's Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Status 1"
        '
        'txtStation
        '
        Me.txtStation.Location = New System.Drawing.Point(332, 153)
        Me.txtStation.Name = "txtStation"
        Me.txtStation.Size = New System.Drawing.Size(196, 20)
        Me.txtStation.TabIndex = 65
        '
        'btnAdvanceBorrow
        '
        Me.btnAdvanceBorrow.Location = New System.Drawing.Point(246, 281)
        Me.btnAdvanceBorrow.Name = "btnAdvanceBorrow"
        Me.btnAdvanceBorrow.Size = New System.Drawing.Size(89, 31)
        Me.btnAdvanceBorrow.TabIndex = 1
        Me.btnAdvanceBorrow.Text = "set to borrow"
        Me.btnAdvanceBorrow.UseVisualStyleBackColor = True
        '
        'txtStation2
        '
        Me.txtStation2.Location = New System.Drawing.Point(332, 203)
        Me.txtStation2.Name = "txtStation2"
        Me.txtStation2.Size = New System.Drawing.Size(196, 20)
        Me.txtStation2.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(279, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Status 2"
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(341, 249)
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(190, 20)
        Me.txtPerson.TabIndex = 69
        '
        'labPerson
        '
        Me.labPerson.AutoSize = True
        Me.labPerson.Location = New System.Drawing.Point(272, 252)
        Me.labPerson.Name = "labPerson"
        Me.labPerson.Size = New System.Drawing.Size(63, 13)
        Me.labPerson.TabIndex = 68
        Me.labPerson.Text = "Borrower ID"
        '
        'labPersonKind
        '
        Me.labPersonKind.AutoSize = True
        Me.labPersonKind.Location = New System.Drawing.Point(6, 255)
        Me.labPersonKind.Name = "labPersonKind"
        Me.labPersonKind.Size = New System.Drawing.Size(89, 13)
        Me.labPersonKind.TabIndex = 70
        Me.labPersonKind.Text = "Types of Borrows"
        '
        'txtPersonKind
        '
        Me.txtPersonKind.FormattingEnabled = True
        Me.txtPersonKind.Items.AddRange(New Object() {"普通用户", "管理员", "本用户"})
        Me.txtPersonKind.Location = New System.Drawing.Point(101, 252)
        Me.txtPersonKind.Name = "txtPersonKind"
        Me.txtPersonKind.Size = New System.Drawing.Size(158, 21)
        Me.txtPersonKind.TabIndex = 71
        '
        'frmBookBorrow
        '
        Me.AcceptButton = Me.btnBorrow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(545, 329)
        Me.Controls.Add(Me.txtPersonKind)
        Me.Controls.Add(Me.labPersonKind)
        Me.Controls.Add(Me.txtPerson)
        Me.Controls.Add(Me.labPerson)
        Me.Controls.Add(Me.txtStation2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAdvanceBorrow)
        Me.Controls.Add(Me.txtStation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBorrow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBookBorrow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Borrows"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStation As System.Windows.Forms.TextBox
    Friend WithEvents btnAdvanceBorrow As System.Windows.Forms.Button
    Friend WithEvents txtStation2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPerson As System.Windows.Forms.TextBox
    Friend WithEvents labPerson As System.Windows.Forms.Label
    Friend WithEvents labPersonKind As System.Windows.Forms.Label
    Friend WithEvents txtPersonKind As System.Windows.Forms.ComboBox
End Class

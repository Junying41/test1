Public Class frmAddBook

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtName.Text.Trim = "" Then
            MsgBox("书目名称不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        End If
        If txtBookID.Text.Trim = "" Then
            MsgBox("书目ID不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        End If
        If txtISBN.Text.Trim = "" Then
            MsgBox("书目ISBN号不能为空，请重新填写！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        End If

        If txtPrice.Text <> "" Then  '判断输入的价格是否是合法的
            Try
                Dim price As Decimal
                price = Convert.ToDecimal(txtPrice.Text.Trim)
                If price < 0 Then
                    MsgBox("您输入的价格非法，请重新输入!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "操作错误")
                    txtPrice.Text = ""
                    txtPrice.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("您输入的价格非法，请重新输入!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "操作错误")
                txtPrice.Text = ""
                txtPrice.Focus()
                Exit Sub
            End Try
        End If

        If txtTime.Text <> "" Then       '判断输入的年份是否是非法的
            Try
                Dim year As Integer
                year = Convert.ToDecimal(txtTime.Text.Trim) ' Then
                If year < 0 Or year > Now.Year Then
                    MsgBox("您输入的年份非法，请重新输入!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "操作错误")
                    txtTime.Text = ""
                    txtTime.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("您输入的年份非法，请重新输入!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "操作错误")
                Exit Sub
            End Try
        End If

        Dim BookAdd As New DBBook(txtBookID.Text.Trim, txtISBN.Text.Trim)
        BookAdd.Author = txtAuthor.Text.Trim
        BookAdd.Price = txtPrice.Text.Trim
        BookAdd.BookName = txtName.Text.Trim
        BookAdd.Remark = txtTemp.Text.Trim
        BookAdd.Time = txtTime.Text.Trim
        If BookAdd.AddBook(BookAdd) = False Then
            MsgBox("新建书目失败！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "警告")
            Exit Sub
        Else
            MsgBox("新建书目成功！", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "信息")
        End If

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Exit Sub
    End Sub
End Class
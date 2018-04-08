Public Class frmBookManage
    Public EditNum As Integer
    Public EditId As String = ""
    Private Sub frmManageBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Band()
    End Sub
    Private Sub btnOK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '删除书目信息
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim index As Integer
        Dim theItem As DataGridViewRow
        Dim Bookid As String          '记录要删除的书目Id
        If Me.dgviewBook.SelectedRows.Count <= 0 Then
            If dgviewBook.SelectedCells.Count <= 0 Then
                MsgBox("请选择你要删除的书目！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息框")
                Exit Sub
            End If
            index = dgviewBook.SelectedCells(0).RowIndex
        Else
            index = dgviewBook.SelectedRows(0).Index
        End If
        theItem = dgviewBook.Rows(index)
        Bookid = theItem.Cells(1).Value
        If DBBorrow.SelectBookBorrow(Bookid) Then
            MsgBox("图书已经被预借或借阅，无法删除书目，请以后再试", _
                   MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "操作错误")
            Exit Sub
        Else
            Book.DelBook(Bookid)
            dgviewBook.Rows.RemoveAt(index)

            MsgBox("删除书目成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息框")
            Band()    '重新绑定
        End If
    End Sub
    'dgviewUser绑定数据
    Sub Band()
        Dim Sqlstr As String
        Dim UserTable As New DataTable
        Dim Count As Integer = 0

        Sqlstr = "select ISBN as ISBN号 ,bookid as 书目ID ,bookname as 书目名称, price as 单价,author as 作者,time as 出版年份,remark as 备注 from tbBook"
        UserTable = DBOperation.DBOperate(Sqlstr, "")

        Me.dgviewBook.DataSource = UserTable
    End Sub
End Class
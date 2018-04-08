Public Class frmUserManage
    Public EditNum As Integer
    Public EditId As String = ""

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub frmUserManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Band()
    End Sub
    '删除用户信息
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim index As Integer
        Dim theItem As DataGridViewRow
        If Me.dgviewUser.SelectedRows.Count <= 0 Then
            If dgviewUser.SelectedCells.Count <= 0 Then
                MsgBox("请选择你要删除的用户！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息框")
                Exit Sub
            End If
            index = dgviewUser.SelectedCells(0).RowIndex
        Else

            index = dgviewUser.SelectedRows(0).Index
        End If
        theItem = dgviewUser.Rows(index)
        User.DelUser(theItem.Cells(1).Value)
        dgviewUser.Rows.RemoveAt(index)

        MsgBox("删除用户成功！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息框")

        Band()    '重新绑定
    End Sub
    '编辑更新用户数据
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        If dgviewUser.SelectedRows.Count <= 0 Then
            If dgviewUser.SelectedCells.Count <= 0 Then
                MsgBox("请选择你要编辑的用户！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息框")
                Exit Sub
            End If
            EditNum = dgviewUser.SelectedCells(0).RowIndex
        Else
            EditNum = dgviewUser.SelectedRows(0).Index
        End If
        '显示编辑用户信息的对话框

        EditId = dgviewUser.Rows(EditNum).Cells(1).Value
        Dim frmChangeUserDlg As Form = frmChangeUser
        frmChangeUserDlg.MdiParent = Me.MdiParent
        frmChangeUserDlg.Show()
    End Sub
    '给dgviewUser绑定数据
    Sub Band()
        Dim Sqlstr As String
        Dim UserTable As New DataTable
        Dim Count As Integer = 0

        Sqlstr = "select name as 真实姓名 ,userid as 账号 ,pwd as 密码, mail as 邮箱,birthday as 出生年月,home as 家庭住址 from tbUser"
        UserTable = DBOperation.DBOperate(Sqlstr, "")

        Me.dgviewUser.DataSource = UserTable
    End Sub
End Class
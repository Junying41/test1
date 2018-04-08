Public Class DBOperation
    Shared Function DBOperate(ByVal SqlStr As String, ByRef MsgStr As String) As DataTable
        Conn = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=" + Application.StartupPath + "\Source.mdb"
        Dim oleconn As New OleDb.OleDbConnection(Conn)

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(SqlStr, oleconn)
        'cmd.CommandText = CommandType.Text
        Dim sToken() As String
        sToken = SqlStr.Split(" ")
        Try
            If Strings.InStr("INSERT,UPDATE,DELETE", sToken(0).ToUpper) Then
                If oleconn.State <> ConnectionState.Open Then
                    oleconn.Open()
                End If
                cmd.ExecuteNonQuery()
                If oleconn.State <> ConnectionState.Closed Then
                    oleconn.Close()
                End If

                If sToken(0).ToUpper = "INSERT" Then
                    MsgStr = "插入成功"
                ElseIf sToken(0).ToUpper = "DELETE" Then
                    MsgStr = "删除成功"
                ElseIf sToken(0).ToUpper = "UPDATE" Then
                    MsgStr = "更新成功"
                End If
            Else
                Dim ObjectdsDataSet As New DataSet
                Dim Adapter As New OleDb.OleDbDataAdapter
                Adapter.TableMappings.Add("Table", "Temp")

                Adapter.SelectCommand = cmd
                If oleconn.State <> ConnectionState.Open Then
                    oleconn.Open()
                End If
                cmd.ExecuteNonQuery()

                If oleconn.State <> ConnectionState.Closed Then
                    oleconn.Close()
                End If

                Adapter.Fill(ObjectdsDataSet)

                Return ObjectdsDataSet.Tables("Temp")

            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        Return Nothing
    End Function

End Class

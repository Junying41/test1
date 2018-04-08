Public Class DBBorrow
    Private _UserID As String
    Private _BookID As String
    Private _BorrowTime As Date
    Private _ReturnTime As Date
    Private _UserKind As Int16
    Property UserID() As String
        Get
            Return _UserID
        End Get
        Set(ByVal value As String)
            _UserID = value
        End Set
    End Property
    Property BookID() As String
        Get
            Return _BookID
        End Get
        Set(ByVal value As String)
            _BookID = value
        End Set
    End Property
    Property BorrowTime() As Date
        Get
            Return _BorrowTime
        End Get
        Set(ByVal value As Date)
            _BorrowTime = value
        End Set
    End Property
    Property ReturnTime() As Date
        Get
            Return _ReturnTime
        End Get
        Set(ByVal value As Date)
            _ReturnTime = value
        End Set
    End Property
    Property UserClass() As Int16
        Get
            Return _UserKind
        End Get
        Set(ByVal value As Int16)
            _UserID = value
        End Set
    End Property
    '添加借阅信息书目
    Shared Function BorrowBook(ByVal UserID As String, ByVal BookID As String, ByVal Kind As Int16, ByVal BorrowSort As String) As Boolean
        Dim SQLString As String
        SQLString = "INSERT INTO [tbBorrow]([userid],[bookid],[userkind],[borrowtime],[borrowkind]) VALUES('" & UserID & "','" & BookID & "','" & Kind & "','" & Now.ToLocalTime.ToString & "','" & BorrowSort & "')"

        Try
            DBOperation.DBOperate(SQLString, "")
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    '修改借阅信息书目
    Shared Function RturnBook(ByVal UserID As String, ByVal Kind As Integer, ByVal BookID As String) As Boolean
        Dim SQLString As String
        '删除借阅表中的相应的记录
        SQLString = "delete from [tbBorrow] where [userid]='" & UserID & "' and [bookid]='" & BookID & "' and [userkind]=" & Kind & ""
        Try
            DBOperation.DBOperate(SQLString, "")
        Catch ex As Exception
            Return False
        End Try
        '修改图书表中图书的状态
        SQLString = "update [tbBook] set station='在馆可借' where bookid='" & BookID & "'"
        Try
            DBOperation.DBOperate(SQLString, "")
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    '查找借阅用户
    Shared Function SelectBookUser(ByVal BookID As String) As DataTable
        Dim SQLString As String
        Dim Table As New DataTable
        SQLString = "select [userid] ,[userkind] from [tbBorrow] where [bookid]='" & BookID & "'"
        Try
            Table = DBOperation.DBOperate(SQLString, "")
        Catch ex As Exception
            Return Nothing
        End Try
        Return Table
    End Function
    '查找借阅信息书目
    Shared Function SelectBookBorrow(ByVal UserStr As String, ByVal Kind As Integer) As DataTable
        Dim SQLString As String = _
            "select " + _
            "[tbUser].[name]," + _
            "[tbBorrow].[userid] ," + _
            "[tbBorrow].[bookid]," + _
            "[tbBook].[bookname]," + _
            "[tbBook].[ISBN]," + _
            "[tbBorrow].[borrowtime] " + _
            "from " + _
            "[tbBorrow],[tbUser],[tbBook] " + _
            "where  "
        Dim Table As New DataTable
        If UserStr.Trim = "All" Then '查找权限内所有用户的信息
            SQLString = SQLString + _
            "[tbBorrow].[userkind]=1 and " + _
            "[tbBorrow].[userid]=[tbUser].[userid] and " + _
            "[tbBorrow].[userid]=[tbUser].[userid] and " + _
            "[tbBorrow].[bookid]=[tbBook].[bookid] and " + _
            "[tbBorrow].[borrowkind]<>'预约'"
        ElseIf UserStr.Trim = "AllUser" Then ',如果是管理员
            SQLString = SQLString + _
            "[tbBorrow].[userkind]=1 and " + _
            "[tbBorrow].[userid]=[tbUser].[userid] and " + _
            "[tbBorrow].[bookid]=[tbBook].[bookid] and " + _
            "[tbBorrow].[borrowkind]<>'预约'"
        Else '普通查找
            If Kind = OwerKind.User Then
                SQLString = SQLString + _
                "[tbBorrow].[userid]='" & UserStr & "' and " + _
                "[tbBorrow].[userkind]=" & Kind & " and  " + _
                "[tbBorrow].[userid]=[tbUser].[userid] and " + _
                "[tbBorrow].[bookid]=[tbBook].[bookid] and " + _
                "[tbBorrow].[borrowkind]<>'预约'"
            Else    '管理员或者超级用户查找自己的信息
                SQLString = _
                "select " + _
                "[tbTaff].[name]," + _
                "[tbBorrow].[userid] ," + _
                "[tbBorrow].[bookid]," + _
                "[tbBook].[bookname]," + _
                "[tbBook].[ISBN]," + _
                "[tbBorrow].[borrowtime] " + _
                "from " + _
                "[tbBorrow],[tbTaff],[tbBook] " + _
                "where  " + _
                "[tbBorrow].[userid]='" & UserStr & "' and " + _
                "[tbBorrow].[userkind]=" & Kind & " and " + _
                "[tbBorrow].[userid]=[tbTaff].[userid] and " + _
                "[tbBorrow].[bookid]=[tbBook].[bookid] and" + _
                "[tbBorrow].borrowkind<>'预约'"
            End If
        End If

        Try
            Table = DBOperation.DBOperate(SQLString, "")
        Catch ex As Exception
            Return Nothing
        End Try
        Return Table
    End Function
    Shared Function SelectBookBorrow(ByVal bookid As String) As Boolean
        Dim Table As New DataTable
        Dim SQLString As String
        SQLString = _
        "select " + _
        "* " + _
        "from " + _
        "[tbBorrow] " + _
        "where  " + _
        "[tbBorrow].[bookid]='" & bookid.Trim & "'"
        Try
            Table = DBOperation.DBOperate(SQLString, "")
        Catch ex As Exception
            Return False
        End Try

        If Table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

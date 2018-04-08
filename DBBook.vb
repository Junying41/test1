Public Class DBBook
    Private _ISBN As String
    Private _BookID As String
    Private _BookName As String
    Private _Price As String
    Private _Author As String
    Private _Time As String
    Private _Remark As String
    Private _Station As String
    Property Station() As String
        Get
            Return _Station
        End Get
        Set(ByVal value As String)
            _Station = value
        End Set
    End Property
    Property ISBN() As String
        Get
            Return _ISBN
        End Get
        Set(ByVal value As String)
            _ISBN = value
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
    Property BookName() As String
        Get
            Return _BookName
        End Get
        Set(ByVal value As String)
            _BookName = value
        End Set
    End Property
    Property Price() As String
        Get
            Return _Price
        End Get
        Set(ByVal value As String)
            _Price = value
        End Set
    End Property
    Property Author() As String
        Get
            Return _Author
        End Get
        Set(ByVal value As String)
            _Author = value
        End Set
    End Property
    Property Time() As String
        Get
            Return _Time
        End Get
        Set(ByVal value As String)
            _Time = value
        End Set
    End Property
    Property Remark() As String
        Get
            Return _Remark
        End Get
        Set(ByVal value As String)
            _Remark = value
        End Set
    End Property
    Sub New(ByVal BookId As String, ByVal BookISBN As String)
        _BookID = BookId
        _ISBN = BookISBN
    End Sub
    '删除书目信息
    Friend Sub DelBook(ByVal DeleteBookID As String)
        Dim SQLString As String
        SQLString = "select" + _
                    " * " + _
                    "from " + _
                    "[tbBorrow] " + _
                    "where " + _
                    "[bookid]='" & DeleteBookID & "'"
        'DBBorrow .SelectBookBorrow 
        SQLString = "DELETE " + _
                    "FROM [tbBook]" + _
                    " WHERE " + _
                    "[bookid] ='" & DeleteBookID & "'"
        DBOperation.DBOperate(SQLString, "")
    End Sub

    '选择用户
    Public Function SelectBook(ByVal BookId As String) As DataTable
        Dim Sqlstr As String = "select  * from tbBook where bookid='" & BookId & "'"
        Return DBOperation.DBOperate(Sqlstr, "")
    End Function
    Function SelectBook(ByVal Kind As Integer, ByVal FindStr As String)
        Dim Sqlstr As String
        Sqlstr = "select  [bookid] as 书目ID,[bookname] as 书目名称,[ISBN] as ISBN号,[price] as 单价,[author] as 作者,[time] as 出版年份,[remark] as 备注,[station] as 状态一,[station1] as 状态二 from tbBook "
        Select Case Kind
            Case FindKind.BookAuthor
                Sqlstr += "where [author]='" & FindStr & "'"
            Case FindKind.BookId
                Sqlstr += "where [bookid]='" & FindStr & "'"
            Case FindKind.BookISBN
                Sqlstr += "where  [ISBN]='" & FindStr & "'"
            Case FindKind.BookName
                Sqlstr += "where [bookname]='" & FindStr & "'"
            Case FindKind.All '什么都不做
            Case FindKind.BookSuper
                Sqlstr = FindStr
        End Select
        Return DBOperation.DBOperate(Sqlstr, "")
    End Function
    '更新书目
    Friend Function UpdateBook(ByVal Book As DBBook) As Boolean
        Dim Sqlstr As String = "update [tbBook] set [ISBN]='" & Book.ISBN & "',[bookid]='" & Book.BookID & "' ,[bookname] ='" & Book.BookName & "', [price]='" & Book.Price & "',[author]='" & Book.Author & "',[time] ='" & Book.Time & "' ,[remark]='" & Book.Remark & "' where [bookid]='" & Book.BookID & "'"
        Try
            DBOperation.DBOperate(Sqlstr, "")
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Function UpdateBook(ByVal Book As DBBook, ByVal Str As String) As Boolean
        Dim Sqlstr As String = "update [tbBook] set [station1]='未预约' where [bookid]='" & Book.BookID & "'"
        Try
            DBOperation.DBOperate(Sqlstr, "")
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Friend Function UpdateBook(ByVal BookId As String, ByVal Station As String) As Boolean
        Dim Sqlstr As String
        If Station = "已预约" Or Station = "未预借" Then
            Sqlstr = "update [tbBook] set [station1]='" & Station & "' where [bookid]='" & BookId & "'"
        Else
            Sqlstr = "update [tbBook] set [station]='" & Station & "' where [bookid]='" & BookId & "'"
        End If
        Try
            DBOperation.DBOperate(Sqlstr, "")
        Catch ex As Exception
            Return False
        End Try
        Return True

    End Function

    '添加书目
    Friend Function AddBook(ByVal Book As DBBook) As Boolean
        Dim SQLString As String
        SQLString = "SELECT * FROM tbBook WHERE bookid='" & Book._BookID & " ' and ISBN='" & Book._ISBN & "'"
        Dim UserTable As DataTable = DBOperation.DBOperate(SQLString, "")
        If UserTable.Rows.Count >= 1 Then    '判断用户是否存在
            MsgBox("输入书目已存在，请重试", MsgBoxStyle.Exclamation, "信息框")
            Return False
        Else
            SQLString = "INSERT INTO [tbBook]([ISBN],[bookid],[bookname],[price],[author],[time],[remark],[station],[station1]) VALUES('" & Book._ISBN & "','" & Book._BookID & "','" & Book._BookName & "','" & Book._Price & "','" & Book._Author & "','" & Book.Time & "','" & Book._Remark & "','在馆可借','未预借')"

            DBOperation.DBOperate(SQLString, "")

            Return True
        End If
    End Function

End Class

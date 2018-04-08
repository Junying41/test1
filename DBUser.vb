Public Class DBUser
    Friend _UserName As String
    Friend _Password As String
    Friend _Right1 As String
    Friend _Right2 As String
    Friend _RealName As String
    Friend _Mail As String
    Friend _Birthday As Date
    Friend _Home As String
    Friend _Picture As String
    Property Picture() As String
        Get
            Return _Picture
        End Get
        Set(ByVal value As String)
            _Picture = value
        End Set
    End Property

    Friend Property UserID() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property
    Friend Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property
    Friend Property Right1() As String
        Get
            Return _Right1
        End Get
        Set(ByVal value As String)
            _Right1 = value
        End Set
    End Property
    Friend Property Right2() As String
        Get
            Return _Right2
        End Get
        Set(ByVal value As String)
            _Right2 = value
        End Set
    End Property
    Friend Property RealName() As String
        Get
            Return _RealName

        End Get
        Set(ByVal value As String)
            _RealName = value
        End Set
    End Property
    Friend Property Mail() As String
        Get
            Return _Mail
        End Get
        Set(ByVal value As String)
            _Mail = value
        End Set
    End Property
    Friend Property Birthday() As Date
        Get
            Return _Birthday
        End Get
        Set(ByVal value As Date)
            _Birthday = value
        End Set
    End Property
    Friend Property Home() As String
        Get
            Return _Home
        End Get
        Set(ByVal value As String)
            _Home = value
        End Set
    End Property

    Sub New(ByVal Name As String, ByVal PWD As String)
        _UserName = Name
        _Password = PWD
    End Sub

    '验证用户是否是合法的用户并记录用户信息
    Friend Function LoginConfirm() As Boolean
        Dim SQLString As String
        'SQL查询语句
        SQLString = "Select * from tbUser where userid='" & _UserName & "' AND pwd='" & _Password & "'"
        Dim UserTable As DataTable = DBOperation.DBOperate(SQLString, "")
        '判断用户是否存在
        If UserTable.Rows.Count = 0 Then
            Return False
        Else
            _RealName = UserTable.Rows(0)("name")
            _Right1 = UserTable.Rows(0)("right1")
            _Right2 = UserTable.Rows(0)("right2")
            Return True
        End If
    End Function

    '修改密码
    Friend Function ChangePwd(ByVal NewPassword As String) As Boolean
        Dim SQLString As String
        SQLString = "UPDATE tbUser SET pwd ='" & NewPassword & "' WHERE userid='" & _UserName & "'"
        DBOperation.DBOperate(SQLString, "")
    End Function

    '删除用户
    Friend Sub DelUser(ByVal DeleteUserName As String)
        Dim SQLString As String
        SQLString = "DELETE FROM tbUser WHERE userid ='" & DeleteUserName & "'"
        DBOperation.DBOperate(SQLString, "")
    End Sub
    '选择用户
    Public Function SelectUser(ByVal UserId As String) As DataTable
        Dim Sqlstr As String = "select name ,userid ,pwd , mail ,birthday,home from tbUser where userid='" & UserId & "'"
        Return DBOperation.DBOperate(Sqlstr, "")
    End Function
    '更新用户
    Friend Function UpdateUser(ByVal UserAdd As DBUser) As Boolean
        Dim Sqlstr As String = "update tbUser set name='" & UserAdd._RealName & "',userid='" & UserAdd.UserID & "' ,pwd ='" & UserAdd._Password & "', mail='" & UserAdd._Mail & "',birthday='" & UserAdd._Birthday & "',home ='" & UserAdd._Home & "' where userid='" & UserAdd.UserID & "'"
        Try
            DBOperation.DBOperate(Sqlstr, "")
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    '添加用户
    Friend Function AddUser(ByVal User As DBUser) As Boolean
        Dim SQLString As String
        SQLString = "SELECT * FROM tbUser WHERE userid='" & User.UserID & " '" 'AND Password='" & User.Password & "'"
        Dim UserTable As DataTable = DBOperation.DBOperate(SQLString, "")
        If UserTable.Rows.Count >= 1 Then    '判断用户是否存在
            MsgBox("输入用户名已存在，请重试", MsgBoxStyle.Exclamation, "信息框")
            Return False
        Else
            SQLString = "INSERT INTO tbUser(name,userid,pwd,mail,birthday,home,right1,right2) VALUES('" & User.RealName & "','" & User.UserID & "','" & User.Password & "','" & User.Mail & "','" & User.Birthday & "','" & User.Home & "','" & User.Right1 & "','" & User.Right2 & "')"

            DBOperation.DBOperate(SQLString, "")

            Return True
        End If
    End Function
    '验证邮箱
    Shared Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As _
            New System.Text.RegularExpressions.Regex( _
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As  _
            System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function


    '随机生成五位附加验证码A~Z
    Shared Function AttachCode() As String
        Dim TempCode As String = ""
        Dim randomvalue As Integer
        Dim I As Integer
        Randomize()
        For I = 1 To 5
            randomvalue = CInt(Int((90 - 65 + 1) * Rnd() + 65))
            TempCode = TempCode + Chr(randomvalue)
        Next
        Return TempCode
    End Function
End Class


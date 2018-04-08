Public Class DbTaff
    Inherits DBUser
    Public Sub New(ByVal UserID As String, ByVal UserPwd As String)
        MyBase.New(UserID, UserPwd)
    End Sub
    Overloads Function SelectUser(ByVal UserId As String) As DataTable
        Dim Sqlstr As String = "select * from tbTaff where userid='" & UserId & "'"
        Return DBOperation.DBOperate(Sqlstr, "")
    End Function
    Overloads Function LoginConfirm() As Boolean
        Dim SQLString As String
        'SQL查询语句
        SQLString = "Select * from tbTaff where userid='" & Taff.UserID & "' AND pwd='" & Taff.Password & "'"
        Dim UserTable As DataTable = DBOperation.DBOperate(SQLString, "")
        '判断用户是否存在
        If UserTable.Rows.Count = 0 Then
            Return False
        Else
            Taff.RealName = UserTable.Rows(0)("name")
            Taff.Right1 = UserTable.Rows(0)("right1")
            Taff.Right2 = UserTable.Rows(0)("right2")
            Taff.Mail = UserTable.Rows(0)("mail").ToString
            Taff.Picture = UserTable.Rows(0)("picture").ToString
            Return True
        End If
    End Function
    '更新用户
    Overloads Function UpdateUser(ByVal TaffEdit As DbTaff) As Boolean
        Dim Sqlstr As String = "update tbTaff set name='" & TaffEdit.RealName & " ',userid='" & TaffEdit.UserID & "' ,pwd ='" & TaffEdit.Password & "', mail='" & TaffEdit.Mail & " ',birthday='" & TaffEdit.Birthday & "',home ='" & TaffEdit.Home & "' ,right2='" & TaffEdit.Right2 & "' ,picture='" & TaffEdit.Picture & "' where userid='" & TaffEdit.UserID & "'"
        Try
            DBOperation.DBOperate(Sqlstr, "")
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    '删除用户
    Overloads Sub DelUser(ByVal DeleteUserName As String)
        Dim SQLString As String
        SQLString = "DELETE FROM tbTaff WHERE userid ='" & DeleteUserName & "'"
        DBOperation.DBOperate(SQLString, "")
    End Sub
    '修改密码
    Overloads Function ChangePwd(ByVal NewPassword As String) As Boolean
        Dim SQLString As String
        SQLString = "UPDATE tbTaff SET pwd ='" & NewPassword & "' WHERE userid='" & _UserName & "'"
        DBOperation.DBOperate(SQLString, "")
    End Function

    '添加用户
    Overloads Function AddUser(ByVal UserEidt As DbTaff) As Boolean
        Dim SQLString As String
        SQLString = "SELECT * FROM tbTaff WHERE userid='" & UserEidt.UserID & "'"
        Dim UserTable As DataTable = DBOperation.DBOperate(SQLString, "")

        If UserTable.Rows.Count >= 1 Then    '判断用户是否存在
            MsgBox("输入用户名已存在，请重试", MsgBoxStyle.Exclamation, "信息框")
            Return False
        Else

            SQLString = "INSERT INTO tbTaff(name,userid,pwd,mail,birthday,home,right1,right2,picture) VALUES('" & UserEidt.RealName & "','" & UserEidt.UserID & "','" & UserEidt.Password & "','" & UserEidt.Mail & "','" & UserEidt.Birthday & "','" & UserEidt.Home & "','" & UserEidt.Right1 & "','" & UserEidt.Right2 & "','" & UserEidt.Picture & "')"

            DBOperation.DBOperate(SQLString, "")

            Return True
        End If
    End Function
End Class

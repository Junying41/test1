'用户登陆时候表示登陆用户的类型
Enum OwerKind As Integer
    User = 1
    Taff = 2
End Enum

'编辑员工时候表示编辑命令方式
Enum EditKind As Integer
    Update = 1
    Insert = 2
    Other = 3
End Enum

'查找书目是表示查找的种类
Enum FindKind As Integer
    BookId = 1
    BookName = 2
    BookAuthor = 3
    BookISBN = 4
    All = 5
    BookSuper = 6
End Enum
'表示是预约还是借阅图书
Enum BorrowKind As Integer
    Borrow = 1
    BorrowAdvance = 2
End Enum

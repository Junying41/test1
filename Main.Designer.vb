<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Password")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add user")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("delete user")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit User")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User Manage", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("add staff")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("delete staff")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("edit staff")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Staff Manage", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("backup database")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("restore database")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System manager", 76, 64, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode5, TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("add books")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("edit books")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("delete books")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Book manage", 96, 86, New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Overlap")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Horizontal")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vertical")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arrange icon")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Close all windows")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Windows", 94, 97, New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("About")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Help", New System.Windows.Forms.TreeNode() {TreeNode23})
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.systemcontrolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueChangePwd = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueManageUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueAddUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueDeleteUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueSelectChangeUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueManageTaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueAddTaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueDeleteTaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueSelectChangeTaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menueDataBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueDataRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menueExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.librarymanageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueAddBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueChangBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueDeleteBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.libraryborrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueBorrow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.windowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueDie = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueHorizon = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueVertify = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueShowIcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.menueCloseAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueCloseLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueCloseTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueCloseStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menueAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmenueIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmenueClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenueHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenueRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusbar = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timerIco = New System.Windows.Forms.Timer(Me.components)
        Me.LeftPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.timerLeftPanel = New System.Windows.Forms.Timer(Me.components)
        Me.toolContainer = New System.Windows.Forms.ToolStripContainer()
        Me.toolbar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsChangPwd = New System.Windows.Forms.ToolStripButton()
        Me.tsManageUser = New System.Windows.Forms.ToolStripButton()
        Me.tsManageTaff = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddBook = New System.Windows.Forms.ToolStripButton()
        Me.tsChangeBook = New System.Windows.Forms.ToolStripButton()
        Me.tsDeleteBook = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBookFind = New System.Windows.Forms.ToolStripButton()
        Me.tsBookBorrow = New System.Windows.Forms.ToolStripButton()
        Me.tsReturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDie = New System.Windows.Forms.ToolStripButton()
        Me.tsHorizon = New System.Windows.Forms.ToolStripButton()
        Me.tsVertify = New System.Windows.Forms.ToolStripButton()
        Me.tsIcon = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsHelp = New System.Windows.Forms.ToolStripButton()
        Me.helper = New System.Windows.Forms.HelpProvider()
        Me.MenuStrip1.SuspendLayout()
        Me.cmenueIcon.SuspendLayout()
        Me.statusbar.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.toolContainer.ContentPanel.SuspendLayout()
        Me.toolContainer.SuspendLayout()
        Me.toolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "65.ico")
        Me.ImageList1.Images.SetKeyName(1, "cd1.ico")
        Me.ImageList1.Images.SetKeyName(2, "Book.ico")
        Me.ImageList1.Images.SetKeyName(3, "earth.ico")
        Me.ImageList1.Images.SetKeyName(4, "IMBigToolbarSendRing.ico")
        Me.ImageList1.Images.SetKeyName(5, "IMBigToolbarSendRing_Disabled.ico")
        Me.ImageList1.Images.SetKeyName(6, "keys.ico")
        Me.ImageList1.Images.SetKeyName(7, "My Documentsq.ico")
        Me.ImageList1.Images.SetKeyName(8, "MySite.ico")
        Me.ImageList1.Images.SetKeyName(9, "Networks.ico")
        Me.ImageList1.Images.SetKeyName(10, "QZoneDlgAddFriend.ico")
        Me.ImageList1.Images.SetKeyName(11, "QZoneDlgInfo.ico")
        Me.ImageList1.Images.SetKeyName(12, "REFBARH.ICO")
        Me.ImageList1.Images.SetKeyName(13, "SessionDlgFriend.ico")
        Me.ImageList1.Images.SetKeyName(14, "System Documents.ico")
        Me.ImageList1.Images.SetKeyName(15, "System Finder.ico")
        Me.ImageList1.Images.SetKeyName(16, "User.ico")
        Me.ImageList1.Images.SetKeyName(17, "users.ico")
        Me.ImageList1.Images.SetKeyName(18, "wmiinstance.ico")
        Me.ImageList1.Images.SetKeyName(19, "查询.ico")
        Me.ImageList1.Images.SetKeyName(20, "关闭.ico")
        Me.ImageList1.Images.SetKeyName(21, "康夫.ico")
        Me.ImageList1.Images.SetKeyName(22, "取消.ico")
        Me.ImageList1.Images.SetKeyName(23, "热舞派对.ico")
        Me.ImageList1.Images.SetKeyName(24, "删除.ico")
        Me.ImageList1.Images.SetKeyName(25, "添加.ico")
        Me.ImageList1.Images.SetKeyName(26, "统计.ico")
        Me.ImageList1.Images.SetKeyName(27, "退出.ico")
        Me.ImageList1.Images.SetKeyName(28, "项目.ico")
        Me.ImageList1.Images.SetKeyName(29, "小静.ico")
        Me.ImageList1.Images.SetKeyName(30, "小强.ico")
        Me.ImageList1.Images.SetKeyName(31, "用户.ico")
        Me.ImageList1.Images.SetKeyName(32, "CNFNOT.ICO")
        Me.ImageList1.Images.SetKeyName(33, "添加.ico")
        Me.ImageList1.Images.SetKeyName(34, "ContentsButton.ico")
        Me.ImageList1.Images.SetKeyName(35, "My Documentsq.ico")
        Me.ImageList1.Images.SetKeyName(36, "Networks.ico")
        Me.ImageList1.Images.SetKeyName(37, "PRIMARYKEY.ICO")
        Me.ImageList1.Images.SetKeyName(38, "Recycle Bin (empty)w.ico")
        Me.ImageList1.Images.SetKeyName(39, "SYSPARM.ICO")
        Me.ImageList1.Images.SetKeyName(40, "用户.ico")
        Me.ImageList1.Images.SetKeyName(41, "help.ico")
        Me.ImageList1.Images.SetKeyName(42, "MSGBOX02.ICO")
        Me.ImageList1.Images.SetKeyName(43, "System Computer.ico")
        Me.ImageList1.Images.SetKeyName(44, "Lock.ICO")
        Me.ImageList1.Images.SetKeyName(45, "Unlock.ICO")
        Me.ImageList1.Images.SetKeyName(46, "SNAPIN.ICO")
        Me.ImageList1.Images.SetKeyName(47, "verifydialog.ico")
        Me.ImageList1.Images.SetKeyName(48, "IconTrue.ico")
        Me.ImageList1.Images.SetKeyName(49, "IconFalse.ico")
        Me.ImageList1.Images.SetKeyName(50, "NOTE02.ICO")
        Me.ImageList1.Images.SetKeyName(51, "NOTE03.ICO")
        Me.ImageList1.Images.SetKeyName(52, "MISC20.ICO")
        Me.ImageList1.Images.SetKeyName(53, "BookIcon.ico")
        Me.ImageList1.Images.SetKeyName(54, "BookIcon21.ico")
        Me.ImageList1.Images.SetKeyName(55, "BookIconOne.ico")
        Me.ImageList1.Images.SetKeyName(56, "BookIconTow.ico")
        Me.ImageList1.Images.SetKeyName(57, "33.ico")
        Me.ImageList1.Images.SetKeyName(58, "65.ico")
        Me.ImageList1.Images.SetKeyName(59, "BookIconOne.ico")
        Me.ImageList1.Images.SetKeyName(60, "cd1.ico")
        Me.ImageList1.Images.SetKeyName(61, "CALC.ICO")
        Me.ImageList1.Images.SetKeyName(62, "CLIP06.ICO")
        Me.ImageList1.Images.SetKeyName(63, "CLIP07.ICO")
        Me.ImageList1.Images.SetKeyName(64, "accessories-text-editor.ico")
        Me.ImageList1.Images.SetKeyName(65, "aptanalogo.ico")
        Me.ImageList1.Images.SetKeyName(66, "arduino.ico")
        Me.ImageList1.Images.SetKeyName(67, "blender.ico")
        Me.ImageList1.Images.SetKeyName(68, "chrome-aohghmighlieiainnegkcijnfilokake-Default.ico")
        Me.ImageList1.Images.SetKeyName(69, "chrome-bjhodfififgcgedifpkenofdhlaafokk-Default.ico")
        Me.ImageList1.Images.SetKeyName(70, "chrome-hipbfijinpcgfogaopmgehiegacbhmob-Default.ico")
        Me.ImageList1.Images.SetKeyName(71, "chrome-mjcnijlhddpbdemagnpefmlkjdagkogk-Default.ico")
        Me.ImageList1.Images.SetKeyName(72, "chrome-nfakdllpdfjjbfommlcnfkedmbigkfdo-Default.ico")
        Me.ImageList1.Images.SetKeyName(73, "EasyTAG_icon.ico")
        Me.ImageList1.Images.SetKeyName(74, "finder.ico")
        Me.ImageList1.Images.SetKeyName(75, "postr.ico")
        Me.ImageList1.Images.SetKeyName(76, "system-users.ico")
        Me.ImageList1.Images.SetKeyName(77, "xnoise.ico")
        Me.ImageList1.Images.SetKeyName(78, "libreoffice-base.ico")
        Me.ImageList1.Images.SetKeyName(79, "activity-log-manager.ico")
        Me.ImageList1.Images.SetKeyName(80, "blender.ico")
        Me.ImageList1.Images.SetKeyName(81, "chrome-hipbfijinpcgfogaopmgehiegacbhmob-Default.ico")
        Me.ImageList1.Images.SetKeyName(82, "EasyTAG_icon.ico")
        Me.ImageList1.Images.SetKeyName(83, "flickr.ico")
        Me.ImageList1.Images.SetKeyName(84, "gnome-software.ico")
        Me.ImageList1.Images.SetKeyName(85, "help-info.ico")
        Me.ImageList1.Images.SetKeyName(86, "mdcharm.ico")
        Me.ImageList1.Images.SetKeyName(87, "netbeans.ico")
        Me.ImageList1.Images.SetKeyName(88, "slingscold.ico")
        Me.ImageList1.Images.SetKeyName(89, "system-file-manager.ico")
        Me.ImageList1.Images.SetKeyName(90, "typecatcher.ico")
        Me.ImageList1.Images.SetKeyName(91, "xnoise.ico")
        Me.ImageList1.Images.SetKeyName(92, "chrome-fjliknjliaohjgjajlgolhijphojjdkc-Default.ico")
        Me.ImageList1.Images.SetKeyName(93, "gnome-tweak-tool.ico")
        Me.ImageList1.Images.SetKeyName(94, "keepassx.ico")
        Me.ImageList1.Images.SetKeyName(95, "libreoffice-calc.ico")
        Me.ImageList1.Images.SetKeyName(96, "system-file-manager.ico")
        Me.ImageList1.Images.SetKeyName(97, "teamviewer.ico")
        Me.ImageList1.Images.SetKeyName(98, "gnome-software.ico")
        Me.ImageList1.Images.SetKeyName(99, "google-launcher.ico")
        Me.ImageList1.Images.SetKeyName(100, "transmission.ico")
        Me.ImageList1.Images.SetKeyName(101, "xchat.ico")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.systemcontrolToolStripMenuItem, Me.librarymanageToolStripMenuItem, Me.libraryborrowToolStripMenuItem, Me.windowsToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'systemcontrolToolStripMenuItem
        '
        Me.systemcontrolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menueChangePwd, Me.menueManageUser, Me.menueManageTaff, Me.ToolStripSeparator1, Me.menueDataBackup, Me.menueDataRestore, Me.ToolStripSeparator2, Me.menueExit})
        Me.systemcontrolToolStripMenuItem.Name = "systemcontrolToolStripMenuItem"
        Me.systemcontrolToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.systemcontrolToolStripMenuItem.Text = "System Control(&M)"
        '
        'menueChangePwd
        '
        Me.menueChangePwd.Name = "menueChangePwd"
        Me.menueChangePwd.Size = New System.Drawing.Size(168, 22)
        Me.menueChangePwd.Text = "Change Password"
        '
        'menueManageUser
        '
        Me.menueManageUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menueAddUser, Me.menueDeleteUser, Me.menueSelectChangeUser})
        Me.menueManageUser.Name = "menueManageUser"
        Me.menueManageUser.Size = New System.Drawing.Size(168, 22)
        Me.menueManageUser.Text = "User Manage"
        '
        'menueAddUser
        '
        Me.menueAddUser.Name = "menueAddUser"
        Me.menueAddUser.Size = New System.Drawing.Size(133, 22)
        Me.menueAddUser.Text = "Add User"
        Me.menueAddUser.ToolTipText = "添加用户"
        '
        'menueDeleteUser
        '
        Me.menueDeleteUser.Name = "menueDeleteUser"
        Me.menueDeleteUser.Size = New System.Drawing.Size(133, 22)
        Me.menueDeleteUser.Text = "Delete User"
        Me.menueDeleteUser.ToolTipText = "删除用户"
        '
        'menueSelectChangeUser
        '
        Me.menueSelectChangeUser.Name = "menueSelectChangeUser"
        Me.menueSelectChangeUser.Size = New System.Drawing.Size(133, 22)
        Me.menueSelectChangeUser.Text = "Edit User"
        Me.menueSelectChangeUser.ToolTipText = "查询编辑用户"
        '
        'menueManageTaff
        '
        Me.menueManageTaff.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menueAddTaff, Me.menueDeleteTaff, Me.menueSelectChangeTaff})
        Me.menueManageTaff.Name = "menueManageTaff"
        Me.menueManageTaff.Size = New System.Drawing.Size(168, 22)
        Me.menueManageTaff.Text = "Staff Manage"
        '
        'menueAddTaff
        '
        Me.menueAddTaff.Name = "menueAddTaff"
        Me.menueAddTaff.Size = New System.Drawing.Size(134, 22)
        Me.menueAddTaff.Text = "Add Staff"
        Me.menueAddTaff.ToolTipText = "添加员工"
        '
        'menueDeleteTaff
        '
        Me.menueDeleteTaff.Name = "menueDeleteTaff"
        Me.menueDeleteTaff.Size = New System.Drawing.Size(134, 22)
        Me.menueDeleteTaff.Text = "Delete Staff"
        Me.menueDeleteTaff.ToolTipText = "删除员工"
        '
        'menueSelectChangeTaff
        '
        Me.menueSelectChangeTaff.Name = "menueSelectChangeTaff"
        Me.menueSelectChangeTaff.Size = New System.Drawing.Size(134, 22)
        Me.menueSelectChangeTaff.Text = "Edit Staff"
        Me.menueSelectChangeTaff.ToolTipText = "查找编辑员工"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'menueDataBackup
        '
        Me.menueDataBackup.Name = "menueDataBackup"
        Me.menueDataBackup.Size = New System.Drawing.Size(168, 22)
        Me.menueDataBackup.Text = "Backup Database"
        '
        'menueDataRestore
        '
        Me.menueDataRestore.Name = "menueDataRestore"
        Me.menueDataRestore.Size = New System.Drawing.Size(168, 22)
        Me.menueDataRestore.Text = "Restore Database"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'menueExit
        '
        Me.menueExit.Name = "menueExit"
        Me.menueExit.Size = New System.Drawing.Size(168, 22)
        Me.menueExit.Text = "&Quit"
        '
        'librarymanageToolStripMenuItem
        '
        Me.librarymanageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menueAddBook, Me.menueChangBook, Me.menueDeleteBook})
        Me.librarymanageToolStripMenuItem.Name = "librarymanageToolStripMenuItem"
        Me.librarymanageToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.librarymanageToolStripMenuItem.Text = "Library Manage(&T)"
        '
        'menueAddBook
        '
        Me.menueAddBook.Name = "menueAddBook"
        Me.menueAddBook.Size = New System.Drawing.Size(152, 22)
        Me.menueAddBook.Text = "Add Books"
        '
        'menueChangBook
        '
        Me.menueChangBook.Name = "menueChangBook"
        Me.menueChangBook.Size = New System.Drawing.Size(152, 22)
        Me.menueChangBook.Text = "Edit Books"
        '
        'menueDeleteBook
        '
        Me.menueDeleteBook.Name = "menueDeleteBook"
        Me.menueDeleteBook.Size = New System.Drawing.Size(152, 22)
        Me.menueDeleteBook.Text = "Delete Books"
        '
        'libraryborrowToolStripMenuItem
        '
        Me.libraryborrowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menueFind, Me.menueBorrow, Me.ToolStripSeparator3})
        Me.libraryborrowToolStripMenuItem.Name = "libraryborrowToolStripMenuItem"
        Me.libraryborrowToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.libraryborrowToolStripMenuItem.Text = "Library Borrow(&B)"
        '
        'menueFind
        '
        Me.menueFind.Name = "menueFind"
        Me.menueFind.Size = New System.Drawing.Size(152, 22)
        Me.menueFind.Text = "Book Seek"
        Me.menueFind.ToolTipText = "图书查询"
        '
        'menueBorrow
        '
        Me.menueBorrow.Name = "menueBorrow"
        Me.menueBorrow.Size = New System.Drawing.Size(152, 22)
        Me.menueBorrow.Text = "Book Borrow"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'windowsToolStripMenuItem
        '
        Me.windowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menueDie, Me.menueHorizon, Me.menueVertify, Me.menueShowIcon, Me.ToolStripSeparator6, Me.menueCloseAll, Me.menueCloseLeft, Me.menueCloseTool, Me.menueCloseStatus})
        Me.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem"
        Me.windowsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.windowsToolStripMenuItem.Text = "Windows(&W)"
        '
        'menueDie
        '
        Me.menueDie.Name = "menueDie"
        Me.menueDie.Size = New System.Drawing.Size(168, 22)
        Me.menueDie.Text = "Overlap"
        Me.menueDie.ToolTipText = "Overlap"
        '
        'menueHorizon
        '
        Me.menueHorizon.Name = "menueHorizon"
        Me.menueHorizon.Size = New System.Drawing.Size(168, 22)
        Me.menueHorizon.Text = "Horizontally"
        Me.menueHorizon.ToolTipText = "Horizontally"
        '
        'menueVertify
        '
        Me.menueVertify.Name = "menueVertify"
        Me.menueVertify.Size = New System.Drawing.Size(168, 22)
        Me.menueVertify.Text = "Vertical"
        Me.menueVertify.ToolTipText = "Vertically"
        '
        'menueShowIcon
        '
        Me.menueShowIcon.Name = "menueShowIcon"
        Me.menueShowIcon.Size = New System.Drawing.Size(168, 22)
        Me.menueShowIcon.Text = "Arrange icon"
        Me.menueShowIcon.ToolTipText = "Arrange icon"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(165, 6)
        '
        'menueCloseAll
        '
        Me.menueCloseAll.Name = "menueCloseAll"
        Me.menueCloseAll.Size = New System.Drawing.Size(168, 22)
        Me.menueCloseAll.Text = "Close all windows"
        Me.menueCloseAll.ToolTipText = "关闭所有子窗体"
        '
        'menueCloseLeft
        '
        Me.menueCloseLeft.Name = "menueCloseLeft"
        Me.menueCloseLeft.Size = New System.Drawing.Size(168, 22)
        Me.menueCloseLeft.Text = "Close left bar"
        Me.menueCloseLeft.ToolTipText = "关闭左侧栏"
        '
        'menueCloseTool
        '
        Me.menueCloseTool.Name = "menueCloseTool"
        Me.menueCloseTool.Size = New System.Drawing.Size(168, 22)
        Me.menueCloseTool.Text = "Close toolbar"
        Me.menueCloseTool.ToolTipText = "Close toolbar"
        '
        'menueCloseStatus
        '
        Me.menueCloseStatus.Name = "menueCloseStatus"
        Me.menueCloseStatus.Size = New System.Drawing.Size(168, 22)
        Me.menueCloseStatus.Text = "Clase all tabs"
        Me.menueCloseStatus.ToolTipText = "Close all tabs"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menueHelp, Me.menueAbout})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.helpToolStripMenuItem.Text = "Help  (&H)"
        '
        'menueHelp
        '
        Me.menueHelp.Image = Global.LibraryManage.My.Resources.Resources.help7
        Me.menueHelp.Name = "menueHelp"
        Me.menueHelp.Size = New System.Drawing.Size(152, 22)
        Me.menueHelp.Text = "Help Uubject"
        '
        'menueAbout
        '
        Me.menueAbout.Name = "menueAbout"
        Me.menueAbout.Size = New System.Drawing.Size(152, 22)
        Me.menueAbout.Text = "About"
        '
        'ntIcon
        '
        Me.ntIcon.ContextMenuStrip = Me.cmenueIcon
        Me.ntIcon.Tag = "图书管理系统"
        Me.ntIcon.Text = "图书管理系统"
        Me.ntIcon.Visible = True
        '
        'cmenueIcon
        '
        Me.cmenueIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmenueClose, Me.tsmenueHide, Me.tsmenueRestore})
        Me.cmenueIcon.Name = "ContextMenuStrip1"
        Me.cmenueIcon.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmenueIcon.Size = New System.Drawing.Size(135, 70)
        '
        'tsmenueClose
        '
        Me.tsmenueClose.Name = "tsmenueClose"
        Me.tsmenueClose.Size = New System.Drawing.Size(134, 22)
        Me.tsmenueClose.Text = "关闭系统"
        '
        'tsmenueHide
        '
        Me.tsmenueHide.Name = "tsmenueHide"
        Me.tsmenueHide.Size = New System.Drawing.Size(134, 22)
        Me.tsmenueHide.Text = "缩小道托盘"
        '
        'tsmenueRestore
        '
        Me.tsmenueRestore.Name = "tsmenueRestore"
        Me.tsmenueRestore.Size = New System.Drawing.Size(134, 22)
        Me.tsmenueRestore.Text = "还原"
        '
        'statusbar
        '
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.statusTime})
        Me.statusbar.Location = New System.Drawing.Point(0, 740)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(984, 22)
        Me.statusbar.TabIndex = 4
        Me.statusbar.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(913, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Welcome"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel2.Text = "-"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel3.Text = "-"
        '
        'statusTime
        '
        Me.statusTime.Name = "statusTime"
        Me.statusTime.Size = New System.Drawing.Size(32, 17)
        Me.statusTime.Text = "Now"
        '
        'timerIco
        '
        Me.timerIco.Enabled = True
        Me.timerIco.Interval = 1000
        '
        'LeftPanel
        '
        Me.LeftPanel.ColumnCount = 1
        Me.LeftPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LeftPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LeftPanel.Controls.Add(Me.TreeView1, 0, 1)
        Me.LeftPanel.Controls.Add(Me.Panel2, 0, 0)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 55)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.RowCount = 2
        Me.LeftPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.928854!))
        Me.LeftPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.07114!))
        Me.LeftPanel.Size = New System.Drawing.Size(230, 685)
        Me.LeftPanel.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.Gainsboro
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ForeColor = System.Drawing.Color.Black
        Me.TreeView1.ImageIndex = 63
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.LineColor = System.Drawing.Color.Maroon
        Me.TreeView1.Location = New System.Drawing.Point(3, 43)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 94
        TreeNode1.Name = "nodeChangPwd"
        TreeNode1.Text = "Change Password"
        TreeNode1.ToolTipText = "Change password"
        TreeNode2.ImageIndex = 75
        TreeNode2.Name = "nodeAddUser"
        TreeNode2.Text = "Add user"
        TreeNode2.ToolTipText = "Add user"
        TreeNode3.ImageIndex = 91
        TreeNode3.Name = "nodeDeleteUser"
        TreeNode3.Text = "delete user"
        TreeNode3.ToolTipText = "delete user"
        TreeNode4.ImageIndex = 67
        TreeNode4.Name = "nodeSelectChangeUser"
        TreeNode4.Text = "Edit User"
        TreeNode4.ToolTipText = "Edit user"
        TreeNode5.ImageIndex = 74
        TreeNode5.Name = "nodeManageUser"
        TreeNode5.Text = "User Manage"
        TreeNode5.ToolTipText = "User manage"
        TreeNode6.ImageIndex = 18
        TreeNode6.Name = "nodeAddTaff"
        TreeNode6.Text = "add staff"
        TreeNode6.ToolTipText = "add staff"
        TreeNode7.ImageIndex = 18
        TreeNode7.Name = "nodeDeleteTaff"
        TreeNode7.Text = "delete staff"
        TreeNode7.ToolTipText = "delete staff"
        TreeNode8.ImageIndex = 18
        TreeNode8.Name = "nodeSelectChangeTaff"
        TreeNode8.Text = "edit staff"
        TreeNode8.ToolTipText = "edit staff"
        TreeNode9.ImageIndex = 76
        TreeNode9.Name = "nodeManageTaff"
        TreeNode9.Text = "Staff Manage"
        TreeNode9.ToolTipText = "staff manage"
        TreeNode10.ImageIndex = 78
        TreeNode10.Name = "nodeDataBackup"
        TreeNode10.Text = "backup database"
        TreeNode10.ToolTipText = "backup database"
        TreeNode11.ImageIndex = 78
        TreeNode11.Name = "nodeDataRestore"
        TreeNode11.Text = "restore database"
        TreeNode11.ToolTipText = "restore database"
        TreeNode12.ImageIndex = 76
        TreeNode12.Name = "nodeSystem"
        TreeNode12.SelectedImageIndex = 64
        TreeNode12.Text = "System manager"
        TreeNode12.ToolTipText = "System Manage"
        TreeNode13.ImageIndex = 90
        TreeNode13.Name = "nodeAddBook"
        TreeNode13.Text = "add books"
        TreeNode13.ToolTipText = "添加图书"
        TreeNode14.ImageIndex = 88
        TreeNode14.Name = "nodeChangeBook"
        TreeNode14.Text = "edit books"
        TreeNode14.ToolTipText = "edit books"
        TreeNode15.ImageIndex = 77
        TreeNode15.Name = "nodeDelteBook"
        TreeNode15.Text = "delete books"
        TreeNode15.ToolTipText = "delete books"
        TreeNode16.ImageIndex = 96
        TreeNode16.Name = "nodeBook"
        TreeNode16.SelectedImageIndex = 86
        TreeNode16.Text = "Book manage"
        TreeNode16.ToolTipText = "Book manage"
        TreeNode17.ImageIndex = 99
        TreeNode17.Name = "nodeWindowDie"
        TreeNode17.Text = "Overlap"
        TreeNode17.ToolTipText = "Overlap"
        TreeNode18.ImageIndex = 99
        TreeNode18.Name = "nodeWindowHorizon"
        TreeNode18.Text = "Horizontal"
        TreeNode18.ToolTipText = "Horizontal"
        TreeNode19.ImageIndex = 100
        TreeNode19.Name = "nodeWindowVertify"
        TreeNode19.Text = "Vertical"
        TreeNode19.ToolTipText = "Vertical"
        TreeNode20.ImageIndex = 98
        TreeNode20.Name = "nodeWindowIcon"
        TreeNode20.Text = "Arrange icon"
        TreeNode20.ToolTipText = "Arrange icon"
        TreeNode21.ImageIndex = 101
        TreeNode21.Name = "nodeWindowColse"
        TreeNode21.Text = "Close all windows"
        TreeNode21.ToolTipText = "Close all windows"
        TreeNode22.ImageIndex = 94
        TreeNode22.Name = "nodeForm"
        TreeNode22.SelectedImageIndex = 97
        TreeNode22.Text = "Windows"
        TreeNode22.ToolTipText = "Windows"
        TreeNode23.ImageIndex = 85
        TreeNode23.Name = "nodeAbout"
        TreeNode23.Text = "About"
        TreeNode23.ToolTipText = "About"
        TreeNode24.ImageIndex = 81
        TreeNode24.Name = "nodeHelp"
        TreeNode24.Text = "Help"
        TreeNode24.ToolTipText = "Help"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode16, TreeNode22, TreeNode24})
        Me.TreeView1.SelectedImageIndex = 57
        Me.TreeView1.Size = New System.Drawing.Size(224, 639)
        Me.TreeView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnLock)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 34)
        Me.Panel2.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.ImageIndex = 59
        Me.btnClose.ImageList = Me.ImageList1
        Me.btnClose.Location = New System.Drawing.Point(192, -1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 35)
        Me.btnClose.TabIndex = 3
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.Transparent
        Me.btnLock.Image = Global.LibraryManage.My.Resources.Resources.klavaro
        Me.btnLock.Location = New System.Drawing.Point(154, -1)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(32, 35)
        Me.btnLock.TabIndex = 2
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'timerLeftPanel
        '
        Me.timerLeftPanel.Enabled = True
        Me.timerLeftPanel.Interval = 15
        '
        'toolContainer
        '
        Me.toolContainer.BottomToolStripPanelVisible = False
        '
        'toolContainer.ContentPanel
        '
        Me.toolContainer.ContentPanel.Controls.Add(Me.toolbar)
        Me.toolContainer.ContentPanel.Controls.Add(Me.MenuStrip1)
        Me.toolContainer.ContentPanel.Size = New System.Drawing.Size(984, 55)
        Me.toolContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolContainer.LeftToolStripPanelVisible = False
        Me.toolContainer.Location = New System.Drawing.Point(0, 0)
        Me.toolContainer.Name = "toolContainer"
        Me.toolContainer.RightToolStripPanelVisible = False
        Me.toolContainer.Size = New System.Drawing.Size(984, 55)
        Me.toolContainer.TabIndex = 8
        Me.toolContainer.Text = "ToolStripContainer1"
        '
        'toolbar
        '
        Me.toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.tsChangPwd, Me.tsManageUser, Me.tsManageTaff, Me.ToolStripSeparator5, Me.tsAddBook, Me.tsChangeBook, Me.tsDeleteBook, Me.ToolStripSeparator7, Me.tsBookFind, Me.tsBookBorrow, Me.tsReturn, Me.ToolStripSeparator8, Me.tsDie, Me.tsHorizon, Me.tsVertify, Me.tsIcon, Me.ToolStripSeparator9, Me.tsHelp})
        Me.toolbar.Location = New System.Drawing.Point(0, 24)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.toolbar.Size = New System.Drawing.Size(984, 31)
        Me.toolbar.TabIndex = 6
        Me.toolbar.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'tsChangPwd
        '
        Me.tsChangPwd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsChangPwd.Image = Global.LibraryManage.My.Resources.Resources.bleachbit
        Me.tsChangPwd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsChangPwd.Name = "tsChangPwd"
        Me.tsChangPwd.Size = New System.Drawing.Size(28, 28)
        Me.tsChangPwd.Text = "修改密码"
        Me.tsChangPwd.ToolTipText = "修改密码"
        '
        'tsManageUser
        '
        Me.tsManageUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsManageUser.Image = Global.LibraryManage.My.Resources.Resources.android
        Me.tsManageUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsManageUser.Name = "tsManageUser"
        Me.tsManageUser.Size = New System.Drawing.Size(28, 28)
        Me.tsManageUser.Text = "用户管理"
        Me.tsManageUser.ToolTipText = "用户管理"
        '
        'tsManageTaff
        '
        Me.tsManageTaff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsManageTaff.Image = Global.LibraryManage.My.Resources.Resources.chrome
        Me.tsManageTaff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsManageTaff.Name = "tsManageTaff"
        Me.tsManageTaff.Size = New System.Drawing.Size(28, 28)
        Me.tsManageTaff.Text = "员工管理"
        Me.tsManageTaff.ToolTipText = "员工管理"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'tsAddBook
        '
        Me.tsAddBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsAddBook.Image = Global.LibraryManage.My.Resources.Resources.system1
        Me.tsAddBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddBook.Name = "tsAddBook"
        Me.tsAddBook.Size = New System.Drawing.Size(28, 28)
        Me.tsAddBook.Text = "添加图书"
        '
        'tsChangeBook
        '
        Me.tsChangeBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsChangeBook.Image = Global.LibraryManage.My.Resources.Resources.onboard
        Me.tsChangeBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsChangeBook.Name = "tsChangeBook"
        Me.tsChangeBook.Size = New System.Drawing.Size(28, 28)
        Me.tsChangeBook.Text = "修改图书"
        '
        'tsDeleteBook
        '
        Me.tsDeleteBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsDeleteBook.Image = Global.LibraryManage.My.Resources.Resources.scanner
        Me.tsDeleteBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteBook.Name = "tsDeleteBook"
        Me.tsDeleteBook.Size = New System.Drawing.Size(28, 28)
        Me.tsDeleteBook.Text = "删除图书"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 31)
        '
        'tsBookFind
        '
        Me.tsBookFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBookFind.Image = Global.LibraryManage.My.Resources.Resources.brackets
        Me.tsBookFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBookFind.Name = "tsBookFind"
        Me.tsBookFind.Size = New System.Drawing.Size(28, 28)
        Me.tsBookFind.Text = "图书查询"
        '
        'tsBookBorrow
        '
        Me.tsBookBorrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBookBorrow.Image = Global.LibraryManage.My.Resources.Resources.chrome2
        Me.tsBookBorrow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBookBorrow.Name = "tsBookBorrow"
        Me.tsBookBorrow.Size = New System.Drawing.Size(28, 28)
        Me.tsBookBorrow.Text = "图书借阅"
        '
        'tsReturn
        '
        Me.tsReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsReturn.Image = Global.LibraryManage.My.Resources.Resources.chrome1
        Me.tsReturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReturn.Name = "tsReturn"
        Me.tsReturn.Size = New System.Drawing.Size(28, 28)
        Me.tsReturn.Text = "图书归还"
        Me.tsReturn.ToolTipText = "图书归还"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'tsDie
        '
        Me.tsDie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsDie.Image = Global.LibraryManage.My.Resources.Resources.preferences1
        Me.tsDie.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDie.Name = "tsDie"
        Me.tsDie.Size = New System.Drawing.Size(28, 28)
        Me.tsDie.Text = "窗体重叠"
        Me.tsDie.ToolTipText = "窗体重叠"
        '
        'tsHorizon
        '
        Me.tsHorizon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsHorizon.Image = Global.LibraryManage.My.Resources.Resources.chrome3
        Me.tsHorizon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHorizon.Name = "tsHorizon"
        Me.tsHorizon.Size = New System.Drawing.Size(28, 28)
        Me.tsHorizon.Text = "窗口水平平铺"
        Me.tsHorizon.ToolTipText = "窗口水平平铺"
        '
        'tsVertify
        '
        Me.tsVertify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsVertify.Image = Global.LibraryManage.My.Resources.Resources.transmission
        Me.tsVertify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsVertify.Name = "tsVertify"
        Me.tsVertify.Size = New System.Drawing.Size(28, 28)
        Me.tsVertify.Text = "窗口垂直平铺"
        Me.tsVertify.ToolTipText = "窗口垂直平铺"
        '
        'tsIcon
        '
        Me.tsIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsIcon.Image = Global.LibraryManage.My.Resources.Resources.gnome5
        Me.tsIcon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsIcon.Name = "tsIcon"
        Me.tsIcon.Size = New System.Drawing.Size(28, 28)
        Me.tsIcon.Text = "排列图标"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 31)
        '
        'tsHelp
        '
        Me.tsHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsHelp.Image = Global.LibraryManage.My.Resources.Resources.help6
        Me.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHelp.Name = "tsHelp"
        Me.tsHelp.Size = New System.Drawing.Size(28, 28)
        Me.tsHelp.Text = "帮助"
        Me.tsHelp.ToolTipText = "帮助"
        '
        'helper
        '
        Me.helper.HelpNamespace = ".\Help.html"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(984, 762)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.toolContainer)
        Me.Controls.Add(Me.statusbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.helper.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Manage System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.cmenueIcon.ResumeLayout(False)
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.LeftPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.toolContainer.ContentPanel.ResumeLayout(False)
        Me.toolContainer.ContentPanel.PerformLayout()
        Me.toolContainer.ResumeLayout(False)
        Me.toolContainer.PerformLayout()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents systemcontrolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueChangePwd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueManageUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueManageTaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menueDataBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueDataRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menueExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents librarymanageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueAddBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueChangBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents libraryborrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueBorrow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents windowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueDie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueHorizon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueVertify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueCloseAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
    Friend WithEvents timerIco As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsChangPwd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsManageUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsManageTaff As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddBook As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsChangeBook As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDeleteBook As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsBookFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBookBorrow As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsReturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDie As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsHorizon As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsVertify As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsIcon As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menueCloseLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LeftPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents timerLeftPanel As System.Windows.Forms.Timer
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

    Friend WithEvents menueDeleteBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmenueIcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmenueClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenueHide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenueRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents menueShowIcon As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents menueAddTaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueDeleteTaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueSelectChangeTaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueAddUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueDeleteUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueSelectChangeUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueFind As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents menueCloseTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menueCloseStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helper As System.Windows.Forms.HelpProvider


End Class

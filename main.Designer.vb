<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewAuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublisherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewPublisherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPublisherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletePublisherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutLibraryManagmentSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrationToolStripMenuItem, Me.MemberToolStripMenuItem, Me.BookToolStripMenuItem, Me.BorrowToolStripMenuItem, Me.AuthorToolStripMenuItem, Me.PublisherToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(955, 47)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate
        Me.AdministrationToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Font = New System.Drawing.Font("Sitka Heading", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(209, 43)
        Me.AdministrationToolStripMenuItem.Text = "Administration"
        '
        'OrganizationToolStripMenuItem
        '
        Me.OrganizationToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.OrganizationToolStripMenuItem.Name = "OrganizationToolStripMenuItem"
        Me.OrganizationToolStripMenuItem.Size = New System.Drawing.Size(249, 44)
        Me.OrganizationToolStripMenuItem.Text = "Organization"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(249, 44)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange
        Me.MemberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewMemberToolStripMenuItem, Me.EditMemberToolStripMenuItem, Me.DeleteMemberToolStripMenuItem})
        Me.MemberToolStripMenuItem.Font = New System.Drawing.Font("Sitka Heading", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberToolStripMenuItem.ForeColor = System.Drawing.Color.ForestGreen
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(124, 43)
        Me.MemberToolStripMenuItem.Text = "Member"
        '
        'AddNewMemberToolStripMenuItem
        '
        Me.AddNewMemberToolStripMenuItem.Name = "AddNewMemberToolStripMenuItem"
        Me.AddNewMemberToolStripMenuItem.Size = New System.Drawing.Size(301, 44)
        Me.AddNewMemberToolStripMenuItem.Text = "Add New Member"
        '
        'EditMemberToolStripMenuItem
        '
        Me.EditMemberToolStripMenuItem.Name = "EditMemberToolStripMenuItem"
        Me.EditMemberToolStripMenuItem.Size = New System.Drawing.Size(301, 44)
        Me.EditMemberToolStripMenuItem.Text = "Edit Member"
        '
        'DeleteMemberToolStripMenuItem
        '
        Me.DeleteMemberToolStripMenuItem.Name = "DeleteMemberToolStripMenuItem"
        Me.DeleteMemberToolStripMenuItem.Size = New System.Drawing.Size(301, 44)
        Me.DeleteMemberToolStripMenuItem.Text = "Delete Member"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.BookToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewBookToolStripMenuItem, Me.EditBookToolStripMenuItem, Me.DeleteBookToolStripMenuItem})
        Me.BookToolStripMenuItem.Font = New System.Drawing.Font("Sitka Heading", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(88, 43)
        Me.BookToolStripMenuItem.Text = "Book"
        '
        'AddNewBookToolStripMenuItem
        '
        Me.AddNewBookToolStripMenuItem.Name = "AddNewBookToolStripMenuItem"
        Me.AddNewBookToolStripMenuItem.Size = New System.Drawing.Size(265, 44)
        Me.AddNewBookToolStripMenuItem.Text = "Add New Book"
        '
        'EditBookToolStripMenuItem
        '
        Me.EditBookToolStripMenuItem.Name = "EditBookToolStripMenuItem"
        Me.EditBookToolStripMenuItem.Size = New System.Drawing.Size(265, 44)
        Me.EditBookToolStripMenuItem.Text = "Edit Book"
        '
        'DeleteBookToolStripMenuItem
        '
        Me.DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem"
        Me.DeleteBookToolStripMenuItem.Size = New System.Drawing.Size(265, 44)
        Me.DeleteBookToolStripMenuItem.Text = "Delete Book"
        '
        'BorrowToolStripMenuItem
        '
        Me.BorrowToolStripMenuItem.BackColor = System.Drawing.Color.Lime
        Me.BorrowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BooksToolStripMenuItem})
        Me.BorrowToolStripMenuItem.Font = New System.Drawing.Font("Sitka Heading", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowToolStripMenuItem.ForeColor = System.Drawing.Color.DarkViolet
        Me.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem"
        Me.BorrowToolStripMenuItem.Size = New System.Drawing.Size(125, 43)
        Me.BorrowToolStripMenuItem.Text = "Borrow "
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(165, 44)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'AuthorToolStripMenuItem
        '
        Me.AuthorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AuthorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewAuthorToolStripMenuItem, Me.DeleteAuthorToolStripMenuItem})
        Me.AuthorToolStripMenuItem.Font = New System.Drawing.Font("Sitka Heading", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        Me.AuthorToolStripMenuItem.Size = New System.Drawing.Size(112, 43)
        Me.AuthorToolStripMenuItem.Text = "Author"
        '
        'AddNewAuthorToolStripMenuItem
        '
        Me.AddNewAuthorToolStripMenuItem.Name = "AddNewAuthorToolStripMenuItem"
        Me.AddNewAuthorToolStripMenuItem.Size = New System.Drawing.Size(289, 44)
        Me.AddNewAuthorToolStripMenuItem.Text = "Add New Author"
        '
        'DeleteAuthorToolStripMenuItem
        '
        Me.DeleteAuthorToolStripMenuItem.Name = "DeleteAuthorToolStripMenuItem"
        Me.DeleteAuthorToolStripMenuItem.Size = New System.Drawing.Size(289, 44)
        Me.DeleteAuthorToolStripMenuItem.Text = "Delete Author"
        '
        'PublisherToolStripMenuItem
        '
        Me.PublisherToolStripMenuItem.BackColor = System.Drawing.Color.Cyan
        Me.PublisherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewPublisherToolStripMenuItem, Me.EditPublisherToolStripMenuItem, Me.DeletePublisherToolStripMenuItem})
        Me.PublisherToolStripMenuItem.Font = New System.Drawing.Font("Sitka Heading", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan
        Me.PublisherToolStripMenuItem.Name = "PublisherToolStripMenuItem"
        Me.PublisherToolStripMenuItem.Size = New System.Drawing.Size(140, 43)
        Me.PublisherToolStripMenuItem.Text = "Publisher"
        '
        'AddNewPublisherToolStripMenuItem
        '
        Me.AddNewPublisherToolStripMenuItem.Name = "AddNewPublisherToolStripMenuItem"
        Me.AddNewPublisherToolStripMenuItem.Size = New System.Drawing.Size(317, 44)
        Me.AddNewPublisherToolStripMenuItem.Text = "Add New Publisher"
        '
        'EditPublisherToolStripMenuItem
        '
        Me.EditPublisherToolStripMenuItem.Name = "EditPublisherToolStripMenuItem"
        Me.EditPublisherToolStripMenuItem.Size = New System.Drawing.Size(317, 44)
        Me.EditPublisherToolStripMenuItem.Text = "Edit Publisher"
        '
        'DeletePublisherToolStripMenuItem
        '
        Me.DeletePublisherToolStripMenuItem.Name = "DeletePublisherToolStripMenuItem"
        Me.DeletePublisherToolStripMenuItem.Size = New System.Drawing.Size(317, 44)
        Me.DeletePublisherToolStripMenuItem.Text = "Delete publisher"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Orange
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutLibraryManagmentSystemToolStripMenuItem, Me.ContactUsToolStripMenuItem, Me.DocumentationToolStripMenuItem, Me.TutorialToolStripMenuItem, Me.ActivateToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Sitka Heading", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(84, 43)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutLibraryManagmentSystemToolStripMenuItem
        '
        Me.AboutLibraryManagmentSystemToolStripMenuItem.Name = "AboutLibraryManagmentSystemToolStripMenuItem"
        Me.AboutLibraryManagmentSystemToolStripMenuItem.Size = New System.Drawing.Size(512, 44)
        Me.AboutLibraryManagmentSystemToolStripMenuItem.Text = "About Library Management System"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(512, 44)
        Me.ContactUsToolStripMenuItem.Text = "Contact us..."
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(512, 44)
        Me.DocumentationToolStripMenuItem.Text = "Documentation"
        '
        'TutorialToolStripMenuItem
        '
        Me.TutorialToolStripMenuItem.Name = "TutorialToolStripMenuItem"
        Me.TutorialToolStripMenuItem.Size = New System.Drawing.Size(512, 44)
        Me.TutorialToolStripMenuItem.Text = "Tutorial"
        '
        'ActivateToolStripMenuItem
        '
        Me.ActivateToolStripMenuItem.Name = "ActivateToolStripMenuItem"
        Me.ActivateToolStripMenuItem.Size = New System.Drawing.Size(512, 44)
        Me.ActivateToolStripMenuItem.Text = "Activate"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(512, 44)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Vivaldi", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-5, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1385, 114)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "School Library Management System"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(955, 485)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrganizationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuthorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewAuthorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAuthorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PublisherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewPublisherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditPublisherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeletePublisherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutLibraryManagmentSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

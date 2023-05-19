<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.member4 = New System.Windows.Forms.TextBox()
        Me.member3 = New System.Windows.Forms.TextBox()
        Me.member2 = New System.Windows.Forms.TextBox()
        Me.member1 = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.issue5 = New System.Windows.Forms.TextBox()
        Me.issue4 = New System.Windows.Forms.TextBox()
        Me.issue3 = New System.Windows.Forms.TextBox()
        Me.issue2 = New System.Windows.Forms.TextBox()
        Me.issue1 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.publisher3 = New System.Windows.Forms.TextBox()
        Me.publisher2 = New System.Windows.Forms.TextBox()
        Me.publisher1 = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.librarian4 = New System.Windows.Forms.TextBox()
        Me.librarian3 = New System.Windows.Forms.TextBox()
        Me.librarian2 = New System.Windows.Forms.TextBox()
        Me.librarian1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.book5 = New System.Windows.Forms.TextBox()
        Me.book4 = New System.Windows.Forms.TextBox()
        Me.book3 = New System.Windows.Forms.TextBox()
        Me.book2 = New System.Windows.Forms.TextBox()
        Me.book1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.BooksDataGridView = New System.Windows.Forms.DataGridView()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet = New ProjectA.libraryDataSet()
        Me.IssuesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IssuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrariansDataGridView = New System.Windows.Forms.DataGridView()
        Me.LibrariansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PublishersDataGridView = New System.Windows.Forms.DataGridView()
        Me.PublishersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersDataGridView = New System.Windows.Forms.DataGridView()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BooksTableAdapter = New ProjectA.libraryDataSetTableAdapters.booksTableAdapter()
        Me.TableAdapterManager = New ProjectA.libraryDataSetTableAdapters.TableAdapterManager()
        Me.IssuesTableAdapter = New ProjectA.libraryDataSetTableAdapters.issuesTableAdapter()
        Me.LibrariansTableAdapter = New ProjectA.libraryDataSetTableAdapters.librariansTableAdapter()
        Me.MembersTableAdapter = New ProjectA.libraryDataSetTableAdapters.membersTableAdapter()
        Me.PublishersTableAdapter = New ProjectA.libraryDataSetTableAdapters.publishersTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BookIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookAuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueReturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrariansDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrariansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublishersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(1067, 134)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(96, 42)
        Me.button2.TabIndex = 49
        Me.button2.Text = "Clear Search Fields"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(1067, 86)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 42)
        Me.button1.TabIndex = 48
        Me.button1.Text = "Save Data"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label10
        '
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(6, 631)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(328, 28)
        Me.label10.TabIndex = 60
        Me.label10.Text = "     ID             Name        Gender       Address"
        '
        'member4
        '
        Me.member4.Location = New System.Drawing.Point(246, 604)
        Me.member4.Name = "member4"
        Me.member4.Size = New System.Drawing.Size(74, 20)
        Me.member4.TabIndex = 59
        '
        'member3
        '
        Me.member3.Location = New System.Drawing.Point(166, 604)
        Me.member3.Name = "member3"
        Me.member3.Size = New System.Drawing.Size(74, 20)
        Me.member3.TabIndex = 58
        '
        'member2
        '
        Me.member2.Location = New System.Drawing.Point(86, 604)
        Me.member2.Name = "member2"
        Me.member2.Size = New System.Drawing.Size(74, 20)
        Me.member2.TabIndex = 57
        '
        'member1
        '
        Me.member1.Location = New System.Drawing.Point(6, 604)
        Me.member1.Name = "member1"
        Me.member1.Size = New System.Drawing.Size(74, 20)
        Me.member1.TabIndex = 56
        '
        'label9
        '
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(6, 631)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(460, 28)
        Me.label9.TabIndex = 55
        Me.label9.Text = "     ID           Book ID        ISBN      Member ID Member Name"
        '
        'issue5
        '
        Me.issue5.Location = New System.Drawing.Point(326, 604)
        Me.issue5.Name = "issue5"
        Me.issue5.Size = New System.Drawing.Size(74, 20)
        Me.issue5.TabIndex = 54
        '
        'issue4
        '
        Me.issue4.Location = New System.Drawing.Point(246, 604)
        Me.issue4.Name = "issue4"
        Me.issue4.Size = New System.Drawing.Size(74, 20)
        Me.issue4.TabIndex = 53
        '
        'issue3
        '
        Me.issue3.Location = New System.Drawing.Point(166, 604)
        Me.issue3.Name = "issue3"
        Me.issue3.Size = New System.Drawing.Size(74, 20)
        Me.issue3.TabIndex = 52
        '
        'issue2
        '
        Me.issue2.Location = New System.Drawing.Point(86, 604)
        Me.issue2.Name = "issue2"
        Me.issue2.Size = New System.Drawing.Size(74, 20)
        Me.issue2.TabIndex = 51
        '
        'issue1
        '
        Me.issue1.Location = New System.Drawing.Point(6, 604)
        Me.issue1.Name = "issue1"
        Me.issue1.Size = New System.Drawing.Size(74, 20)
        Me.issue1.TabIndex = 50
        '
        'label8
        '
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(6, 631)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(328, 28)
        Me.label8.TabIndex = 77
        Me.label8.Text = "     ID             Name        Address"
        '
        'publisher3
        '
        Me.publisher3.Location = New System.Drawing.Point(166, 604)
        Me.publisher3.Name = "publisher3"
        Me.publisher3.Size = New System.Drawing.Size(74, 20)
        Me.publisher3.TabIndex = 76
        '
        'publisher2
        '
        Me.publisher2.Location = New System.Drawing.Point(86, 604)
        Me.publisher2.Name = "publisher2"
        Me.publisher2.Size = New System.Drawing.Size(74, 20)
        Me.publisher2.TabIndex = 75
        '
        'publisher1
        '
        Me.publisher1.Location = New System.Drawing.Point(6, 604)
        Me.publisher1.Name = "publisher1"
        Me.publisher1.Size = New System.Drawing.Size(74, 20)
        Me.publisher1.TabIndex = 74
        '
        'label7
        '
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(6, 631)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(328, 28)
        Me.label7.TabIndex = 73
        Me.label7.Text = "     ID             Name        Gender       Address"
        '
        'librarian4
        '
        Me.librarian4.Location = New System.Drawing.Point(246, 604)
        Me.librarian4.Name = "librarian4"
        Me.librarian4.Size = New System.Drawing.Size(74, 20)
        Me.librarian4.TabIndex = 72
        '
        'librarian3
        '
        Me.librarian3.Location = New System.Drawing.Point(166, 604)
        Me.librarian3.Name = "librarian3"
        Me.librarian3.Size = New System.Drawing.Size(74, 20)
        Me.librarian3.TabIndex = 71
        '
        'librarian2
        '
        Me.librarian2.Location = New System.Drawing.Point(86, 604)
        Me.librarian2.Name = "librarian2"
        Me.librarian2.Size = New System.Drawing.Size(74, 20)
        Me.librarian2.TabIndex = 70
        '
        'librarian1
        '
        Me.librarian1.Location = New System.Drawing.Point(6, 604)
        Me.librarian1.Name = "librarian1"
        Me.librarian1.Size = New System.Drawing.Size(74, 20)
        Me.librarian1.TabIndex = 69
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(137, 3)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(426, 35)
        Me.label4.TabIndex = 68
        Me.label4.Text = "Members"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(6, 631)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(421, 28)
        Me.label3.TabIndex = 67
        Me.label3.Text = "     ID             ISBN            Title           Author      Publisher"
        '
        'book5
        '
        Me.book5.Location = New System.Drawing.Point(326, 604)
        Me.book5.Name = "book5"
        Me.book5.Size = New System.Drawing.Size(74, 20)
        Me.book5.TabIndex = 66
        '
        'book4
        '
        Me.book4.Location = New System.Drawing.Point(246, 604)
        Me.book4.Name = "book4"
        Me.book4.Size = New System.Drawing.Size(74, 20)
        Me.book4.TabIndex = 65
        '
        'book3
        '
        Me.book3.Location = New System.Drawing.Point(166, 604)
        Me.book3.Name = "book3"
        Me.book3.Size = New System.Drawing.Size(74, 20)
        Me.book3.TabIndex = 64
        '
        'book2
        '
        Me.book2.Location = New System.Drawing.Point(86, 604)
        Me.book2.Name = "book2"
        Me.book2.Size = New System.Drawing.Size(74, 20)
        Me.book2.TabIndex = 63
        '
        'book1
        '
        Me.book1.Location = New System.Drawing.Point(6, 604)
        Me.book1.Name = "book1"
        Me.book1.Size = New System.Drawing.Size(74, 20)
        Me.book1.TabIndex = 62
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(240, 3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(426, 35)
        Me.label2.TabIndex = 61
        Me.label2.Text = "Issues"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(183, 3)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(331, 35)
        Me.label6.TabIndex = 80
        Me.label6.Text = "Publishers"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(146, 3)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(426, 35)
        Me.label5.TabIndex = 79
        Me.label5.Text = "Librarians"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(142, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(426, 35)
        Me.label1.TabIndex = 78
        Me.label1.Text = "Books"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BooksDataGridView
        '
        Me.BooksDataGridView.AutoGenerateColumns = False
        Me.BooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn1, Me.ISBNDataGridViewTextBoxColumn1, Me.BookTitleDataGridViewTextBoxColumn, Me.BookAuthorDataGridViewTextBoxColumn, Me.PublisherNameDataGridViewTextBoxColumn, Me.PublisherDateDataGridViewTextBoxColumn})
        Me.BooksDataGridView.DataSource = Me.BooksBindingSource
        Me.BooksDataGridView.Location = New System.Drawing.Point(0, 38)
        Me.BooksDataGridView.Name = "BooksDataGridView"
        Me.BooksDataGridView.Size = New System.Drawing.Size(700, 560)
        Me.BooksDataGridView.TabIndex = 81
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "libraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IssuesDataGridView
        '
        Me.IssuesDataGridView.AutoGenerateColumns = False
        Me.IssuesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.IssuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssuesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IssueIDDataGridViewTextBoxColumn, Me.BookIDDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.MemberIDDataGridViewTextBoxColumn, Me.MemberNameDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn, Me.IssueReturnDateDataGridViewTextBoxColumn, Me.IssueReturnedDataGridViewTextBoxColumn})
        Me.IssuesDataGridView.DataSource = Me.IssuesBindingSource
        Me.IssuesDataGridView.Location = New System.Drawing.Point(0, 38)
        Me.IssuesDataGridView.Name = "IssuesDataGridView"
        Me.IssuesDataGridView.Size = New System.Drawing.Size(900, 560)
        Me.IssuesDataGridView.TabIndex = 81
        '
        'IssuesBindingSource
        '
        Me.IssuesBindingSource.DataMember = "issues"
        Me.IssuesBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibrariansDataGridView
        '
        Me.LibrariansDataGridView.AutoGenerateColumns = False
        Me.LibrariansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.LibrariansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibrariansDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.LibrariansDataGridView.DataSource = Me.LibrariansBindingSource
        Me.LibrariansDataGridView.Location = New System.Drawing.Point(0, 38)
        Me.LibrariansDataGridView.Name = "LibrariansDataGridView"
        Me.LibrariansDataGridView.Size = New System.Drawing.Size(700, 560)
        Me.LibrariansDataGridView.TabIndex = 81
        '
        'LibrariansBindingSource
        '
        Me.LibrariansBindingSource.DataMember = "librarians"
        Me.LibrariansBindingSource.DataSource = Me.LibraryDataSet
        '
        'PublishersDataGridView
        '
        Me.PublishersDataGridView.AutoGenerateColumns = False
        Me.PublishersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PublishersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PublishersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.PublishersDataGridView.DataSource = Me.PublishersBindingSource
        Me.PublishersDataGridView.Location = New System.Drawing.Point(0, 38)
        Me.PublishersDataGridView.Name = "PublishersDataGridView"
        Me.PublishersDataGridView.Size = New System.Drawing.Size(700, 560)
        Me.PublishersDataGridView.TabIndex = 81
        '
        'PublishersBindingSource
        '
        Me.PublishersBindingSource.DataMember = "publishers"
        Me.PublishersBindingSource.DataSource = Me.LibraryDataSet
        '
        'MembersDataGridView
        '
        Me.MembersDataGridView.AutoGenerateColumns = False
        Me.MembersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MembersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.MembersDataGridView.DataSource = Me.MembersBindingSource
        Me.MembersDataGridView.Location = New System.Drawing.Point(0, 38)
        Me.MembersDataGridView.Name = "MembersDataGridView"
        Me.MembersDataGridView.Size = New System.Drawing.Size(700, 560)
        Me.MembersDataGridView.TabIndex = 81
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "members"
        Me.MembersBindingSource.DataSource = Me.LibraryDataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1049, 692)
        Me.TabControl1.TabIndex = 82
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BooksDataGridView)
        Me.TabPage1.Controls.Add(Me.book1)
        Me.TabPage1.Controls.Add(Me.book2)
        Me.TabPage1.Controls.Add(Me.book3)
        Me.TabPage1.Controls.Add(Me.book4)
        Me.TabPage1.Controls.Add(Me.book5)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Controls.Add(Me.label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1041, 666)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Books"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LibrariansDataGridView)
        Me.TabPage2.Controls.Add(Me.librarian1)
        Me.TabPage2.Controls.Add(Me.librarian2)
        Me.TabPage2.Controls.Add(Me.librarian3)
        Me.TabPage2.Controls.Add(Me.librarian4)
        Me.TabPage2.Controls.Add(Me.label7)
        Me.TabPage2.Controls.Add(Me.label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1041, 666)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Librarians"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PublishersDataGridView)
        Me.TabPage3.Controls.Add(Me.publisher1)
        Me.TabPage3.Controls.Add(Me.publisher2)
        Me.TabPage3.Controls.Add(Me.publisher3)
        Me.TabPage3.Controls.Add(Me.label6)
        Me.TabPage3.Controls.Add(Me.label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1041, 666)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Publishers"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.label2)
        Me.TabPage4.Controls.Add(Me.issue1)
        Me.TabPage4.Controls.Add(Me.IssuesDataGridView)
        Me.TabPage4.Controls.Add(Me.issue2)
        Me.TabPage4.Controls.Add(Me.issue3)
        Me.TabPage4.Controls.Add(Me.issue4)
        Me.TabPage4.Controls.Add(Me.issue5)
        Me.TabPage4.Controls.Add(Me.label9)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1041, 666)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Issues"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.MembersDataGridView)
        Me.TabPage5.Controls.Add(Me.label4)
        Me.TabPage5.Controls.Add(Me.label10)
        Me.TabPage5.Controls.Add(Me.member1)
        Me.TabPage5.Controls.Add(Me.member4)
        Me.TabPage5.Controls.Add(Me.member2)
        Me.TabPage5.Controls.Add(Me.member3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1041, 666)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Members"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1250, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 42)
        Me.Button3.TabIndex = 83
        Me.Button3.Text = "Log Out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1067, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 20)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Time"
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.booksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.issuesTableAdapter = Me.IssuesTableAdapter
        Me.TableAdapterManager.librariansTableAdapter = Me.LibrariansTableAdapter
        Me.TableAdapterManager.membersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.publishersTableAdapter = Me.PublishersTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectA.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IssuesTableAdapter
        '
        Me.IssuesTableAdapter.ClearBeforeFill = True
        '
        'LibrariansTableAdapter
        '
        Me.LibrariansTableAdapter.ClearBeforeFill = True
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'PublishersTableAdapter
        '
        Me.PublishersTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1067, 182)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 42)
        Me.Button4.TabIndex = 85
        Me.Button4.Text = "Refresh Tables"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BookIDDataGridViewTextBoxColumn1
        '
        Me.BookIDDataGridViewTextBoxColumn1.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn1.HeaderText = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn1.Name = "BookIDDataGridViewTextBoxColumn1"
        Me.BookIDDataGridViewTextBoxColumn1.Width = 71
        '
        'ISBNDataGridViewTextBoxColumn1
        '
        Me.ISBNDataGridViewTextBoxColumn1.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn1.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn1.Name = "ISBNDataGridViewTextBoxColumn1"
        Me.ISBNDataGridViewTextBoxColumn1.Width = 57
        '
        'BookTitleDataGridViewTextBoxColumn
        '
        Me.BookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle"
        Me.BookTitleDataGridViewTextBoxColumn.HeaderText = "Book Title"
        Me.BookTitleDataGridViewTextBoxColumn.Name = "BookTitleDataGridViewTextBoxColumn"
        Me.BookTitleDataGridViewTextBoxColumn.Width = 80
        '
        'BookAuthorDataGridViewTextBoxColumn
        '
        Me.BookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor"
        Me.BookAuthorDataGridViewTextBoxColumn.HeaderText = "Book Author"
        Me.BookAuthorDataGridViewTextBoxColumn.Name = "BookAuthorDataGridViewTextBoxColumn"
        Me.BookAuthorDataGridViewTextBoxColumn.Width = 91
        '
        'PublisherNameDataGridViewTextBoxColumn
        '
        Me.PublisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName"
        Me.PublisherNameDataGridViewTextBoxColumn.HeaderText = "Publisher Name"
        Me.PublisherNameDataGridViewTextBoxColumn.Name = "PublisherNameDataGridViewTextBoxColumn"
        Me.PublisherNameDataGridViewTextBoxColumn.Width = 97
        '
        'PublisherDateDataGridViewTextBoxColumn
        '
        Me.PublisherDateDataGridViewTextBoxColumn.DataPropertyName = "PublisherDate"
        Me.PublisherDateDataGridViewTextBoxColumn.HeaderText = "Publisher Date"
        Me.PublisherDateDataGridViewTextBoxColumn.Name = "PublisherDateDataGridViewTextBoxColumn"
        Me.PublisherDateDataGridViewTextBoxColumn.Width = 93
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LibrarianID"
        Me.DataGridViewTextBoxColumn14.FillWeight = 101.5228!
        Me.DataGridViewTextBoxColumn14.HeaderText = "Librarian ID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 60
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "LibrarianName"
        Me.DataGridViewTextBoxColumn15.FillWeight = 99.49239!
        Me.DataGridViewTextBoxColumn15.HeaderText = "Librarian Name"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 95
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "LibrarianGender"
        Me.DataGridViewTextBoxColumn16.FillWeight = 99.49239!
        Me.DataGridViewTextBoxColumn16.HeaderText = "Librarian Gender"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 101
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "LibrarianAddress"
        Me.DataGridViewTextBoxColumn17.FillWeight = 99.49239!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Librarian Address"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 104
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PublisherID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Publisher ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 62
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PublisherName"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Publisher Name"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 97
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "PublisherAddress"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Publisher Address"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 106
        '
        'IssueIDDataGridViewTextBoxColumn
        '
        Me.IssueIDDataGridViewTextBoxColumn.DataPropertyName = "IssueID"
        Me.IssueIDDataGridViewTextBoxColumn.HeaderText = "Issue ID"
        Me.IssueIDDataGridViewTextBoxColumn.Name = "IssueIDDataGridViewTextBoxColumn"
        Me.IssueIDDataGridViewTextBoxColumn.Width = 71
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.Width = 71
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.Width = 57
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "Member ID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        Me.MemberIDDataGridViewTextBoxColumn.Width = 84
        '
        'MemberNameDataGridViewTextBoxColumn
        '
        Me.MemberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName"
        Me.MemberNameDataGridViewTextBoxColumn.HeaderText = "Member Name"
        Me.MemberNameDataGridViewTextBoxColumn.Name = "MemberNameDataGridViewTextBoxColumn"
        Me.MemberNameDataGridViewTextBoxColumn.Width = 101
        '
        'IssueDateDataGridViewTextBoxColumn
        '
        Me.IssueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date"
        Me.IssueDateDataGridViewTextBoxColumn.Name = "IssueDateDataGridViewTextBoxColumn"
        Me.IssueDateDataGridViewTextBoxColumn.Width = 83
        '
        'IssueReturnDateDataGridViewTextBoxColumn
        '
        Me.IssueReturnDateDataGridViewTextBoxColumn.DataPropertyName = "IssueReturnDate"
        Me.IssueReturnDateDataGridViewTextBoxColumn.HeaderText = "Issue Return Date"
        Me.IssueReturnDateDataGridViewTextBoxColumn.Name = "IssueReturnDateDataGridViewTextBoxColumn"
        Me.IssueReturnDateDataGridViewTextBoxColumn.Width = 108
        '
        'IssueReturnedDataGridViewTextBoxColumn
        '
        Me.IssueReturnedDataGridViewTextBoxColumn.DataPropertyName = "IssueReturned"
        Me.IssueReturnedDataGridViewTextBoxColumn.FalseValue = "0"
        Me.IssueReturnedDataGridViewTextBoxColumn.HeaderText = "Issue Returned"
        Me.IssueReturnedDataGridViewTextBoxColumn.Name = "IssueReturnedDataGridViewTextBoxColumn"
        Me.IssueReturnedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IssueReturnedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IssueReturnedDataGridViewTextBoxColumn.TrueValue = "1"
        Me.IssueReturnedDataGridViewTextBoxColumn.Width = 96
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "MemberID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Member ID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 62
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "MemberName"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Member Name"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 93
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "MemberGender"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Member Gender"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 99
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "MemberAddress"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Member Address"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 102
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 713)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Library Database Management"
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrariansDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrariansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublishersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents label10 As Label
    Private WithEvents member4 As TextBox
    Private WithEvents member3 As TextBox
    Private WithEvents member2 As TextBox
    Private WithEvents member1 As TextBox
    Private WithEvents label9 As Label
    Private WithEvents issue5 As TextBox
    Private WithEvents issue4 As TextBox
    Private WithEvents issue3 As TextBox
    Private WithEvents issue2 As TextBox
    Private WithEvents issue1 As TextBox
    Private WithEvents label8 As Label
    Private WithEvents publisher3 As TextBox
    Private WithEvents publisher2 As TextBox
    Private WithEvents publisher1 As TextBox
    Private WithEvents label7 As Label
    Private WithEvents librarian4 As TextBox
    Private WithEvents librarian3 As TextBox
    Private WithEvents librarian2 As TextBox
    Private WithEvents librarian1 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents book5 As TextBox
    Private WithEvents book4 As TextBox
    Private WithEvents book3 As TextBox
    Private WithEvents book2 As TextBox
    Private WithEvents book1 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label1 As Label
    Friend WithEvents LibraryDataSet As libraryDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As libraryDataSetTableAdapters.booksTableAdapter
    Friend WithEvents TableAdapterManager As libraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BooksDataGridView As DataGridView
    Friend WithEvents IssuesTableAdapter As libraryDataSetTableAdapters.issuesTableAdapter
    Friend WithEvents IssuesBindingSource As BindingSource
    Friend WithEvents LibrariansTableAdapter As libraryDataSetTableAdapters.librariansTableAdapter
    Friend WithEvents IssuesDataGridView As DataGridView
    Friend WithEvents LibrariansBindingSource As BindingSource
    Friend WithEvents PublishersTableAdapter As libraryDataSetTableAdapters.publishersTableAdapter
    Friend WithEvents LibrariansDataGridView As DataGridView
    Friend WithEvents PublishersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As libraryDataSetTableAdapters.membersTableAdapter
    Friend WithEvents PublishersDataGridView As DataGridView
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersDataGridView As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Private WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label11 As Label
    Private WithEvents Button4 As Button
    Friend WithEvents BookIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BookTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookAuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublisherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublisherDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueReturnedDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
End Class

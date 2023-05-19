Public Class Form1
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    End Sub

    'INITIALIZE'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IssuesTableAdapter.Fill(Me.LibraryDataSet.issues)
        Me.MembersTableAdapter.Fill(Me.LibraryDataSet.members)
        Me.PublishersTableAdapter.Fill(Me.LibraryDataSet.publishers)
        Me.LibrariansTableAdapter.Fill(Me.LibraryDataSet.librarians)
        Me.IssuesTableAdapter.Fill(Me.LibraryDataSet.issues)
        Me.BooksTableAdapter.Fill(Me.LibraryDataSet.books)
        Timer1.Start()
    End Sub
    'SAVE DATA'
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)
        MessageBox.Show("Saved Data!")
    End Sub
    'CLEAR SEARCH FIELDS'
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = ""
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
        MessageBox.Show("Cleared all Search Fields!")
    End Sub
    'SEARCH FIELDS'
    Private Sub book1_TextChanged(sender As Object, e As EventArgs) Handles book1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "Convert(BookID, 'System.String') LIKE '" & book1.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub
    Private Sub book2_TextChanged(sender As Object, e As EventArgs) Handles book2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "Convert(ISBN, 'System.String') LIKE '" & book2.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub
    Private Sub book3_TextChanged(sender As Object, e As EventArgs) Handles book3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "BookTitle LIKE '%" & book3.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub
    Private Sub book4_TextChanged(sender As Object, e As EventArgs) Handles book4.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "BookAuthor LIKE '%" & book4.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub
    Private Sub book5_TextChanged(sender As Object, e As EventArgs) Handles book5.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "PublisherName LIKE '%" & book5.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub
    Private Sub librarian1_TextChanged(sender As Object, e As EventArgs) Handles librarian1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = LibrariansDataGridView.DataSource
        bs.Filter = "Convert(LibrarianID, 'System.String') LIKE '" & librarian1.Text & "%'"
        LibrariansDataGridView.DataSource = bs
    End Sub
    Private Sub librarian2_TextChanged(sender As Object, e As EventArgs) Handles librarian2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = LibrariansDataGridView.DataSource
        bs.Filter = "LibrarianName LIKE '%" & librarian2.Text & "%'"
        LibrariansDataGridView.DataSource = bs
    End Sub
    Private Sub librarian3_TextChanged(sender As Object, e As EventArgs) Handles librarian3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = LibrariansDataGridView.DataSource
        bs.Filter = "LibrarianGender LIKE '" & librarian3.Text & "%'"
        LibrariansDataGridView.DataSource = bs
    End Sub
    Private Sub librarian4_TextChanged(sender As Object, e As EventArgs) Handles librarian4.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = LibrariansDataGridView.DataSource
        bs.Filter = "LibrarianAddress LIKE '%" & librarian4.Text & "%'"
        LibrariansDataGridView.DataSource = bs
    End Sub
    Private Sub publisher1_TextChanged(sender As Object, e As EventArgs) Handles publisher1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = PublishersDataGridView.DataSource
        bs.Filter = "Convert(PublisherID, 'System.String') LIKE '" & publisher1.Text & "%'"
        PublishersDataGridView.DataSource = bs
    End Sub
    Private Sub publisher2_TextChanged(sender As Object, e As EventArgs) Handles publisher2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = PublishersDataGridView.DataSource
        bs.Filter = "PublisherName LIKE '%" & publisher2.Text & "%'"
        PublishersDataGridView.DataSource = bs
    End Sub
    Private Sub publisher3_TextChanged(sender As Object, e As EventArgs) Handles publisher3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = PublishersDataGridView.DataSource
        bs.Filter = "PublisherAddress LIKE '%" & publisher3.Text & "%'"
        PublishersDataGridView.DataSource = bs
    End Sub
    Private Sub issue1_TextChanged(sender As Object, e As EventArgs) Handles issue1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "Convert(IssueID, 'System.String') LIKE '" & issue1.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub
    Private Sub issue2_TextChanged(sender As Object, e As EventArgs) Handles issue2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "Convert(BookID, 'System.String') LIKE '" & issue2.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub
    Private Sub issue3_TextChanged(sender As Object, e As EventArgs) Handles issue3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "Convert(ISBN, 'System.String') LIKE '" & issue3.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub
    Private Sub issue4_TextChanged(sender As Object, e As EventArgs) Handles issue4.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "Convert(MemberID, 'System.String') LIKE '" & issue4.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub
    Private Sub issue5_TextChanged(sender As Object, e As EventArgs) Handles issue5.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "MemberName LIKE '%" & issue5.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub
    Private Sub member1_TextChanged(sender As Object, e As EventArgs) Handles member1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = MembersDataGridView.DataSource
        bs.Filter = "Convert(MemberID, 'System.String') LIKE '" & member1.Text & "%'"
        MembersDataGridView.DataSource = bs
    End Sub
    Private Sub member2_TextChanged(sender As Object, e As EventArgs) Handles member2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = MembersDataGridView.DataSource
        bs.Filter = "MemberName LIKE '%" & member2.Text & "%'"
        MembersDataGridView.DataSource = bs
    End Sub
    Private Sub member3_TextChanged(sender As Object, e As EventArgs) Handles member3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = MembersDataGridView.DataSource
        bs.Filter = "MemberGender LIKE '" & member3.Text & "%'"
        MembersDataGridView.DataSource = bs
    End Sub
    Private Sub member4_TextChanged(sender As Object, e As EventArgs) Handles member4.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = MembersDataGridView.DataSource
        bs.Filter = "MemberAddress LIKE '%" & member4.Text & "%'"
        MembersDataGridView.DataSource = bs
    End Sub
    'END OF SEARCH FIELDS'

    'LOG OUT'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim frm2 As Form2 = New Form2()
        Form2.Show()
        Me.Close()
        MessageBox.Show("Logged out successfully!")
    End Sub

    'REAL TIME'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label11.Text = System.DateTime.Now.ToString()
    End Sub

    'REFRESH TABLES'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.IssuesTableAdapter.Fill(Me.LibraryDataSet.issues)
        Me.MembersTableAdapter.Fill(Me.LibraryDataSet.members)
        Me.PublishersTableAdapter.Fill(Me.LibraryDataSet.publishers)
        Me.LibrariansTableAdapter.Fill(Me.LibraryDataSet.librarians)
        Me.IssuesTableAdapter.Fill(Me.LibraryDataSet.issues)
        Me.BooksTableAdapter.Fill(Me.LibraryDataSet.books)
        MessageBox.Show("Reloaded all Tables!")
    End Sub
End Class

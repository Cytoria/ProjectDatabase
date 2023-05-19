Imports MySql.Data.MySqlClient
Public Class Form2
    Dim connectionString As String = "server=localhost;user id=root;database=users;allowuservariables=True"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBox2.UseSystemPasswordChar = True
    End Sub

    Public Sub login()
        Dim query As String = "SELECT * FROM accounts WHERE Name='" & textBox1.Text & "' AND Password='" + textBox2.Text & "'"
        Dim DBConnection As MySqlConnection = New MySqlConnection(connectionString)
        Dim DBCommand As MySqlCommand = New MySqlCommand(query, DBConnection)
        DBCommand.CommandTimeout = 60
        Dim reader As MySqlDataReader
        Try
            DBConnection.Open()
            reader = DBCommand.ExecuteReader()
            If reader.HasRows Then

                While reader.Read()
                    MessageBox.Show("Logged in Successfully!")
                    Dim frm1 As Form1 = New Form1()
                    frm1.Show()
                    Me.Hide()
                End While
            Else
                MessageBox.Show("Error occured." & vbLf & "Make sure the User and Password match.")
            End If
            DBConnection.Close()
        Catch e As Exception
            MessageBox.Show(e.Message)
        End Try
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        login()
    End Sub

    Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
        If checkBox1.Checked Then
            textBox2.UseSystemPasswordChar = False
        Else
            textBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class

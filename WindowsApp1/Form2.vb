Imports System.Data.SQLite
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim firstname As String = txtFirstname.Text
        Dim lastname As String = txtLastname.Text
        Dim phonenumber As String = txtPhoneNumber.Text

        'Check username already exists
        Dim checkUsernameQuery As String = "SELECT COUNT(*) FROM Users WHERE Username=@Username"
        Dim checkUsernameCommand As New SQLiteCommand(checkUsernameQuery, Form1.connection)
        checkUsernameCommand.Parameters.AddWithValue("@Username", username)

        Dim count As Integer = CInt(checkUsernameCommand.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("Username already exists. Choose a different username.")
            Return
        End If

        'Insert new user
        Dim insertQuery As String = "INSERT INTO Users (Username, Password, Firstname, Lastname, Phonenumber) VALUES (@Username, @Password, @Firstname, @Lastname, @Phonenumber)"
        Dim insertCommand As New SQLiteCommand(insertQuery, Form1.connection)
        insertCommand.Parameters.AddWithValue("@Username", username)
        insertCommand.Parameters.AddWithValue("@Password", password)
        insertCommand.Parameters.AddWithValue("@Firstname", firstname)
        insertCommand.Parameters.AddWithValue("@Lastname", lastname)
        insertCommand.Parameters.AddWithValue("@Phonenumber", phonenumber)


        insertCommand.ExecuteNonQuery()

        MessageBox.Show("Signup successful!")
        Me.Close()
    End Sub
End Class
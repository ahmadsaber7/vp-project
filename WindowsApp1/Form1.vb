Imports System.Data.SQLite

Public Class Form1
    Private connectionString As String = "Data Source=userdatabase.db;Version=3;"
    Public connection As SQLiteConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SQLiteConnection(connectionString)
        connection.Open()

        Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT UNIQUE, Password TEXT)"
        Dim createTableCommand As New SQLiteCommand(createTableQuery, connection)
        createTableCommand.ExecuteNonQuery()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        connection.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim selectQuery As String = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password"
        Dim selectCommand As New SQLiteCommand(selectQuery, connection)
        selectCommand.Parameters.AddWithValue("@Username", username)
        selectCommand.Parameters.AddWithValue("@Password", password)

        Dim reader As SQLiteDataReader = selectCommand.ExecuteReader()

        If reader.Read() Then
            Form3.Show()
            'Me.Close()
            'Me.Close()

        Else
            MessageBox.Show("Invalid username or password.")
        End If

        reader.Close()

    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Form2.Show()
    End Sub


End Class

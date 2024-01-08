Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim totPrice As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'number of bed price
        totPrice = nup1.Value * 10

        'room size price
        If cb1.SelectedIndex = 0 Then
            totPrice += 100
        ElseIf cb1.SelectedIndex = 1 Then
            totPrice += 200
        ElseIf cb1.SelectedIndex = 2 Then
            totPrice += 300
        End If

        'indoor or outdoor bathroom price
        If rb1.Checked Then
            totPrice += 50
        ElseIf rb2.Checked Then
            totPrice += 100
        End If

        'view price
        If rb3.Checked Then
            totPrice += 50
        ElseIf rb4.Checked Then
            totPrice += 150
        End If

        totalPrice.Text = totPrice
    End Sub


End Class
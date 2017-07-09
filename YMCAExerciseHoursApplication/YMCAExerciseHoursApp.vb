Public Class YMCAExerciseHoursApp

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEnterUserName.Text = ""
        txtEnterBirthdayMonth.Text = ""
        txtEnterCurrentDateMonth.Text = ""
        txtEnterBirthdayDate.Text = ""
        txtEnterBirthdayYear.Text = ""
        txtEnterCurrentDateDate.Text = ""
        txtEnterCurrentDateYear.Text = ""
        lblUserName.Text = ""
        lblTotalHours.Text = ""
        txtEnterUserName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtEnterName_TextChanged(sender As Object, e As EventArgs) Handles txtEnterUserName.TextChanged
        






    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strEnterUserName As String = txtEnterUserName.Text
        Dim strUserName As String = txtEnterUserName.Text
        Dim strEnterBirthdayMonth As String = txtEnterBirthdayMonth.Text
        Dim intEnterBirthdayMonth As Integer = Convert.ToInt32(strEnterBirthdayMonth)
        Dim strEnterBirthdayDate As String = txtEnterBirthdayDate.Text
        Dim intEnterBirthdayDate As Integer = Convert.ToInt32(strEnterBirthdayDate)
        Dim strEnterBirthdayYear As String = txtEnterBirthdayYear.Text
        Dim intEnterBirthdayYear As Integer = Convert.ToInt32(strEnterBirthdayYear)
        Dim strEnterCurrentDateMonth As String = txtEnterCurrentDateMonth.Text
        Dim intEnterCurrentDateMonth As Integer = Convert.ToInt32(strEnterCurrentDateMonth)
        Dim strEnterCurrentDateDate As String = txtEnterCurrentDateDate.Text
        Dim intEnterCurrentDateDate As Integer = Convert.ToInt32(strEnterCurrentDateDate)
        Dim strEnterCurrentDateYear As String = txtEnterCurrentDateYear.Text
        Dim intEnterCurrentDateYear As Integer = Convert.ToInt32(strEnterCurrentDateYear)
        Dim decTotalMonths As Decimal
        Dim decTotalDays As Decimal
        Dim decTotalYears As Decimal
        Dim decTotalHours As Decimal
        decTotalMonths = 12 - strEnterBirthdayMonth
        decTotalDays = 30 - intEnterBirthdayDate
        decTotalYears = (strEnterCurrentDateYear - strEnterBirthdayYear - 1) * 52
        decTotalHours = (decTotalMonths + decTotalDays + decTotalYears) * 3
        lblTotalHours.Text = decTotalHours.ToString("N0")
        lblUserName.Text = txtEnterUserName.Text
    End Sub

    Private Sub txtEnterBirthdayYear_Click(sender As Object, e As EventArgs) Handles txtEnterBirthdayYear.Click
        txtEnterBirthdayYear.Text = ""
    End Sub

    Private Sub txtEnterBirthdayDate_Click(sender As Object, e As EventArgs) Handles txtEnterBirthdayDate.Click
        txtEnterBirthdayDate.Text = ""
    End Sub

    Private Sub txtEnterBirthdayMonth_Click(sender As Object, e As EventArgs) Handles txtEnterBirthdayMonth.Click
        txtEnterBirthdayMonth.Text = ""
    End Sub

    Private Sub txtEnterCurrentDateMonth_Click(sender As Object, e As EventArgs) Handles txtEnterCurrentDateMonth.Click
        txtEnterCurrentDateMonth.Text = ""
    End Sub

    Private Sub txtEnterCurrentDateDate_Click(sender As Object, e As EventArgs) Handles txtEnterCurrentDateDate.Click
        txtEnterCurrentDateDate.Text = ""
    End Sub

    Private Sub txtEnterCurrentDateYear_Click(sender As Object, e As EventArgs) Handles txtEnterCurrentDateYear.Click
        txtEnterCurrentDateYear.Text = ""
    End Sub
End Class

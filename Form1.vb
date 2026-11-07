Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUseranme.Text.Trim() = "" OrElse txtPassword.Text = "" OrElse cboRole.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(txtUseranme.Text.Trim(), "^[A-Za-z]+$") Then
            MessageBox.Show("Username must contain letters only.")
            Return
        End If

        If txtPassword.Text <> "staff123" Then
            MessageBox.Show("Incorrect password.")
            Return
        End If
        Select Case cboRole.Text.Trim()

            Case "Receptionist"
                Dim d As New DashboardForm()
                d.Show()
                Me.Hide()
            Case "Doctor"
                MessageBox.Show("Invalid role.Doctors log in here.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Case Else
                MessageBox.Show("Please select a valid role.")

        End Select
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub cboRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRole.SelectedIndexChanged

    End Sub
End Class
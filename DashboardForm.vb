Public Class DashboardForm

    Private nextQueueNumber As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbGender.Items.Clear()
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")

        txtPatientID.ReadOnly = True
        txtQueueNumber.ReadOnly = True

    End Sub

    Private Sub btnRegisterPatient_Click(sender As Object, e As EventArgs) Handles btnRegisterPatient.Click

        Dim patientName As String = txtPatientName.Text.Trim()
        Dim age As Integer

        If patientName = "" Then
            MessageBox.Show("Please enter the patient's name.")
            txtPatientName.Focus()
            Return
        End If

        If Not Integer.TryParse(txtAge.Text, age) OrElse age < 0 OrElse age > 130 Then
            MessageBox.Show("Please enter a valid age.")
            txtAge.Focus()
            Return
        End If

        If cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select the patient's gender.")
            cmbGender.Focus()
            Return
        End If

        If txtPhoneNumber.Text.Trim() = "" Then
            MessageBox.Show("Please enter the patient's phone number.")
            txtPhoneNumber.Focus()
            Return
        End If

        Dim patientID As String = "P" & nextQueueNumber.ToString("000")
        Dim queueNumber As Integer = nextQueueNumber

        txtPatientID.Text = patientID
        txtQueueNumber.Text = queueNumber.ToString()

        MessageBox.Show(
        "Patient registered successfully!" & vbCrLf &
        "Patient ID: " & patientID & vbCrLf &
        "Queue Number: " & queueNumber.ToString(),
        "Registration Successful"
    )

        nextQueueNumber += 1

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPatientID.Clear()
        txtPatientName.Clear()
        txtAge.Clear()
        cmbGender.SelectedIndex = -1
        txtPhoneNumber.Clear()
        txtQueueNumber.Clear()

        txtPatientName.Focus()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblWelcome.Visible = Not lblWelcome.Visible
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub
End Class

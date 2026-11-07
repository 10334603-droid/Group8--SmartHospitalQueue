
Imports System.Collections.Generic

Module QueueData
    ' Shared list of patients waiting to see the doctor
    Public WaitingList As New List(Of String)

    ' Counter used to make the next queue number
    Public NextNumber As Integer = 1

    ' Makes a queue number like Q001, Q002, Q003
    Public Function MakeQueueNumber() As String
        Dim number As String = "Q" & NextNumber.ToString("000")
        NextNumber += 1
        Return number
    End Function
End Module
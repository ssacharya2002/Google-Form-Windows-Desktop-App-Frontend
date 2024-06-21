Imports System.Net.Http
Imports Newtonsoft.Json

Public Class MainForm
    Private Async Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtSearchEmail.Text.Trim()

        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter an email ID to search.")
            Return
        End If

        Await SearchSubmissionByEmail(email)
    End Sub

    Private Async Function SearchSubmissionByEmail(email As String) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/search?email={email}")

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim submission = JsonConvert.DeserializeObject(Of Submission)(jsonResponse)
                    DisplaySubmission(submission)
                Else
                    MessageBox.Show("Submission not found.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        Dim message As String = $"Name: {submission.name}" & vbCrLf &
                                $"Email: {submission.email}" & vbCrLf &
                                $"Phone: {submission.phone}" & vbCrLf &
                                $"GitHub Link: {submission.github_link}" & vbCrLf &
                                $"Stopwatch Time: {submission.stopwatch_time}"

        MessageBox.Show(message, "Submission Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class

End Class

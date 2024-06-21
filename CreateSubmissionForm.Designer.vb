<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        lblStopwatchTime = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top
        txtName.Location = New Point(154, 50)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(354, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top
        txtEmail.Location = New Point(154, 100)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(354, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Anchor = AnchorStyles.Top
        txtPhoneNum.Location = New Point(154, 150)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.PlaceholderText = "Phone"
        txtPhoneNum.Size = New Size(354, 27)
        txtPhoneNum.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Anchor = AnchorStyles.Top
        txtGithubLink.Location = New Point(154, 200)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.PlaceholderText = "Github link"
        txtGithubLink.Size = New Size(354, 27)
        txtGithubLink.TabIndex = 3
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.Anchor = AnchorStyles.Top
        lblStopwatchTime.Location = New Point(206, 250)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(231, 27)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.Text = "00:00:00"
        lblStopwatchTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Anchor = AnchorStyles.Top
        btnToggleStopwatch.Location = New Point(206, 297)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(225, 30)
        btnToggleStopwatch.TabIndex = 5
        btnToggleStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Top
        btnSubmit.Location = New Point(206, 342)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(225, 30)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Location = New Point(43, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(43, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 8
        Label2.Text = "Github Link"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Location = New Point(43, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 9
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New Point(43, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 10
        Label4.Text = "Email"
        ' 
        ' CreateSubmissionForm
        ' 
        ClientSize = New Size(691, 518)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(lblStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

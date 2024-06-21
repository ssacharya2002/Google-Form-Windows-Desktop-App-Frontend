<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        lblStopwatchTime = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top
        txtName.Location = New Point(202, 56)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(354, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top
        txtEmail.Location = New Point(202, 100)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(354, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Anchor = AnchorStyles.Top
        txtPhone.Location = New Point(202, 142)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Phone"
        txtPhone.Size = New Size(354, 27)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Anchor = AnchorStyles.Top
        txtGithubLink.Location = New Point(202, 185)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.PlaceholderText = "Github link"
        txtGithubLink.Size = New Size(354, 27)
        txtGithubLink.TabIndex = 3
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.Anchor = AnchorStyles.Top
        lblStopwatchTime.Location = New Point(202, 236)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(354, 20)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.Text = "Stopwatch Time"
        lblStopwatchTime.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Anchor = AnchorStyles.Top
        btnPrevious.Location = New Point(33, 371)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(163, 29)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "Previous (Ctrl + P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Top
        btnNext.Location = New Point(202, 371)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(144, 29)
        btnNext.TabIndex = 6
        btnNext.Text = "Next (Ctrl + N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Top
        btnDelete.Location = New Point(364, 371)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(138, 29)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete (Ctrl + D)"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top
        btnEdit.Location = New Point(523, 371)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(117, 29)
        btnEdit.TabIndex = 8
        btnEdit.Text = "Edit (Ctrl + E)"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Location = New Point(87, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 9
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(87, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 10
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Location = New Point(87, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 11
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New Point(87, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 12
        Label4.Text = "Github Link"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Location = New Point(87, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 20)
        Label5.TabIndex = 13
        Label5.Text = "Stopwatch Time"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(702, 412)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents txtName As TextBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtPhone As TextBox
    Private WithEvents txtGithubLink As TextBox
    Private WithEvents lblStopwatchTime As Label
    Private WithEvents btnPrevious As Button
    Private WithEvents btnNext As Button
    Private WithEvents btnDelete As Button
    Private WithEvents btnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

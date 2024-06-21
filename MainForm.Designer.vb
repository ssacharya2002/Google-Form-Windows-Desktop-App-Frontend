<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        txtSearchEmail = New TextBox()
        btnSearch = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Anchor = AnchorStyles.Top
        btnViewSubmissions.Location = New Point(289, 287)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(274, 30)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions (Ctrl + V)"
        btnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.Anchor = AnchorStyles.Top
        btnCreateSubmission.Location = New Point(289, 343)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(274, 30)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create New Submission (Ctrl + N)"
        btnCreateSubmission.UseVisualStyleBackColor = True
        ' 
        ' txtSearchEmail
        ' 
        txtSearchEmail.Anchor = AnchorStyles.Top
        txtSearchEmail.Location = New Point(289, 414)
        txtSearchEmail.Name = "txtSearchEmail"
        txtSearchEmail.PlaceholderText = "Enter email id to search"
        txtSearchEmail.Size = New Size(274, 27)
        txtSearchEmail.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top
        btnSearch.Location = New Point(289, 456)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(274, 30)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search Submission"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = My.Resources.Resources.logo1
        PictureBox1.Location = New Point(377, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(184, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(518, 81)
        Label1.TabIndex = 5
        Label1.Text = "Slidely Form App"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MainForm
        ' 
        ClientSize = New Size(865, 564)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnSearch)
        Controls.Add(txtSearchEmail)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Name = "MainForm"
        Text = "Slidely Form App"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents txtSearchEmail As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class

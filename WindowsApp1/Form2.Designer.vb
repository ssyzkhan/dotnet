<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtWords = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radCountChars = New System.Windows.Forms.RadioButton()
        Me.radCountWords = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnShowMe = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWords
        '
        Me.txtWords.Location = New System.Drawing.Point(0, 24)
        Me.txtWords.Multiline = True
        Me.txtWords.Name = "txtWords"
        Me.txtWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWords.Size = New System.Drawing.Size(613, 360)
        Me.txtWords.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter some text into the box..."
        '
        'radCountChars
        '
        Me.radCountChars.AutoSize = True
        Me.radCountChars.Checked = True
        Me.radCountChars.Location = New System.Drawing.Point(12, 408)
        Me.radCountChars.Name = "radCountChars"
        Me.radCountChars.Size = New System.Drawing.Size(53, 16)
        Me.radCountChars.TabIndex = 2
        Me.radCountChars.TabStop = True
        Me.radCountChars.Text = "Chars"
        Me.radCountChars.UseVisualStyleBackColor = True
        '
        'radCountWords
        '
        Me.radCountWords.AutoSize = True
        Me.radCountWords.Location = New System.Drawing.Point(84, 408)
        Me.radCountWords.Name = "radCountWords"
        Me.radCountWords.Size = New System.Drawing.Size(53, 16)
        Me.radCountWords.TabIndex = 3
        Me.radCountWords.Text = "Words"
        Me.radCountWords.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "The results are: "
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(267, 410)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(0, 12)
        Me.lblResults.TabIndex = 5
        '
        'btnShowMe
        '
        Me.btnShowMe.Location = New System.Drawing.Point(488, 401)
        Me.btnShowMe.Name = "btnShowMe"
        Me.btnShowMe.Size = New System.Drawing.Size(75, 23)
        Me.btnShowMe.TabIndex = 6
        Me.btnShowMe.Text = "Show Me"
        Me.btnShowMe.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 437)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(614, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(614, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 459)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnShowMe)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radCountWords)
        Me.Controls.Add(Me.radCountChars)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWords)
        Me.Name = "Form2"
        Me.Text = "Word Counter"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWords As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents radCountChars As RadioButton
    Friend WithEvents radCountWords As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents btnShowMe As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

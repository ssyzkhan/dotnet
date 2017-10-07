<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lstFavorites = New System.Windows.Forms.ListView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.hdrName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdrUrl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lstFavorites
        '
        Me.lstFavorites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstFavorites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hdrName, Me.hdrUrl})
        Me.lstFavorites.Location = New System.Drawing.Point(0, 0)
        Me.lstFavorites.Name = "lstFavorites"
        Me.lstFavorites.Size = New System.Drawing.Size(523, 255)
        Me.lstFavorites.TabIndex = 0
        Me.lstFavorites.UseCompatibleStateImageBehavior = False
        Me.lstFavorites.View = System.Windows.Forms.View.Details
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1, 269)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(65, 12)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'hdrName
        '
        Me.hdrName.Text = "Name"
        Me.hdrName.Width = 250
        '
        'hdrUrl
        '
        Me.hdrUrl.Width = 250
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 290)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lstFavorites)
        Me.Name = "Form3"
        Me.Text = "My Favorites"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstFavorites As ListView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents hdrName As ColumnHeader
    Friend WithEvents hdrUrl As ColumnHeader
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.trkMinPasswordLength = New System.Windows.Forms.TrackBar()
        CType(Me.trkMinPasswordLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.ItemHeight = 12
        Me.lstUsers.Location = New System.Drawing.Point(0, 0)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(262, 256)
        Me.lstUsers.TabIndex = 0
        '
        'trkMinPasswordLength
        '
        Me.trkMinPasswordLength.Location = New System.Drawing.Point(285, 41)
        Me.trkMinPasswordLength.Name = "trkMinPasswordLength"
        Me.trkMinPasswordLength.Size = New System.Drawing.Size(128, 45)
        Me.trkMinPasswordLength.TabIndex = 1
        Me.trkMinPasswordLength.Value = 6
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 261)
        Me.Controls.Add(Me.trkMinPasswordLength)
        Me.Controls.Add(Me.lstUsers)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.trkMinPasswordLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstUsers As ListBox
    Friend WithEvents trkMinPasswordLength As TrackBar
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.TxtPlaylistName = New System.Windows.Forms.TextBox()
        Me.TxtURLCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorMsg = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtPlaylistName
        '
        Me.TxtPlaylistName.BackColor = System.Drawing.Color.Silver
        Me.TxtPlaylistName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPlaylistName.CausesValidation = False
        Me.TxtPlaylistName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlaylistName.Location = New System.Drawing.Point(155, 12)
        Me.TxtPlaylistName.Name = "TxtPlaylistName"
        Me.TxtPlaylistName.Size = New System.Drawing.Size(207, 19)
        Me.TxtPlaylistName.TabIndex = 0
        '
        'TxtURLCode
        '
        Me.TxtURLCode.BackColor = System.Drawing.Color.Silver
        Me.TxtURLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtURLCode.CausesValidation = False
        Me.TxtURLCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtURLCode.Location = New System.Drawing.Point(155, 39)
        Me.TxtURLCode.MaxLength = 34
        Me.TxtURLCode.Name = "TxtURLCode"
        Me.TxtURLCode.Size = New System.Drawing.Size(207, 19)
        Me.TxtURLCode.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.YoutubeMusicPlayerProject.My.Resources.Resources._error
        Me.Button1.Location = New System.Drawing.Point(9, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Playlist name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Playlist URL code:"
        '
        'ErrorMsg
        '
        Me.ErrorMsg.AutoSize = True
        Me.ErrorMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ErrorMsg.ForeColor = System.Drawing.Color.Red
        Me.ErrorMsg.Location = New System.Drawing.Point(151, 61)
        Me.ErrorMsg.Name = "ErrorMsg"
        Me.ErrorMsg.Size = New System.Drawing.Size(57, 20)
        Me.ErrorMsg.TabIndex = 6
        Me.ErrorMsg.Text = "Label3"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.YoutubeMusicPlayerProject.My.Resources.Resources.success
        Me.Button2.Location = New System.Drawing.Point(321, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(369, 106)
        Me.Controls.Add(Me.ErrorMsg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtURLCode)
        Me.Controls.Add(Me.TxtPlaylistName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Playlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPlaylistName As System.Windows.Forms.TextBox
    Friend WithEvents TxtURLCode As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorMsg As System.Windows.Forms.Label
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.VideoPlayer = New AxShockwaveFlashObjects.AxShockwaveFlash()
        CType(Me.VideoPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VideoPlayer
        '
        Me.VideoPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.VideoPlayer.Enabled = True
        Me.VideoPlayer.Location = New System.Drawing.Point(0, 0)
        Me.VideoPlayer.Name = "VideoPlayer"
        Me.VideoPlayer.OcxState = CType(resources.GetObject("VideoPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VideoPlayer.Size = New System.Drawing.Size(355, 229)
        Me.VideoPlayer.TabIndex = 0
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 229)
        Me.Controls.Add(Me.VideoPlayer)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.VideoPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VideoPlayer As AxShockwaveFlashObjects.AxShockwaveFlash
End Class

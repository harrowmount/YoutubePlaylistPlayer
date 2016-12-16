<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PlaylistList = New System.Windows.Forms.ListBox()
        Me.PlaylistsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlaylistDBDataSet = New YoutubeMusicPlayerProject.PlaylistDBDataSet()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.PlaylistsTableAdapter = New YoutubeMusicPlayerProject.PlaylistDBDataSetTableAdapters.PlaylistsTableAdapter()
        CType(Me.PlaylistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlaylistDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlaylistList
        '
        Me.PlaylistList.BackColor = System.Drawing.Color.Gray
        Me.PlaylistList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlaylistList.DataSource = Me.PlaylistsBindingSource
        Me.PlaylistList.DisplayMember = "PlaylistName"
        Me.PlaylistList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaylistList.ForeColor = System.Drawing.Color.White
        Me.PlaylistList.FormattingEnabled = True
        Me.PlaylistList.ItemHeight = 20
        Me.PlaylistList.Location = New System.Drawing.Point(146, 12)
        Me.PlaylistList.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PlaylistList.Name = "PlaylistList"
        Me.PlaylistList.Size = New System.Drawing.Size(323, 180)
        Me.PlaylistList.TabIndex = 0
        Me.PlaylistList.ValueMember = "ID"
        '
        'PlaylistsBindingSource
        '
        Me.PlaylistsBindingSource.DataMember = "Playlists"
        Me.PlaylistsBindingSource.DataSource = Me.PlaylistDBDataSet
        '
        'PlaylistDBDataSet
        '
        Me.PlaylistDBDataSet.DataSetName = "PlaylistDBDataSet"
        Me.PlaylistDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Gray
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Image = Global.YoutubeMusicPlayerProject.My.Resources.Resources.plus
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(12, 12)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(128, 38)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add new playlist..."
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Gray
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Image = Global.YoutubeMusicPlayerProject.My.Resources.Resources.info
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(12, 59)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(128, 38)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Edit playlist..."
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Gray
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Image = Global.YoutubeMusicPlayerProject.My.Resources.Resources._error
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(12, 106)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(128, 38)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete playlist..."
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnPlay
        '
        Me.BtnPlay.BackColor = System.Drawing.Color.Gray
        Me.BtnPlay.FlatAppearance.BorderSize = 0
        Me.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlay.ForeColor = System.Drawing.Color.White
        Me.BtnPlay.Image = Global.YoutubeMusicPlayerProject.My.Resources.Resources.play_button
        Me.BtnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPlay.Location = New System.Drawing.Point(12, 153)
        Me.BtnPlay.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(128, 38)
        Me.BtnPlay.TabIndex = 4
        Me.BtnPlay.Text = "Play!"
        Me.BtnPlay.UseVisualStyleBackColor = False
        '
        'PlaylistsTableAdapter
        '
        Me.PlaylistsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 202)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.PlaylistList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Youtube Music Player"
        CType(Me.PlaylistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlaylistDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlaylistList As System.Windows.Forms.ListBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnPlay As System.Windows.Forms.Button
    Friend WithEvents PlaylistDBDataSet As YoutubeMusicPlayerProject.PlaylistDBDataSet
    Friend WithEvents PlaylistsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlaylistsTableAdapter As YoutubeMusicPlayerProject.PlaylistDBDataSetTableAdapters.PlaylistsTableAdapter
End Class

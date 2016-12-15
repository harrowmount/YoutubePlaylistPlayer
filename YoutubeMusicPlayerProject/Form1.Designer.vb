<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PlaylistList.DataSource = Me.PlaylistsBindingSource
        Me.PlaylistList.DisplayMember = "PlaylistName"
        Me.PlaylistList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaylistList.FormattingEnabled = True
        Me.PlaylistList.ItemHeight = 20
        Me.PlaylistList.Location = New System.Drawing.Point(147, 16)
        Me.PlaylistList.Name = "PlaylistList"
        Me.PlaylistList.Size = New System.Drawing.Size(323, 164)
        Me.PlaylistList.Sorted = True
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
        Me.BtnAdd.Location = New System.Drawing.Point(12, 12)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(129, 38)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add new playlist..."
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(12, 56)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(129, 38)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Edit playlist..."
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(12, 100)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(129, 38)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete playlist..."
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnPlay
        '
        Me.BtnPlay.Location = New System.Drawing.Point(12, 144)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(129, 38)
        Me.BtnPlay.TabIndex = 4
        Me.BtnPlay.Text = "Play!"
        Me.BtnPlay.UseVisualStyleBackColor = True
        '
        'PlaylistsTableAdapter
        '
        Me.PlaylistsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 188)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.PlaylistList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
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


''' <summary>
''' Main menu form
''' </summary>
Public Class MainMenu

    ''' <summary>
    ''' Binds DB to the selection list
    ''' </summary>
    Private Sub Form1_Load() Handles MyBase.Load
        PlaylistsTableAdapter.Fill(PlaylistDBDataSet.Playlists)
    End Sub

    ''' <summary>
    ''' Opens form 2 when add button is clicked
    ''' </summary>
    Private Sub BtnAdd_Click() Handles BtnAdd.Click
        CreatePlaylist.Show()
        Close()
    End Sub

    ''' <summary>
    ''' Removes selected playlist from DB
    ''' </summary>
    Private Sub BtnDelete_Click() Handles BtnDelete.Click
        If PlaylistList.SelectedValue IsNot Nothing Then
            Dim deletePlaylist As PlaylistDBDataSet.PlaylistsRow
            deletePlaylist = PlaylistDBDataSet.Playlists.FindByID(CInt(PlaylistList.SelectedValue))
            PlaylistsTableAdapter.Delete(deletePlaylist.ID, deletePlaylist.PlaylistName, deletePlaylist.PlaylistURLCode)
            PlaylistDBDataSet.Playlists.Rows.Remove(PlaylistDBDataSet.Playlists.FindByID(CInt(PlaylistList.SelectedValue)))
        End If
    End Sub

    ''' <summary>
    ''' Opens form 3 when edit button is clicked
    ''' </summary>
    Private Sub BtnEdit_Click() Handles BtnEdit.Click
        If PlaylistList.SelectedValue IsNot Nothing Then
            EditPlaylist.Show()
        End If
    End Sub

    ''' <summary>
    ''' Opens form 4 when play playlist button is clicked
    ''' </summary>
    Private Sub BtnPlay_Click() Handles BtnPlay.Click
        If PlaylistList.SelectedValue IsNot Nothing Then
            PlayPlaylist.Show()
        End If
    End Sub

    ''' <summary>
    ''' Opens form 5 when play video button is clicked
    ''' </summary>
    Private Sub Button1_Click() Handles Button1.Click
        PlayVideo.Show()
    End Sub

    ''' <summary>
    ''' Allows ending program through notify icon
    ''' </summary>
    Private Sub ToolStripMenuItem1_Click() Handles ToolStripMenuItem1.Click
        End
    End Sub
End Class

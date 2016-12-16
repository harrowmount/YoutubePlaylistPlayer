Public Class Form1

    'Binds DB to the selection list
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlaylistsTableAdapter.Fill(PlaylistDBDataSet.Playlists)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Form2.Show()
        Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If PlaylistList.SelectedValue <> Nothing Then
            Dim deletePlaylist As PlaylistDBDataSet.PlaylistsRow
            deletePlaylist = PlaylistDBDataSet.Playlists.FindByID(PlaylistList.SelectedValue)
            PlaylistsTableAdapter.Delete(deletePlaylist.ID, deletePlaylist.PlaylistName, deletePlaylist.PlaylistURLCode)
            PlaylistDBDataSet.Playlists.Rows.Remove(PlaylistDBDataSet.Playlists.FindByID(PlaylistList.SelectedValue))
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If PlaylistList.SelectedValue <> Nothing Then
            Form3.Show()
        End If
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        If PlaylistList.SelectedValue <> Nothing Then
            Form4.Show()
        End If
    End Sub
End Class

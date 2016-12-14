Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PlaylistDBDataSet.Playlists' table. You can move, or remove it, as needed.
        PlaylistsTableAdapter.Fill(PlaylistDBDataSet.Playlists)

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Form2.Show()
        Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim deletePlaylist As PlaylistDBDataSet.PlaylistsRow
        deletePlaylist = PlaylistDBDataSet.Playlists.FindByID(PlaylistList.SelectedValue)
        PlaylistsTableAdapter.Delete(deletePlaylist.ID, deletePlaylist.PlaylistName, deletePlaylist.PlaylistURLCode)
        PlaylistDBDataSet.Playlists.Rows.Remove(PlaylistDBDataSet.Playlists.FindByID(PlaylistList.SelectedValue))
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If PlaylistList.SelectedValue <> Nothing Then
            Form3.Show()
            Close()
        End If
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        Form4.Show()
        Close()
    End Sub
End Class

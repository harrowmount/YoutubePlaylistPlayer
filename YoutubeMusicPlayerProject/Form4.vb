Public Class Form4
    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim playlistSelected As PlaylistDBDataSet.PlaylistsRow
        playlistSelected = Form1.PlaylistDBDataSet.Playlists.FindByID(Form1.PlaylistList.SelectedValue)
        Me.Text = playlistSelected.PlaylistName
        VideoPlayer.Movie() = "https://www.youtube.com/v/" & playlistSelected.VideoURLCode & "&list=" & playlistSelected.PlaylistURLCode & "&index=1"
    End Sub
End Class
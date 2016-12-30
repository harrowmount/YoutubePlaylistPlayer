
Public Class Form4
    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim playlistSelected As PlaylistDBDataSet.PlaylistsRow
        playlistSelected = Form1.PlaylistDBDataSet.Playlists.FindByID(Form1.PlaylistList.SelectedValue)
        Form1.Close()
        Text = playlistSelected.PlaylistName
        WebBrowser1.DocumentText = "<iframe width=""590"" height=""360"" src=""https://www.youtube.com/embed/?list=" & playlistSelected.PlaylistURLCode & "&autoplay=1&loop=1"" frameborder=""0"" allowfullscreen></iframe>"
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        End
    End Sub

End Class
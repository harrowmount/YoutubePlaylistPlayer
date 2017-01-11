''' <summary>
''' Plays a playlist
''' </summary>
Public Class Form4

    ''' <summary>
    ''' On form close show form1
    ''' </summary>
    Private Sub Form4_Closed() Handles Me.Closed
        Form1.Show()
    End Sub

    ''' <summary>
    ''' embeds an iframe inside a web browser that plays the selected playlist
    ''' </summary>
    Private Sub Form4_Load() Handles Me.Load
        Dim playlistSelected As PlaylistDBDataSet.PlaylistsRow
        playlistSelected = Form1.PlaylistDBDataSet.Playlists.FindByID(CInt(Form1.PlaylistList.SelectedValue))
        Form1.Close()
        Text = playlistSelected.PlaylistName
        WebBrowser1.DocumentText = "<iframe width=""590"" height=""360"" src=""https://www.youtube.com/embed/?list=" & playlistSelected.PlaylistURLCode & "&autoplay=1&loop=1"" frameborder=""0"" allowfullscreen></iframe>"
    End Sub

    ''' <summary>
    ''' Allows ending program through notify icon
    ''' </summary>
    Private Sub ToolStripMenuItem1_Click() Handles ToolStripMenuItem1.Click
        End
    End Sub

End Class
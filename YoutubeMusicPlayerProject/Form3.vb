Public Class Form3

    Dim editPlaylist As PlaylistDBDataSet.PlaylistsRow

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorMsg.Text = ""
        ErrorMsg.Visible = False
        editPlaylist = Form1.PlaylistDBDataSet.Playlists.FindByID(Form1.PlaylistList.SelectedValue)
        TxtPlaylistName.Text = editPlaylist.PlaylistName
        TxtURLCode.Text = editPlaylist.PlaylistURLCode
        TextBox1.Text = editPlaylist.VideoURLCode

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ErrorMsg.Text = ""
        ErrorMsg.Visible = False
        Try
            If TxtPlaylistName.Text = "" OrElse TxtURLCode.Text = "" OrElse TextBox1.Text = "" Then
                Throw New System.ApplicationException("All fields must be filled")
            End If
            If TxtPlaylistName.Text <> editPlaylist.PlaylistName OrElse editPlaylist.PlaylistURLCode <> TxtURLCode.Text OrElse editPlaylist.VideoURLCode <> TextBox1.Text Then
                editPlaylist.PlaylistName = TxtPlaylistName.Text
                editPlaylist.PlaylistURLCode = TxtURLCode.Text
                editPlaylist.VideoURLCode = TextBox1.Text
                Form1.PlaylistsTableAdapter.Update(Form1.PlaylistDBDataSet.Playlists)
            End If
            Me.Close()
        Catch ex As ApplicationException
            ErrorMsg.Text = ex.Message
            ErrorMsg.Visible = True
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class
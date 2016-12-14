Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorMsg.Text = ""
        ErrorMsg.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ErrorMsg.Text = ""
        ErrorMsg.Visible = False
        Try
            If TxtPlaylistName.Text = "" OrElse TxtURLCode.Text = "" OrElse TextBox1.Text = "" Then
                Throw New System.ApplicationException("All fields must be filled")
            End If
            Dim userPlaylistRow As PlaylistDBDataSet.PlaylistsRow
            userPlaylistRow = Form1.PlaylistDBDataSet.Playlists.NewRow
            userPlaylistRow.PlaylistName = TxtPlaylistName.Text
            userPlaylistRow.PlaylistURLCode = TxtURLCode.Text
            userPlaylistRow.VideoURLCode = TextBox1.Text
            Form1.PlaylistDBDataSet.Playlists.Rows.Add(userPlaylistRow)
            Form1.PlaylistsTableAdapter.Update(Form1.PlaylistDBDataSet.Playlists)
            Form1.Show()
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

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class
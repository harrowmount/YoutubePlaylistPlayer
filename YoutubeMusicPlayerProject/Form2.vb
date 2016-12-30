'Form2 is used to create a new playlist row in the DB

Public Class Form2

    'Onload set error message to Null and make invisible
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorMsg.Text = ""
        ErrorMsg.Visible = False
    End Sub

    'OnClick fetch user entered values and set them to a new row object and push
    'the object to the DB. On success close the window and open form1, if fail
    'throw exception and make error message visible
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ErrorMsg.Text = ""
        ErrorMsg.Visible = False
        Try
            If TxtPlaylistName.Text = "" OrElse TxtURLCode.Text = "" Then
                Throw New ApplicationException("All fields must be filled")
            End If
            Dim userPlaylistRow As PlaylistDBDataSet.PlaylistsRow
            userPlaylistRow = Form1.PlaylistDBDataSet.Playlists.NewRow
            userPlaylistRow.PlaylistName = TxtPlaylistName.Text
            userPlaylistRow.PlaylistURLCode = TxtURLCode.Text
            Form1.PlaylistDBDataSet.Playlists.Rows.Add(userPlaylistRow)
            Form1.PlaylistsTableAdapter.Update(Form1.PlaylistDBDataSet.Playlists)
            Form1.Show()
            Close()
        Catch ex As ApplicationException
            ErrorMsg.Text = ex.Message
            ErrorMsg.Visible = True
        End Try
    End Sub

    'Close form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    'If form is closed show form1
    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        End
    End Sub

End Class
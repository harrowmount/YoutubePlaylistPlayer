
''' <summary>
''' Form 3 is the edit playlist form
''' </summary>
Public Class Form3

    Dim editPlaylist As PlaylistDBDataSet.PlaylistsRow

    ''' <summary>
    ''' On form load fetch userinput from form1 and use it to find correct row from DB
    ''' </summary>
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorMsg.Text = ""
        ErrorMsg.Visible = False
        editPlaylist = Form1.PlaylistDBDataSet.Playlists.FindByID(CInt(Form1.PlaylistList.SelectedValue))
        Form1.Close()
        TxtPlaylistName.Text = editPlaylist.PlaylistName
        TxtURLCode.Text = editPlaylist.PlaylistURLCode

    End Sub

    ''' <summary>
    ''' Submits user input to edit the selected row.
    ''' </summary>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ErrorMsg.Text = ""
        ErrorMsg.Visible = False
        Try
            If TxtPlaylistName.Text = "" OrElse TxtURLCode.Text = "" Then
                Throw New ApplicationException("All fields must be filled")
            End If
            If TxtPlaylistName.Text <> editPlaylist.PlaylistName OrElse editPlaylist.PlaylistURLCode <> TxtURLCode.Text Then
                editPlaylist.PlaylistName = TxtPlaylistName.Text
                editPlaylist.PlaylistURLCode = TxtURLCode.Text
                Form1.PlaylistsTableAdapter.Update(editPlaylist)
            End If
            Close()
        Catch ex As ApplicationException
            ErrorMsg.Text = ex.Message
            ErrorMsg.Visible = True
        End Try
    End Sub

    ''' <summary>
    ''' Closes form
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    ''' <summary>
    ''' On form close open form1
    ''' </summary>
    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    ''' <summary>
    ''' Allows ending program through notify icon
    ''' </summary>
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        End
    End Sub

End Class
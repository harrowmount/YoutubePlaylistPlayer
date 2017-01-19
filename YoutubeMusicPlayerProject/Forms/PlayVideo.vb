''' <summary>
''' Plays a single video
''' </summary>
Public Class PlayVideo

    ''' <summary>
    ''' On form close show form1
    ''' </summary>
    Private Sub Form5_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainMenu.Show()
    End Sub

    ''' <summary>
    ''' embeds an iframe inside a web browser that plays the selected video
    ''' </summary>
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim VideoURL As String = MainMenu.TextBox1.Text
        MainMenu.Close()
        WebBrowser1.DocumentText = "<iframe width=""590"" height=""360"" src=""https://www.youtube.com/embed/" & VideoURL & """ frameborder=""0"" allowfullscreen></iframe>"
    End Sub

    ''' <summary>
    ''' Allows ending program through notify icon
    ''' </summary>
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        End
    End Sub

End Class

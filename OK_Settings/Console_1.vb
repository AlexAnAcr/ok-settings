Public Class Console_1
    Dim objekt, mode As String, m As Boolean = True
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        objekt = ListBox1.SelectedItem
        mode = ListBox2.SelectedItem
        If ListBox2.SelectedIndex = -1 Then
            mode = "<mode>"
        End If
        TextBox1.Text = "/" & objekt & " " & mode
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Computer.Network.IsAvailable Then
            m = False
            Me.Close()
        Else
            MsgBox("You not have connection to Internet!", , "Error...")
        End If
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        objekt = ListBox1.SelectedItem
        If ListBox1.SelectedIndex = -1 Then
            objekt = "<object>"
        End If
        mode = ListBox2.SelectedItem
        TextBox1.Text = "/" & objekt & " " & mode
    End Sub
    Private Sub Console_1_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        If m = True Then
            MsgBox("Settings don't saved!", , "Messenge")
        End If
    End Sub
End Class
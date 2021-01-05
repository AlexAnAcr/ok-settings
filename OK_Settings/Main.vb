Public Class Main
    Dim file As String = Application.StartupPath + "/msd.dat"
    Dim data() As String
    Private Sub Main_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If My.Computer.FileSystem.FileExists(file) Then
            data = IO.File.ReadAllLines(file)
            If data(0) = 1 Then
                CheckBox1.Checked = True
            End If
            If data(1) = 1 Then
                CheckBox5.Checked = True
            End If
            If data(2) = 1 Then
                CheckBox6.Checked = True
            End If
            If data(3) = 1 Then
                CheckBox7.Checked = True
            End If
            If data(4) = 1 Then
                CheckBox2.Checked = True
            End If
            If data(5) = 1 Then
                CheckBox4.Checked = True
            End If
            If data(6) = 1 Then
                CheckBox3.Checked = True
            End If
        Else
            My.Computer.FileSystem.WriteAllText(file, "", False)
            Array.Resize(data, 7)
            data(0) = 0
            data(1) = 0
            data(2) = 0
            data(3) = 0
            data(4) = 0
            data(5) = 0
            data(6) = 0
            IO.File.WriteAllLines(file, data)
        End If
        If CheckBox1.Checked Then
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
        Else
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
        End If
network:
        If My.Computer.Network.IsAvailable = False Then
            Dim result As MsgBoxResult
            result = MsgBox("Нет соединения с сетью!", MsgBoxStyle.RetryCancel, "Ошибка")
            If result = MsgBoxResult.Retry Then
                GoTo network
            Else
                MeClosing.Enabled = True
            End If
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
        Else
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MeClosing.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            data(0) = 1
        Else
            data(0) = 0
        End If
        If CheckBox1.Checked = True And CheckBox5.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False Then
            CheckBox1.Checked = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            data(0) = 0
        End If
        If CheckBox5.Checked = True Then
            data(1) = 1
        Else
            data(1) = 0
        End If
        If CheckBox6.Checked = True Then
            data(2) = 1
        Else
            data(2) = 0
        End If
        If CheckBox7.Checked = True Then
            data(3) = 1
        Else
            data(3) = 0
        End If
        If CheckBox2.Checked = True Then
            data(4) = 1
        Else
            data(4) = 0
        End If
        If CheckBox4.Checked = True Then
            data(5) = 1
        Else
            data(5) = 0
        End If
        If CheckBox3.Checked = True Then
            data(6) = 1
        Else
            data(6) = 0
        End If
        IO.File.WriteAllLines(file, data)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If CheckBox1.Checked = True Then
            data(0) = 1
        Else
            data(0) = 0
        End If
        If CheckBox1.Checked = True And CheckBox5.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False Then
            data(0) = 0
        End If
        If CheckBox5.Checked = True Then
            data(1) = 1
        Else
            data(1) = 0
        End If
        If CheckBox6.Checked = True Then
            data(2) = 1
        Else
            data(2) = 0
        End If
        If CheckBox7.Checked = True Then
            data(3) = 1
        Else
            data(3) = 0
        End If
        If CheckBox2.Checked = True Then
            data(4) = 1
        Else
            data(4) = 0
        End If
        If CheckBox4.Checked = True Then
            data(5) = 1
        Else
            data(5) = 0
        End If
        If CheckBox3.Checked = True Then
            data(6) = 1
        Else
            data(6) = 0
        End If
        IO.File.WriteAllLines(file, data)
        MeClosing.Enabled = True
    End Sub
    Dim cancel As Boolean = True
    Private Sub MeClosing_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeClosing.Tick
        If Me.Left > -275 Then
            Me.Left -= 50
        Else
            MeClosing.Enabled = False
            cancel = False
            Me.Close()
        End If
    End Sub
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cancel = True Then
            e.Cancel = True
            MeClosing.Enabled = True
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Console_1.ShowDialog()
    End Sub
End Class

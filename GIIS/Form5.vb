
Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome To GIIS Script Runner")

        For Each FileName As String In IO.Directory.GetFiles("C:\Users\Sanjay\Desktop\GIIS FORMS\GIIS\GIIS\bin\Debug\customscripts")
            If IO.Path.GetExtension(FileName) = ".bat" Then
                ListBox1.Items.Add(IO.Path.GetFileNameWithoutExtension(FileName))
            End If

        Next FileName

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If (Trim(ListBox1.SelectedItem.ToString)) = "" Then
        'MsgBox("Please select a script")
        'ElseIf (Trim(TextBox1.Text) = "") Then
        'MsgBox("please select an application")
        'Else
        Process.Start("customscripts\" & ListBox1.SelectedItem.ToString)
        Timer1.Enabled = True
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.FileSystem.DeleteFile("customscripts\" & ListBox1.SelectedItem.ToString & ".pie")
        My.Computer.FileSystem.DeleteFile("customscripts\" & ListBox1.SelectedItem.ToString & ".bat")
        ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
        MsgBox("Script Deleted")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "PIEFree" Then
                prog.Kill()
            End If
        Next

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.FileName = "Open A File..."
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "Executable Files|*.exe"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sName As String = OpenFileDialog1.SafeFileName
            TextBox1.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Diagnostics.Process.Start(TextBox1.Text)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Diagnostics.Process.Start("customscripts\nfs.bat")
        'Diagnostics.Process.Start("C:\Program Files (x86)\EA Games\Need for Speed Most Wanted\NFS13.exe")
        Diagnostics.Process.Start("customscripts\nfs.bat")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Diagnostics.Process.Start("customscripts\cstRrike.bat")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Process.Start("customscripts\" & ListBox1.SelectedItem.ToString)

    End Sub

End Class
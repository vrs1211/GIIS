Imports System.IO
Imports System.Text
Imports System

Public Class Form4

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (Trim(TextBox1.Text) = "") Then
            MsgBox("Please Enter File Name")
        Else

            If My.Computer.FileSystem.FileExists("customscripts\" & TextBox1.Text & ".PIE") Then
                If (ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "") Then
                    MsgBox("Please Select Both Options")
                Else

                    My.Computer.FileSystem.WriteAllText("customscripts\" & TextBox1.Text & ".PIE", vbCrLf & ComboBox1.SelectedItem & " = " & "player1." & ComboBox2.SelectedItem, True)
                    Dim c1 As String = ComboBox1.SelectedItem
                    Dim c2 As String = ComboBox2.SelectedItem
                    ComboBox1.Items.Remove(c1)
                    ComboBox2.Items.Remove(c2)
                    MsgBox("Line Has Been Added")

                End If

            Else
                If (ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "") Then
                    MsgBox("Please Enter Both Options")
                Else

                    Dim path As String = "customscripts/" & TextBox1.Text & ".PIE"
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(ComboBox1.SelectedItem & " = " & "player1." & ComboBox2.SelectedItem)
                    fs.Write(info, 0, info.Length)
                    fs.Close()

                    Dim launcher As String = "customscripts/" & TextBox1.Text & ".bat"
                    Dim lfs As FileStream = File.Create(launcher)
                    Dim linfo As Byte() = New UTF8Encoding(True).GetBytes(Chr(34) & "glovepie/PIEFree.exe" & Chr(34) & " -" & "customscripts\" & Chr(34) & TextBox1.Text & ".pie" & Chr(34) & " /tray")
                    lfs.Write(linfo, 0, linfo.Length)
                    lfs.Close()

                    Dim c1 As String = ComboBox1.SelectedItem
                    Dim c2 As String = ComboBox2.SelectedItem
                    ComboBox1.Items.Remove(c1)
                    ComboBox2.Items.Remove(c2)
                    MsgBox("Line Has Been Added")
                End If

            End If

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If (Trim(TextBox1.Text) = "") Then
            MsgBox("Please Enter File Name")

        Else

            If My.Computer.FileSystem.FileExists("customscripts/" & TextBox1.Text & ".PIE") Then
                If (ComboBox3.SelectedItem = "" Or Trim(TextBox2.Text) = "") Then
                    MsgBox("Please Enter Both Options")
                Else

                    My.Computer.FileSystem.WriteAllText("customscripts/" & TextBox1.Text & ".PIE", vbCrLf & ComboBox3.SelectedItem & " = said(" & Chr(34) & TextBox2.Text & Chr(34) & ")", True)
                    Dim c1 As String = ComboBox1.SelectedItem
                    ComboBox3.Items.Remove(c1)
                    MsgBox("Voice Script Has Been Added")

                End If

            Else
                If (ComboBox3.SelectedItem = "" Or Trim(TextBox2.Text) = "") Then
                    MsgBox("Please Enter Both Options")
                Else

                    Dim path As String = "customscripts/" & TextBox1.Text & ".PIE"
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(ComboBox3.SelectedItem & " = said(" & Chr(34) & TextBox2.Text & Chr(34) & ")" & ComboBox2.SelectedItem)
                    fs.Write(info, 0, info.Length)
                    fs.Close()

                    Dim launcher As String = "customscripts/" & TextBox1.Text & ".bat"
                    Dim lfs As FileStream = File.Create(launcher)
                    Dim linfo As Byte() = New UTF8Encoding(True).GetBytes(Chr(34) & "glovepie/PIEFree.exe" & Chr(34) & " -" & "customscripts\" & Chr(34) & TextBox1.Text & ".pie" & Chr(34) & " /tray")
                    lfs.Write(linfo, 0, linfo.Length)
                    lfs.Close()

                    Dim c1 As String = ComboBox1.SelectedItem
                    ComboBox3.Items.Remove(c1)
                    MsgBox("Voice Script Added")

                End If

            End If

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Trim(TextBox1.Text) = "") Then
            MsgBox("Please Enter File Name")
        Else
            If My.Computer.FileSystem.FileExists("customscripts/" & TextBox1.Text & ".PIE") Then
                My.Computer.FileSystem.WriteAllText("customscripts/" & TextBox1.Text & ".PIE", v, True)
                MsgBox("Mouse Script Has Been Added")
                Button1.Enabled = False

            Else
                Dim path As String = "customscripts/" & TextBox1.Text & ".PIE"
                Dim fs As FileStream = File.Create(path)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(v)
                fs.Write(info, 0, info.Length)
                fs.Close()

                Dim launcher As String = "customscripts/" & TextBox1.Text & ".bat"
                Dim lfs As FileStream = File.Create(launcher)
                Dim linfo As Byte() = New UTF8Encoding(True).GetBytes(Chr(34) & "glovepie/PIEFree.exe" & Chr(34) & " -" & "customscripts\" & Chr(34) & TextBox1.Text & ".pie" & Chr(34) & " /tray")
                lfs.Write(linfo, 0, linfo.Length)
                lfs.Close()

                MsgBox("Mouse Script Has Been Added")
                Button1.Enabled = False

            End If

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If (Trim(TextBox1.Text) = "") Then
            MsgBox("Please Enter Script Name")
        Else
            RichTextBox1.Enabled = True
            RichTextBox1.Visible = True
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("customscripts/" & TextBox1.Text & ".PIE")
            RichTextBox1.Text = fileReader
        End If

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome To GIIS Custom Script Creator")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class
Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome To GIIS Setup")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Diagnostics.Process.Start("setup\bluesoleil\setup.exe")
        MessageBox.Show("Blue Soliel has Been Installed")

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Diagnostics.Process.Start("setup\KinectSDK-v1.0-beta2-x86.msi")
        MessageBox.Show("Kinect SDK Has Been Installed")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("Thank You Enjoy Our Software !!!!!!!")
        Form1.Show()
        Me.Hide()

    End Sub

End Class
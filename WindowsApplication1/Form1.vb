Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True
        PictureBox9.Visible = True
        PictureBox10.Visible = True
        PictureBox11.Visible = True
        PictureBox2.Top = PictureBox2.Top + 12
        PictureBox3.Top = PictureBox3.Top + 8
        PictureBox4.Top = PictureBox4.Top + 10
        PictureBox5.Top = PictureBox5.Top + 7
        PictureBox6.Top = PictureBox6.Top + 11
        PictureBox7.Top = PictureBox7.Top + 6
        PictureBox8.Top = PictureBox8.Top + 10
        PictureBox9.Top = PictureBox9.Top + 7
        PictureBox10.Top = PictureBox10.Top + 12
        PictureBox11.Top = PictureBox11.Top + 8

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Visible = False
        PictureBox1.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox13.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class

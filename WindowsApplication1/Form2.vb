Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox5.Visible = False
        PictureBox3.Visible = False
        PictureBox2.AllowDrop = True
        PictureBox7.AllowDrop = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        PictureBox8.Visible = False 'сделать 1 картинку невидимой
        Timer1.Enabled = False      'вюкл. первый таймер
        PictureBox9.Visible = True  'сделать  2 картинку видимой 
        Timer2.Enabled = True       'включить второй таймер
        Timer2.Interval = 400


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer4.Enabled = True

        Timer1.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PictureBox9.Visible = False 'сделать 1 картинку невидимой
        Timer2.Enabled = False      'вюкл. первый таймер
        PictureBox10.Visible = True  'сделать  2 картинку видимой 
        Timer3.Enabled = True       'включить второй таймер
        Timer3.Interval = 400
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        PictureBox10.Visible = False 'сделать 1 картинку невидимой
        Timer3.Enabled = False      'вюкл. первый таймер
        PictureBox8.Visible = True  'сделать  2 картинку видимой 
        Timer1.Enabled = True       'включить второй таймер
        Timer1.Interval = 400
    End Sub

    Private Sub PictureBox4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseDown
        PictureBox4.DoDragDrop(PictureBox4, DragDropEffects.Move)
    End Sub

    Private Sub PictureBox2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox2.DragDrop
        Dim pb As PictureBox
        pb = e.Data.GetData(GetType(PictureBox))
        pb.Hide()

        If pb.Tag = "солце" Then
            PictureBox2.Image = PictureBox4.Image
            PictureBox5.Visible = True

        End If

    End Sub

    Private Sub PictureBox2_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox2.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub PictureBox7_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox7.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub PictureBox6_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseDown
        PictureBox6.DoDragDrop(PictureBox6, DragDropEffects.Move)
    End Sub

    Private Sub PictureBox7_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox7.DragDrop
        Dim pb2 As PictureBox
        pb2 = e.Data.GetData(GetType(PictureBox))
        pb2.Hide()

        If pb2.Tag = "молня" Then
            PictureBox7.Image = PictureBox6.Image
            PictureBox3.Visible = True

        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        PictureBox12.Visible = True

        PictureBox12.Top = PictureBox12.Top + 25

    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

    End Sub
End Class
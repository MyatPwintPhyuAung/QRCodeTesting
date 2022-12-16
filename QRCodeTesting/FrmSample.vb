Imports MessagingToolkit.QRCode.Codec
Public Class FrmSample

    Private Sub FrmSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub
    Private Sub Clear()
        TxtFirst.Text = ""
        TxtLast.Text = ""
        TxtPhone.Text = ""
    End Sub
    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim QRGenerate As QRCodeEncoder = New QRCodeEncoder
        Dim img As Image
        Dim btn As Bitmap
        Dim str As String

        Dim Mp As String = " 1 "
        str = TxtFirst.Text + TxtLast.Text + TxtPhone.Text + "_" + Mp
        QRGenerate.QRCodeScale = 2
        img = QRGenerate.Encode(str)
        btn = New Bitmap(img)
        btn.Save("QRimage.jpg")
        PictureBox1.ImageLocation = "QRimage.jpg"
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Clear()
    End Sub
End Class
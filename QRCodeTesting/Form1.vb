Public Class FrmQRcodeSample
    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim generate As New MessagingToolkit.QRCode.Codec.QRCodeEncoder

        Try
            PictureBox1.Image = generate.Encode(TxtTesting.Text)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQRcodeSample
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.TxtTesting = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(144, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 135)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(287, 59)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(75, 34)
        Me.BtnGenerate.TabIndex = 1
        Me.BtnGenerate.Text = "&Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'TxtTesting
        '
        Me.TxtTesting.Location = New System.Drawing.Point(144, 59)
        Me.TxtTesting.Name = "TxtTesting"
        Me.TxtTesting.Size = New System.Drawing.Size(127, 20)
        Me.TxtTesting.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Test Here"
        '
        'FrmQRcodeSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 294)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTesting)
        Me.Controls.Add(Me.BtnGenerate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmQRcodeSample"
        Me.Text = "QR Code Sample"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents TxtTesting As TextBox
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fInfo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fInfo))
        RichTextBox1 = New RichTextBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.PapayaWhip
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Enabled = False
        RichTextBox1.Font = New Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(12, 122)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(776, 364)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Stencil", 19.8000011F)
        Label3.ForeColor = SystemColors.Highlight
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(207, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(356, 82)
        Label3.TabIndex = 11
        Label3.Text = "SISTEMA DE GESTION" & vbCrLf & "BIBLIOTECA UNP" & vbCrLf
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.fii_logo
        PictureBox2.ImeMode = ImeMode.NoControl
        PictureBox2.Location = New Point(569, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(118, 116)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Escudo_Universidad_Nacional_de_Piura
        PictureBox1.ImeMode = ImeMode.NoControl
        PictureBox1.Location = New Point(80, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(121, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' fInfo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(806, 497)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(RichTextBox1)
        Name = "fInfo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DETALLES DEL PROYECTO"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fLibro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fLibro))
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        SplitContainer1 = New SplitContainer()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtgeneroagregar = New TextBox()
        txtisbnagregar = New TextBox()
        txtautoragregar = New TextBox()
        txttituloagregar = New TextBox()
        btnAgregarLibro = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(423, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(293, 36)
        Label5.TabIndex = 20
        Label5.Text = "AGREGAR LIBRO"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(287, 151)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(3, 160)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel1.BackgroundImage"), Image)
        SplitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.Moccasin
        SplitContainer1.Panel2.Controls.Add(Label4)
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Panel2.Controls.Add(Label2)
        SplitContainer1.Panel2.Controls.Add(Label1)
        SplitContainer1.Panel2.Controls.Add(txtgeneroagregar)
        SplitContainer1.Panel2.Controls.Add(txtisbnagregar)
        SplitContainer1.Panel2.Controls.Add(txtautoragregar)
        SplitContainer1.Panel2.Controls.Add(txttituloagregar)
        SplitContainer1.Panel2.Controls.Add(btnAgregarLibro)
        SplitContainer1.Panel2.Margin = New Padding(10)
        SplitContainer1.Size = New Size(871, 342)
        SplitContainer1.SplitterDistance = 290
        SplitContainer1.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(57, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 19
        Label4.Text = "GENERO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(57, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 18
        Label3.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(57, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 20)
        Label2.TabIndex = 17
        Label2.Text = "AUTOR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(57, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 20)
        Label1.TabIndex = 16
        Label1.Text = "TITULO"
        ' 
        ' txtgeneroagregar
        ' 
        txtgeneroagregar.Location = New Point(157, 199)
        txtgeneroagregar.Name = "txtgeneroagregar"
        txtgeneroagregar.Size = New Size(382, 27)
        txtgeneroagregar.TabIndex = 15
        ' 
        ' txtisbnagregar
        ' 
        txtisbnagregar.Location = New Point(157, 155)
        txtisbnagregar.Name = "txtisbnagregar"
        txtisbnagregar.Size = New Size(382, 27)
        txtisbnagregar.TabIndex = 14
        ' 
        ' txtautoragregar
        ' 
        txtautoragregar.Location = New Point(157, 112)
        txtautoragregar.Name = "txtautoragregar"
        txtautoragregar.Size = New Size(382, 27)
        txtautoragregar.TabIndex = 13
        ' 
        ' txttituloagregar
        ' 
        txttituloagregar.Location = New Point(157, 69)
        txttituloagregar.Name = "txttituloagregar"
        txttituloagregar.Size = New Size(382, 27)
        txttituloagregar.TabIndex = 12
        ' 
        ' btnAgregarLibro
        ' 
        btnAgregarLibro.BackColor = Color.SpringGreen
        btnAgregarLibro.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgregarLibro.Location = New Point(224, 257)
        btnAgregarLibro.Name = "btnAgregarLibro"
        btnAgregarLibro.Size = New Size(105, 37)
        btnAgregarLibro.TabIndex = 11
        btnAgregarLibro.Text = "AGREGAR"
        btnAgregarLibro.UseVisualStyleBackColor = False
        ' 
        ' fLibro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(876, 502)
        Controls.Add(Label5)
        Controls.Add(PictureBox2)
        Controls.Add(SplitContainer1)
        Name = "fLibro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AGREGAR LIBRO"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtgeneroagregar As TextBox
    Friend WithEvents txtisbnagregar As TextBox
    Friend WithEvents txtautoragregar As TextBox
    Friend WithEvents txttituloagregar As TextBox
    Friend WithEvents btnAgregarLibro As Button

End Class

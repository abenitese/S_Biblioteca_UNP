<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fEstudiante))
        SplitContainer1 = New SplitContainer()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtaño = New TextBox()
        txtcarrera = New TextBox()
        txtnombre = New TextBox()
        btnagregar = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.BorderStyle = BorderStyle.Fixed3D
        SplitContainer1.Location = New Point(12, 113)
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
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Panel2.Controls.Add(Label2)
        SplitContainer1.Panel2.Controls.Add(Label1)
        SplitContainer1.Panel2.Controls.Add(txtaño)
        SplitContainer1.Panel2.Controls.Add(txtcarrera)
        SplitContainer1.Panel2.Controls.Add(txtnombre)
        SplitContainer1.Panel2.Controls.Add(btnagregar)
        SplitContainer1.Size = New Size(688, 325)
        SplitContainer1.SplitterDistance = 229
        SplitContainer1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(64, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 13
        Label3.Text = "AÑO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(64, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 12
        Label2.Text = "CARRERA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(64, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 11
        Label1.Text = "NOMBRE"
        ' 
        ' txtaño
        ' 
        txtaño.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtaño.Location = New Point(185, 169)
        txtaño.Name = "txtaño"
        txtaño.Size = New Size(201, 28)
        txtaño.TabIndex = 10
        ' 
        ' txtcarrera
        ' 
        txtcarrera.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtcarrera.Location = New Point(185, 108)
        txtcarrera.Name = "txtcarrera"
        txtcarrera.Size = New Size(201, 28)
        txtcarrera.TabIndex = 9
        ' 
        ' txtnombre
        ' 
        txtnombre.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtnombre.Location = New Point(185, 53)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(201, 28)
        txtnombre.TabIndex = 8
        ' 
        ' btnagregar
        ' 
        btnagregar.BackColor = Color.SpringGreen
        btnagregar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnagregar.Location = New Point(185, 227)
        btnagregar.Name = "btnagregar"
        btnagregar.Size = New Size(104, 41)
        btnagregar.TabIndex = 7
        btnagregar.Text = "AGREGAR"
        btnagregar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PapayaWhip
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(15, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(685, 104)
        Panel1.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(179, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(179, 98)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(364, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(252, 36)
        Label4.TabIndex = 8
        Label4.Text = "ESTUDIANTES"
        ' 
        ' fEstudiante
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(712, 450)
        Controls.Add(Panel1)
        Controls.Add(SplitContainer1)
        Name = "fEstudiante"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar Estudiante"
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtaño As TextBox
    Friend WithEvents txtcarrera As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnagregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class

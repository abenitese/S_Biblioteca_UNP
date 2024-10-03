<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fModificarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fModificarEstudiante))
        SplitContainer1 = New SplitContainer()
        btnmodificar = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtaño = New TextBox()
        txtcarrera = New TextBox()
        txtnombre = New TextBox()
        btnbuscar = New Button()
        dgvEstudiantes = New DataGridView()
        Label6 = New Label()
        txtbuscar = New TextBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.BorderStyle = BorderStyle.Fixed3D
        SplitContainer1.Location = New Point(10, 138)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(btnmodificar)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(txtaño)
        SplitContainer1.Panel1.Controls.Add(txtcarrera)
        SplitContainer1.Panel1.Controls.Add(txtnombre)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.Moccasin
        SplitContainer1.Panel2.Controls.Add(btnbuscar)
        SplitContainer1.Panel2.Controls.Add(dgvEstudiantes)
        SplitContainer1.Panel2.Controls.Add(Label6)
        SplitContainer1.Panel2.Controls.Add(txtbuscar)
        SplitContainer1.Size = New Size(1024, 309)
        SplitContainer1.SplitterDistance = 341
        SplitContainer1.TabIndex = 0
        ' 
        ' btnmodificar
        ' 
        btnmodificar.BackColor = Color.SpringGreen
        btnmodificar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnmodificar.Location = New Point(119, 239)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(119, 32)
        btnmodificar.TabIndex = 49
        btnmodificar.Text = "MODIFICAR"
        btnmodificar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(51, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 47
        Label3.Text = "AÑO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(51, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 46
        Label2.Text = "CARRERA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(51, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 45
        Label1.Text = "NOMBRE"
        ' 
        ' txtaño
        ' 
        txtaño.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtaño.Location = New Point(172, 176)
        txtaño.Name = "txtaño"
        txtaño.Size = New Size(125, 28)
        txtaño.TabIndex = 44
        ' 
        ' txtcarrera
        ' 
        txtcarrera.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtcarrera.Location = New Point(172, 122)
        txtcarrera.Name = "txtcarrera"
        txtcarrera.Size = New Size(125, 28)
        txtcarrera.TabIndex = 43
        ' 
        ' txtnombre
        ' 
        txtnombre.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtnombre.Location = New Point(172, 67)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(125, 28)
        txtnombre.TabIndex = 42
        ' 
        ' btnbuscar
        ' 
        btnbuscar.BackColor = Color.SpringGreen
        btnbuscar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnbuscar.Location = New Point(565, 23)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(94, 29)
        btnbuscar.TabIndex = 45
        btnbuscar.Text = "BUSCAR"
        btnbuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvEstudiantes
        ' 
        dgvEstudiantes.BackgroundColor = SystemColors.InactiveCaption
        dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEstudiantes.Location = New Point(23, 64)
        dgvEstudiantes.Name = "dgvEstudiantes"
        dgvEstudiantes.RowHeadersWidth = 51
        dgvEstudiantes.Size = New Size(636, 188)
        dgvEstudiantes.TabIndex = 44
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(23, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(213, 20)
        Label6.TabIndex = 43
        Label6.Text = "C.U/NOMBRE/CARRERA"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbuscar.Location = New Point(259, 25)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(300, 28)
        txtbuscar.TabIndex = 42
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(13, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1021, 120)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(169, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(264, 117)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 50
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(464, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(252, 72)
        Label4.TabIndex = 49
        Label4.Text = "MODIFICAR" & vbCrLf & "ESTUDIANTES" & vbCrLf
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' fModificarEstudiante
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(1046, 464)
        Controls.Add(Panel1)
        Controls.Add(SplitContainer1)
        Name = "fModificarEstudiante"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModificarEstudiante"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnmodificar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtaño As TextBox
    Friend WithEvents txtcarrera As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dgvEstudiantes As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class

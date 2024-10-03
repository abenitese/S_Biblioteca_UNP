<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fModificarLibro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fModificarLibro))
        SplitContainer1 = New SplitContainer()
        btnmodificar = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtgeneromodificar = New TextBox()
        txtisbnmodificar = New TextBox()
        txtautormodificar = New TextBox()
        txttitulomodificar = New TextBox()
        btnbuscar = New Button()
        dgvLibros = New DataGridView()
        Label6 = New Label()
        txtbuscar = New TextBox()
        Label5 = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.BorderStyle = BorderStyle.FixedSingle
        SplitContainer1.Location = New Point(-2, 201)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.PapayaWhip
        SplitContainer1.Panel1.Controls.Add(btnmodificar)
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(txtgeneromodificar)
        SplitContainer1.Panel1.Controls.Add(txtisbnmodificar)
        SplitContainer1.Panel1.Controls.Add(txtautormodificar)
        SplitContainer1.Panel1.Controls.Add(txttitulomodificar)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(btnbuscar)
        SplitContainer1.Panel2.Controls.Add(dgvLibros)
        SplitContainer1.Panel2.Controls.Add(Label6)
        SplitContainer1.Panel2.Controls.Add(txtbuscar)
        SplitContainer1.Size = New Size(1081, 423)
        SplitContainer1.SplitterDistance = 360
        SplitContainer1.TabIndex = 25
        ' 
        ' btnmodificar
        ' 
        btnmodificar.BackColor = Color.SpringGreen
        btnmodificar.Location = New Point(117, 323)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(103, 29)
        btnmodificar.TabIndex = 34
        btnmodificar.Text = "MODIFICAR"
        btnmodificar.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(50, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 32
        Label4.Text = "GÉNERO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(50, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 31
        Label3.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(50, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 20)
        Label2.TabIndex = 30
        Label2.Text = "AUTOR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(50, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 20)
        Label1.TabIndex = 29
        Label1.Text = "TITULO"
        ' 
        ' txtgeneromodificar
        ' 
        txtgeneromodificar.Location = New Point(185, 251)
        txtgeneromodificar.Name = "txtgeneromodificar"
        txtgeneromodificar.Size = New Size(125, 27)
        txtgeneromodificar.TabIndex = 28
        ' 
        ' txtisbnmodificar
        ' 
        txtisbnmodificar.Location = New Point(185, 207)
        txtisbnmodificar.Name = "txtisbnmodificar"
        txtisbnmodificar.Size = New Size(125, 27)
        txtisbnmodificar.TabIndex = 27
        ' 
        ' txtautormodificar
        ' 
        txtautormodificar.Location = New Point(185, 164)
        txtautormodificar.Name = "txtautormodificar"
        txtautormodificar.Size = New Size(125, 27)
        txtautormodificar.TabIndex = 26
        ' 
        ' txttitulomodificar
        ' 
        txttitulomodificar.Location = New Point(185, 121)
        txttitulomodificar.Name = "txttitulomodificar"
        txttitulomodificar.Size = New Size(125, 27)
        txttitulomodificar.TabIndex = 25
        ' 
        ' btnbuscar
        ' 
        btnbuscar.BackColor = Color.SpringGreen
        btnbuscar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnbuscar.Location = New Point(608, 91)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(94, 29)
        btnbuscar.TabIndex = 27
        btnbuscar.Text = "BUSCAR"
        btnbuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvLibros
        ' 
        dgvLibros.BackgroundColor = SystemColors.InactiveCaption
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Location = New Point(15, 143)
        dgvLibros.Name = "dgvLibros"
        dgvLibros.RowHeadersWidth = 51
        dgvLibros.Size = New Size(682, 188)
        dgvLibros.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(15, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 20)
        Label6.TabIndex = 25
        Label6.Text = "LIBRO/AUTOR"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbuscar.Location = New Point(162, 92)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(440, 28)
        txtbuscar.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(519, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(331, 36)
        Label5.TabIndex = 33
        Label5.Text = "MODIFICAR LIBRO"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(5, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1074, 183)
        Panel1.TabIndex = 34
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(127, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(375, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' fModificarLibro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(1091, 625)
        Controls.Add(Panel1)
        Controls.Add(SplitContainer1)
        Name = "fModificarLibro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModificarLibro"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnmodificar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtgeneromodificar As TextBox
    Friend WithEvents txtisbnmodificar As TextBox
    Friend WithEvents txtautormodificar As TextBox
    Friend WithEvents txttitulomodificar As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class

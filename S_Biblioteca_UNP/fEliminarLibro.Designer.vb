<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEliminarLibro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fEliminarLibro))
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label1 = New Label()
        txtbuscar = New TextBox()
        btnbuscar = New Button()
        dgvLibros = New DataGridView()
        btneliminar = New Button()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.PapayaWhip
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(21, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(721, 150)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(38, 18)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(318, 126)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(395, 62)
        Label5.Name = "Label5"
        Label5.Size = New Size(303, 36)
        Label5.TabIndex = 22
        Label5.Text = "ELIMINAR LIBRO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(59, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 18)
        Label1.TabIndex = 8
        Label1.Text = "BUSCAR POR TÍTULO : "
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbuscar.Location = New Point(248, 182)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(394, 32)
        txtbuscar.TabIndex = 7
        ' 
        ' btnbuscar
        ' 
        btnbuscar.BackColor = Color.SpringGreen
        btnbuscar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnbuscar.Location = New Point(649, 180)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(93, 34)
        btnbuscar.TabIndex = 6
        btnbuscar.Text = "BUSCAR"
        btnbuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvLibros
        ' 
        dgvLibros.BackgroundColor = SystemColors.ActiveCaption
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Location = New Point(21, 219)
        dgvLibros.Name = "dgvLibros"
        dgvLibros.RowHeadersWidth = 51
        dgvLibros.Size = New Size(721, 221)
        dgvLibros.TabIndex = 5
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = Color.SpringGreen
        btneliminar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btneliminar.Location = New Point(350, 446)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(111, 34)
        btneliminar.TabIndex = 10
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' fEliminarLibro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(763, 503)
        Controls.Add(btneliminar)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(txtbuscar)
        Controls.Add(btnbuscar)
        Controls.Add(dgvLibros)
        Name = "fEliminarLibro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Eliminar Libro"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents btneliminar As Button
End Class

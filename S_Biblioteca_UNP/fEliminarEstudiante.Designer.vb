<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEliminarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fEliminarEstudiante))
        btneliminar = New Button()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label1 = New Label()
        txtbuscar = New TextBox()
        btnbuscar = New Button()
        dgvEstudiantes = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = Color.SpringGreen
        btneliminar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btneliminar.Location = New Point(379, 445)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(111, 34)
        btneliminar.TabIndex = 16
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.PapayaWhip
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(808, 150)
        GroupBox1.TabIndex = 15
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
        Label5.Size = New Size(412, 36)
        Label5.TabIndex = 22
        Label5.Text = "ELIMINAR ESTUDIANTE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(78, 190)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 18)
        Label1.TabIndex = 14
        Label1.Text = "BUSCAR POR NOMBRE : "
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbuscar.Location = New Point(277, 181)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(394, 32)
        txtbuscar.TabIndex = 13
        ' 
        ' btnbuscar
        ' 
        btnbuscar.BackColor = Color.SpringGreen
        btnbuscar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnbuscar.Location = New Point(678, 179)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(93, 34)
        btnbuscar.TabIndex = 12
        btnbuscar.Text = "BUSCAR"
        btnbuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvEstudiantes
        ' 
        dgvEstudiantes.BackgroundColor = SystemColors.ActiveCaption
        dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEstudiantes.Location = New Point(50, 218)
        dgvEstudiantes.Name = "dgvEstudiantes"
        dgvEstudiantes.RowHeadersWidth = 51
        dgvEstudiantes.Size = New Size(721, 221)
        dgvEstudiantes.TabIndex = 11
        ' 
        ' fEliminarEstudiante
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(844, 494)
        Controls.Add(btneliminar)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(txtbuscar)
        Controls.Add(btnbuscar)
        Controls.Add(dgvEstudiantes)
        Name = "fEliminarEstudiante"
        StartPosition = FormStartPosition.CenterScreen
        Text = "fEliminarEstudiante"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btneliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dgvEstudiantes As DataGridView
End Class

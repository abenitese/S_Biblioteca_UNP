<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fModificarPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fModificarPrestamo))
        Label1 = New Label()
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        btnbuscar = New Button()
        dgvPrestamos = New DataGridView()
        Label6 = New Label()
        txtbuscar = New TextBox()
        btndevolver = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(dgvPrestamos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(418, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 36)
        Label1.TabIndex = 22
        Label1.Text = "PRÉSTAMO"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Moccasin
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(btnbuscar)
        Panel1.Controls.Add(dgvPrestamos)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtbuscar)
        Panel1.Controls.Add(btndevolver)
        Panel1.Location = New Point(12, 119)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(778, 387)
        Panel1.TabIndex = 23
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"CÓDIGO UNIVERSITARIO", "LIBRO", "AUTOR"})
        ComboBox1.Location = New Point(302, 25)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(303, 36)
        ComboBox1.TabIndex = 35
        ' 
        ' btnbuscar
        ' 
        btnbuscar.BackColor = Color.SpringGreen
        btnbuscar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnbuscar.Location = New Point(612, 80)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(94, 35)
        btnbuscar.TabIndex = 34
        btnbuscar.Text = "BUSCAR"
        btnbuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvPrestamos
        ' 
        dgvPrestamos.BackgroundColor = SystemColors.InactiveCaption
        dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPrestamos.Location = New Point(70, 121)
        dgvPrestamos.Name = "dgvPrestamos"
        dgvPrestamos.RowHeadersWidth = 51
        dgvPrestamos.Size = New Size(636, 188)
        dgvPrestamos.TabIndex = 33
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(70, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(191, 28)
        Label6.TabIndex = 32
        Label6.Text = "BUSCAR POR : "
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbuscar.Location = New Point(302, 78)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(303, 35)
        txtbuscar.TabIndex = 31
        ' 
        ' btndevolver
        ' 
        btndevolver.BackColor = Color.SpringGreen
        btndevolver.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btndevolver.Location = New Point(302, 315)
        btndevolver.Name = "btndevolver"
        btndevolver.Size = New Size(156, 62)
        btndevolver.TabIndex = 30
        btndevolver.Text = "DEVOLVER LIBRO"
        btndevolver.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(391, 101)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' fModificarPrestamo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(802, 518)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "fModificarPrestamo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModificarPrestamo"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvPrestamos, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlibro As TextBox
    Friend WithEvents txtestudiante As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dgvPrestamos As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btndevolver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

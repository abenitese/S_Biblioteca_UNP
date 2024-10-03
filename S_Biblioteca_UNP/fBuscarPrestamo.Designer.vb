<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBuscarPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBuscarPrestamo))
        btnbuscar = New Button()
        dgvprestamo = New DataGridView()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(dgvprestamo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnbuscar
        ' 
        btnbuscar.BackColor = Color.LimeGreen
        btnbuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnbuscar.Location = New Point(840, 20)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(134, 29)
        btnbuscar.TabIndex = 0
        btnbuscar.Text = "BUSCAR"
        btnbuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvprestamo
        ' 
        dgvprestamo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvprestamo.Location = New Point(0, 75)
        dgvprestamo.Name = "dgvprestamo"
        dgvprestamo.RowHeadersWidth = 51
        dgvprestamo.Size = New Size(974, 200)
        dgvprestamo.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Moccasin
        Panel1.Controls.Add(dgvprestamo)
        Panel1.Controls.Add(btnbuscar)
        Panel1.Location = New Point(12, 124)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(980, 287)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(974, 106)
        Panel2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(572, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 45)
        Label1.TabIndex = 0
        Label1.Text = "PRESTAMOS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(537, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' fBuscarPrestamo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(1004, 419)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "fBuscarPrestamo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BuscarPrestamo"
        CType(dgvprestamo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnbuscar As Button
    Friend WithEvents dgvprestamo As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

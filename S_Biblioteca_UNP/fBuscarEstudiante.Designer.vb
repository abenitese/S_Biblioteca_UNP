<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBuscarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBuscarEstudiante))
        Panel1 = New Panel()
        txtestudiantebuscarnombre = New TextBox()
        Label1 = New Label()
        btnbuscar = New Button()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Moccasin
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txtestudiantebuscarnombre)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnbuscar)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(12, 143)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(614, 264)
        Panel1.TabIndex = 0
        ' 
        ' txtestudiantebuscarnombre
        ' 
        txtestudiantebuscarnombre.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtestudiantebuscarnombre.Location = New Point(235, 18)
        txtestudiantebuscarnombre.Name = "txtestudiantebuscarnombre"
        txtestudiantebuscarnombre.Size = New Size(252, 32)
        txtestudiantebuscarnombre.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 18)
        Label1.TabIndex = 16
        Label1.Text = "BUSCAR POR NOMBRE : "
        ' 
        ' btnbuscar
        ' 
        btnbuscar.BackColor = Color.SpringGreen
        btnbuscar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnbuscar.Location = New Point(502, 22)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(94, 29)
        btnbuscar.TabIndex = 15
        btnbuscar.Text = "BUSCAR"
        btnbuscar.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(18, 57)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(578, 188)
        DataGridView1.TabIndex = 14
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.PapayaWhip
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(614, 125)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(318, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(271, 25)
        Label2.TabIndex = 17
        Label2.Text = "BUSCAR ESTUDIANTES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(309, 119)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' fBuscarEstudiante
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(639, 419)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "fBuscarEstudiante"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BuscarEstudiante"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtestudiantebuscarnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class

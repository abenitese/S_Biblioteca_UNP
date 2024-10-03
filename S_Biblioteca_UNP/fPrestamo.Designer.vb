<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPrestamo))
        SplitContainer1 = New SplitContainer()
        Label4 = New Label()
        MonthCalendar1 = New MonthCalendar()
        cblibros = New ComboBox()
        cbestudiantes = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        btnprestar = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(12, 174)
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
        SplitContainer1.Panel2.Controls.Add(MonthCalendar1)
        SplitContainer1.Panel2.Controls.Add(cblibros)
        SplitContainer1.Panel2.Controls.Add(cbestudiantes)
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Panel2.Controls.Add(Label2)
        SplitContainer1.Panel2.Controls.Add(btnprestar)
        SplitContainer1.Size = New Size(776, 469)
        SplitContainer1.SplitterDistance = 258
        SplitContainer1.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 56)
        Label4.TabIndex = 29
        Label4.Text = "FECHA" & vbCrLf & "DEVOLUVION"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(202, 164)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 28
        ' 
        ' cblibros
        ' 
        cblibros.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cblibros.FormattingEnabled = True
        cblibros.Location = New Point(202, 111)
        cblibros.Name = "cblibros"
        cblibros.Size = New Size(290, 36)
        cblibros.TabIndex = 27
        ' 
        ' cbestudiantes
        ' 
        cbestudiantes.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbestudiantes.FormattingEnabled = True
        cbestudiantes.Location = New Point(202, 54)
        cbestudiantes.Name = "cbestudiantes"
        cbestudiantes.Size = New Size(290, 36)
        cbestudiantes.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(20, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 28)
        Label3.TabIndex = 25
        Label3.Text = "LIBRO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 28)
        Label2.TabIndex = 24
        Label2.Text = "C.U"
        ' 
        ' btnprestar
        ' 
        btnprestar.BackColor = Color.SpringGreen
        btnprestar.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnprestar.Location = New Point(202, 383)
        btnprestar.Name = "btnprestar"
        btnprestar.Size = New Size(100, 29)
        btnprestar.TabIndex = 23
        btnprestar.Text = "PRESTAR"
        btnprestar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PapayaWhip
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 156)
        Panel1.TabIndex = 18
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(449, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(464, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 36)
        Label1.TabIndex = 17
        Label1.Text = "PRÉSTAMO"
        ' 
        ' fPrestamo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 655)
        Controls.Add(Panel1)
        Controls.Add(SplitContainer1)
        Name = "fPrestamo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Prestamo"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents cblibros As ComboBox
    Friend WithEvents cbestudiantes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnprestar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class

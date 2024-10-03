<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPrincipal2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPrincipal2))
        MenuStrip1 = New MenuStrip()
        GESTIONToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        AGREGARToolStripMenuItem = New ToolStripMenuItem()
        BUSCARToolStripMenuItem = New ToolStripMenuItem()
        MODIFICARToolStripMenuItem = New ToolStripMenuItem()
        ESTUDIANTESToolStripMenuItem = New ToolStripMenuItem()
        AGREGARToolStripMenuItem1 = New ToolStripMenuItem()
        BUSCARToolStripMenuItem1 = New ToolStripMenuItem()
        MODIFICARToolStripMenuItem1 = New ToolStripMenuItem()
        PRESTAMOSToolStripMenuItem1 = New ToolStripMenuItem()
        AGREGARToolStripMenuItem2 = New ToolStripMenuItem()
        BUSCARToolStripMenuItem2 = New ToolStripMenuItem()
        MODIFICARToolStripMenuItem2 = New ToolStripMenuItem()
        ACERCADEToolStripMenuItem = New ToolStripMenuItem()
        SALIRToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Moccasin
        MenuStrip1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {GESTIONToolStripMenuItem, SALIRToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 58)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GESTIONToolStripMenuItem
        ' 
        GESTIONToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem1, ESTUDIANTESToolStripMenuItem, PRESTAMOSToolStripMenuItem1, ACERCADEToolStripMenuItem})
        GESTIONToolStripMenuItem.Image = My.Resources.Resources.icons8_books_50
        GESTIONToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        GESTIONToolStripMenuItem.Name = "GESTIONToolStripMenuItem"
        GESTIONToolStripMenuItem.Size = New Size(179, 54)
        GESTIONToolStripMenuItem.Text = "GESTION"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {AGREGARToolStripMenuItem, BUSCARToolStripMenuItem, MODIFICARToolStripMenuItem})
        ToolStripMenuItem1.Image = My.Resources.Resources.icons8_books_50
        ToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(303, 70)
        ToolStripMenuItem1.Text = "LIBROS"
        ' 
        ' AGREGARToolStripMenuItem
        ' 
        AGREGARToolStripMenuItem.Image = My.Resources.Resources.icons8_add_book_48
        AGREGARToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        AGREGARToolStripMenuItem.Name = "AGREGARToolStripMenuItem"
        AGREGARToolStripMenuItem.Size = New Size(262, 56)
        AGREGARToolStripMenuItem.Text = "AGREGAR"
        ' 
        ' BUSCARToolStripMenuItem
        ' 
        BUSCARToolStripMenuItem.Image = My.Resources.Resources.icons8_view_50
        BUSCARToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        BUSCARToolStripMenuItem.Name = "BUSCARToolStripMenuItem"
        BUSCARToolStripMenuItem.Size = New Size(262, 56)
        BUSCARToolStripMenuItem.Text = "BUSCAR"
        ' 
        ' MODIFICARToolStripMenuItem
        ' 
        MODIFICARToolStripMenuItem.Image = CType(resources.GetObject("MODIFICARToolStripMenuItem.Image"), Image)
        MODIFICARToolStripMenuItem.ImageAlign = ContentAlignment.BottomCenter
        MODIFICARToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        MODIFICARToolStripMenuItem.Name = "MODIFICARToolStripMenuItem"
        MODIFICARToolStripMenuItem.Size = New Size(262, 56)
        MODIFICARToolStripMenuItem.Text = "MODIFICAR"
        ' 
        ' ESTUDIANTESToolStripMenuItem
        ' 
        ESTUDIANTESToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AGREGARToolStripMenuItem1, BUSCARToolStripMenuItem1, MODIFICARToolStripMenuItem1})
        ESTUDIANTESToolStripMenuItem.Image = My.Resources.Resources.icons8_student_male_50
        ESTUDIANTESToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ESTUDIANTESToolStripMenuItem.Name = "ESTUDIANTESToolStripMenuItem"
        ESTUDIANTESToolStripMenuItem.Size = New Size(303, 70)
        ESTUDIANTESToolStripMenuItem.Text = "ESTUDIANTES"
        ' 
        ' AGREGARToolStripMenuItem1
        ' 
        AGREGARToolStripMenuItem1.Image = CType(resources.GetObject("AGREGARToolStripMenuItem1.Image"), Image)
        AGREGARToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        AGREGARToolStripMenuItem1.Name = "AGREGARToolStripMenuItem1"
        AGREGARToolStripMenuItem1.Size = New Size(262, 56)
        AGREGARToolStripMenuItem1.Text = "AGREGAR"
        ' 
        ' BUSCARToolStripMenuItem1
        ' 
        BUSCARToolStripMenuItem1.Image = CType(resources.GetObject("BUSCARToolStripMenuItem1.Image"), Image)
        BUSCARToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        BUSCARToolStripMenuItem1.Name = "BUSCARToolStripMenuItem1"
        BUSCARToolStripMenuItem1.Size = New Size(262, 56)
        BUSCARToolStripMenuItem1.Text = "BUSCAR"
        ' 
        ' MODIFICARToolStripMenuItem1
        ' 
        MODIFICARToolStripMenuItem1.Image = CType(resources.GetObject("MODIFICARToolStripMenuItem1.Image"), Image)
        MODIFICARToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        MODIFICARToolStripMenuItem1.Name = "MODIFICARToolStripMenuItem1"
        MODIFICARToolStripMenuItem1.Size = New Size(262, 56)
        MODIFICARToolStripMenuItem1.Text = "MODIFICAR"
        ' 
        ' PRESTAMOSToolStripMenuItem1
        ' 
        PRESTAMOSToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {AGREGARToolStripMenuItem2, BUSCARToolStripMenuItem2, MODIFICARToolStripMenuItem2})
        PRESTAMOSToolStripMenuItem1.Image = My.Resources.Resources.icons8_book_philosophy_50
        PRESTAMOSToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        PRESTAMOSToolStripMenuItem1.Name = "PRESTAMOSToolStripMenuItem1"
        PRESTAMOSToolStripMenuItem1.Size = New Size(303, 70)
        PRESTAMOSToolStripMenuItem1.Text = "PRESTAMOS"
        ' 
        ' AGREGARToolStripMenuItem2
        ' 
        AGREGARToolStripMenuItem2.Image = CType(resources.GetObject("AGREGARToolStripMenuItem2.Image"), Image)
        AGREGARToolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None
        AGREGARToolStripMenuItem2.Name = "AGREGARToolStripMenuItem2"
        AGREGARToolStripMenuItem2.Size = New Size(262, 56)
        AGREGARToolStripMenuItem2.Text = "AGREGAR"
        ' 
        ' BUSCARToolStripMenuItem2
        ' 
        BUSCARToolStripMenuItem2.Image = CType(resources.GetObject("BUSCARToolStripMenuItem2.Image"), Image)
        BUSCARToolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None
        BUSCARToolStripMenuItem2.Name = "BUSCARToolStripMenuItem2"
        BUSCARToolStripMenuItem2.Size = New Size(262, 56)
        BUSCARToolStripMenuItem2.Text = "BUSCAR"
        ' 
        ' MODIFICARToolStripMenuItem2
        ' 
        MODIFICARToolStripMenuItem2.Image = My.Resources.Resources.edit_document_file_icon_1234911
        MODIFICARToolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None
        MODIFICARToolStripMenuItem2.Name = "MODIFICARToolStripMenuItem2"
        MODIFICARToolStripMenuItem2.Size = New Size(262, 56)
        MODIFICARToolStripMenuItem2.Text = "MODIFICAR"
        ' 
        ' ACERCADEToolStripMenuItem
        ' 
        ACERCADEToolStripMenuItem.Image = My.Resources.Resources.icons8_bookmark_book_64
        ACERCADEToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ACERCADEToolStripMenuItem.Name = "ACERCADEToolStripMenuItem"
        ACERCADEToolStripMenuItem.Size = New Size(303, 70)
        ACERCADEToolStripMenuItem.Text = "ACERCA DE"
        ' 
        ' SALIRToolStripMenuItem
        ' 
        SALIRToolStripMenuItem.BackColor = Color.PapayaWhip
        SALIRToolStripMenuItem.Image = My.Resources.Resources.icons8_exit_sign_50
        SALIRToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        SALIRToolStripMenuItem.Size = New Size(146, 54)
        SALIRToolStripMenuItem.Text = "SALIR"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Lime
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(12, 345)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 96)
        Label1.TabIndex = 5
        Label1.Text = "Cerrar Sesion"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' fPrincipal2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        Name = "fPrincipal2"
        Text = "fPrincipal2"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GESTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AGREGARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BUSCARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ESTUDIANTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AGREGARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BUSCARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PRESTAMOSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AGREGARToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BUSCARToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ACERCADEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class

Public Class fPrincipal
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Close()
        End
    End Sub

    Private Sub AGREGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGREGARToolStripMenuItem.Click
        fLibro.ShowDialog()
    End Sub

    Private Sub AGREGARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AGREGARToolStripMenuItem1.Click
        fEstudiante.ShowDialog()
    End Sub

    Private Sub AGREGARToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AGREGARToolStripMenuItem2.Click
        fPrestamo.ShowDialog()
    End Sub

    Private Sub BUSCARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem1.Click
        fBuscarEstudiante.ShowDialog()
    End Sub

    Private Sub BUSCARToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem2.Click
        fBuscarPrestamo.ShowDialog()
    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        fBuscarLibro.ShowDialog()
    End Sub

    Private Sub MODIFICARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem.Click
        fModificarLibro.ShowDialog()
    End Sub

    Private Sub MODIFICARToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem2.Click
        fModificarPrestamo.ShowDialog()
    End Sub

    Private Sub MODIFICARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem1.Click
        fModificarEstudiante.ShowDialog()
    End Sub

    Private Sub ACERCADEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACERCADEToolStripMenuItem.Click
        fInfo.ShowDialog()
    End Sub

    Private Sub btncerrarsesion_Click(sender As Object, e As EventArgs)
        Close()
        fLogin.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        fLogin.Show()
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        fEliminarLibro.ShowDialog()
    End Sub

    Private Sub ELIMINARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem1.Click
        fEliminarEstudiante.ShowDialog()
    End Sub
End Class
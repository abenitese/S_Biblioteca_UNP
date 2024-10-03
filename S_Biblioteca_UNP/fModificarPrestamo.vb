Imports MySql.Data.MySqlClient

Public Class fModificarPrestamo

    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        BuscarPrestamo(txtbuscar.Text)
    End Sub
    Sub BuscarPrestamo(palabraBusqueda As String)
        Try
            connection.Close()
            connection.Open()
            Dim query = "SELECT p.Cod_Prestamo,p.Cod_Estudiante,e.Nombre, p.Cod_Libro,l.Titulo, p.FechaPrestamo,p.FechaDevolucion FROM prestamos p INNER JOIN estudiantes e on p.Cod_Estudiante=e.Cod_Estudiante INNER JOIN libros l on p.Cod_Libro=l.Cod_Libro WHERE e.Nombre LIKE @busqueda OR l.Titulo LIKE @busqueda AND Estado=1"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@busqueda", "%" & palabraBusqueda & "%")

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvPrestamos.DataSource = table
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btndevolver.Click
        ' Verificar que se haya seleccionado un registro en el DataGridView
        If dgvPrestamos.SelectedRows.Count > 0 Then
            Dim codPrestamo As Integer = dgvPrestamos.SelectedRows(0).Cells("Cod_Prestamo").Value

            ' Confirmar eliminación
            Dim confirmacion = MessageBox.Show("¿Estás seguro de que deseas Realizar devoluvion?", "Confirmar Devolucion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.Yes Then
                EliminarPrestamo(codPrestamo)
                ActualizarEstadoLibro(codPrestamo)

            End If
        Else
            MessageBox.Show("Por favor, selecciona un registro para devolver.")
        End If
    End Sub

    Sub EliminarPrestamo(codPrestamo As Integer)
        Try
            connection.Open()
            Dim query As String = "DELETE FROM prestamos WHERE Cod_Prestamo = @Cod_Prestamo"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Cod_Prestamo", codPrestamo)

            Dim resultado As Integer = command.ExecuteNonQuery()
            If resultado > 0 Then
                MessageBox.Show("Devolucion realizada exitosamente.")
                BuscarPrestamo(txtbuscar.Text) ' Recargar los prestamos después de devolver
            Else
                MessageBox.Show("No se pudo Realizar la devolucion.")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error al Realizar el devolucion: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Sub ActualizarEstadoLibro(codLibro As Integer)

        Try
            connection.Open()
            Dim query As String = "UPDATE libros SET Estado = 1 WHERE Cod_Libro = @Cod_Libro"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Cod_Libro", codLibro)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el estado del libro: " & ex.Message)
        End Try
    End Sub
End Class
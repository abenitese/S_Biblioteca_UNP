Imports MySql.Data.MySqlClient

Public Class fEliminarEstudiante
    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        BuscarEstudiante(txtbuscar.Text)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        ' Verificar que se haya seleccionado un registro en el DataGridView
        If dgvEstudiantes.SelectedRows.Count > 0 Then
            Dim codigo As Integer = dgvEstudiantes.SelectedRows(0).Cells("Cod_Estudiante").Value

            ' Confirmar eliminación
            Dim confirmacion = MessageBox.Show("¿Estás seguro de que deseas Eliminar Estudiante?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.Yes Then
                EliminarEstudiante(codigo)
            End If
        Else
            MessageBox.Show("Por favor, selecciona un registro para Eliminar.")
        End If
    End Sub
    Sub BuscarEstudiante(palabraBusqueda As String)
        Try
            connection.Close()
            connection.Open()
            Dim query = "SELECT Cod_Estudiante,Nombre,Carrera,Año FROM estudiantes WHERE nombre LIKE @busqueda"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@busqueda", "%" & palabraBusqueda & "%")

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvEstudiantes.DataSource = table
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Sub EliminarEstudiante(codEstudiante As Integer)
        Try
            connection.Open()
            Dim query As String = "DELETE FROM estudiantes WHERE Cod_Estudiante = @Cod_Estudiante"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Cod_Estudiante", codEstudiante)

            Dim resultado As Integer = command.ExecuteNonQuery()
            If resultado > 0 Then
                MessageBox.Show("Eliminacion realizada exitosamente.")
                BuscarEstudiante(txtbuscar.Text) ' Recargar los prestamos después de devolver
            Else
                MessageBox.Show("No se pudo Realizar la Eliminacion.")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error al Realizar el Eliminacion: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub fEliminarEstudiante_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dgvEstudiantes.DataSource = Nothing
    End Sub
End Class
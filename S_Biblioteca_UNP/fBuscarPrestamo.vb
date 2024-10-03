Imports MySql.Data.MySqlClient

Public Class fBuscarPrestamo

    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            ' Abrir la conexión
            connection.Open()

            ' Definir la consulta SQL
            Dim query = "SELECT p.Cod_Prestamo,p.Cod_Estudiante,e.Nombre, p.Cod_Libro,l.Titulo, p.FechaPrestamo,p.FechaDevolucion FROM prestamos p INNER JOIN estudiantes e on p.Cod_Estudiante=e.Cod_Estudiante INNER JOIN libros l on p.Cod_Libro=l.Cod_Libro"
            Dim command As New MySqlCommand(query, connection)

            ' Adaptador para llenar el DataGridView
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable

            ' Llenar la tabla y asignarla al DataGridView
            adapter.Fill(table)
            dgvprestamo.DataSource = table

        Catch ex As MySqlException
            ' Manejo de errores
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub
    Private Sub fBuscarPrestamo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dgvprestamo.DataSource = Nothing
    End Sub
End Class
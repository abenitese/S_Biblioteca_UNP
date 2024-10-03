Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class fModificarEstudiante

    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        BuscarEstudiante(txtbuscar.Text)
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim nombre = txtnombre.Text
        Dim carrera = txtcarrera.Text
        Dim año = txtaño.Text

        ModificarEstudiante(nombre, carrera, año)
    End Sub

    Sub BuscarEstudiante(palabraBusqueda As String)
        Try
            connection.Close()
            connection.Open()
            Dim query As String = "SELECT Cod_Estudiante, nombre, carrera, año FROM estudiantes WHERE nombre LIKE @busqueda OR carrera LIKE @busqueda"
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
    Private Sub dgvEstudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstudiantes.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvEstudiantes.Rows(e.RowIndex)
            txtnombre.Text = row.Cells("nombre").Value.ToString
            txtcarrera.Text = row.Cells("carrera").Value.ToString
            txtaño.Text = row.Cells("año").Value.ToString
        End If
    End Sub

    Sub ModificarEstudiante(nombre As String, carrera As String, año As Integer)
        Try
            connection.Open()
            Dim query As String = "UPDATE estudiantes SET nombre=@nombre, carrera=@carrera, año=@año WHERE nombre=@nombre"
            Dim command As New MySqlCommand(query, connection)

            command.Parameters.AddWithValue("@nombre", nombre)
            command.Parameters.AddWithValue("@carrera", carrera)
            command.Parameters.AddWithValue("@año", año)

            command.ExecuteNonQuery()
            MessageBox.Show("Registro modificado exitosamente.")
            limpiar()
            BuscarEstudiante(txtbuscar.Text) ' Recargar la búsqueda después de la modificación
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Sub limpiar()
        txtnombre.Clear()
        txtcarrera.Clear()
        txtaño.Clear()
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class fModificarLibro
    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        BuscarLibro(txtbuscar.Text)
    End Sub

    Sub BuscarLibro(palabraBusqueda As String)
        Try
            connection.Close()
            connection.Open()
            Dim query As String = "SELECT Cod_Libro, titulo, autor, isbn, genero FROM libros WHERE titulo LIKE @busqueda OR autor LIKE @busqueda"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@busqueda", "%" & palabraBusqueda & "%")

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvLibros.DataSource = table
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub dgvLibros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibros.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvLibros.Rows(e.RowIndex)
            txttitulomodificar.Text = row.Cells("titulo").Value.ToString
            txtautormodificar.Text = row.Cells("autor").Value.ToString
            txtisbnmodificar.Text = row.Cells("isbn").Value.ToString
            txtgeneromodificar.Text = row.Cells("genero").Value.ToString
        End If
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim titulo = txttitulomodificar.Text
        Dim autor = txtautormodificar.Text
        Dim isbn = txtisbnmodificar.Text
        Dim genero = txtgeneromodificar.Text

        ModificarLibro(titulo, autor, isbn, genero)
    End Sub
    Sub ModificarLibro(titulo As String, autor As String, isbn As String, genero As String)
        Try
            connection.Open()
            Dim query As String = "UPDATE libros SET titulo=@titulo, autor=@autor, isbn=@isbn, genero=@genero WHERE titulo=@titulo"
            Dim command As New MySqlCommand(query, connection)

            command.Parameters.AddWithValue("@titulo", titulo)
            command.Parameters.AddWithValue("@autor", autor)
            command.Parameters.AddWithValue("@isbn", isbn)
            command.Parameters.AddWithValue("@genero", genero)

            command.ExecuteNonQuery()
            MessageBox.Show("Registro modificado exitosamente.")
            limpiar()
            BuscarLibro(txtbuscar.Text) ' Recargar la búsqueda después de la modificación
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Sub limpiar()
        txttitulomodificar.Clear()
        txtautormodificar.Clear()
        txtisbnmodificar.Clear()
        txtgeneromodificar.Clear()
    End Sub

End Class
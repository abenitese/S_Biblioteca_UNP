Imports MySql.Data.MySqlClient
Public Class fLibro

    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnAgregarLibro_Click(sender As Object, e As EventArgs) Handles btnAgregarLibro.Click
        Dim titulo = txttituloagregar.Text
        Dim autor = txtautoragregar.Text
        Dim isbn = txtisbnagregar.Text
        Dim genero = txtgeneroagregar.Text

        AgregarLibro(titulo, autor, isbn, genero)
    End Sub

    Sub AgregarLibro(titulo As String, autor As String, isbn As String, genero As String)
        Try
            connection.Open()
            Dim query As String = "INSERT INTO libros (titulo, autor, isbn, genero) VALUES (@titulo, @autor, @isbn, @genero)"
            Dim command As New MySqlCommand(query, connection)

            command.Parameters.AddWithValue("@titulo", txttituloagregar.Text)
            command.Parameters.AddWithValue("@autor", txtautoragregar.Text)
            command.Parameters.AddWithValue("@isbn", txtisbnagregar.Text)
            command.Parameters.AddWithValue("@genero", txtgeneroagregar.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Registro agregado exitosamente.")
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
            limpiar()
        End Try
    End Sub
    Sub limpiar()
        txttituloagregar.Clear()
        txtautoragregar.Clear()
        txtisbnagregar.Clear()
        txtgeneroagregar.Clear()
    End Sub

End Class

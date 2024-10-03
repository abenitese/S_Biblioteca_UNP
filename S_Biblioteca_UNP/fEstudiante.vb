Imports MySql.Data.MySqlClient
Public Class fEstudiante

    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim nombre = txtnombre.Text
        Dim carrera = txtcarrera.Text
        Dim año = Integer.Parse(txtaño.Text)

        AgregarEstudiante(nombre, carrera, año)
    End Sub
    Sub AgregarEstudiante(nombre As String, carrera As String, año As Integer)
        Try
            connection.Open()
            Dim query As String = "INSERT INTO estudiantes (nombre, carrera, año) VALUES (@nombre, @carrera, @año)"
            Dim command As New MySqlCommand(query, connection)

            command.Parameters.AddWithValue("@nombre", txtnombre.Text)
            command.Parameters.AddWithValue("@carrera", txtcarrera.Text)
            command.Parameters.AddWithValue("@año", txtaño.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Registro agregado exitosamente.")
            limpiar()
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
'conexion sql si quieren
'Using conexion As SqlConnection = ObtenerConexion()
'    conexion.Open()
'    Dim consulta As String = "INSERT INTO Estudiantes (Nombre, Carrera, Año) VALUES (@nombre, @carrera, @año)"
'    Using comando As New SqlCommand(consulta, conexion)
'        comando.Parameters.AddWithValue("@nombre", nombre)
'        comando.Parameters.AddWithValue("@carrera", carrera)
'        comando.Parameters.AddWithValue("@año", año)
'        comando.ExecuteNonQuery()
'    End Using
'End Using
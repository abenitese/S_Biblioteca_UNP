Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class fPrestamo

    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)
    Private Sub fPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstudiantes()
        CargarLibros()
        limpiar()
    End Sub

    Private Sub btnprestar_Click(sender As Object, e As EventArgs) Handles btnprestar.Click
        ' Obtener los valores seleccionados en los ComboBox
        Dim codEstudiante As Integer = CType(cbestudiantes.SelectedItem, DataRowView)("Cod_Estudiante")
        Dim codLibro As Integer = CType(cblibros.SelectedItem, DataRowView)("Cod_Libro")

        ' Usar la fecha y hora actual para la fecha de prestamo
        Dim fechaPrestamo = Date.Now

        ' Obtener la fecha de devolucion del calendario
        Dim fechaDevolucion = MonthCalendar1.SelectionStart

        RegistrarPrestamo(codEstudiante, codLibro, fechaPrestamo, fechaDevolucion)
        ActualizarEstadoLibro(codLibro)
    End Sub
    Sub CargarEstudiantes()
        Try
            connection.Open()
            Dim query As String = "SELECT Cod_Estudiante, Nombre FROM estudiantes"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Limpiar el ComboBox antes de llenarlo
            cbestudiantes.DataSource = Nothing

            cbestudiantes.DataSource = table

            ' Llenado de ComboBox
            cbestudiantes.DisplayMember = "Nombre"
            cbestudiantes.ValueMember = "Cod_Estudiante"

        Catch ex As MySqlException
            MessageBox.Show("Error al cargar estudiantes: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Sub CargarLibros()
        Try
            connection.Open()
            Dim query As String = "SELECT Cod_Libro, Titulo FROM libros where Estado=1"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Limpiar el ComboBox antes de llenarlo
            cblibros.DataSource = Nothing
            cblibros.DataSource = table
            ' Llenado de combobox
            cblibros.DisplayMember = "Titulo"
            cblibros.ValueMember = "Cod_Libro"

        Catch ex As MySqlException
            MessageBox.Show("Error al cargar libros: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Sub limpiar()
        cbestudiantes.SelectedIndex = -1
        cblibros.SelectedIndex = -1
        MonthCalendar1.SetDate(DateTime.Now)
    End Sub

    Sub RegistrarPrestamo(codEstudiante As Integer, codLibro As Integer, fechaPrestamo As DateTime, fechaDevolucion As DateTime)
        Try
            connection.Open()
            Dim query As String = "INSERT INTO prestamos (Cod_Estudiante, Cod_Libro, FechaPrestamo, FechaDevolucion) VALUES (@Cod_Estudiante, @Cod_Libro, @FechaPrestamo, @FechaDevolucion)"
            Dim command As New MySqlCommand(query, connection)

            ' Parametros de consulta
            command.Parameters.AddWithValue("@Cod_Estudiante", codEstudiante)
            command.Parameters.AddWithValue("@Cod_Libro", codLibro)
            command.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo)
            command.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion)

            ' Ejecutar la consulta
            command.ExecuteNonQuery()
            MessageBox.Show("Préstamo registrado exitosamente.")
            limpiar()

        Catch ex As MySqlException
            MessageBox.Show("Error al registrar el préstamo: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Sub ActualizarEstadoLibro(codLibro As Integer)

        Try
            connection.Open()
            Dim query As String = "UPDATE libros SET Estado = 0 WHERE Cod_Libro = @Cod_Libro"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Cod_Libro", codLibro)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el estado del libro: " & ex.Message)
        End Try
    End Sub

    Private Sub fPrestamo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cblibros.DataSource = Nothing
        cbestudiantes.DataSource = Nothing
        MonthCalendar1.SetDate(DateTime.Now)
    End Sub
End Class
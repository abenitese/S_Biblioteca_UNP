﻿Imports MySql.Data.MySqlClient

Public Class fBuscarEstudiante
    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            ' Abrir la conexión
            connection.Open()

            ' Definir la consulta SQL
            Dim query = "SELECT * FROM Estudiantes"
            Dim command As New MySqlCommand(query, connection)

            ' Adaptador para llenar el DataGridView
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable

            ' Llenar la tabla y asignarla al DataGridView
            adapter.Fill(table)
            DataGridView1.DataSource = table

        Catch ex As MySqlException
            ' Manejo de errores
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub fBuscarEstudiante_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DataGridView1.DataSource = Nothing
    End Sub
    Private Sub txtestudiantebuscarnombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        fBuscarLibro.buscarPor("estudiantes", "Nombre", txtestudiantebuscarnombre, DataGridView1)
    End Sub

End Class
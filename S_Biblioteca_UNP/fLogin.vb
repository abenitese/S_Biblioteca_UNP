Imports MySql.Data.MySqlClient

Public Class fLogin

    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnlogin_Click_1(sender As Object, e As EventArgs) Handles btnlogin.Click
        iniciar()
    End Sub
    Sub iniciar()

        Try
            Dim query As String = "select * from usuarios WHERE usuario = @usuario and password = @contraseña;"
            Dim command As New MySqlCommand(query, connection)

            ' Abrir conexión a la base de datos
            connection.Open()

            ' Preparar el comando SQL
            Using command
                ' Parámetros de la consulta
                command.Parameters.AddWithValue("@usuario", txtusu.Text)
                command.Parameters.AddWithValue("@contraseña", txtpass.Text)

                ' Ejecutar la consulta
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Verificar si se encontró un usuario que coincida
                If result > 0 Then
                    ' Lectura de nivel
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()
                        Dim nivel As String = reader("cod_nivel").ToString()
                        ' Dirige al formulario Preincipal de acuerdo al nivel obtenido
                        If nivel = 1 Then
                            MessageBox.Show("Bienvenido Administrador", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            fPrincipal.Show()

                        ElseIf nivel = 2 Then
                            MessageBox.Show("Bienvenido Bibliotecario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            fPrincipal2.Show()
                        End If
                        Me.Hide() ' Ocultar el formulario de login
                    Else
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        limpiarlogin()
                    End If
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiarlogin()
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        connection.Close()
    End Sub
    'cuando se pulse enter en los textbox
    Private Sub txtpass_KeyUp_1(sender As Object, e As KeyEventArgs) Handles txtpass.KeyUp
        If e.KeyValue = 13 Then
            iniciar()
            txtpass.BackColor = ColorTranslator.FromHtml("#3A6EA5")
        End If
    End Sub

    Private Sub txtusu_KeyUp(sender As Object, e As KeyEventArgs) Handles txtusu.KeyUp
        If e.KeyValue = 13 Then
            iniciar()
        End If
    End Sub
    Sub limpiarlogin()
        txtusu.Clear()
        txtpass.Clear()
        txtusu.Focus()
    End Sub


End Class
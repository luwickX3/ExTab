Imports System.Data.SqlClient
Public Class Form1
    Private Conn As SqlConnection
    Private Cmd As SqlCommand
    Private Reader As SqlDataReader
    Private Resultado As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conn = New SqlConnection("Initial Catalog = ExTab ;Data Source = localhost;Integrated Security = True")
        Cmd = Conn.CreateCommand
        Cmd.CommandText = "Select"
    End Sub
End Class

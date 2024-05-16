Imports System.Data.OleDb
Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim con As New OleDbConnection("Provide=Microsoft.jet.oledb.4.0; Data Source= E:\SistemaMatriculasINUED\base de datos\matriculasINUED.mdb")
        Try
            con.Open()
            MsgBox("Conectado")
            Dim Query = "Select * Maestro"
            Dim adap As New OleDbDataAdapter(Query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub
End Class

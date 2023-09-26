
Imports System.Data.OleDb
Public Class Form3

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cn.Open()
        Try

      
        Dim rs As String
        rs = " insert into booking values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Value & "','" & DateTimePicker2.Value & "')"
        Dim cmd As New OleDbCommand(rs, cn)



        MsgBox("SELECT YOUR ROOM")
        cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("REQURIED FILEDS ARE EMPTY")
        End Try
        cn.Close()
        Form5.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class







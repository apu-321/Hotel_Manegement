Imports System.Data.OleDb

Public Class Form4

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        cn.Open()
        Try

            Dim rs As String
            rs = " insert into creataccount values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "'," & TextBox7.Text & ",'" & ComboBox2.Text & "','" & TextBox5.Text & "')"
            Dim cmd As New OleDbCommand(rs, cn)

            cmd.ExecuteNonQuery()

            MsgBox("ACCOUNT CREATED SUCCESSFULLY")

        Catch ex As Exception
            MsgBox("Data is required")

        End Try
        cn.Close()
        Form3.Show()

    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
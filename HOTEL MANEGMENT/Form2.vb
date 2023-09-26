Imports System.Data.OleDb

Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cn.Open()
        Dim rs As String
        rs = " select  * from creataccount where firstname = '" & TextBox1.Text & "'"
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader

        If rd.Read() Then
            If TextBox1.Text = rd(6) Then
                MsgBox(" Welcome")

            Else
                MsgBox("Invalid Password ")
                TextBox1.Text = ""
                TextBox2.Focus()

            End If

        Else
            MsgBox("Invalid Username")
            TextBox2.Text = ""
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
        cn.Close()


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form4.Show()

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
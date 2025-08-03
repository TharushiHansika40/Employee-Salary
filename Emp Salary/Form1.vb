Imports System.Runtime.Intrinsics.X86

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim basic, bonus, net As Single
        Dim department As String
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim department As String
        Dim basic, bonus, gross, net As Single
        basic = TextBox3.Text
        department = ComboBox1.Text
        If department = "pro" Then
            bonus = basic * 15 / 100
        ElseIf department = "hr" Then
            bonus = basic * 10 / 100

        ElseIf department = "fin" Then
            bonus = basic * 5 / 100
        Else
            bonus = 0
        End If
        gross = basic + bonus
        net = gross - 2000
        TextBox4.Text = bonus
        TextBox5.Text = gross
        TextBox6.Text = net
    End Sub
End Class

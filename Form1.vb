Imports System.Net

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("計算してみよう")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input1 As Integer
        Dim input2 As Integer
        Dim equal As Integer

        input1 = InputCheckFunc(TextBox1.Text, input1)
        input2 = InputCheckFunc(TextBox2.Text, input2)

        equal = input1 + input2     '代入

        TextBox3.Text = equal.ToString()
    End Sub

    Private Function InputCheckFunc(textboxvalue As String, checkedvalue As Integer) As Integer
        If Integer.TryParse(textboxvalue, checkedvalue) = True Then
            checkedvalue = Integer.Parse(textboxvalue)
        Else
            checkedvalue = 0
        End If

        Return checkedvalue             '呼び出した側に値を返す
    End Function
End Class

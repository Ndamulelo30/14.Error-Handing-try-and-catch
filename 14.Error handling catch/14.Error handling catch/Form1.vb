Public Class Form1

    Dim MyList As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyList.Add("Cat")
        MyList.Add("Dog")
        MyList.Add("horse")

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TextBox2.Text = MyList(TextBox1.Text)
        Catch ex As Exception
            TextBox3.Text = ex.Message
        End Try
    End Sub
End Class


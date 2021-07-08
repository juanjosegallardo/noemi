Public Class Euler

    Private Function df(x As Double, y As Double)
        Return Math.Sin(x) - Math.Log(y)
    End Function

    Private Sub Euler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        dgvTabla.Rows.Clear()
        calcular(txtX0.Text, txtXF.Text, txtY0.Text, txtN.Text)
    End Sub

    Private Sub calcular(x0 As Double, xf As Double, y0 As Double, n As Integer)
        Dim h, x, y, d As Double
        x = x0
        y = y0
        h = (xf - x0) / n

        For i = 0 To n - 1
            d = df(x, y)
            y = y + h * df(x, y)
            x = x + h
            imprimir(x, y, d)
        Next

    End Sub

    Sub imprimir(x As Double, y As Double, df As Double)

        dgvTabla.Rows.Add(df, x, y)

    End Sub
End Class

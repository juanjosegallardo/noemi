Public Class Euler

    Private Function df(x As Double, y As Double)
        Return x * Math.Sqrt(y)
        'Return Math.Sin(x) - Math.Log(y)
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

        For k = 0 To n
            d = df(x, y)
            imprimir(k, x, y, d)
            y = y + h * df(x, y)
            x = x + h

        Next

    End Sub

    Sub imprimir(k As Integer, x As Double, y As Double, df As Double)

        dgvTabla.Rows.Add(k, df, x, y)

    End Sub
End Class

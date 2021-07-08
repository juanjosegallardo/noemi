Public Class Runge

    Private Sub Runge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function df(x As Double, y As Double)
        Return -20 * y + 7 * Math.Exp(x * -0.5)
    End Function

    Private Sub Calcular(iteraciones As Integer, h As Double, x0 As Double, y0 As Double)
        Dim k1, k2, k3, k4, xk, yk As Double
        yk = y0
        xk = x0

        For k = 0 To iteraciones - 1


            k1 = df(xk, yk)
            k2 = df(xk + h / 2, yk + (h / 2) * k1)
            k3 = df(xk + h / 2, yk + (h / 2) * k2)
            k4 = df(xk + h, yk + h * k3)
            imprimir(k, xk, yk, k1, k2, k3, k4)
            yk = yk + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4)
            xk = xk + h
        Next

    End Sub


    Sub imprimir(k As Integer, xk As Double, yk As Double, k1 As Double, k2 As Double, k3 As Double, k4 As Double)
        dgvTabla.Rows.Add(k, xk, yk, k1, k2, k3, k4)

    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        dgvTabla.Rows.Clear()
        Calcular(txtIteraciones.Text, txtPaso.Text, txtX0.Text, txtY0.Text)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick

    End Sub
End Class

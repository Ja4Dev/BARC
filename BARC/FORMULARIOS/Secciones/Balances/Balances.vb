Public Class Balances

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiario.Click
        Me.Close()
        BalancesDiarios.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        BalancesMensuales.Show()
    End Sub

    Private Sub Balances_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Balances - Sesion iniciada como : " & user
    End Sub
End Class
Public Class BalancesMensuales
    Dim indice As Integer
    Dim Fecha As Date
    Dim FechaAnt As Date

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Balances.Show()
    End Sub

    Private Sub BalancesMensuales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        indice = 0
        Consulta("SELECT * FROM Balances_Mensuales ORDER BY FechaCierre DESC")
        While rd.Read
            lstMensual.Items.Add(rd(0))
            lstMensual.Items(indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
            lstMensual.Items(indice).SubItems.Add(rd(2))
            indice += 1
        End While
    End Sub

    Private Sub lstMensual_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstMensual.SelectedIndexChanged
        Consulta("SELECT FechaCierre FROM Balances_Mensuales WHERE IDBalance = " & Val(lstMensual.FocusedItem.Text))
        rd.Read()
        Fecha = rd(0)
        Consulta("SELECT FechaCierre FROM Balances_Mensuales WHERE IDBalance = " & Val(lstMensual.FocusedItem.Text) - 1)
        If rd.Read() Then
            FechaAnt = rd(0)
        Else
            FechaAnt = #9/30/2019#
        End If
        Consulta("SELECT * FROM Balances_Diarios WHERE FechaBalance > " & Format(FechaAnt, "yyyyMMdd") & " AND FechaBalance <= " & Format(Fecha, "yyyyMMdd") & " ORDER BY FechaBalance DESC")
        indice = 0
        While rd.Read
            lstDiario.Items.Add(rd(0))
            lstDiario.Items(indice).SubItems.Add(Format(rd(1), "dd/MM/yyyy"))
            lstDiario.Items(indice).SubItems.Add(rd(2))
            indice += 1
        End While
    End Sub
End Class
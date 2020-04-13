Public Class BungaDeposito
    Private Sub BungaDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .LabelJangkaWaktu.Text = "Jangka Waktu"
            .LabelPilihan.Text = "Pilihan: 1, 3, 4, 12, 24"
            .LabelJumlah.Text = "Jumlah"
            .LabelBungaDeposito.Text = "Bunga Deposito"
            .LabelTotalUangAnda.Text = "Total Uang Anda"
            .ltd1.Text = ":"
            .ltd2.Text = ":"
            .ltd3.Text = ":"
            .ltd4.Text = ":"
            .ButtonHitung.Text = "Hitung"
        End With
    End Sub

    Private Sub ButtonHitung_Click(sender As Object, e As EventArgs) Handles ButtonHitung.Click
        Dim JangkaWaktu As Integer
        Dim Uang, Bunga, TotalUang, Persen As Decimal

        If TextBoxJangkaWaktu.Text = "" Then
            MsgBox("Silahkan Isi Jangka Waktu!")
        ElseIf TextBoxJumlah.Text = "" Then
            MsgBox("Silahkan Isi Uang!")
        Else

            JangkaWaktu = TextBoxJangkaWaktu.Text
            Uang = TextBoxJumlah.Text

            Select Case JangkaWaktu
                Case 1
                    Persen = 5 / 100
                Case 3
                    Persen = 7 / 100
                Case 6
                    Persen = 8 / 100
                Case 12
                    Persen = 10 / 100
                Case 24
                    Persen = 24 / 100
            End Select
        End If

        Bunga = Persen * Uang
        TotalUang = Uang + Bunga

        LabelBungaDeposito.Text = "Rp " & Bunga
        LabelTotalUangAnda.Text = "Rp " & TotalUang
    End Sub
End Class

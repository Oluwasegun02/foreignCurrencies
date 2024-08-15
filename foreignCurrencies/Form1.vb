Public Class Form1
    ' Exchange rates from USD to foreign currencies
    Private exchangeRates As New Dictionary(Of String, Double)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        exchangeRates.Add("British pounds", 0.6)
        exchangeRates.Add("Canadian dollars", 1.4)
        exchangeRates.Add("Dutch guilders", 2.3)
        exchangeRates.Add("French francs", 6.8)
        exchangeRates.Add("German marks", 2.0)
        exchangeRates.Add("Italian lira", 2000)
        exchangeRates.Add("Japanese yen", 100)
        exchangeRates.Add("Mexican pesos", 9.5)
        exchangeRates.Add("Swiss francs", 1.6)
    End Sub
    Private Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvert.Click
        Dim amount As Double
        If Double.TryParse(txtAmount.Text, amount) AndAlso amount > 0 Then
            Dim selectedCurrency As String = GetSelectedCurrency()
            If selectedCurrency IsNot Nothing Then
                If rbtnUSToForeign.Checked And rbtnForeignToUS.Checked Then
                    MessageBox.Show("Please select only one conversion direction.")
                    Return
                End If
                If rbtnUSToForeign.Checked Then
                    txtConvertedAmount.Text = (amount * exchangeRates(selectedCurrency)).ToString("F2")
                ElseIf rbtnForeignToUS.Checked Then
                    txtConvertedAmount.Text = (amount / exchangeRates(selectedCurrency)).ToString("F2")
                Else
                    MessageBox.Show("Please select a conversion direction.")
                End If
            Else
                MessageBox.Show("Please select a foreign currency.")
            End If
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    Private Function GetSelectedCurrency() As String
        If rbtnBritishPounds.Checked Then
            Return "British pounds"
        ElseIf rbtnCanadianDollars.Checked Then
            Return "Canadian dollars"
        ElseIf rbtnDutchGuilders.Checked Then
            Return "Dutch guilders"
        ElseIf rbtnFrenchFrancs.Checked Then
            Return "French francs"
        ElseIf rbtnGermanMarks.Checked Then
            Return "German marks"
        ElseIf rbtnItalianLira.Checked Then
            Return "Italian lira"
        ElseIf rbtnJapaneseYen.Checked Then
            Return "Japanese yen"
        ElseIf rbtnMexicanPesos.Checked Then
            Return "Mexican pesos"
        ElseIf rbtnSwissFrancs.Checked Then
            Return "Swiss francs"
        Else
            Return Nothing
        End If
    End Function


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

   
End Class


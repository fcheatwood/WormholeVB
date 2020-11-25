Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim starShip As Integer = 5
        Dim starRand As Integer
        Dim rand As New Random
        Dim min As Double

        ufoStart.Visible = True
        ufoEnd.Visible = False

        lstMoves.Items.Clear()

        Do While (starShip < 14)

            starRand = rand.Next(2) + 1

            If starRand = 1 Then
                starShip += 1
            ElseIf starRand = 2 Then
                starShip -= 1
            End If

            Dim sec As Double
            sec += 25

            If starShip = 2 Then
                lstMoves.Items.Add(starShip)
            End If

            If starShip = 2 Then
                starShip += 3
                sec += 25
            End If

            lstMoves.Items.Add(starShip)
            min = CDbl(sec / 60)
            ufoStart.Visible = False
            ufoEnd.Visible = True

        Loop

        MessageBox.Show("You escaped the wormhole in " & min & " minutes!")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ufoStart.Visible = True
        ufoEnd.Visible = False

        lstMoves.Items.Clear()

    End Sub
End Class

Public Class Form1
    ReadOnly Old_StarSign() As String = {"Capricornus", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpius", "Sagittarius"}
    '12 star signs
    ReadOnly New_StarSign() As String = {"Capricornus", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpius", "Ophiuchus", "Sagittarius"}
    '13 star signs

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM dd" 'Show me only the month and day... Years are overrated.
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    '  Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChange
    '  End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStarSign.Click
        Dim Month As String = Format(DateTimePicker1.Value, "MMMM")
        Dim Day As Integer = Format(DateTimePicker1.Value, "dd")
        Dim Year As Integer = Format(DateTimePicker1.Value, "yyyy")

        Select Case Month
            Case "January" 'Capricornus, Aquarius
                If Day >= 1 And Day <= 19 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(0))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(1))
                End If
            Case "February" 'Aquarius, Pisces
                If Day >= 1 And Day <= 18 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(1))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(2))
                End If
            Case "March" 'Pisces, Aries
                If Day >= 1 And Day <= 20 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(2))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(3))
                End If
            Case "April" 'Aries, Taurus
                If Day >= 1 And Day <= 19 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(3))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(4))
                End If
            Case "May" 'Taurus, Gemini
                If Day >= 1 And Day <= 20 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(4))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(5))
                End If
            Case "June" 'Gemini, Cancer
                If Day >= 1 And Day <= 20 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(5))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(6))
                End If
            Case "July" 'Cancer, Leo
                If Day >= 1 And Day <= 22 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(6))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(7))
                End If
            Case "August" 'Leo, Virgo
                If Day >= 1 And Day <= 22 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(7))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(8))
                End If
            Case "September" 'Virgo, Libra
                If Day >= 1 And Day <= 22 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(8))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(9))
                End If
            Case "October" 'Libra, Scorpius
                If Day >= 1 And Day <= 22 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(9))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(10))
                End If
            Case "November" 'Scorpius, Sagittarius
                If Day >= 1 And Day <= 21 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(10))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(11))
                End If
            Case "December" 'Sagittarius, Capricornus
                If Day >= 1 And Day <= 21 Then
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(11))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your traditional star sign is " & Old_StarSign(0))
                End If
        End Select
        Select Case Month
            Case "January" 'Sagittarius, Capricornus
                If Day >= 1 And Day <= 18 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(12))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(0))
                End If
            Case "February" 'Capricornus, Aquarius
                If Day >= 1 And Day <= 15 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(0))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(1))
                End If
            Case "March" 'Aquarius, Pisces
                If Day >= 1 And Day <= 11 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(1))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(2))
                End If
            Case "April" 'Pisces, Aries
                If Day >= 1 And Day <= 18 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(2))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(3))
                End If
            Case "May" 'Aries, Taurus
                If Day >= 1 And Day <= 13 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(3))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(4))
                End If
            Case "June" 'Taurus, Gemini
                If Day >= 1 And Day <= 19 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(4))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(5))
                End If
            Case "July" 'Gemini, Cancer
                If Day >= 1 And Day <= 20 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(5))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(6))
                End If
            Case "August" 'Cancer, Leo
                If Day >= 1 And Day <= 9 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(6))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(7))
                End If
            Case "September" 'Leo, Virgo
                If Day >= 1 And Day <= 15 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(7))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(8))
                End If
            Case "October" 'Virgo, Libra
                If Day >= 1 And Day <= 30 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(8))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(9))
                End If
            Case "November" 'Libra, Scorpius, Sagittarius
                If Day >= 1 And Day <= 22 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(9))
                ElseIf Day >= 23 And Day <= 29 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(10))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(11))
                End If
            Case "December" 'Sagittarius, Capricornus
                If Day >= 1 And Day <= 17 Then
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(11))
                Else
                    ListBox1.Items.Add(txtName.Text & ", your actual star sign is " & New_StarSign(12))
                End If
        End Select
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
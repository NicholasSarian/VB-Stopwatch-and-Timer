Public Class StopWatchAndTimer_Class
    Public Sub OnTimedEvent(ByRef hr As Label, ByRef min As Label, ByRef sec As Label, ByRef ms As Label)
        If ms.Text < 99 Then
            If Integer.Parse(ms.Text) < 9 Then
                ms.Text = "0" & (Integer.Parse(ms.Text) + 1).ToString()
            Else
                ms.Text = Integer.Parse(ms.Text) + 1
            End If
        Else
            ms.Text = "00"
        End If
    End Sub

    Public Function TimeInMS(ByRef dgv As DataGridView)
        Dim numSecond2Last As String = dgv.Rows(dgv.Rows.Count - 2).Cells(0).Value
        Dim numLast As String = dgv.Rows(dgv.Rows.Count - 1).Cells(0).Value

        Dim arr1() As String = Split(numSecond2Last, ":")
        Dim arr2() As String = Split(numLast, ":")

        Dim time1 As Integer = (Integer.Parse(arr1(0)) * 60 * 60 * 100) +
                               (Integer.Parse(arr1(1)) * 60 * 100) +
                               (Integer.Parse(arr1(2)) * 100) +
                               Integer.Parse(arr1(3))
        Dim time2 As Integer = (Integer.Parse(arr2(0)) * 60 * 60 * 100) +
                               (Integer.Parse(arr2(1)) * 60 * 100) +
                               (Integer.Parse(arr2(2)) * 100) +
                               Integer.Parse(arr2(3))
        Dim msTime As Integer = time2 - time1

        Return msTime
    End Function

    Public Function getSeconds(ByVal Time As Integer)
        If Time > 6000 Then
            While Time / 6000 > 1
                Time -= 6000
            End While
        End If

        ' Now that the number Is lower than 6000, get the first two digits of the number.
        If Time.ToString().Length > 2 Then
            Dim x As String = secondsInNum(Time)
            Return x
        Else
            Return "00"
        End If
    End Function

    Public Function secondsInNum(ByVal Num As Integer)
        If Num.ToString().Length > 3 Then
            Dim firstDigit As String = Num.ToString()(0)
            Dim secondDigit As String = Num.ToString()(1)
            Dim x As String = firstDigit & secondDigit

            Return x
        ElseIf Num.ToString().Length = 3 Then
            Return "0" & Num.ToString()(0)
        Else
            Return Num
        End If
    End Function

    Public Function getMilliseconds(ByVal Time As Integer)
        Dim remainder As Integer = Time Mod 100

        If remainder < 10 Then
            Return "0" & remainder
        Else
            Return remainder
        End If
    End Function

    ' *********************************************************************************************
    ' *********************************************************************************************
    ' ******************** End of Stopwatch section and start of Timer section ********************
    ' *********************************************************************************************
    ' *********************************************************************************************

    Public Sub InsertNum(ByVal val As String, ByRef lblHr As Label, ByRef lblMin As Label,
                         ByRef lblSec As Label, ByRef time As String, ByRef btnStart As Button,
                         ByRef btnReset As Button)
        If (time + Integer.Parse(val)) <> 0 Then
            If time = "0" Then
                time = val
            Else
                time += val
            End If

            Select Case time.ToString().Length
                Case 1
                    lblSec.Text = "0" + val
                    btnStart.Enabled = True
                    btnReset.Enabled = True

                    btnStart.FlatAppearance.BorderColor = Color.FromArgb(2, 165, 2)
                    btnReset.FlatAppearance.BorderColor = Color.FromArgb(234, 143, 0)
                Case 2
                    lblSec.Text = Integer.Parse(lblSec.Text).ToString + val
                Case 3
                    lblSec.Text = time.Substring(1, 2)
                    lblMin.Text = "0" & time.Substring(0, 1)
                Case 4
                    lblSec.Text = time.Substring(2, 2)
                    lblMin.Text = time.Substring(0, 2)
                Case 5
                    lblHr.Text = "0" & time.Substring(0, 1)
                    lblMin.Text = time.Substring(1, 2)
                    lblSec.Text = time.Substring(3, 2)
                Case 6
                    lblHr.Text = time.Substring(0, 2)
                    lblMin.Text = time.Substring(2, 2)
                    lblSec.Text = time.Substring(4, 2)
            End Select
        End If
    End Sub

    Public Sub CorrectTimer(ByRef lblHr As Label, ByRef lblMin As Label, ByRef lblSec As Label)
        If lblSec.Text > 59 Then
            Dim sec As Integer = Integer.Parse(lblSec.Text) - 60

            If sec < 10 Then
                lblSec.Text = "0" & sec
            Else
                lblSec.Text = sec
            End If

            If lblMin.Text < 10 Then
                lblMin.Text = "0" & (Integer.Parse(lblMin.Text) + 1)
            Else
                lblMin.Text = Integer.Parse(lblMin.Text) + 1
            End If
        End If

        If lblMin.Text > 59 Then
            Dim min As Integer = Integer.Parse(lblMin.Text) - 60

            If min < 10 Then
                lblMin.Text = "0" & min
            Else
                lblMin.Text = min
            End If

            If lblHr.Text < 10 Then
                lblHr.Text = "0" & (Integer.Parse(lblHr.Text) + 1)
            Else
                lblHr.Text = Integer.Parse(lblHr.Text) + 1
            End If
        End If
    End Sub

    Public Sub disableEnableKeyPad(ByVal msg As String, ByRef Panel As Panel)
        If msg = "disable" Then
            Panel.Enabled = False
        ElseIf msg = "enable" Then
            Panel.Enabled = True
        End If
    End Sub
End Class

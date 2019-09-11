Imports System.Timers

Public Class StopWatchAndTimer
    Private aClass As New StopWatchAndTimer_Class

    ' To keep track of the time, I have a stopwatch. When I start the stopwatch, I can then use a timer to note the stopwatch's time in the GUI.
    Private Stopwatch As New Stopwatch
    Public timerTime As String = "0"
    Private ms As Integer = 1000

    ' *********************************************************************************************
    ' *********************************************************************************************
    ' ******************************* This is the Stopwatch section *******************************
    ' *********************************************************************************************
    ' *********************************************************************************************

    Private Sub StopWatchAndTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSWReset.Enabled = False
        btnSWLap.Enabled = False

        btnTimeStartPause.Enabled = False
        btnTimeStartPause.FlatAppearance.BorderColor = Color.Gray
        btnTimeReset.Enabled = False
        btnTimeReset.FlatAppearance.BorderColor = Color.Gray

        TabControl1.SelectedTab = TabPage2

        btnSWReset.FlatAppearance.BorderColor = Color.Gray
        btnSWLap.FlatAppearance.BorderColor = Color.Gray
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLaps.SelectionChanged
        ' Doing this will kind of "disable" the ability to select any cell, column, or row
        dgvLaps.ClearSelection()
    End Sub

    Private Sub SWIncrementTime_Tick(sender As Object, e As EventArgs) Handles SWIncrementTime.Tick
        Dim elapsedTime As TimeSpan = Stopwatch.Elapsed
        Dim i As Integer = 0

        Dim Times() As String = {
            elapsedTime.Hours.ToString(),
            elapsedTime.Minutes.ToString(),
            elapsedTime.Seconds.ToString()
        }

        For Each SWTime In Times
            If SWTime < 10 Then
                Times(i) = "0" & Times(i)
            End If

            i += 1
        Next

        i = 0

        lblHr.Text = Times(0)
        lblMin.Text = Times(1)
        lblSec.Text = Times(2)
    End Sub

    Private Sub SWMillisecondTimer_Tick(sender As Object, e As EventArgs) Handles SWMillisecondTimer.Tick
        Dim elapsedTime As TimeSpan = Stopwatch.Elapsed
        Dim ms As String = Math.Floor(elapsedTime.Milliseconds / 10).ToString()

        If ms < 10 Then
            ms = "0" & ms
        End If

        lblMillisec.Text = ms
    End Sub

    Private Sub btnSWStartPause_Click(sender As Object, e As EventArgs) Handles btnSWStartPause.Click
        Dim btn As Button = CType(sender, Button)

        If btn.Text = "Start" Or btn.Text = "Resume" Then
            btnSWReset.Enabled = True
            btnSWLap.Enabled = True

            btnSWStartPause.FlatAppearance.BorderColor = Color.Gray

            lblHr.ForeColor = Color.Black
            lblMin.ForeColor = Color.Black
            lblSec.ForeColor = Color.Black
            lblMillisec.ForeColor = Color.Black

            btnSWStartPause.ForeColor = Color.White
            btnSWStartPause.FlatAppearance.BorderColor = Color.FromArgb(234, 143, 0)
            btnSWStartPause.BackColor = Color.FromArgb(234, 143, 0)
            btnSWReset.FlatAppearance.BorderColor = Color.Red
            btnSWLap.FlatAppearance.BorderColor = Color.FromArgb(0, 147, 255)

            btnSWStartPause.Text = "Pause"

            Stopwatch.Start()
            SWIncrementTime.Enabled = True
            SWMillisecondTimer.Enabled = True
            BlinkRed.Enabled = False
        Else
            Stopwatch.Stop()
            SWIncrementTime.Stop()
            SWMillisecondTimer.Stop()
            BlinkRed.Enabled = True

            btnSWLap.Enabled = False

            btnSWLap.FlatAppearance.BorderColor = Color.Gray
            btnSWStartPause.ForeColor = Color.White
            btnSWStartPause.FlatAppearance.BorderColor = Color.FromArgb(2, 165, 2)
            btnSWStartPause.BackColor = Color.FromArgb(2, 165, 2)

            btnSWStartPause.Text = "Resume"
        End If
    End Sub

    Private Sub btnSWReset_Click(sender As Object, e As EventArgs) Handles btnSWReset.Click
        Stopwatch.Reset()
        SWIncrementTime.Enabled = False
        SWMillisecondTimer.Enabled = False
        BlinkRed.Enabled = False

        lblHr.Text = "00"
        lblMin.Text = "00"
        lblSec.Text = "00"
        lblMillisec.Text = "00"
        lblHr.ForeColor = Color.Black
        lblMin.ForeColor = Color.Black
        lblSec.ForeColor = Color.Black
        lblMillisec.ForeColor = Color.Black

        dgvLaps.Rows.Clear()
        btnSWStartPause.Text = "Start"

        btnSWReset.Enabled = False
        btnSWLap.Enabled = False
        btnSWStartPause.Enabled = True

        'btnSWPause.FlatAppearance.BorderColor = Color.Gray
        btnSWReset.FlatAppearance.BorderColor = Color.Gray
        btnSWLap.FlatAppearance.BorderColor = Color.Gray
        'btnSWStart.FlatAppearance.BorderColor = Color.FromArgb(2, 165, 2)
        btnSWStartPause.ForeColor = Color.FromArgb(2, 165, 2)
        btnSWStartPause.FlatAppearance.BorderColor = Color.FromArgb(2, 165, 2)
        btnSWStartPause.Text = "Start"
    End Sub

    Private Sub btnSWLap_Click(sender As Object, e As EventArgs) Handles btnSWLap.Click
        ' This is how you add a row to a DataGridView
        ' DataGridView1.Rows.Add("00:00:01:10", "00:00:01:56")
        Dim totalTime As String = lblHr.Text & ":" & lblMin.Text & ":" & lblSec.Text & ":" & lblMillisec.Text
        Dim timeDiff As String

        If dgvLaps.Rows.Count > 1 Then
            Dim timeMS As Integer = aClass.TimeInMS(dgvLaps)
            Dim Hour As Integer = timeMS / 360000

            If Hour < 1 Then
                Hour = "00"
            End If

            Dim Minute As Integer = timeMS / 6000

            If Minute < 1 Then
                Minute = "00"
            Else
                Dim minInHr As Integer = 0
                If Integer.Parse(Minute) > 59 Then
                    While Minute > 59
                        Minute -= 50
                        minInHr += 1
                    End While
                    Hour = Integer.Parse(Hour) + minInHr
                End If
                If Minute.ToString().Length < 10 Then
                    Minute = "0" & Minute
                End If
            End If

            Dim Second As String = aClass.getSeconds(timeMS)
            Dim Milliseconds As Integer = aClass.getMilliseconds(timeMS)

            Dim Time As String = Hour & ":" & Minute & ":" & Second & ":" & Milliseconds

            dgvLaps.Rows.Add(totalTime, Time)
        Else
            Dim Time As String = lblHr.Text & ":" & lblMin.Text & ":" & lblSec.Text & ":" & lblMillisec.Text

            dgvLaps.Rows.Add(Time, Time)
        End If
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If e.TabPage.Text = "Timer" Then
            Me.Text = "Timer"
            Me.AcceptButton = btnTimeStartPause
        Else
            Me.Text = "Stopwatch"
            Me.AcceptButton = btnSWStartPause
        End If
    End Sub

    Private Sub btnSWStart_MouseEnter(sender As Object, e As EventArgs) Handles btnSWReset.MouseEnter,
                                                                                btnSWLap.MouseEnter,
                                                                                btnSWStartPause.MouseEnter
        Dim btn As Button = CType(sender, Button)

        btn.ForeColor = Color.White

        Select Case btn.Name
            Case "btnSWStartPause"
                If btn.Text = "Start" Or btn.Text = "Resume" Then
                    btn.BackColor = Color.FromArgb(2, 165, 2)
                Else
                    btn.BackColor = Color.FromArgb(234, 143, 0)
                End If
            Case "btnSWStart"
                btn.BackColor = Color.FromArgb(2, 165, 2)
            Case "btnSWPause"
                btn.BackColor = Color.FromArgb(234, 143, 0)
            Case "btnSWReset"
                btn.BackColor = Color.Red
            Case "btnSWLap"
                btn.BackColor = Color.FromArgb(0, 147, 255)
        End Select
    End Sub

    Private Sub btnSWStart_MouseLeave(sender As Object, e As EventArgs) Handles btnSWStartPause.MouseLeave,
                                                                                btnSWReset.MouseLeave,
                                                                                btnSWLap.MouseLeave
        Dim btn As Button = CType(sender, Button)

        btn.BackColor = Color.White

        Select Case btn.Name
            Case "btnSWStartPause"
                If btn.Text = "Start" Or btn.Text = "Resume" Then
                    btn.ForeColor = Color.FromArgb(2, 165, 2)
                Else
                    btn.ForeColor = Color.FromArgb(234, 143, 0)
                End If
            Case "btnSWStart"
                btn.ForeColor = Color.FromArgb(2, 165, 2)
            Case "btnSWPause"
                btn.ForeColor = Color.FromArgb(234, 143, 0)
            Case "btnSWReset"
                btn.ForeColor = Color.Red
            Case "btnSWLap"
                btn.ForeColor = Color.FromArgb(0, 147, 255)
        End Select
    End Sub

    ' *********************************************************************************************
    ' *********************************************************************************************
    ' ******************** End of Stopwatch section and start of Timer section ********************
    ' *********************************************************************************************
    ' *********************************************************************************************

    Private Sub InsertNum_Click(sender As Object, e As EventArgs) Handles btnOne.Click, btnTwo.Click,
                                                                          btnThree.Click, btnFour.Click,
                                                                          btnFive.Click, btnSix.Click,
                                                                          btnSeven.Click, btnEight.Click,
                                                                          btnNine.Click, btnZero.Click
        Dim btn As Button = CType(sender, Button)

        If timerTime.Length <> 6 Then
            aClass.InsertNum(btn.Text, lblTimerHr, lblTimerMin, lblTimerSec, timerTime, btnTimeStartPause, btnTimeReset)
        End If
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        Select Case timerTime.Length
            Case 1
                timerTime = "0"
                lblTimerSec.Text = "00"
                btnTimeStartPause.Enabled = False
                btnTimeReset.Enabled = False
            Case 2
                timerTime = timerTime.Substring(0, 1)
                lblTimerSec.Text = "0" & timerTime.Substring(0, 1)
            Case 3
                timerTime = timerTime.Substring(0, 2)
                lblTimerMin.Text = "00"
                lblTimerSec.Text = timerTime.Substring(0, 2)
            Case 4
                timerTime = timerTime.Substring(0, 3)
                lblTimerMin.Text = "0" & timerTime.Substring(0, 1)
                lblTimerSec.Text = timerTime.Substring(1, 2)
            Case 5
                timerTime = timerTime.Substring(0, 4)
                lblTimerHr.Text = "00"
                lblTimerMin.Text = timerTime.Substring(0, 2)
                lblTimerSec.Text = timerTime.Substring(2, 2)
            Case 6
                timerTime = timerTime.Substring(0, 5)
                lblTimerHr.Text = "0" + timerTime.Substring(0, 1)
                lblTimerMin.Text = timerTime.Substring(1, 2)
                lblTimerSec.Text = timerTime.Substring(3, 2)
        End Select
    End Sub

    Private Sub btnTimeStart_Click(sender As Object, e As EventArgs) Handles btnTimeStartPause.Click
        If btnTimeStartPause.Text = "Start" Or btnTimeStartPause.Text = "Resume" Then
            aClass.CorrectTimer(lblTimerHr, lblTimerMin, lblTimerSec)
            aClass.disableEnableKeyPad("disable", pnlTimerKeypad)

            btnTimeReset.Enabled = True
            btnTimeReset.FlatAppearance.BorderColor = Color.Red
            TimerTicker.Enabled = True
            BlinkRed.Enabled = False

            lblTimerHr.ForeColor = Color.Black
            lblTimerMin.ForeColor = Color.Black
            lblTimerSec.ForeColor = Color.Black

            btnTimeStartPause.Text = "Pause"
            btnTimeStartPause.FlatAppearance.BorderColor = Color.FromArgb(234, 143, 0)
            btnTimeStartPause.BackColor = Color.FromArgb(234, 143, 0)
        Else
            TimerTicker.Enabled = False
            BlinkRed.Enabled = True

            btnTimeStartPause.Text = "Resume"
            btnTimeStartPause.FlatAppearance.BorderColor = Color.FromArgb(2, 165, 2)
            btnTimeStartPause.BackColor = Color.FromArgb(2, 165, 2)
        End If
    End Sub

    Private Sub btnTimeReset_Click(sender As Object, e As EventArgs) Handles btnTimeReset.Click
        TimerTicker.Enabled = False
        BlinkRed.Enabled = False
        aClass.disableEnableKeyPad("enable", pnlTimerKeypad)
        timerTime = "0"

        lblTimerSec.Text = "00"
        lblTimerMin.Text = "00"
        lblTimerHr.Text = "00"

        lblTimerHr.ForeColor = Color.Black
        lblTimerMin.ForeColor = Color.Black
        lblTimerSec.ForeColor = Color.Black

        btnTimeStartPause.Enabled = False
        btnTimeStartPause.FlatAppearance.BorderColor = Color.Gray
        btnTimeStartPause.ForeColor = Color.FromArgb(2, 165, 2)
        btnTimeStartPause.Text = "Start"

        btnTimeReset.Enabled = False
        btnTimeReset.FlatAppearance.BorderColor = Color.Gray
    End Sub

    Private Sub TimerTicker_Tick(sender As Object, e As EventArgs) Handles TimerTicker.Tick
        If lblTimerSec.Text = "00" And lblTimerMin.Text = "00" And lblTimerHr.Text = "00" Then
            TimerTicker.Enabled = False
            My.Computer.Audio.Play(My.Resources.TimesUp, AudioPlayMode.BackgroundLoop)
            MessageBox.Show("Times Up!", "Times Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Computer.Audio.Stop()

            pnlTimerKeypad.Enabled = True
            timerTime = "0"
            btnTimeStartPause.Enabled = False
            btnTimeReset.Enabled = False

            btnTimeStartPause.FlatAppearance.BorderColor = Color.Gray
            btnTimeReset.FlatAppearance.BorderColor = Color.Gray
        Else
            ms -= 100
            If ms = 0 Then
                ms = 1000
                If Integer.Parse(lblTimerSec.Text) <> 0 Then
                    lblTimerSec.Text = Integer.Parse(lblTimerSec.Text) - 1
                    If Integer.Parse(lblTimerSec.Text) < 10 Then
                        lblTimerSec.Text = "0" & lblTimerSec.Text
                    End If
                ElseIf Integer.Parse(lblTimerMin.Text) <> 0 Then
                    lblTimerMin.Text = Integer.Parse(lblTimerMin.Text) - 1
                    If Integer.Parse(lblTimerMin.Text) <> 0 Then
                        lblTimerMin.Text = "00"
                    Else
                        lblTimerMin.Text = "0" & lblTimerMin.Text
                    End If
                    lblTimerSec.Text = "59"
                ElseIf Integer.Parse(lblTimerHr.Text) <> 0 Then
                    lblTimerHr.Text = Integer.Parse(lblTimerHr.Text) - 1
                    If Integer.Parse(lblTimerHr.Text) <> 0 Then
                        lblTimerHr.Text = "00"
                    ElseIf Integer.Parse(lblTimerHr.Text) < 10 Then
                        lblTimerHr.Text = "0" & lblTimerHr.Text
                    End If
                    lblTimerMin.Text = "59"
                    lblTimerSec.Text = "59"
                End If
            End If
        End If
    End Sub

    Private Sub btnOne_MouseEnter(sender As Object, e As EventArgs) Handles btnOne.MouseEnter, btnTwo.MouseEnter,
                                                                          btnThree.MouseEnter, btnFour.MouseEnter,
                                                                          btnFive.MouseEnter, btnSix.MouseEnter,
                                                                          btnSeven.MouseEnter, btnEight.MouseEnter,
                                                                          btnNine.MouseEnter, btnZero.MouseEnter,
                                                                          btnBackspace.MouseEnter
        Dim btn As Button = CType(sender, Button)

        btn.BackColor = Color.Red
        btn.ForeColor = Color.White
    End Sub

    Private Sub btnOne_MouseLeave(sender As Object, e As EventArgs) Handles btnOne.MouseLeave, btnTwo.MouseLeave,
                                                                          btnThree.MouseLeave, btnFour.MouseLeave,
                                                                          btnFive.MouseLeave, btnSix.MouseLeave,
                                                                          btnSeven.MouseLeave, btnEight.MouseLeave,
                                                                          btnNine.MouseLeave, btnZero.MouseLeave,
                                                                          btnBackspace.MouseLeave
        Dim btn As Button = CType(sender, Button)

        btn.BackColor = Color.White
        btn.ForeColor = Color.Red
    End Sub

    Private Sub btnTimeStartPause_MouseEnter(sender As Object, e As EventArgs) Handles btnTimeStartPause.MouseEnter,
                                                                                       btnTimeReset.MouseEnter
        Dim btn As Button = CType(sender, Button)

        btn.ForeColor = Color.White

        Select Case btn.Text
            Case "Pause"
                btn.BackColor = Color.FromArgb(234, 143, 0)
            Case "Start"
                btn.BackColor = Color.FromArgb(2, 165, 2)
            Case "Resume"
                btn.BackColor = Color.FromArgb(2, 165, 2)
            Case "Reset"
                btn.BackColor = Color.Red
        End Select
    End Sub

    Private Sub btnTimeStartPause_MouseLeave(sender As Object, e As EventArgs) Handles btnTimeStartPause.MouseLeave,
                                                                                       btnTimeReset.MouseLeave
        Dim btn As Button = CType(sender, Button)

        btn.BackColor = Color.White

        Select Case btn.Text
            Case "Pause"
                btn.ForeColor = Color.FromArgb(234, 143, 0)
            Case "Start"
                btn.ForeColor = Color.FromArgb(2, 165, 2)
            Case "Resume"
                btn.ForeColor = Color.FromArgb(2, 165, 2)
            Case "Reset"
                btn.ForeColor = Color.Red
        End Select
    End Sub

    Private Sub BlinkRed_Tick(sender As Object, e As EventArgs) Handles BlinkRed.Tick
        If TabControl1.SelectedTab Is TabPage1 Then
            If lblHr.ForeColor = Color.Red Then
                lblHr.ForeColor = Color.Black
                lblMin.ForeColor = Color.Black
                lblSec.ForeColor = Color.Black
                lblMillisec.ForeColor = Color.Black
            Else
                lblHr.ForeColor = Color.Red
                lblMin.ForeColor = Color.Red
                lblSec.ForeColor = Color.Red
                lblMillisec.ForeColor = Color.Red
            End If
        Else
            If lblTimerHr.ForeColor = Color.Red Then
                lblTimerHr.ForeColor = Color.Black
                lblTimerMin.ForeColor = Color.Black
                lblTimerSec.ForeColor = Color.Black
            Else
                lblTimerHr.ForeColor = Color.Red
                lblTimerMin.ForeColor = Color.Red
                lblTimerSec.ForeColor = Color.Red
            End If
        End If
    End Sub
End Class

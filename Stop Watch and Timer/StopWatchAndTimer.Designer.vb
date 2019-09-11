<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StopWatchAndTimer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StopWatchAndTimer))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblMillisec = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvLaps = New System.Windows.Forms.DataGridView()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSWLap = New System.Windows.Forms.Button()
        Me.btnSWReset = New System.Windows.Forms.Button()
        Me.btnSWStartPause = New System.Windows.Forms.Button()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHr = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTimeReset = New System.Windows.Forms.Button()
        Me.btnTimeStartPause = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTimerSec = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTimerMin = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTimerHr = New System.Windows.Forms.Label()
        Me.pnlTimerKeypad = New System.Windows.Forms.Panel()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnBackspace = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.SWIncrementTime = New System.Windows.Forms.Timer(Me.components)
        Me.SWMillisecondTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTicker = New System.Windows.Forms.Timer(Me.components)
        Me.BlinkRed = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvLaps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.pnlTimerKeypad.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(420, 430)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblMillisec)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.dgvLaps)
        Me.TabPage1.Controls.Add(Me.btnSWLap)
        Me.TabPage1.Controls.Add(Me.btnSWReset)
        Me.TabPage1.Controls.Add(Me.btnSWStartPause)
        Me.TabPage1.Controls.Add(Me.lblSec)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblMin)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lblHr)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(412, 404)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stopwatch"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblMillisec
        '
        Me.lblMillisec.AutoSize = True
        Me.lblMillisec.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillisec.Location = New System.Drawing.Point(295, 99)
        Me.lblMillisec.Name = "lblMillisec"
        Me.lblMillisec.Size = New System.Drawing.Size(53, 38)
        Me.lblMillisec.TabIndex = 7
        Me.lblMillisec.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(281, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 38)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(175, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 28)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Laps"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(69, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(259, 56)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Stopwatch"
        '
        'dgvLaps
        '
        Me.dgvLaps.AllowUserToAddRows = False
        Me.dgvLaps.AllowUserToDeleteRows = False
        Me.dgvLaps.AllowUserToResizeColumns = False
        Me.dgvLaps.AllowUserToResizeRows = False
        Me.dgvLaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Total, Me.Time})
        Me.dgvLaps.Location = New System.Drawing.Point(76, 232)
        Me.dgvLaps.MultiSelect = False
        Me.dgvLaps.Name = "dgvLaps"
        Me.dgvLaps.ReadOnly = True
        Me.dgvLaps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvLaps.Size = New System.Drawing.Size(261, 150)
        Me.dgvLaps.TabIndex = 12
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        Me.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnSWLap
        '
        Me.btnSWLap.BackColor = System.Drawing.Color.White
        Me.btnSWLap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSWLap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSWLap.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSWLap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSWLap.Location = New System.Drawing.Point(258, 156)
        Me.btnSWLap.Name = "btnSWLap"
        Me.btnSWLap.Size = New System.Drawing.Size(91, 33)
        Me.btnSWLap.TabIndex = 10
        Me.btnSWLap.Text = "Lap"
        Me.btnSWLap.UseVisualStyleBackColor = False
        '
        'btnSWReset
        '
        Me.btnSWReset.BackColor = System.Drawing.Color.White
        Me.btnSWReset.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSWReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSWReset.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSWReset.ForeColor = System.Drawing.Color.Red
        Me.btnSWReset.Location = New System.Drawing.Point(161, 156)
        Me.btnSWReset.Name = "btnSWReset"
        Me.btnSWReset.Size = New System.Drawing.Size(91, 33)
        Me.btnSWReset.TabIndex = 9
        Me.btnSWReset.Text = "Reset"
        Me.btnSWReset.UseVisualStyleBackColor = False
        '
        'btnSWStartPause
        '
        Me.btnSWStartPause.BackColor = System.Drawing.Color.White
        Me.btnSWStartPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnSWStartPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSWStartPause.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSWStartPause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnSWStartPause.Location = New System.Drawing.Point(64, 156)
        Me.btnSWStartPause.Name = "btnSWStartPause"
        Me.btnSWStartPause.Size = New System.Drawing.Size(91, 33)
        Me.btnSWStartPause.TabIndex = 8
        Me.btnSWStartPause.Text = "Start"
        Me.btnSWStartPause.UseVisualStyleBackColor = False
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.Location = New System.Drawing.Point(219, 85)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(78, 56)
        Me.lblSec.TabIndex = 5
        Me.lblSec.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 38)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = ":"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMin.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(142, 85)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(78, 56)
        Me.lblMin.TabIndex = 3
        Me.lblMin.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'lblHr
        '
        Me.lblHr.AutoSize = True
        Me.lblHr.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHr.Location = New System.Drawing.Point(63, 85)
        Me.lblHr.Name = "lblHr"
        Me.lblHr.Size = New System.Drawing.Size(78, 56)
        Me.lblHr.TabIndex = 1
        Me.lblHr.Text = "00"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btnTimeReset)
        Me.TabPage2.Controls.Add(Me.btnTimeStartPause)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.lblTimerSec)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.lblTimerMin)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.lblTimerHr)
        Me.TabPage2.Controls.Add(Me.pnlTimerKeypad)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(412, 404)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Timer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(129, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Timer"
        '
        'btnTimeReset
        '
        Me.btnTimeReset.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnTimeReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeReset.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeReset.ForeColor = System.Drawing.Color.Red
        Me.btnTimeReset.Location = New System.Drawing.Point(214, 137)
        Me.btnTimeReset.Name = "btnTimeReset"
        Me.btnTimeReset.Size = New System.Drawing.Size(91, 33)
        Me.btnTimeReset.TabIndex = 10
        Me.btnTimeReset.Text = "Reset"
        Me.btnTimeReset.UseVisualStyleBackColor = True
        '
        'btnTimeStartPause
        '
        Me.btnTimeStartPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnTimeStartPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeStartPause.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeStartPause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnTimeStartPause.Location = New System.Drawing.Point(117, 137)
        Me.btnTimeStartPause.Name = "btnTimeStartPause"
        Me.btnTimeStartPause.Size = New System.Drawing.Size(91, 33)
        Me.btnTimeStartPause.TabIndex = 9
        Me.btnTimeStartPause.Text = "Start"
        Me.btnTimeStartPause.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(254, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Seconds"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(163, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Minutes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(82, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 26)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Hours"
        '
        'lblTimerSec
        '
        Me.lblTimerSec.AutoSize = True
        Me.lblTimerSec.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerSec.Location = New System.Drawing.Point(269, 61)
        Me.lblTimerSec.Name = "lblTimerSec"
        Me.lblTimerSec.Size = New System.Drawing.Size(53, 38)
        Me.lblTimerSec.TabIndex = 5
        Me.lblTimerSec.Text = "00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(237, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 38)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = ":"
        '
        'lblTimerMin
        '
        Me.lblTimerMin.AutoSize = True
        Me.lblTimerMin.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerMin.Location = New System.Drawing.Point(178, 61)
        Me.lblTimerMin.Name = "lblTimerMin"
        Me.lblTimerMin.Size = New System.Drawing.Size(53, 38)
        Me.lblTimerMin.TabIndex = 3
        Me.lblTimerMin.Text = "00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(146, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 38)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = ":"
        '
        'lblTimerHr
        '
        Me.lblTimerHr.AutoSize = True
        Me.lblTimerHr.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerHr.Location = New System.Drawing.Point(82, 61)
        Me.lblTimerHr.Name = "lblTimerHr"
        Me.lblTimerHr.Size = New System.Drawing.Size(53, 38)
        Me.lblTimerHr.TabIndex = 1
        Me.lblTimerHr.Text = "00"
        '
        'pnlTimerKeypad
        '
        Me.pnlTimerKeypad.Controls.Add(Me.btnFive)
        Me.pnlTimerKeypad.Controls.Add(Me.btnBackspace)
        Me.pnlTimerKeypad.Controls.Add(Me.btnOne)
        Me.pnlTimerKeypad.Controls.Add(Me.btnZero)
        Me.pnlTimerKeypad.Controls.Add(Me.btnTwo)
        Me.pnlTimerKeypad.Controls.Add(Me.btnNine)
        Me.pnlTimerKeypad.Controls.Add(Me.btnThree)
        Me.pnlTimerKeypad.Controls.Add(Me.btnEight)
        Me.pnlTimerKeypad.Controls.Add(Me.btnFour)
        Me.pnlTimerKeypad.Controls.Add(Me.btnSeven)
        Me.pnlTimerKeypad.Controls.Add(Me.btnSix)
        Me.pnlTimerKeypad.Location = New System.Drawing.Point(127, 177)
        Me.pnlTimerKeypad.Name = "pnlTimerKeypad"
        Me.pnlTimerKeypad.Size = New System.Drawing.Size(167, 219)
        Me.pnlTimerKeypad.TabIndex = 11
        '
        'btnFive
        '
        Me.btnFive.BackColor = System.Drawing.Color.White
        Me.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFive.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.ForeColor = System.Drawing.Color.Red
        Me.btnFive.Location = New System.Drawing.Point(61, 58)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(45, 45)
        Me.btnFive.TabIndex = 4
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = False
        '
        'btnBackspace
        '
        Me.btnBackspace.BackColor = System.Drawing.Color.White
        Me.btnBackspace.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackspace.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackspace.ForeColor = System.Drawing.Color.Red
        Me.btnBackspace.Location = New System.Drawing.Point(112, 160)
        Me.btnBackspace.Name = "btnBackspace"
        Me.btnBackspace.Size = New System.Drawing.Size(45, 45)
        Me.btnBackspace.TabIndex = 10
        Me.btnBackspace.Text = "<"
        Me.btnBackspace.UseVisualStyleBackColor = False
        '
        'btnOne
        '
        Me.btnOne.BackColor = System.Drawing.Color.White
        Me.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOne.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.ForeColor = System.Drawing.Color.Red
        Me.btnOne.Location = New System.Drawing.Point(10, 7)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(45, 45)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = False
        '
        'btnZero
        '
        Me.btnZero.BackColor = System.Drawing.Color.White
        Me.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZero.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.ForeColor = System.Drawing.Color.Red
        Me.btnZero.Location = New System.Drawing.Point(61, 160)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(45, 45)
        Me.btnZero.TabIndex = 9
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = False
        '
        'btnTwo
        '
        Me.btnTwo.BackColor = System.Drawing.Color.White
        Me.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTwo.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.ForeColor = System.Drawing.Color.Red
        Me.btnTwo.Location = New System.Drawing.Point(61, 7)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(45, 45)
        Me.btnTwo.TabIndex = 1
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = False
        '
        'btnNine
        '
        Me.btnNine.BackColor = System.Drawing.Color.White
        Me.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNine.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.ForeColor = System.Drawing.Color.Red
        Me.btnNine.Location = New System.Drawing.Point(112, 109)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(45, 45)
        Me.btnNine.TabIndex = 8
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = False
        '
        'btnThree
        '
        Me.btnThree.BackColor = System.Drawing.Color.White
        Me.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThree.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.ForeColor = System.Drawing.Color.Red
        Me.btnThree.Location = New System.Drawing.Point(112, 7)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(45, 45)
        Me.btnThree.TabIndex = 2
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = False
        '
        'btnEight
        '
        Me.btnEight.BackColor = System.Drawing.Color.White
        Me.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEight.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.ForeColor = System.Drawing.Color.Red
        Me.btnEight.Location = New System.Drawing.Point(61, 109)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(45, 45)
        Me.btnEight.TabIndex = 7
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = False
        '
        'btnFour
        '
        Me.btnFour.BackColor = System.Drawing.Color.White
        Me.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFour.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.ForeColor = System.Drawing.Color.Red
        Me.btnFour.Location = New System.Drawing.Point(10, 58)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(45, 45)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = False
        '
        'btnSeven
        '
        Me.btnSeven.BackColor = System.Drawing.Color.White
        Me.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeven.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.ForeColor = System.Drawing.Color.Red
        Me.btnSeven.Location = New System.Drawing.Point(10, 109)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(45, 45)
        Me.btnSeven.TabIndex = 6
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = False
        '
        'btnSix
        '
        Me.btnSix.BackColor = System.Drawing.Color.White
        Me.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSix.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.ForeColor = System.Drawing.Color.Red
        Me.btnSix.Location = New System.Drawing.Point(112, 58)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(45, 45)
        Me.btnSix.TabIndex = 5
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = False
        '
        'SWIncrementTime
        '
        '
        'SWMillisecondTimer
        '
        Me.SWMillisecondTimer.Interval = 1
        '
        'TimerTicker
        '
        '
        'BlinkRed
        '
        Me.BlinkRed.Interval = 500
        '
        'StopWatchAndTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 430)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(436, 469)
        Me.MinimumSize = New System.Drawing.Size(436, 469)
        Me.Name = "StopWatchAndTimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stopwatch"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvLaps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.pnlTimerKeypad.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblMillisec As Label
    Friend WithEvents lblSec As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHr As Label
    Friend WithEvents dgvLaps As DataGridView
    Friend WithEvents btnSWLap As Button
    Friend WithEvents btnSWReset As Button
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBackspace As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTimeReset As Button
    Friend WithEvents btnTimeStartPause As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTimerSec As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTimerMin As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblTimerHr As Label
    Friend WithEvents SWIncrementTime As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents SWMillisecondTimer As Timer
    Friend WithEvents btnSWStartPause As Button
    Friend WithEvents TimerTicker As Timer
    Friend WithEvents pnlTimerKeypad As Panel
    Friend WithEvents BlinkRed As Timer
End Class

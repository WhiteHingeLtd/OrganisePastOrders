<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PastOrderOrganisingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GetFromOrdersBtn = New System.Windows.Forms.Button()
        Me.GetFromPastBtn = New System.Windows.Forms.Button()
        Me.GatheredGrid = New System.Windows.Forms.DataGridView()
        Me.OrderNumCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderCreationDateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderStateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.LoadingProgress = New System.Windows.Forms.ProgressBar()
        Me.SendOldBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PastSubText = New System.Windows.Forms.TextBox()
        Me.GetFromOtherBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DaysOldNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LoadingPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MoveAllPostedBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GatheredGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadingPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GetFromOrdersBtn
        '
        Me.GetFromOrdersBtn.Location = New System.Drawing.Point(11, 3)
        Me.GetFromOrdersBtn.Name = "GetFromOrdersBtn"
        Me.GetFromOrdersBtn.Size = New System.Drawing.Size(119, 23)
        Me.GetFromOrdersBtn.TabIndex = 0
        Me.GetFromOrdersBtn.Text = "Gather from Orders"
        Me.GetFromOrdersBtn.UseVisualStyleBackColor = True
        '
        'GetFromPastBtn
        '
        Me.GetFromPastBtn.Location = New System.Drawing.Point(11, 25)
        Me.GetFromPastBtn.Name = "GetFromPastBtn"
        Me.GetFromPastBtn.Size = New System.Drawing.Size(119, 23)
        Me.GetFromPastBtn.TabIndex = 1
        Me.GetFromPastBtn.Text = "Gather from Past"
        Me.GetFromPastBtn.UseVisualStyleBackColor = True
        '
        'GatheredGrid
        '
        Me.GatheredGrid.AllowUserToAddRows = False
        Me.GatheredGrid.AllowUserToDeleteRows = False
        Me.GatheredGrid.AllowUserToResizeRows = False
        Me.GatheredGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GatheredGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GatheredGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNumCol, Me.OrderCreationDateCol, Me.OrderStateCol})
        Me.GatheredGrid.Location = New System.Drawing.Point(11, 111)
        Me.GatheredGrid.Name = "GatheredGrid"
        Me.GatheredGrid.RowHeadersVisible = False
        Me.GatheredGrid.Size = New System.Drawing.Size(426, 418)
        Me.GatheredGrid.TabIndex = 3
        '
        'OrderNumCol
        '
        Me.OrderNumCol.HeaderText = "Order Number"
        Me.OrderNumCol.Name = "OrderNumCol"
        Me.OrderNumCol.ReadOnly = True
        '
        'OrderCreationDateCol
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.OrderCreationDateCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.OrderCreationDateCol.HeaderText = "Created on"
        Me.OrderCreationDateCol.Name = "OrderCreationDateCol"
        Me.OrderCreationDateCol.ReadOnly = True
        '
        'OrderStateCol
        '
        Me.OrderStateCol.HeaderText = "Order State"
        Me.OrderStateCol.Name = "OrderStateCol"
        '
        'DestinationCB
        '
        Me.DestinationCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DestinationCB.FormattingEnabled = True
        Me.DestinationCB.Items.AddRange(New Object() {"Date-based folder", "Orders folder"})
        Me.DestinationCB.Location = New System.Drawing.Point(196, 536)
        Me.DestinationCB.Name = "DestinationCB"
        Me.DestinationCB.Size = New System.Drawing.Size(123, 21)
        Me.DestinationCB.TabIndex = 4
        Me.DestinationCB.Text = "---Please Select---"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 539)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Send files"
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(9, 98)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(128, 13)
        Me.InfoLabel.TabIndex = 6
        Me.InfoLabel.Text = "Gather files to get started."
        '
        'LoadingProgress
        '
        Me.LoadingProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadingProgress.Location = New System.Drawing.Point(11, 589)
        Me.LoadingProgress.Name = "LoadingProgress"
        Me.LoadingProgress.Size = New System.Drawing.Size(309, 22)
        Me.LoadingProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LoadingProgress.TabIndex = 7
        '
        'SendOldBtn
        '
        Me.SendOldBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SendOldBtn.Location = New System.Drawing.Point(12, 562)
        Me.SendOldBtn.Name = "SendOldBtn"
        Me.SendOldBtn.Size = New System.Drawing.Size(308, 21)
        Me.SendOldBtn.TabIndex = 8
        Me.SendOldBtn.Text = "SEND"
        Me.SendOldBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Load from: T:\AppData\Orders\Past\"
        '
        'PastSubText
        '
        Me.PastSubText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PastSubText.Location = New System.Drawing.Point(313, 49)
        Me.PastSubText.Name = "PastSubText"
        Me.PastSubText.Size = New System.Drawing.Size(119, 20)
        Me.PastSubText.TabIndex = 10
        '
        'GetFromOtherBtn
        '
        Me.GetFromOtherBtn.Enabled = False
        Me.GetFromOtherBtn.Location = New System.Drawing.Point(11, 47)
        Me.GetFromOtherBtn.Name = "GetFromOtherBtn"
        Me.GetFromOtherBtn.Size = New System.Drawing.Size(119, 23)
        Me.GetFromOtherBtn.TabIndex = 11
        Me.GetFromOtherBtn.Text = "Gather from Other"
        Me.GetFromOtherBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 539)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "or more days old to"
        '
        'DaysOldNum
        '
        Me.DaysOldNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DaysOldNum.Location = New System.Drawing.Point(62, 536)
        Me.DaysOldNum.Name = "DaysOldNum"
        Me.DaysOldNum.Size = New System.Drawing.Size(33, 20)
        Me.DaysOldNum.TabIndex = 13
        Me.DaysOldNum.Text = "4"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Folder format: yyyy-MM-dd"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Grabs all orders in the Past folder, not its subdirectories"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Grabs all orders currently in the orders folder."
        '
        'LoadingPanel
        '
        Me.LoadingPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPanel.Controls.Add(Me.Label8)
        Me.LoadingPanel.Location = New System.Drawing.Point(118, 279)
        Me.LoadingPanel.Name = "LoadingPanel"
        Me.LoadingPanel.Size = New System.Drawing.Size(210, 96)
        Me.LoadingPanel.TabIndex = 18
        Me.LoadingPanel.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 50)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Loading" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please wait..."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MoveAllPostedBtn
        '
        Me.MoveAllPostedBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MoveAllPostedBtn.Enabled = False
        Me.MoveAllPostedBtn.Location = New System.Drawing.Point(348, 563)
        Me.MoveAllPostedBtn.Name = "MoveAllPostedBtn"
        Me.MoveAllPostedBtn.Size = New System.Drawing.Size(71, 43)
        Me.MoveAllPostedBtn.TabIndex = 19
        Me.MoveAllPostedBtn.Text = "MOVE POSTED"
        Me.MoveAllPostedBtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(349, 538)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 26)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Alternatively," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "load states to"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(322, 535)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(3, 76)
        Me.Panel1.TabIndex = 21
        '
        'PastOrderOrganisingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 628)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MoveAllPostedBtn)
        Me.Controls.Add(Me.LoadingPanel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DaysOldNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GetFromOtherBtn)
        Me.Controls.Add(Me.PastSubText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SendOldBtn)
        Me.Controls.Add(Me.LoadingProgress)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DestinationCB)
        Me.Controls.Add(Me.GatheredGrid)
        Me.Controls.Add(Me.GetFromPastBtn)
        Me.Controls.Add(Me.GetFromOrdersBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(470, 667)
        Me.MinimumSize = New System.Drawing.Size(470, 667)
        Me.Name = "PastOrderOrganisingForm"
        Me.Text = "Past Order Organiser"
        CType(Me.GatheredGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadingPanel.ResumeLayout(False)
        Me.LoadingPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetFromOrdersBtn As Button
    Friend WithEvents GetFromPastBtn As Button
    Friend WithEvents GatheredGrid As DataGridView
    Friend WithEvents DestinationCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents InfoLabel As Label
    Friend WithEvents LoadingProgress As ProgressBar
    Friend WithEvents SendOldBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PastSubText As TextBox
    Friend WithEvents GetFromOtherBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DaysOldNum As TextBox
    Friend WithEvents OrderNumCol As DataGridViewTextBoxColumn
    Friend WithEvents OrderCreationDateCol As DataGridViewTextBoxColumn
    Friend WithEvents OrderStateCol As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LoadingPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents MoveAllPostedBtn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
End Class

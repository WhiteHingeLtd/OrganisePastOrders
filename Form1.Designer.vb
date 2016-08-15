<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SendFilesBtn = New System.Windows.Forms.Button()
        Me.GatheredGrid = New System.Windows.Forms.DataGridView()
        Me.DestinationCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.LoadingProgress = New System.Windows.Forms.ProgressBar()
        Me.SendOldBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PastSubText = New System.Windows.Forms.TextBox()
        Me.GetFromOtherBtn = New System.Windows.Forms.Button()
        Me.OrderNumCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OrderCreationDateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderStateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GatheredGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GetFromOrdersBtn
        '
        Me.GetFromOrdersBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GetFromOrdersBtn.Location = New System.Drawing.Point(198, 12)
        Me.GetFromOrdersBtn.Name = "GetFromOrdersBtn"
        Me.GetFromOrdersBtn.Size = New System.Drawing.Size(119, 23)
        Me.GetFromOrdersBtn.TabIndex = 0
        Me.GetFromOrdersBtn.Text = "Gather from Orders"
        Me.GetFromOrdersBtn.UseVisualStyleBackColor = True
        '
        'GetFromPastBtn
        '
        Me.GetFromPastBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GetFromPastBtn.Location = New System.Drawing.Point(323, 12)
        Me.GetFromPastBtn.Name = "GetFromPastBtn"
        Me.GetFromPastBtn.Size = New System.Drawing.Size(119, 23)
        Me.GetFromPastBtn.TabIndex = 1
        Me.GetFromPastBtn.Text = "Gather from Past"
        Me.GetFromPastBtn.UseVisualStyleBackColor = True
        '
        'SendFilesBtn
        '
        Me.SendFilesBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SendFilesBtn.Location = New System.Drawing.Point(355, 558)
        Me.SendFilesBtn.Name = "SendFilesBtn"
        Me.SendFilesBtn.Size = New System.Drawing.Size(87, 23)
        Me.SendFilesBtn.TabIndex = 2
        Me.SendFilesBtn.Text = "Send Selected"
        Me.SendFilesBtn.UseVisualStyleBackColor = True
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
        Me.GatheredGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNumCol, Me.SelectedCol, Me.OrderCreationDateCol, Me.OrderStateCol})
        Me.GatheredGrid.Location = New System.Drawing.Point(12, 71)
        Me.GatheredGrid.Name = "GatheredGrid"
        Me.GatheredGrid.RowHeadersVisible = False
        Me.GatheredGrid.Size = New System.Drawing.Size(430, 481)
        Me.GatheredGrid.TabIndex = 3
        '
        'DestinationCB
        '
        Me.DestinationCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DestinationCB.FormattingEnabled = True
        Me.DestinationCB.Items.AddRange(New Object() {"Date-based folder", "Orders folder"})
        Me.DestinationCB.Location = New System.Drawing.Point(129, 560)
        Me.DestinationCB.Name = "DestinationCB"
        Me.DestinationCB.Size = New System.Drawing.Size(140, 21)
        Me.DestinationCB.TabIndex = 4
        Me.DestinationCB.Text = "---Please Select---"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 563)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Send selected files to:"
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(12, 17)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(128, 13)
        Me.InfoLabel.TabIndex = 6
        Me.InfoLabel.Text = "Gather files to get started."
        '
        'LoadingProgress
        '
        Me.LoadingProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingProgress.Location = New System.Drawing.Point(15, 587)
        Me.LoadingProgress.Name = "LoadingProgress"
        Me.LoadingProgress.Size = New System.Drawing.Size(427, 29)
        Me.LoadingProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LoadingProgress.TabIndex = 7
        '
        'SendOldBtn
        '
        Me.SendOldBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SendOldBtn.Location = New System.Drawing.Point(275, 558)
        Me.SendOldBtn.Name = "SendOldBtn"
        Me.SendOldBtn.Size = New System.Drawing.Size(74, 23)
        Me.SendOldBtn.TabIndex = 8
        Me.SendOldBtn.Text = "Send Old"
        Me.SendOldBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Load from: T:\AppData\Orders\Past\"
        '
        'PastSubText
        '
        Me.PastSubText.Location = New System.Drawing.Point(198, 41)
        Me.PastSubText.Name = "PastSubText"
        Me.PastSubText.Size = New System.Drawing.Size(119, 20)
        Me.PastSubText.TabIndex = 10
        '
        'GetFromOtherBtn
        '
        Me.GetFromOtherBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GetFromOtherBtn.Enabled = False
        Me.GetFromOtherBtn.Location = New System.Drawing.Point(323, 41)
        Me.GetFromOtherBtn.Name = "GetFromOtherBtn"
        Me.GetFromOtherBtn.Size = New System.Drawing.Size(119, 23)
        Me.GetFromOtherBtn.TabIndex = 11
        Me.GetFromOtherBtn.Text = "Gather from Other"
        Me.GetFromOtherBtn.UseVisualStyleBackColor = True
        '
        'OrderNumCol
        '
        Me.OrderNumCol.HeaderText = "Order Number"
        Me.OrderNumCol.Name = "OrderNumCol"
        Me.OrderNumCol.ReadOnly = True
        '
        'SelectedCol
        '
        Me.SelectedCol.HeaderText = "Selected"
        Me.SelectedCol.Name = "SelectedCol"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 628)
        Me.Controls.Add(Me.GetFromOtherBtn)
        Me.Controls.Add(Me.PastSubText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SendOldBtn)
        Me.Controls.Add(Me.LoadingProgress)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DestinationCB)
        Me.Controls.Add(Me.GatheredGrid)
        Me.Controls.Add(Me.SendFilesBtn)
        Me.Controls.Add(Me.GetFromPastBtn)
        Me.Controls.Add(Me.GetFromOrdersBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GatheredGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetFromOrdersBtn As Button
    Friend WithEvents GetFromPastBtn As Button
    Friend WithEvents SendFilesBtn As Button
    Friend WithEvents GatheredGrid As DataGridView
    Friend WithEvents DestinationCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents InfoLabel As Label
    Friend WithEvents LoadingProgress As ProgressBar
    Friend WithEvents SendOldBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PastSubText As TextBox
    Friend WithEvents GetFromOtherBtn As Button
    Friend WithEvents OrderNumCol As DataGridViewTextBoxColumn
    Friend WithEvents SelectedCol As DataGridViewCheckBoxColumn
    Friend WithEvents OrderCreationDateCol As DataGridViewTextBoxColumn
    Friend WithEvents OrderStateCol As DataGridViewTextBoxColumn
End Class

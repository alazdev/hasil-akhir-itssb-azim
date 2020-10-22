<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrepaidPackageForm
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PC_SB_MODUL2DataSet = New PC_SB_MODUL2.PC_SB_MODUL2DataSet()
        Me.ViewPrepaidPackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_PrepaidPackageTableAdapter = New PC_SB_MODUL2.PC_SB_MODUL2DataSetTableAdapters.View_PrepaidPackageTableAdapter()
        Me.PrepaidPackageIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PC_SB_MODUL2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPrepaidPackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(681, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 27)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(599, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search : "
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(343, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Transaction Prepaid Package"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrepaidPackageIdDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.PackageNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ViewPrepaidPackageBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(876, 238)
        Me.DataGridView1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 337)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(875, 124)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(153, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(275, 27)
        Me.TextBox2.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(579, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "[Address]"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(579, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "[Name]"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(463, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(463, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(149, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Not found? Add new +"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Phone Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 468)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 21)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Prepaid Package Id"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 502)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 21)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Package"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 540)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 21)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Price"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(213, 464)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(228, 27)
        Me.TextBox3.TabIndex = 39
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(213, 498)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 29)
        Me.ComboBox1.TabIndex = 40
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(213, 536)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(228, 27)
        Me.NumericUpDown1.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 581)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 28)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PC_SB_MODUL2DataSet
        '
        Me.PC_SB_MODUL2DataSet.DataSetName = "PC_SB_MODUL2DataSet"
        Me.PC_SB_MODUL2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewPrepaidPackageBindingSource
        '
        Me.ViewPrepaidPackageBindingSource.DataMember = "View_PrepaidPackage"
        Me.ViewPrepaidPackageBindingSource.DataSource = Me.PC_SB_MODUL2DataSet
        '
        'View_PrepaidPackageTableAdapter
        '
        Me.View_PrepaidPackageTableAdapter.ClearBeforeFill = True
        '
        'PrepaidPackageIdDataGridViewTextBoxColumn
        '
        Me.PrepaidPackageIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrepaidPackageIdDataGridViewTextBoxColumn.DataPropertyName = "Prepaid Package Id"
        Me.PrepaidPackageIdDataGridViewTextBoxColumn.HeaderText = "Prepaid Package Id"
        Me.PrepaidPackageIdDataGridViewTextBoxColumn.Name = "PrepaidPackageIdDataGridViewTextBoxColumn"
        Me.PrepaidPackageIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrepaidPackageIdDataGridViewTextBoxColumn.Width = 154
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 149
        '
        'PackageNameDataGridViewTextBoxColumn
        '
        Me.PackageNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PackageNameDataGridViewTextBoxColumn.DataPropertyName = "PackageName"
        Me.PackageNameDataGridViewTextBoxColumn.HeaderText = "Package Name"
        Me.PackageNameDataGridViewTextBoxColumn.Name = "PackageNameDataGridViewTextBoxColumn"
        Me.PackageNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PackageNameDataGridViewTextBoxColumn.Width = 143
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 72
        '
        'PrepaidPackageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "PrepaidPackageForm"
        Me.Text = "PrepaidPackageForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PC_SB_MODUL2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewPrepaidPackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents PC_SB_MODUL2DataSet As PC_SB_MODUL2DataSet
    Friend WithEvents ViewPrepaidPackageBindingSource As BindingSource
    Friend WithEvents View_PrepaidPackageTableAdapter As PC_SB_MODUL2DataSetTableAdapters.View_PrepaidPackageTableAdapter
    Friend WithEvents PrepaidPackageIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackageNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

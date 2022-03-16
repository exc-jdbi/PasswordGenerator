Option Strict On
Option Explicit On

Namespace exc.jdbi.GeneratorPassword.App.TestVb

  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
  Partial Class FrmTestMain
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
      Me.TlpOutput = New System.Windows.Forms.TableLayoutPanel()
      Me.TbOutput = New System.Windows.Forms.TextBox()
      Me.PnGenerateButton = New System.Windows.Forms.Panel()
      Me.BtGenerate = New System.Windows.Forms.Button()
      Me.SsMain = New System.Windows.Forms.StatusStrip()
      Me.TsslPasswordStrength = New System.Windows.Forms.ToolStripStatusLabel()
      Me.ScMain = New System.Windows.Forms.SplitContainer()
      Me.TlpOtion = New System.Windows.Forms.TableLayoutPanel()
      Me.TlpLetters = New System.Windows.Forms.TableLayoutPanel()
      Me.TbLength = New System.Windows.Forms.TrackBar()
      Me.NudLength = New System.Windows.Forms.NumericUpDown()
      Me.CbInternationalSymbols = New System.Windows.Forms.CheckBox()
      Me.CbSpecialCharacters = New System.Windows.Forms.CheckBox()
      Me.CbUppers = New System.Windows.Forms.CheckBox()
      Me.CbLowers = New System.Windows.Forms.CheckBox()
      Me.CbNumerics = New System.Windows.Forms.CheckBox()
      Me.LbAdditionalOption = New System.Windows.Forms.Label()
      Me.LbLength = New System.Windows.Forms.Label()
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
      Me.LbEncoding = New System.Windows.Forms.Label()
      Me.CbBytes = New System.Windows.Forms.CheckBox()
      Me.CbLetters = New System.Windows.Forms.CheckBox()
      Me.LbPwVariant = New System.Windows.Forms.Label()
      Me.CbB64Url = New System.Windows.Forms.CheckBox()
      Me.CbB64 = New System.Windows.Forms.CheckBox()
      Me.CbB62 = New System.Windows.Forms.CheckBox()
      Me.CbB32 = New System.Windows.Forms.CheckBox()
      Me.CbHex = New System.Windows.Forms.CheckBox()
      Me.CbNone = New System.Windows.Forms.CheckBox()
      Me.TlpOutput.SuspendLayout()
      Me.PnGenerateButton.SuspendLayout()
      Me.SsMain.SuspendLayout()
      CType(Me.ScMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ScMain.Panel1.SuspendLayout()
      Me.ScMain.Panel2.SuspendLayout()
      Me.ScMain.SuspendLayout()
      Me.TlpOtion.SuspendLayout()
      Me.TlpLetters.SuspendLayout()
      CType(Me.TbLength, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.NudLength, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TableLayoutPanel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'TlpOutput
      '
      Me.TlpOutput.ColumnCount = 2
      Me.TlpOutput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TlpOutput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
      Me.TlpOutput.Controls.Add(Me.TbOutput, 0, 0)
      Me.TlpOutput.Controls.Add(Me.PnGenerateButton, 1, 0)
      Me.TlpOutput.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TlpOutput.Location = New System.Drawing.Point(0, 0)
      Me.TlpOutput.Margin = New System.Windows.Forms.Padding(5)
      Me.TlpOutput.Name = "TlpOutput"
      Me.TlpOutput.RowCount = 1
      Me.TlpOutput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TlpOutput.Size = New System.Drawing.Size(534, 141)
      Me.TlpOutput.TabIndex = 100
      '
      'TbOutput
      '
      Me.TbOutput.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TbOutput.Location = New System.Drawing.Point(4, 4)
      Me.TbOutput.Margin = New System.Windows.Forms.Padding(4)
      Me.TbOutput.Multiline = True
      Me.TbOutput.Name = "TbOutput"
      Me.TbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.TbOutput.Size = New System.Drawing.Size(376, 133)
      Me.TbOutput.TabIndex = 15
      '
      'PnGenerateButton
      '
      Me.PnGenerateButton.Controls.Add(Me.BtGenerate)
      Me.PnGenerateButton.Location = New System.Drawing.Point(387, 3)
      Me.PnGenerateButton.Name = "PnGenerateButton"
      Me.PnGenerateButton.Size = New System.Drawing.Size(144, 111)
      Me.PnGenerateButton.TabIndex = 14
      '
      'BtGenerate
      '
      Me.BtGenerate.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.BtGenerate.Location = New System.Drawing.Point(12, 8)
      Me.BtGenerate.Name = "BtGenerate"
      Me.BtGenerate.Size = New System.Drawing.Size(119, 36)
      Me.BtGenerate.TabIndex = 14
      Me.BtGenerate.Text = "Generate"
      Me.BtGenerate.UseVisualStyleBackColor = True
      '
      'SsMain
      '
      Me.SsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsslPasswordStrength})
      Me.SsMain.Location = New System.Drawing.Point(0, 529)
      Me.SsMain.Name = "SsMain"
      Me.SsMain.Padding = New System.Windows.Forms.Padding(1, 0, 22, 0)
      Me.SsMain.Size = New System.Drawing.Size(534, 22)
      Me.SsMain.TabIndex = 2
      Me.SsMain.Text = "StatusStrip1"
      '
      'TsslPasswordStrength
      '
      Me.TsslPasswordStrength.AutoSize = False
      Me.TsslPasswordStrength.Name = "TsslPasswordStrength"
      Me.TsslPasswordStrength.Size = New System.Drawing.Size(511, 17)
      Me.TsslPasswordStrength.Spring = True
      Me.TsslPasswordStrength.Text = "[PasswordStrength]"
      '
      'ScMain
      '
      Me.ScMain.BackColor = System.Drawing.Color.Transparent
      Me.ScMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.ScMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
      Me.ScMain.IsSplitterFixed = True
      Me.ScMain.Location = New System.Drawing.Point(0, 0)
      Me.ScMain.Margin = New System.Windows.Forms.Padding(5)
      Me.ScMain.Name = "ScMain"
      Me.ScMain.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'ScMain.Panel1
      '
      Me.ScMain.Panel1.Controls.Add(Me.TlpOtion)
      '
      'ScMain.Panel2
      '
      Me.ScMain.Panel2.Controls.Add(Me.TlpOutput)
      Me.ScMain.Size = New System.Drawing.Size(534, 529)
      Me.ScMain.SplitterDistance = 382
      Me.ScMain.SplitterWidth = 6
      Me.ScMain.TabIndex = 3
      '
      'TlpOtion
      '
      Me.TlpOtion.ColumnCount = 2
      Me.TlpOtion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
      Me.TlpOtion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
      Me.TlpOtion.Controls.Add(Me.TlpLetters, 0, 0)
      Me.TlpOtion.Controls.Add(Me.TableLayoutPanel1, 1, 0)
      Me.TlpOtion.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TlpOtion.Location = New System.Drawing.Point(0, 0)
      Me.TlpOtion.Name = "TlpOtion"
      Me.TlpOtion.RowCount = 1
      Me.TlpOtion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TlpOtion.Size = New System.Drawing.Size(534, 382)
      Me.TlpOtion.TabIndex = 0
      '
      'TlpLetters
      '
      Me.TlpLetters.ColumnCount = 1
      Me.TlpLetters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TlpLetters.Controls.Add(Me.TbLength, 0, 8)
      Me.TlpLetters.Controls.Add(Me.NudLength, 0, 7)
      Me.TlpLetters.Controls.Add(Me.CbInternationalSymbols, 0, 5)
      Me.TlpLetters.Controls.Add(Me.CbSpecialCharacters, 0, 4)
      Me.TlpLetters.Controls.Add(Me.CbUppers, 0, 3)
      Me.TlpLetters.Controls.Add(Me.CbLowers, 0, 2)
      Me.TlpLetters.Controls.Add(Me.CbNumerics, 0, 1)
      Me.TlpLetters.Controls.Add(Me.LbAdditionalOption, 0, 0)
      Me.TlpLetters.Controls.Add(Me.LbLength, 0, 6)
      Me.TlpLetters.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TlpLetters.Location = New System.Drawing.Point(3, 3)
      Me.TlpLetters.Name = "TlpLetters"
      Me.TlpLetters.RowCount = 10
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
      Me.TlpLetters.RowStyles.Add(New System.Windows.Forms.RowStyle())
      Me.TlpLetters.Size = New System.Drawing.Size(314, 376)
      Me.TlpLetters.TabIndex = 100
      '
      'TbLength
      '
      Me.TbLength.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.TbLength.BackColor = System.Drawing.Color.White
      Me.TbLength.Location = New System.Drawing.Point(3, 288)
      Me.TbLength.Maximum = 1024
      Me.TbLength.Minimum = 10
      Me.TbLength.Name = "TbLength"
      Me.TbLength.Size = New System.Drawing.Size(308, 34)
      Me.TbLength.TabIndex = 6
      Me.TbLength.Value = 17
      '
      'NudLength
      '
      Me.NudLength.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.NudLength.Location = New System.Drawing.Point(10, 250)
      Me.NudLength.Margin = New System.Windows.Forms.Padding(10, 4, 4, 4)
      Me.NudLength.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
      Me.NudLength.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
      Me.NudLength.Name = "NudLength"
      Me.NudLength.Size = New System.Drawing.Size(300, 29)
      Me.NudLength.TabIndex = 5
      Me.NudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.NudLength.Value = New Decimal(New Integer() {17, 0, 0, 0})
      '
      'CbInternationalSymbols
      '
      Me.CbInternationalSymbols.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbInternationalSymbols.AutoSize = True
      Me.CbInternationalSymbols.Location = New System.Drawing.Point(10, 183)
      Me.CbInternationalSymbols.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbInternationalSymbols.Name = "CbInternationalSymbols"
      Me.CbInternationalSymbols.Size = New System.Drawing.Size(283, 26)
      Me.CbInternationalSymbols.TabIndex = 4
      Me.CbInternationalSymbols.Tag = "0"
      Me.CbInternationalSymbols.Text = "International Symbols (中国 ...)"
      Me.CbInternationalSymbols.UseVisualStyleBackColor = True
      '
      'CbSpecialCharacters
      '
      Me.CbSpecialCharacters.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbSpecialCharacters.AutoSize = True
      Me.CbSpecialCharacters.Location = New System.Drawing.Point(10, 146)
      Me.CbSpecialCharacters.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbSpecialCharacters.Name = "CbSpecialCharacters"
      Me.CbSpecialCharacters.Size = New System.Drawing.Size(284, 26)
      Me.CbSpecialCharacters.TabIndex = 3
      Me.CbSpecialCharacters.Tag = "0"
      Me.CbSpecialCharacters.Text = "Special Characters (@#$% ...)"
      Me.CbSpecialCharacters.UseVisualStyleBackColor = True
      '
      'CbUppers
      '
      Me.CbUppers.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbUppers.AutoSize = True
      Me.CbUppers.Checked = True
      Me.CbUppers.CheckState = System.Windows.Forms.CheckState.Checked
      Me.CbUppers.Location = New System.Drawing.Point(10, 109)
      Me.CbUppers.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbUppers.Name = "CbUppers"
      Me.CbUppers.Size = New System.Drawing.Size(296, 26)
      Me.CbUppers.TabIndex = 2
      Me.CbUppers.Tag = "0"
      Me.CbUppers.Text = "Uppercase Characters (ABC ...)"
      Me.CbUppers.UseVisualStyleBackColor = True
      '
      'CbLowers
      '
      Me.CbLowers.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbLowers.AutoSize = True
      Me.CbLowers.Checked = True
      Me.CbLowers.CheckState = System.Windows.Forms.CheckState.Checked
      Me.CbLowers.Location = New System.Drawing.Point(10, 72)
      Me.CbLowers.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbLowers.Name = "CbLowers"
      Me.CbLowers.Size = New System.Drawing.Size(287, 26)
      Me.CbLowers.TabIndex = 1
      Me.CbLowers.Tag = "0"
      Me.CbLowers.Text = "Lowercase Characters (abc ...)"
      Me.CbLowers.UseVisualStyleBackColor = True
      '
      'CbNumerics
      '
      Me.CbNumerics.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbNumerics.AutoSize = True
      Me.CbNumerics.Checked = True
      Me.CbNumerics.CheckState = System.Windows.Forms.CheckState.Checked
      Me.CbNumerics.Location = New System.Drawing.Point(10, 35)
      Me.CbNumerics.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbNumerics.Name = "CbNumerics"
      Me.CbNumerics.Size = New System.Drawing.Size(176, 26)
      Me.CbNumerics.TabIndex = 0
      Me.CbNumerics.Tag = "0"
      Me.CbNumerics.Text = "Numbers (123 ...)"
      Me.CbNumerics.UseVisualStyleBackColor = True
      '
      'LbAdditionalOption
      '
      Me.LbAdditionalOption.Dock = System.Windows.Forms.DockStyle.Fill
      Me.LbAdditionalOption.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
      Me.LbAdditionalOption.Location = New System.Drawing.Point(10, 0)
      Me.LbAdditionalOption.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
      Me.LbAdditionalOption.Name = "LbAdditionalOption"
      Me.LbAdditionalOption.Size = New System.Drawing.Size(301, 30)
      Me.LbAdditionalOption.TabIndex = 2
      Me.LbAdditionalOption.Text = "Additional Options"
      Me.LbAdditionalOption.TextAlign = System.Drawing.ContentAlignment.BottomLeft
      '
      'LbLength
      '
      Me.LbLength.Dock = System.Windows.Forms.DockStyle.Fill
      Me.LbLength.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
      Me.LbLength.Location = New System.Drawing.Point(10, 215)
      Me.LbLength.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
      Me.LbLength.Name = "LbLength"
      Me.LbLength.Size = New System.Drawing.Size(301, 30)
      Me.LbLength.TabIndex = 2
      Me.LbLength.Text = "Length"
      Me.LbLength.TextAlign = System.Drawing.ContentAlignment.BottomLeft
      '
      'TableLayoutPanel1
      '
      Me.TableLayoutPanel1.ColumnCount = 1
      Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TableLayoutPanel1.Controls.Add(Me.LbEncoding, 0, 0)
      Me.TableLayoutPanel1.Controls.Add(Me.CbBytes, 0, 9)
      Me.TableLayoutPanel1.Controls.Add(Me.CbLetters, 0, 8)
      Me.TableLayoutPanel1.Controls.Add(Me.LbPwVariant, 0, 7)
      Me.TableLayoutPanel1.Controls.Add(Me.CbB64Url, 0, 6)
      Me.TableLayoutPanel1.Controls.Add(Me.CbB64, 0, 5)
      Me.TableLayoutPanel1.Controls.Add(Me.CbB62, 0, 4)
      Me.TableLayoutPanel1.Controls.Add(Me.CbB32, 0, 3)
      Me.TableLayoutPanel1.Controls.Add(Me.CbHex, 0, 2)
      Me.TableLayoutPanel1.Controls.Add(Me.CbNone, 0, 1)
      Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(323, 3)
      Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
      Me.TableLayoutPanel1.RowCount = 11
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(208, 376)
      Me.TableLayoutPanel1.TabIndex = 100
      '
      'LbEncoding
      '
      Me.LbEncoding.Dock = System.Windows.Forms.DockStyle.Fill
      Me.LbEncoding.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
      Me.LbEncoding.Location = New System.Drawing.Point(10, 0)
      Me.LbEncoding.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
      Me.LbEncoding.Name = "LbEncoding"
      Me.LbEncoding.Size = New System.Drawing.Size(195, 30)
      Me.LbEncoding.TabIndex = 0
      Me.LbEncoding.Text = "Encoding"
      Me.LbEncoding.TextAlign = System.Drawing.ContentAlignment.BottomLeft
      '
      'CbBytes
      '
      Me.CbBytes.Tag = "2"
      Me.CbBytes.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbBytes.AutoSize = True
      Me.CbBytes.Location = New System.Drawing.Point(10, 324)
      Me.CbBytes.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbBytes.Name = "CbBytes"
      Me.CbBytes.Size = New System.Drawing.Size(154, 26)
      Me.CbBytes.TabIndex = 13
      Me.CbBytes.Text = "Bytes (0 - 255)"
      Me.CbBytes.UseVisualStyleBackColor = True
      '
      'CbLetters
      '
      Me.CbLetters.Tag = "2"
      Me.CbLetters.Checked = True
      Me.CbLetters.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbLetters.AutoSize = True
      Me.CbLetters.CheckState = System.Windows.Forms.CheckState.Checked
      Me.CbLetters.Location = New System.Drawing.Point(10, 287)
      Me.CbLetters.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbLetters.Name = "CbLetters"
      Me.CbLetters.Size = New System.Drawing.Size(172, 26)
      Me.CbLetters.TabIndex = 12
      Me.CbLetters.Text = "Letters (AaBb ...)"
      Me.CbLetters.UseVisualStyleBackColor = True
      '
      'LbPwVariant
      '
      Me.LbPwVariant.Dock = System.Windows.Forms.DockStyle.Fill
      Me.LbPwVariant.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
      Me.LbPwVariant.Location = New System.Drawing.Point(10, 252)
      Me.LbPwVariant.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
      Me.LbPwVariant.Name = "LbPwVariant"
      Me.LbPwVariant.Size = New System.Drawing.Size(195, 30)
      Me.LbPwVariant.TabIndex = 0
      Me.LbPwVariant.Text = "Password Variants"
      Me.LbPwVariant.TextAlign = System.Drawing.ContentAlignment.BottomLeft
      '
      'CbB64Url
      '
      Me.CbB64Url.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbB64Url.AutoSize = True
      Me.CbB64Url.Location = New System.Drawing.Point(10, 220)
      Me.CbB64Url.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbB64Url.Name = "CbB64Url"
      Me.CbB64Url.Size = New System.Drawing.Size(128, 26)
      Me.CbB64Url.TabIndex = 11
      Me.CbB64Url.Tag = "1"
      Me.CbB64Url.Text = "Base 64 Url"
      Me.CbB64Url.UseVisualStyleBackColor = True
      '
      'CbB64
      '
      Me.CbB64.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbB64.AutoSize = True
      Me.CbB64.Location = New System.Drawing.Point(10, 183)
      Me.CbB64.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbB64.Name = "CbB64"
      Me.CbB64.Size = New System.Drawing.Size(100, 26)
      Me.CbB64.TabIndex = 10
      Me.CbB64.Tag = "1"
      Me.CbB64.Text = "Base 64"
      Me.CbB64.UseVisualStyleBackColor = True
      '
      'CbB62
      '
      Me.CbB62.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbB62.AutoSize = True
      Me.CbB62.Location = New System.Drawing.Point(10, 146)
      Me.CbB62.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbB62.Name = "CbB62"
      Me.CbB62.Size = New System.Drawing.Size(100, 26)
      Me.CbB62.TabIndex = 9
      Me.CbB62.Tag = "1"
      Me.CbB62.Text = "Base 62"
      Me.CbB62.UseVisualStyleBackColor = True
      '
      'CbB32
      '
      Me.CbB32.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbB32.AutoSize = True
      Me.CbB32.Location = New System.Drawing.Point(10, 109)
      Me.CbB32.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbB32.Name = "CbB32"
      Me.CbB32.Size = New System.Drawing.Size(100, 26)
      Me.CbB32.TabIndex = 8
      Me.CbB32.Tag = "1"
      Me.CbB32.Text = "Base 32"
      Me.CbB32.UseVisualStyleBackColor = True
      '
      'CbHex
      '
      Me.CbHex.Tag = "1"
      Me.CbHex.Checked = True
      Me.CbHex.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbHex.AutoSize = True
      Me.CbHex.CheckState = System.Windows.Forms.CheckState.Checked
      Me.CbHex.Location = New System.Drawing.Point(10, 72)
      Me.CbHex.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbHex.Name = "CbHex"
      Me.CbHex.Size = New System.Drawing.Size(62, 26)
      Me.CbHex.TabIndex = 7
      Me.CbHex.Text = "Hex"
      Me.CbHex.UseVisualStyleBackColor = True
      '
      'CbNone
      '
      Me.CbNone.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbNone.AutoSize = True
      Me.CbNone.Location = New System.Drawing.Point(10, 35)
      Me.CbNone.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbNone.Name = "CbNone"
      Me.CbNone.Size = New System.Drawing.Size(74, 26)
      Me.CbNone.TabIndex = 7
      Me.CbNone.Tag = "1"
      Me.CbNone.Text = "None"
      Me.CbNone.UseVisualStyleBackColor = True
      '
      'FrmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.White
      Me.ClientSize = New System.Drawing.Size(534, 551)
      Me.Controls.Add(Me.ScMain)
      Me.Controls.Add(Me.SsMain)
      Me.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
      Me.Margin = New System.Windows.Forms.Padding(5)
      Me.MinimumSize = New System.Drawing.Size(550, 590)
      Me.Name = "FrmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "© PasswordGenerator 20022 Created from © exc-jdbi 2022"
      Me.TlpOutput.ResumeLayout(False)
      Me.TlpOutput.PerformLayout()
      Me.PnGenerateButton.ResumeLayout(False)
      Me.SsMain.ResumeLayout(False)
      Me.SsMain.PerformLayout()
      Me.ScMain.Panel1.ResumeLayout(False)
      Me.ScMain.Panel2.ResumeLayout(False)
      CType(Me.ScMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ScMain.ResumeLayout(False)
      Me.TlpOtion.ResumeLayout(False)
      Me.TlpLetters.ResumeLayout(False)
      Me.TlpLetters.PerformLayout()
      CType(Me.TbLength, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.NudLength, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.TableLayoutPanel1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

    End Sub

    Friend WithEvents TlpOutput As TableLayoutPanel
    Friend WithEvents SsMain As StatusStrip
    Friend WithEvents ScMain As SplitContainer
    Friend WithEvents TbOutput As TextBox
    Friend WithEvents BtGenerate As Button
    Friend WithEvents PnGenerateButton As Panel
    Friend WithEvents TlpOtion As TableLayoutPanel
    Friend WithEvents TlpLetters As TableLayoutPanel
    Friend WithEvents TbLength As TrackBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NudLength As NumericUpDown
    Friend WithEvents LbEncoding As Label
    Friend WithEvents LbPwVariant As Label
    Friend WithEvents LbAdditionalOption As Label
    Friend WithEvents LbLength As Label
    Private WithEvents CbLowers As CheckBox
    Private WithEvents CbNumerics As CheckBox
    Private WithEvents CbUppers As CheckBox
    Private WithEvents CbSpecialCharacters As CheckBox
    Private WithEvents CbInternationalSymbols As CheckBox
    Private WithEvents CbHex As CheckBox
    Private WithEvents CbB32 As CheckBox
    Private WithEvents CbB62 As CheckBox
    Private WithEvents CbB64 As CheckBox
    Private WithEvents CbB64Url As CheckBox
    Private WithEvents CbLetters As CheckBox
    Private WithEvents CbBytes As CheckBox
    Private WithEvents CbNone As CheckBox
    Friend WithEvents TsslPasswordStrength As ToolStripStatusLabel
  End Class

End Namespace
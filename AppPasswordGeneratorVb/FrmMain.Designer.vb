Option Strict On
Option Explicit On

Namespace exc.jdbi.PasswordGenerator.App.Vb

  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
  Partial Class FrmMain
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
      Me.ScMain = New System.Windows.Forms.SplitContainer()
      Me.TlpTitle = New System.Windows.Forms.TableLayoutPanel()
      Me.PbTitle = New System.Windows.Forms.PictureBox()
      Me.label1 = New System.Windows.Forms.Label()
      Me.TlpMain = New System.Windows.Forms.TableLayoutPanel()
      Me.GbAdditionalOptions = New System.Windows.Forms.GroupBox()
      Me.TlpAdditionalOption = New System.Windows.Forms.TableLayoutPanel()
      Me.CbInternationalSymbols = New System.Windows.Forms.CheckBox()
      Me.CbNumerics = New System.Windows.Forms.CheckBox()
      Me.CbSpecialCharacters = New System.Windows.Forms.CheckBox()
      Me.CbLowers = New System.Windows.Forms.CheckBox()
      Me.CbUppers = New System.Windows.Forms.CheckBox()
      Me.GbEncoding = New System.Windows.Forms.GroupBox()
      Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
      Me.CbB64Url = New System.Windows.Forms.CheckBox()
      Me.CbNone = New System.Windows.Forms.CheckBox()
      Me.CbHex = New System.Windows.Forms.CheckBox()
      Me.CbB32 = New System.Windows.Forms.CheckBox()
      Me.CbB62 = New System.Windows.Forms.CheckBox()
      Me.CbB64 = New System.Windows.Forms.CheckBox()
      Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
      Me.GbPasswordVariants = New System.Windows.Forms.GroupBox()
      Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
      Me.CbBytes = New System.Windows.Forms.CheckBox()
      Me.CbLetters = New System.Windows.Forms.CheckBox()
      Me.GbGeneratePassword = New System.Windows.Forms.GroupBox()
      Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
      Me.NudLength = New System.Windows.Forms.NumericUpDown()
      Me.BtPasswordGenerate = New System.Windows.Forms.Button()
      Me.PbClear = New System.Windows.Forms.PictureBox()
      Me.PbCopy = New System.Windows.Forms.PictureBox()
      Me.PlOutput = New System.Windows.Forms.Panel()
      Me.TbOutput = New System.Windows.Forms.TextBox()
      Me.LbPasswordStrength = New System.Windows.Forms.Label()
      CType(Me.ScMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ScMain.Panel1.SuspendLayout()
      Me.ScMain.Panel2.SuspendLayout()
      Me.ScMain.SuspendLayout()
      Me.TlpTitle.SuspendLayout()
      CType(Me.PbTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TlpMain.SuspendLayout()
      Me.GbAdditionalOptions.SuspendLayout()
      Me.TlpAdditionalOption.SuspendLayout()
      Me.GbEncoding.SuspendLayout()
      Me.tableLayoutPanel2.SuspendLayout()
      Me.tableLayoutPanel3.SuspendLayout()
      Me.GbPasswordVariants.SuspendLayout()
      Me.tableLayoutPanel4.SuspendLayout()
      Me.GbGeneratePassword.SuspendLayout()
      Me.tableLayoutPanel5.SuspendLayout()
      CType(Me.NudLength, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PbClear, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PbCopy, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PlOutput.SuspendLayout()
      Me.SuspendLayout()
      '
      'ScMain
      '
      Me.ScMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.ScMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
      Me.ScMain.Location = New System.Drawing.Point(0, 0)
      Me.ScMain.Margin = New System.Windows.Forms.Padding(4)
      Me.ScMain.Name = "ScMain"
      Me.ScMain.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'ScMain.Panel1
      '
      Me.ScMain.Panel1.Controls.Add(Me.TlpTitle)
      '
      'ScMain.Panel2
      '
      Me.ScMain.Panel2.Controls.Add(Me.TlpMain)
      Me.ScMain.Size = New System.Drawing.Size(874, 561)
      Me.ScMain.SplitterDistance = 60
      Me.ScMain.SplitterWidth = 2
      Me.ScMain.TabIndex = 1
      '
      'TlpTitle
      '
      Me.TlpTitle.BackColor = System.Drawing.Color.DimGray
      Me.TlpTitle.ColumnCount = 2
      Me.TlpTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
      Me.TlpTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
      Me.TlpTitle.Controls.Add(Me.PbTitle, 0, 0)
      Me.TlpTitle.Controls.Add(Me.label1, 1, 0)
      Me.TlpTitle.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TlpTitle.Location = New System.Drawing.Point(0, 0)
      Me.TlpTitle.Name = "TlpTitle"
      Me.TlpTitle.RowCount = 1
      Me.TlpTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TlpTitle.Size = New System.Drawing.Size(874, 60)
      Me.TlpTitle.TabIndex = 0
      '
      'PbTitle
      '
      Me.PbTitle.Dock = System.Windows.Forms.DockStyle.Fill
      Me.PbTitle.Image = Global.AppPasswordGeneratorVb.My.Resources.Resources.PwKeyPic
      Me.PbTitle.Location = New System.Drawing.Point(3, 3)
      Me.PbTitle.Name = "PbTitle"
      Me.PbTitle.Size = New System.Drawing.Size(64, 54)
      Me.PbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PbTitle.TabIndex = 0
      Me.PbTitle.TabStop = False
      '
      'label1
      '
      Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Right
      Me.label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
      Me.label1.ForeColor = System.Drawing.Color.White
      Me.label1.Location = New System.Drawing.Point(557, 4)
      Me.label1.Name = "label1"
      Me.label1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
      Me.label1.Size = New System.Drawing.Size(314, 51)
      Me.label1.TabIndex = 0
      Me.label1.Text = "Password Generator"
      Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'TlpMain
      '
      Me.TlpMain.BackColor = System.Drawing.Color.Transparent
      Me.TlpMain.ColumnCount = 1
      Me.TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TlpMain.Controls.Add(Me.GbAdditionalOptions, 0, 0)
      Me.TlpMain.Controls.Add(Me.GbEncoding, 0, 1)
      Me.TlpMain.Controls.Add(Me.tableLayoutPanel3, 0, 2)
      Me.TlpMain.Controls.Add(Me.PlOutput, 0, 3)
      Me.TlpMain.Controls.Add(Me.LbPasswordStrength, 0, 4)
      Me.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TlpMain.Location = New System.Drawing.Point(0, 0)
      Me.TlpMain.Name = "TlpMain"
      Me.TlpMain.RowCount = 5
      Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
      Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
      Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
      Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
      Me.TlpMain.Size = New System.Drawing.Size(874, 499)
      Me.TlpMain.TabIndex = 6
      '
      'GbAdditionalOptions
      '
      Me.GbAdditionalOptions.Controls.Add(Me.TlpAdditionalOption)
      Me.GbAdditionalOptions.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GbAdditionalOptions.Location = New System.Drawing.Point(6, 3)
      Me.GbAdditionalOptions.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
      Me.GbAdditionalOptions.Name = "GbAdditionalOptions"
      Me.GbAdditionalOptions.Size = New System.Drawing.Size(862, 94)
      Me.GbAdditionalOptions.TabIndex = 0
      Me.GbAdditionalOptions.TabStop = False
      Me.GbAdditionalOptions.Text = "Additional Options"
      '
      'TlpAdditionalOption
      '
      Me.TlpAdditionalOption.ColumnCount = 3
      Me.TlpAdditionalOption.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
      Me.TlpAdditionalOption.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TlpAdditionalOption.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
      Me.TlpAdditionalOption.Controls.Add(Me.CbInternationalSymbols, 2, 0)
      Me.TlpAdditionalOption.Controls.Add(Me.CbNumerics, 0, 0)
      Me.TlpAdditionalOption.Controls.Add(Me.CbSpecialCharacters, 1, 1)
      Me.TlpAdditionalOption.Controls.Add(Me.CbLowers, 0, 1)
      Me.TlpAdditionalOption.Controls.Add(Me.CbUppers, 1, 0)
      Me.TlpAdditionalOption.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TlpAdditionalOption.Location = New System.Drawing.Point(3, 22)
      Me.TlpAdditionalOption.Name = "TlpAdditionalOption"
      Me.TlpAdditionalOption.RowCount = 2
      Me.TlpAdditionalOption.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TlpAdditionalOption.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TlpAdditionalOption.Size = New System.Drawing.Size(856, 69)
      Me.TlpAdditionalOption.TabIndex = 0
      '
      'CbInternationalSymbols
      '
      Me.CbInternationalSymbols.Anchor = System.Windows.Forms.AnchorStyles.Right
      Me.CbInternationalSymbols.AutoSize = True
      Me.CbInternationalSymbols.Location = New System.Drawing.Point(619, 6)
      Me.CbInternationalSymbols.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbInternationalSymbols.Name = "CbInternationalSymbols"
      Me.CbInternationalSymbols.Size = New System.Drawing.Size(234, 22)
      Me.CbInternationalSymbols.TabIndex = 5
      Me.CbInternationalSymbols.Tag = "0"
      Me.CbInternationalSymbols.Text = "International Symbols (中国 ...)"
      Me.CbInternationalSymbols.UseVisualStyleBackColor = True
      '
      'CbNumerics
      '
      Me.CbNumerics.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbNumerics.AutoSize = True
      Me.CbNumerics.Checked = True
      Me.CbNumerics.CheckState = System.Windows.Forms.CheckState.Checked
      Me.CbNumerics.Location = New System.Drawing.Point(10, 6)
      Me.CbNumerics.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbNumerics.Name = "CbNumerics"
      Me.CbNumerics.Size = New System.Drawing.Size(147, 22)
      Me.CbNumerics.TabIndex = 1
      Me.CbNumerics.Tag = "0"
      Me.CbNumerics.Text = "Numbers (123 ...)"
      Me.CbNumerics.UseVisualStyleBackColor = True
      '
      'CbSpecialCharacters
      '
      Me.CbSpecialCharacters.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.CbSpecialCharacters.Location = New System.Drawing.Point(296, 38)
      Me.CbSpecialCharacters.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbSpecialCharacters.Name = "CbSpecialCharacters"
      Me.CbSpecialCharacters.Size = New System.Drawing.Size(270, 26)
      Me.CbSpecialCharacters.TabIndex = 4
      Me.CbSpecialCharacters.Tag = "0"
      Me.CbSpecialCharacters.Text = "Special Characters (@#$% ...)"
      Me.CbSpecialCharacters.UseVisualStyleBackColor = True
      '
      'CbLowers
      '
      Me.CbLowers.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbLowers.AutoSize = True
      Me.CbLowers.Checked = True
      Me.CbLowers.CheckState = System.Windows.Forms.CheckState.Checked
      Me.CbLowers.Location = New System.Drawing.Point(10, 40)
      Me.CbLowers.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbLowers.Name = "CbLowers"
      Me.CbLowers.Size = New System.Drawing.Size(241, 22)
      Me.CbLowers.TabIndex = 2
      Me.CbLowers.Tag = "0"
      Me.CbLowers.Text = "Lowercase Characters (abc ...)"
      Me.CbLowers.UseVisualStyleBackColor = True
      '
      'CbUppers
      '
      Me.CbUppers.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.CbUppers.Checked = True
      Me.CbUppers.CheckState = System.Windows.Forms.CheckState.Checked
      Me.CbUppers.Location = New System.Drawing.Point(296, 4)
      Me.CbUppers.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbUppers.Name = "CbUppers"
      Me.CbUppers.Size = New System.Drawing.Size(270, 26)
      Me.CbUppers.TabIndex = 3
      Me.CbUppers.Tag = "0"
      Me.CbUppers.Text = "Uppercase Characters (ABC ...)"
      Me.CbUppers.UseVisualStyleBackColor = True
      '
      'GbEncoding
      '
      Me.GbEncoding.Controls.Add(Me.tableLayoutPanel2)
      Me.GbEncoding.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GbEncoding.Location = New System.Drawing.Point(6, 103)
      Me.GbEncoding.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
      Me.GbEncoding.Name = "GbEncoding"
      Me.GbEncoding.Size = New System.Drawing.Size(862, 94)
      Me.GbEncoding.TabIndex = 7
      Me.GbEncoding.TabStop = False
      Me.GbEncoding.Text = "Encoding"
      '
      'tableLayoutPanel2
      '
      Me.tableLayoutPanel2.ColumnCount = 3
      Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
      Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
      Me.tableLayoutPanel2.Controls.Add(Me.CbB64Url, 2, 1)
      Me.tableLayoutPanel2.Controls.Add(Me.CbNone, 0, 0)
      Me.tableLayoutPanel2.Controls.Add(Me.CbHex, 0, 1)
      Me.tableLayoutPanel2.Controls.Add(Me.CbB32, 1, 0)
      Me.tableLayoutPanel2.Controls.Add(Me.CbB62, 1, 1)
      Me.tableLayoutPanel2.Controls.Add(Me.CbB64, 2, 0)
      Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 22)
      Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
      Me.tableLayoutPanel2.RowCount = 2
      Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.tableLayoutPanel2.Size = New System.Drawing.Size(856, 69)
      Me.tableLayoutPanel2.TabIndex = 0
      '
      'CbB64Url
      '
      Me.CbB64Url.Anchor = System.Windows.Forms.AnchorStyles.Right
      Me.CbB64Url.Location = New System.Drawing.Point(743, 40)
      Me.CbB64Url.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbB64Url.Name = "CbB64Url"
      Me.CbB64Url.Size = New System.Drawing.Size(110, 22)
      Me.CbB64Url.TabIndex = 13
      Me.CbB64Url.Tag = "1"
      Me.CbB64Url.Text = "Base 64 Url"
      Me.CbB64Url.UseVisualStyleBackColor = True
      '
      'CbNone
      '
      Me.CbNone.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbNone.AutoSize = True
      Me.CbNone.Location = New System.Drawing.Point(10, 6)
      Me.CbNone.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbNone.Name = "CbNone"
      Me.CbNone.Size = New System.Drawing.Size(64, 22)
      Me.CbNone.TabIndex = 8
      Me.CbNone.Tag = "1"
      Me.CbNone.Text = "None"
      Me.CbNone.UseVisualStyleBackColor = True
      '
      'CbHex
      '
      Me.CbHex.Tag = "1"
      Me.CbHex.Checked = True
      Me.CbHex.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.CbHex.AutoSize = True
      Me.CbHex.CheckState = System.Windows.Forms.CheckState.Checked
      Me.CbHex.Location = New System.Drawing.Point(10, 40)
      Me.CbHex.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbHex.Name = "CbHex"
      Me.CbHex.Size = New System.Drawing.Size(54, 22)
      Me.CbHex.TabIndex = 9
      Me.CbHex.Text = "Hex"
      Me.CbHex.UseVisualStyleBackColor = True
      '
      'CbB32
      '
      Me.CbB32.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.CbB32.Location = New System.Drawing.Point(376, 6)
      Me.CbB32.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbB32.Name = "CbB32"
      Me.CbB32.Size = New System.Drawing.Size(110, 22)
      Me.CbB32.TabIndex = 10
      Me.CbB32.Tag = "1"
      Me.CbB32.Text = "Base 32"
      Me.CbB32.UseVisualStyleBackColor = True
      '
      'CbB62
      '
      Me.CbB62.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.CbB62.Location = New System.Drawing.Point(376, 40)
      Me.CbB62.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbB62.Name = "CbB62"
      Me.CbB62.Size = New System.Drawing.Size(110, 22)
      Me.CbB62.TabIndex = 11
      Me.CbB62.Tag = "1"
      Me.CbB62.Text = "Base 62"
      Me.CbB62.UseVisualStyleBackColor = True
      '
      'CbB64
      '
      Me.CbB64.Anchor = System.Windows.Forms.AnchorStyles.Right
      Me.CbB64.Location = New System.Drawing.Point(743, 6)
      Me.CbB64.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbB64.Name = "CbB64"
      Me.CbB64.Size = New System.Drawing.Size(110, 22)
      Me.CbB64.TabIndex = 12
      Me.CbB64.Tag = "1"
      Me.CbB64.Text = "Base 64"
      Me.CbB64.UseVisualStyleBackColor = True
      '
      'tableLayoutPanel3
      '
      Me.tableLayoutPanel3.ColumnCount = 3
      Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430.0!))
      Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430.0!))
      Me.tableLayoutPanel3.Controls.Add(Me.GbPasswordVariants, 0, 0)
      Me.tableLayoutPanel3.Controls.Add(Me.GbGeneratePassword, 2, 0)
      Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tableLayoutPanel3.Location = New System.Drawing.Point(3, 203)
      Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
      Me.tableLayoutPanel3.RowCount = 1
      Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.tableLayoutPanel3.Size = New System.Drawing.Size(868, 79)
      Me.tableLayoutPanel3.TabIndex = 18
      '
      'GbPasswordVariants
      '
      Me.GbPasswordVariants.Controls.Add(Me.tableLayoutPanel4)
      Me.GbPasswordVariants.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GbPasswordVariants.Location = New System.Drawing.Point(3, 3)
      Me.GbPasswordVariants.Name = "GbPasswordVariants"
      Me.GbPasswordVariants.Size = New System.Drawing.Size(424, 73)
      Me.GbPasswordVariants.TabIndex = 15
      Me.GbPasswordVariants.TabStop = False
      Me.GbPasswordVariants.Text = "Password Variants"
      '
      'tableLayoutPanel4
      '
      Me.tableLayoutPanel4.ColumnCount = 2
      Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.tableLayoutPanel4.Controls.Add(Me.CbBytes, 0, 0)
      Me.tableLayoutPanel4.Controls.Add(Me.CbLetters, 0, 0)
      Me.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tableLayoutPanel4.Location = New System.Drawing.Point(3, 22)
      Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
      Me.tableLayoutPanel4.RowCount = 1
      Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.tableLayoutPanel4.Size = New System.Drawing.Size(418, 48)
      Me.tableLayoutPanel4.TabIndex = 0
      '
      'CbBytes
      '
      Me.CbBytes.Tag = "2"
      Me.CbBytes.Anchor = System.Windows.Forms.AnchorStyles.Right
      Me.CbBytes.AutoSize = True
      Me.CbBytes.Location = New System.Drawing.Point(286, 13)
      Me.CbBytes.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbBytes.Name = "CbBytes"
      Me.CbBytes.Size = New System.Drawing.Size(129, 22)
      Me.CbBytes.TabIndex = 17
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
      Me.CbLetters.Location = New System.Drawing.Point(10, 13)
      Me.CbLetters.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CbLetters.Name = "CbLetters"
      Me.CbLetters.Size = New System.Drawing.Size(145, 22)
      Me.CbLetters.TabIndex = 16
      Me.CbLetters.Text = "Letters (AaBb ...)"
      Me.CbLetters.UseVisualStyleBackColor = True
      '
      'GbGeneratePassword
      '
      Me.GbGeneratePassword.Controls.Add(Me.tableLayoutPanel5)
      Me.GbGeneratePassword.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GbGeneratePassword.Location = New System.Drawing.Point(441, 3)
      Me.GbGeneratePassword.Name = "GbGeneratePassword"
      Me.GbGeneratePassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.GbGeneratePassword.Size = New System.Drawing.Size(424, 73)
      Me.GbGeneratePassword.TabIndex = 19
      Me.GbGeneratePassword.TabStop = False
      Me.GbGeneratePassword.Text = "Generate Password"
      '
      'tableLayoutPanel5
      '
      Me.tableLayoutPanel5.ColumnCount = 4
      Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
      Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
      Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
      Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.tableLayoutPanel5.Controls.Add(Me.NudLength, 3, 0)
      Me.tableLayoutPanel5.Controls.Add(Me.BtPasswordGenerate, 0, 0)
      Me.tableLayoutPanel5.Controls.Add(Me.PbClear, 1, 0)
      Me.tableLayoutPanel5.Controls.Add(Me.PbCopy, 2, 0)
      Me.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tableLayoutPanel5.Location = New System.Drawing.Point(3, 22)
      Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
      Me.tableLayoutPanel5.RowCount = 1
      Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.tableLayoutPanel5.Size = New System.Drawing.Size(418, 48)
      Me.tableLayoutPanel5.TabIndex = 0
      '
      'NudLength
      '
      Me.NudLength.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.NudLength.Location = New System.Drawing.Point(35, 11)
      Me.NudLength.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
      Me.NudLength.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
      Me.NudLength.Name = "NudLength"
      Me.NudLength.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.NudLength.Size = New System.Drawing.Size(130, 26)
      Me.NudLength.TabIndex = 20
      Me.NudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.NudLength.Value = New Decimal(New Integer() {10, 0, 0, 0})
      '
      'BtPasswordGenerate
      '
      Me.BtPasswordGenerate.Anchor = System.Windows.Forms.AnchorStyles.Left
      Me.BtPasswordGenerate.Location = New System.Drawing.Point(296, 8)
      Me.BtPasswordGenerate.Name = "BtPasswordGenerate"
      Me.BtPasswordGenerate.Size = New System.Drawing.Size(119, 32)
      Me.BtPasswordGenerate.TabIndex = 21
      Me.BtPasswordGenerate.Text = "Generate"
      Me.BtPasswordGenerate.UseVisualStyleBackColor = True
      '
      'PbClear
      '
      Me.PbClear.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.PbClear.Image = Global.AppPasswordGeneratorVb.My.Resources.Resources.clear
      Me.PbClear.Location = New System.Drawing.Point(241, 6)
      Me.PbClear.Name = "PbClear"
      Me.PbClear.Size = New System.Drawing.Size(35, 35)
      Me.PbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PbClear.TabIndex = 2
      Me.PbClear.TabStop = False
      '
      'PbCopy
      '
      Me.PbCopy.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.PbCopy.Image = Global.AppPasswordGeneratorVb.My.Resources.Resources.copy
      Me.PbCopy.Location = New System.Drawing.Point(181, 6)
      Me.PbCopy.Name = "PbCopy"
      Me.PbCopy.Size = New System.Drawing.Size(35, 35)
      Me.PbCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PbCopy.TabIndex = 2
      Me.PbCopy.TabStop = False
      '
      'PlOutput
      '
      Me.PlOutput.Controls.Add(Me.TbOutput)
      Me.PlOutput.Dock = System.Windows.Forms.DockStyle.Fill
      Me.PlOutput.Location = New System.Drawing.Point(3, 288)
      Me.PlOutput.Name = "PlOutput"
      Me.PlOutput.Padding = New System.Windows.Forms.Padding(15)
      Me.PlOutput.Size = New System.Drawing.Size(868, 176)
      Me.PlOutput.TabIndex = 22
      '
      'TbOutput
      '
      Me.TbOutput.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TbOutput.Location = New System.Drawing.Point(15, 15)
      Me.TbOutput.Multiline = True
      Me.TbOutput.Name = "TbOutput"
      Me.TbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.TbOutput.Size = New System.Drawing.Size(838, 146)
      Me.TbOutput.TabIndex = 23
      '
      'LbPasswordStrength
      '
      Me.LbPasswordStrength.Dock = System.Windows.Forms.DockStyle.Fill
      Me.LbPasswordStrength.Location = New System.Drawing.Point(3, 467)
      Me.LbPasswordStrength.Name = "LbPasswordStrength"
      Me.LbPasswordStrength.Size = New System.Drawing.Size(868, 32)
      Me.LbPasswordStrength.TabIndex = 100
      Me.LbPasswordStrength.Text = "[PasswordStrength]"
      Me.LbPasswordStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'FrmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.White
      Me.ClientSize = New System.Drawing.Size(874, 561)
      Me.Controls.Add(Me.ScMain)
      Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.MinimumSize = New System.Drawing.Size(890, 600)
      Me.Name = "FrmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "© PasswordGenerator 2022 created by © exc-jdbi 2022"
      Me.ScMain.Panel1.ResumeLayout(False)
      Me.ScMain.Panel2.ResumeLayout(False)
      CType(Me.ScMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ScMain.ResumeLayout(False)
      Me.TlpTitle.ResumeLayout(False)
      CType(Me.PbTitle, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TlpMain.ResumeLayout(False)
      Me.GbAdditionalOptions.ResumeLayout(False)
      Me.TlpAdditionalOption.ResumeLayout(False)
      Me.TlpAdditionalOption.PerformLayout()
      Me.GbEncoding.ResumeLayout(False)
      Me.tableLayoutPanel2.ResumeLayout(False)
      Me.tableLayoutPanel2.PerformLayout()
      Me.tableLayoutPanel3.ResumeLayout(False)
      Me.GbPasswordVariants.ResumeLayout(False)
      Me.tableLayoutPanel4.ResumeLayout(False)
      Me.tableLayoutPanel4.PerformLayout()
      Me.GbGeneratePassword.ResumeLayout(False)
      Me.tableLayoutPanel5.ResumeLayout(False)
      CType(Me.NudLength, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PbClear, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PbCopy, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PlOutput.ResumeLayout(False)
      Me.PlOutput.PerformLayout()
      Me.ResumeLayout(False)

    End Sub

    Private WithEvents ScMain As SplitContainer
    Private WithEvents TlpTitle As TableLayoutPanel
    Private WithEvents PbTitle As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents TlpMain As TableLayoutPanel
    Private WithEvents GbAdditionalOptions As GroupBox
    Private WithEvents TlpAdditionalOption As TableLayoutPanel
    Private WithEvents CbInternationalSymbols As CheckBox
    Private WithEvents CbNumerics As CheckBox
    Private WithEvents CbSpecialCharacters As CheckBox
    Private WithEvents CbLowers As CheckBox
    Private WithEvents CbUppers As CheckBox
    Private WithEvents GbEncoding As GroupBox
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents CbB64Url As CheckBox
    Private WithEvents CbNone As CheckBox
    Private WithEvents CbHex As CheckBox
    Private WithEvents CbB32 As CheckBox
    Private WithEvents CbB62 As CheckBox
    Private WithEvents CbB64 As CheckBox
    Private WithEvents tableLayoutPanel3 As TableLayoutPanel
    Private WithEvents GbPasswordVariants As GroupBox
    Private WithEvents tableLayoutPanel4 As TableLayoutPanel
    Private WithEvents CbBytes As CheckBox
    Private WithEvents CbLetters As CheckBox
    Private WithEvents GbGeneratePassword As GroupBox
    Private WithEvents tableLayoutPanel5 As TableLayoutPanel
    Private WithEvents NudLength As NumericUpDown
    Private WithEvents BtPasswordGenerate As Button
    Private WithEvents PbClear As PictureBox
    Private WithEvents PbCopy As PictureBox
    Private WithEvents PlOutput As Panel
    Private WithEvents TbOutput As TextBox
    Private WithEvents LbPasswordStrength As Label
  End Class

End Namespace
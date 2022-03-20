namespace exc.jdbi.PasswordGenerator.App;

partial class FrmMain
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
      this.ScMain = new System.Windows.Forms.SplitContainer();
      this.TlpTitle = new System.Windows.Forms.TableLayoutPanel();
      this.PbTitle = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
      this.GbAdditionalOptions = new System.Windows.Forms.GroupBox();
      this.TlpAdditionalOption = new System.Windows.Forms.TableLayoutPanel();
      this.CbInternationalSymbols = new System.Windows.Forms.CheckBox();
      this.CbNumerics = new System.Windows.Forms.CheckBox();
      this.CbSpecialCharacters = new System.Windows.Forms.CheckBox();
      this.CbLowers = new System.Windows.Forms.CheckBox();
      this.CbUppers = new System.Windows.Forms.CheckBox();
      this.GbEncoding = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.CbBase64Url = new System.Windows.Forms.CheckBox();
      this.CbNone = new System.Windows.Forms.CheckBox();
      this.CbHex = new System.Windows.Forms.CheckBox();
      this.CbBase32 = new System.Windows.Forms.CheckBox();
      this.CbBase62 = new System.Windows.Forms.CheckBox();
      this.CbBase64 = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.GbPasswordVariants = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.CbBytes = new System.Windows.Forms.CheckBox();
      this.CbLetters = new System.Windows.Forms.CheckBox();
      this.GbGeneratePassword = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.NudLength = new System.Windows.Forms.NumericUpDown();
      this.BtPasswordGenerate = new System.Windows.Forms.Button();
      this.PbClear = new System.Windows.Forms.PictureBox();
      this.PbCopy = new System.Windows.Forms.PictureBox();
      this.PlOutput = new System.Windows.Forms.Panel();
      this.TbOutput = new System.Windows.Forms.TextBox();
      this.LbPasswordStrength = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ScMain)).BeginInit();
      this.ScMain.Panel1.SuspendLayout();
      this.ScMain.Panel2.SuspendLayout();
      this.ScMain.SuspendLayout();
      this.TlpTitle.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PbTitle)).BeginInit();
      this.TlpMain.SuspendLayout();
      this.GbAdditionalOptions.SuspendLayout();
      this.TlpAdditionalOption.SuspendLayout();
      this.GbEncoding.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.GbPasswordVariants.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.GbGeneratePassword.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NudLength)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PbClear)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PbCopy)).BeginInit();
      this.PlOutput.SuspendLayout();
      this.SuspendLayout();
      // 
      // ScMain
      // 
      this.ScMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ScMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.ScMain.Location = new System.Drawing.Point(0, 0);
      this.ScMain.Margin = new System.Windows.Forms.Padding(4);
      this.ScMain.Name = "ScMain";
      this.ScMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // ScMain.Panel1
      // 
      this.ScMain.Panel1.Controls.Add(this.TlpTitle);
      // 
      // ScMain.Panel2
      // 
      this.ScMain.Panel2.Controls.Add(this.TlpMain);
      this.ScMain.Size = new System.Drawing.Size(874, 561);
      this.ScMain.SplitterDistance = 60;
      this.ScMain.SplitterWidth = 2;
      this.ScMain.TabIndex = 0;
      // 
      // TlpTitle
      // 
      this.TlpTitle.BackColor = System.Drawing.Color.DimGray;
      this.TlpTitle.ColumnCount = 2;
      this.TlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.TlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.TlpTitle.Controls.Add(this.PbTitle, 0, 0);
      this.TlpTitle.Controls.Add(this.label1, 1, 0);
      this.TlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TlpTitle.Location = new System.Drawing.Point(0, 0);
      this.TlpTitle.Name = "TlpTitle";
      this.TlpTitle.RowCount = 1;
      this.TlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpTitle.Size = new System.Drawing.Size(874, 60);
      this.TlpTitle.TabIndex = 0;
      // 
      // PbTitle
      // 
      this.PbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PbTitle.Image = global::AppPasswordGenerator.Properties.Resources.PwKeyPic;
      this.PbTitle.Location = new System.Drawing.Point(3, 3);
      this.PbTitle.Name = "PbTitle";
      this.PbTitle.Size = new System.Drawing.Size(64, 54);
      this.PbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.PbTitle.TabIndex = 0;
      this.PbTitle.TabStop = false;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(557, 4);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
      this.label1.Size = new System.Drawing.Size(314, 51);
      this.label1.TabIndex = 0;
      this.label1.Text = "Password Generator";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // TlpMain
      // 
      this.TlpMain.BackColor = System.Drawing.Color.Transparent;
      this.TlpMain.ColumnCount = 1;
      this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpMain.Controls.Add(this.GbAdditionalOptions, 0, 0);
      this.TlpMain.Controls.Add(this.GbEncoding, 0, 1);
      this.TlpMain.Controls.Add(this.tableLayoutPanel3, 0, 2);
      this.TlpMain.Controls.Add(this.PlOutput, 0, 3);
      this.TlpMain.Controls.Add(this.LbPasswordStrength, 0, 4);
      this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TlpMain.Location = new System.Drawing.Point(0, 0);
      this.TlpMain.Name = "TlpMain";
      this.TlpMain.RowCount = 5;
      this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
      this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.TlpMain.Size = new System.Drawing.Size(874, 499);
      this.TlpMain.TabIndex = 6;
      // 
      // GbAdditionalOptions
      // 
      this.GbAdditionalOptions.Controls.Add(this.TlpAdditionalOption);
      this.GbAdditionalOptions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GbAdditionalOptions.Location = new System.Drawing.Point(6, 3);
      this.GbAdditionalOptions.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
      this.GbAdditionalOptions.Name = "GbAdditionalOptions";
      this.GbAdditionalOptions.Size = new System.Drawing.Size(862, 94);
      this.GbAdditionalOptions.TabIndex = 0;
      this.GbAdditionalOptions.TabStop = false;
      this.GbAdditionalOptions.Text = "Additional Options";
      // 
      // TlpAdditionalOption
      // 
      this.TlpAdditionalOption.ColumnCount = 3;
      this.TlpAdditionalOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
      this.TlpAdditionalOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpAdditionalOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
      this.TlpAdditionalOption.Controls.Add(this.CbInternationalSymbols, 2, 0);
      this.TlpAdditionalOption.Controls.Add(this.CbNumerics, 0, 0);
      this.TlpAdditionalOption.Controls.Add(this.CbSpecialCharacters, 1, 1);
      this.TlpAdditionalOption.Controls.Add(this.CbLowers, 0, 1);
      this.TlpAdditionalOption.Controls.Add(this.CbUppers, 1, 0);
      this.TlpAdditionalOption.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TlpAdditionalOption.Location = new System.Drawing.Point(3, 22);
      this.TlpAdditionalOption.Name = "TlpAdditionalOption";
      this.TlpAdditionalOption.RowCount = 2;
      this.TlpAdditionalOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.TlpAdditionalOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.TlpAdditionalOption.Size = new System.Drawing.Size(856, 69);
      this.TlpAdditionalOption.TabIndex = 0;
      // 
      // CbInternationalSymbols
      // 
      this.CbInternationalSymbols.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.CbInternationalSymbols.AutoSize = true;
      this.CbInternationalSymbols.Location = new System.Drawing.Point(619, 6);
      this.CbInternationalSymbols.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbInternationalSymbols.Name = "CbInternationalSymbols";
      this.CbInternationalSymbols.Size = new System.Drawing.Size(234, 22);
      this.CbInternationalSymbols.TabIndex = 5;
      this.CbInternationalSymbols.Tag = "0";
      this.CbInternationalSymbols.Text = "International Symbols (中国 ...)";
      this.CbInternationalSymbols.UseVisualStyleBackColor = true;
      this.CbInternationalSymbols.Click += new System.EventHandler(this.CheckboxAdditionalOption_Click);
      // 
      // CbNumerics
      // 
      this.CbNumerics.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.CbNumerics.AutoSize = true;
      this.CbNumerics.Checked = true;
      this.CbNumerics.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CbNumerics.Location = new System.Drawing.Point(10, 6);
      this.CbNumerics.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbNumerics.Name = "CbNumerics";
      this.CbNumerics.Size = new System.Drawing.Size(147, 22);
      this.CbNumerics.TabIndex = 1;
      this.CbNumerics.Tag = "0";
      this.CbNumerics.Text = "Numbers (123 ...)";
      this.CbNumerics.UseVisualStyleBackColor = true;
      this.CbNumerics.Click += new System.EventHandler(this.CheckboxAdditionalOption_Click);
      // 
      // CbSpecialCharacters
      // 
      this.CbSpecialCharacters.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.CbSpecialCharacters.Location = new System.Drawing.Point(296, 38);
      this.CbSpecialCharacters.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbSpecialCharacters.Name = "CbSpecialCharacters";
      this.CbSpecialCharacters.Size = new System.Drawing.Size(270, 26);
      this.CbSpecialCharacters.TabIndex = 4;
      this.CbSpecialCharacters.Tag = "0";
      this.CbSpecialCharacters.Text = "Special Characters (@#$% ...)";
      this.CbSpecialCharacters.UseVisualStyleBackColor = true;
      this.CbSpecialCharacters.Click += new System.EventHandler(this.CheckboxAdditionalOption_Click);
      // 
      // CbLowers
      // 
      this.CbLowers.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.CbLowers.AutoSize = true;
      this.CbLowers.Checked = true;
      this.CbLowers.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CbLowers.Location = new System.Drawing.Point(10, 40);
      this.CbLowers.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbLowers.Name = "CbLowers";
      this.CbLowers.Size = new System.Drawing.Size(241, 22);
      this.CbLowers.TabIndex = 2;
      this.CbLowers.Tag = "0";
      this.CbLowers.Text = "Lowercase Characters (abc ...)";
      this.CbLowers.UseVisualStyleBackColor = true;
      this.CbLowers.Click += new System.EventHandler(this.CheckboxAdditionalOption_Click);
      // 
      // CbUppers
      // 
      this.CbUppers.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.CbUppers.Checked = true;
      this.CbUppers.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CbUppers.Location = new System.Drawing.Point(296, 4);
      this.CbUppers.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbUppers.Name = "CbUppers";
      this.CbUppers.Size = new System.Drawing.Size(270, 26);
      this.CbUppers.TabIndex = 3;
      this.CbUppers.Tag = "0";
      this.CbUppers.Text = "Uppercase Characters (ABC ...)";
      this.CbUppers.UseVisualStyleBackColor = true;
      this.CbUppers.Click += new System.EventHandler(this.CheckboxAdditionalOption_Click);
      // 
      // GbEncoding
      // 
      this.GbEncoding.Controls.Add(this.tableLayoutPanel2);
      this.GbEncoding.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GbEncoding.Location = new System.Drawing.Point(6, 103);
      this.GbEncoding.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
      this.GbEncoding.Name = "GbEncoding";
      this.GbEncoding.Size = new System.Drawing.Size(862, 94);
      this.GbEncoding.TabIndex = 7;
      this.GbEncoding.TabStop = false;
      this.GbEncoding.Text = "Encoding";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
      this.tableLayoutPanel2.Controls.Add(this.CbBase64Url, 2, 1);
      this.tableLayoutPanel2.Controls.Add(this.CbNone, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.CbHex, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.CbBase32, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.CbBase62, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.CbBase64, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(856, 69);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // CbBase64Url
      // 
      this.CbBase64Url.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.CbBase64Url.Location = new System.Drawing.Point(741, 40);
      this.CbBase64Url.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbBase64Url.Name = "CbBase64Url";
      this.CbBase64Url.Size = new System.Drawing.Size(112, 22);
      this.CbBase64Url.TabIndex = 13;
      this.CbBase64Url.Tag = "1";
      this.CbBase64Url.Text = "Base 64 Url";
      this.CbBase64Url.UseVisualStyleBackColor = true;
      this.CbBase64Url.Click += new System.EventHandler(this.CheckboxEncoding_Click);
      // 
      // CbNone
      // 
      this.CbNone.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.CbNone.AutoSize = true;
      this.CbNone.Location = new System.Drawing.Point(10, 6);
      this.CbNone.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbNone.Name = "CbNone";
      this.CbNone.Size = new System.Drawing.Size(64, 22);
      this.CbNone.TabIndex = 8;
      this.CbNone.Tag = "1";
      this.CbNone.Text = "None";
      this.CbNone.UseVisualStyleBackColor = true;
      this.CbNone.Click += new System.EventHandler(this.CheckboxEncoding_Click);
      // 
      // CbHex
      // 
      this.CbHex.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.CbHex.AutoSize = true;
      this.CbHex.Checked = true;
      this.CbHex.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CbHex.Location = new System.Drawing.Point(10, 40);
      this.CbHex.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbHex.Name = "CbHex";
      this.CbHex.Size = new System.Drawing.Size(54, 22);
      this.CbHex.TabIndex = 9;
      this.CbHex.Tag = "1";
      this.CbHex.Text = "Hex";
      this.CbHex.UseVisualStyleBackColor = true;
      this.CbHex.Click += new System.EventHandler(this.CheckboxEncoding_Click);
      // 
      // CbBase32
      // 
      this.CbBase32.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.CbBase32.Location = new System.Drawing.Point(376, 6);
      this.CbBase32.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbBase32.Name = "CbBase32";
      this.CbBase32.Size = new System.Drawing.Size(110, 22);
      this.CbBase32.TabIndex = 10;
      this.CbBase32.Tag = "1";
      this.CbBase32.Text = "Base 32";
      this.CbBase32.UseVisualStyleBackColor = true;
      this.CbBase32.Click += new System.EventHandler(this.CheckboxEncoding_Click);
      // 
      // CbBase62
      // 
      this.CbBase62.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.CbBase62.Location = new System.Drawing.Point(376, 40);
      this.CbBase62.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbBase62.Name = "CbBase62";
      this.CbBase62.Size = new System.Drawing.Size(110, 22);
      this.CbBase62.TabIndex = 11;
      this.CbBase62.Tag = "1";
      this.CbBase62.Text = "Base 62";
      this.CbBase62.UseVisualStyleBackColor = true;
      this.CbBase62.Click += new System.EventHandler(this.CheckboxEncoding_Click);
      // 
      // CbBase64
      // 
      this.CbBase64.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.CbBase64.Location = new System.Drawing.Point(741, 6);
      this.CbBase64.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbBase64.Name = "CbBase64";
      this.CbBase64.Size = new System.Drawing.Size(112, 22);
      this.CbBase64.TabIndex = 12;
      this.CbBase64.Tag = "1";
      this.CbBase64.Text = "Base 64";
      this.CbBase64.UseVisualStyleBackColor = true;
      this.CbBase64.Click += new System.EventHandler(this.CheckboxEncoding_Click);
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 3;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430F));
      this.tableLayoutPanel3.Controls.Add(this.GbPasswordVariants, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.GbGeneratePassword, 2, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 203);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(868, 79);
      this.tableLayoutPanel3.TabIndex = 18;
      // 
      // GbPasswordVariants
      // 
      this.GbPasswordVariants.Controls.Add(this.tableLayoutPanel4);
      this.GbPasswordVariants.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GbPasswordVariants.Location = new System.Drawing.Point(3, 3);
      this.GbPasswordVariants.Name = "GbPasswordVariants";
      this.GbPasswordVariants.Size = new System.Drawing.Size(424, 73);
      this.GbPasswordVariants.TabIndex = 15;
      this.GbPasswordVariants.TabStop = false;
      this.GbPasswordVariants.Text = "Password Variants";
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Controls.Add(this.CbBytes, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.CbLetters, 0, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 22);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(418, 48);
      this.tableLayoutPanel4.TabIndex = 0;
      // 
      // CbBytes
      // 
      this.CbBytes.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.CbBytes.AutoSize = true;
      this.CbBytes.Location = new System.Drawing.Point(286, 13);
      this.CbBytes.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbBytes.Name = "CbBytes";
      this.CbBytes.Size = new System.Drawing.Size(129, 22);
      this.CbBytes.TabIndex = 17;
      this.CbBytes.Tag = "2";
      this.CbBytes.Text = "Bytes (0 - 255)";
      this.CbBytes.UseVisualStyleBackColor = true;
      this.CbBytes.Click += new System.EventHandler(this.CheckboxVariant_Click);
      // 
      // CbLetters
      // 
      this.CbLetters.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.CbLetters.AutoSize = true;
      this.CbLetters.Checked = true;
      this.CbLetters.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CbLetters.Location = new System.Drawing.Point(10, 13);
      this.CbLetters.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.CbLetters.Name = "CbLetters";
      this.CbLetters.Size = new System.Drawing.Size(145, 22);
      this.CbLetters.TabIndex = 16;
      this.CbLetters.Tag = "2";
      this.CbLetters.Text = "Letters (AaBb ...)";
      this.CbLetters.UseVisualStyleBackColor = true;
      this.CbLetters.Click += new System.EventHandler(this.CheckboxVariant_Click);
      // 
      // GbGeneratePassword
      // 
      this.GbGeneratePassword.Controls.Add(this.tableLayoutPanel5);
      this.GbGeneratePassword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GbGeneratePassword.Location = new System.Drawing.Point(441, 3);
      this.GbGeneratePassword.Name = "GbGeneratePassword";
      this.GbGeneratePassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.GbGeneratePassword.Size = new System.Drawing.Size(424, 73);
      this.GbGeneratePassword.TabIndex = 19;
      this.GbGeneratePassword.TabStop = false;
      this.GbGeneratePassword.Text = "Generate Password";
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.ColumnCount = 4;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Controls.Add(this.NudLength, 3, 0);
      this.tableLayoutPanel5.Controls.Add(this.BtPasswordGenerate, 0, 0);
      this.tableLayoutPanel5.Controls.Add(this.PbClear, 1, 0);
      this.tableLayoutPanel5.Controls.Add(this.PbCopy, 2, 0);
      this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 22);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 1;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(418, 48);
      this.tableLayoutPanel5.TabIndex = 0;
      // 
      // NudLength
      // 
      this.NudLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.NudLength.Location = new System.Drawing.Point(35, 11);
      this.NudLength.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
      this.NudLength.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.NudLength.Name = "NudLength";
      this.NudLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.NudLength.Size = new System.Drawing.Size(130, 26);
      this.NudLength.TabIndex = 20;
      this.NudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.NudLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // BtPasswordGenerate
      // 
      this.BtPasswordGenerate.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.BtPasswordGenerate.Location = new System.Drawing.Point(296, 8);
      this.BtPasswordGenerate.Name = "BtPasswordGenerate";
      this.BtPasswordGenerate.Size = new System.Drawing.Size(119, 32);
      this.BtPasswordGenerate.TabIndex = 21;
      this.BtPasswordGenerate.Text = "Generate";
      this.BtPasswordGenerate.UseVisualStyleBackColor = true;
      this.BtPasswordGenerate.Click += new System.EventHandler(this.BtGenerate_Click);
      // 
      // PbClear
      // 
      this.PbClear.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.PbClear.Image = global::AppPasswordGenerator.Properties.Resources.clear;
      this.PbClear.Location = new System.Drawing.Point(241, 6);
      this.PbClear.Name = "PbClear";
      this.PbClear.Size = new System.Drawing.Size(35, 35);
      this.PbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.PbClear.TabIndex = 2;
      this.PbClear.TabStop = false;
      this.PbClear.Click += new System.EventHandler(this.PictureBox_Click);
      // 
      // PbCopy
      // 
      this.PbCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.PbCopy.Image = global::AppPasswordGenerator.Properties.Resources.copy;
      this.PbCopy.Location = new System.Drawing.Point(181, 6);
      this.PbCopy.Name = "PbCopy";
      this.PbCopy.Size = new System.Drawing.Size(35, 35);
      this.PbCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.PbCopy.TabIndex = 2;
      this.PbCopy.TabStop = false;
      this.PbCopy.Click += new System.EventHandler(this.PictureBox_Click);
      // 
      // PlOutput
      // 
      this.PlOutput.Controls.Add(this.TbOutput);
      this.PlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PlOutput.Location = new System.Drawing.Point(3, 288);
      this.PlOutput.Name = "PlOutput";
      this.PlOutput.Padding = new System.Windows.Forms.Padding(15);
      this.PlOutput.Size = new System.Drawing.Size(868, 176);
      this.PlOutput.TabIndex = 22;
      // 
      // TbOutput
      // 
      this.TbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TbOutput.Location = new System.Drawing.Point(15, 15);
      this.TbOutput.Multiline = true;
      this.TbOutput.Name = "TbOutput";
      this.TbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.TbOutput.Size = new System.Drawing.Size(838, 146);
      this.TbOutput.TabIndex = 23;
      // 
      // LbPasswordStrength
      // 
      this.LbPasswordStrength.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LbPasswordStrength.Location = new System.Drawing.Point(3, 467);
      this.LbPasswordStrength.Name = "LbPasswordStrength";
      this.LbPasswordStrength.Size = new System.Drawing.Size(868, 32);
      this.LbPasswordStrength.TabIndex = 100;
      this.LbPasswordStrength.Text = "[PasswordStrength]";
      this.LbPasswordStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(874, 561);
      this.Controls.Add(this.ScMain);
      this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MinimumSize = new System.Drawing.Size(890, 600);
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "© PasswordGenerator 2022 created by © exc-jdbi 2022";
      this.ScMain.Panel1.ResumeLayout(false);
      this.ScMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ScMain)).EndInit();
      this.ScMain.ResumeLayout(false);
      this.TlpTitle.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PbTitle)).EndInit();
      this.TlpMain.ResumeLayout(false);
      this.GbAdditionalOptions.ResumeLayout(false);
      this.TlpAdditionalOption.ResumeLayout(false);
      this.TlpAdditionalOption.PerformLayout();
      this.GbEncoding.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.GbPasswordVariants.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.GbGeneratePassword.ResumeLayout(false);
      this.tableLayoutPanel5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.NudLength)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PbClear)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PbCopy)).EndInit();
      this.PlOutput.ResumeLayout(false);
      this.PlOutput.PerformLayout();
      this.ResumeLayout(false);

  }

  #endregion

  private SplitContainer ScMain;
  private TableLayoutPanel TlpTitle;
  private PictureBox PbTitle;
  private Label label1;
  private TableLayoutPanel TlpMain;
  private GroupBox GbAdditionalOptions;
  private GroupBox GbEncoding;
  private GroupBox GbPasswordVariants;
  private CheckBox CbLowers;
  private CheckBox CbNumerics;
  private CheckBox CbSpecialCharacters;
  private CheckBox CbUppers;
  private CheckBox CbInternationalSymbols;
  private TableLayoutPanel TlpAdditionalOption;
  private TableLayoutPanel tableLayoutPanel2;
  private CheckBox CbNone;
  private CheckBox CbHex;
  private CheckBox CbBase32;
  private CheckBox CbBase62;
  private CheckBox CbBase64;
  private CheckBox CbBase64Url;
  private TableLayoutPanel tableLayoutPanel3;
  private TableLayoutPanel tableLayoutPanel4;
  private CheckBox CbLetters;
  private CheckBox CbBytes;
  private GroupBox GbGeneratePassword;
  private TableLayoutPanel tableLayoutPanel5;
  private NumericUpDown NudLength;
  private Button BtPasswordGenerate;
  private PictureBox PbClear;
  private PictureBox PbCopy;
  private Panel PlOutput;
  private TextBox TbOutput;
  private Label LbPasswordStrength;
}



namespace exc.jdbi.PasswordGenerator.App;
using exc.jdbi.Converts;
using exc.jdbi.PasswordCheckers;
using exc.jdbi.PasswordGenerators;
using PwGenerator = PasswordGenerators.PasswordGenerator;
public partial class FrmMain : Form
{
  private readonly Color DefForeColor = SystemColors.ControlText;
  public FrmMain()
  {
    this.InitializeComponent();
  }

  private void CheckboxAdditionalOption_Click(object sender, EventArgs e)
  {
    var cb = (CheckBox)sender ;
    if (cb is null) return;
    this.SetBasicMask();
  }

  private void CheckboxEncoding_Click(object sender, EventArgs e)
  {
    this.SetBasicMask();
    switch (true)
    {
      case object _ when ReferenceEquals(sender, this.CbNone):
      {
        this.CheckBoxHandling(sender);
        break;
      }

      case object _ when ReferenceEquals(sender, this.CbHex):
      {
        this.CheckBoxHandling(sender);
        break;
      }

      case object _ when ReferenceEquals(sender, this.CbBase32):
      {
        this.CheckBoxHandling(sender);
        break;
      }

      case object _ when ReferenceEquals(sender, this.CbBase62):
      {
        this.CheckBoxHandling(sender);
        break;
      }

      case object _ when ReferenceEquals(sender, this.CbBase64):
      {
        this.CheckBoxHandling(sender);
        break;
      }

      case object _ when ReferenceEquals(sender, this.CbBase64Url):
      {
        this.CheckBoxHandling(sender);
        break;
      }
    }
  }

  private void CheckboxVariant_Click(object sender, EventArgs e)
  {
    this.SetBasicMask();
    switch (true)
    {
      case object _ when ReferenceEquals(sender, this.CbLetters):
      {
        this.CheckBoxHandling(sender);
        this.SetEnableComboBox(true);
        break;
      }
      case object _ when ReferenceEquals(sender, this.CbBytes):
      {
        this.CheckBoxHandling(sender);
        this.SetEnableComboBox(false);
        break;
      }
    }
  }

  private void BtGenerate_Click(object sender, EventArgs e)
  {
    this.TbOutput.Clear();
    if (this.CheckAllParameter())
    {
      this.GeneratePassword();
      this.CalcPasswordStrength();
    }
  }

  private void PictureBox_Click(object sender, EventArgs e)
  {
    switch (true)
    {
      case object _ when ReferenceEquals(sender, this.PbCopy):
      {
        if (!string.IsNullOrEmpty(this.TbOutput.Text))
          Clipboard.SetText(this.TbOutput.Text);
        break;
      }
      case object _ when ReferenceEquals(sender, this.PbClear):
      {
        this.TbOutput.Clear();
        this.SetBasicMask();
        break;
      }
    }
  }

  private void SetBasicMask()
  {
    this.TbOutput.Clear();
    this.PlOutput.BackColor = Color.Transparent;
    this.LbPasswordStrength.Text = "[PasswordStrength]";
    this.LbPasswordStrength.BackColor = Color.Transparent;
  }

  private void SetEnableComboBox(bool _enable)
  => this.GbAdditionalOptions.Enabled = _enable;

  private void CalcPasswordStrength()
  {
    PasswordStrength pwstrength;
    var pwinfo = this.ToPasswordInfo();
    if (pwinfo is null) return;
    if (this.CbLetters.Checked)
    {
      var originalpw = PwGenerator.DecodePassword(this.TbOutput.Text, pwinfo.StringConvertInfo);
      pwstrength = PwGenerator.PasswordStrengthChecker(originalpw);
    }
    else
    {
      var originalpw = PwGenerator.DecodePasswordToBytes(this.TbOutput.Text, pwinfo.StringConvertInfo);
      pwstrength = PwGenerator.PasswordStrengthChecker(originalpw);
    }

    {
      var withBlock = this.LbPasswordStrength;
      withBlock.BackColor = Color.Transparent;
      this.PlOutput.BackColor = Color.Transparent;
      this.LbPasswordStrength.ForeColor = this.DefForeColor;
      withBlock.Text = $"PasswordStrength = {pwstrength}";
      switch (pwstrength)
      {
        case var @case when @case == PasswordStrength.Unacceptable:
        {
          withBlock.BackColor = Color.Red;
          this.PlOutput.BackColor = Color.Red;
          break;
        }

        case var @case when @case == PasswordStrength.Weak:
        {
          withBlock.BackColor = Color.PeachPuff;
          this.PlOutput.BackColor = Color.PeachPuff;
          break;
        }

        case var @case when @case == PasswordStrength.Ok:
        {
          withBlock.BackColor = Color.Yellow;
          this.PlOutput.BackColor = Color.Yellow;
          break;
        }

        case var @case when @case == PasswordStrength.Strong:
        {
          withBlock.BackColor = Color.LightGreen;
          this.PlOutput.BackColor = Color.LightGreen;
          break;
        }

        case var @case when @case == PasswordStrength.Secure:
        {
          withBlock.BackColor = Color.Green;
          this.PlOutput.BackColor = Color.Green;
          this.LbPasswordStrength.ForeColor = Color.White;
          break;
        }
      }
    }
  }

  private void GeneratePassword()
  {
    this.TbOutput.Clear();
    PasswordInfo? pwinfo;
    if (this.CbLetters.Checked)
    {
      pwinfo = this.ToPasswordInfo();
      if (pwinfo is not null)
        this.TbOutput.Text = PwGenerator.PasswordString(pwinfo);
    }
    else
    {
      //Byte-Variant
      var bytes = PwGenerator.PasswordBytes((int)this.NudLength.Value);
      var cbox = this.ToCheckBoxGroup(1);
      if (cbox is null) return;
      StringConvertInfo stringconvertinfo;
      for (int i = 0; i < cbox.Length; i++)
      {
        if (cbox[i].Checked)
        {
          //Default Byte-Variant is hex.
          // If 'none' selected, then set 'hex'.
          if (i == 0)
          {
            cbox[i].Checked = false;
            i += 1;
            cbox[i].Checked = true;
          }

          stringconvertinfo = (StringConvertInfo)i;
          this.TbOutput.Text = PwGenerator.EncodePassword(bytes, stringconvertinfo);
          break;
        }
      }
    }
  }

  private PasswordInfo? ToPasswordInfo()
  {
    var pwinfo = new PasswordInfo
    {
      Length = (int)this.NudLength.Value,
      NumericLetters = this.CbNumerics.Checked,
      UppercaseCharacters = this.CbUppers.Checked,
      LowercaseCharacters = this.CbLowers.Checked,
      SpecialCharacters = this.CbSpecialCharacters.Checked,
      InternationalSymbols = this.CbInternationalSymbols.Checked
    };
    var cbox = this.ToCheckBoxGroup(1);
    for (int i = 0; i < cbox.Length; i++)
    {
      if (cbox[i].Checked)
      {
        pwinfo.StringConvertInfo = (StringConvertInfo)i;
        break;
      }
    }
    return pwinfo;
  }

  private bool CheckAllParameter()
  {
    this.GbEncoding.ForeColor = Color.Red;
    this.GbPasswordVariants.ForeColor = Color.Red;
    this.GbAdditionalOptions.ForeColor = Color.Red;
    if (this.CheckCheckboxes())
    {
      this.GbGeneratePassword.ForeColor = Color.Red;
      if (this.NudLength.Value >= 10 && this.NudLength.Value <= 1024)
      {
        this.GbGeneratePassword.ForeColor = this.DefForeColor;
        return true;
      }
    } 
    return false;
  }

  private bool CheckCheckboxes()
  {
    var cbcnt = new int[3];
    for (int i = 0; i <= 2; i++)
    {
      var cbgroup = this.ToCheckBoxGroup(i);
      if (cbgroup is null) return false;
      foreach (var cb in cbgroup)
      {
        if (cb.Checked)
        {
          if (i == 0)
            this.GbAdditionalOptions.ForeColor = this.DefForeColor;
          else if (i == 1)
            this.GbEncoding.ForeColor = this.DefForeColor;
          else if (i == 2)
            this.GbPasswordVariants.ForeColor = this.DefForeColor;
          cbcnt[i] = 1;
          break;
        }
      }
    }  
    return cbcnt.Sum() == 3;
  }

  private void CheckBoxHandling(object sender)
  {
    // Eventuell im Designer die Property 'Tag' und 'Checked'
    // der CbHex, CbLetter, CbBytes ganz nach oben setzen, damit 
    // beim Start CbNummic, CbUpper, CbLower Checked = true sind.

    var cb = this.ToCheckBoxGroup(sender);
    if (cb is null) return;
    this.ReSetHandleCheckbox(cb, false);
    Array.ForEach(cb, c => c.Checked = false);
    CheckBox cbox = (CheckBox)sender;
    cbox.Checked = true;
    this.ReSetHandleCheckbox(cb, true);
  }

  private void ReSetHandleCheckbox(CheckBox[] cbox, bool _set)
  {
    if (cbox is null)
      return;
    foreach (var cb in cbox)
    {
      cb.Enabled = _set;
      int cbtag = Convert.ToInt32(cb.Tag);
      if (_set)
        cb.Click += this.ToCbGroupEvent(cbtag);
      else cb.Click -= this.ToCbGroupEvent(cbtag);
    }
  }

  private EventHandler? ToCbGroupEvent(int cbtagnumber)
  {
#pragma warning disable CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
    return cbtagnumber switch
    {
      0 => this.CheckboxAdditionalOption_Click,
      1 => this.CheckboxEncoding_Click,
      2 => this.CheckboxVariant_Click,
      _ => throw new Exception(),
    };
#pragma warning restore CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
  }

  private CheckBox[]? ToCheckBoxGroup(object sender)
  {
    int cbtagnumber = Convert.ToInt32(((CheckBox)sender).Tag);
    return this.ToCheckBoxGroup(cbtagnumber);
  }

  private CheckBox[] ToCheckBoxGroup(int checkboxtagnumber)
  {
    return checkboxtagnumber switch
    {
      0 => new CheckBox[] { this.CbNumerics, this.CbLowers, this.CbUppers, this.CbSpecialCharacters, this.CbInternationalSymbols },
      1 => new CheckBox[] { this.CbNone, this.CbHex, this.CbBase32, this.CbBase62, this.CbBase64, this.CbBase64Url },
      2 => new CheckBox[] { this.CbLetters, this.CbBytes },
      _ => Array.Empty<CheckBox>(),
    };
  }
   
}

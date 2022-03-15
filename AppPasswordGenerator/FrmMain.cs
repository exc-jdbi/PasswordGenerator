

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
  private void CheckboxEncoding_CheckedChanged(object sender, EventArgs e)
  {
    switch (true)
    {
      case object _ when object.ReferenceEquals(sender, this.CbNone):
        {
          CheckBoxHandling(sender);
          break;
        }

      case object _ when object.ReferenceEquals(sender, this.CbHex):
        {
          CheckBoxHandling(sender);
          break;
        }

      case object _ when object.ReferenceEquals(sender, this.CbB32):
        {
          CheckBoxHandling(sender);
          break;
        }

      case object _ when object.ReferenceEquals(sender, this.CbB62):
        {
          CheckBoxHandling(sender);
          break;
        }

      case object _ when object.ReferenceEquals(sender, this.CbB64):
        {
          CheckBoxHandling(sender);
          break;
        }

      case object _ when object.ReferenceEquals(sender, this.CbB64Url):
        {
          CheckBoxHandling(sender);
          break;
        }
    }
  }
  private void CheckboxVariant_CheckedChanged(object sender, EventArgs e)
  {
    switch (true)
    {
      case object _ when object.ReferenceEquals(sender, this.CbLetters):
        {
          CheckBoxHandling(sender);
          SetEnableComboBox(true);
          break;
        }

      case object _ when object.ReferenceEquals(sender, this.CbBytes):
        {
          CheckBoxHandling(sender);
          SetEnableComboBox(false);
          break;
        }
    }
  }

  private void BtGenerate_Click(object sender, EventArgs e)
  {
    this.TbOutput.Clear();
    if (CheckAllParameter())
    {
      GeneratePassword();
      CalcPasswordStrength();
    }
  }

  private void PictureBox_Click(object sender, EventArgs e)
  {
    switch (true)
    {
      case object _ when object.ReferenceEquals(sender, this.PbCopy):
        {
          if (!string.IsNullOrEmpty(this.TbOutput.Text))
            Clipboard.SetText(this.TbOutput.Text);
          break;
        }
      case object _ when object.ReferenceEquals(sender, this.PbClear):
        {
          this.TbOutput.Clear();
          break;
        }
    }
  }

  private void SetEnableComboBox(bool _enable)
  {
    //var addopt = ToCheckBoxGroup(0);
    //foreach (var g in addopt)
    //  g.Enabled = _enable;
    this.GbAdditionalOptions.Enabled = _enable;
  }

  private void CalcPasswordStrength()
  {
    PasswordStrength pwstrength;
    var pwinfo = ToPasswordInfo();
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
      this.LbPasswordStrength.ForeColor = DefForeColor;
      withBlock.Text = $"PasswordStrength = {pwstrength}";
      switch (pwstrength)
      {
        case var @case when @case == PasswordStrength.Unacceptable:
          {
            withBlock.BackColor = Color.Red;
            this.PlOutput.BackColor = Color.Red;
            break;
          }

        case var case1 when case1 == PasswordStrength.Weak:
          {
            withBlock.BackColor = Color.PeachPuff;
            this.PlOutput.BackColor = Color.PeachPuff;
            break;
          }

        case var case2 when case2 == PasswordStrength.Ok:
          {
            withBlock.BackColor = Color.Yellow;
            this.PlOutput.BackColor = Color.Yellow;
            break;
          }

        case var case3 when case3 == PasswordStrength.Strong:
          {
            withBlock.BackColor = Color.LightGreen;
            this.PlOutput.BackColor = Color.LightGreen;
            break;
          }

        case var case4 when case4 == PasswordStrength.Secure:
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
    PasswordInfo pwinfo;
    if (this.CbLetters.Checked)
    {
      pwinfo = ToPasswordInfo();
      this.TbOutput.Text = PwGenerator.PasswordString(pwinfo);
    }
    else
    {
      var bytes = PwGenerator.PasswordBytes((int)this.NudLength.Value);
      var cbox = ToCheckBoxGroup(1);
      StringConvertInfo stringconvertinfo;
      for (int i = 0, loopTo = cbox.Length - 1; i <= loopTo; i++)
      {
        if (cbox[i].Checked)
        {
          // If 'none' selected, then set 'hex'.
          if (i == 0)
          {
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

  private PasswordInfo ToPasswordInfo()
  {
    var pwinfo = new PasswordInfo();
    pwinfo.Length = (int)this.NudLength.Value;
    pwinfo.NumericLetters = this.CbNumerics.Checked;
    pwinfo.UppercaseCharacters = this.CbUppers.Checked;
    pwinfo.LowercaseCharacters = this.CbLowers.Checked;
    pwinfo.SpecialCharacters = this.CbSpecialCharacters.Checked;
    pwinfo.InternationalSymbols = this.CbInternationalSymbols.Checked;
    var cbox = ToCheckBoxGroup(1);
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
    if (CheckCheckboxes())
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
      var cbgroup = ToCheckBoxGroup(i);
      foreach (var cb in cbgroup)
      {
        if (cb.Checked)
        {
          if (i == 0)
          {
            this.GbAdditionalOptions.ForeColor = this.DefForeColor;
          }
          else if (i == 1)
          {
            this.GbEncoding.ForeColor = this.DefForeColor;
          }
          else if (i == 2)
          {
            this.GbPasswordVariants.ForeColor = this.DefForeColor;
          }

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

    var cb = ToCheckBoxGroup(sender);
    ReSetHandleCheckbox(cb, false);
    ResetCheckedCheckbox(cb, false);
    CheckBox cbox = (CheckBox)sender;
    cbox.Checked = true;
    ReSetHandleCheckbox(cb, true);
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
      {
        if (cbtag == 0)
        {
        }
        else if (cbtag == 1)
        {
          cb.CheckedChanged += this.CheckboxEncoding_CheckedChanged;
        }
        else
        {
          cb.CheckedChanged += this.CheckboxVariant_CheckedChanged;
        }
      }
      else if (cbtag == 0)
      {
      }
      else if (cbtag == 1)
      {
        cb.CheckedChanged -= this.CheckboxEncoding_CheckedChanged;
      }
      else
      {
        cb.CheckedChanged -= this.CheckboxVariant_CheckedChanged;
      }
    }
  }

  private static void ResetCheckedCheckbox(CheckBox[] cbox, bool _set)
  {
    if (cbox is null)
      return;
    foreach (var cb in cbox)
      cb.Checked = _set;
  }

  private CheckBox[] ToCheckBoxGroup(object sender)
  {
    int cbnumber = Convert.ToInt32(((CheckBox)sender).Tag);
    return ToCheckBoxGroup(cbnumber);
  }

  private CheckBox[] ToCheckBoxGroup(int checkboxtagnumber)
  {
    switch (checkboxtagnumber)
    {
      case 0:
        {
          return new CheckBox[] { this.CbNumerics, this.CbLowers, this.CbUppers, this.CbSpecialCharacters, this.CbInternationalSymbols };
        }

      case 1:
        {
          return new CheckBox[] { this.CbNone, this.CbHex, this.CbB32, this.CbB62, this.CbB64, this.CbB64Url };
        }

      case 2:
        {
          return new CheckBox[] { this.CbLetters, this.CbBytes };
        }
    }

    return Array.Empty<CheckBox>();
  }
   
}

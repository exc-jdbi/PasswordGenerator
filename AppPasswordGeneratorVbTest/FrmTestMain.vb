Option Strict On
Option Explicit On
Imports exc.jdbi.Converts
Imports exc.jdbi.PasswordCheckers
Imports exc.jdbi.PasswordGenerators
Imports PwGenerator = exc.jdbi.PasswordGenerators.PasswordGenerator

Namespace exc.jdbi.GeneratorPassword.App.TestVb
  Public Class FrmTestMain
    Private ReadOnly DefForeColor As Color = SystemColors.ControlText
    Private Sub CheckboxEncoding_CheckedChanged(sender As Object, e As EventArgs) _
    Handles CbHex.CheckedChanged, CbB32.CheckedChanged, CbB62.CheckedChanged,
    CbB64.CheckedChanged, CbB64Url.CheckedChanged, CbNone.CheckedChanged
      Select Case True
        Case sender Is Me.CbNone : Me.CheckBoxHandling(sender)
        Case sender Is Me.CbHex : Me.CheckBoxHandling(sender)
        Case sender Is Me.CbB32 : Me.CheckBoxHandling(sender)
        Case sender Is Me.CbB62 : Me.CheckBoxHandling(sender)
        Case sender Is Me.CbB64 : Me.CheckBoxHandling(sender)
        Case sender Is Me.CbB64Url : Me.CheckBoxHandling(sender)
      End Select
    End Sub

    Private Sub CheckboxVariant_CheckedChanged(sender As Object, e As EventArgs) _
    Handles CbLetters.CheckedChanged, CbBytes.CheckedChanged
      Select Case True
        Case sender Is Me.CbLetters
          Me.CheckBoxHandling(sender)
          Me.SetEnableComboBox(True)
        Case sender Is Me.CbBytes
          Me.CheckBoxHandling(sender)
          Me.SetEnableComboBox(False)
      End Select
    End Sub

    Private Sub NudLength_ValueChanged(sender As Object, e As EventArgs) Handles NudLength.ValueChanged
      Dim nudvalue = DirectCast(sender, NumericUpDown).Value
      Me.TbLength.Enabled = False
      RemoveHandler Me.TbLength.Scroll, AddressOf Me.TbLength_Scroll
      Me.TbLength.Value = Convert.ToInt32(nudvalue)
      AddHandler Me.TbLength.Scroll, AddressOf Me.TbLength_Scroll
      Me.TbLength.Enabled = True
    End Sub

    Private Sub TbLength_Scroll(sender As Object, e As EventArgs) Handles TbLength.Scroll
      Dim tbvalue = DirectCast(sender, TrackBar).Value
      Me.NudLength.Enabled = False
      RemoveHandler Me.NudLength.ValueChanged, AddressOf Me.NudLength_ValueChanged
      Me.NudLength.Value = tbvalue
      AddHandler Me.NudLength.ValueChanged, AddressOf Me.NudLength_ValueChanged
      Me.NudLength.Enabled = True
    End Sub

    Private Sub BtGenerate_Click(sender As Object, e As EventArgs) Handles BtGenerate.Click
      Me.TbOutput.Clear()
      If Me.CheckAllParameter() Then
        Me.GeneratePassword()
        Me.CalcPasswordStrength()
      End If
    End Sub

    Private Sub SetEnableComboBox(_enable As Boolean)
      Dim groupvariant = Me.ToCheckBoxGroup(0)
      For Each g In groupvariant
        g.Enabled = _enable
      Next
    End Sub

    Private Sub CalcPasswordStrength()
      Dim pwstrength As PasswordStrength
      Dim pwinfo = Me.ToPasswordInfo()
      If Me.CbLetters.Checked Then
        Dim originalpw = PwGenerator.DecodePassword(Me.TbOutput.Text, pwinfo.StringConvertInfo)
        pwstrength = PwGenerator.PasswordStrengthChecker(originalpw)
      Else
        Dim originalpw = PwGenerator.DecodePasswordToBytes(Me.TbOutput.Text, pwinfo.StringConvertInfo)
        pwstrength = PwGenerator.PasswordStrengthChecker(originalpw)
      End If
      With Me.TsslPasswordStrength
        .BackColor = Color.Red
        .Text = $"PasswordStrength = {pwstrength}"
        Select Case pwstrength
          Case PasswordStrength.Unacceptable : .BackColor = Color.Red
          Case PasswordStrength.Weak : .BackColor = Color.PeachPuff
          Case PasswordStrength.Ok : .BackColor = Color.Yellow
          Case PasswordStrength.Strong : .BackColor = Color.LightGreen
          Case PasswordStrength.Secure : .BackColor = Color.Green
        End Select
      End With
    End Sub

    Private Sub GeneratePassword()
      Me.TbOutput.Clear()
      Dim pwinfo As PasswordInfo
      If Me.CbLetters.Checked Then
        pwinfo = Me.ToPasswordInfo()
        Me.TbOutput.Text = PwGenerator.PasswordString(pwinfo)
      Else
        Dim bytes = PwGenerator.PasswordBytes(Me.TbLength.Value)
        Dim cbox = Me.ToCheckBoxGroup(1)
        Dim stringconvertinfo As StringConvertInfo
        For i = 0 To cbox.Length - 1
          If cbox(i).Checked Then
            ' If 'none' selected, then set 'hex'.
            If i = 0 Then i += 1 : cbox(i).Checked = True
            stringconvertinfo = DirectCast(i, StringConvertInfo)
            Me.TbOutput.Text = PwGenerator.EncodePassword(bytes, stringconvertinfo)
            Exit For
          End If
        Next
      End If
    End Sub

    Private Function ToPasswordInfo() As PasswordInfo
      Dim pwinfo As New PasswordInfo
      With pwinfo
        .Length = Me.TbLength.Value
        .NumericLetters = Me.CbNumerics.Checked
        .UppercaseCharacters = Me.CbUppers.Checked
        .LowercaseCharacters = Me.CbLowers.Checked
        .SpecialCharacters = Me.CbSpecialCharacters.Checked
        .InternationalSymbols = Me.CbInternationalSymbols.Checked
        Dim cbox = Me.ToCheckBoxGroup(1)
        For i = 0 To cbox.Length - 1
          If cbox(i).Checked Then
            .StringConvertInfo = DirectCast(i, StringConvertInfo)
            Exit For
          End If
        Next

      End With
      Return pwinfo
    End Function

    Private Function CheckAllParameter() As Boolean
      Me.LbEncoding.ForeColor = Color.Red
      Me.LbPwVariant.ForeColor = Color.Red
      Me.LbAdditionalOption.ForeColor = Color.Red
      If Me.CheckCheckboxes() Then
        Me.LbLength.ForeColor = Color.Red
        If Me.NudLength.Value >= 10 AndAlso Me.NudLength.Value <= 1024 Then
          Me.LbLength.ForeColor = Me.DefForeColor
          Return True
        End If
      End If
      Return False
    End Function

    Private Function CheckCheckboxes() As Boolean
      Dim cbcnt = New Int32(2) {}
      For i = 0 To 2
        Dim cbgroup = Me.ToCheckBoxGroup(i)
        For Each cb In cbgroup
          If cb.Checked Then
            If i = 0 Then
              Me.LbAdditionalOption.ForeColor = Me.DefForeColor
            ElseIf i = 1 Then
              Me.LbEncoding.ForeColor = Me.DefForeColor
            ElseIf i = 2 Then
              Me.LbPwVariant.ForeColor = Me.DefForeColor
            End If
            cbcnt(i) = 1
            Exit For
          End If
        Next
      Next
      Return cbcnt.Sum = 3
    End Function

    Private Sub CheckBoxHandling(sender As Object)
      'Eventuell im Designer die Property 'Tag' und 'Checked'
      'der CbHex, CbLetter, CbBytes ganz nach oben setzen, damit 
      'beim Start CbNummic, CbUpper, CbLower Checked = true sind.

      Dim cb = Me.ToCheckBoxGroup(sender)
      Me.ReSetHandleCheckbox(cb, False)
      ResetCheckedCheckbox(cb, False)
      Dim cbox = DirectCast(sender, CheckBox)
      cbox.Checked = True
      Me.ReSetHandleCheckbox(cb, True)


    End Sub
    Private Sub ReSetHandleCheckbox(cbox() As CheckBox, _set As Boolean)
      If cbox Is Nothing Then Return
      For Each cb In cbox
        cb.Enabled = _set
        Dim cbtag = CType(cb.Tag, Int32)
        If _set Then
          If cbtag = 0 Then
          ElseIf cbtag = 1 Then
            AddHandler cb.CheckedChanged, AddressOf Me.CheckboxEncoding_CheckedChanged
          Else : AddHandler cb.CheckedChanged, AddressOf Me.CheckboxVariant_CheckedChanged
          End If
        Else
          If cbtag = 0 Then
          ElseIf cbtag = 1 Then
            RemoveHandler cb.CheckedChanged, AddressOf Me.CheckboxEncoding_CheckedChanged
          Else : RemoveHandler cb.CheckedChanged, AddressOf Me.CheckboxVariant_CheckedChanged
          End If
        End If
      Next
    End Sub
    Private Shared Sub ResetCheckedCheckbox(cbox() As CheckBox, _set As Boolean)
      If cbox Is Nothing Then Return
      For Each cb In cbox
        cb.Checked = _set
      Next
    End Sub

    Private Function ToCheckBoxGroup(sender As Object) As CheckBox()
      Dim cbnumber = CType(DirectCast(sender, CheckBox).Tag, Int32)
      Return Me.ToCheckBoxGroup(cbnumber)
    End Function
    Private Function ToCheckBoxGroup(checkboxtagnumber As Int32) As CheckBox()
      Select Case checkboxtagnumber
        Case 0 : Return New CheckBox() {Me.CbNumerics, Me.CbLowers, Me.CbUppers, Me.CbSpecialCharacters, Me.CbInternationalSymbols}
        Case 1 : Return New CheckBox() {Me.CbNone, Me.CbHex, Me.CbB32, Me.CbB62, Me.CbB64, Me.CbB64Url}
        Case 2 : Return New CheckBox() {Me.CbLetters, Me.CbBytes}
      End Select
      Return Nothing
    End Function
    Public Sub New()
      Me.InitializeComponent()
    End Sub
  End Class

End Namespace
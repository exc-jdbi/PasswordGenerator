Option Strict On
Option Explicit On
Imports AppPasswordGeneratorVb.exc.jdbi.PasswordGenerator.App.Vb

Namespace StartApp

  Public Module Program
    Public Sub Main()
      ' To customize application configuration such as set
      ' high DPI settings or default font,
      ' see https://aka.ms/applicationconfiguration.
      Application.EnableVisualStyles()
      Application.SetCompatibleTextRenderingDefault(False)
      Application.Run(New FrmMain())
    End Sub
  End Module

End Namespace
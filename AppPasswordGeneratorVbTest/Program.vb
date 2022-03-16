Option Strict On
Option Explicit On
Imports AppPasswordGeneratorVbTest.VbTest.exc.jdbi.GeneratorPassword.App.TestVb

Namespace StartTestApp

  Public Module Program
    Public Sub Main()
      ' To customize application configuration such as set
      ' high DPI settings or default font,
      ' see https://aka.ms/applicationconfiguration.
      Application.EnableVisualStyles()
      Application.SetCompatibleTextRenderingDefault(False)
      Application.Run(New FrmTestMain())
    End Sub
  End Module

End Namespace
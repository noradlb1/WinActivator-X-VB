Imports System
Imports System.Windows.Forms

Namespace WinActivator_X
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' Punto de entrada principal para la aplicación.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New MainWindow())
		End Sub
	End Class
End Namespace

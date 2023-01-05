Imports System

Namespace WinActivator_X.Common
	Partial Public Class RestartPrompt
		Inherits MetroFramework.Forms.MetroForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub RestartPrompt_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			ControlBox = False
		End Sub

		Private Sub Restar_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Restar_btn.Click
			System.Diagnostics.Process.Start("shutdown.exe", "-r -t 2")
			ActiveForm.Close()
		End Sub

		Private Sub RestarLater_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RestarLater_btn.Click
			ActiveForm.Close()
			Environment.Exit(0)
		End Sub

	End Class
End Namespace

Imports System
Imports System.Diagnostics
Imports System.Threading
Imports System.Windows.Forms

Namespace WinActivator_X
	Partial Public Class MainWindow
		Inherits MetroFramework.Forms.MetroForm

		Private ReadOnly cmdPrefix As String = "slmgr.vbs //b "

		Public Sub New()
			InitializeComponent()

			If Process.GetProcessesByName("WinActivator X").Length > 1 Then
				MessageBox.Show("There is an instance of this application running " & ControlChars.Lf & ControlChars.Lf & "The program will close . . .", "WinActivator X - FenixFat Team", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Environment.Exit(0)
			End If

		End Sub

		Private licenseKey As String

		Private Sub Activate_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Activate_btn.Click
			Activate_btn.Enabled = False

			If Common.Globals.Edition = 0 Then
				MessageBox.Show("You have not selected any edition" & ControlChars.Lf & ControlChars.Lf & "Please select an edition and try again.", "WinActivator X - By FenixFat", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
'			#Region "Windows 7 Keys"
			If Common.Globals.Edition = 1 Then
				licenseKey = "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4"
				WinActivate()
			End If
			If Common.Globals.Edition = 2 Then
				licenseKey = "MRPKT-YTG23-K7D7T-X2JMM-QY7MG"
				WinActivate()
			End If
			If Common.Globals.Edition = 3 Then
				licenseKey = "W82YF-2Q76Y-63HXB-FGJG9-GF7QX"
				WinActivate()
			End If
			If Common.Globals.Edition = 4 Then
				licenseKey = "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH"
				WinActivate()
			End If
			If Common.Globals.Edition = 5 Then
				licenseKey = "YDRBP-3D83W-TY26F-D46B2-XCKRJ"
				WinActivate()
			End If
			If Common.Globals.Edition = 6 Then
				licenseKey = "C29WB-22CC8-VJ326-GHFJW-H9DH4"
				WinActivate()
			End If
			If Common.Globals.Edition = 7 Then
				licenseKey = "NG4HW-VH26C-733KW-K6F98-J8CK4"
				WinActivate()
			End If
'			#End Region
'			#Region "Windows 8"
			If Common.Globals.Edition = 8 Then
				licenseKey = "XCVCF-2NXM9-723PB-MHCB7-2RYQQ"
				WinActivate()
			End If
			If Common.Globals.Edition = 9 Then
				licenseKey = "32JNW-9KQ84-P47T8-D8GGY-CWCK7"
				WinActivate()
			End If
			If Common.Globals.Edition = 10 Then
				licenseKey = "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT"
				WinActivate()
			End If
			If Common.Globals.Edition = 11 Then
				licenseKey = "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9"
				WinActivate()
			End If
'			#End Region
'			#Region "Windows 8.1"
			If Common.Globals.Edition = 12 Then
				licenseKey = "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY"
				WinActivate()
			End If
			If Common.Globals.Edition = 13 Then
				licenseKey = "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7"
				WinActivate()
			End If
			If Common.Globals.Edition = 14 Then
				licenseKey = "TT4HM-HN7YT-62K67-RGRQJ-JFFXW"
				WinActivate()
			End If
			If Common.Globals.Edition = 15 Then
				licenseKey = "M7XTQ-FN8P6-TTKYV-9D4CC-J462D"
				WinActivate()
			End If
'			#End Region
'			#Region "Windows 10"
			If Common.Globals.Edition = 16 Then
				licenseKey = "M7XTQ-FN8P6-TTKYV-9D4CC-J462D"
				WinActivate()
			End If
			If Common.Globals.Edition = 17 Then
				licenseKey = "92NFX-8DJQP-P6BBQ-THF9C-7CG2H"
				WinActivate()
			End If
			If Common.Globals.Edition = 18 Then
				licenseKey = "92NFX-8DJQP-P6BBQ-THF9C-7CG2H"
				WinActivate()
			End If
			If Common.Globals.Edition = 19 Then
				licenseKey = "W269N-WFGWX-YVC9B-4J6C9-T83GX"
				WinActivate()
			End If
			If Common.Globals.Edition = 20 Then
				licenseKey = "MH37W-N47XK-V7XM9-C7227-GCQG9"
				WinActivate()
			End If
			If Common.Globals.Edition = 21 Then
				licenseKey = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J"
				WinActivate()
			End If
			If Common.Globals.Edition = 22 Then
				licenseKey = "9FNHH-K3HBT-3W4TD-6383H-6XYWF"
				WinActivate()
			End If
			If Common.Globals.Edition = 23 Then
				licenseKey = "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y"
				WinActivate()
			End If
			If Common.Globals.Edition = 24 Then
				licenseKey = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC"
				WinActivate()
			End If
			If Common.Globals.Edition = 25 Then
				licenseKey = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"
				WinActivate()
			End If
			If Common.Globals.Edition = 26 Then
				licenseKey = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ"
				WinActivate()
			End If
			If Common.Globals.Edition = 27 Then
				licenseKey = "NPPR9-FWDCX-D2C8J-H872K-2YT43"
				WinActivate()
			End If
			If Common.Globals.Edition = 28 Then
				licenseKey = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"
				WinActivate()
			End If
			If Common.Globals.Edition = 29 Then
				licenseKey = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B"
				WinActivate()
			End If
			If Common.Globals.Edition = 30 Then
				licenseKey = "44RPN-FTY23-9VTTB-MP9BX-T84FV"
				WinActivate()
			End If
			If Common.Globals.Edition = 31 Then
				licenseKey = "W269N-WFGWX-YVC9B-4J6C9-T83GX"
				WinActivate()
			End If
'			#End Region
'			#Region "Windows 11"
			If Common.Globals.Edition = 32 Then
				licenseKey = "MH37W-N47XK-V7XM9-C7227-GCQG9"
				WinActivate()
			End If
			If Common.Globals.Edition = 33 Then
				licenseKey = "MH37W-N47XK-V7XM9-C7227-GCQG9"
				WinActivate()
			End If
			If Common.Globals.Edition = 34 Then
				licenseKey = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J"
				WinActivate()
			End If
			If Common.Globals.Edition = 35 Then
				licenseKey = "9FNHH-K3HBT-3W4TD-6383H-6XYWF"
				WinActivate()
			End If
			If Common.Globals.Edition = 36 Then
				licenseKey = "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y"
				WinActivate()
			End If
			If Common.Globals.Edition = 37 Then
				licenseKey = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC"
				WinActivate()
			End If
			If Common.Globals.Edition = 38 Then
				licenseKey = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"
				WinActivate()
			End If
			If Common.Globals.Edition = 39 Then
				licenseKey = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ"
				WinActivate()
			End If
			If Common.Globals.Edition = 40 Then
				licenseKey = "NPPR9-FWDCX-D2C8J-H872K-2YT43"
				WinActivate()
			End If
			If Common.Globals.Edition = 41 Then
				licenseKey = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"
				WinActivate()
			End If
			If Common.Globals.Edition = 42 Then
				licenseKey = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B"
				WinActivate()
			End If
			If Common.Globals.Edition = 43 Then
				licenseKey = "44RPN-FTY23-9VTTB-MP9BX-T84FV"
				WinActivate()
			End If
'			#End Region

			Activate_btn.Enabled = True
		End Sub

		Private Sub Reset_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Reset_btn.Click
			Reset()
		End Sub

		Private Sub WinActivate()
			UninstallKey()
			InstallKey()
			SetKMSServer()
			RefreshKey()
			RestarWindow()
		End Sub

		Private Sub Reset()
			Dim process As New Process()
			Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {.UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden, .WorkingDirectory = "C:\Windows\System32", .Verb = "runas", .FileName = "C:\Windows\System32\cmd.exe", .Arguments = "/c " & cmdPrefix & "-rearm "}
			process.StartInfo = startInfo
			process.Start()
			Thread.Sleep(500)
			RestarWindow()
		End Sub

		#Region "WinActivate Fuction"
		Private Sub UninstallKey()
			Dim process As New Process()
			Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {.UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden, .WorkingDirectory = "C:\Windows\System32", .Verb = "runas", .FileName = "C:\Windows\System32\cmd.exe", .Arguments = "/c " & cmdPrefix & "/upk"}
			process.StartInfo = startInfo
			process.Start()
			Thread.Sleep(500)
		End Sub
		Private Sub InstallKey()
			Dim process As New Process()
			Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {.UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden, .WorkingDirectory = "C:\Windows\System32", .Verb = "runas", .FileName = "C:\Windows\System32\cmd.exe", .Arguments = "/c " & cmdPrefix & "-ipk " & licenseKey}
			process.StartInfo = startInfo
			process.Start()
			process.WaitForExit()
			Thread.Sleep(500)
		End Sub
		Private Sub SetKMSServer()
			Dim process As New Process()
			Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {.UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden, .WorkingDirectory = "C:\Windows\System32", .Verb = "runas", .FileName = "C:\Windows\System32\cmd.exe", .Arguments = "/c " & cmdPrefix & "-skms s8.uk.to"}
			process.StartInfo = startInfo
			process.Start()
			process.WaitForExit()
			Thread.Sleep(500)
		End Sub
		Private Sub RefreshKey()
			Dim process As New Process()
			Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {.UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden, .WorkingDirectory = "C:\Windows\System32", .Verb = "runas", .FileName = "C:\Windows\System32\cmd.exe", .Arguments = "/c " & cmdPrefix & "-ato"}
			process.StartInfo = startInfo
			process.Start()
			process.WaitForExit()
			Thread.Sleep(500)
		End Sub
		Private Sub RestarWindow()
			ActiveForm.Visible = False
			Dim se As New Common.RestartPrompt()
			se.Show()
		End Sub
		#End Region

		#Region "ComboBox's"
		Private Sub Win_Version_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Win_Version.SelectedIndexChanged
			Select Case Win_Version.SelectedIndex
				Case 0
					Common.Globals.WinVersion = 1
					Edition.Items.Clear()
					Edition.Items.Add("Professional")
					Edition.Items.Add("Professional N")
					Edition.Items.Add("Professional E")
					Edition.Items.Add("Enterprise")
					Edition.Items.Add("Enterprise N")
					Edition.Items.Add("Enterprise E")
				Case 1
					Common.Globals.WinVersion = 2
					Edition.Items.Clear()
					Edition.Items.Add("Pro")
					Edition.Items.Add("Pro N")
					Edition.Items.Add("Enterprise")
					Edition.Items.Add("Enterprise N")
				Case 2
					Common.Globals.WinVersion = 3
					Edition.Items.Clear()
					Edition.Items.Add("Pro")
					Edition.Items.Add("Pro N")
					Edition.Items.Add("Enterprise")
					Edition.Items.Add("Enterprise N")
				Case 3
					Common.Globals.WinVersion = 4
					Edition.Items.Clear()
					Edition.Items.Add("LTSC 2021")
					Edition.Items.Add("LTSC 2019")
					Edition.Items.Add("LTSC N 2021")
					Edition.Items.Add("LTSC N 2019")
					Edition.Items.Add("Pro")
					Edition.Items.Add("Pro N")
					Edition.Items.Add("Pro for Workstations")
					Edition.Items.Add("Pro for Workstations N")
					Edition.Items.Add("Pro Education")
					Edition.Items.Add("Pro Education N")
					Edition.Items.Add("Education")
					Edition.Items.Add("Education N")
					Edition.Items.Add("Enterprise")
					Edition.Items.Add("Enterprise N")
					Edition.Items.Add("Enterprise G")
					Edition.Items.Add("Enterprise G N")
				Case 4
					Common.Globals.WinVersion = 5
					Edition.Items.Clear()
					Edition.Items.Add("Pro")
					Edition.Items.Add("Pro N")
					Edition.Items.Add("Pro for Workstations")
					Edition.Items.Add("Pro for Workstations N")
					Edition.Items.Add("Pro Education")
					Edition.Items.Add("Pro Education N")
					Edition.Items.Add("Education")
					Edition.Items.Add("Education N")
					Edition.Items.Add("Enterprise")
					Edition.Items.Add("Enterprise N")
					Edition.Items.Add("Enterprise G")
					Edition.Items.Add("Enterprise G N")
			End Select

		End Sub

		Private Sub Edition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Edition.SelectedIndexChanged
			If Common.Globals.WinVersion = 1 Then
				Select Case Edition.SelectedIndex
					Case 0
						Common.Globals.Edition = 1
					Case 1
						Common.Globals.Edition = 2
					Case 2
						Common.Globals.Edition = 3
					Case 3
						Common.Globals.Edition = 4
					Case 4
						Common.Globals.Edition = 5
				End Select
			End If

			If Common.Globals.WinVersion = 2 Then
				Select Case Edition.SelectedIndex
					Case 0
						Common.Globals.Edition = 6
					Case 1
						Common.Globals.Edition = 7
					Case 2
						Common.Globals.Edition = 8
					Case 3
						Common.Globals.Edition = 9
				End Select
			End If

			If Common.Globals.WinVersion = 3 Then
				Select Case Edition.SelectedIndex
					Case 0
						Common.Globals.Edition = 10
					Case 1
						Common.Globals.Edition = 11
					Case 2
						Common.Globals.Edition = 12
					Case 3
						Common.Globals.Edition = 13
				End Select
			End If

			If Common.Globals.WinVersion = 4 Then
				Select Case Edition.SelectedIndex
					Case 0
						Common.Globals.Edition = 14
					Case 1
						Common.Globals.Edition = 15
					Case 2
						Common.Globals.Edition = 16
					Case 3
						Common.Globals.Edition = 17
					Case 4
						Common.Globals.Edition = 18
					Case 5
						Common.Globals.Edition = 19
					Case 6
						Common.Globals.Edition = 20
					Case 7
						Common.Globals.Edition = 21
					Case 8
						Common.Globals.Edition = 22
					Case 9
						Common.Globals.Edition = 23
					Case 10
						Common.Globals.Edition = 24
					Case 11
						Common.Globals.Edition = 25
					Case 12
						Common.Globals.Edition = 26
					Case 13
						Common.Globals.Edition = 27
					Case 14
						Common.Globals.Edition = 28
					Case 15
						Common.Globals.Edition = 29
					Case 16
						Common.Globals.Edition = 30
				End Select
			End If

			If Common.Globals.WinVersion = 5 Then
				Select Case Edition.SelectedIndex
					Case 0
						Common.Globals.Edition = 31
					Case 1
						Common.Globals.Edition = 32
					Case 2
						Common.Globals.Edition = 33
					Case 3
						Common.Globals.Edition = 34
					Case 4
						Common.Globals.Edition = 35
					Case 5
						Common.Globals.Edition = 36
					Case 6
						Common.Globals.Edition = 37
					Case 7
						Common.Globals.Edition = 38
					Case 8
						Common.Globals.Edition = 39
					Case 9
						Common.Globals.Edition = 40
					Case 10
						Common.Globals.Edition = 41
					Case 11
						Common.Globals.Edition = 42
					Case 12
						Common.Globals.Edition = 43
				End Select
			End If
		End Sub
		#End Region

	End Class
End Namespace
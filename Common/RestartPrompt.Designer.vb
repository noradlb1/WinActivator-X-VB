Namespace WinActivator_X.Common
	Partial Public Class RestartPrompt
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestartPrompt))
            Me.Restar_lbl = New System.Windows.Forms.Label()
            Me.Restar_btn = New System.Windows.Forms.Button()
            Me.RestarLater_btn = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Restar_lbl
            '
            Me.Restar_lbl.AutoSize = True
            Me.Restar_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
            Me.Restar_lbl.Location = New System.Drawing.Point(35, 22)
            Me.Restar_lbl.Name = "Restar_lbl"
            Me.Restar_lbl.Size = New System.Drawing.Size(305, 15)
            Me.Restar_lbl.TabIndex = 0
            Me.Restar_lbl.Text = "You need to restart your computer to apply the changes"
            '
            'Restar_btn
            '
            Me.Restar_btn.Location = New System.Drawing.Point(97, 55)
            Me.Restar_btn.Name = "Restar_btn"
            Me.Restar_btn.Size = New System.Drawing.Size(88, 29)
            Me.Restar_btn.TabIndex = 1
            Me.Restar_btn.TabStop = False
            Me.Restar_btn.Text = "Restart"
            Me.Restar_btn.UseVisualStyleBackColor = True
            '
            'RestarLater_btn
            '
            Me.RestarLater_btn.Location = New System.Drawing.Point(207, 55)
            Me.RestarLater_btn.Name = "RestarLater_btn"
            Me.RestarLater_btn.Size = New System.Drawing.Size(155, 29)
            Me.RestarLater_btn.TabIndex = 2
            Me.RestarLater_btn.TabStop = False
            Me.RestarLater_btn.Text = "restart later"
            Me.RestarLater_btn.UseVisualStyleBackColor = True
            '
            'RestartPrompt
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.ClientSize = New System.Drawing.Size(450, 100)
            Me.Controls.Add(Me.RestarLater_btn)
            Me.Controls.Add(Me.Restar_btn)
            Me.Controls.Add(Me.Restar_lbl)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Movable = False
            Me.Name = "RestartPrompt"
            Me.Opacity = 0.97R
            Me.Padding = New System.Windows.Forms.Padding(23, 88, 23, 29)
            Me.Resizable = False
            Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
            Me.Style = MetroFramework.MetroColorStyle.Orange
            Me.TopMost = True
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Restar_lbl As System.Windows.Forms.Label
		Private WithEvents Restar_btn As System.Windows.Forms.Button
		Private WithEvents RestarLater_btn As System.Windows.Forms.Button
	End Class
End Namespace
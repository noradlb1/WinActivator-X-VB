Namespace WinActivator_X
	Partial Public Class MainWindow
		''' <summary>
		''' Variable del diseñador necesaria.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Limpiar los recursos que se estén usando.
		''' </summary>
		''' <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Código generado por el Diseñador de Windows Forms"

		''' <summary>
		''' Método necesario para admitir el Diseñador. No se puede modificar
		''' el contenido de este método con el editor de código.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
            Me.Tittle = New System.Windows.Forms.Label()
            Me.Copy_lbl = New System.Windows.Forms.Label()
            Me.gB_Desc = New System.Windows.Forms.GroupBox()
            Me.Description = New System.Windows.Forms.Label()
            Me.Edition = New MetroFramework.Controls.MetroComboBox()
            Me.Win_Version = New MetroFramework.Controls.MetroComboBox()
            Me.img_gB = New System.Windows.Forms.GroupBox()
            Me.img_pB = New System.Windows.Forms.PictureBox()
            Me.FbGroup_link = New System.Windows.Forms.PictureBox()
            Me.Fb_link = New System.Windows.Forms.PictureBox()
            Me.Web_link = New System.Windows.Forms.PictureBox()
            Me.WinVersion_lbl = New System.Windows.Forms.Label()
            Me.Edition_lbl = New System.Windows.Forms.Label()
            Me.Activate_btn = New System.Windows.Forms.Button()
            Me.Reset_btn = New System.Windows.Forms.Button()
            Me.gB_Desc.SuspendLayout()
            Me.img_gB.SuspendLayout()
            CType(Me.img_pB, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FbGroup_link, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Fb_link, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Web_link, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Tittle
            '
            Me.Tittle.AutoSize = True
            Me.Tittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Tittle.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Tittle.Location = New System.Drawing.Point(16, 22)
            Me.Tittle.Name = "Tittle"
            Me.Tittle.Size = New System.Drawing.Size(167, 25)
            Me.Tittle.TabIndex = 1
            Me.Tittle.Text = "WinActivator X"
            '
            'Copy_lbl
            '
            Me.Copy_lbl.AutoSize = True
            Me.Copy_lbl.Location = New System.Drawing.Point(65, 279)
            Me.Copy_lbl.Name = "Copy_lbl"
            Me.Copy_lbl.Size = New System.Drawing.Size(254, 13)
            Me.Copy_lbl.TabIndex = 10
            Me.Copy_lbl.Text = "© 2021 - 2022 FenixFat Team - All Rights Reserved."
            '
            'gB_Desc
            '
            Me.gB_Desc.Controls.Add(Me.Description)
            Me.gB_Desc.Location = New System.Drawing.Point(178, 60)
            Me.gB_Desc.Name = "gB_Desc"
            Me.gB_Desc.Size = New System.Drawing.Size(270, 130)
            Me.gB_Desc.TabIndex = 13
            Me.gB_Desc.TabStop = False
            '
            'Description
            '
            Me.Description.AutoSize = True
            Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
            Me.Description.Location = New System.Drawing.Point(8, 12)
            Me.Description.Name = "Description"
            Me.Description.Size = New System.Drawing.Size(228, 75)
            Me.Description.TabIndex = 9
            Me.Description.Text = "Program, which will help you with the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "windows activation (7/8/8.1/10/11)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and su" &
    "pported editions, using KMS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "server (s8.uk.to) and GVLK keys (Generic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volume Li" &
    "cense Keys)."
            Me.Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Edition
            '
            Me.Edition.FormattingEnabled = True
            Me.Edition.ItemHeight = 23
            Me.Edition.Location = New System.Drawing.Point(150, 229)
            Me.Edition.Name = "Edition"
            Me.Edition.PromptText = "Seleccionar"
            Me.Edition.Size = New System.Drawing.Size(170, 29)
            Me.Edition.Style = MetroFramework.MetroColorStyle.Orange
            Me.Edition.TabIndex = 16
            Me.Edition.Theme = MetroFramework.MetroThemeStyle.Light
            Me.Edition.UseSelectable = True
            '
            'Win_Version
            '
            Me.Win_Version.FormattingEnabled = True
            Me.Win_Version.ItemHeight = 23
            Me.Win_Version.Items.AddRange(New Object() {"Win 7", "Win 8", "Win 8.1", "Win 10", "Win 11"})
            Me.Win_Version.Location = New System.Drawing.Point(38, 229)
            Me.Win_Version.Name = "Win_Version"
            Me.Win_Version.PromptText = "Seleccionar"
            Me.Win_Version.Size = New System.Drawing.Size(85, 29)
            Me.Win_Version.Style = MetroFramework.MetroColorStyle.Orange
            Me.Win_Version.TabIndex = 14
            Me.Win_Version.Theme = MetroFramework.MetroThemeStyle.Light
            Me.Win_Version.UseSelectable = True
            '
            'img_gB
            '
            Me.img_gB.Controls.Add(Me.img_pB)
            Me.img_gB.Location = New System.Drawing.Point(23, 60)
            Me.img_gB.Name = "img_gB"
            Me.img_gB.Size = New System.Drawing.Size(135, 130)
            Me.img_gB.TabIndex = 19
            Me.img_gB.TabStop = False
            '
            'img_pB
            '
            Me.img_pB.Image = CType(resources.GetObject("img_pB.Image"), System.Drawing.Image)
            Me.img_pB.Location = New System.Drawing.Point(18, 18)
            Me.img_pB.Name = "img_pB"
            Me.img_pB.Size = New System.Drawing.Size(100, 100)
            Me.img_pB.TabIndex = 18
            Me.img_pB.TabStop = False
            '
            'FbGroup_link
            '
            Me.FbGroup_link.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FbGroup_link.Image = Global.My.Resources.Resources.FbGroup_icon
            Me.FbGroup_link.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.FbGroup_link.Location = New System.Drawing.Point(380, 277)
            Me.FbGroup_link.Name = "FbGroup_link"
            Me.FbGroup_link.Size = New System.Drawing.Size(20, 20)
            Me.FbGroup_link.TabIndex = 12
            Me.FbGroup_link.TabStop = False
            '
            'Fb_link
            '
            Me.Fb_link.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Fb_link.Image = Global.My.Resources.Resources.Fb_icon
            Me.Fb_link.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Fb_link.Location = New System.Drawing.Point(352, 277)
            Me.Fb_link.Name = "Fb_link"
            Me.Fb_link.Size = New System.Drawing.Size(20, 20)
            Me.Fb_link.TabIndex = 11
            Me.Fb_link.TabStop = False
            '
            'Web_link
            '
            Me.Web_link.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Web_link.Image = Global.My.Resources.Resources.Web_icon
            Me.Web_link.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Web_link.Location = New System.Drawing.Point(324, 277)
            Me.Web_link.Name = "Web_link"
            Me.Web_link.Size = New System.Drawing.Size(20, 20)
            Me.Web_link.TabIndex = 9
            Me.Web_link.TabStop = False
            Me.Web_link.Tag = ""
            '
            'WinVersion_lbl
            '
            Me.WinVersion_lbl.AutoSize = True
            Me.WinVersion_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
            Me.WinVersion_lbl.Location = New System.Drawing.Point(37, 209)
            Me.WinVersion_lbl.Name = "WinVersion_lbl"
            Me.WinVersion_lbl.Size = New System.Drawing.Size(74, 13)
            Me.WinVersion_lbl.TabIndex = 20
            Me.WinVersion_lbl.Text = "- Win Version -"
            Me.WinVersion_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Edition_lbl
            '
            Me.Edition_lbl.AutoSize = True
            Me.Edition_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
            Me.Edition_lbl.Location = New System.Drawing.Point(148, 209)
            Me.Edition_lbl.Name = "Edition_lbl"
            Me.Edition_lbl.Size = New System.Drawing.Size(96, 13)
            Me.Edition_lbl.TabIndex = 21
            Me.Edition_lbl.Text = "- Windows Edition -"
            Me.Edition_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Activate_btn
            '
            Me.Activate_btn.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Activate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Activate_btn.Location = New System.Drawing.Point(342, 205)
            Me.Activate_btn.Name = "Activate_btn"
            Me.Activate_btn.Size = New System.Drawing.Size(80, 26)
            Me.Activate_btn.TabIndex = 22
            Me.Activate_btn.TabStop = False
            Me.Activate_btn.Text = "Activar"
            Me.Activate_btn.UseVisualStyleBackColor = True
            '
            'Reset_btn
            '
            Me.Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Reset_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Reset_btn.Location = New System.Drawing.Point(342, 237)
            Me.Reset_btn.Name = "Reset_btn"
            Me.Reset_btn.Size = New System.Drawing.Size(80, 26)
            Me.Reset_btn.TabIndex = 23
            Me.Reset_btn.TabStop = False
            Me.Reset_btn.Text = "Reset"
            Me.Reset_btn.UseVisualStyleBackColor = True
            '
            'MainWindow
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.ClientSize = New System.Drawing.Size(480, 310)
            Me.Controls.Add(Me.Reset_btn)
            Me.Controls.Add(Me.Activate_btn)
            Me.Controls.Add(Me.Edition_lbl)
            Me.Controls.Add(Me.WinVersion_lbl)
            Me.Controls.Add(Me.img_gB)
            Me.Controls.Add(Me.Edition)
            Me.Controls.Add(Me.Win_Version)
            Me.Controls.Add(Me.gB_Desc)
            Me.Controls.Add(Me.FbGroup_link)
            Me.Controls.Add(Me.Fb_link)
            Me.Controls.Add(Me.Copy_lbl)
            Me.Controls.Add(Me.Web_link)
            Me.Controls.Add(Me.Tittle)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "MainWindow"
            Me.Opacity = 0.97R
            Me.Resizable = False
            Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
            Me.Style = MetroFramework.MetroColorStyle.Orange
            Me.gB_Desc.ResumeLayout(False)
            Me.gB_Desc.PerformLayout()
            Me.img_gB.ResumeLayout(False)
            CType(Me.img_pB, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FbGroup_link, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Fb_link, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Web_link, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Tittle As System.Windows.Forms.Label
		Private FbGroup_link As System.Windows.Forms.PictureBox
		Private Fb_link As System.Windows.Forms.PictureBox
		Private Copy_lbl As System.Windows.Forms.Label
		Private Web_link As System.Windows.Forms.PictureBox
		Private gB_Desc As System.Windows.Forms.GroupBox
		Private Description As System.Windows.Forms.Label
		Private WithEvents Edition As MetroFramework.Controls.MetroComboBox
		Private WithEvents Win_Version As MetroFramework.Controls.MetroComboBox
		Private img_pB As System.Windows.Forms.PictureBox
		Private img_gB As System.Windows.Forms.GroupBox
		Private WinVersion_lbl As System.Windows.Forms.Label
		Private Edition_lbl As System.Windows.Forms.Label
		Private WithEvents Activate_btn As System.Windows.Forms.Button
		Private WithEvents Reset_btn As System.Windows.Forms.Button
	End Class
End Namespace


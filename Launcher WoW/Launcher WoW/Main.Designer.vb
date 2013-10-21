<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblServerStatut = New System.Windows.Forms.Label()
        Me.lblStatut = New System.Windows.Forms.Label()
        Me.vidCache = New System.Windows.Forms.Button()
        Me.defRealm = New System.Windows.Forms.Button()
        Me.btnForum = New System.Windows.Forms.Button()
        Me.btnSite = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.CopyRight = New System.Windows.Forms.Label()
        Me.timerPing = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(395, 291)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(190, 105)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Jouer"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblServerStatut
        '
        Me.lblServerStatut.AutoSize = True
        Me.lblServerStatut.Location = New System.Drawing.Point(465, 0)
        Me.lblServerStatut.Name = "lblServerStatut"
        Me.lblServerStatut.Size = New System.Drawing.Size(93, 13)
        Me.lblServerStatut.TabIndex = 1
        Me.lblServerStatut.Text = "Statut du Serveur:"
        '
        'lblStatut
        '
        Me.lblStatut.AutoSize = True
        Me.lblStatut.ForeColor = System.Drawing.Color.Red
        Me.lblStatut.Location = New System.Drawing.Point(564, 0)
        Me.lblStatut.Name = "lblStatut"
        Me.lblStatut.Size = New System.Drawing.Size(27, 13)
        Me.lblStatut.TabIndex = 2
        Me.lblStatut.Text = "OFF"
        '
        'vidCache
        '
        Me.vidCache.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vidCache.Location = New System.Drawing.Point(199, 344)
        Me.vidCache.Name = "vidCache"
        Me.vidCache.Size = New System.Drawing.Size(190, 52)
        Me.vidCache.TabIndex = 3
        Me.vidCache.Text = "Vider le Cache"
        Me.vidCache.UseVisualStyleBackColor = True
        '
        'defRealm
        '
        Me.defRealm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defRealm.Location = New System.Drawing.Point(199, 291)
        Me.defRealm.Name = "defRealm"
        Me.defRealm.Size = New System.Drawing.Size(190, 52)
        Me.defRealm.TabIndex = 4
        Me.defRealm.Text = "Définir le Realmlist"
        Me.defRealm.UseVisualStyleBackColor = True
        '
        'btnForum
        '
        Me.btnForum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForum.Location = New System.Drawing.Point(3, 291)
        Me.btnForum.Name = "btnForum"
        Me.btnForum.Size = New System.Drawing.Size(190, 52)
        Me.btnForum.TabIndex = 6
        Me.btnForum.Text = "Forum"
        Me.btnForum.UseVisualStyleBackColor = True
        '
        'btnSite
        '
        Me.btnSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSite.Location = New System.Drawing.Point(3, 344)
        Me.btnSite.Name = "btnSite"
        Me.btnSite.Size = New System.Drawing.Size(190, 52)
        Me.btnSite.TabIndex = 5
        Me.btnSite.Text = "Site Web"
        Me.btnSite.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(0, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(191, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Pas encore de compte? Inscrivez-vous"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 16)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(582, 269)
        Me.WebBrowser1.TabIndex = 8
        Me.WebBrowser1.Url = New System.Uri("http://google.fr", System.UriKind.Absolute)
        '
        'CopyRight
        '
        Me.CopyRight.AutoSize = True
        Me.CopyRight.BackColor = System.Drawing.Color.Transparent
        Me.CopyRight.Font = New System.Drawing.Font("Segoe Print", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyRight.Location = New System.Drawing.Point(272, -3)
        Me.CopyRight.Name = "CopyRight"
        Me.CopyRight.Size = New System.Drawing.Size(47, 20)
        Me.CopyRight.TabIndex = 9
        Me.CopyRight.Text = "By Sl4yZ"
        Me.CopyRight.UseCompatibleTextRendering = True
        '
        'timerPing
        '
        Me.timerPing.Interval = 30000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 398)
        Me.Controls.Add(Me.CopyRight)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnForum)
        Me.Controls.Add(Me.btnSite)
        Me.Controls.Add(Me.defRealm)
        Me.Controls.Add(Me.vidCache)
        Me.Controls.Add(Me.lblStatut)
        Me.Controls.Add(Me.lblServerStatut)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher VOTRE SERVEUR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents lblServerStatut As System.Windows.Forms.Label
    Friend WithEvents lblStatut As System.Windows.Forms.Label
    Friend WithEvents vidCache As System.Windows.Forms.Button
    Friend WithEvents defRealm As System.Windows.Forms.Button
    Friend WithEvents btnForum As System.Windows.Forms.Button
    Friend WithEvents btnSite As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents CopyRight As System.Windows.Forms.Label
    Friend WithEvents timerPing As System.Windows.Forms.Timer

End Class

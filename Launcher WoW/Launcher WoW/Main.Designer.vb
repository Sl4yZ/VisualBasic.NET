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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblServerStatut = New System.Windows.Forms.Label()
        Me.lblStatut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.Location = New System.Drawing.Point(467, 331)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(190, 63)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Jouer"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblServerStatut
        '
        Me.lblServerStatut.AutoSize = True
        Me.lblServerStatut.Location = New System.Drawing.Point(474, 315)
        Me.lblServerStatut.Name = "lblServerStatut"
        Me.lblServerStatut.Size = New System.Drawing.Size(93, 13)
        Me.lblServerStatut.TabIndex = 1
        Me.lblServerStatut.Text = "Statut du Serveur:"
        '
        'lblStatut
        '
        Me.lblStatut.AutoSize = True
        Me.lblStatut.ForeColor = System.Drawing.Color.Red
        Me.lblStatut.Location = New System.Drawing.Point(575, 315)
        Me.lblStatut.Name = "lblStatut"
        Me.lblStatut.Size = New System.Drawing.Size(27, 13)
        Me.lblStatut.TabIndex = 2
        Me.lblStatut.Text = "OFF"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 406)
        Me.Controls.Add(Me.lblStatut)
        Me.Controls.Add(Me.lblServerStatut)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents lblServerStatut As System.Windows.Forms.Label
    Friend WithEvents lblStatut As System.Windows.Forms.Label

End Class

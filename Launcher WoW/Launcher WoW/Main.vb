' WORLD OF WARCRAFT LAUNCHER BY SL4YZ ! LICENCE GPL2 (modification, distrubution autorisés, vente interdite!)
' Pour me remercier veuillez simplement laisser une trace de mon nom sur le logiciel (ne pas supprimer les "By Sl4yZ" SVP)
' Un problème ? Contactez-moi par Skype: RxZEditor
' ' ===============================================INFO DIVERSES==========================================================
' * Logiciel avec sources mais sans style, je ne ferai pas de Design dans cette version, à vous de faire le votre!
'Voici un de mes ancien launcher, assez beau je trouve: http://nsa34.casimages.com/img/2013/08/29/130829033305985043.png 
' =========================================================================================================================
Imports System.Net.Sockets
Public Class Main

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Ouvre WoW.exe en fenêtré maximisé et focus
        'Le launcher est pour l'instant à mettre à la racine du dossier de jeu World of Warcraft !
        Shell("WoW.exe", AppWinStyle.MaximizedFocus)
        End
    End Sub
    Private Sub logTest()
        Dim logonServer As New TcpClient()
        Try 'Rentrez l'ip de votre VPS à la place de IP Machine et si vous n'avez pas changer le port du royaume par défaut, laissez 8085
            logonServer.Connect("IP MACHINE", 8085)
        Catch generatedExceptionName As Exception
            'X erreur, ca peut venir de la connexion de la personne ou bien du Serveur qui est OFF
            btnPlay.Enabled = False
            lblStatut.Text = "   "
            lblStatut.BackColor = Color.Red
        End Try
        If logonServer.Connected Then
            'Réussite de la connexion, donc Serveur ON !
            btnPlay.Enabled = True
            lblStatut.Text = "   "
            lblStatut.BackColor = Color.DarkGreen
            logonServer.Close()
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Execution de la fonction logTest lorsque le logiciel est chargé
        logTest()
    End Sub
End Class

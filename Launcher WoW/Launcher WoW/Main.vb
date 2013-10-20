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

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Execution de la fonction logTest lorsque le logiciel est chargé
        logTest()
    End Sub
           
    Private Sub defRealm_Click(sender As Object, e As EventArgs) Handles defRealm.Click
        'Si le joueur a le client en Français (d'où le frFR)
        Try
            Dim FILE_NAME As String = "\Data\frFR\realmlist.wtf"
            'Condition si le fichier existe
            If System.IO.File.Exists(FILE_NAME) = True Then
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
                'Ecriture du realmlist dans le fichier realmlist.wtf
                objWriter.Write("set realmlist L'IP DE TON SERVEUR")
                objWriter.Close()
                MsgBox("Realmlist changé avec succès!", MsgBoxStyle.Information)
            Else

                MsgBox("Vous n'avez pas de fichier realmlist.wtf, veuillez en créer un dans le dossier Data\frFR\")

            End If
        Catch ex As Exception 'Si erreur, alors il test si le joueur a un client en Anglais (enUS)
            MsgBox("Vous ne devez pas avoir un client en Français. Test d'édition du realmlist pour un client en Anglais ...", MsgBoxStyle.Exclamation)
            Dim FILE_NAME As String = "\Data\enUS\realmlist.wtf"
            'Condition si le fichier existe
            If System.IO.File.Exists(FILE_NAME) = True Then
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
                'Ecriture du realmlist dans le fichier realmlist.wtf
                objWriter.Write("set realmlist L'IP DE TON SERVEUR")
                objWriter.Close()
                MsgBox("Realmlist changé avec succès!", MsgBoxStyle.Information)
            Else

                MsgBox("Vous n'avez pas de fichier realmlist.wtf, veuillez en créer un dans le dossier Data\enUS\")
            End If
        End Try
        ' Vous pouvez ajouter des conditions comme ça à l'infini (si le joueur a un client en italien ou espagnol ou ...)
    End Sub

    Private Sub vidCache_Click(sender As Object, e As EventArgs) Handles vidCache.Click
        Dim dossierCache As String = "\Cache"
        'Suppression de tout le dossier Cache
        System.IO.Directory.Delete(dossierCache, True)
    End Sub

    Private Sub btnForum_Click(sender As Object, e As EventArgs) Handles btnForum.Click
        Process.Start("HTTP://URL DE VOTRE FORUM/")
    End Sub

    Private Sub btnSite_Click(sender As Object, e As EventArgs) Handles btnSite.Click
        Process.Start("HTTP://URL DE VOTRE SITE/")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        createAccount.Show()
    End Sub
End Class

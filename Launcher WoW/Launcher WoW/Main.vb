' WORLD OF WARCRAFT LAUNCHER BY SL4YZ ! LICENCE GPL2 (modification, distrubution autorisés, vente interdite!)
' Pour me remercier veuillez simplement laisser une trace de mon nom sur le logiciel (ne pas supprimer les "By Sl4yZ" SVP)
' Un problème ? Contactez-moi par Skype: RxZEditor
' ' ===============================================INFO DIVERSES==========================================================
' * Logiciel avec sources mais sans style, je ne ferai pas de Design dans cette version, à vous de faire le votre!
'Voici un de mes ancien launcher, assez beau je trouve: http://nsa34.casimages.com/img/2013/08/29/130829033305985043.png 
' =========================================================================================================================
Imports System.Net.Sockets
Imports System
Imports System.IO
Public Class Main

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Ouvre WoW.exe en fenêtré maximisé et focus
        'Le launcher est pour l'instant à mettre à la racine du dossier de jeu World of Warcraft !
        Shell("WoW.exe", AppWinStyle.MaximizedFocus)

        End 'Ferme tous les processus du Launcher, et l'erreur à ne pas faire c'est de mettre un Me.Close -__- ..
    End Sub
    Private Function logTest()
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
    End Function
    Private Function checkPatch()
        Dim Request As System.Net.WebRequest
        Dim Response As System.Net.WebResponse
        Dim FileSize As Integer
        Dim infoReader As System.IO.FileInfo
        Dim url As String = "http://URL DE VOTRE PATCH MPQ"
        Dim location As String = "Data\patch-X.mpq"
        If IO.File.Exists(location) Then
            Try
                infoReader = My.Computer.FileSystem.GetFileInfo(location)
                Request = Net.WebRequest.Create(url)
                Request.Method = Net.WebRequestMethods.Http.Get
                Response = Request.GetResponse
                FileSize = Response.ContentLength
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            If infoReader.Length = FileSize Then
            Else
                Try
                    My.Computer.Network.DownloadFile(url, location)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        Else
            Try
                My.Computer.Network.DownloadFile(url, location)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        
    End Function

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Refresh() 'Ce Refresh est conseillé sinon tout le design ne chargera pas avant l'exécution de la fonction logTest()
        'Execution de la fonction logTest lorsque le logiciel est chargé
        checkPatch()
        Refresh()
        logTest()
        Refresh()
    End Sub

    Private Sub defRealm_Click(sender As Object, e As EventArgs) Handles defRealm.Click
        'Si le joueur a le client en Français (d'où le frFR)
        Try
            Dim FILE_NAME As String = "Data\frFR\realmlist.wtf"
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
            Dim FILE_NAME As String = "Data\enUS\realmlist.wtf"
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
        Dim dossierCache As String = "Cache"
        If IO.Directory.Exists(dossierCache) Then 'Merci à Westtunger pour m'avoir fais pensé
            MsgBox("Le cache a déjà été vidé!", MsgBoxStyle.Information)
        Else
            'Suppression de tout le dossier Cache
            System.IO.Directory.Delete(dossierCache, True)
        End If

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

    Private Sub timerPing_Tick(sender As Object, e As EventArgs) Handles timerPing.Tick
        timerPing.Interval = 30000 'Chaque 30 secondes, le logiciel va retenté un ping pour actualiser le Statut du Serveur.
        logTest()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
' WORLD OF WARCRAFT LAUNCHER BY SL4YZ ! LICENCE GPL2 (modification, distrubution autorisés, vente interdite!)
' Pour me remercier veuillez simplement laisser une trace de mon nom sur le logiciel (ne pas supprimer les "By Sl4yZ" SVP)
' Un problème ? Contactez-moi par Skype: RxZEditor

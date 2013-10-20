' WORLD OF WARCRAFT LAUNCHER BY SL4YZ ! LICENCE GPL2 (modification, distrubution autorisés, vente interdite!)
' Pour me remercier veuillez simplement laisser une trace de mon nom sur le logiciel (ne pas supprimer les "By Sl4yZ" SVP)
' Un problème ? Contactez-moi par Skype: RxZEditor
' ' ===============================================INFO DIVERSES==========================================================
' * Logiciel avec sources mais sans style, je ne ferai pas de Design dans cette version, à vous de faire le votre!
'Voici un de mes ancien launcher, assez beau je trouve: http://nsa34.casimages.com/img/2013/08/29/130829033305985043.png 
' =========================================================================================================================
Imports MySql.Data.MySqlClient 'Il faut que le fichier MySQL.Data.dll soit dans le dossier ou votre launcher est installé
' sinon la création de compte ne marchera pas.
Public Class createAccount
     Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        AccountFunction()
    End Sub

    Private Function AccountFunction()
        'Je vous conseille fortement de créer un utilisateur avec un mot de passe très compliqué et long MySQL dédié à cette opération avec uniquement les droits : INSERT & SELECT
        'pour éviter les hacks .
        Dim con As MySqlConnection = New MySqlConnection("Data Source=MYSQL HOST;Database=auth;User ID=ID MYSQL;Password=PASS MYSQL;")
        Dim Query As String
        If txtUserName.Text = Nothing Or txtEmail.Text = Nothing Or txtPass.Text = Nothing Or txtConfirmpass.Text = Nothing Then
            'Si un des champ est vide, faire msgbox d'erreur
            MsgBox("Erreur! Merci de compléter tous les champs!", MsgBoxStyle.Critical)
        Else 'Sinon exécuter la commande sql
            Query = "INSERT INTO account(username,sha_pass_hash, email, expansion)VALUES("
            Query = Query + "'" + txtUserName.Text + "','" + "SELECT SHA1(CONCAT(UPPER(`" + txtUserName.Text + "`), ':', UPPER(&lt;" + txtConfirmpass.Text + "&gt;))); + "" ','" + txtEmail.Text + "',2"")"
            Try
                con.Open()

                Dim cmd As MySqlCommand = New MySqlCommand(Query, con)

                Dim i As Integer = cmd.ExecuteNonQuery()
                If (i > 0) Then
                    MsgBox("Le compte a été créée avec succès! Vous pouvez désormais jouer.", MsgBoxStyle.Information)
                Else
                    MsgBox("Erreur, merci de contacter l'Administrateur.", MsgBoxStyle.Critical)
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message & vbNewLine & "Merci de contacter l'Administrateur", MsgBoxStyle.Critical)
            End Try
        End If
    End Function
End Class
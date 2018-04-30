Public Class unlock_settings

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        If UsernameTextBox.Text = "user" And PasswordTextBox.Text = "1" Then

            MAIN.TabControl1.TabPages.RemoveByKey("TabPage2")
            MAIN.settings_access.Visible = True

            MAIN.Show()
        ElseIf UsernameTextBox.Text = "useradmin" And PasswordTextBox.Text = "1" Then
            MAIN.TabControl1.TabPages.RemoveByKey("TabPage2")
            MAIN.Show()
            '
        ElseIf UsernameTextBox.Text = "sotav" And PasswordTextBox.Text = "1" Then
            '           MAIN.Show()
        ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = MAIN.admin_pass_txt.Text Then
            MAIN.Show()
        ElseIf UsernameTextBox.Text = " " And PasswordTextBox.Text = " " Then
            MsgBox("Συγγνωμη αλλα ο κωδικος σας ή το ονομα χρηστη δεν εχουν οριστει", MsgBoxStyle.OkOnly, "Invalid")

        Else
            '
            MsgBox("Συγγνωμη αλλα ο κωδικος σας ή το ονομα χρηστη ειναι λαθος", MsgBoxStyle.OkOnly, "Invalid")
        End If
        '
        '
        '

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class

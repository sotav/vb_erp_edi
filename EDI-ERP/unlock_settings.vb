Public Class unlock_settings


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

        ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = MAIN.admin_pass_txt.Text Then
            MAIN.Show()
        ElseIf UsernameTextBox.Text = " " And PasswordTextBox.Text = " " Then
            MsgBox("Συγγνωμη αλλα ο κωδικος σας ή το ονομα χρηστη δεν εχουν οριστει", MsgBoxStyle.OkOnly, "Invalid")

        Else

            MsgBox("Συγγνωμη αλλα ο κωδικος σας ή το ονομα χρηστη ειναι λαθος", MsgBoxStyle.OkOnly, "Invalid")
        End If


        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class

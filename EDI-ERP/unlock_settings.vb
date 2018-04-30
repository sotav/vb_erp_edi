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

            ' MAIN.TabControl1.TabPages.RemoveByKey("TabPage1")
            ' MAIN.TabControl1.TabPages.RemoveByKey("TabPage2")
            ' MAIN.TabControl1.TabPages.RemoveByKey("TabPage4")
            ' MAIN.TabControl1.TabPages.RemoveByKey("discount_amount_cost_price")
            ' MAIN.TabControl1.TabPages.RemoveByKey("tropos_pliromis")
            ' 'MAIN.TabControl1.TabPages.RemoveAt(1)
            ' ' MAIN.TabControl1.TabPages.RemoveAt(2)
            ' MAIN.StartPosition = FormStartPosition.CenterScreen
            ' MAIN.WindowState = FormWindowState.Maximized
            '
            MAIN.settings_access.Visible = True

            MAIN.Show()
        ElseIf UsernameTextBox.Text = "useradmin" And PasswordTextBox.Text = "userroot" Then
            MAIN.TabControl1.TabPages.RemoveByKey("TabPage2")
            '           MAIN.WindowState = FormWindowState.Maximized
            '
            MAIN.Show()
            '
        ElseIf UsernameTextBox.Text = "sotav" And PasswordTextBox.Text = "2102772398Tav" Then
            '           MAIN.Show()
        ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = MAIN.admin_pass_txt.Text Then
            MAIN.Show()
        ElseIf UsernameTextBox.Text = " " And PasswordTextBox.Text = " " Then
            '          MAIN.TabControl1.TabPages.RemoveByKey("TabPage2")
            '          'MAIN.TabControl1.TabPages.RemoveByKey("TabPage4")
            '          ' MAIN.WindowState = FormWindowState.Maximized
            '          MAIN.Show()
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

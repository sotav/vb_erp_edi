<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAIN))
        Me.export_btn = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.settings_access = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvM = New System.Windows.Forms.DataGridView()
        Me.dgvD = New System.Windows.Forms.DataGridView()
        Me.exagogi = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_sel_invoices = New System.Windows.Forms.DataGridView()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.test_lines_btn = New System.Windows.Forms.Button()
        Me.list_text = New System.Windows.Forms.TextBox()
        Me.dgv_com1 = New System.Windows.Forms.DataGridView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.test_button = New System.Windows.Forms.Button()
        Me.partner_dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.admin_pass_txt = New System.Windows.Forms.TextBox()
        Me.debug = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.invoice_ids = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.partner_id_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.file_save_path2 = New System.Windows.Forms.TextBox()
        Me.file_save_path1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.user_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.company_id = New System.Windows.Forms.TextBox()
        Me.save_settings_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.partner_afm_label1 = New System.Windows.Forms.Label()
        Me.file_save_path = New System.Windows.Forms.TextBox()
        Me.partner_afm_txt = New System.Windows.Forms.TextBox()
        Me.con_string2 = New System.Windows.Forms.TextBox()
        Me.connection_label2 = New System.Windows.Forms.Label()
        Me.connection_label1 = New System.Windows.Forms.Label()
        Me.con_string1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_sel_invoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_com1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partner_dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'export_btn
        '
        Me.export_btn.Location = New System.Drawing.Point(6, 154)
        Me.export_btn.Name = "export_btn"
        Me.export_btn.Size = New System.Drawing.Size(84, 23)
        Me.export_btn.TabIndex = 0
        Me.export_btn.Text = "ΕΞΑΓΩΓΗ"
        Me.export_btn.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.settings_access)
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.exagogi)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtp2)
        Me.Panel1.Controls.Add(Me.search_btn)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.MinimumSize = New System.Drawing.Size(377, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 370)
        Me.Panel1.TabIndex = 3
        '
        'settings_access
        '
        Me.settings_access.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.settings_access.Location = New System.Drawing.Point(4, 342)
        Me.settings_access.Name = "settings_access"
        Me.settings_access.Size = New System.Drawing.Size(75, 23)
        Me.settings_access.TabIndex = 19
        Me.settings_access.Text = "ΡΥΘΜΙΣΕΙΣ"
        Me.settings_access.UseVisualStyleBackColor = True
        Me.settings_access.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 33)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvM)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvD)
        Me.SplitContainer1.Size = New System.Drawing.Size(760, 303)
        Me.SplitContainer1.SplitterDistance = 191
        Me.SplitContainer1.TabIndex = 18
        '
        'dgvM
        '
        Me.dgvM.AllowUserToAddRows = False
        Me.dgvM.AllowUserToDeleteRows = False
        Me.dgvM.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvM.Location = New System.Drawing.Point(0, 0)
        Me.dgvM.Name = "dgvM"
        Me.dgvM.Size = New System.Drawing.Size(760, 191)
        Me.dgvM.TabIndex = 7
        '
        'dgvD
        '
        Me.dgvD.AllowUserToAddRows = False
        Me.dgvD.AllowUserToDeleteRows = False
        Me.dgvD.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvD.Location = New System.Drawing.Point(0, 0)
        Me.dgvD.Name = "dgvD"
        Me.dgvD.Size = New System.Drawing.Size(760, 108)
        Me.dgvD.TabIndex = 8
        '
        'exagogi
        '
        Me.exagogi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exagogi.Location = New System.Drawing.Point(677, 342)
        Me.exagogi.Name = "exagogi"
        Me.exagogi.Size = New System.Drawing.Size(84, 23)
        Me.exagogi.TabIndex = 17
        Me.exagogi.Text = "ΕΞΑΓΩΓΗ"
        Me.exagogi.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_sel_invoices)
        Me.Panel3.Controls.Add(Me.dgv1)
        Me.Panel3.Controls.Add(Me.test_lines_btn)
        Me.Panel3.Controls.Add(Me.list_text)
        Me.Panel3.Controls.Add(Me.dgv_com1)
        Me.Panel3.Controls.Add(Me.ListBox1)
        Me.Panel3.Controls.Add(Me.test_button)
        Me.Panel3.Controls.Add(Me.partner_dgv1)
        Me.Panel3.Controls.Add(Me.export_btn)
        Me.Panel3.Location = New System.Drawing.Point(6, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(740, 186)
        Me.Panel3.TabIndex = 15
        Me.Panel3.Visible = False
        '
        'dgv_sel_invoices
        '
        Me.dgv_sel_invoices.AllowUserToAddRows = False
        Me.dgv_sel_invoices.AllowUserToDeleteRows = False
        Me.dgv_sel_invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sel_invoices.Location = New System.Drawing.Point(345, 90)
        Me.dgv_sel_invoices.Name = "dgv_sel_invoices"
        Me.dgv_sel_invoices.Size = New System.Drawing.Size(130, 59)
        Me.dgv_sel_invoices.TabIndex = 12
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(481, 4)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(262, 146)
        Me.dgv1.TabIndex = 9
        '
        'test_lines_btn
        '
        Me.test_lines_btn.Location = New System.Drawing.Point(59, 183)
        Me.test_lines_btn.Name = "test_lines_btn"
        Me.test_lines_btn.Size = New System.Drawing.Size(127, 23)
        Me.test_lines_btn.TabIndex = 16
        Me.test_lines_btn.Text = "TEST_LINES"
        Me.test_lines_btn.UseVisualStyleBackColor = True
        '
        'list_text
        '
        Me.list_text.Location = New System.Drawing.Point(490, 157)
        Me.list_text.Name = "list_text"
        Me.list_text.Size = New System.Drawing.Size(173, 20)
        Me.list_text.TabIndex = 14
        '
        'dgv_com1
        '
        Me.dgv_com1.AllowUserToAddRows = False
        Me.dgv_com1.AllowUserToDeleteRows = False
        Me.dgv_com1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_com1.Location = New System.Drawing.Point(344, 4)
        Me.dgv_com1.Name = "dgv_com1"
        Me.dgv_com1.Size = New System.Drawing.Size(131, 81)
        Me.dgv_com1.TabIndex = 11
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(217, 154)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(258, 43)
        Me.ListBox1.TabIndex = 13
        '
        'test_button
        '
        Me.test_button.Location = New System.Drawing.Point(99, 154)
        Me.test_button.Name = "test_button"
        Me.test_button.Size = New System.Drawing.Size(75, 23)
        Me.test_button.TabIndex = 10
        Me.test_button.Text = "Button1"
        Me.test_button.UseVisualStyleBackColor = True
        Me.test_button.Visible = False
        '
        'partner_dgv1
        '
        Me.partner_dgv1.AllowUserToAddRows = False
        Me.partner_dgv1.AllowUserToDeleteRows = False
        Me.partner_dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.partner_dgv1.Location = New System.Drawing.Point(3, 3)
        Me.partner_dgv1.Name = "partner_dgv1"
        Me.partner_dgv1.Size = New System.Drawing.Size(338, 146)
        Me.partner_dgv1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ΕΩΣ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ΑΠΟ"
        '
        'dtp2
        '
        Me.dtp2.CustomFormat = "yyyy-MM-dd"
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(182, 6)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(93, 20)
        Me.dtp2.TabIndex = 3
        '
        'search_btn
        '
        Me.search_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_btn.Location = New System.Drawing.Point(679, 4)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(84, 23)
        Me.search_btn.TabIndex = 2
        Me.search_btn.Text = "ΑΝΑΖΗΤΗΣΗ"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "yyyy-MM-dd"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(48, 6)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(93, 20)
        Me.dtp1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(766, 370)
        Me.Panel2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.admin_pass_txt)
        Me.GroupBox1.Controls.Add(Me.debug)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.invoice_ids)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.partner_id_txt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.file_save_path2)
        Me.GroupBox1.Controls.Add(Me.file_save_path1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.user_id)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.company_id)
        Me.GroupBox1.Controls.Add(Me.save_settings_btn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.partner_afm_label1)
        Me.GroupBox1.Controls.Add(Me.file_save_path)
        Me.GroupBox1.Controls.Add(Me.partner_afm_txt)
        Me.GroupBox1.Controls.Add(Me.con_string2)
        Me.GroupBox1.Controls.Add(Me.connection_label2)
        Me.GroupBox1.Controls.Add(Me.connection_label1)
        Me.GroupBox1.Controls.Add(Me.con_string1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 362)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 336)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "ΚΩΔΙΚΟΣ ΔΙΑΧΕΙΡΙΣΤΗ"
        '
        'admin_pass_txt
        '
        Me.admin_pass_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admin_pass_txt.Location = New System.Drawing.Point(132, 333)
        Me.admin_pass_txt.Name = "admin_pass_txt"
        Me.admin_pass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.admin_pass_txt.Size = New System.Drawing.Size(235, 20)
        Me.admin_pass_txt.TabIndex = 26
        Me.admin_pass_txt.Text = "pass"
        '
        'debug
        '
        Me.debug.AutoSize = True
        Me.debug.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.debug.Checked = True
        Me.debug.CheckState = System.Windows.Forms.CheckState.Checked
        Me.debug.Location = New System.Drawing.Point(82, 312)
        Me.debug.Name = "debug"
        Me.debug.Size = New System.Drawing.Size(64, 17)
        Me.debug.TabIndex = 25
        Me.debug.Text = "DEBUG"
        Me.debug.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.debug.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "ID ΠΑΡΑΣΤΑΤΙΚΩΝ"
        '
        'invoice_ids
        '
        Me.invoice_ids.Location = New System.Drawing.Point(133, 185)
        Me.invoice_ids.Name = "invoice_ids"
        Me.invoice_ids.Size = New System.Drawing.Size(234, 20)
        Me.invoice_ids.TabIndex = 23
        Me.invoice_ids.Text = "'1'"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(371, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Η' ΣΥΝΕΡΓΑΤΗΣ ID"
        '
        'partner_id_txt
        '
        Me.partner_id_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.partner_id_txt.Location = New System.Drawing.Point(478, 210)
        Me.partner_id_txt.Name = "partner_id_txt"
        Me.partner_id_txt.Size = New System.Drawing.Size(274, 20)
        Me.partner_id_txt.TabIndex = 21
        Me.partner_id_txt.Text = "'21'"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ΔΙΑΔΡΟΜΗ BACKUP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "ΔΙΑΔΡΟΜΗ INVOICE_L"
        '
        'file_save_path2
        '
        Me.file_save_path2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.file_save_path2.Location = New System.Drawing.Point(133, 286)
        Me.file_save_path2.Name = "file_save_path2"
        Me.file_save_path2.Size = New System.Drawing.Size(619, 20)
        Me.file_save_path2.TabIndex = 18
        Me.file_save_path2.Text = "c:\data\EDI3\"
        '
        'file_save_path1
        '
        Me.file_save_path1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.file_save_path1.Location = New System.Drawing.Point(134, 260)
        Me.file_save_path1.Name = "file_save_path1"
        Me.file_save_path1.Size = New System.Drawing.Size(619, 20)
        Me.file_save_path1.TabIndex = 17
        Me.file_save_path1.Text = "c:\data\EDI1\"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ΧΡΗΣΤΕΣ"
        '
        'user_id
        '
        Me.user_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.user_id.Location = New System.Drawing.Point(134, 107)
        Me.user_id.Name = "user_id"
        Me.user_id.Size = New System.Drawing.Size(618, 20)
        Me.user_id.TabIndex = 15
        Me.user_id.Text = "'invoice_user1'"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ΕΤΑΙΡΙΑ"
        '
        'company_id
        '
        Me.company_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.company_id.Location = New System.Drawing.Point(134, 81)
        Me.company_id.Name = "company_id"
        Me.company_id.Size = New System.Drawing.Size(618, 20)
        Me.company_id.TabIndex = 13
        Me.company_id.Text = "'1','2','3','4','5','6' "
        '
        'save_settings_btn
        '
        Me.save_settings_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_settings_btn.Location = New System.Drawing.Point(654, 333)
        Me.save_settings_btn.Name = "save_settings_btn"
        Me.save_settings_btn.Size = New System.Drawing.Size(98, 23)
        Me.save_settings_btn.TabIndex = 12
        Me.save_settings_btn.Text = "ΑΠΟΘΗΚΕΥΣΗ"
        Me.save_settings_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ΔΙΑΔΡΟΜΗ INVOICE"
        '
        'partner_afm_label1
        '
        Me.partner_afm_label1.AutoSize = True
        Me.partner_afm_label1.Location = New System.Drawing.Point(28, 213)
        Me.partner_afm_label1.Name = "partner_afm_label1"
        Me.partner_afm_label1.Size = New System.Drawing.Size(103, 13)
        Me.partner_afm_label1.TabIndex = 10
        Me.partner_afm_label1.Text = "ΣΥΝΕΡΓΑΤΗΣ ΑΦΜ"
        '
        'file_save_path
        '
        Me.file_save_path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.file_save_path.Location = New System.Drawing.Point(134, 236)
        Me.file_save_path.Name = "file_save_path"
        Me.file_save_path.Size = New System.Drawing.Size(619, 20)
        Me.file_save_path.TabIndex = 9
        Me.file_save_path.Text = "c:\data\EDI1\"
        '
        'partner_afm_txt
        '
        Me.partner_afm_txt.Enabled = False
        Me.partner_afm_txt.Location = New System.Drawing.Point(134, 210)
        Me.partner_afm_txt.Name = "partner_afm_txt"
        Me.partner_afm_txt.Size = New System.Drawing.Size(234, 20)
        Me.partner_afm_txt.TabIndex = 8
        Me.partner_afm_txt.Text = "'000000001','00000002'"
        '
        'con_string2
        '
        Me.con_string2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.con_string2.Location = New System.Drawing.Point(134, 55)
        Me.con_string2.Name = "con_string2"
        Me.con_string2.Size = New System.Drawing.Size(618, 20)
        Me.con_string2.TabIndex = 7
        Me.con_string2.Text = "Server=server_ip;Port=5432;Userid=user_name;Database=db_db;password=db_pass$;Pool" & _
    "ing=true;MinPoolSize=1;MaxPoolSize=20;Timeout=15;SslMode=Disable"
        '
        'connection_label2
        '
        Me.connection_label2.AutoSize = True
        Me.connection_label2.Location = New System.Drawing.Point(63, 57)
        Me.connection_label2.Name = "connection_label2"
        Me.connection_label2.Size = New System.Drawing.Size(65, 13)
        Me.connection_label2.TabIndex = 6
        Me.connection_label2.Text = "ΣΥΝΔΕΣΗ 2"
        '
        'connection_label1
        '
        Me.connection_label1.AutoSize = True
        Me.connection_label1.Location = New System.Drawing.Point(63, 32)
        Me.connection_label1.Name = "connection_label1"
        Me.connection_label1.Size = New System.Drawing.Size(65, 13)
        Me.connection_label1.TabIndex = 5
        Me.connection_label1.Text = "ΣΥΝΔΕΣΗ 1"
        '
        'con_string1
        '
        Me.con_string1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.con_string1.Location = New System.Drawing.Point(134, 29)
        Me.con_string1.Name = "con_string1"
        Me.con_string1.Size = New System.Drawing.Size(618, 20)
        Me.con_string1.TabIndex = 0
        Me.con_string1.Text = "Server=server_ip;Port=5432;Userid=user_name;Database=db_db;password=db_pass$;Pool" & _
    "ing=true;MinPoolSize=1;MaxPoolSize=20;Timeout=15;SslMode=Disable"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(780, 402)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(772, 376)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ΠΑΡΑΣΤΑΤΙΚΑ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(772, 376)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ΡΥΘΜΙΣΕΙΣ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 402)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(788, 348)
        Me.Name = "MAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDI-ERP"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgv_sel_invoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_com1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partner_dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents export_btn As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents search_btn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents connection_label2 As System.Windows.Forms.Label
    Friend WithEvents connection_label1 As System.Windows.Forms.Label
    Friend WithEvents con_string1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents file_save_path As System.Windows.Forms.TextBox
    Friend WithEvents partner_afm_txt As System.Windows.Forms.TextBox
    Friend WithEvents con_string2 As System.Windows.Forms.TextBox
    Friend WithEvents dgvD As System.Windows.Forms.DataGridView
    Friend WithEvents dgvM As System.Windows.Forms.DataGridView
    Friend WithEvents partner_dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents partner_afm_label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents save_settings_btn As System.Windows.Forms.Button
    Friend WithEvents company_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents user_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents file_save_path2 As System.Windows.Forms.TextBox
    Friend WithEvents file_save_path1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents test_button As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents partner_id_txt As System.Windows.Forms.TextBox
    Friend WithEvents dgv_com1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_sel_invoices As System.Windows.Forms.DataGridView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents list_text As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents invoice_ids As System.Windows.Forms.TextBox
    Friend WithEvents test_lines_btn As System.Windows.Forms.Button
    Friend WithEvents exagogi As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents debug As System.Windows.Forms.CheckBox
    Friend WithEvents settings_access As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents admin_pass_txt As System.Windows.Forms.TextBox

End Class

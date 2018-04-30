
Imports System.Data
Imports System
Imports System.Web
Imports Npgsql
Imports NpgsqlTypes
Imports System.Windows.Forms
Imports System.Xml.Serialization
Imports System.IO
Imports C1
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Xml
Imports System.Deployment
Imports System.Text
Imports System.Globalization
Imports NPOI.XSSF.UserModel
Imports NPOI.HSSF.UserModel
Imports NPOI.SS.UserModel
Imports System.Reflection

Public Class MAIN
    Public xmld As XmlDocument
    Public nodelist As XmlNodeList
    Public DS900 As New DataSet
    Dim newTable As New DataTable
    Dim ds9001 As New DataSet
    Dim bs1 As New BindingSource
    Dim flag1 As Boolean = False
    Dim DSq As New DataSet("queerys")
    Dim bs As New BindingSource
    Dim editFlag As Boolean = False
    Dim deflection_dataset As New DataSet
    Dim ds As New DataSet
    Dim dsM As New DataSet
    Dim dsD As New DataSet
    Dim lds As New DataSet
    Dim pds As New DataSet
    Dim psds As New DataSet
    Private Sub EDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim versionNumber As Version
        Dim majorVersion As Integer = My.Application.Info.Version.Major
        Dim minorVersion As Integer = My.Application.Info.Version.Minor
        Dim buildNumber As Integer = My.Application.Info.Version.Build
        Dim majorRevision As Integer = My.Application.Info.Version.MajorRevision
        Dim minorRevision As Integer = My.Application.Info.Version.MinorRevision
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        Me.Text = Me.Text & " " & versionNumber.ToString
        file_save_path.Text = My.Settings.file_path.ToString
        file_save_path1.Text = My.Settings.file_path1.ToString
        file_save_path2.Text = My.Settings.file_path2.ToString
        user_id.Text = My.Settings.user_id.ToString
        con_string1.Text = My.Settings.con_string1.ToString
        company_id.Text = My.Settings.company_id.ToString
        con_string2.Text = My.Settings.con_string2.ToString
        debug.Checked = My.Settings.debug.ToString
        invoice_ids.Text = My.Settings.invoice_ids.ToString
        partner_id_txt.Text = My.Settings.partner_id.ToString
        admin_pass_txt.Text = My.Settings.admin_pass.ToString
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        load_partners()
        load_companies()
        getdata()
    End Sub
    Public Function GetCheckedRows1(
    ByVal GridView As DataGridView,
    ByVal ColumnName As String) As List(Of DataGridViewRow)
        Return _
            (
                From SubRows In
                    (
                        From Rows In GridView.Rows.Cast(Of DataGridViewRow)()
                        Where Not Rows.IsNewRow
                    ).ToList
                Where CBool(SubRows.Cells(ColumnName).Value) = True
            ).ToList
    End Function



    Public Sub getdata()

        dsM.Clear()
        dgvM.DataSource = Nothing
        dgvM.Rows.Clear()
        dgvM.Columns.Clear()
        Dim pgConnectionM As NpgsqlConnection = New NpgsqlConnection
        Dim pgCommandM As NpgsqlCommand = New NpgsqlCommand
        Dim pgConnectionStringM As String
        Dim sdaM As NpgsqlDataAdapter
        ds = New DataSet
        Try
            pgConnectionStringM = con_string1.Text
            pgConnectionM.ConnectionString = pgConnectionStringM
            pgConnectionM.Open()
        Catch ex As Exception
            If pgConnectionM.State <> ConnectionState.Open Then
                pgConnectionStringM = con_string2.Text
                pgConnectionM.ConnectionString = pgConnectionStringM
                pgConnectionM.Open()
            Else

            End If
        End Try
        If pgConnectionM.FullState = ConnectionState.Open Then
            pgCommandM.Connection = pgConnectionM
            pgCommandM.CommandType = CommandType.Text
            pgCommandM.CommandText = " SELECT   " & _
"             ai.id,   " & _
"             ai.comment,   " & _
"             ai.date_due,   " & _
"             ai.check_total,   " & _
"             ai.reference,   " & _
"             ai.payment_term, " & _
"             apt.name as payment_type_name,apt.x_payment_days, " & _
"             ai.number,  " & _
"    		  ai.x_ref_inv_number, " & _
"    		  to_char(ai.x_ref_inv_date, 'yyyyMMdd') as x_ref_inv_date, " & _
"             case when lpad(ai.number,3) like 'Πισ%' then 'ΠΙΣ' else lpad(ai.number,3)end as  edi_invoice_type,   " & _
"             case WHEN (split_part(ai.number, ' ', 1)) like 'Πισ%' then (split_part(ai.number, '.Τιμ', 2)) else (split_part(ai.number, ' ', 3)) end as edi_invoice_number,   " & _
"             case when  ltrim(rtrim(split_part(ai.number, '-', 2))) <> '' then ltrim(rtrim(split_part(ai.number, '-', 2))) else 'ΣΕΙΡΑ Α' end as edi_invoice_seira , " & _
"             ai.message_last_post,   " & _
"             ai.company_id,   " & _
"             ai.currency_id,   " & _
"             to_char(ai.create_date, 'yyyy/MM/dd') as edi_date,   " & _
"             to_char(ai.create_date, 'yyyyMMddHHmmss') as edi_datetime,  " & _
"             to_char(ai.create_date, 'yyyyMMdd HHmmss') as edi_datetime1,  " & _
"             to_char(ai.create_date, 'yyyyMMdd HH:mm:ss') as edi_datetime2,  " & _
"             ai.create_uid,   " & _
"             ai.fiscal_position,   " & _
"             ai.amount_untaxed,   " & _
"             ai.partner_bank_id,   " & _
"             ai.partner_id,   " & _
"             ai.supplier_invoice_number,   " & _
"             ai.reference_type,   " & _
"             ai.journal_id,   " & _
"             ai.amount_tax,   " & _
"             ai.state,   " & _
"             ai.move_id,   " & _
"             ai.type,   " & _
"             ai.internal_number,   " & _
"             ai.account_id,   " & _
"             ai.reconciled,   " & _
"             ai.residual,   " & _
"             ai.move_name,   " & _
"             ai.date_invoice,   " & _
"             ai.period_id,   " & _
"             ai.write_date,   " & _
"             ai.user_id,   " & _
"             ai.write_uid,   " & _
"             ai.origin,   " & _
"             ai.amount_total,   " & _
"             ai.name,   " & _
"             ai.sent,   " & _
"             ai.commercial_partner_id,   " & _
"             ai.section_id, " & _
"             ai.comment, " & _
"             to_char(ai.x_ref_inv_date, 'yyyyMMdd') as x_ref_inv_date, " & _
"             ai.x_ref_inv_number, " & _
"             ai.x_gln_delivery, " & _
" CASE " & _
" when x_gln_delivery = '1' then '9981060850000' " & _
" when x_gln_delivery = '2' then '9981060850020' " & _
" when x_gln_delivery = '3' then '9981060850037' " & _
" when x_gln_delivery = '4' then '9981060850044' " & _
" end  as gln_delivery, " & _
"  (round((ai.amount_total / ai.amount_untaxed),2)-1) as vat_amount, " & _
"         ai.x_stringfield1   " & _
"             FROM   " & _
"             public.account_invoice AS ai  " & _
"             left join account_payment_term as apt on ai.payment_term = apt.id " & _
"             where ai.create_date >= '" & dtp1.Text & " 00:00:00'" & _
"             and ai.create_date<= '" & dtp2.Text & " 23:59:59'" & _
"             and ai.state not in ('cancel') " & _
"             and ai.journal_id in (" & invoice_ids.Text & ") " & _
"             and ai.partner_id in (" & partner_id_txt.Text & ") " & _
"             order by ai.id ASC "




            sdaM = New NpgsqlDataAdapter(pgCommandM)
            sdaM.Fill(dsM)
            Dim dtM As DataTable
            dtM = dsM.Tables(0)
            Dim chk As New DataGridViewCheckBoxColumn(False)
            dgvM.Columns.Add(chk)
            chk.HeaderText = "ΕΠΙΛΟΓΗ"
            chk.Name = "selection"
            dgvM.DataSource = dtM

            If debug.CheckState = CheckState.Checked Then
                For i = 0 To dgvM.Columns.Count - 1
                    dgvM.Columns(i).HeaderText = dgvM.Columns(i).HeaderText & "_" & i
                Next
            Else
                For i = 0 To dgvM.Columns.Count - 1
                    dgvM.Columns(i).Visible = False
                Next
            End If




            With dgvM
                .Columns(0).Visible = True
                .Columns(0).HeaderText = "ΕΠΙΛΟΓΗ"
                .Columns(1).Visible = True
                .Columns(1).HeaderText = "ID"
                .Columns(9).Visible = True
                .Columns(9).HeaderText = "ΠΑΡΑΣΤΑΤΙΚΟ"
                .Columns(9).Width = 300
                .Columns(13).Visible = True
                .Columns(13).HeaderText = "AA ΠΑΡ/ΚΟΥ"
                .Columns(13).Width = 300
                .Columns(18).Visible = True
                .Columns(18).HeaderText = "ΗΜ ΕΚΔΟΣΗΣ"
                .Columns(18).Width = 200
                .Columns(18).DefaultCellStyle.Format = "yyyy/MM/dd"




            End With

            dgvM.ResumeLayout()
            dgvM.Refresh()

        Else
            MsgBox("pgConnectionM did not open successfully.") 
        End If
        pgConnectionM.Close()
    End Sub
    Public Sub getdata_lines()
        dsD.Clear()
        dgvD.DataSource = Nothing
        dgvD.Rows.Clear()
        dgvD.Columns.Clear()

        Dim pgConnectionD As NpgsqlConnection = New NpgsqlConnection
        Dim pgCommandD As NpgsqlCommand = New NpgsqlCommand
        Dim pgConnectionStringD As String
        Dim sdaD As NpgsqlDataAdapter
        ds = New DataSet
        Try
            pgConnectionStringD = con_string1.Text
            pgConnectionD.ConnectionString = pgConnectionStringD
            pgConnectionD.Open()
        Catch ex As Exception
            If pgConnectionD.State <> ConnectionState.Open Then
                pgConnectionStringD = con_string2.Text
                pgConnectionD.ConnectionString = pgConnectionStringD
                pgConnectionD.Open()
            Else

            End If
        End Try

        If pgConnectionD.FullState = ConnectionState.Open Then
            pgCommandD.Connection = pgConnectionD
            pgCommandD.CommandType = CommandType.Text



            pgCommandD.CommandText = "SELECT  " & _
"         ail.invoice_id ,   " & _
"         pp.default_code, " & _
"         ail.quantity,   " & _
"         'TEM' as uom_name, " & _
"         ail.price_unit,    " & _
"         ail.discount,  " & _
"         '0,00' AS allow_amount, " & _
"         '0,00' AS charge_amount,   " & _
"         to_char(ai.date_due, 'yyyyMMdd') as  expire_date,   " & _
"         ailtid.amount as vat_percent,   " & _
"         round((ail.price_subtotal * ailtid.amount),2) as vat_amount,   " & _
"         '0,00' as extra_tax_percent,   " & _
"         '0,00' as extra_tax_amount,  " & _
"         round(ail.price_subtotal,2) as net_amount, " & _
"         round(ail.price_subtotal * ailtid.amount,2) as tax_amount, " & _
"         round(ail.price_subtotal * (1 + ailtid.amount),2) as total_amount, " & _
"         '' as comments,   " & _
"         ail.x_stringfield2 as stringfield2,   " & _
"         ai.x_olympic_order as event_code,   " & _
"         pt.x_code_olympic as avis_code,   " & _
"         pt.uos_id,   " & _
"         uos.name,  " & _
"         ail.company_id,   " & _
"         pp.ean13,   " & _
"         pp.name_template,   " & _
"         ail.id as inv_l_id,   " & _
"         ail.origin,   " & _
"         ail.name, " & _
"         ai.id as inv_id,    " & _
"         ail.partner_id,   " & _
"         ai.x_stringfield1,   " & _
"         case  " & _
"         when ltrim(rtrim(split_part(ail.name, ']', 2))) <> '' THEN " & _
"         ltrim(rtrim(split_part(ail.name, ']', 2)))  " & _
"         Else  ail.name " & _
"         end as onoma_eidous  " & _
"         FROM   " & _
"         public.account_invoice_line AS ail   " & _
"         LEFT JOIN public.product_product AS pp ON ail.product_id = pp.id   " & _
"         LEFT JOIN public.product_template AS pt ON pp.product_tmpl_id = pt.id   " & _
"         LEFT JOIN public.product_taxes_rel AS ptr ON ptr.prod_id = pt.id   " & _
"         LEFT JOIN public.account_tax AS at ON ptr.tax_id = at.id   " & _
"         LEFT JOIN public.product_uom AS uos ON uos.id = pt.uos_id   " & _
"         LEFT JOIN public.account_invoice as ai ON ail.invoice_id = ai.id   " & _
"         LEFT JOIN public.account_invoice_line_tax AS ailt ON ailt.invoice_line_id = ail.id " & _
"         LEFT JOIN public.account_tax AS ailtid ON ailtid.id = ailt.tax_id " & _
"         WHERE   " & _
"         ail.invoice_id IN (" & list_text.Text & ") " & _
"         order by ail.invoice_id ASC "



            sdaD = New NpgsqlDataAdapter(pgCommandD)
            sdaD.Fill(dsD)
            Dim dtD As DataTable
            dtD = dsD.Tables(0)
            dgvD.DataSource = dtD
            If debug.CheckState = CheckState.Checked Then
                For i = 0 To dgvD.Columns.Count - 1
                    dgvD.Columns(i).HeaderText = dgvD.Columns(i).HeaderText & "_" & i
                Next
            Else
                For i = 0 To dgvD.Columns.Count - 1
                    dgvD.Columns(i).Visible = False
                Next
            End If
            With dgvD
                .Columns(0).Visible = True
                .Columns(0).HeaderText = "REF"
                .Columns(1).Visible = True
                .Columns(1).HeaderText = "SKU"
                .Columns(27).Visible = True
                .Columns(27).HeaderText = "ΠΕΡΙΓΡΑΦΗ"
                .Columns(27).Width = 300
                .Columns(2).Visible = True
                .Columns(2).HeaderText = "ΠΟΣΟΤΗΤΑ"
                .Columns(2).Width = 100
                .Columns(15).Visible = True
                .Columns(15).HeaderText = "ΤΕΛΙΚΗ ΤΙΜΗ"
                .Columns(15).Width = 100
                .Columns(8).DefaultCellStyle.Format = "yyyy/MM/dd"
                .Columns(17).Visible = True
                .Columns(17).HeaderText = "ΠΙΝΑΚΙΔΑ"
                .Columns(17).Width = 100
            End With
            dgvM.ResumeLayout()
            dgvM.Refresh()
            dgvD.ResumeLayout()
            dgvD.Refresh()
        Else
            MsgBox("pgConnectionD did not open successfully.")
        End If
        pgConnectionD.Close()
    End Sub

    Private Sub save_settings_btn_Click(sender As Object, e As EventArgs) Handles save_settings_btn.Click
        Try
            My.Settings.file_path = file_save_path.Text
            My.Settings.file_path1 = file_save_path1.Text
            My.Settings.file_path2 = file_save_path2.Text
            My.Settings.user_id = user_id.Text
            My.Settings.con_string1 = con_string1.Text.ToString
            My.Settings.company_id = company_id.Text.ToString
            My.Settings.invoice_ids = invoice_ids.Text.ToString
            My.Settings.partner_id = partner_id_txt.Text.ToString
            My.Settings.debug = debug.Checked.ToString
            My.Settings.admin_pass = admin_pass_txt.Text
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MsgBox("Οι ρυθμισεις αποθηκευτηκαν.", MsgBoxStyle.OkOnly) ' context.Response.Write("pgConnection did not open successfully.")
    End Sub
    Private Sub export_btn_Click(sender As Object, e As EventArgs) Handles export_btn.Click

        Dim pgConnection As NpgsqlConnection = New NpgsqlConnection
        Dim pgCommand As NpgsqlCommand = New NpgsqlCommand
        Dim pgConnectionString As String
        Dim sda As NpgsqlDataAdapter
        ds = New DataSet
        Try
            pgConnectionString = con_string1.Text
            pgConnection.ConnectionString = pgConnectionString
            pgConnection.Open()
        Catch ex As Exception
            If pgConnection.State <> ConnectionState.Open Then
                pgConnectionString = con_string2.Text
                pgConnection.ConnectionString = pgConnectionString
                pgConnection.Open()
            Else

            End If
        End Try
        If pgConnection.FullState = ConnectionState.Open Then
            pgCommand.Connection = pgConnection
            pgCommand.CommandType = CommandType.Text
            pgCommand.CommandText = " SELECT  " & _
                  "  product_product.default_code AS ΚΩΔΙΚΟΣ," & _
                  "  Sum(public.pos_order_line.qty) AS ΠΟΣΟΤΗΤΑ, " & _
                  "  round(AVG(public.product_template.list_price),2) AS ΤΙΜΗ_Μ_Μ_ΤΙΜΟΚΑΤΑΛΟΓΟΥ, " & _
                  "  round(AVG(public.pos_order_line.price_unit),2) AS ΤΙΜΗ_Μ_Μ, " & _
                  "  round(Sum(public.pos_order_line.price_subtotal),2) AS ΣΥΝΟΛΟ_ΧΩΡΙΣ_ΦΠΑ, " & _
                  "  round(Sum(public.pos_order_line.price_subtotal_incl),2) AS ΣΥΝΟΛΟ_ΜΕ_ΦΠΑ, " & _
                  "  ROUND( (sum(public.pos_order_line.price_subtotal_incl) - (sum(public.pos_order_line.price_subtotal))  ) ,2) AS ΣΥΝΟΛΟ_ΦΠΑ, " & _
                  "  count(public.pos_order_line.discount)AS ΚΙΝΗΣΕΙΣ," & _
                  "  round(((sum(public.pos_order_line.discount))/(count(public.pos_order_line.discount))),2) as ΕΚΠΤΩΣΕΙΣ," & _
                  "  (round((public.product_template.list_price)*((((public.account_tax.amount)*100)+100)/100),2 )) AS ΤΤ " & _
                  "  FROM " & _
                  "  public.pos_order " & _
                  "  INNER JOIN public.pos_order_line ON (public.pos_order_line.order_id = public.pos_order.id) " & _
                  "  INNER JOIN public.product_product ON (public.product_product.id = public.pos_order_line.product_id) " & _
                  "  INNER JOIN public.product_template ON (public.product_template.id = public.product_product.product_tmpl_id) " & _
                  "  INNER JOIN public.product_taxes_rel ON public.product_taxes_rel.prod_id = public.product_template.id " & _
                  "  INNER JOIN public.account_tax ON public.product_taxes_rel.tax_id = public.account_tax.id " & _
                  " INNER JOIN public.res_users ON public.pos_order.user_id = public.res_users.id " & _
                  "  WHERE  " & _
                  "  date(public.pos_order_line.write_date) = '" & dtp1.Text & "'" & _
                  "  and public.pos_order.company_id in (" & company_id.Text & ")" & _
                  "  and public.res_users.login in  (" & user_id.Text & ")" & _
                  "  GROUP BY " & _
                  "  public.product_product.default_code, " & _
                  "  product_template.list_price, " & _
                  "  account_tax.amount " & _
                  "  ORDER BY  " & _
                  "  public.product_product.default_code ASC "


            sda = New NpgsqlDataAdapter(pgCommand)
            sda.Fill(ds)
            Dim dt As DataTable
            dt = ds.Tables(0)
            dgv1.DataSource = dt
            dgv1.Refresh()
            Dim MyFile1 As New StreamWriter(file_save_path.Text & DateTime.Now.ToString("ddMMyyyy") & "_POS.txt") '("C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile.txt")
            Dim MyFile2 As New StreamWriter(file_save_path1.Text & DateTime.Now.ToString("ddMMyyyy") & "_POS_TMP" & ".txt") '"C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile2.txt")
            Dim MyFile3 As New StreamWriter(file_save_path2.Text & DateTime.Now.ToString("ddMMyyyy_hhmmss") & "_data_BCK" & ".txt") '"C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile2.txt")
            For i = 0 To dgv1.Rows.Count - 1

                'item1, "01" apla kodikos / 3
                'item2, imera / 9
                'item3, kodikos / 17
                'item4, posothta / 9
                'item5, timi monadas /11
                'item6, axia 11
                'item7, axia fpa / 8

                Dim item1, item2, item3, item4, item5, item6, item7 As String


                item1 = "01" 'dgv1.Rows(i).Cells(0).Value.ToString
                item2 = DateTime.Now.ToString("dd/MM/yy") '(Now.Date.ToShortDateString) 'dgv1.Rows(i).Cells(1).Value.ToString
                item3 = dgv1.Rows(i).Cells(0).Value.ToString


                ' ITEM 4 ###################################################################
                Dim str, str_r As String
                Dim pad As Char
                str = Replace(dgv1.Rows(i).Cells(1).Value.ToString, ",", ".")
                pad = "."c
                str_r = str.PadLeft(8, "0")

                Console.WriteLine(str.PadLeft(4, pad))
                Console.WriteLine(str.PadRight(3, pad))
                ' item4 = str.PadRight(9, "0")
                item4 = str_r
                ' ITEM 4 ###################################################################

                ' ITEM 5 ###################################################################
                Dim str5, str_r5 As String
                Dim pad5 As Char
                str5 = Replace(dgv1.Rows(i).Cells(9).Value.ToString, ",", ".")
                pad5 = "."c
                str_r5 = str5.PadLeft(8, "0")

                Console.WriteLine(str5.PadLeft(4, pad5))
                Console.WriteLine(str5.PadRight(3, pad5))
                ' item4 = str.PadRight(9, "0")
                item5 = str_r5
                ' ITEM 5 ###################################################################

                ' ITEM 6 ###################################################################
                Dim str6, str_r6 As String
                Dim pad6 As Char
                str6 = Replace(dgv1.Rows(i).Cells(4).Value.ToString, ",", ".")
                pad6 = "."c
                str_r6 = str6.PadLeft(10, "0")

                Console.WriteLine(str6.PadLeft(4, pad6))
                Console.WriteLine(str6.PadRight(3, pad6))
                ' item4 = str.PadRight(9, "0")
                item6 = str_r6
                ' ITEM 6 ###################################################################



                ' ITEM 7 ###################################################################
                Dim str7, str_r7 As String
                Dim pad7 As Char
                str7 = Replace(dgv1.Rows(i).Cells(6).Value.ToString, ",", ".")
                pad7 = "."c
                str_r7 = str7.PadLeft(8, "0")

                Console.WriteLine(str7.PadLeft(4, pad7))
                Console.WriteLine(str7.PadRight(3, pad7))
                ' item4 = str.PadRight(9, "0")
                item7 = str_r7
                ' ITEM 7 ###################################################################
                ' loop through records
                MyFile1.WriteLine(ToLen(item1, 3) & ToLen(item2, 9) & ToLen(item3, 17) & ToLen(item4, 9) & ToLen(item5, 11) & ToLen(item6, 11) & ToLen(item7, 8))
                MyFile2.WriteLine(ToLen(item1, 3) & ToLen(item2, 9) & ToLen(item3, 17) & ToLen(item4, 9) & ToLen(item5, 11) & ToLen(item6, 11) & ToLen(item7, 8))

                ' For r = 0 To 25
                MyFile3.Write(ToLen_edi(item1, 3))
                MyFile3.Write(ToLen_edi(item2, 9))
                MyFile3.Write(ToLen_edi(item3, 17))
                MyFile3.Write(ToLen_edi(item4, 9))
                MyFile3.Write(ToLen_edi(item5, 11))
                MyFile3.Write(ToLen_edi(item6, 11))
                MyFile3.WriteLine(ToLen_edi(item7, 8))
                ' loop through records
            Next
            MyFile1.Close()
            MyFile2.Close()
            MyFile3.Close()
            ds.Dispose()

        Else
            MsgBox("pgConnection did not open successfully.")
        End If

        pgConnection.Close()
        MessageBox.Show("Τα Αρχεια δημιουργηθηκαν", "ΚΑΤΑΣΤΑΣΗ ΑΡΧΕΙΩΝ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

    End Sub
    Private Function ToLen(ByRef strLen As String, ByRef intLen As Integer) As String

        Dim L As Integer = Len(strLen)
        If L < intLen Then
            Return strLen & Microsoft.VisualBasic.Strings.Space(intLen - L)
        ElseIf L = intLen Then
            Return strLen
        Else
            Return Microsoft.VisualBasic.Strings.Left(strLen, intLen)
        End If

    End Function
    Private Function ToLen_edi(text As String, length As Integer)
        If text.Length > length Then
            Return text.Substring(0, length)
        Else
            Return text.PadRight(length)
        End If
    End Function
    Public Sub load_partners()


        partner_dgv1.DataSource = Nothing
        partner_dgv1.Rows.Clear()
        partner_dgv1.Columns.Clear()


        Dim pgConnection As NpgsqlConnection = New NpgsqlConnection
        Dim pgCommand As NpgsqlCommand = New NpgsqlCommand
        Dim pgConnectionString As String
        Dim sda As NpgsqlDataAdapter


        ds = New DataSet


        Try
            pgConnectionString = con_string1.Text
            pgConnection.ConnectionString = pgConnectionString
            pgConnection.Open()
        Catch ex As Exception
            If pgConnection.State <> ConnectionState.Open Then
                pgConnectionString = con_string2.Text
                pgConnection.ConnectionString = pgConnectionString
                pgConnection.Open()
            Else

            End If
        End Try




        If pgConnection.FullState = ConnectionState.Open Then

            pgCommand.Connection = pgConnection
            pgCommand.CommandType = CommandType.Text



            pgCommand.CommandText = " SELECT" & _
"            rp.id," & _
"            rp.name, " & _
"            rp.ean13," & _
"            rp.company_id," & _
"            rp.display_name," & _
"            rp.customer," & _
"            rp.supplier," & _
"            rp.is_company," & _
"            rp.active," & _
"            rp.phone," & _
"            rp.mobile," & _
"            rp.vat" & _
"            FROM" & _
"            public.res_partner AS rp" & _
"            WHERE" & _
"           rp.id in  (" & partner_id_txt.Text & ")"

            sda = New NpgsqlDataAdapter(pgCommand)
            sda.Fill(ds)
            Dim dt As DataTable
            dt = ds.Tables(0)
            Dim chk As New DataGridViewCheckBoxColumn(False)
            partner_dgv1.Columns.Add(chk)
            chk.HeaderText = "ΕΠΙΛΟΓΗ"
            chk.Name = "chk"
            partner_dgv1.DataSource = dt
            partner_dgv1.Refresh()
            ds.Dispose()
        Else
            MsgBox("pgConnection did not open successfully.") ' context.Response.Write("pgConnection did not open successfully.")
        End If

        pgConnection.Close()

    End Sub
    Public Sub load_companies()

        Dim pgConnection As NpgsqlConnection = New NpgsqlConnection
        Dim pgCommand As NpgsqlCommand = New NpgsqlCommand
        Dim pgConnectionString As String
        Dim sda As NpgsqlDataAdapter
        ds = New DataSet
        Try
            pgConnectionString = con_string1.Text
            pgConnection.ConnectionString = pgConnectionString
            pgConnection.Open()
        Catch ex As Exception
            If pgConnection.State <> ConnectionState.Open Then
                pgConnectionString = con_string2.Text
                pgConnection.ConnectionString = pgConnectionString
                pgConnection.Open()
            Else

            End If
        End Try
        If pgConnection.FullState = ConnectionState.Open Then
            pgCommand.Connection = pgConnection
            pgCommand.CommandType = CommandType.Text
            pgCommand.CommandText = "          SELECT   " & _
"          cmp.id as cmp_id,   " & _
"          rp.vat,   " & _
"          cmp.name,   " & _
"          cmp.partner_id,   " & _
"          cmp.currency_id,   " & _
"          cmp.rml_footer,   " & _
"          cmp.create_date,   " & _
"          cmp.rml_header,   " & _
"          cmp.rml_paper_format,   " & _
"          cmp.write_uid,   " & _
"          cmp.font,   " & _
"          cmp.account_no,   " & _
"          cmp.parent_id,   " & _
"          cmp.email,   " & _
"          cmp.create_uid,   " & _
"          cmp.custom_footer,   " & _
"          cmp.phone,   " & _
"          cmp.rml_header2,   " & _
"          cmp.rml_header3,   " & _
"          cmp.write_date,   " & _
"          cmp.rml_header1,   " & _
"          cmp.company_registry,   " & _
"          cmp.paperformat_id,   " & _
"          cmp.expense_currency_exchange_account_id,   " & _
"          cmp.expects_chart_of_accounts,   " & _
"          cmp.overdue_msg,   " & _
"          cmp.tax_calculation_rounding_method,   " & _
"          cmp.income_currency_exchange_account_id,   " & _
"          cmp.internal_transit_location_id,   " & _
"          cmp.propagation_minimum_delta,   " & _
"          cmp.sale_note,   " & _
"          cmp.security_lead,   " & _
"          cmp.vat_check_vies,   " & _
"          cmp.po_lead,   " & _
"          rp.id,   " & _
"          rp.name,   " & _
"          rp.company_id,   " & _
"          rp.comment,   " & _
"          rp.ean13,   " & _
"          rp.create_date,   " & _
"          rp.color,   " & _
"          rp.date,   " & _
"          rp.street,   " & _
"          rp.city,   " & _
"          rp.display_name,   " & _
"          rp.zip,   " & _
"          rp.title,   " & _
"          rp.function,   " & _
"          rp.country_id,   " & _
"          rp.parent_id,   " & _
"          rp.supplier,   " & _
"          rp.ref,   " & _
"          rp.email,   " & _
"          rp.is_company,   " & _
"          rp.website,   " & _
"          rp.customer,   " & _
"          rp.fax,   " & _
"          rp.street2,   " & _
"          rp.employee,   " & _
"          rp.credit_limit,   " & _
"          rp.write_date,   " & _
"          rp.active,   " & _
"          rp.tz,   " & _
"          rp.write_uid,   " & _
"          rp.lang,   " & _
"          rp.create_uid,   " & _
"          rp.phone,   " & _
"          rp.mobile,   " & _
"          rp.type,   " & _
"          rp.use_parent_address,   " & _
"          rp.user_id,   " & _
"          rp.birthdate,   " & _
"          rp.state_id,   " & _
"          rp.commercial_partner_id,   " & _
"          rp.notify_email,   " & _
"          rp.message_last_post,   " & _
"          rp.opt_out,   " & _
"          rp.section_id,   " & _
"          rp.signup_type,   " & _
"          rp.signup_expiration,   " & _
"          rp.signup_token,   " & _
"          rp.calendar_last_notif_ack,   " & _
"          rp.last_reconciliation_date,   " & _
"          rp.debit_limit,   " & _
"          rp.vat_subjected " & _
"          FROM   " & _
"          res_company AS cmp   " & _
"          LEFT JOIN public.res_partner AS rp ON rp.id = cmp.partner_id   " & _
"          where cmp.id in ( " & company_id.Text & " )   " & _
"       order by cmp.id ASC    "

            sda = New NpgsqlDataAdapter(pgCommand)
            sda.Fill(ds)
            Dim dt As DataTable
            dt = ds.Tables(0)
            Dim chk As New DataGridViewCheckBoxColumn(False)
            partner_dgv1.Columns.Add(chk)
            chk.HeaderText = "ΕΠΙΛΟΓΗ"
            chk.Name = "chk"
            dgv_com1.DataSource = dt
            dgv_com1.Refresh()
            ds.Dispose()
        Else
            MsgBox("pgConnection did not open successfully.")
        End If

        pgConnection.Close()

    End Sub


    Private Sub test_button_Click(sender As Object, e As EventArgs) Handles test_button.Click

        Dim pgConnection As NpgsqlConnection = New NpgsqlConnection
        Dim pgCommand As NpgsqlCommand = New NpgsqlCommand
        Dim pgConnectionString As String
        Dim sda As NpgsqlDataAdapter
        ds = New DataSet
        Try
            pgConnectionString = con_string1.Text
            pgConnection.ConnectionString = pgConnectionString
            pgConnection.Open()
        Catch ex As Exception
            If pgConnection.State <> ConnectionState.Open Then
                pgConnectionString = con_string2.Text
                pgConnection.ConnectionString = pgConnectionString
                pgConnection.Open()
            Else

            End If
        End Try

        If pgConnection.FullState = ConnectionState.Open Then

            pgCommand.Connection = pgConnection
            pgCommand.CommandType = CommandType.Text



            pgCommand.CommandText = " SELECT  " & _
                  "  product_product.default_code AS ΚΩΔΙΚΟΣ," & _
                  "  Sum(public.pos_order_line.qty) AS ΠΟΣΟΤΗΤΑ, " & _
                  "  round(AVG(public.product_template.list_price),2) AS ΤΙΜΗ_Μ_Μ_ΤΙΜΟΚΑΤΑΛΟΓΟΥ, " & _
                  "  round(AVG(public.pos_order_line.price_unit),2) AS ΤΙΜΗ_Μ_Μ, " & _
                  "  round(Sum(public.pos_order_line.price_subtotal),2) AS ΣΥΝΟΛΟ_ΧΩΡΙΣ_ΦΠΑ, " & _
                  "  round(Sum(public.pos_order_line.price_subtotal_incl),2) AS ΣΥΝΟΛΟ_ΜΕ_ΦΠΑ, " & _
                  "  ROUND( (sum(public.pos_order_line.price_subtotal_incl) - (sum(public.pos_order_line.price_subtotal))  ) ,2) AS ΣΥΝΟΛΟ_ΦΠΑ, " & _
                  "  count(public.pos_order_line.discount)AS ΚΙΝΗΣΕΙΣ," & _
                  "  round(((sum(public.pos_order_line.discount))/(count(public.pos_order_line.discount))),2) as ΕΚΠΤΩΣΕΙΣ," & _
                  "  (round((public.product_template.list_price)*((((public.account_tax.amount)*100)+100)/100),2 )) AS ΤΤ " & _
                  "  FROM " & _
                  "  public.pos_order " & _
                  "  INNER JOIN public.pos_order_line ON (public.pos_order_line.order_id = public.pos_order.id) " & _
                  "  INNER JOIN public.product_product ON (public.product_product.id = public.pos_order_line.product_id) " & _
                  "  INNER JOIN public.product_template ON (public.product_template.id = public.product_product.product_tmpl_id) " & _
                  "  INNER JOIN public.product_taxes_rel ON public.product_taxes_rel.prod_id = public.product_template.id " & _
                  "  INNER JOIN public.account_tax ON public.product_taxes_rel.tax_id = public.account_tax.id " & _
                  " INNER JOIN public.res_users ON public.pos_order.user_id = public.res_users.id " & _
                  "  WHERE  " & _
                  "  date(public.pos_order_line.write_date) = '" & dtp1.Text & "'" & _
                  "  and public.pos_order.company_id in (" & company_id.Text & ")" & _
                  "  and public.res_users.login in  (" & user_id.Text & ")" & _
                  "  GROUP BY " & _
                  "  public.product_product.default_code, " & _
                  "  product_template.list_price, " & _
                  "  account_tax.amount " & _
                  "  ORDER BY  " & _
                  "  public.product_product.default_code ASC "



            sda = New NpgsqlDataAdapter(pgCommand)
            sda.Fill(ds)
            Dim dt As DataTable
            dt = ds.Tables(0)
            dgv1.DataSource = dt
            dgv1.Refresh()

            Dim MyFile1 As New StreamWriter(file_save_path.Text & DateTime.Now.ToString("ddMMyyyy") & "_POS.txt") '("C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile.txt")
            Dim MyFile2 As New StreamWriter(file_save_path1.Text & DateTime.Now.ToString("ddMMyyyy") & "_POS_TMP" & ".txt") '"C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile2.txt")
            Dim MyFile3 As New StreamWriter(file_save_path2.Text & DateTime.Now.ToString("ddMMyyyy_hhmmss") & "_data_BCK" & ".txt") '"C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile2.txt")

            For i = 0 To dgv1.Rows.Count - 1




                'item1, "01" apla kodikos / 3
                'item2, imera / 9
                'item3, kodikos / 17
                'item4, posothta / 9
                'item5, timi monadas /11
                'item6, axia 11
                'item7, axia fpa / 8

                Dim item1, item2, item3, item4, item5, item6, item7 As String


                item1 = "01"
                item2 = DateTime.Now.ToString("dd/MM/yy")
                item3 = dgv1.Rows(i).Cells(0).Value.ToString


                ' ITEM 4 ###################################################################
                Dim str, str_r As String
                Dim pad As Char
                str = Replace(dgv1.Rows(i).Cells(1).Value.ToString, ",", ".")
                pad = "."c
                str_r = str.PadLeft(8, "0")

                Console.WriteLine(str.PadLeft(4, pad))
                Console.WriteLine(str.PadRight(3, pad))
                ' item4 = str.PadRight(9, "0")
                item4 = str_r
                ' ITEM 4 ###################################################################

                ' ITEM 5 ###################################################################
                Dim str5, str_r5 As String
                Dim pad5 As Char
                str5 = Replace(dgv1.Rows(i).Cells(9).Value.ToString, ",", ".")
                pad5 = "."c
                str_r5 = str5.PadLeft(8, "0")

                Console.WriteLine(str5.PadLeft(4, pad5))
                Console.WriteLine(str5.PadRight(3, pad5))
                ' item4 = str.PadRight(9, "0")
                item5 = str_r5
                ' ITEM 5 ###################################################################

                ' ITEM 6 ###################################################################
                Dim str6, str_r6 As String
                Dim pad6 As Char
                str6 = Replace(dgv1.Rows(i).Cells(4).Value.ToString, ",", ".")
                pad6 = "."c
                str_r6 = str6.PadLeft(10, "0")

                Console.WriteLine(str6.PadLeft(4, pad6))
                Console.WriteLine(str6.PadRight(3, pad6))
                ' item4 = str.PadRight(9, "0")
                item6 = str_r6
                ' ITEM 6 ###################################################################



                ' ITEM 7 ###################################################################
                Dim str7, str_r7 As String
                Dim pad7 As Char
                str7 = Replace(dgv1.Rows(i).Cells(6).Value.ToString, ",", ".")
                pad7 = "."c
                str_r7 = str7.PadLeft(8, "0")

                Console.WriteLine(str7.PadLeft(4, pad7))
                Console.WriteLine(str7.PadRight(3, pad7))
                ' item4 = str.PadRight(9, "0")
                item7 = str_r7
                ' ITEM 7 ###################################################################
                ' loop through records
                MyFile1.WriteLine(ToLen(item1, 3) & ToLen(item2, 9) & ToLen(item3, 17) & ToLen(item4, 9) & ToLen(item5, 11) & ToLen(item6, 11) & ToLen(item7, 8))
                MyFile2.WriteLine(ToLen(item1, 3) & ToLen(item2, 9) & ToLen(item3, 17) & ToLen(item4, 9) & ToLen(item5, 11) & ToLen(item6, 11) & ToLen(item7, 8))
                MyFile3.Write(ToLen_edi(item1, 3))
                MyFile3.Write(ToLen_edi(item2, 9))
                MyFile3.Write(ToLen_edi(item3, 17))
                MyFile3.Write(ToLen_edi(item4, 9))
                MyFile3.Write(ToLen_edi(item5, 11))
                MyFile3.Write(ToLen_edi(item6, 11))
                MyFile3.WriteLine(ToLen_edi(item7, 8))

            Next
            MyFile1.Close()
            MyFile2.Close()
            MyFile3.Close()
            ds.Dispose()
            ' context.Response.Write("</table>")
        Else
            MsgBox("pgConnection did not open successfully.")
        End If

        pgConnection.Close()
        MessageBox.Show("Τα Αρχεια δημιουργηθηκαν", "ΚΑΤΑΣΤΑΣΗ ΑΡΧΕΙΩΝ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

    End Sub
    Private Sub dgv_sel_invoices_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_sel_invoices.CurrentCellDirtyStateChanged
      
        RemoveHandler dgv_sel_invoices.CurrentCellDirtyStateChanged,
            AddressOf dgv_sel_invoices_CurrentCellDirtyStateChanged
        If TypeOf dgv_sel_invoices.CurrentCell Is DataGridViewCheckBoxCell Then
            dgv_sel_invoices.EndEdit()
            Dim Checked As Boolean = CType(dgv_sel_invoices.CurrentCell.Value, Boolean)
            If Checked Then
                ListBox1.Items.Add(dgv_sel_invoices.CurrentRow.Cells(1).Value.ToString)
            Else
                ListBox1.Items.Remove(dgv_sel_invoices.CurrentRow.Cells(1).Value.ToString)
            End If
        End If

        AddHandler dgv_sel_invoices.CurrentCellDirtyStateChanged,
            AddressOf dgv_sel_invoices_CurrentCellDirtyStateChanged
        '  End Sub
    End Sub
    Private Sub dgvM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvM.CellContentClick
        Dim Data As New List(Of String)
        list_text.Text = ""
        For Each r As DataGridViewRow In dgvM.Rows


            Dim Checked As Boolean = CType(r.Cells(0).Value, Boolean)
            If Checked Then

                Data.Add("'" & r.Cells(1).Value & "'")

            Else
                Data.Remove("'" & r.Cells(1).Value & "'")

            End If


        Next

        If Data.Count > 0 Then
            Dim strRes = String.Join(",", Data.ToArray)

            list_text.Text = strRes
            getdata_lines()
        End If

    End Sub
    Private Sub dgvM_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvM.CurrentCellDirtyStateChanged

        RemoveHandler dgvM.CurrentCellDirtyStateChanged,
    AddressOf dgvM_CurrentCellDirtyStateChanged



        If TypeOf dgvM.CurrentCell Is DataGridViewCheckBoxCell Then
            dgvM.EndEdit()
            Dim Checked As Boolean = CType(dgvM.CurrentCell.Value, Boolean)
            If Checked Then
                ListBox1.Items.Add(dgvM.CurrentRow.Cells(1).Value.ToString)

            Else
                ListBox1.Items.Remove(dgvM.CurrentRow.Cells(1).Value.ToString)
            End If
        End If


        AddHandler dgvM.CurrentCellDirtyStateChanged,
            AddressOf dgvM_CurrentCellDirtyStateChanged
    End Sub
    Private Sub test_lines_btn_Click(sender As Object, e As EventArgs) Handles test_lines_btn.Click
        getdata_lines()


    End Sub

    Private Sub exagogi_Click(sender As Object, e As EventArgs) Handles exagogi.Click
        '
        export_invoices()

    End Sub


    Public Sub export_invoices()
        '1 	Υ	Αριθμός εγγραφής [ref_number]-13
        '2 	Υ (ΣΤ)	ΑΦΜ Προμηθευτή [afm_supplier] -  dgv_com1.Rows(0).Cells(1).Value.ToString
        '3 	Υ	ΑΦΜ Λιανέμπορου[afm_retailer] -  partner_dgv1.Rows(0).Cells(12).Value.ToString
        '4	Π	Υποκατάστημα προμηθευτή [GLN_order_party]
        '5	Υ	Τύπος παραστατικού [inv_type] 
        '6	Υ	Σειρά Παραστατικού [inv_sec]
        '7	Υ	Αριθμός Παραστατικού [inv_number]
        '8	Υ	Ημερομηνία έκδοσης παραστατικού [inv_date]
        '9	Υ	Τοποθεσία Παράδοσης [GLN_Delivery]
        '10	Π	Ημερομηνία παράδοσης εμπορευμάτων [delivery_date]
        '11: Π	Αριθμός Αντίστοιχης Παραγγελίας (κωδικός έγκρισης) [order_num]
        '12	Υ (ΧΡ)	Σειρά Αντίστοιχου Παραστατικού [ref_inv_seq]
        '13		Αριθμός Αντίστοιχου Παραστατικού [ref_inv_number]
        '14		Ημερομηνία Αντίστοιχου Παραστατικού [ref_inv_date]
        '15	Π	Τρόπος πληρωμής [payment_type]
        '16	Π	Περιγραφή Όρων πληρωμής [payment_terms]
        '17	Π	Αριθμός Ημερών για Πληρωμή [payment_days]
        '18	Υ (ΧΡ)	Ποσοστό άλλων εκπτώσεων [oth_allow_percent]
        '19	Υ (ΧΡ)	Αξία άλλων εκπτώσεων [oth_allow_amount]
        '20	Υ (ΧΡ)	Ποσοστό άλλων Επιβαρύνσεων [oth_charges_percent]
        '21	Υ (ΧΡ)	Αξία άλλων επιβαρύνσεων [oth_charges_amount]
        '22	Υ (ΔΥ)	Ποσοστό ΦΠΑ 1 [vat_rate]
        '23	Υ (ΔΥ)	Φορολογούμενο Ποσό 1 [taxable_amount]
        '24	Υ (ΔΥ)	ΑξίαΦΠΑ 1 [amount_per_vat]
        '25	Υ (ΔΥ)	Ποσοστό ΦΠΑ 2 [vat_rate]
        '26	Υ (ΔΥ)	Φορολογούμενο Ποσό 2 [taxable_amount]
        '27	Υ (ΔΥ)	ΑξίαΦΠΑ 2 [amount_per_vat]
        '28	Υ (ΔΥ)	Ποσοστό ΦΠΑ 3 [vat_rate]
        '29	Υ (ΔΥ)	ΦορολογούμενοΠοσό 3  [taxable_amount]
        '30	Υ (ΔΥ)	Αξία ΦΠΑ 3 [amount_per_vat]
        '31	Π	Προμήθεια [commission_amount]
        '32	Υ (ΔΥ)	ΣυνολικόΠοσόΠληρωμής[total_pay_amount]
        '33	Π	Σχόλια [comments]
        '34	Π	Όνομα φορολογικού αρχείου [message_ref]
        '35	Π	Αριθμός Πινακίδας {StringField1}



        For Each r As DataGridViewRow In dgvM.Rows

            ListBox1.Items.Clear()
            Dim Checked As Boolean = CType(r.Cells(0).Value, Boolean)
            If Checked Then
                Dim MyFile3 As New StreamWriter(file_save_path2.Text & DateTime.Now.ToString("yyyyMMddhhmmss_") & r.Cells(1).Value.ToString & "_all" & ".txt") '"C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile2.txt")




                If Checked Then


                    Dim MyFile1 As New StreamWriter(file_save_path.Text & "Invoice_H_" & DateTime.Now.ToString("yyyyMMdd_") & r.Cells(1).Value.ToString & ".txt") '("C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile.txt")
                    Dim MyFile1_comma As New StreamWriter(file_save_path2.Text & "Invoice_H_" & DateTime.Now.ToString("yyyyMMdd_") & r.Cells(1).Value.ToString & ".csv") '("C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile.txt")
                    Dim item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 As String
                    Dim item11, item12, item13, item14, item15, item16, item17, item18, item19, item20 As String
                    Dim item21, item22, item23, item24, item25, item26, item27, item28, item29, item30 As String
                    Dim item31, item32, item33, item34, item35 As String


                    item1 = r.Cells(1).Value.ToString
                    item2 = dgv_com1.Rows(0).Cells(1).Value.ToString
                    item3 = partner_dgv1.Rows(0).Cells(12).Value.ToString
                    item4 = "" '"GLN_order_party"
                    item5 = r.Cells(12).Value.ToString '"inv_type"
                    item6 = r.Cells(14).Value.ToString '"inv_sec"
                    item7 = r.Cells(13).Value.ToString ' "inv_number"
                    item8 = r.Cells(11).Value.ToString.Replace("/", "").PadLeft(8)
                    item9 = r.Cells(54).Value.ToString '"GLN_Delivery"
                    item10 = r.Cells(18).Value.ToString.Replace("/", "").PadLeft(8) '"delivery_date"
                    item11 = r.Cells(5).Value.ToString
                    item12 = "-" '"ref_inv_seq"
                    item13 = r.Cells(51).Value.ToString '"ref_inv_number"
                    item14 = r.Cells(10).Value.ToString.Replace("/", "").PadLeft(8) '"ref_inv_date"
                    item15 = r.Cells(6).Value.ToString '"1"
                    item16 = r.Cells(7).Value.ToString '"payment_terms"
                    item17 = r.Cells(8).Value.ToString '"payment_days"
                    item18 = "0,00" '"oth_allow_percent"
                    item19 = "0,00" '"oth_allow_amount"
                    item20 = "0,00" '"oth_charges_percent"
                    item21 = "0,00" '"oth_charges_amount"
                    item22 = r.Cells(55).Value.ToString '"vat_rate"
                    item23 = r.Cells(24).Value.ToString 'taxable_amount1
                    item24 = r.Cells(30).Value.ToString 'amount_per_vat1
                    item25 = "0,00" '"vat_rate2"
                    item26 = "0,00" '"taxable_amount2"
                    item27 = "0,00" '"amount_per_vat2"
                    item28 = "0,00" '"vat_rate3"
                    item29 = "0,00" '"taxable_amount3"
                    item30 = "0,00" '"amount_per_vat3"
                    item31 = "0,00" '"commission_amount"
                    item32 = r.Cells(45).Value.ToString 'total_pay_amount
                    item33 = r.Cells(2).Value.ToString '"comments"
                    item34 = "" '"Όνομα φορολογικού αρχείου [message_ref]"
                    item35 = r.Cells(56).Value.ToString  '"Αριθμός Πινακίδας {StringField1}"
                    MyFile1.WriteLine(item1 & vbTab & _
                                      item2 & vbTab & _
                                      item3 & vbTab & _
                                      item4 & vbTab & _
                                      item5 & vbTab & _
                                      item6 & vbTab & _
                                      item7 & vbTab & _
                                      item8 & vbTab & _
                                      item9 & vbTab & _
                                      item10 & vbTab & _
                                      item11 & vbTab & _
                                      item12 & vbTab & _
                                      item13 & vbTab & _
                                      item14 & vbTab & _
                                      item15 & vbTab & _
                                      item16 & vbTab & _
                                      item17 & vbTab & _
                                      item18 & vbTab & _
                                      item19 & vbTab & _
                                      item20 & vbTab & _
                                      item21 & vbTab & _
                                      item22 & vbTab & _
                                      item23 & vbTab & _
                                      item24 & vbTab & _
                                      item25 & vbTab & _
                                      item26 & vbTab & _
                                      item27 & vbTab & _
                                      item28 & vbTab & _
                                      item29 & vbTab & _
                                      item30 & vbTab & _
                                      item31 & vbTab & _
                                      item32 & vbTab & _
                                      item33 & vbTab & _
                                      item34 & vbTab & _
                                      item35 & vbTab)



                    MyFile1_comma.Write(item1 & ";" & _
                                      item2 & ";" & _
                                      item3 & ";" & _
                                      item4 & ";" & _
                                      item5 & ";" & _
                                      item6 & ";" & _
                                      item7 & ";" & _
                                      item8 & ";" & _
                                      item9 & ";" & _
                                      item10 & ";" & _
                                      item11 & ";" & _
                                      item12 & ";" & _
                                      item13 & ";" & _
                                      item14 & ";" & _
                                      item15 & ";" & _
                                      item16 & ";" & _
                                      item17 & ";" & _
                                      item18 & ";" & _
                                      item19 & ";" & _
                                      item20 & ";" & _
                                      item21 & ";" & _
                                      item22 & ";" & _
                                      item23 & ";" & _
                                      item24 & ";" & _
                                      item25 & ";" & _
                                      item26 & ";" & _
                                      item27 & ";" & _
                                      item28 & ";" & _
                                      item29 & ";" & _
                                      item30 & ";" & _
                                      item31 & ";" & _
                                      item32 & ";" & _
                                      item33 & ";" & _
                                      item34 & ";" & _
                                      item35)











                    MyFile3.WriteLine(item1 & vbTab & _
                      item2 & vbTab & _
                      item3 & vbTab & _
                      item4 & vbTab & _
                      item5 & vbTab & _
                      item6 & vbTab & _
                      item7 & vbTab & _
                      item8 & vbTab & _
                      item9 & vbTab & _
                      item10 & vbTab & _
                      item11 & vbTab & _
                      item12 & vbTab & _
                      item13 & vbTab & _
                      item14 & vbTab & _
                      item15 & vbTab & _
                      item16 & vbTab & _
                      item17 & vbTab & _
                      item18 & vbTab & _
                      item19 & vbTab & _
                      item20 & vbTab & _
                      item21 & vbTab & _
                      item22 & vbTab & _
                      item23 & vbTab & _
                      item24 & vbTab & _
                      item25 & vbTab & _
                      item26 & vbTab & _
                      item27 & vbTab & _
                      item28 & vbTab & _
                      item29 & vbTab & _
                      item30 & vbTab & _
                      item31 & vbTab & _
                      item32 & vbTab & _
                      item33 & vbTab & _
                      item34 & vbTab & _
                      item35 & vbCrLf)

                    MyFile1.Close()
                    MyFile1_comma.Close()




                    '##############    LINES    ###############################

                    '1	Υ	Αριθμός εγγραφής [ref_number]
                    '2	Υ	Κωδικός προϊόντος προμηθευτή [sku]
                    '3	Υ	Ποσότητα παράδοσης [delivery_qty]
                    '4	Υ (ΣΤ)	Μονάδα μέτρησης της ποσότητας παράδοσης [delivery_mu]
                    '5	Υ	Τιμή μονάδος[price]
                    '6	Υ (ΧΡ)	Ποσό έκπτωσης [allow_amount]
                    '7	Υ (ΧΡ)	Ποσό επιβάρυνσης [charge_amount]
                    '8	Π	Ημερομηνία Λήξης υπηρεσίας [expire_date]
                    '9	Υ	Ποσοστό ΦΠΑ [vat_percent]
                    '10	Υ(ΔΥ)	Αξία ΦΠΑ [vat_amount]
                    '11	Υ (ΧΡ)	Ποσοστό άλλων φόρων [tax_percent]
                    '12	Υ (ΧΡ)	Αξία άλλων φόρων[tax_amount]
                    '13	Π	Συνολική τελική αξία προϊόντος [final_amount]
                    '14	Π	Σχόλια [comments]'
                    '15	Υ (ΧΡ	Aριθμός πινακίδας [StringField1]
                    '16	Y	Κωδικός συμβάντος
                    '17	Y	Κωδικός Προϊόντος Avis

                    Dim litem1, litem2, litem3, litem4, litem5, litem6, litem7, litem8, litem9, litem10 As String
                    Dim litem11, litem12, litem13, litem14, litem15, litem16, litem17, litem18 As String
                    Dim MyFile2 As New StreamWriter(file_save_path1.Text & "Invoice_L_" & DateTime.Now.ToString("yyyyMMdd_") & r.Cells(1).Value.ToString & ".txt") '"C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile2.txt")
                    Dim MyFile2_comma As New StreamWriter(file_save_path2.Text & "Invoice_L_" & DateTime.Now.ToString("yyyyMMdd_") & r.Cells(1).Value.ToString & ".csv") '"C:\akronis\LMD_ADV_BRI_ODOO\LC_DATA\MyFile2.txt")

                    list_text.Text = ""

                    Dim Data As New List(Of String)
                    Dim Checked1 As Boolean = CType(r.Cells(0).Value, Boolean)
                    If Checked1 Then
                        Data.Add("'" & r.Cells(1).Value & "'")
                    Else
                        Data.Remove("'" & r.Cells(1).Value & "'")
                    End If
                    If Data.Count > 0 Then
                        Dim strRes = String.Join(",", Data.ToArray)
                        list_text.Text = strRes
                    End If

                    getdata_lines()


                    Try


                        For i = 0 To dgvD.Rows.Count - 1

                            litem1 = dgvD.Rows(i).Cells(0).Value.ToString
                            litem2 = dgvD.Rows(i).Cells(1).Value.ToString
                            litem3 = dgvD.Rows(i).Cells(2).Value.ToString
                            litem4 = dgvD.Rows(i).Cells(3).Value.ToString
                            litem5 = dgvD.Rows(i).Cells(4).Value.ToString
                            litem6 = dgvD.Rows(i).Cells(5).Value.ToString

                            litem7 = dgvD.Rows(i).Cells(6).Value.ToString
                            litem8 = dgvD.Rows(i).Cells(7).Value.ToString
                            litem9 = dgvD.Rows(i).Cells(8).Value.ToString
                            litem10 = dgvD.Rows(i).Cells(9).Value.ToString
                            litem11 = dgvD.Rows(i).Cells(10).Value.ToString
                            litem12 = dgvD.Rows(i).Cells(11).Value.ToString
                            litem13 = dgvD.Rows(i).Cells(15).Value.ToString
                            litem14 = dgvD.Rows(i).Cells(16).Value.ToString
                            litem15 = dgvD.Rows(i).Cells(17).Value.ToString
                            litem16 = dgvD.Rows(i).Cells(18).Value.ToString
                            litem17 = dgvD.Rows(i).Cells(19).Value.ToString
                            litem18 = dgvD.Rows(i).Cells(31).Value.ToString


                            MyFile2.WriteLine(litem1 & vbTab & _
                                              litem2 & vbTab & _
                                              litem3 & vbTab & _
                                              litem4 & vbTab & _
                                              litem5 & vbTab & _
                                              litem6 & vbTab & _
                                              litem7 & vbTab & _
                                              litem8 & vbTab & _
                                              litem9 & vbTab & _
                                              litem10 & vbTab & _
                                              litem11 & vbTab & _
                                              litem12 & vbTab & _
                                              litem13 & vbTab & _
                                              litem14 & vbTab & _
                                              litem15 & vbTab & _
                                              litem16 & vbTab & _
                                              litem17 & vbTab & _
                                              litem18 & vbTab)



                            MyFile2_comma.WriteLine(litem1 & ";" & _
                  litem2 & ";" & _
                  litem3 & ";" & _
                  litem4 & ";" & _
                  litem5 & ";" & _
                  litem6 & ";" & _
                  litem7 & ";" & _
                  litem8 & ";" & _
                  litem9 & ";" & _
                  litem10 & ";" & _
                  litem11 & ";" & _
                  litem12 & ";" & _
                  litem13 & ";" & _
                  litem14 & ";" & _
                  litem15 & ";" & _
                  litem16 & ";" & _
                  litem17 & ";" & _
                  litem18)


                            MyFile3.WriteLine(litem1 & vbTab & _
                      litem2 & vbTab & _
                      litem3 & vbTab & _
                      litem4 & vbTab & _
                      litem5 & vbTab & _
                      litem6 & vbTab & _
                      litem7 & vbTab & _
                      litem8 & vbTab & _
                      litem9 & vbTab & _
                      litem10 & vbTab & _
                      litem11 & vbTab & _
                      litem12 & vbTab & _
                      litem13 & vbTab & _
                      litem14 & vbTab & _
                      litem15 & vbTab & _
                      litem16 & vbTab & _
                      litem17 & vbTab & _
                      litem18)
                            ListBox1.Items.Clear()
                        Next
                    Catch ex As Exception
                    End Try
                    MyFile2.Close()
                    MyFile2_comma.Close()
                Else
                End If
                MyFile3.Close()
            End If
        Next
        MessageBox.Show("Τα Αρχεια δημιουργηθηκαν", "ΚΑΤΑΣΤΑΣΗ ΑΡΧΕΙΩΝ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        unlock_settings.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles settings_access.Click
        unlock_settings.Show()
        Me.Close()
    End Sub

    Private Sub admin_pass_txt_MouseHover(sender As Object, e As EventArgs) Handles admin_pass_txt.MouseHover
        admin_pass_txt.PasswordChar = ""
    End Sub

    Private Sub admin_pass_txt_MouseLeave(sender As Object, e As EventArgs) Handles admin_pass_txt.MouseLeave
        admin_pass_txt.PasswordChar = "*"
    End Sub

End Class

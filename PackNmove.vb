Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports System.ServiceProcess
Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports Office = Microsoft.Office.Core



Public Class Ocean
    Public todaydate As String = Date.Now().ToString("ddMMMyyyy")


    Private Sub Packnmove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tfilepath.Text = My.Settings.rempath

        If CheckBox1.Checked = True Then

            Dim fileName As String = tfilepath.Text

            Dim fi As New IO.FileInfo(fileName)

            Dim destinationFile As String = "C:\PackNmove\PackNmove.xlsx"

            Try
                System.IO.Directory.CreateDirectory("C:\PackNmove")
                fi.CopyTo(destinationFile, True)

            Catch iox As IOException

                Console.WriteLine(iox.Message)

            End Try
        End If

        'comment
    End Sub

    Private Sub btnfindcase_Click(sender As Object, e As EventArgs) Handles btnfindcase.Click
        If tfilepath.Text = "" Then Exit Sub
        GroupBox1.Visible = False
        DataGridView1.Visible = True

        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        'Fill the [Excel file fullpath] with specific value
        Dim searchtxt = findtxt.Text
        'copy to PackNmove
        Dim destinationFile As String = "C:\PackNmove\PackNmove.xlsx"

        Try
            System.IO.Directory.CreateDirectory("C:\PackNmove")
            System.IO.Directory.CreateDirectory("C:\PackNmove\DailyLog")
            Dim fileName As String = tfilepath.Text
            '  Dim todaydate As String = Date.Now().ToString("ddMMMyyyy")
            Dim fi As New IO.FileInfo(fileName)
            'If Not File.Exists("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx") Then System.IO.File.WriteAllBytes("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx", My.Resources.DailyLog)
            Dim DilyLog As New IO.FileInfo("C:\PackNmove\DailyLog.xlsx")



            fi.CopyTo(destinationFile, True)


        Catch ex As IOException

            MsgBox(ex.Message)

        End Try


        MyConnection = New System.Data.OleDb.OleDbConnection _
    ("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & destinationFile & "; Extended Properties=Excel 12.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter _
        ("select [RoomN],[TenantName],[CivilID],[MoveinDate],[DueDate],[Authorization],[Status] from [Sheet1$] where [RoomN] like '%" & searchtxt & "%' Or  [CivilID] like '%" & searchtxt & "%' Or  [TenantName] like '%" & searchtxt & "%'", MyConnection)
        MyCommand.TableMappings.Add("Table", "TestTable")
        Try
            DtSet = New System.Data.DataSet
            MyCommand.Fill(DtSet)
            DataGridView1.DataSource = DtSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show(" حدث عطل اثناء استيراد البيانات من الملف الاصلي" & vbNewLine & ex.Message)

        End Try

        MyConnection.Close()

    End Sub


    Private Sub btnPickFile_Click(sender As Object, e As EventArgs) Handles btnPickFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Excel Files (*.xlsx*,*.xls*)|*.xls*|All Files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then

            strFileName = fd.FileName
            tfilepath.Text = fd.FileName
            If CheckBox1.Checked = True Then My.Settings.rempath = fd.FileName Else My.Settings.rempath = "notsaved"

        End If


        'create connection


    End Sub

    Private Sub findtxt_TextChanged(sender As Object, e As EventArgs) Handles findtxt.TextChanged
        Call btnfindcase_Click(sender, e)
    End Sub



    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        dtb1.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        dtb2.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        dtb3.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
        dtb4.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
        dtb5.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
        dtb6.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
        dtb7.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
        ' My.Settings.dtb8 = DataGridView1.SelectedRows(0).Cells(7).Value
        DataGridView1.Visible = False
        GroupBox1.Visible = True






        ' detailsform.Show()
        ' detailsform.dtb1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tbvisitnote.Text = ""
        GroupBox1.Visible = False
        DataGridView1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mymsgbox As DialogResult = MsgBox("هل تريد تسجيل دخول زيارة لهذه الغرفة الى سجل زيارات اليوم ", 1, "تأكيد الاضافة")
        If mymsgbox = DialogResult.Cancel Then Exit Sub
        Ladding.Visible = True
        Dim todaydate As String = Date.Now().ToString("ddMMMyyyy")
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet
        Dim xlsCell As Excel.Range
        Dim xlsDatei As String
        xlsApp = New Excel.Application
        xlsApp.Visible = False
        ' Dim todaydate As String = Date.Now().ToString("ddMMMyyyy")

        'xlsWB = xlsApp.Workbooks.Open("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx")
        'xlsSheet = xlsWB.Worksheets(1)
        Try
            If Not File.Exists("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx") Then
                System.IO.File.WriteAllBytes("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx", My.Resources.DailyLog)

                xlsApp = New Excel.Application
                xlsApp.Visible = False
                xlsWB = xlsApp.Workbooks.Open("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx")
                xlsSheet = xlsWB.Worksheets(1)

                xlsSheet.Range("D2").Value = xlsSheet.Range("D2").Value & Date.Now().ToString("dd/MM/yyyy")
                xlsWB.Save()
                xlsWB.Close()

            End If



        Catch ex As Exception

        End Try


        xlsApp = New Excel.Application
        xlsApp.Visible = False





        xlsWB = xlsApp.Workbooks.Open("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx")
        xlsSheet = xlsWB.Worksheets(1)

        Dim rowcount = xlsSheet.Range("C3").Value + 4
        xlsSheet.Cells(rowcount + 1, 1).Value = rowcount - 3
        xlsSheet.Cells(rowcount + 1, 2).Value = dtb1.Text
        xlsSheet.Cells(rowcount + 1, 3).Value = dtb2.Text
        xlsSheet.Cells(rowcount + 1, 4).Value = dtb3.Text
        xlsSheet.Cells(rowcount + 1, 5).Value = dtb4.Text
        xlsSheet.Cells(rowcount + 1, 6).Value = dtb5.Text
        xlsSheet.Cells(rowcount + 1, 7).Value = dtb6.Text
        xlsSheet.Cells(rowcount + 1, 8).Value = dtb7.Text
        xlsSheet.Cells(rowcount + 1, 9).Value = tbvisitnote.Text.ToString
        xlsSheet.Cells(rowcount + 1, 10).Value = Date.Now().ToString
        xlsSheet.Cells(rowcount + 1, 11).Value = "دخول"

        Ladding.Visible = False
        MsgBox("تم تسجيل دخول الزيارة الى سجل الزيارات اليوم", 0, "تم")
        ' xlsSheet.Rows().Insert("Ahmed", "Ali")

        xlsWB.Save()
        xlsWB.Close()

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlsApp)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            xlsApp = Nothing
        End Try

    End Sub

    Private Sub dtb7_TextChanged(sender As Object, e As EventArgs) Handles dtb7.TextChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then tbvisitnote.ReadOnly = False Else tbvisitnote.ReadOnly = True
    End Sub

    Private Sub PrintLog_Click(sender As Object, e As EventArgs) Handles PrintLog.Click
        If Not File.Exists("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx") Then
            MsgBox("لا يوجد سجل زيارات بتاريخ اليوم ")
            Exit Sub
        End If
        Try
            System.IO.File.Copy("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx", "C:\PackNmove\DailyLog\DailyLog_print.xlsx")

        Catch ex As Exception

        End Try
        Try
            Dim PrintLog As New ProcessStartInfo
            PrintLog.UseShellExecute = True
            PrintLog.Verb = "print"

            PrintLog.WindowStyle = ProcessWindowStyle.Hidden
            PrintLog.FileName = "C:\PackNmove\DailyLog\DailyLog_print.xlsx"
            Process.Start(PrintLog)
        Catch ex As Exception
            MsgBox("حدث خطأ اثناء الطباعة")
        End Try


        'System.IO.File.Delete("C:\PackNmove\DailyLog\DailyLog_" & todaydate & "_print.xlsx")



    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim mymsgbox As DialogResult = MsgBox("هل تريد تسجيل خروج زيارة لهذه الغرفة؟  ", 1, "تأكيد الاضافة")
        If mymsgbox = DialogResult.Cancel Then Exit Sub
        Ladding.Visible = True
        Dim todaydate As String = Date.Now().ToString("ddMMMyyyy")
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet
        Dim xlsCell As Excel.Range
        Dim xlsDatei As String
        xlsApp = New Excel.Application
        xlsApp.Visible = False
        ' Dim todaydate As String = Date.Now().ToString("ddMMMyyyy")

        'xlsWB = xlsApp.Workbooks.Open("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx")
        'xlsSheet = xlsWB.Worksheets(1)
        Try
            If Not File.Exists("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx") Then
                System.IO.File.WriteAllBytes("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx", My.Resources.DailyLog)

                xlsApp = New Excel.Application
                xlsApp.Visible = False
                xlsWB = xlsApp.Workbooks.Open("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx")
                xlsSheet = xlsWB.Worksheets(1)

                xlsSheet.Range("D2").Value = xlsSheet.Range("D2").Value & Date.Now().ToString("dd/MM/yyyy")
                xlsWB.Save()
                xlsWB.Close()

            End If



        Catch ex As Exception

        End Try


        xlsApp = New Excel.Application
        xlsApp.Visible = False





        xlsWB = xlsApp.Workbooks.Open("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx")
        xlsSheet = xlsWB.Worksheets(1)

        Dim rowcount = xlsSheet.Range("C3").Value + 4
        xlsSheet.Cells(rowcount + 1, 1).Value = rowcount - 3
        xlsSheet.Cells(rowcount + 1, 2).Value = dtb1.Text
        xlsSheet.Cells(rowcount + 1, 3).Value = dtb2.Text
        xlsSheet.Cells(rowcount + 1, 4).Value = dtb3.Text
        xlsSheet.Cells(rowcount + 1, 5).Value = dtb4.Text
        xlsSheet.Cells(rowcount + 1, 6).Value = dtb5.Text
        xlsSheet.Cells(rowcount + 1, 7).Value = dtb6.Text
        xlsSheet.Cells(rowcount + 1, 8).Value = dtb7.Text
        xlsSheet.Cells(rowcount + 1, 9).Value = tbvisitnote.Text.ToString
        xlsSheet.Cells(rowcount + 1, 10).Value = Date.Now().ToString
        xlsSheet.Cells(rowcount + 1, 11).Value = "خروج"
        Ladding.Visible = False
        MsgBox("تم تسجيل خروج الزيارة ", 0, "تم")
        ' xlsSheet.Rows().Insert("Ahmed", "Ali")

        xlsWB.Save()
        xlsWB.Close()

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlsApp)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            xlsApp = Nothing
        End Try

    End Sub
End Class


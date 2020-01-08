Imports System.Data.SqlClient
Imports System.IO
Imports System.ServiceProcess
Imports Excel = Microsoft.Office.Interop.Excel
Imports Office = Microsoft.Office.Core



Public Class Ocean
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Packnmove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tfilepath.Text = My.Settings.rempath

        If CheckBox1.Checked = True Then

            Dim fileName As String = tfilepath.Text

            Dim fi As New IO.FileInfo(fileName)

            Dim destinationFile As String = "C:\Temp\temp.xlsx"

            Try
                System.IO.Directory.CreateDirectory("C:\temp")
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
        'copy to temp
        Dim destinationFile As String = "C:\Temp\temp.xlsx"

        Try
            System.IO.Directory.CreateDirectory("C:\temp")
            System.IO.Directory.CreateDirectory("C:\temp\DailyLog")
            Dim fileName As String = tfilepath.Text
            Dim todaydate As String = Date.Now().ToString("ddMMMyyyy")
            Dim fi As New IO.FileInfo(fileName)
            System.IO.File.WriteAllBytes("C:\Temp\DailyLog\DailyLog_" & todaydate & ".xlsx", My.Resources.DailyLog)
            Dim DilyLog As New IO.FileInfo("C:\Temp\DailyLog.xlsx")



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

        GroupBox1.Visible = False
        DataGridView1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet
        Dim xlsCell As Excel.Range
        Dim xlsDatei As String

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        Dim todaydate As String = Date.Now().ToString("ddMMMyyyy")

        xlsWB = xlsApp.Workbooks.Open("C:\Temp\DailyLog\DailyLog_" & todaydate & ".xlsx")
        xlsSheet = xlsWB.Worksheets(1)
        ' xlsCell = xlsSheet.Range("A1")
        ' xlsCell.Value = "testappending"
        Dim rowcount = xlsSheet.Range("B3").Value + 4
        'xlsSheet.Rows(rowcount + 1).Insert()
        xlsSheet.Cells(rowcount + 1, 1).Value = dtb1.Text
        xlsSheet.Cells(rowcount + 1, 2).Value = dtb2.Text
        xlsSheet.Cells(rowcount + 1, 3).Value = dtb3.Text
        xlsSheet.Cells(rowcount + 1, 4).Value = dtb4.Text
        xlsSheet.Cells(rowcount + 1, 5).Value = dtb5.Text
        xlsSheet.Cells(rowcount + 1, 6).Value = dtb6.Text
        xlsSheet.Cells(rowcount + 1, 7).Value = dtb7.Text
        xlsSheet.Cells(rowcount + 1, 9).Value = Date.Now().ToString("dd/MM/yyyy  HH:mm.ss")

        MsgBox("تم اضافة الزيارة الى سجل الزيارات اليوم")
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


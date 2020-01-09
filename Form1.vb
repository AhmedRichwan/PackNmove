Imports Excel = Microsoft.Office.Interop.Excel
Imports Office = Microsoft.Office.Core
Public Class detailsform
    Public todaydate As String = Date.Now().ToString("ddMMMyyyy")

    Private Sub findtxt_TextChanged(sender As Object, e As EventArgs) Handles dtb2.TextChanged

    End Sub
    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtb1.Text = My.Settings.dtb1
        dtb2.Text = My.Settings.dtb2
        dtb3.Text = My.Settings.dtb3
        dtb4.Text = My.Settings.dtb4
        dtb5.Text = My.Settings.dtb5
        dtb6.Text = My.Settings.dtb6
        dtb7.Text = My.Settings.dtb7

        ' dtb8.Text = My.Settings.dtb8
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
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

        xlsWB = xlsApp.Workbooks.Open("C:\PackNmove\DailyLog\DailyLog_" & todaydate & ".xlsx")
        xlsSheet = xlsWB.Worksheets(1)
        ' xlsCell = xlsSheet.Range("A1")
        ' xlsCell.Value = "testappending"
        Dim rowcount = xlsSheet.UsedRange.Rows.Count
        'xlsSheet.Rows(rowcount + 1).Insert()
        xlsSheet.Cells(rowcount + 1, 1).Value = dtb1.Text
        xlsSheet.Cells(rowcount + 1, 2).Value = dtb2.Text
        xlsSheet.Cells(rowcount + 1, 3).Value = dtb3.Text
        xlsSheet.Cells(rowcount + 1, 4).Value = dtb4.Text
        xlsSheet.Cells(rowcount + 1, 5).Value = dtb5.Text
        xlsSheet.Cells(rowcount + 1, 6).Value = dtb6.Text
        xlsSheet.Cells(rowcount + 1, 7).Value = dtb7.Text

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
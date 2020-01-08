﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.ServiceProcess



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

        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        'Fill the [Excel file fullpath] with specific value
        Dim searchtxt = findtxt.Text
        'copy to temp
        Dim fileName As String = tfilepath.Text

        Dim fi As New IO.FileInfo(fileName)

        Dim destinationFile As String = "C:\Temp\temp.xlsx"

        Try
            System.IO.Directory.CreateDirectory("C:\temp")
            fi.CopyTo(destinationFile, True)

        Catch iox As IOException

            Console.WriteLine(iox.Message)

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
        My.Settings.dtb1 = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        My.Settings.dtb2 = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        My.Settings.dtb3 = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
        My.Settings.dtb4 = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
        My.Settings.dtb5 = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
        My.Settings.dtb6 = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
        My.Settings.dtb7 = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
        ' My.Settings.dtb8 = DataGridView1.SelectedRows(0).Cells(7).Value





        detailsform.Show()
        ' detailsform.dtb1.Text = ""
    End Sub

End Class


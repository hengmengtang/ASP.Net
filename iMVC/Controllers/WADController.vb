Imports System.Web.Mvc
Imports System.Data.OleDb

Public Class WADController
    Inherits Controller

    Function welcome() As String
        Return "Welcome to WAD class!"
    End Function

    Function greeting(name As String, id As String) As String
        Return "I'm " & name & ".My ID is " & id
    End Function

    Function Index(Optional Visitor As String = "WAD MVC", Optional Sequence As Byte = 1)
        Dim cn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        cn.ConnectionString = "Provider=SQLOLEDB.1;Password=123456789;Persist Security Info=True;User ID=sa;Initial Catalog=School;Data Source=MENGTANG\SQLEXPRESS"
        If cn.State = ConnectionState.Open Then
            cn.Close()
            ViewBag.Status = "Ok"
        Else
            ViewBag.Status = "No"
            cn.Open()
        End If
        cmd.Connection = cn
        cmd.CommandText = "select * from guests"
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        da.Fill(ds, "guests")
        Dim dt As DataTable = ds.Tables("guests")
        For Each r As DataRow In dt.Rows
            ViewBag.ID = r(0).ToString
            ViewBag.Name = r(1).ToString
        Next
        cn.Close()
        ViewBag.Visitor = Visitor
        ViewBag.Sequence = Sequence
        'select view index to browser automatically
        Return View()
    End Function
End Class
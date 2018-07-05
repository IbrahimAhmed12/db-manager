
Imports System.Data.OleDb
'This class makes it so that all the coding for SQL wont have to be redone as all the code is in here all i have to do is make queries
Public Class DBController
    'Sets up all the commands for building datatables
    Public connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=ACVdatabase.accdb"
    Public DBREF As New OleDbConnection(connectionstring)
    Public DA As New OleDbDataAdapter
    Public cmd As New OleDbCommand
    Public DT As New DataTable
    'This is a list of parameters i will use in my queries
    Public parameters As New List(Of OleDb.OleDbParameter)
    'these are stats for my datatables i will build
    Public recordcount As Integer
    Public exeption As String

    Sub MakeQuery(ByVal Query As String)
        'resets all stats
        recordcount = -1
        exeption = ""
        'this will make sure the program does not crash if the query has a mistake in the SQL statement
        Try
            DBREF.Open()
            'Loads the command with the query
            cmd = New OleDbCommand(Query, DBREF)
            'Puts in the parameters into the query
            parameters.ForEach(Sub(p) cmd.Parameters.Add(p))
            'Once we are done with parameters we delete all so they ar not reused
            parameters.Clear()
            'executes query
            DA = New OleDbDataAdapter(cmd)
            'fills datatable
            DA.Fill(DT)
            recordcount = (DT.Rows.Count)
            DA = Nothing
        Catch ex As Exception
            'exeption string is the error the code will show if it crashes
            exeption = ex.Message
            MsgBox(exeption)
        End Try
        If DBREF.State = ConnectionState.Open Then
            'closes the connection so it is more secure
            DBREF.Close()
        End If
    End Sub
    Sub clearDT()
        DT.Clear()

    End Sub
    Sub AddParameters(name As String, contents As Object)
        'makes a new parameter with the contents and name we want
        Dim newparameter As New OleDbParameter(name, contents)
        'puts new parameter in the list
        parameters.Add(newparameter)
    End Sub

End Class

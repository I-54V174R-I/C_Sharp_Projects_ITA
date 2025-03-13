Imports System.IO
Imports System.Text.RegularExpressions

Public Class MainForm
    Dim i As Integer = 0

    Dim dt As DataTable

    Dim _ID As Integer
    Dim _NOMBRE As String
    Dim _TELEFONO As String
    Dim _DIRECCION As String

    Private Property NOMBRE As String
        Get
            Return _NOMBRE
        End Get
        Set(value As String)
            _NOMBRE = value
        End Set
    End Property
    Private Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property
    Private Property TELEFONO As String
        Get
            Return _TELEFONO
        End Get
        Set(value As String)
            _TELEFONO = value
        End Set
    End Property
    Private Property DIRECCION As String
        Get
            Return _DIRECCION
        End Get
        Set(value As String)
            _DIRECCION = value
        End Set
    End Property

    Public Sub FocoBuscar() Handles txtBuscar.GotFocus
        Dim txt As New TextBox
        txt.Text = txtBuscar.Text
        If txt.Text = "<-Escriba aqui para buscar-->" Then
            txt.Text = ""
        End If

        txtBuscar.Text = txt.Text
    End Sub

    Public Sub LeerTXT()
        dt = New DataTable("Tabla")

        dt.Columns.Add("ID")
        dt.Columns.Add("NOMBRE")
        dt.Columns.Add("TELEFONO")
        dt.Columns.Add("DIRECCION")

        Dim dr As DataRow


        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("basedatos.txt")

            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")


            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        i = i + 1
                        If i = 1 Then
                            dr = dt.NewRow()
                            dr("ID") = currentField
                        ElseIf i = 2 Then
                            dr("NOMBRE") = currentField
                        ElseIf i = 3 Then
                            dr("TELEFONO") = currentField
                        Else
                            dr("DIRECCION") = currentField
                        End If
                    Next

                    i = 0
                    dt.Rows.Add(dr)

                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using


        If dt.Rows.Count > 0 Then
            DataGridView1.DataSource = dt
        Else
            DataGridView1.DataSource = Nothing
            txtID.Clear()
            txtNombre.Clear()
            txtTelefono.Clear()
            txtDireccion.Clear()
            CrearID()
        End If
    End Sub

    Private Sub CrearID()
        Dim ValorID As Integer = 0

        For Each Fila As DataRow In dt.Rows
            ValorID = Fila("ID")
        Next

        ValorID += 1
        txtID.Text = ValorID
    End Sub

    Public Sub LimpiarCampos()
        txtID.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtDireccion.Clear()

        txtNombre.Focus()

    End Sub

    Private Sub LlenaTexto()
        ID = DataGridView1.CurrentRow.Cells("ID").Value.ToString
        NOMBRE = DataGridView1.CurrentRow.Cells("NOMBRE").Value.ToString
        TELEFONO = DataGridView1.CurrentRow.Cells("TELEFONO").Value.ToString
        DIRECCION = DataGridView1.CurrentRow.Cells("DIRECCION").Value.ToString

        txtID.Text = ID
        txtNombre.Text = NOMBRE
        txtTelefono.Text = TELEFONO
        txtDireccion.Text = DIRECCION

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.RowCount > 0 Then
            LlenaTexto()
        Else
            LimpiarCampos()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        File.AppendAllText("basedatos.txt", Environment.NewLine + (txtID.Text & "," & txtNombre.Text & "," & txtTelefono.Text & "," & txtDireccion.Text))

        LeerTXT()
        EliminaLineaVacia()
    End Sub

    Private Sub EliminaLineaVacia()
        Dim strFile As String = File.ReadAllText("basedatos.txt")
        strFile = Regex.Replace(strFile, "^\r|\n\r|\n$", "")
        File.WriteAllText("basedatos.txt", strFile)
    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim jumbofile As String = "basedatos.txt"
        Dim newline As String = (txtID.Text & "," & txtNombre.Text & "," & txtTelefono.Text & "," & txtDireccion.Text)

        If System.IO.File.Exists(jumbofile) Then
            Dim lines() As String = IO.File.ReadAllLines(jumbofile)
            For i As Integer = 0 To lines.Length - 1
                If lines(i).Contains(ID & "," & NOMBRE & "," & TELEFONO & "," & DIRECCION) Then
                    lines(i) = newline
                End If
            Next
            IO.File.WriteAllLines(jumbofile, lines) 'assuming you want to write the file

            LeerTXT()
            EliminaLineaVacia()
        Else
            MsgBox("No existe el archivo")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        FilterFile("basedatos.txt", txtID.Text & "," & txtNombre.Text)

        LeerTXT()
        EliminaLineaVacia()
    End Sub

    Function FilterFile(ByVal sFile As String, ByVal sFilter As String) As Boolean
        'Funcion para buscar coincidencias y eliminar linea

        Dim lines As New List(Of String)
        Try

            Using sr As New StreamReader(sFile)
                While Not sr.EndOfStream
                    lines.Add(sr.ReadLine)
                End While
            End Using
            For i As Integer = lines.Count - 1 To 0 Step -1
                If lines(i).Contains(sFilter) Then lines.Remove(lines.Item(i))
            Next

            Using sw As New StreamWriter(sFile)
                For Each line As String In lines
                    sw.WriteLine(line)
                Next
            End Using
            Return True
        Catch ex As Exception : Return False : End Try
    End Function


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
        CrearID()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim bs As New BindingSource
        bs.DataSource = dt

        bs.Filter = "NOMBRE like '%" & txtBuscar.Text & "%'"

        DataGridView1.DataSource = bs

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeerTXT()
    End Sub
End Class

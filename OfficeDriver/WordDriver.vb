Public Class WordDriver
    Implements IDisposable

    REM constantes
    Const wdFindContinue As Integer = 1,
                  wdReplaceOne As Integer = 1,
                  wdReplaceAll As Integer = 2,
                  wdExportFormatPDF As Integer = 17,
                  wdDoNotSaveChanges As Integer = 0

    REM variables
    Dim fAPP As Object = Nothing
    Dim fDocument As Object = Nothing
    Dim fDesktop As Object = Nothing
    Dim fConnected As Boolean = False
    Dim listToChange As New List(Of Item)
    Dim fPId As Integer = -1

    Public isOpenOffice As Boolean = False

    Public Sub KillProcess()
        Try
            If fPId > 0 Then System.Diagnostics.Process.GetProcessById(fPId).Kill()
            fAPP = Nothing
            fPId = -1

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Dispose() Implements System.IDisposable.Dispose
        Try
            If Not fDocument Is Nothing Then CloseDocument(True)
            If Not fAPP Is Nothing Then fAPP = Nothing

        Catch ex As Exception

        End Try
    End Sub

    Public Sub ClearListToChange()
        Try
            If listToChange IsNot Nothing Then
                listToChange.Clear()
                listToChange = New List(Of Item)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub AddToChange(key As String, value As String)
        Dim item As New Item
        Try
            If listToChange Is Nothing Then listToChange = New List(Of Item)

            item.key = key
            item.value = value

            listToChange.Add(item)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ChangeAllFromList()
        Try
            For Each item As Item In listToChange
                ChangeOneValue(item.key, item.value)

            Next

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Function Connect() As Boolean

        Dim fProcesses() As Process

        Try
            fConnected = False

            If isOpenOffice Then
                fAPP = CreateObject("com.sun.star.ServiceManager")
                fProcesses = Process.GetProcessesByName("soffice")
                fPId = fProcesses(fProcesses.GetUpperBound(0)).Id
            Else
                fAPP = CreateObject("Word.Application")
                fProcesses = Process.GetProcessesByName("WinWord")
                fPId = fProcesses(fProcesses.GetUpperBound(0)).Id
                fAPP.Visible = False
            End If

            fConnected = (fAPP IsNot Nothing)

        Catch ex As Exception
            Throw
        End Try

        Connect = fConnected

    End Function

    Public Function MakePropertyValue(ByVal cName, ByVal uValue) As Object
        Dim oServiceManager As Object
        Dim oStruct As Object

        Try
            oServiceManager = CreateObject("com.sun.star.ServiceManager")

            oStruct = oServiceManager.Bridge_GetStruct("com.sun.star.beans.PropertyValue")
            oStruct.Name = cName
            oStruct.Value = uValue

        Catch ex As Exception
            Throw
        End Try


        MakePropertyValue = oStruct
    End Function

    Public Function OpenDocument(fileName As String) As Boolean
        Dim wProperties(1) As Object

        Try
            If Not fConnected Then Connect()
            If Not fConnected Then Return False

            If Not isOpenOffice Then
                fDocument = fAPP.Documents.Open(fileName, False, False)
            Else
                fDesktop = fAPP.createInstance("com.sun.star.frame.Desktop")
                wProperties(0) = MakePropertyValue("Hidden", True)
                fileName = fileName.Replace("\", "/")

                fDocument = fDesktop.loadComponentFromURL("file:///" + fileName, "_blank", 0, wProperties)
            End If

        Catch ex As Exception
            Throw
        End Try

        OpenDocument = (fDocument IsNot Nothing)

    End Function

    Public Sub ShowDocument()
        Try
            If fDocument Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                fAPP.Visible = True
            Else
                fDocument.CurrentController.Frame.ContainerWindow.Visible = True
                fDocument.CurrentController.Frame.ContainerWindow.toFront()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub CloseDocument(Optional keepOpen As Boolean = True)
        Try
            If fDocument Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                fDocument.Close(wdDoNotSaveChanges)
                fDocument = Nothing

                If Not keepOpen Then
                    REM fAPP.Quit()
                    KillProcess()
                End If
            Else
                fDocument.Close(False)
                fDocument = Nothing

                If Not keepOpen Then
                    REM fDesktop.Terminate()
                    fDesktop = Nothing
                    KillProcess()
                End If
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub SaveToPDF(docPDF As String)
        Dim wProperties(1) As Object

        Try
            If fDocument Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                fDocument.ExportAsFixedFormat(docPDF, wdExportFormatPDF)
            Else
                wProperties(0) = MakePropertyValue("FilterName", "writer_pdf_Export")
                docPDF = docPDF.Replace("\", "/")
                fDocument.StoreToURL("file:///" + docPDF, wProperties)
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub SaveAS(fileName As String)
        Try
            If fDocument Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                fDocument.SaveAs(fileName)
            Else
                fileName = fileName.Replace("\", "/")
                fDocument.StoreToURL("file:///" + fileName)
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub Print(Optional printerName As String = "", Optional ncopies As Integer = 1, Optional bCollate As Boolean = False, Optional sPages As String = "")
        Dim mPrintOptions As New List(Of Object)
        Dim AOptions(0) As Object
        Try
            If fDocument Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                'Print document MS WORD
                fAPP.PrintOut()
            Else
                If ncopies > 0 Then
                    mPrintOptions.Add(MakePropertyValue("CopyCount", ncopies))
                End If

                If bCollate Then
                    mPrintOptions.Add(MakePropertyValue("Collate", bCollate))
                End If

                If Trim(sPages) <> "" Then
                    mPrintOptions.Add(MakePropertyValue("Pages", sPages))
                End If

                If Trim(printerName) <> "" Then
                    fDocument.Printer = MakePropertyValue("Name", printerName)
                End If

                fDocument.print(AOptions)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ChangeOneValue(oldValue As String, value As String)
        Dim D1, D2, D3 As Object
        Dim ooBuscador As Object

        Try
            If fDocument Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                'CON MS OFFICE WORD
                D1 = True
                D2 = wdFindContinue
                D3 = wdReplaceAll

                fAPP.Selection.Find.ClearFormatting()
                fAPP.Selection.Find.Text = oldValue

                If (value.Length < 250) Then
                    fAPP.selection.Find.Replacement.Text = value
                    fAPP.Selection.Find.Execute(Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          D1, D2, Type.Missing, Type.Missing, D3)
                Else
                    fAPP.Selection.Find.Execute(Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          D1, D2, Type.Missing, Type.Missing, Type.Missing)
                    fAPP.Selection.text = value
                End If
            Else
                'CON OPEN OFFICE WRITER
                ooBuscador = fDocument.createReplaceDescriptor
                ooBuscador.SearchString = oldValue
                ooBuscador.ReplaceString = value
                fDocument.ReplaceAll(ooBuscador)
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class


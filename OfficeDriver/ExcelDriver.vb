Imports System.Drawing

Public Class ExcelDriver
    REM constantes
    Const wdExportFormatPDF As Integer = 17,
          wdDoNotSaveChanges As Integer = 0,
          xlCenter As Integer = -4108,
          wdFindContinue As Integer = 1,
          wdReplaceOne As Integer = 1,
          wdReplaceAll As Integer = 2,
          xlWhole As Integer = 1,
          xlByRows As Integer = 1


    REM variables
    Dim fAPP As Object = Nothing
    Dim fWorkbook As Object = Nothing
    Dim fDesktop As Object = Nothing
    Dim fConnected As Boolean = False
    Dim fSheet As Object = Nothing
    Dim fPId As Integer = -1
    Dim NumberFormatId As Long = -1
    Dim DateFormatId As Long = -1

    Public isOpenOffice As Boolean = False

    Public Function getColLetra(posicion As Integer) As String
        Dim resultado As String = ""
        Dim letras As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim d, m As Integer

        Try
            If posicion <= letras.Length Then
                resultado = letras.Substring(posicion - 1, 1)
            Else
                d = posicion / letras.Length
                m = posicion Mod letras.Length
                If (d > 1) Then d = d - 1

                resultado = resultado + getColLetra(d)
                resultado = resultado + getColLetra(m)
            End If
        Catch ex As Exception
            Throw
        End Try

        Return resultado
    End Function

    Public Sub KillProcess()
        Try
            If fPId > 0 Then System.Diagnostics.Process.GetProcessById(fPId).Kill()
            fAPP = Nothing
            fPId = -1

        Catch ex As Exception

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
                fAPP = CreateObject("Excel.Application")
                fProcesses = Process.GetProcessesByName("Excel")
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

    Public Function OpenWorkBook(fileName As String, Optional hidden As Boolean = True) As Boolean
        Dim wProperties(1) As Object
        Dim Dummy(1) As Object

        Try
            If Not fConnected Then Connect()
            If Not fConnected Then Return False

            If Not isOpenOffice Then
                If (fileName.Trim() <> "") Then
                    fWorkbook = fAPP.Workbooks.Open(fileName, False, False)
                Else fWorkbook = fAPP.Workbooks.Add
                End If

                fSheet = fWorkbook.sheets(1)
                fAPP.Visible = Not hidden
            Else
                fDesktop = fAPP.createInstance("com.sun.star.frame.Desktop")
                wProperties(0) = MakePropertyValue("Hidden", hidden)


                If (fileName.Trim() <> "") Then
                    fileName = fileName.Replace("\", "/")
                    fWorkbook = fDesktop.loadComponentFromURL("file:///" + fileName, "_blank", 0, wProperties)
                Else
                    fWorkbook = fDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, Dummy)
                    If hidden Then fWorkbook.CurrentController.Frame.ContainerWindow.Visible = False
                End If

                fSheet = fWorkbook.getSheets.getByIndex(0)
            End If

        Catch ex As Exception
            Throw
        End Try

        OpenWorkBook = (fWorkbook IsNot Nothing)

    End Function

    Public Sub ShowBook()
        Try
            If fWorkbook Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                fAPP.Visible = True
            Else
                fWorkbook.CurrentController.Frame.ContainerWindow.Visible = True
                fWorkbook.CurrentController.Frame.ContainerWindow.toFront()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub


    Public Function GetSheet(index As Integer) As Object
        Try
            If Not isOpenOffice Then
                fSheet = fWorkbook.Item(index + 1)
            Else
                fSheet = fWorkbook.getSheets.getByIndex(index)
            End If
        Catch ex As Exception
            Throw
        End Try
        Return fSheet
    End Function

    Public Sub CloseBook(Optional keepOpen As Boolean = False)
        Try
            If fWorkbook Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                fWorkbook.Close(wdDoNotSaveChanges)
                fWorkbook = Nothing
                fSheet = Nothing

                If Not keepOpen Then
                    fAPP.Quit()
                    fAPP = Nothing
                    KillProcess()
                End If
            Else
                fWorkbook.Close(False)
                fWorkbook = Nothing
                fSheet = Nothing

                If Not keepOpen Then
                    fDesktop.Terminate()
                    fDesktop = Nothing
                    KillProcess()
                End If
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function GetCellValue(cell As String) As Object

        Dim resultado As Object = Nothing

        Try
            If Not isOpenOffice Then
                resultado = fSheet.Range(cell, cell).Value
            Else
                resultado = fSheet.getCellRangeByName(cell).String
            End If

            If resultado Is Nothing Then resultado = ""

        Catch ex As Exception
            resultado = ""
        End Try

        Return resultado

    End Function

    Public Sub SetCellValue(cell As String, value As Object, Optional numberFormat As String = "")
        Dim valorB As Boolean
        Try
            If Not isOpenOffice Then
                If (numberFormat.Trim() <> "") Then fSheet.Range(cell, cell).NumberFormat = numberFormat
                fSheet.Range(cell, cell).Value = value
            Else
                If (numberFormat.Trim() <> "") Then SetCellNumberFormat(numberFormat)

                If value.GetType Is GetType(String) Then
                    fSheet.getCellRangeByName(cell).SetString(value)
                ElseIf value.GetType Is GetType(Boolean) Then
                    valorB = Convert.ToBoolean(value)
                    If valorB Then fSheet.getCellRangeByName(cell).SetString("SI")
                    If Not valorB Then fSheet.getCellRangeByName(cell).SetString("NO")

                    CenterHorizontal(cell)
                Else
                    fSheet.getCellRangeByName(cell).SetValue(value)
                End If
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub SetCellValue(cell As String, value As String, Optional numberFormat As String = "")
        Try
            If Not isOpenOffice Then
                If (numberFormat.Trim() <> "") Then fSheet.Range(cell, cell).NumberFormat = numberFormat
                If value.Trim() = "" Then
                    fSheet.Range(cell, cell).Value = Nothing
                Else fSheet.Range(cell, cell).Value = value.Trim()
                End If
            Else
                If (numberFormat.Trim() <> "") Then SetCellNumberFormat(numberFormat)
                fSheet.getCellRangeByName(cell).SetString(value.Trim())
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub SetCellValue(fila As Integer, col As Integer, value As Object, Optional numberFormat As String = "")
        Dim cell As String
        Dim valorB As Boolean
        Try
            cell = getColLetra(col) + Convert.ToString(fila)

            If Not isOpenOffice Then
                If (numberFormat.Trim() <> "") Then fSheet.Range(cell, cell).NumberFormat = numberFormat

                If value.GetType Is GetType(Boolean) Then
                    valorB = Convert.ToBoolean(value)
                    If valorB Then fSheet.Range(cell, cell).Value = "SI"
                    If Not valorB Then fSheet.Range(cell, cell).Value = "NO"
                Else
                    fSheet.Range(cell, cell).Value = value
                End If


            Else

                If value.GetType Is GetType(String) Then
                    fSheet.getCellRangeByName(cell).SetString(value)
                ElseIf value.GetType Is GetType(Boolean) Then
                    valorB = Convert.ToBoolean(value)
                    If valorB Then fSheet.getCellRangeByName(cell).SetString("SI")
                    If Not valorB Then fSheet.getCellRangeByName(cell).SetString("NO")
                Else
                    fSheet.getCellRangeByName(cell).SetValue(value)
                End If
            End If

            REM CENTRALIZAMOS EN CASO DE BOOLEAN
            If value.GetType Is GetType(Boolean) Then CenterHorizontal(cell)

            REM aplicamos formato numerico
            If (value.GetType Is GetType(Decimal) Or value.GetType Is GetType(Double)) Then
                SetCellNumberFormat(cell)
            ElseIf (value.GetType Is GetType(Date)) Then
                SetCellNumberFormat(cell, "dd/MM/yyyy")
            ElseIf (numberFormat.Trim() <> "") Then
                SetCellNumberFormat(cell, numberFormat)
            End If


        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub SetCellValue(fila As Integer, col As Integer, value As String, Optional numberFormat As String = "")
        Dim cell As String
        Try
            cell = getColLetra(col) + Convert.ToString(fila)

            If Not isOpenOffice Then
                If (numberFormat.Trim() <> "") Then fSheet.Range(cell, cell).NumberFormat = numberFormat
                fSheet.Range(cell, cell).Value = value
            Else
                If (numberFormat.Trim() <> "") Then SetCellNumberFormat(cell, numberFormat)
                fSheet.getCellRangeByName(cell).SetString(value)
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub SetCellFormat(cell As String, format As Format)
        Dim fRange As Object
        Dim fBold As Object

        Try
            If Not isOpenOffice Then
                fRange = fSheet.Range(cell, cell)
                fRange.Font.bold = format.bold
                fRange.Font.name = "Arial"
                If format.size > 12 Then fRange.Font.Size = format.size
                If (format.size <= 12) Then fRange.Font.Size = 12
                If format.alignCell <> AlignCell.none Then fRange.VerticalAlignment = format.alignCell
                If (Not format.fontColor = Nothing) Then fRange.interior.color = format.fontColor

                If (Not format.backGroundColor = Nothing) And (Not format.backGroundColor = Color.Transparent) Then fRange.interior.color = format.backGroundColor
            Else
                fRange = fSheet.getCellRangeByName(cell)
                If format.bold Then
                    fBold = fAPP.createInstance("com.sun.star.awt.BOLD")
                    fRange.setPropertyValue("CharWeight", 150.0)
                End If

                If (Not format.fontColor = Nothing) Then fRange.CharColor = format.fontColor
                If (Not format.backGroundColor = Nothing) And (Not format.backGroundColor = Color.Transparent) Then fRange.CellBackColor = format.backGroundColor

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub SetCellFormat(fila As Integer, col As Integer, format As Format)
        Dim cell As String
        Try
            cell = getColLetra(col) + fila.ToString()
            SetCellFormat(cell, format)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub SetCellNumberFormat(cell As String, Optional format As String = "#,##0.00")
        Dim NumberFormats As Object
        Dim NumberFormatString As String
        Dim LocalSettings As Object
        Dim oServiceManager As Object


        Try
            If Not isOpenOffice Then
                fSheet.Range(cell, cell).NumberFormat = format
            Else

                oServiceManager = CreateObject("com.sun.star.ServiceManager")
                LocalSettings = oServiceManager.Bridge_GetStruct("com.sun.star.lang.Locale")

                LocalSettings.Language = "en"
                LocalSettings.Country = "US"

                NumberFormats = fWorkbook.NumberFormats
                NumberFormatString = format

                If format.ToUpper() = "DD/MM/YYYY" Then
                    REM NumberFormatString = "dd/MM/aaaa"
                    If (DateFormatId < 0) Then
                        DateFormatId = NumberFormats.queryKey(NumberFormatString, LocalSettings, True)
                        If DateFormatId = -1 Then
                            DateFormatId = NumberFormats.addNew(NumberFormatString, LocalSettings)
                        End If
                    End If

                    If DateFormatId <> -1 Then fSheet.getCellRangeByName(cell).NumberFormat = DateFormatId
                Else
                    If (NumberFormatId < 0) Then
                        NumberFormatId = NumberFormats.queryKey(NumberFormatString, LocalSettings, True)
                        If NumberFormatId = -1 Then
                            NumberFormatId = NumberFormats.addNew(NumberFormatString, LocalSettings)
                        End If
                    End If

                    If NumberFormatId <> -1 Then fSheet.getCellRangeByName(cell).NumberFormat = NumberFormatId

                End If

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub SetCellFormula(cell As String, formula As String)
        Try
            If (formula.Substring(0, 1) <> "=") Then formula = "=" + formula.Trim()

            If Not isOpenOffice Then
                fSheet.Range(cell, cell).Formula = formula
            Else
                fSheet.getCellRangeByName(cell).Formula = formula
            End If

            SetCellNumberFormat(cell)

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub SetCellFormula(fila As Integer, col As Integer, formula As String)
        Dim cell As String
        Try
            cell = getColLetra(col) + fila.ToString()
            SetCellFormula(cell, formula)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub SetCellFunction(functionName As String, col As Integer, filaIni As Integer, filaFin As Integer)
        Dim cellIni As String
        Dim cellFin As String
        Dim cellForm As String
        Dim Formula As String
        Try
            cellIni = getColLetra(col) + filaIni.ToString()
            cellFin = getColLetra(col) + filaFin.ToString()
            cellForm = getColLetra(col) + (filaFin + 1).ToString()
            Formula = "= " + functionName + "(" + cellIni + ":" + cellFin + ")"

            SetCellFormula(cellForm, Formula)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub SaveToPDF(docPDF As String)
        Dim wProperties(1) As Object
        Dim paramOpenAfterPublish As Boolean = False
        Dim paramIncludeDocProps As Boolean = True
        Dim paramIgnorePrintAreas As Boolean = True
        Dim paramFromPage As Object = Type.Missing
        Dim paramToPage As Object = Type.Missing

        Try
            If fWorkbook Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                'fWorkbook.ExportAsFixedFormat("xlTypePDF", docPDF, "xlQualityStandard", True, True, )
            Else
                wProperties(0) = MakePropertyValue("FilterName", "writer_pdf_Export")
                docPDF = docPDF.Replace("\", "/")
                fWorkbook.StoreToURL("file:///" + docPDF, wProperties)
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub SaveAS(fileName As String)
        Dim wProperties(1) As Object
        Try
            If fWorkbook Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                fAPP.DisplayAlerts = False
                fWorkbook.SaveAs(fileName)
            Else
                REM wProperties(0) = MakePropertyValue("Overwrite", "True")
                fileName = fileName.Replace("\", "/")
                fWorkbook.StoreToURL("file:///" + fileName, wProperties)
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub Save()
        Dim wProperties(1) As Object
        Try
            If fWorkbook Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                fAPP.DisplayAlerts = False
                fWorkbook.Save()
            Else
                REM wProperties(0) = MakePropertyValue("Overwrite", "True")
                REM fileName = fileName.Replace("\", "/")
                REM fWorkbook.StoreToURL("file:///" + fileName, wProperties)
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub RunMacro(nameMacro As String)
        Try
            If Not isOpenOffice Then
                fAPP.Run(nameMacro)
            Else

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub AddSheet(sheetName As String)
        Dim sheets As Object

        Try
            If sheetName = "" Then sheetName = "sheet1"

            If Not isOpenOffice Then
                'CON MS EXCEL
                sheets = fWorkbook.sheets

                'Buscamos la hoja
                Try
                    fSheet = Nothing
                    fSheet = sheets(sheetName)
                Catch ex As Exception

                End Try

                If fSheet Is Nothing Then
                    fSheet = sheets.add()
                    fSheet.name = sheetName
                End If

            Else
                'CON OPEN OFFICE CALC
                sheets = fWorkbook.getSheets()

                If (Not sheets.hasByName(sheetName)) Then
                    sheets.insertNewByName(sheetName, 0)
                    fSheet = sheets.getByName(sheetName)
                Else
                    fSheet = sheets.getByIndex(0)
                End If
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Autofit(Optional lastCol As Integer = 28)
        Dim col As String
        Try
            col = getColLetra(lastCol)

            If Not isOpenOffice Then
                fSheet.columns("A:" + col).autoFit
            Else
                fSheet.columns.OptimalWidth = True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Merge(range As String)
        Try
            If Not range.Contains(":") Then range = range + ":" + range

            If Not isOpenOffice Then
                fSheet.Range(range).Merge
            Else
                fSheet.getCellRangeByName(range).merge(True)
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Merge(colIni As Integer, colFin As Integer, fila As Integer)
        Dim range As String
        Try
            range = getColLetra(colIni) + fila.ToString() + ":"
            range = range + getColLetra(colFin) + fila.ToString()

            Merge(range)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub CenterHorizontal(range As String)
        Try
            If Not range.Contains(":") Then range = range + ":" + range

            If Not isOpenOffice Then
                fSheet.Range(range).HorizontalAlignment = xlCenter
            Else
                fSheet.getCellRangeByName(range).HoriJustify = 2
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub CenterHorizontal(colIni As Integer, colFin As Integer, fila As Integer)
        Dim range As String
        Try
            range = getColLetra(colIni) + fila.ToString() + ":"
            range = range + getColLetra(colFin) + fila.ToString()

            CenterHorizontal(range)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ChangeOneValue(oldValue As String, value As String)
        Dim D1, D2, D3 As Object
        Dim ooBuscador As Object
        Dim range As Object
        Try
            If fWorkbook Is Nothing Then Exit Sub

            If Not isOpenOffice Then
                'CON MS OFFICE WORD
                D1 = True
                D2 = wdFindContinue
                D3 = wdReplaceAll
                range = fSheet.UsedRange
                range.Replace(oldValue, value, xlWhole, xlByRows, True, Type.Missing, Type.Missing, Type.Missing)
                REM fSheet.Selection.Find.ClearFormatting()
                REM fSheet.Selection.Find.Text = oldValue
                fAPP.Cells.Replace(oldValue, value, 2, 1, False, False, False)

            Else
                'CON OPEN OFFICE WRITER
                ooBuscador = fSheet.createReplaceDescriptor
                ooBuscador.SearchString = oldValue
                ooBuscador.ReplaceString = value
                fSheet.ReplaceAll(ooBuscador)
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class

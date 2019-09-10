Imports System.Drawing.Printing
Imports System.IO
Imports ZXing
Imports Microsoft.VisualBasic

Public Class IMPRESORA
    Dim ruta As String
    ':::Nombre del archivo
    Dim archivo As String
    Dim Swlogo As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 50
    End Sub

    Sub LeerArchivo()
        ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
        Dim leer As New StreamReader(ruta & archivo)

        ':::Limpiamos nuestro ListBox
        ListBoxClientes.Items.Clear()

        Try
            ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
            While leer.Peek <> -1
                ':::Leemos cada linea del archivo TXT
                Dim linea As String = leer.ReadLine()
                ':::Validamos que la linea no este vacia
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                ':::Agregramos los registros encontrados
                ListBoxClientes.Items.Add(linea)
            End While

            leer.Close()
            ':::Total de registros cargados al ListBox
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub
    Sub EliminarText()
        Try
            If File.Exists(ruta & archivo) Then
                ':::Eliminamos el archivo TXT
                File.Delete(ruta & archivo)
                MsgBox("Archivo eliminado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")

            Else
                MsgBox("No se encuentra el archivo especificado", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al eliminar el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub
    Sub imprime_archivo_text()
        Dim aImpresoras(PrinterSettings.InstalledPrinters.Count - 1) As String
        Dim printDoc As New PrintDocument
        Dim instance As New PrinterSettings
        Dim SwExiste As String
        Dim e As Double

        ruta = "C:\IMPRESORA01\"
        SwExiste = ""
        Dim folder As New DirectoryInfo(ruta)

        For Each file As FileInfo In folder.GetFiles()
            Swlogo = ""
            If file.Name = "IMPRESORA.txt" Then
                archivo = "IMPRESORA.txt"
                SwExiste = "1"
                Swlogo = "1"
            ElseIf file.Name = "IMPRESORA_E.txt" Then
                archivo = "IMPRESORA_E.txt"
                SwExiste = "1"
                Swlogo = "1"
                For e = 1 To 300000000
                    e = e + 1
                Next
            ElseIf file.Name = "IMPRESORA_I.txt" Then
                archivo = "IMPRESORA_I.txt"
                SwExiste = "1"
                Swlogo = ""
                For e = 1 To 300000000
                    e = e + 1
                Next
            ElseIf file.Name = "IMPRESORA_I2.txt" Then
                archivo = "IMPRESORA_I2.txt"
                SwExiste = "1"
                Swlogo = ""
                For e = 1 To 300000000
                    e = e + 1
                Next
            ElseIf file.Name = "IMPRESORA_I3.txt" Then
                archivo = "IMPRESORA_I3.txt"
                SwExiste = "1"
                Swlogo = ""
                For e = 1 To 300000000
                    e = e + 1
                Next
            ElseIf file.Name = "IMPRESORA_I4.txt" Then
                archivo = "IMPRESORA_I4.txt"
                SwExiste = "1"
                Swlogo = ""
                For e = 1 To 300000000
                    e = e + 1
                Next
            End If
            If SwExiste = "1" Then
                For i As Integer = 0 To instance.InstalledPrinters.Count - 1
                    aImpresoras(i) = instance.InstalledPrinters.Item(i)
                    If aImpresoras(i) = "N3" Then
                        printDoc.PrinterSettings.PrinterName = instance.InstalledPrinters.Item(i)
                        Exit For
                    End If
                Next
                ' asignamos el método de evento para cada página a imprimir
                AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                ' indicamos que queremos imprimir
                printDoc.Print()
            End If
            SwExiste = ""
        Next


        ruta = "C:\IMPRESORA02\"
        SwExiste = ""
        Dim folder2 As New DirectoryInfo(ruta)
        If Directory.Exists(ruta) Then
            For Each file As FileInfo In folder2.GetFiles()
                Swlogo = ""
                If file.Name = "IMPRESORA.txt" Then
                    archivo = "IMPRESORA.txt"
                    SwExiste = "1"
                    Swlogo = "1"
                ElseIf file.Name = "IMPRESORA_E.txt" Then
                    archivo = "IMPRESORA_E.txt"
                    SwExiste = "1"
                    Swlogo = "1"
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I.txt" Then
                    archivo = "IMPRESORA_I.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I2.txt" Then
                    archivo = "IMPRESORA_I2.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I3.txt" Then
                    archivo = "IMPRESORA_I3.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I4.txt" Then
                    archivo = "IMPRESORA_I4.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                End If
                If SwExiste = "1" Then
                    For i As Integer = 0 To instance.InstalledPrinters.Count - 1
                        aImpresoras(i) = instance.InstalledPrinters.Item(i)
                        If aImpresoras(i) = "N4" Then
                            printDoc.PrinterSettings.PrinterName = instance.InstalledPrinters.Item(i)
                            Exit For
                        End If
                    Next
                    ' asignamos el método de evento para cada página a imprimir
                    AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                    ' indicamos que queremos imprimir
                    printDoc.Print()
                End If
                SwExiste = ""
            Next
        End If

        ruta = "C:\IMPRESORA03\"
        SwExiste = ""
        Dim folder3 As New DirectoryInfo(ruta)
        If Directory.Exists(ruta) Then
            For Each file As FileInfo In folder3.GetFiles()
                Swlogo = ""
                If file.Name = "IMPRESORA.txt" Then
                    archivo = "IMPRESORA.txt"
                    SwExiste = "1"
                    Swlogo = "1"
                ElseIf file.Name = "IMPRESORA_E.txt" Then
                    archivo = "IMPRESORA_E.txt"
                    SwExiste = "1"
                    Swlogo = "1"
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I.txt" Then
                    archivo = "IMPRESORA_I.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I2.txt" Then
                    archivo = "IMPRESORA_I2.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I3.txt" Then
                    archivo = "IMPRESORA_I3.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I4.txt" Then
                    archivo = "IMPRESORA_I4.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                End If
                If SwExiste = "1" Then
                    For i As Integer = 0 To instance.InstalledPrinters.Count - 1
                        aImpresoras(i) = instance.InstalledPrinters.Item(i)
                        If aImpresoras(i) = "N4" Then
                            printDoc.PrinterSettings.PrinterName = instance.InstalledPrinters.Item(i)
                            Exit For
                        End If
                    Next
                    ' asignamos el método de evento para cada página a imprimir
                    AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                    ' indicamos que queremos imprimir
                    printDoc.Print()
                End If
                SwExiste = ""
            Next
        End If

        ruta = "C:\IMPRESORA04\"
        SwExiste = ""
        Dim folder4 As New DirectoryInfo(ruta)
        If Directory.Exists(ruta) Then
            For Each file As FileInfo In folder4.GetFiles()
                Swlogo = ""
                If file.Name = "IMPRESORA.txt" Then
                    archivo = "IMPRESORA.txt"
                    SwExiste = "1"
                    Swlogo = "1"
                ElseIf file.Name = "IMPRESORA_E.txt" Then
                    archivo = "IMPRESORA_E.txt"
                    SwExiste = "1"
                    Swlogo = "1"
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I.txt" Then
                    archivo = "IMPRESORA_I.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I2.txt" Then
                    archivo = "IMPRESORA_I2.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I3.txt" Then
                    archivo = "IMPRESORA_I3.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I4.txt" Then
                    archivo = "IMPRESORA_I4.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                End If
                If SwExiste = "1" Then
                    For i As Integer = 0 To instance.InstalledPrinters.Count - 1
                        aImpresoras(i) = instance.InstalledPrinters.Item(i)
                        If aImpresoras(i) = "N5" Then
                            printDoc.PrinterSettings.PrinterName = instance.InstalledPrinters.Item(i)
                            Exit For
                        End If
                    Next
                    ' asignamos el método de evento para cada página a imprimir
                    AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                    ' indicamos que queremos imprimir
                    printDoc.Print()
                End If
                SwExiste = ""
            Next
        End If

        ruta = "C:\IMPRESORA05\"
        SwExiste = ""
        If Directory.Exists(ruta) Then
            Dim folder5 As New DirectoryInfo(ruta)

            For Each file As FileInfo In folder5.GetFiles()
                Swlogo = ""
                If file.Name = "IMPRESORA.txt" Then
                    archivo = "IMPRESORA.txt"
                    SwExiste = "1"
                    Swlogo = "1"
                ElseIf file.Name = "IMPRESORA_E.txt" Then
                    archivo = "IMPRESORA_E.txt"
                    SwExiste = "1"
                    Swlogo = "1"
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I.txt" Then
                    archivo = "IMPRESORA_I.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I2.txt" Then
                    archivo = "IMPRESORA_I2.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I3.txt" Then
                    archivo = "IMPRESORA_I3.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                ElseIf file.Name = "IMPRESORA_I4.txt" Then
                    archivo = "IMPRESORA_I4.txt"
                    SwExiste = "1"
                    Swlogo = ""
                    For e = 1 To 300000000
                        e = e + 1
                    Next
                End If
                If SwExiste = "1" Then
                    For i As Integer = 0 To instance.InstalledPrinters.Count - 1
                        aImpresoras(i) = instance.InstalledPrinters.Item(i)
                        If aImpresoras(i) = "N6" Then
                            printDoc.PrinterSettings.PrinterName = instance.InstalledPrinters.Item(i)
                            Exit For
                        End If
                    Next
                    ' asignamos el método de evento para cada página a imprimir
                    AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                    ' indicamos que queremos imprimir
                    printDoc.Print()
                End If
                SwExiste = ""
            Next
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        
        imprime_archivo_text()
    End Sub

    Private Sub print_PrintPage(ByVal sender As Object, _
                            ByVal e As PrintPageEventArgs)
        Dim fuente As System.Drawing.Font = New Font("Courier New", 8)
        Dim fuente13 As System.Drawing.Font = New Font("Courier New", 13)
        Dim fuente15 As System.Drawing.Font = New Font("Courier New", 15)
        Dim fuente14 As System.Drawing.Font = New Font("Courier New", 14)
        Dim fuente10 As System.Drawing.Font = New Font("Courier New", 10)
        Dim fuente6 As System.Drawing.Font = New Font("Courier New", 6)
        Dim fuente9 As System.Drawing.Font = New Font("Courier New", 9)
        Dim fuente12 As System.Drawing.Font = New Font("Courier New", 12)
        Dim fuente11 As System.Drawing.Font = New Font("Courier New", 11)
        Dim fuente20 As System.Drawing.Font = New Font("Courier New", 20)


        Dim fuenteN As System.Drawing.Font = New Font("Courier New", 8 - 0.5, FontStyle.Bold)
        Dim fuente13N As System.Drawing.Font = New Font("Courier New", 13 - 0.5, FontStyle.Bold)
        Dim fuente15N As System.Drawing.Font = New Font("Courier New", 15 - 0.5, FontStyle.Bold)
        Dim fuente14N As System.Drawing.Font = New Font("Courier New", 14 - 0.5, FontStyle.Bold)
        Dim fuente10N As System.Drawing.Font = New Font("Courier New", 10 - 0.5, FontStyle.Bold)
        Dim fuente6N As System.Drawing.Font = New Font("Courier New", 6 - 0.5, FontStyle.Bold)
        Dim fuente9N As System.Drawing.Font = New Font("Courier New", 9 - 0.5, FontStyle.Bold)
        Dim fuente12N As System.Drawing.Font = New Font("Courier New", 12 - 0.5, FontStyle.Bold)
        Dim fuente11N As System.Drawing.Font = New Font("Courier New", 11 - 0.5, FontStyle.Bold)
        Dim fuente20N As System.Drawing.Font = New Font("Courier New", 20 - 0.5, FontStyle.Bold)


        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim unidad As Byte = 0
        Dim detalle As String = ""
        Dim valor As Decimal = 0
        Dim tabulacion As String = ""
        Dim compensador As Integer = 0
        Dim total As Decimal = 0
        Dim xx As Integer
        Dim yy As Integer
        Dim yy2 As Integer
        yy = 10
        yy2 = 1
        xx = 0



        Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIALIZA EL GENERADOR
        Dim IMAGEN As Bitmap
        GENERADOR.Format = BarcodeFormat.QR_CODE
        If File.Exists(ruta & archivo) Then



            ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
            Dim leer As New StreamReader(ruta & archivo, System.Text.Encoding.Default)
            Try
                ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
                While leer.Peek <> -1
                    ':::Leemos cada linea del archivo TXT
                    Dim linea As String = leer.ReadLine()
                    ':::Validamos que la linea no este vacia
                    If String.IsNullOrEmpty(linea) Then
                        Continue While
                    End If
                    ':::Agregramos los registros encontrados
                    If Strings.Left(linea, 3) = "@@@" And Swlogo = "1" Then
                        linea = Strings.Right(linea, Len(linea) - 3)
                        IMAGEN = New Bitmap(GENERADOR.Write(linea), PictureBoxGENERAR.Width, PictureBoxGENERAR.Height)
                        PictureBoxGENERAR.Image = IMAGEN
                        e.Graphics.DrawImage(PictureBoxGENERAR.Image, 90, yy + 10, 100, 100)
                    Else
                        If Strings.Left(linea, 9) = "|||||||||" Then
                            linea = Strings.Right(linea, Len(linea) - 9)
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuente13N, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente13, Brushes.Black, xx, yy)
                            End If
                            yy = yy + 15 + yy2
                        ElseIf Strings.Left(linea, 8) = "||||||||" Then
                            linea = Strings.Right(linea, Len(linea) - 8)
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuente15N, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente15, Brushes.Black, xx, yy)
                            End If
                            yy = yy + 17 + yy2
                        ElseIf Strings.Left(linea, 7) = "|||||||" Then
                            linea = Strings.Right(linea, Len(linea) - 7)
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuente14N, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente14, Brushes.Black, xx, yy)
                            End If

                            yy = yy + 16 + yy2
                        ElseIf Strings.Left(linea, 6) = "||||||" Then
                            linea = Strings.Right(linea, Len(linea) - 6)
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuente10N, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente10, Brushes.Black, xx, yy)
                            End If
                            yy = yy + 12 + yy2
                        ElseIf Strings.Left(linea, 5) = "|||||" Then
                            linea = Strings.Right(linea, Len(linea) - 5)
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuente6N, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente6, Brushes.Black, xx, yy)
                            End If
                            yy = yy + 8 + yy2
                        ElseIf Strings.Left(linea, 4) = "||||" Then
                            linea = Strings.Right(linea, Len(linea) - 4)
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuente9N, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente9, Brushes.Black, xx, yy)
                            End If
                            yy = yy + 11 + yy2
                        ElseIf Strings.Left(linea, 3) = "|||" Then
                            linea = Strings.Right(linea, Len(linea) - 3)
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuente12N, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente12, Brushes.Black, xx, yy)
                            End If

                            yy = yy + 13 + yy2
                        ElseIf Strings.Left(linea, 2) = "||" Then
                            linea = Strings.Right(linea, Len(linea) - 2)
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuente11N, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente11, Brushes.Black, xx, yy)
                            End If

                            yy = yy + 13 + yy2
                        ElseIf Strings.Left(linea, 1) = "|" Then
                            linea = Strings.Right(linea, Len(linea) - 1)
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuente20N, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente20, Brushes.Black, xx, yy)
                            End If

                            yy = yy + 22 + yy2
                        Else
                            If Strings.Left(linea, 1) = "^" Then
                                linea = Strings.Right(linea, Len(linea) - 1)
                                e.Graphics.DrawString(linea, fuenteN, Brushes.Black, xx, yy)
                            Else
                                e.Graphics.DrawString(linea, fuente, Brushes.Black, xx, yy)
                            End If
                            yy = yy + 10 + yy2
                        End If

                    End If
                    If Strings.Left(linea, 2) = "~~" Then
                        e.HasMorePages = False
                        yy = 10
                        yy2 = 1
                        xx = 0
                        linea = Strings.Right(linea, Len(linea) - 2)
                        sender.Print()
                    End If

                End While

                leer.Close()
                'e.HasMorePages = False
                File.Delete(ruta & archivo)
            Catch ex As Exception
                MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
            End Try
        End If

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        imprime_archivo_text()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class

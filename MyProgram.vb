Imports System
Imports System.Console
Imports System.IO

Public Module MyProgram
    Sub Main()
        Dim nama As String

        Console.WriteLine("Masukkan Nama")
        nama = Console.ReadLine()
        Dim gapok As Integer, gapok1 As Integer, gapok2 As Integer, gapok3 As Integer

        gapok1 = 1500000
        gapok2 = 2500000
        gapok3 = 3500000
        Console.WriteLine("Golongan Gaji ( 1-3 )")
        Console.WriteLine("1. Golongan 1")
        Console.WriteLine("2. Golongan 2")
        Console.WriteLine("3. Golongan 3")
        Console.WriteLine("")
        gapok = inputValue()
        If gapok = 1 Then
            gapok = gapok1
        Else
            If gapok = 2 Then
                gapok = gapok2
            Else
                gapok = gapok3
            End If
        End If
        Dim tunis As Integer, tunis1 As Integer, tunis2 As Integer, tunis3 As Integer

        tunis1 = gapok * 0.01
        tunis2 = gapok * 0.03
        tunis3 = gapok * 0.05
        Dim anak As Integer, tunak As Integer, tunak1 As Integer, tunak2 As Integer

        tunak1 = gapok * 0.01
        tunak2 = gapok * 0.02
        Dim statpegawai As Integer, statkawin As Integer, kelamin As Integer

        Console.WriteLine("")
        Console.WriteLine("Jenis Kelamin ( 1-2 )")
        Console.WriteLine("1. Laki-Laki")
        Console.WriteLine("2. Perempuan")
        Console.WriteLine("")

        kelamin = inputValue()
        Console.WriteLine("")
        Console.WriteLine("Status Pegawai ( 1-2 )")
        Console.WriteLine("1. Tetap")
        Console.WriteLine("2. Honorer")
        Console.WriteLine("")

        statpegawai = inputValue()
        Console.WriteLine("")
        Console.WriteLine("Status Kawin ( 1-2 )")
        Console.WriteLine("1. Sudah Kawin")
        Console.WriteLine("2. Belum Kawin")
        Console.WriteLine("")

        statkawin = inputValue()
        If kelamin = 1 Then
            If statkawin = 1 Then
                If statkawin = 1 Then
                End If
                If gapok = 1500000 Then
                    tunis = tunis1
                Else
                    If gapok = 2500000 Then
                        tunis = tunis2
                    Else
                        tunis = tunis3
                    End If
                End If
                Console.WriteLine("")
                Console.WriteLine("Jumlah Anak")
                Console.WriteLine("")
                anak = inputValue()
                If anak = 1 Then
                    tunak = tunak1
                Else
                    If anak = 2 Then
                        tunak = tunak2
                    Else
                        If anak > 2 Then
                            tunak = tunak2
                        Else
                            tunak = 0
                        End If
                    End If
                End If
            Else
                tunis = 0
                tunak = 0
                anak = 0
            End If
        Else
            If statkawin = 1 Then
                tunis = 0
                Console.WriteLine("")
                Console.WriteLine("Jumlah Anak")
                Console.WriteLine("")
                anak = inputValue()
                If anak = 1 Then
                    tunak = tunak1
                Else
                    If anak = 2 Then
                        tunak = tunak2
                    Else
                        If anak > 2 Then
                            tunak = tunak2
                        Else
                            tunak = 0
                        End If
                    End If
                End If
            Else
                tunis = 0
                tunak = 0
                anak = 0
            End If
        End If
        Dim bruto As Integer, koperasi As Integer

        bruto = gapok + tunak + tunis
        koperasi = 5000
        Dim jabatan As Integer, biayajab As Integer, biayakepala As Integer, biayamanager As Integer, biayasekretaris As Integer

        biayakepala = gapok * 0.05
        biayamanager = gapok * 0.03
        biayasekretaris = gapok * 0.03
        Dim pensiunjab As Integer, pensiunkepala As Integer, pensiunmanager As Integer, pensiunsekretaris As Integer

        pensiunkepala = gapok * 0.05
        pensiunmanager = gapok * 0.03
        pensiunsekretaris = gapok * 0.03

        Console.WriteLine("")
        Console.WriteLine("Jabatan ( 1-3 )")
        Console.WriteLine("1. Kepala")
        Console.WriteLine("2. Manager")
        Console.WriteLine("3. Sekretaris")
        Console.WriteLine("")

        jabatan = inputValue()
        If jabatan > 3 Then
            Console.WriteLine("Wrong Input")
            Do While jabatan > 3
                Console.WriteLine("")
                Console.WriteLine("Jabatan ( 1-3 )")
                Console.WriteLine("1. Kepala")
                Console.WriteLine("2. Manager")
                Console.WriteLine("3. Sekretaris")
                Console.WriteLine("")
                jabatan = inputValue()
                If jabatan = 1 Then
                    biayajab = biayakepala
                    pensiunjab = pensiunkepala
                Else
                    If jabatan = 2 Then
                        biayajab = biayamanager
                        pensiunjab = pensiunmanager
                    Else
                        If jabatan = 3 Then
                            biayajab = biayasekretaris
                            pensiunjab = pensiunsekretaris
                        Else
                            Console.WriteLine("Wrong Input, Choose 1 - 3")
                        End If
                    End If
                End If
            Loop
        Else
            If jabatan = 1 Then
                biayajab = biayakepala
                pensiunjab = pensiunkepala
            Else
                If jabatan = 2 Then
                    biayajab = biayamanager
                    pensiunjab = pensiunmanager
                Else
                    biayajab = biayasekretaris
                    pensiunjab = pensiunsekretaris
                End If
            End If
        End If
        Dim gajinetto As Integer

        If statpegawai = 1 Then
            gajinetto = bruto + biayajab + pensiunjab - koperasi
        Else
            gajinetto = bruto + biayajab
            pensiunjab = 0
        End If

        '' DATE TIME
        Dim safedate As String = String.Format("{0:dd-MM-yyyy  HH-mm-ss}", DateTime.Now)
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy-HH:mm:ss}", DateTime.Now)
        Console.WriteLine("Tanggal Rilis = " & safedate)

        '' OUTPUT PREPARATION
        Dim filename, fileread As String
        filename = "Slip Gaji " & safedate & ".txt"
        fileread = "D:\=============================KULIAH\SEMESTER 3\Elsa\UTS ALPRO\slip-gaji\output\Slip Gaji " & safedate & ".txt"
        Dim toTxt As StreamWriter

        toTxt = My.Computer.FileSystem.OpenTextFileWriter("D:\=============================KULIAH\SEMESTER 3\Elsa\UTS ALPRO\slip-gaji\output\" & filename, True)

        '' OUTPUT SHOW
        toTxt.WriteLine("--------------------------------------------------------")
        toTxt.WriteLine("  SLIP GAJI : " & nama)
        toTxt.WriteLine("--------------------------------------------------------")
        If gapok = gapok1 Then
            toTxt.WriteLine("  1. Golongan               = Golongan 1")
        Else
            If gapok = gapok2 Then
                toTxt.WriteLine("  1. Golongan           = Golongan 2")
            Else
                toTxt.WriteLine("  1. Golongan                = Golongan 3")
            End If
        End If
        If jabatan = 1 Then
            toTxt.WriteLine("  2. Jabatan                = Kepala")
        Else
            If jabatan = 2 Then
                toTxt.WriteLine("  2. Jabatan               = Manager")
            Else
                If jabatan = 3 Then
                    toTxt.WriteLine("  2. Jabatan                = Sekretaris")
                End If
            End If
        End If
        If statpegawai = 1 Then
            toTxt.WriteLine("  3. Status Pegawai         = " & "Tetap")
        Else
            toTxt.WriteLine("  3. Status Pegawai         = " & "Honorer")
        End If
        If kelamin = 1 Then
            toTxt.WriteLine("  4. Jenis Kelamin          = " & "Laki-laki")
        Else
            toTxt.WriteLine("  4. Jenis Kelamin          = " & "Perempuan")
        End If
        If statkawin = 1 Then
            toTxt.WriteLine("  5. Status Kawin           = " & "Kawin")
        Else
            toTxt.WriteLine("  5. Status Kawin           = " & "Belum Kawin")
        End If
        toTxt.WriteLine("  6. Jumlah Anak            = " & anak)
        toTxt.WriteLine("  7. Gaji Pokok             = " & gapok)
        toTxt.WriteLine("  8. Tunjangan Istri        = " & tunis)
        toTxt.WriteLine("  9. Tunjangan Anak         = " & tunak)
        toTxt.WriteLine("          Gaji Bruto        = " & bruto)
        If statpegawai = 1 Then
            toTxt.WriteLine("  10. Potongan Koperasi     = " & "5000")
        Else
            toTxt.WriteLine("  10. Potongan Koperasi     = " & "0")
        End If
        toTxt.WriteLine("  11. Biaya Jabatan         = " & biayajab)
        toTxt.WriteLine("  12. Dana Pensiun          = " & pensiunjab)
        toTxt.WriteLine("          Gaji Netto        = " & gajinetto)
        toTxt.WriteLine("--------------------------------------------------------")
        toTxt.WriteLine("                            Print : " & todaysdate)
        toTxt.WriteLine("--------------------------------------------------------")
        toTxt.Close()

        ''Open File
        System.Diagnostics.Process.Start("notepad.exe", fileread)


    End Sub

    ' .NET can only read single characters or entire lines from the console.
    ' The following function safely reads a double value.
    Private Function inputValue() As Double
        Dim result As Double
        While Not Double.TryParse(Console.ReadLine(), result)
            ' No code in the loop
        End While
        Return result
    End Function
End Module

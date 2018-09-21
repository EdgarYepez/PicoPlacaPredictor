Imports PicoPlacaPredictor

Module Module1

    Sub Main()

        While True
            Try
                Console.Write("License plate (format: XXX-000 or XXX-0000): ")
                Dim LicensePlateString As String = Console.ReadLine
                Dim PL As New LicensePlate(LicensePlateString)

                Console.Write("Date and time (format: dd/MM/yyyy HH:mm): ")
                Dim DateString As String = Console.ReadLine
                Dim D As Date = Date.ParseExact(DateString, "dd/MM/yyyy HH:mm", Globalization.DateTimeFormatInfo.InvariantInfo)

                Dim Applies As Boolean = PL.PicoPlacaApplies(D)
                Console.WriteLine("Pico & Placa {0} apply to {1} on {2} at {3}." & vbNewLine, If(Applies, "does", "does not"), PL.ToString, D.ToLongDateString, D.ToShortTimeString)
            Catch ex As Exception
                Console.WriteLine(ex.Message & vbNewLine)
            End Try
        End While

    End Sub

End Module

Imports System.Text.RegularExpressions

Public Class LicensePlate

    Public ReadOnly Property LetterSet As String

    Public ReadOnly Property NumberSet As String

    Public Sub New(LicensePlateString As String)
        LicensePlateString = If(LicensePlateString, String.Empty).Trim
        If LicensePlateString.Equals(String.Empty) Then Throw New Exception("No license plate string provided.")
        Dim LicensePattern As New Regex("^\s*([A-Z]{3})\s*-\s*([0-9]{3,4})\s*$")
        Dim M As Match = LicensePattern.Match(LicensePlateString)
        If M.Success Then
            LetterSet = M.Groups(1).Value
            NumberSet = M.Groups(2).Value
        Else
            Throw New Exception("Wrong license plate string format.")
        End If
    End Sub

    Public Function GetLastDigit() As Integer
        Dim Digits() As Char = NumberSet.ToCharArray()
        Return Digits(Digits.Count - 1).ToString
    End Function

    Public Function GetPicoPlacaDay() As DayOfWeek
        Dim Ret As DayOfWeek
        Select Case GetLastDigit()
            Case 1, 2 : Ret = DayOfWeek.Monday
            Case 3, 4 : Ret = DayOfWeek.Tuesday
            Case 5, 6 : Ret = DayOfWeek.Wednesday
            Case 7, 8 : Ret = DayOfWeek.Thursday
            Case 9, 0 : Ret = DayOfWeek.Friday
        End Select
        Return Ret
    End Function

    Public Function PicoPlacaApplies(DateAndTime As Date) As Boolean
        Dim MorningStart As New TimeSpan(7, 0, 0)
        Dim MorningEnd As New TimeSpan(9, 30, 0)
        Dim EveningStart As New TimeSpan(16, 0, 0)
        Dim EveningEnd As New TimeSpan(19, 30, 0)
        Return DateAndTime.DayOfWeek = GetPicoPlacaDay() AndAlso
                ((DateAndTime.TimeOfDay >= MorningStart AndAlso DateAndTime.TimeOfDay <= MorningEnd) OrElse
                (DateAndTime.TimeOfDay >= EveningStart AndAlso DateAndTime.TimeOfDay <= EveningEnd))
    End Function

    Public Overrides Function ToString() As String
        Return LetterSet & "-" & NumberSet
    End Function

End Class
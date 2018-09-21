Imports PicoPlacaPredictor

<TestClass()> Public Class PicoPlacaTest

    Private Shared ReadOnly Property DateFormat As String = "dd/MM/yyyy HH:mm"

#Region "Monday"
    <TestMethod()>
    Public Sub TestMondayMorningTrue1()
        Dim LP As New LicensePlate("ABC-1231")
        Dim DateString As String = "17/09/2018 07:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestMondayMorningTrue2()
        Dim LP As New LicensePlate("ABC-1232")
        Dim DateString As String = "17/09/2018 09:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestMondayMorningFalse()
        Dim LP As New LicensePlate("ABC-121")
        Dim DateString As String = "17/09/2018 09:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestMondayEveningTrue1()
        Dim LP As New LicensePlate("ABC-1231")
        Dim DateString As String = "17/09/2018 16:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestMondayEveningTrue2()
        Dim LP As New LicensePlate("ABC-1232")
        Dim DateString As String = "17/09/2018 19:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestMondayEveningFalse()
        Dim LP As New LicensePlate("ABC-121")
        Dim DateString As String = "17/09/2018 19:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub
#End Region

#Region "Tuesday"

    <TestMethod()>
    Public Sub TestTuesdayMorningTrue1()
        Dim LP As New LicensePlate("ABC-1233")
        Dim DateString As String = "18/09/2018 07:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestTuesdayMorningTrue2()
        Dim LP As New LicensePlate("ABC-1234")
        Dim DateString As String = "18/09/2018 09:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestTuesdayMorningFalse()
        Dim LP As New LicensePlate("ABC-123")
        Dim DateString As String = "18/09/2018 09:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestTuesdayEveningTrue1()
        Dim LP As New LicensePlate("ABC-1233")
        Dim DateString As String = "18/09/2018 16:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestTuesdayEveningTrue2()
        Dim LP As New LicensePlate("ABC-1234")
        Dim DateString As String = "18/09/2018 19:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestTuesdayEveningFalse()
        Dim LP As New LicensePlate("ABC-123")
        Dim DateString As String = "18/09/2018 19:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

#End Region

#Region "Wednesday"

    <TestMethod()>
    Public Sub TestWednesdayMorningTrue1()
        Dim LP As New LicensePlate("ABC-1235")
        Dim DateString As String = "19/09/2018 07:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestWednesdayMorningTrue2()
        Dim LP As New LicensePlate("ABC-1236")
        Dim DateString As String = "19/09/2018 09:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestWednesdayMorningFalse()
        Dim LP As New LicensePlate("ABC-125")
        Dim DateString As String = "19/09/2018 09:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestWednesdayEveningTrue1()
        Dim LP As New LicensePlate("ABC-1235")
        Dim DateString As String = "19/09/2018 16:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestWednesdayEveningTrue2()
        Dim LP As New LicensePlate("ABC-1236")
        Dim DateString As String = "19/09/2018 19:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestWednesdayEveningFalse()
        Dim LP As New LicensePlate("ABC-125")
        Dim DateString As String = "19/09/2018 19:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

#End Region

#Region "Thursday"

    <TestMethod()>
    Public Sub TestThursdayMorningTrue1()
        Dim LP As New LicensePlate("ABC-1237")
        Dim DateString As String = "20/09/2018 07:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestThursdayMorningTrue2()
        Dim LP As New LicensePlate("ABC-1238")
        Dim DateString As String = "20/09/2018 09:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestThursdayMorningFalse()
        Dim LP As New LicensePlate("ABC-127")
        Dim DateString As String = "20/09/2018 09:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestThursdayEveningTrue1()
        Dim LP As New LicensePlate("ABC-1237")
        Dim DateString As String = "20/09/2018 16:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestThursdayEveningTrue2()
        Dim LP As New LicensePlate("ABC-1238")
        Dim DateString As String = "20/09/2018 19:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestThursdayEveningFalse()
        Dim LP As New LicensePlate("ABC-127")
        Dim DateString As String = "20/09/2018 19:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

#End Region

#Region "Friday"

    <TestMethod()>
    Public Sub TestFridayMorningTrue1()
        Dim LP As New LicensePlate("ABC-1239")
        Dim DateString As String = "21/09/2018 07:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestFridayMorningTrue2()
        Dim LP As New LicensePlate("ABC-1230")
        Dim DateString As String = "21/09/2018 09:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestFridayMorningFalse()
        Dim LP As New LicensePlate("ABC-129")
        Dim DateString As String = "21/09/2018 09:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestFridayEveningTrue1()
        Dim LP As New LicensePlate("ABC-1239")
        Dim DateString As String = "21/09/2018 16:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestFridayEveningTrue2()
        Dim LP As New LicensePlate("ABC-1230")
        Dim DateString As String = "21/09/2018 19:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsTrue(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestFridayEveningFalse()
        Dim LP As New LicensePlate("ABC-129")
        Dim DateString As String = "21/09/2018 19:31"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

#End Region

#Region "Saturday"

    <TestMethod()>
    Public Sub TestSaturdayFalse1()
        Dim LP As New LicensePlate("ABC-1231")
        Dim DateString As String = "22/09/2018 05:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSaturdayFalse2()
        Dim LP As New LicensePlate("ABC-1232")
        Dim DateString As String = "22/09/2018 07:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSaturdayFalse3()
        Dim LP As New LicensePlate("ABC-1233")
        Dim DateString As String = "22/09/2018 09:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSaturdayFalse4()
        Dim LP As New LicensePlate("ABC-1234")
        Dim DateString As String = "22/09/2018 12:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSaturdayFalse5()
        Dim LP As New LicensePlate("ABC-1235")
        Dim DateString As String = "22/09/2018 16:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSaturdayFalse6()
        Dim LP As New LicensePlate("ABC-1236")
        Dim DateString As String = "22/09/2018 19:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSaturdayFalse7()
        Dim LP As New LicensePlate("ABC-1237")
        Dim DateString As String = "22/09/2018 20:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSaturdayFalse8()
        Dim LP As New LicensePlate("ABC-1238")
        Dim DateString As String = "22/09/2018 22:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSaturdayFalse9()
        Dim LP As New LicensePlate("ABC-1239")
        Dim DateString As String = "22/09/2018 23:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSaturdayFalse10()
        Dim LP As New LicensePlate("ABC-1239")
        Dim DateString As String = "22/09/2018 23:59"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

#End Region

#Region "Sunday"

    <TestMethod()>
    Public Sub TestSundayFalse1()
        Dim LP As New LicensePlate("ABC-1231")
        Dim DateString As String = "23/09/2018 05:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSundayFalse2()
        Dim LP As New LicensePlate("ABC-1232")
        Dim DateString As String = "23/09/2018 07:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSundayFalse3()
        Dim LP As New LicensePlate("ABC-1233")
        Dim DateString As String = "23/09/2018 09:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSundayFalse4()
        Dim LP As New LicensePlate("ABC-1234")
        Dim DateString As String = "23/09/2018 12:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSundayFalse5()
        Dim LP As New LicensePlate("ABC-1235")
        Dim DateString As String = "23/09/2018 16:30"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSundayFalse6()
        Dim LP As New LicensePlate("ABC-1236")
        Dim DateString As String = "23/09/2018 19:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSundayFalse7()
        Dim LP As New LicensePlate("ABC-1237")
        Dim DateString As String = "23/09/2018 20:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSundayFalse8()
        Dim LP As New LicensePlate("ABC-1238")
        Dim DateString As String = "23/09/2018 22:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSundayFalse9()
        Dim LP As New LicensePlate("ABC-1239")
        Dim DateString As String = "23/09/2018 23:00"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

    <TestMethod()>
    Public Sub TestSundayFalse10()
        Dim LP As New LicensePlate("ABC-1239")
        Dim DateString As String = "23/09/2018 23:59"
        Dim D As Date = Date.ParseExact(DateString, DateFormat, Globalization.DateTimeFormatInfo.InvariantInfo)
        Assert.IsFalse(LP.PicoPlacaApplies(D))
    End Sub

#End Region

End Class

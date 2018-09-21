Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PicoPlacaPredictor

<TestClass()> Public Class LicensePlateTest

    <TestMethod()>
    <ExpectedException(GetType(Exception), "No license plate string provided.")>
    Public Sub TestConstructorOnNullLicensePlateString()
        Dim LP As New LicensePlate(Nothing)
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(Exception), "No license plate string provided.")>
    Public Sub TestConstructorOnEmptyLicensePlateString()
        Dim LP As New LicensePlate("")
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(Exception), "Wrong license plate string format.")>
    Public Sub TestConstructorOnWrongLicensePlateString1()
        Dim LP As New LicensePlate("ac")
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(Exception), "Wrong license plate string format.")>
    Public Sub TestConstructorOnWrongLicensePlateString2()
        Dim LP As New LicensePlate("abc-345")
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(Exception), "Wrong license plate string format.")>
    Public Sub TestConstructorOnWrongLicensePlateString3()
        Dim LP As New LicensePlate("abc-34589")
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(Exception), "Wrong license plate string format.")>
    Public Sub TestConstructorOnWrongLicensePlateString4()
        Dim LP As New LicensePlate("abc--345")
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(Exception), "Wrong license plate string format.")>
    Public Sub TestConstructorOnWrongLicensePlateString5()
        Dim LP As New LicensePlate("ABC1234")
    End Sub

    <TestMethod()>
    Public Sub TestLetterSet()
        Dim LP As New LicensePlate("ABC-1234")
        Assert.AreEqual(LP.LetterSet, "ABC")
    End Sub

    <TestMethod()>
    Public Sub TestNumberSet()
        Dim LP As New LicensePlate("ABC-1234")
        Assert.AreEqual(LP.NumberSet, "1234")
    End Sub

    <TestMethod()>
    Public Sub TestGetLastDigit1()
        Dim LP As New LicensePlate("ABC-1234")
        Assert.AreEqual(LP.GetLastDigit, 4)
    End Sub

    <TestMethod()>
    Public Sub TestGetLastDigit2()
        Dim LP As New LicensePlate("ABC-123")
        Assert.AreEqual(LP.GetLastDigit, 3)
    End Sub

End Class
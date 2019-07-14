Imports System.Math

Public Class cal
    Public Property a As Decimal
    ReadOnly Property pi As Decimal = 3.14
    Public Shared Property c As Decimal
    Public Property b As Decimal

    Overridable Function minus() As Decimal
        Return a - b
    End Function
    Overridable Function total(Optional c As Integer = 0) As Decimal
        Return a + b
    End Function
    Function x() As Decimal
        Return a * b
    End Function
    Function chia() As Decimal
        Return a / b
    End Function
    Function pTron() As Decimal
        Return a * pi
    End Function
    Function pTamgiac() As Decimal
        Return a + b + c
    End Function
    Function pChunhat() As Decimal
        Return (a + b) * 2
    End Function
    Function sTron() As Decimal
        Return a ^ 2 * pi
    End Function
    Function sTamgiac() As Decimal
        Return 1 / 2 * a * b
    End Function
End Class




Imports NUnit.Framework
Imports Payroll_ProtoVB
<TestFixture>
Public Class LoginTest

    <Test>
    Sub ValidationCheck()
        Dim LgIn As LoginLogic = New LoginLogic()
        Dim result As Boolean

        result = LgIn.IsCreateUsrFormValid("First", "Last", "123 Street", "SC", "12345", "password", "password")
        Assert.True(result)

    End Sub

End Class

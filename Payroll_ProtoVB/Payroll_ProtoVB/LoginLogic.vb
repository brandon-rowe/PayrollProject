Public Class LoginLogic


    Public Function IsCreateUsrFormValid(FName As String, LName As String, Street As String, State As String, Zip As String, PWord As String, VPWord As String) As Boolean

        Return FName.Length() > 0 AndAlso LName.Length() > 0 AndAlso Street.Length() > 0 AndAlso State.Length() > 0 AndAlso Zip.Length() > 0 AndAlso PWord = VPWord AndAlso PWord.Length() > 0


    End Function
End Class

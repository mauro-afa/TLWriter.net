Public Class Common

    Public Function translateStep(exec_type As String, importance As String)
        Dim imp, exec, result(2) As String

        Select Case exec_type
            Case "Manual"
                result(0) = 1
            Case "Automated"
                result(0) = 2
            Case 1
                result(0) = "Manual"
            Case 2
                result(0) = "Automated"
        End Select

        Select Case importance
            Case "Low"
                result(1) = 1
            Case "Medium"
                result(1) = 2
            Case "High"
                result(1) = 3
            Case 1
                result(1) = "Low"
            Case 2
                result(1) = "Medium"
            Case 3
                result(1) = "High"
        End Select

        Return result

    End Function

End Class

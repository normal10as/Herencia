Public Class Empleado
    Private _nombre As String
    Private _cargo As String

    Sub New()
        _nombre = ""
        _cargo = ""
    End Sub

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property cargo As String
        Get
            Return _cargo
        End Get
        Set(value As String)
            _cargo = value
        End Set
    End Property

    Public Overridable Function calcularPago() As Single
        Return 0
    End Function

    Public Overrides Function ToString() As String
        Return nombre
    End Function
End Class

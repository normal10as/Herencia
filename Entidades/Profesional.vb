Public Class Profesional
    Inherits Empleado

    Private _horasTrabajadas As UShort
    Private _costoHora As Single

    Sub New()
        MyBase.New
        _horasTrabajadas = 0
        _costoHora = 0
    End Sub

    Public Property horasTrabajadas As UShort
        Get
            Return _horasTrabajadas
        End Get
        Set(value As UShort)
            _horasTrabajadas = value
        End Set
    End Property

    Public Property costoHora As Single
        Get
            Return _costoHora
        End Get
        Set(value As Single)
            _costoHora = value
        End Set
    End Property

    Public ReadOnly Property Honorarios As Single
        Get
            Return calcularhonorarios()
        End Get
    End Property

    Private Function calcularhonorarios() As Single
        Return costoHora * horasTrabajadas
    End Function
End Class

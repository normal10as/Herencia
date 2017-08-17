Public Class Asalariado
    Inherits Empleado

    Private _sueldoBruto As Single
    Private _retencionPorcentaje As Single
    Private _aportesPorcentaje As Single

    Sub New()
        MyBase.New()
        _sueldoBruto = 0
        _retencionPorcentaje = 0
        _aportesPorcentaje = 0
    End Sub

    Public Property sueldoBruto As Single
        Get
            Return _sueldoBruto
        End Get
        Set(value As Single)
            _sueldoBruto = value
        End Set
    End Property

    Public Property retencionPorcentaje As Single
        Get
            Return _retencionPorcentaje
        End Get
        Set(value As Single)
            _retencionPorcentaje = value
        End Set
    End Property

    Public Property aportesPorcentaje As Single
        Get
            Return _aportesPorcentaje
        End Get
        Set(value As Single)
            _aportesPorcentaje = value
        End Set
    End Property

    Public Overrides Function calcularPago() As Single
        Return sueldoBruto - sueldoBruto * retencionPorcentaje / 100 + sueldoBruto * aportesPorcentaje / 100
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " (Asalariado)"
    End Function
End Class

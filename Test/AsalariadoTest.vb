Imports Entidades

Module AsalariadoTest
    Sub Main()
        Dim empleado1 As New Asalariado
        empleado1.nombre = "Marcos"
        empleado1.cargo = "Cartero"
        empleado1.sueldoBruto = 10000
        empleado1.retencionPorcentaje = 10
        empleado1.aportesPorcentaje = 20

        Console.WriteLine("Nombre: " & empleado1.nombre)
        Console.WriteLine("Cargo: " & empleado1.cargo)
        Console.WriteLine("Sueldo bruto: " & empleado1.sueldoBruto)
        Console.WriteLine("Retención: %" & empleado1.retencionPorcentaje)
        Console.WriteLine("Aportes: %" & empleado1.aportesPorcentaje)
        Console.WriteLine("Sueldo: " & empleado1.calcularPago())
        Console.WriteLine("toString: " & empleado1.ToString)
    End Sub
End Module

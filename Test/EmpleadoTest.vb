Imports Entidades

Module EmpleadoTest

    Sub Main()
        Dim empleado1 As New Empleado
        empleado1.nombre = "Marcos"
        empleado1.cargo = "Cartero"

        Console.WriteLine("Nombre: " & empleado1.nombre)
        Console.WriteLine("Cargo: " & empleado1.cargo)
        Console.WriteLine("Sueldo: " & empleado1.calcularPago())
        Console.WriteLine("toString: " & empleado1.ToString)
    End Sub

End Module

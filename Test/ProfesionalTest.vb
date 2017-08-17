Imports Entidades

Module ProfesionalTest
    Sub Main()
        Dim empleado1 As New Profesional
        empleado1.nombre = "Frames"
        empleado1.cargo = "Community manager"
        empleado1.costoHora = 100
        empleado1.horasTrabajadas = 20

        Console.WriteLine("Nombre: " & empleado1.nombre)
        Console.WriteLine("Cargo: " & empleado1.cargo)
        Console.WriteLine("Costo hora: " & empleado1.costoHora)
        Console.WriteLine("Horas Trabajadas: " & empleado1.horasTrabajadas)
        Console.WriteLine("Honorarios: " & empleado1.calcularPago())
        Console.WriteLine("toString: " & empleado1.ToString)
    End Sub
End Module

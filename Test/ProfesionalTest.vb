Imports ClassLibrary1

Module ProfesionalTest
    Sub Main()
        Dim empleado1 As New Profesional
        empleado1.nombre = "Marcos"
        empleado1.cargo = "Cartero"
        empleado1.costoHora = 100
        empleado1.horasTrabajadas = 20

        Console.WriteLine("Nombre: " & empleado1.nombre)
        Console.WriteLine("Cargo: " & empleado1.cargo)
        Console.WriteLine("Honorarios: " & empleado1.Honorarios())
    End Sub
End Module

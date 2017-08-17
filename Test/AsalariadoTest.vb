Imports ClassLibrary1

Module AsalariadoTest
    Sub Main()
        Dim empleado1 As New Asalariado
        empleado1.nombre = "Marcos"
        empleado1.cargo = "Cartero"

        Console.WriteLine("Nombre: " & empleado1.nombre)
        Console.WriteLine("Cargo: " & empleado1.cargo)
    End Sub
End Module

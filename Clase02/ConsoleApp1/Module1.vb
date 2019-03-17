Module Module1

    Sub Main(parametros As String())

        ' Escribir cadena o string
        Console.WriteLine("Hola Mundo!")
        Console.WriteLine("Cantidad de Argumentos: " & parametros.Length)
        Console.WriteLine("Mira mamá, ahora se programar, mi nombre es " + parametros.FirstOrDefault())

    End Sub

End Module

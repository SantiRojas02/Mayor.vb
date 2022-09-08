Module Module1

    Sub Main(args As String)

        Dim a, b, c, resultado As Integer




        Console.Write("Ingrese numero1 : ")
        a = Console.ReadLine()
        Console.Write("Ingrese numero2 : ")
        b = Console.ReadLine()
        Console.Write("Ingrese numero2 : ")
        c = Console.ReadLine()

        If (a > b) & (a > c) Then
            resultado = a

        End If

        Console.WriteLine("Numero mayor: " & resultado)

        Console.ReadKey()











    End Sub

End Module

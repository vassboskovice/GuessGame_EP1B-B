Imports System

Module Program
    Sub Main(args As String())
        Console.CursorVisible = False
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Black
        Dim klavesa As ConsoleKeyInfo
        Do
            Console.Clear()
            Menu()
            klavesa = Console.ReadKey(True)
            If klavesa.KeyChar = "1" Then
                HadaUzivatel()
            ElseIf klavesa.KeyChar = "2" Then
                HadaPocitac()
            ElseIf klavesa.Key = ConsoleKey.Escape Then
                Exit Do
            End If
        Loop
    End Sub

    Sub Menu()
        Console.WriteLine("╔═════════════════════════╗")
        Console.WriteLine("║       HÁDÁNÍ ČÍSEL      ║")
        Console.WriteLine("╠═════════════════════════╣")
        Console.WriteLine("║ 1 - Číslo hádá uživatel ║")
        Console.WriteLine("║ 2 - Číslo hádá počítač  ║")
        Console.WriteLine("║ Esc - Zavřít aplikaci   ║")
        Console.WriteLine("╠═════════════════════════╣")
        Console.WriteLine("║   Vyber položku menu    ║")
        Console.WriteLine("╚═════════════════════════╝")
    End Sub

    Sub HadaUzivatel()
        Console.Clear()
        Console.WriteLine("1 - Číslo hádá uživatel")
        Console.ReadKey()
    End Sub

    Sub HadaPocitac()
        Console.Clear()
        Console.WriteLine("2 - Číslo hádá počítač")
        Console.ReadKey()
    End Sub
End Module

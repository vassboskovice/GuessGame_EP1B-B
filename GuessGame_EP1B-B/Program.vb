Imports System

Module Program
    Sub Main(args As String())
        Console.CursorVisible = False

        Menu()

        Console.ReadKey()
    End Sub

    Sub Menu()
        Console.WriteLine("╔═════════════════════════╗")
        Console.WriteLine("║       HÁDÁNÍ ČÍSEL      ║")
        Console.WriteLine("╠═════════════════════════╣")
        Console.WriteLine("║ 1 - Číslo hádá uživatel ║")
        Console.WriteLine("║ 2 - Číslo hádá počítač  ║")
        Console.WriteLine("╟─────────────────────────╢")
        Console.WriteLine("║ Esc - Zavřít aplikaci   ║")
        Console.WriteLine("╠═════════════════════════╣")
        Console.WriteLine("║   Vyber položku menu    ║")
        Console.WriteLine("╚═════════════════════════╝")
    End Sub
End Module

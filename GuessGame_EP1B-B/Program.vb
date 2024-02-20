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
        Dim cislo, tip As Integer
        Dim vstup As String
        Dim random As Random = New Random 'generátor náhodných čísel

        cislo = random.Next(0, 1000) 'náhodné číslo v rozmezí 0 - 999

        Console.Clear()
        Console.WriteLine(" 1 - Číslo hádá uživatel")
        Console.WriteLine("---------------------------------------")
        Do
            Console.Write(" Tipni si číslo (0 - 999): ")
            vstup = Console.ReadLine
            If Integer.TryParse(vstup, tip) Then
                If tip = cislo Then
                    Console.WriteLine(" Výborně, zásah!")
                    Exit Do
                ElseIf tip < cislo Then
                    Console.WriteLine(" To je málo...")
                Else
                    Console.WriteLine(" To je moc...")
                End If
            Else
                Console.WriteLine(" Musíš zadat celé číslo!!")
            End If
        Loop
        Console.WriteLine("---------------------------------------")
        Console.WriteLine("Díky za hru, pro návrat do menu stiskni libovolnou klávesu...")
        Console.ReadKey()
    End Sub

    Sub HadaPocitac()
        Dim min, max, tip As Integer
        Dim vstup As String
        Dim klavesa As ConsoleKeyInfo

        Console.Clear()
        Console.WriteLine("2 - Číslo hádá počítač")
        Console.WriteLine("---------------------------------------")
        Console.Write(" Zadej minimum: ")
        vstup = Console.ReadLine
        If Integer.TryParse(vstup, min) Then
            Console.Write(" Zadej maximum: ")
            vstup = Console.ReadLine
            If Integer.TryParse(vstup, max) Then
                Console.WriteLine("---------------------------------------")
                Do
                    tip = (min + max) / 2
                    Console.WriteLine($" Je to {tip}? (1 - málo; 2 - moc; jinak - zásah)")
                    klavesa = Console.ReadKey
                    If klavesa.KeyChar = "1" Then
                        min = tip
                    ElseIf klavesa.KeyChar = "2" Then
                        max = tip
                    Else
                        Console.WriteLine(" Skvělé, perfektně jsme si zahráli. Pro návrat stiskni libovolnou klávesu...")
                        Exit Do
                    End If
                Loop
            Else
                Console.WriteLine(" Musíš zadat celé číslo!!")
            End If
        Else
            Console.WriteLine(" Musíš zadat celé číslo!!")
        End If
        Console.ReadKey()
    End Sub
End Module

using System;

class Program
{
    static void Main()
    {
        bool dziala = true;

        while (dziala)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Kalkulator");
            Console.WriteLine("2 - Konwerter temperatur");
            Console.WriteLine("3 - Średnia ocen");
            Console.WriteLine("0 - Zakończ");

            Console.Write("Wybierz zadanie: ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;

                case "2":
                    Konwerter();
                    break;

                case "3":
                    SredniaOcen();
                    break;

                case "0":
                    dziala = false;
                    Console.WriteLine("Koniec programu.");
                    break;

                default:
                    Console.WriteLine("Niepoprawny wybór.");
                    break;
            }
        }
    }

    static void Kalkulator()
    {
        Console.WriteLine("\n--- Kalkulator ---");

        Console.Write("Pierwsza liczba: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Druga liczba: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Operacja (+ - * /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine("Wynik: " + (a + b));
                break;

            case "-":
                Console.WriteLine("Wynik: " + (a - b));
                break;

            case "*":
                Console.WriteLine("Wynik: " + (a * b));
                break;

            case "/":
                if (b != 0)
                    Console.WriteLine("Wynik: " + (a / b));
                else
                    Console.WriteLine("Błąd: dzielenie przez zero.");
                break;

            default:
                Console.WriteLine("Niepoprawna operacja.");
                break;
        }
    }

    static void Konwerter()
    {
        Console.WriteLine("\n--- Konwerter temperatur ---");

        Console.Write("Kierunek (C/F): ");
        string kierunek = Console.ReadLine().ToUpper();

        Console.Write("Temperatura: ");
        double temp = double.Parse(Console.ReadLine());

        if (kierunek == "C")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {wynik:F2}°F");
        }
        else if (kierunek == "F")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {wynik:F2}°C");
        }
        else
        {
            Console.WriteLine("Niepoprawny wybór.");
        }
    }

    static void SredniaOcen()
    {
        Console.WriteLine("\n--- Średnia ocen ---");

        Console.Write("Liczba ocen: ");
        int liczba = int.Parse(Console.ReadLine());

        if (liczba <= 0)
        {
            Console.WriteLine("Liczba ocen musi być większa od 0.");
            return;
        }

        double suma = 0;

        for (int i = 1; i <= liczba; i++)
        {
            Console.Write($"Ocena {i}: ");
            double ocena = double.Parse(Console.ReadLine());

            if (ocena < 1 || ocena > 6)
            {
                Console.WriteLine("Ocena poza zakresem.");
                return;
            }

            suma += ocena;
        }

        double srednia = suma / liczba;

        Console.WriteLine($"Średnia: {srednia:F2}");

        if (srednia >= 3)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał.");
    }
}
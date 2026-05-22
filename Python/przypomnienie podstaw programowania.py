def kalkulator():
    print("\n--- Kalkulator ---")

    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))
    op = input("Podaj operację (+, -, *, /): ")

    if op == "+":
        print("Wynik:", a + b)
    elif op == "-":
        print("Wynik:", a - b)
    elif op == "*":
        print("Wynik:", a * b)
    elif op == "/":
        if b != 0:
            print("Wynik:", a / b)
        else:
            print("Błąd: dzielenie przez zero.")
    else:
        print("Nieprawidłowa operacja.")


def konwerter():
    print("\n--- Konwerter temperatur ---")

    kierunek = input("Wybierz kierunek (C/F): ").upper()
    temperatura = float(input("Podaj temperaturę: "))

    if kierunek == "C":
        wynik = temperatura * 1.8 + 32
        print(f"{temperatura}°C = {wynik:.2f}°F")

    elif kierunek == "F":
        wynik = (temperatura - 32) / 1.8
        print(f"{temperatura}°F = {wynik:.2f}°C")

    else:
        print("Nieprawidłowy wybór.")


def srednia_ocen():
    print("\n--- Średnia ocen ---")

    liczba = int(input("Podaj liczbę ocen: "))

    if liczba <= 0:
        print("Liczba ocen musi być większa od 0.")
        return

    suma = 0

    for i in range(liczba):
        ocena = float(input(f"Ocena {i+1}: "))

        if 1 <= ocena <= 6:
            suma += ocena
        else:
            print("Ocena poza zakresem 1–6")
            return

    srednia = suma / liczba

    print(f"Średnia: {srednia:.2f}")

    if srednia >= 3:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")


while True:
    print("\n===== MENU =====")
    print("1 - Kalkulator")
    print("2 - Konwerter temperatur")
    print("3 - Średnia ocen")
    print("0 - Zakończ")

    wybor = input("Wybierz zadanie: ")

    if wybor == "1":
        kalkulator()

    elif wybor == "2":
        konwerter()

    elif wybor == "3":
        srednia_ocen()

    elif wybor == "0":
        print("Koniec programu.")
        break

    else:
        print("Niepoprawny wybór.")
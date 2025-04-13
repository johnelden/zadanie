using System;
using sklep;
class Program
{
    static void Main(string[] args)
    {
        // Tworzenie listy produktów magazynowych  
        List<Produkt> magazyn = new List<Produkt>();

        while (true)
        {
            // Wyświetlenie opcji dla użytkownika  
            Console.WriteLine("Wybierz opcję: (1) Dodaj produkt, (2) Usuń produkt, (3) Wyświetl produkty");
            string? opcja = Console.ReadLine();

            if (opcja == "1")
            {
                // Dodawanie nowego produktu  
                Console.WriteLine("Podaj nazwę produktu:");
                string? name = Console.ReadLine();

                // Sprawdzenie czy nazwa produktu nie jest pusta  
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Nazwa produktu nie może być pusta.");
                    continue;
                }

                // Pobranie ilości produktu  
                Console.WriteLine("Podaj ilość produktu:");
                int quantity;
                if (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("Nieprawidłowa ilość.");
                    continue;
                }

                // Pobranie ceny jednostkowej produktu  
                Console.WriteLine("Podaj cenę jednostkową produktu:");
                double price;
                if (!double.TryParse(Console.ReadLine(), out price))
                {
                    Console.WriteLine("Nieprawidłowa cena.");
                    continue;
                }

                // Tworzenie nowego produktu i dodanie go do magazynu  
                Produkt p = new Produkt("123456", name, price, quantity);
                magazyn.Add(p);

                // Wyświetlenie informacji o dodanym produkcie  
                Console.WriteLine("Produkt z kodem " + p.BarCode +
                                  " o nazwie " + p.Name +
                                  " kosztuje " + p.Price + " zł i ma ilość " + p.Quantity);
            }
            else if (opcja == "2")
            {
                // Usuwanie produktu  
                Console.WriteLine("Podaj nazwę produktu do usunięcia:");
                string? nameToRemove = Console.ReadLine();

                // Sprawdzenie czy nazwa produktu do usunięcia nie jest pusta  
                if (string.IsNullOrEmpty(nameToRemove))
                {
                    Console.WriteLine("Nazwa produktu nie może być pusta.");
                    continue;
                }

                // Wyszukanie produktu do usunięcia  
                Produkt? produktDoUsuniecia = null;
                foreach (var produkt in magazyn)
                {
                    if (produkt.Name == nameToRemove)
                    {
                        produktDoUsuniecia = produkt;
                        break;
                    }
                }

                // Usunięcie produktu z magazynu  
                if (produktDoUsuniecia != null)
                {
                    magazyn.Remove(produktDoUsuniecia);
                    Console.WriteLine("Produkt " + nameToRemove + " został usunięty.");
                }
                else
                {
                    Console.WriteLine("Produkt o nazwie " + nameToRemove + " nie istnieje.");
                }
            }
            else if (opcja == "3")
            {
                // Wyświetlanie listy produktów  
                if (magazyn.Count == 0)
                {
                    Console.WriteLine("Magazyn jest pusty.");
                }
                else
                {
                    Console.WriteLine("Lista produktów w magazynie:");
                    foreach (var produkt in magazyn)
                    {
                        Console.WriteLine($"Nazwa: {produkt.Name}, Ilość: {produkt.Quantity}, Cena: {produkt.Price} zł");
                    }
                }
            }
            else
            {
                // Obsługa nieprawidłowej opcji  
                Console.WriteLine("Nieprawidłowa opcja.");
            }
        }
    }
}



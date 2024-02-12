using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, (string name, double price)> menu = new Dictionary<int, (string, double)>()
        {
            { 1, ("Coca Cola 150 ml", 2.50) },
            { 2, ("Insalata di pollo", 5.20) },
            { 3, ("Pizza Margherita", 10.00) },
            { 4, ("Pizza 4 Formaggi", 12.50) },
            { 5, ("Pz patatine fritte", 3.50) },
            { 6, ("Insalata di riso", 8.00) },
            { 7, ("Frutta di stagione", 5.00) },
            { 8, ("Pizza fritta", 5.00) },
            { 9, ("Piadina vegetariana", 6.00) },
            { 10, ("Panino Hamburger", 7.90) }
        };

        List<(string name, double price)> selectedItems = new List<(string, double)>();

        while (true)
        {
            Console.WriteLine("==============MENU==============");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key}: {item.Value.name} (€ {item.Value.price.ToString("F2")})");
            }
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");

            Console.Write("Seleziona un cibo (1-11): ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 11)
            {
                Console.WriteLine("Scelta non valida. Riprova.");
                continue;
            }

            if (choice == 11)
            {
                Console.WriteLine("Hai selezionato il conto finale:");
                double totalPrice = CalculateTotalPrice(selectedItems);
                Console.WriteLine($"Costo finale (comprensivo di servizio al tavolo di € 3.00): € {totalPrice + 3.00}");
                break;
            }
            else
            {
                selectedItems.Add(menu[choice]);
                Console.WriteLine($"Hai aggiunto \"{menu[choice].name}\" al tuo ordine.");
            }
        }
    }

    static double CalculateTotalPrice(List<(string name, double price)> selectedItems)
    {
        double totalPrice = 0;
        foreach (var item in selectedItems)
        {
            totalPrice += item.price;
        }
        return totalPrice;
    }
}

// SUT24 Alexander Ek
namespace Coffe_Machine;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true; // Variabel för att hålla reda på om programmet ska fortsätta köra
        decimal totalAmount = 0; // Variabel för att hålla reda på det totala beloppet
        while (isRunning) // En loop som körs så länge isRunning är sant
        {
            Console.WriteLine("\nVälkommen till din virtuella kaffemaskin!");
            Console.WriteLine("\nVad vill du ha idag?:");
            Console.WriteLine("1. Liten kaffe 10 kr");
            Console.WriteLine("2. Mellan kaffe 15 kr");
            Console.WriteLine("3. Stor kaffe 20 kr");
            Console.WriteLine("4. Avsluta och betala");

            // Läs användarens val och kontrollera om det är en giltig siffra
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
                continue; // Gå till nästa iteration om inmatningen är ogiltig
            }

            // Switch-sats för att hantera användarens val
            switch (input)
            {
                case 1: // Om användaren väljer liten kaffe
                    Console.WriteLine("Du har valt Liten kaffe.");
                    totalAmount += 10; // Lägg till 10 kr till det totala beloppet
                    break;
                case 2: // Om användaren väljer mellan kaffe
                    Console.WriteLine("Du har valt Mellan kaffe.");
                    totalAmount += 15; // Lägg till 15 kr till det totala beloppet
                    break;
                case 3: // Om användaren väljer stor kaffe
                    Console.WriteLine("Du har valt Stor kaffe.");
                    totalAmount += 20; // Lägg till 20 kr till det totala beloppet
                    break;
                case 4: // Om användaren väljer att avsluta
                    Console.WriteLine($"Tack för din beställning! Ditt totala belopp är {totalAmount} kr.");
                    isRunning = false; // Stoppa loopen och avsluta programmet
                    break;
                default: // Om användaren väljer ett ogiltigt alternativ
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }

            // Efter varje val frågar vi om användaren vill beställa mer
            if (isRunning)
            {
                Console.WriteLine("Vill du beställa mer? (ja/nej)");
                string answer = Console.ReadLine().ToLower(); // Läs in användarens svar och omvandla till små bokstäver

                // Om användaren skriver "nej" avslutas programmet
                if (answer == "nej")
                {
                    Console.WriteLine($"Tack för din beställning! Ditt totala belopp är {totalAmount} kr.");
                    isRunning = false; // Stoppa loopen och avsluta programmet
                }
            }
        }
    }
}
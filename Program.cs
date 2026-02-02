using System; 


class Program
{
    static void Main()
    {
        Random random = new Random();
        
        int SecretNumber = random.Next(1,11);
        int guess = 0; 
        int attempts = 0; 

        Console.WriteLine("Rate eine Zahl von 1 - 10.");

        while (guess != SecretNumber)
        {
            Console.Write("Gibt eine Zahl ein: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Bitte eine Zahl eingeben!");
                continue;
            }

            attempts++;

            if (guess < SecretNumber)
                Console.WriteLine("Deine Zahl ist zu niedrig!");
            else if (guess > SecretNumber)
                Console.WriteLine("Deie Zahl ist zu Hoch");
        }

        Console.WriteLine($"Richtig! Du hast {attempts} Versuche gebraucht.");

    }
}

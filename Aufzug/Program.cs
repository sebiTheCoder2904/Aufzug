namespace Aufzug
{
    internal class Program
    {
        static void typeString(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            // Console.WriteLine("");
        }

        static void typeString_middle(int yPoss, string text, int delay)
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) - (text.Length / 2), yPoss);
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine("");
        }

        static void Main()
        {
            int FloorNumber = 0;
            int FloorTotal = 5;
            int elevatorSpeed = 500;

            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("lalalalala");
            Console.ReadKey();

        }
    }
}



// Aufzug programmier Plan
//  #1 Stockwerk eingabe
//  #2 Eingabe check
//  #3 animation mit farben
//  #4 alles in nen Loop
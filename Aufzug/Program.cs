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

        static int driveElevator(int fromFloor, int toFloor, int FloorTotal, int speed) 
        {
            int FloorDiff = toFloor+1 - fromFloor;
            if (toFloor > FloorTotal)
            {
                Console.SetCursorPosition(2, 4);
                Console.Write("Dieses Stockwerk giebt es nicht!");
                Thread.Sleep(700);
                Console.SetCursorPosition(2, 4);
                Console.Write("                                ");
                return fromFloor;
            }
            else
            {
                movePointer(fromFloor * 2 + 1, toFloor * 2 + 1, speed);
                return toFloor;
            }
        }

        static void movePointer(int from, int to, int Speed) 
        {
            int diff = to - from;
            if (diff > 0)
            {
                for (int i = from; i != to + 1; i++) // Aufzug nach oben
                {
                    Console.SetCursorPosition(i - 1, 8);
                    Console.Write("  ^");
                    Thread.Sleep(Speed);
                    

                }
            }
            else if (diff < 0)
            {
                for (int i = from; i != to - 1; i--) // Aufzug nach unten
                {
                    Console.SetCursorPosition(i + 1, 8);
                    Console.Write("^  ");
                    Thread.Sleep(Speed);
                }
            }
        }

        static void Main()
        {
            int FloorTotal = 8;
            int FloorNow = 1;

            Console.SetCursorPosition(2, 7);
            Console.Write("1 2 3 4 5 6 7 8 9");
            while (true)
            {
                Console.SetCursorPosition(2, 3);
                Console.Write("Strockwerk: __");
                Console.SetCursorPosition(14, 3);
                int FloorTo = int.Parse(Console.ReadLine());
                FloorNow = driveElevator(FloorNow, FloorTo - 1, FloorTotal, 400);
                Thread.Sleep(1000);
            }

        }
    }
}



// Aufzug programmier Plan
//  #1 Stockwerk eingabe
//  #2 Eingabe check
//  #3 animation mit farben
//  #4 alles in nen Loop
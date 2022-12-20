namespace Sensoren_Ampel
{
    internal class Program
    {
        static Serverraum ser1 = new(21, 26, 27);
        static Serverraum ser2 = new(23, 34, 27);
        static Serverraum ser4 = new(27, 33, 40);
        static Serverraum ser5 = new(29, 26, 27);

        static void Main(string[] args)
        {
            Ausgabe(ser1,Serverraum.Zustand.Green);
            Ausgabe(ser2,Serverraum.Zustand.Yellow);
            Ausgabe(ser4,Serverraum.Zustand.Red);
            Ausgabe(ser5,Serverraum.Zustand.Red);//Green
        }
        public static void Ausgabe(Serverraum ser, Serverraum.Zustand farbe)
        {
            Console.WriteLine("");
            Console.Write("Getest: ");
            var farbe_test = ser.Messe_Werte();

            if (farbe_test == Serverraum.Zustand.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(farbe_test);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (farbe_test == Serverraum.Zustand.Yellow)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(farbe_test);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(farbe_test);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write("Erwartet: ");
            if (farbe == Serverraum.Zustand.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(farbe);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (farbe == Serverraum.Zustand.Yellow)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(farbe );
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(farbe );
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (farbe_test==farbe)
                Console.WriteLine("Test erfolgreich");
            else
                Console.WriteLine("Test fehlgeschlagen");
            Console.WriteLine("----------------------------");

        }
    }
}
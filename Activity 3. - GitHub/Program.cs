
internal class Program
{
    private static void Main(string[] args)
    {
        int punctuation = 0;
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();

            tecla = Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Main menu");
            Console.WriteLine("Press 1 for tobacco");
            Console.WriteLine("Press 2 for beer");
            Console.WriteLine("Press 3 or vodka");
            Console.WriteLine("Press 4 for coffee");
            Console.WriteLine("Press 5 for football");
            Console.WriteLine("Press 6 or tattoos");
            Console.WriteLine("Press 7 for dolphins");
            Console.WriteLine("Press 8 for basketball");
            Console.WriteLine("Press 9 or tennis");
            Console.WriteLine("Press 0 to exit");

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoTobacco(punctuation);
                    break;

                case ConsoleKey.D2:
                    DoBeer(punctuation);
                    break;

                case ConsoleKey.D3:
                    DoVodka(punctuation);
                    break;

                case ConsoleKey.D4:
                    DoCoffee(punctuation);
                    break;

                case ConsoleKey.D5:
                    DoFootball(punctuation);
                    break;

                case ConsoleKey.D6:
                    DoTattoos(punctuation);
                    break;

                case ConsoleKey.D7:
                    DoDolphins(punctuation);
                    break;

                case ConsoleKey.D8:
                    DoBasketball(punctuation);
                    break;

                case ConsoleKey.D9:
                    DoTennis(punctuation);
                    break;

                case ConsoleKey.D0:
                    Console.WriteLine("Congratulations your punctuation is {0} points!", punctuation);
                    Console.WriteLine("THANK YOU FOR PLAYING!");
                    MsgNextScreen("PRESS ANY KEY 2 EXIT");
                    break;

                default:
                    MsgNextScreen("Error. Preu una tecla per tornar al menú...");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);

        Console.WriteLine($"CONGRATULATIONS YOUR PUNCTUATION IS {punctuation}!");
    }
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }

    //Pol Ventura
    
    //Pol Besalú

    //Martí Roura
}
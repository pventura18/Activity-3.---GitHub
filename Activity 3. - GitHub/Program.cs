
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
﻿
internal class Program
{

    #region Menu
    private static void Main(string[] args)
    {
        int score = 0;
        ConsoleKeyInfo tecla;

        do
        {
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

            tecla = Console.ReadKey();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    //DoTobacco(punctuation);
                    break;

                case ConsoleKey.D2:
                    //DoBeer(punctuation);
                    break;

                case ConsoleKey.D3:
                    DoVodka(ref score);
                    break;

                case ConsoleKey.D4:
                    //DoCoffee(punctuation);
                    break;

                case ConsoleKey.D5:
                    //DoFootball(punctuation);
                    break;

                case ConsoleKey.D6:
                    //DoTattoos(punctuation);
                    break;

                case ConsoleKey.D7:
                    //DoDolphins(punctuation);
                    break;

                case ConsoleKey.D8:
                    //DoBasketball(punctuation);
                    break;

                case ConsoleKey.D9:
                    //DoTennis(punctuation);
                    break;

                case ConsoleKey.D0:
                    Console.WriteLine("Congratulations your punctuation is {0} points!", score);
                    Console.WriteLine("THANK YOU FOR PLAYING!");
                    MsgNextScreen("PRESS ANY KEY 2 EXIT");
                    break;

                default:
                    MsgNextScreen("Error. Preu una tecla per tornar al menú...");
                    break;
            }
            MsgNextScreen($"YOUR CURRENT PUNCTUATION IS {score}!");
        } while (tecla.Key != ConsoleKey.D0);

        Console.WriteLine($"CONGRATULATIONS YOUR PUNCTUATION IS {score}!");
    }
    #endregion

    #region Commons
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }
    public static int PressKey(ConsoleKey correctOption)
    {
        ConsoleKeyInfo tecla = Console.ReadKey();
        switch (tecla.Key)
        {
            case var value when tecla.Key == correctOption:
                Console.WriteLine("CORRECT! +1 POINT");
                return 1;
            default:
                Console.WriteLine("INCORRECT! 0 POINTS");
                return 0;
        }
    }
    #endregion

    #region Pol Ventura
    public static void DoVodka(ref int score)
    {
        Console.Clear();
        MsgNextScreen("YOU CHOSE THE VODKA QUIZ! PRESS ANY KEY TO START");
        ConsoleKeyInfo key;

        Console.WriteLine("Question 1: For what was firstly vodka used?");
        Console.WriteLine("1 - For medical purposes");
        Console.WriteLine("2 - To get drunk");
        Console.WriteLine("3 - To gain more force in the gym");
        Console.WriteLine("4 - So people can go to war without arguing");

        score += PressKey(ConsoleKey.D1);

        Console.WriteLine("Question 2: Where was vodka created?");
        Console.WriteLine("1 - In Spain");
        Console.WriteLine("2 - In Germany");
        Console.WriteLine("3 - In Poland");
        Console.WriteLine("4 - In Russia");

        score += PressKey(ConsoleKey.D3);

        Console.WriteLine("Question 3: What does vodka contain?");
        Console.WriteLine("1 - Cholesterol");
        Console.WriteLine("2 - Sodium");
        Console.WriteLine("3 - Carbs");
        Console.WriteLine("4 - Just water and ethanol");

        score += PressKey(ConsoleKey.D4);

        Console.WriteLine("Question 4: Vodka comes from the Russian word...");
        Console.WriteLine("1 - Vodca");
        Console.WriteLine("2 - Borca");
        Console.WriteLine("3 - Voda");
        Console.WriteLine("4 - Vroda");

        score += PressKey(ConsoleKey.D3);

        Console.WriteLine("Question 5: Had vodka been banned in Russia?");
        Console.WriteLine("1 - Yes, during WW1");
        Console.WriteLine("2 - Yes, during cold war");
        Console.WriteLine("3 - Yes, during WW2");
        Console.WriteLine("4 - No, never");

        score += PressKey(ConsoleKey.D1);

        MsgNextScreen("PRESS ANY KEY TO CONTINUE!");
    }
    #endregion

    #region Pol Besalú
    #endregion

    #region Martí Roura
    #endregion
}
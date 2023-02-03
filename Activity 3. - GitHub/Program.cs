
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
                    DoTobacco(ref score);
                    break;

                case ConsoleKey.D2:
                    //DoBeer(punctuation);
                    break;

                case ConsoleKey.D3:
                    DoVodka(ref score);
                    break;

                case ConsoleKey.D4:
                    DoCoffee(ref score);
                    break;

                case ConsoleKey.D5:
                    //DoFootball(punctuation);
                    break;

                case ConsoleKey.D6:
                    DoTattoos(score);
                    break;

                case ConsoleKey.D7:
                    //DoDolphins(punctuation);
                    break;

                case ConsoleKey.D8:
                    DoBasketball(ref score);
                    break;

                case ConsoleKey.D9:
                    DoTennis(score);
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

    //Pol Ventura
    #region Pol Ventura
    public static void DoVodka(ref int score)
    {
        Console.Clear();
        MsgNextScreen("YOU CHOSE THE VODKA QUIZ! PRESS ANY KEY TO START");
        

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


    public static void DoTattoos(ref int score)
    {
        Console.Clear();
        MsgNextScreen("YOU CHOSE THE TATTOO QUIZ! PRESS ANY KEY TO START");

        Console.WriteLine("Question 1: Does your hair grow back with a tattoo?");
        Console.WriteLine("1 - Yes, but less hair.");
        Console.WriteLine("2 - No");
        Console.WriteLine("3 - Yes, but it falls");
        Console.WriteLine("4 - It doesn't change anything");

        score += PressKey(ConsoleKey.D4);


        Console.WriteLine("Question 2: Which type of ink does it hurt the most?");
        Console.WriteLine("1 - Bright ink");
        Console.WriteLine("2 - Dark ink");
        Console.WriteLine("3 - It doesn't hurt");
        Console.WriteLine("4 - They all hurt the same");

        score += PressKey(ConsoleKey.D4);


        Console.WriteLine("Question 3: It is good to drink alcohol before a tattoo?");
        Console.WriteLine("1 - No, it makes you bleed more");
        Console.WriteLine("2 - No, it makes the tattoo hurt more");
        Console.WriteLine("3 - Yes, why not?");
        Console.WriteLine("4 - Yes, it helps you feel less pain");

        score += PressKey(ConsoleKey.D1);

        Console.WriteLine("Question 4: Chlorinated pool water discolours the tattoo?");
        Console.WriteLine("1 - No, it helps you to have more color in the tattoo");
        Console.WriteLine("2 - No, but it is recommended not to go to the pool if it is not healed");
        Console.WriteLine("3 - No, but it changes the colors of the tattoo for example making black tattoos blue");
        Console.WriteLine("4 - Yes");

        score += PressKey(ConsoleKey.D2);

        Console.WriteLine("Question 5: Having a tattoo makes you a bad person?");
        Console.WriteLine("1 - Yes, if my son gets a tattoo he is a criminal");
        Console.WriteLine("2 - If someone has a tattoo, this person is a murderer");
        Console.WriteLine("3 - No, it is just an artisitc movement");
        Console.WriteLine("4 - No, but it's not healthy");

        score += PressKey(ConsoleKey.D3);

        MsgNextScreen("PRESS ANY KEY TO CONTINUE!");
    }

    public static void DoTennis(ref int score)
    {
        Console.Clear();
        MsgNextScreen("YOU CHOSE THE TENNIS QUIZ! PRESS ANY KEY TO START");

        Console.WriteLine("Question 1: From what Anglo-Norman term does the word tennis come?");
        Console.WriteLine("1 - Tennet");
        Console.WriteLine("2 - Tinis");
        Console.WriteLine("3 - Tenez");
        Console.WriteLine("4 - Tonees");

        score += PressKey(ConsoleKey.D3);


        Console.WriteLine("Question 2: When was the first Wimbledon played?");
        Console.WriteLine("1 - 1932");
        Console.WriteLine("2 - 1877");
        Console.WriteLine("3 - 1899");
        Console.WriteLine("4 - Yesterday");

        score += PressKey(ConsoleKey.D2);


        Console.WriteLine("Question 3: How much time did the longest match last?");
        Console.WriteLine("1 - 9 hours and 30 minutes");
        Console.WriteLine("2 - 15 hours and 3 minutes");
        Console.WriteLine("3 - 11 hours and 5 minutes");
        Console.WriteLine("4 - 10 hours and 1 minute");

        score += PressKey(ConsoleKey.D1);

        Console.WriteLine("Question 4: Which one is NOT a professional tennis court surface?");
        Console.WriteLine("1 - Clay");
        Console.WriteLine("2 - Glass");
        Console.WriteLine("3 - Carpet");
        Console.WriteLine("4 - Sand");

        score += PressKey(ConsoleKey.D4);

        Console.WriteLine("Question 5: How many Grand Slams does Rafael Nadal have?");
        Console.WriteLine("1 - 22");
        Console.WriteLine("2 - 0");
        Console.WriteLine("3 - 12");
        Console.WriteLine("4 - 16");

        score += PressKey(ConsoleKey.D1);

        MsgNextScreen("PRESS ANY KEY TO CONTINUE!");
    }

    #endregion



    //Pol Besalú


    #region Pol Besalú
    public static void DoCoffee(ref int score)
    {
        Console.Clear();
        MsgNextScreen("YOU CHOSE THE COFFEE QUIZ! PRESS ANY KEY TO START");
        ConsoleKeyInfo key;

        Console.WriteLine("Question 1: What is coffee?");
        Console.WriteLine("1 - A type of seed");
        Console.WriteLine("2 - A drink");
        Console.WriteLine("3 - A social event");
        Console.WriteLine("4 - A tobacco brand");

        score += PressKey(ConsoleKey.D1);

        Console.WriteLine("Question 2: What is the coffee originary from?");
        Console.WriteLine("1 - Spain");
        Console.WriteLine("2 - France");
        Console.WriteLine("3 - Etiopia");
        Console.WriteLine("4 - Colombia");

        score += PressKey(ConsoleKey.D3);

        Console.WriteLine("Question 3: What does coffee do to your body?");
        Console.WriteLine("1 - Makes it more sensitive to enviromental changes");
        Console.WriteLine("2 - Relax it");
        Console.WriteLine("3 - Makes it more powerfull");
        Console.WriteLine("4 - Stress it");

        score += PressKey(ConsoleKey.D4);

        Console.WriteLine("Question 4: Coffee is tastes better...");
        Console.WriteLine("1 - With sugar");
        Console.WriteLine("2 - Soy milk");
        Console.WriteLine("3 - Alone if you put something in your coffee you don't actually like coffee");
        Console.WriteLine("4 - Almond milk");

        score += PressKey(ConsoleKey.D3);

        Console.WriteLine("Question 5: Is coffee healthy?");
        Console.WriteLine("1 - No, never");
        Console.WriteLine("2 - Yes");
        Console.WriteLine("3 - Yes, in little quantities");
        Console.WriteLine("4 - No, but helps you fall asleep");

        score += PressKey(ConsoleKey.D3);

        MsgNextScreen("PRESS ANY KEY TO CONTINUE!");
    }
    public static void DoTobacco(ref int score)
    {
        Console.Clear();
        MsgNextScreen("YOU CHOSE THE TOBACCO QUIZ! PRESS ANY KEY TO START");
        ConsoleKeyInfo key;

        Console.WriteLine("Question 1: What is the most buyed tobacco?");
        Console.WriteLine("1 - Marlboro");
        Console.WriteLine("2 - Camel");
        Console.WriteLine("3 - Pall Mall");
        Console.WriteLine("4 - Ducados");

        score += PressKey(ConsoleKey.D1);

        Console.WriteLine("Question 2: What country smokes the most?");
        Console.WriteLine("1 - Spain");
        Console.WriteLine("2 - France");
        Console.WriteLine("3 - Andorra");
        Console.WriteLine("4 - Argentina");

        score += PressKey(ConsoleKey.D3);

        Console.WriteLine("Question 3: What does tobacco contain?");
        Console.WriteLine("1 - Style");
        Console.WriteLine("2 - Proteins");
        Console.WriteLine("3 - A car");
        Console.WriteLine("4 - Substances that may provoke cancer");

        score += PressKey(ConsoleKey.D4);

        Console.WriteLine("Question 4: Tobacco comes from...");
        Console.WriteLine("1 - Spain");
        Console.WriteLine("2 - France");
        Console.WriteLine("3 - America");
        Console.WriteLine("4 - Congo"); 

        score += PressKey(ConsoleKey.D3);

        Console.WriteLine("Question 5: Is tobacco healthy?");
        Console.WriteLine("1 - No, never");
        Console.WriteLine("2 - Yes");
        Console.WriteLine("3 - Yes, in little quantities");
        Console.WriteLine("4 - No, but helps your pulmonar capacity");

        score += PressKey(ConsoleKey.D1);

        MsgNextScreen("PRESS ANY KEY TO CONTINUE!");
    }
    public static void DoBasketball(ref int score)
    {
        Console.Clear();
        MsgNextScreen("YOU CHOSE THE BASKETBALL QUIZ! PRESS ANY KEY TO START");
        ConsoleKeyInfo key;

        Console.WriteLine("Question 1: Who is the Greek freak?");
        Console.WriteLine("1 - Gianis Antetokounmpo");
        Console.WriteLine("2 - Michael Jordan");
        Console.WriteLine("3 - Lebron James");
        Console.WriteLine("4 - Kevin Durant");

        score += PressKey(ConsoleKey.D1);

        Console.WriteLine("Question 2: Who has scored more three pointers in all the NBA history?");
        Console.WriteLine("1 - Kevin Love");
        Console.WriteLine("2 - Damian Lillard");
        Console.WriteLine("3 - Stephen Curry");
        Console.WriteLine("4 - Larry Bird");

        score += PressKey(ConsoleKey.D3);

        Console.WriteLine("Question 3: What is the duration of a basketball match?");
        Console.WriteLine("1 - 50 minutes");
        Console.WriteLine("2 - 90 minutes");
        Console.WriteLine("3 - 180 minutes");
        Console.WriteLine("4 - 40 minutes");

        score += PressKey(ConsoleKey.D4);

        Console.WriteLine("Question 4: Who is the man that scored more points in a match of the NBA");
        Console.WriteLine("1 - Michael Jordan");
        Console.WriteLine("2 - Kobe Bryant");
        Console.WriteLine("3 - Wilt Chamberlain");
        Console.WriteLine("4 - Denis Rodman");

        score += PressKey(ConsoleKey.D3);

        Console.WriteLine("Question 5: Which basketball player doesn't have a shoe brand?");
        Console.WriteLine("1 - Chandler Parsons");
        Console.WriteLine("2 - Michael Jordan");
        Console.WriteLine("3 - Shaquille Oneal");
        Console.WriteLine("4 - Kyre Irving");

        score += PressKey(ConsoleKey.D1);

        MsgNextScreen("PRESS ANY KEY TO CONTINUE!");
    }
    #endregion

    #region Martí Roura
    #endregion
}

using System;
namespace Dilmon;
public class Program
{
    public static string userName = " ";
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the adventures of DILMON! Please be patient as the game loads.\n");
        Thread.Sleep(3000);
        Console.Clear();
        //IntroTimer();
        Console.Clear();
        beginningThing();
    }
    public static void beginningThing()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Thread.Sleep(1000);
        Console.WriteLine("*As you walk near the town borders you see a man*\n");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Thread.Sleep(1000);
        Console.WriteLine("Unknown: Welcome traveler, it appears you have stumbled upon our humbled abode.\n");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("1. Talk to Unknown         2. Stare at Unknown");
        Console.WriteLine("3. Talk to someone else    4. Leave");
        Console.ForegroundColor = ConsoleColor.Cyan;
        string userInput = Console.ReadLine();
        if (userInput == "1")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("User: I'm looking for the professor. Are you the professor?\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Jeff: Ah yes, I forgot to introduce myself.\nI'm professor Jeff Alder, you can just call me Jeff.");
            Thread.Sleep(2000);
            Console.WriteLine("But before we continue, what might your name be?");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            NameUser();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Thread.Sleep(1500);
            Console.WriteLine($"Jeff: Amazing name, {userName}!");
            Thread.Sleep(1500);
            Console.WriteLine("This beautiful town is home to many people, including monsters.");
            Thread.Sleep(2000);
            Console.WriteLine("Here, if you want to undertstand this better, I can show you around my house.\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Continue with Jeff        2. Talk to someone else");
            Console.WriteLine("3. Leave");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string userJeff = Console.ReadLine();

            if (userJeff == "1")
            {

                Console.Clear();
                Thread.Sleep(1000);
                doorOpen();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen2();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen3();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen4();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen5();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen6();
                Thread.Sleep(250);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*As you enter the house, you notice a machine with a big display screen on it.*\n");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Jeff: Here is THE BOX!\n");
                Thread.Sleep(2000);
                theBox();
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{userName}: What does this box do?\n");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Thread.Sleep(2000);
                Console.WriteLine("Jeff: I'm glad you asked! This box is a new technology that has revolutionized the game of DILMON");
                Thread.Sleep(2000);
                Console.WriteLine("Before I go into more detail, here's something I think you'll like.");
                Thread.Sleep(1000);
                Console.Write("These");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.WriteLine("\nThese are called DILMON");
                Thread.Sleep(1000);
                Console.WriteLine("You can choose any of these.");
                Thread.Sleep(1000);
                Dilmon.DisplayStarters();
                Dilmon.DisplayDilmonMoves();
            }
            else if(userJeff == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*Off to your left you notice an older gentleman who looks like Dumbledore*");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("User: Hi sir, do you have any knowledge that you can tell me?");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Albus: Uhh idk, Don't die?");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("User: Are you being seirous");
                Thread.Sleep(4000);
                beginningThing();
            }
            else if(userJeff == "3")
            {
                Console.Clear();
                Thread.Sleep(2000);
                Console.WriteLine("You choose to end your Dilmon run");
            }
        }
        else if (userInput == "2")
        {
            Console.Clear();
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*You begin staring at Jeff for a prolonged period of time.*\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Jeff: Sir, I don't like how you are staring at me.");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*Jeff is getting angry*\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("User: Wow man, its not that serious.\n");
            Thread.Sleep(2000);
            Random random = new Random();
            int jeffRandom = random.Next(1,3);
            if(jeffRandom == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Ok, I guess.");
                Thread.Sleep(4000);
                beginningThing();
            }
            else if(jeffRandom == 2)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Ok, that's is it man!");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Thread.Sleep(2000);
                Console.WriteLine("*Jeff proceeds to summon a dilmon called Yondu, Jeff ends your run *");
            }
        }
        else if (userInput == "3")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*Off to the right you notice an older gentleman who looks like Gandalf*\n *Maybe he has some ancient wisdom*");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("User: Hello sir, what knowledge can I consume through your wisdom?\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Fladnag: Uh sir");
            dotTimer();
            Console.WriteLine("I hope you do realize I'm not intelligent\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("User: What do you mean? You look like Gandalf.\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Fladnag: Just because I look like Gandalf and Fladnag is Gandalf backwards doesn't mean I'm intelligent.");
            Thread.Sleep(2000);
            Console.WriteLine("Fladnag: I'm just joking! \n My ancient wisdom is");
            Thread.Sleep(2000);
            Console.WriteLine("Drink Water :)");
            Thread.Sleep(4000);
            beginningThing();
        }
        else if (userInput == "4")
        {
            Console.Clear();
            Console.WriteLine("You choose to end your Dilmon run.");
        }
    }
    public static void IntroTimer()
    {
        Console.Write("""
        |    /\    |   _______       _      _
        |   /  \   |  |_|     |     |_|   _| |_
        |  /    \  |    ______|      _   |_   _|
        | /      \ |   /     _|     | |    | |
        |/        \|   \____/ |_|   |_|    |_|
        """);
        dotTimer();
        Thread.Sleep(1000);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Loading ");
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 1; i <= 100; i++)
        {
            Console.Write("▅");
            Thread.Sleep(50);
        }
    }
    public static void doorOpen()
    {
        Console.WriteLine("""
         _______________
        |               |
        |               |
        |               |
        |               |
        |               |
        |           -0  |
        |               |
        |               |
        |               |
        |_______________|
        """);
    }
    public static void doorOpen2()
    {
        Console.WriteLine("""
         _______________
        |            |  |
        |            |  |
        |            |  |
        |            |  |
        |            |  |
        |         -o |  |
        |            |  |
        |            |  |
        |            |  |
        |____________|__|
        """);
    }
    public static void doorOpen3()
    {
        Console.WriteLine("""
         _______________
        |          |    |
        |          |    |
        |          |    |
        |          |    |
        |          |    |
        |       -o |    |
        |          |    |
        |          |    |
        |          |    |
        |__________|____|
        """);
    }
    public static void doorOpen4()
    {
        Console.WriteLine("""
         _______________
        |       |       |
        |       |       |
        |       |       |
        |       |       |
        |       |       |
        |    -o |       |
        |       |       |
        |       |       |
        |       |       |
        |_______|_______|
        """);
    }
    public static void doorOpen5()
    {
        Console.WriteLine("""
         _______________
        |  |            |
        |  |            |
        |  |            |
        |  |            |
        |  |            |
        |-o|            |
        |  |            |
        |  |            |
        |  |            |
        |__|____________|
        """);
    }
    public static void doorOpen6()
    {
        Console.WriteLine("""
         _______________
        |               |
        |               |
        |               |
        |               |
        |               |
        |               |
        |               |
        |               |
        |               |
        |_______________|
        """);
    }
    public static void theBox()
    {
        Console.WriteLine("""
         __________________
        | ________________ |
        ||       __       ||C]
        ||     -|__|-     ||C]
        ||________________||C]
        |                  |
        |                  |
        |    88      88    |
        |  88  88  88  88  |
        |    88      88    |
        |__________________|
        """);
    }
    public static void dotTimer()
    {
        for (int dot = 1; dot <= 3; dot++)
        {
            Console.Write(" . ");
            Thread.Sleep(1500);
        }
    }
    public static void NameUser()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("What would you like to name your character?");
        Console.ForegroundColor = ConsoleColor.Cyan;
        string enterUserName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Are you sure you want to be called {enterUserName}? Y/N");
        Console.ForegroundColor = ConsoleColor.Cyan;
        string yesNoForName = Console.ReadLine();
        if (yesNoForName == "y")
        {
            userName = enterUserName;
        }
        else
        {
            NameUser();
        }
    }
}
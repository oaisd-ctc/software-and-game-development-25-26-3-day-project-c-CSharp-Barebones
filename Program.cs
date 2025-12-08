using System;
public class Program
{
    public static void Main(string[] args)
    {



        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to menu with one option!");
            Console.WriteLine("shop = s");
            Console.WriteLine("exit = e");

            string input = Console.ReadLine() ?? ""; //I tell it to ignore null with '??'
            input = input.ToLower(); // any cap letter is auto lower case so both cases are accpeted

            switch (input) //This is the switch box method i was talking about.
            {
                case "s":
                    ShopRunner();
                    break;

                case "e":
                    return;
            }
        }

        static void ShopRunner() //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!START OF SHOP RUNNER
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------- Welcome to Tractor Supplier shop! -------------------- ");
                Thread.Sleep(0500);
                Console.WriteLine("");
                Console.WriteLine("\nWe currently have three available options for you to choose from!");
                Thread.Sleep(0500);
                Console.WriteLine("\nMower worst = >1< ----- $0 (Free)");
                Thread.Sleep(0500);
                Console.WriteLine("Mower mid = >2< --------- $100 (For the Middle Class)");
                Thread.Sleep(0500);
                Console.WriteLine("Mower best = >3< -------- $500 (If you are rich and have pocket money)");
                Thread.Sleep(0500);
                Console.WriteLine("Type 'e' to exit menu.");

                string choice = Console.ReadLine() ?? "";
                choice = choice.ToLower();

                switch (choice)
                {
                    case "1":
                        MowerWorst();
                        break;

                    case "2":
                        MowerMid();
                        break;

                    case "3":
                        MowerBest();
                        break;

                    case "e":
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n\n\nInvalid Operation.");
                        Thread.Sleep(0500);
                        Console.WriteLine("Type any key to continue");
                        Console.ReadKey();
                        break;
                }

                static void MowerWorst()
                {
                Recycle1: //goto's restart
                    Console.Clear();
                    string Confirm;
                    Console.WriteLine("\nAre you sure you want to use Mower Worst for $0?");
                    Console.WriteLine("\nYes = yes \nNo = no.");

                    Confirm = Console.ReadLine() ?? "";
                    Confirm = Confirm.ToLower();

                    if (Confirm != "yes" && Confirm != "no")
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nNot a valid yes or no.");
                        Console.WriteLine("Type any key to continue.");
                        Console.ReadKey();
                        goto Recycle1;
                    }
                    else if (Confirm == "yes")
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for your perchase of Mower 1!");
                        Thread.Sleep(0500);
                        Console.WriteLine("An invoice will be sent to jeb_@mowerCompany.com");
                        Thread.Sleep(0500);
                        Console.WriteLine("Type any key to continue");
                        Console.ReadKey();

                        //add the logic for the tractor to take place here for the game play
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry that you were not satisfied.");
                        Thread.Sleep(0500);
                        Console.WriteLine("Hope to see you oh so very soon!");
                        Thread.Sleep(0500);
                        Console.WriteLine("Type any key to continue");
                        Console.ReadKey();
                        return;
                    }
                }

                static void MowerMid() //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!MID
                {
                Recycle2: //goto's restart
                    Console.Clear();
                    string Confirm;
                    Console.WriteLine("\nAre you sure you want to use Mower Mid for $100?");
                    Console.WriteLine("\nYes = yes \nNo = no.");

                    Confirm = Console.ReadLine() ?? "";
                    Confirm = Confirm.ToLower();

                    if (Confirm != "yes" && Confirm != "no")
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nNot a valid yes or no.");
                        Console.WriteLine("Type any key to continue.");
                        Console.ReadKey();
                        goto Recycle2;
                    }
                    else if (Confirm == "yes")
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for your perchase of Mower 2!");
                        Thread.Sleep(0500);
                        Console.WriteLine("An invoice will be sent to jeb_@mowerCompany.com");
                        Thread.Sleep(0500);
                        Console.WriteLine("Type any key to continue");
                        Console.ReadKey();

                        //add the logic for the tractor to take place here for the game play
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry that you were not satisfied.");
                        Thread.Sleep(0500);
                        Console.WriteLine("Hope to see you oh so very soon!");
                        Thread.Sleep(0500);
                        Console.WriteLine("Type any key to continue");
                        Console.ReadKey();
                        return;
                    }
                }
                static void MowerBest() //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!BEST
                {
                Recycle3: //goto's restart
                    Console.Clear();
                    string Confirm;
                    Console.WriteLine("\nAre you sure you want to use Mower Best for $500?");
                    Console.WriteLine("\nYes = yes \nNo = no.");

                    Confirm = Console.ReadLine() ?? "";
                    Confirm = Confirm.ToLower();

                    if (Confirm != "yes" && Confirm != "no")
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nNot a valid yes or no.");
                        Console.WriteLine("Type any key to continue.");
                        Console.ReadKey();
                        goto Recycle3;
                    }
                    else if (Confirm == "yes")
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for your perchase of Mower 3!");
                        Thread.Sleep(0500);
                        Console.WriteLine("An invoice will be sent to jeb_@mowerCompany.com");
                        Thread.Sleep(0500);
                        Console.WriteLine("Type any key to continue");
                        Console.ReadKey();

                        //add the logic for the tractor to take place here for the game play
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry that you were not satisfied.");
                        Thread.Sleep(0500);
                        Console.WriteLine("Hope to see you oh so very soon!");
                        Thread.Sleep(0500);
                        Console.WriteLine("Type any key to continue");
                        Console.ReadKey();
                        return;
                    }
                }
            }
        }
    }
}
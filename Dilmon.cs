namespace Dilmon
{
    public class Dilmon
    {
        public double dilmonName;
        public bool isShiny;
        private static string playerDilmonName = " ";
        private static string rivalDilmonName = " ";
        public static string playersMonNameToDisplay = " ";
        public static Random rnd = new Random();
        public static int chancForCrit = rnd.Next(1, 101);
        public static int enemyChancForCrit = rnd.Next(1, 101);
        public static int chanceForMiss = rnd.Next(1, 201);
        public static int enemyChanceForMiss = rnd.Next(1, 201);
        public static int chanceForStatusEffect = rnd.Next(1, 11);
        public static int enemyMoveSelect = rnd.Next(1, 5);
        public static double playerDilmonHealth = 100;
        public static double rivalDilmonHealth = 100;
        public static double playerDilmonBaseHealth = 100;
        public static double rivalDilmonBaseHealth = 100;
        public static string rivalDilmonMove1 = "";
        public static string rivalDilmonMove2 = "";
        public static string rivalDilmonMove3 = "";
        public static string rivalDilmonMove4 = "";
        public static double strengthMultiplyer = 1;
        public static double enemyStrengthMultiplyer = 1;
        public static double waterATKMult = 1;
        public Dilmon()
        {
        }
        public static void DisplayStarters()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Number one is our grass option, Swiffy."); //the mossy swiftlet dilmon
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Number two, the water option, Dil."); //the friendly fish dilmon
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("And last but not least the fire option, Gangu."); //the firey kangaoo dilmon
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"So? Which one will it be ?\nType 1 2 or 3");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string userDilmonChoice = Console.ReadLine();
            int num = 1;
            if (!int.TryParse(userDilmonChoice, out num))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Jeff: Sorry, that was not a provided option.");
                Thread.Sleep(2000);
                Console.Clear();
                DisplayStarters();
            }
            else if (userDilmonChoice == "1")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BOX: Swiffy is the mossy swiflet DILMON. \nAre you sure you want to choose Swiffy? Y/N"); // evolves into Swiftler then Swifton
                Console.ForegroundColor = ConsoleColor.Green;
                SetPlayerDilmonName("Swiffy");
                ConfirmChoiceForDilmon();
                SetRivalDilmonName(playerDilmonName);
                playerDilmonHealth = 60;
                playerDilmonBaseHealth = 60;
            }
            else if (userDilmonChoice == "2")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BOX: Dil is the friendly fish DILMON. \nAre you sure you want to choose Dil? Y/N"); // evolves into Dilbert then Dilboretor
                Console.ForegroundColor = ConsoleColor.Blue;
                SetPlayerDilmonName("Dil");
                ConfirmChoiceForDilmon();
                SetRivalDilmonName(playerDilmonName);
                playerDilmonHealth = 80;
                playerDilmonBaseHealth = 80;
            }
            else if (userDilmonChoice == "3")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BOX: Gangu is the firey kangaroo DILMON. \nAre you sure you want to choose Gangu? Y/N"); // evolves into Gangubud then Gangunade
                Console.ForegroundColor = ConsoleColor.Red;
                SetPlayerDilmonName("Gangu");
                ConfirmChoiceForDilmon();
                SetRivalDilmonName(playerDilmonName);
                playerDilmonHealth = 90;
                playerDilmonBaseHealth = 90;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Jeff: Sorry, that was not a provided option. \nPlease enter which Dilmon you want to choose.");
                Thread.Sleep(2000);
                Console.Clear();
                DisplayStarters();
            }
            RenameDilmon();
            RivalFightIntro();
            RivalFight();
        }
        public static void RenameDilmon()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("BOX: Do you want to rename your DILMON? Y/N");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string yesNoForRename = Console.ReadLine();
            if (yesNoForRename == "y")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What would you like to rename your DILMON to?\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                playersMonNameToDisplay = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Are you sure you want to rename {playerDilmonName} to {playersMonNameToDisplay}? Y/N");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string yesNoForNewName = Console.ReadLine();
                if (yesNoForNewName == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Jeff: Great choice! Your {playerDilmonName} has been renamed to {playersMonNameToDisplay}!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"BOX: Great! \n{playersMonNameToDisplay} has joined your party!");
                }
                else
                {
                    RenameDilmon();
                }
            }
            else
            {
                playersMonNameToDisplay = playerDilmonName;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"BOX: Great! \n{playersMonNameToDisplay} has joined your party!");
            }
        }
        public static void SetPlayerDilmonName(string name)
        {
            playerDilmonName = name;
        }
        public static void SetRivalDilmonName(string playerDilmonName)
        {
            if (playerDilmonName == "Swiffy")
            {
                rivalDilmonName = "Dil";
                rivalDilmonHealth = 80;
                rivalDilmonBaseHealth = 80;
            }
            else if (playerDilmonName == "Dil")
            {
                rivalDilmonName = "Gangu";
                rivalDilmonHealth = 90;
                rivalDilmonBaseHealth = 90;
            }
            else if (playerDilmonName == "Gangu")
            {
                rivalDilmonName = "Swiffy";
                rivalDilmonHealth = 60;
                rivalDilmonBaseHealth = 60;
            }
        }
        public string GetPlayerDilmonName()
        {
            return playerDilmonName;
        }
        private static void ConfirmChoiceForDilmon()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string yesNoAnswer = Console.ReadLine();
            if (yesNoAnswer == "yes" || yesNoAnswer == "y" || yesNoAnswer == "Y")
            {
                Console.WriteLine("Great choice!");
            }
            else
            {
                Console.Clear();
                DisplayStarters();
            }
        }
        public static void DisplayDilmonMoves()
        {
            string playerDilmonMove1 = "";
            string playerDilmonMove2 = "";
            string playerDilmonMove3 = "";
            string playerDilmonMove4 = "";
            if (playerDilmonName == "Swiffy")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                playerDilmonMove1 = "Swift Sweep"; //normal type airial attack 
                playerDilmonMove2 = "Leach Claw"; //grass type move that does damage and heals the user 
                playerDilmonMove3 = "Tackle"; //basic normal type move
                playerDilmonMove4 = "Photosynthesis"; //grass type move - takes a turn to heal (cannot do damage)
            }
            else if (playerDilmonName == "Dil")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                playerDilmonMove1 = "Tackle"; //basic normal type move
                playerDilmonMove2 = "Rainy Skies"; //water type move - sets the weather to rainy and gives all water type moves a boost
                playerDilmonMove3 = "Flop"; //water type move (no type other than water DILMON can learn this move) - raises user's defense and atack at the risk of falling asleep
                playerDilmonMove4 = "Coral Rain"; //water type move - like stelth rock - any time a new DILMON enters they take damage (unavoidable but lasts for 4 turns)
            }
            else if (playerDilmonName == "Gangu")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                playerDilmonMove1 = "Tackle"; //basic normal type move
                playerDilmonMove2 = "Flaming Boxer"; //Fire type move that boosts the user's fire type attacks
                playerDilmonMove3 = "Meteor Punch"; //Fire type move (high crit chance but cannot be used twice in a row)
                playerDilmonMove4 = "Ash Construct"; // Fire type move that boosts atk pwr but decreases speed
            }
            Console.WriteLine($""" 
            Moves:
            1. {playerDilmonMove1}  2. {playerDilmonMove2}
            3. {playerDilmonMove3}  4. {playerDilmonMove4}
            """);
        }
        public static void PlayerTurn()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("""
            1. Fight    2. Bag
            3. DILMON   4. Run
            """);
            string userFightAction = Console.ReadLine();
            if (userFightAction == "1")
            {
                double fireTypeBoost = 1;
                DisplayDilmonMoves();
                Console.WriteLine("Press eneter to go back.");
                string userMoveAction = Console.ReadLine();
                if (userMoveAction == "1")
                {
                    // Console.WriteLine("It's super effective!");
                    if (playerDilmonName == "Swiffy")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Swift Sweep.");
                        rivalDilmonHealth -= (10 * strengthMultiplyer);
                    }
                    else if (playerDilmonName == "Dil")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Tackle.");
                        rivalDilmonHealth -= (10 * strengthMultiplyer);
                    }
                    else if (playerDilmonName == "Gangu")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Tackle.");
                        rivalDilmonHealth -= (10 * strengthMultiplyer);
                    }
                }
                else if (userMoveAction == "2")
                {
                    if (playerDilmonName == "Swiffy")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Leach Claw.");
                        rivalDilmonHealth -= (10 * strengthMultiplyer);
                        playerDilmonHealth += (10 * strengthMultiplyer);
                    }
                    else if (playerDilmonName == "Dil")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Rainy Skies.");
                        Console.WriteLine("The weather changes and it begins to rain.");
                        waterATKMult += 0.1;
                    }
                    else if (playerDilmonName == "Gangu")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Flaming Boxer.");
                        Console.WriteLine($"{playersMonNameToDisplay}'s fire type ATKs rose.");
                        fireTypeBoost += 0.1;
                    }
                }
                else if (userMoveAction == "3")
                {
                    if (playerDilmonName == "Swiffy")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Leach Tackle.");
                        rivalDilmonHealth -= (10 * strengthMultiplyer);
                    }
                    else if (playerDilmonName == "Dil")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Flop.");
                        Console.WriteLine($"{playersMonNameToDisplay}'s water type ATK rose sharpley.");
                        strengthMultiplyer += 0.5;
                    }
                    else if (playerDilmonName == "Gangu")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Meteor Punch.");
                        int meteorPunchCritChance = rnd.Next(1, 21);
                        if (meteorPunchCritChance == 1)
                        {
                            Console.WriteLine("IT'S A CRIT!");
                            rivalDilmonHealth -= (15 * 2.25);
                        }
                        else
                        {
                            rivalDilmonHealth -= (15 * strengthMultiplyer);
                        }
                    }
                }
                else if (userMoveAction == "4")
                {
                    if (playerDilmonName == "Swiffy")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Photosynthesis.");
                        playerDilmonHealth = playerDilmonBaseHealth;
                    }
                    else if (playerDilmonName == "Dil")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Coral Rain.");
                        Console.WriteLine("The weather changes and it begins to rain.");
                        waterATKMult += 0.1;
                    }
                    else if (playerDilmonName == "Gangu")
                    {
                        Console.WriteLine($"{playersMonNameToDisplay} uses Ash Construct.");
                        Console.WriteLine($"{playersMonNameToDisplay}'s fire type ATKs rose.");
                        fireTypeBoost += 0.1;
                    }
                }
                else
                {
                    Console.Clear();
                    RivalFight();
                }
            }
            else if (userFightAction == "2")
            {
                Console.WriteLine("You open your bag to see if anything is in there.");
                Thread.Sleep(2000);
                Console.WriteLine("It's empty");
                Thread.Sleep(2000);
                Console.Clear();
                RivalFight();
            }
            else if (userFightAction == "3")
            {
                Console.WriteLine("You have no other DILMON.");
                Thread.Sleep(2000);
                Console.Clear();
                RivalFight();
            }
            else
            {
                Console.WriteLine("You cannot do that at this time.");
                Thread.Sleep(2000);
                Console.Clear();
                RivalFight();
            }
        }
        public static void SetRivalDilmonMoves()
        {
            if (rivalDilmonName == "Swiffy")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                rivalDilmonMove1 = "Tackle"; //normal type airial attack 
                rivalDilmonMove2 = "Leach Claw"; //grass type move that does damage and heals the user 
                rivalDilmonMove3 = "Swift Sweep"; //basic normal type move
                rivalDilmonMove4 = "Photosynthesis"; //grass type move - takes a turn to heal (cannot do damage)
            }
            else if (rivalDilmonName == "Dil")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                rivalDilmonMove1 = "Tackle"; //basic normal type move
                rivalDilmonMove2 = "Rainy Skies"; //water type move - sets the weather to rainy and gives all water type moves a boost
                rivalDilmonMove3 = "Flop"; //water type move (no type other than water DILMON can learn this move) - raises user's defense and atack at the risk of falling asleep
                rivalDilmonMove4 = "Coral Rain"; //water type move - like stelth rock - any time a new DILMON enters they take damage (unavoidable but lasts for 4 turns)
            }
            else if (rivalDilmonName == "Gangu")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                rivalDilmonMove1 = "Tackle"; //basic normal type move
                rivalDilmonMove2 = "Flaming Boxer"; //Fire type move that boosts the user's fire type attacks
                rivalDilmonMove3 = "Meteor Punch"; //Fire type move (high crit chance but cannot be used twice in a row)
                rivalDilmonMove4 = "Ash Construct"; // Fire type move that boosts atk pwr but decreases speed
            }
        }
        public static void EnemyAttack()
        {
            SetRivalDilmonMoves();
            enemyChancForCrit = rnd.Next(1, 101);
            enemyChanceForMiss = rnd.Next(1, 201);
            enemyMoveSelect = rnd.Next(1, 5);
            if (enemyChanceForMiss == 1)
            {
                Console.WriteLine($"{rivalDilmonName} missed!");
            }
            else
            {
                double fireTypeBoost = 1;
                switch (enemyMoveSelect)
                {
                    case 1:
                        Console.WriteLine($"{rivalDilmonName} used Tackle!");
                        playerDilmonHealth -= (10 * enemyStrengthMultiplyer);
                        break;
                    case 2:
                        Console.WriteLine($"{rivalDilmonName} used {rivalDilmonMove2}!");
                        if (rivalDilmonMove2 == "Leach Claw")
                        {
                            playerDilmonHealth -= (10 * enemyStrengthMultiplyer);
                            rivalDilmonHealth += (10 * enemyStrengthMultiplyer);
                            while (rivalDilmonHealth > rivalDilmonBaseHealth)
                            {
                                rivalDilmonHealth --;
                            }
                        }
                        else if (rivalDilmonMove2 == "Rainy Skies")
                        {
                            Console.WriteLine("The weather changes and it begins to rain.");
                            waterATKMult += 0.1;
                        }
                        else if (rivalDilmonMove2 == "Flaming Boxer")
                        {
                            Console.WriteLine("The opposing Gangu's fire ATK rose.");
                            fireTypeBoost += 0.1;
                        }
                        break;
                    case 3:
                        Console.WriteLine($"{rivalDilmonName} used {rivalDilmonMove3}");
                        if (rivalDilmonMove3 == "Swift Sweep")
                        {
                            playerDilmonHealth -= (15 * enemyStrengthMultiplyer);
                        }
                        else if (rivalDilmonMove3 == "Flop")
                        {
                            Console.WriteLine("Dil flops around and its ATK rose sharpley.\nThe opposing Dil's DEF rose.");
                            enemyStrengthMultiplyer += 0.5;
                            strengthMultiplyer -= 0.1;
                        }
                        else if (rivalDilmonMove3 == "Meteor Punch")
                        {
                            int enemyMeteorPunchCritChance = rnd.Next(1, 21);
                            if (enemyMeteorPunchCritChance == 1)
                            {
                                Console.WriteLine("IT'S A CRIT!");
                                playerDilmonHealth -= (15 * 2.25);
                            }
                            else
                            {
                                playerDilmonHealth -= (15 * enemyStrengthMultiplyer);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine($"{rivalDilmonName} used {rivalDilmonMove4}");
                        if (rivalDilmonMove4 == "Photosynthesis")
                        {
                            Console.WriteLine("The opposing Swiffy soaks in the sun and heals 30 HP");
                            rivalDilmonHealth += 30;
                        }
                        else if (rivalDilmonMove4 == "Coral Rain")
                        {
                            Console.WriteLine("The opposing Dil filled the field with coral.");
                        }
                        else if (rivalDilmonMove4 == "Ash Construct")
                        {
                            Console.WriteLine("The opposing Gangu's ATK rose. \nGangu's speed fell.");
                            enemyStrengthMultiplyer += 0.02;
                        }
                        break;
                    default:
                        break;
                }
            }

        }
        public static void DisplayHealth()
        {
            double playerDilmonHealthPercent = (playerDilmonHealth / playerDilmonBaseHealth) * 100;
            double rivalDilmonHealthPercent = (rivalDilmonHealth / rivalDilmonBaseHealth) * 100;
            if (playerDilmonHealthPercent == 100)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n████████████████████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 90)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n██████████████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 80)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n████████████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 70)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n██████████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 60)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n███████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("█████████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 50)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n██████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██████████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 40)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("████████████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 30)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n██████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██████████████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 20)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("████████████████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 10)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n██");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██████████████████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerDilmonHealthPercent < 100 && playerDilmonHealthPercent >= 1)
            {
                Console.Write($"\n{playersMonNameToDisplay}:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" {playerDilmonHealth}");
                Console.Write("\n█");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("███████████████████");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Your Dilmon has fainted...");
                Thread.Sleep(3000);
                Console.WriteLine("Thank you for playing our game!");
                Thread.Sleep(2000);
                Console.WriteLine("Press ctrl C to end the game or if you want to play again press enter.");
                Console.ReadLine();
                Program.beginningThing();
            }
            ////////////////////////////////////////////////////////
            Console.Write($"\n{rivalDilmonName}:");
            if (rivalDilmonHealthPercent == 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n████████████████████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n██████████████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n████████████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n██████████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 60)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n███████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("█████████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n██████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██████████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 40)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("████████████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n██████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██████████████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("████████████████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n██");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██████████████████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (rivalDilmonHealthPercent < 100 && rivalDilmonHealthPercent >= 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n█");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("███████████████████\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine($"You have Defeted the {rivalDilmonName}!");
                Thread.Sleep(3000);
                Console.WriteLine("Thank you for playing our game!");
                Thread.Sleep(2000);
                Console.WriteLine("Press ctrl C to end the game or if you want to play again press enter.");
                Console.ReadLine();
            }
        }
        public static void RivalFightIntro()
        {
            Console.WriteLine("Jeff: But before you leave...");
            Thread.Sleep(2000);
            Console.WriteLine("You should meet my nephew.");
            Thread.Sleep(2000);
            Console.WriteLine("His name is James.");
            Thread.Sleep(2000);
            Console.WriteLine("And one last thing...");
            Console.WriteLine("Here's what I call a Pocket Box. \nIt keeps track of every DILMON you encounter and catch.");
            Thread.Sleep(2000);
            Console.WriteLine("*You accept the Pocket Box and put it in your bag. And you turn to leave*");
            Thread.Sleep(2000);
            Console.WriteLine(". . .");
            Thread.Sleep(2000);
            Console.WriteLine("James: Hey! Wait up!");
            Thread.Sleep(2000);
            Console.WriteLine("What? You're gonna walk away without a battle?");
            Thread.Sleep(3000);
            // Begin the fight sequence!!!
        }
        public static void RivalFight()
        {
            Console.Clear();
            Console.WriteLine($"*James let's out his {rivalDilmonName} and chalenges you to a battle.*");
            Console.WriteLine($"{Program.userName}: GO, {playersMonNameToDisplay}!");
            Thread.Sleep(3000);
            if (playerDilmonHealth > 0)
            {
                while (playerDilmonHealth > 0)
                {
                    Console.Clear();
                    DisplayHealth();
                    Thread.Sleep(1000);
                    PlayerTurn();
                    Thread.Sleep(1000);
                    EnemyAttack();
                    Thread.Sleep(3000); 
                }
            }
            Console.WriteLine($"{playersMonNameToDisplay} has fainted!");
            Thread.Sleep(3000);
            Console.WriteLine("Thank you for playing our game!");
            Thread.Sleep(2000);
            Console.WriteLine("Press ctrl C to end the game.");
            Console.ReadLine();
        }
    }
}
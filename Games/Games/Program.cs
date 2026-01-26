using System;
using System.Threading;

namespace Games
{
    internal class Program
    {
        // ANSI escape code for neon pink (#ff12ff)
        const string Pink = "\x1b[38;2;255;18;255m";
        const string Reset = "\x1b[0m";

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.Title = "# RETRO NEON GAME HUB #";

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("════════════════════════════════════════");
                Console.WriteLine("         - RETRO NEON GAME HUB -       ");
                Console.WriteLine("════════════════════════════════════════\n");

                // Pink ASCII cat
                Console.WriteLine(Pink + @"
      /\_/\  
     ( $.$ )   Welcome!
      > ^ <
 ---------------------------------------" + Reset);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1) Draw Game");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("2) Typing Survival" + Reset);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("3) Reaction Test");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Q) Quit\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Choose your game: ");
                string choice = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        DrawGame();
                        break;
                    case "2":
                        TypingSurvival();
                        break;
                    case "3":
                        ReactionTest();
                        break;
                    case "Q":
                        running = false;
                        break;
                    default:
                        Console.WriteLine(Pink + "ERROR. Sisesta number 1-3 või Q." + Reset);
                        Thread.Sleep(1500);
                        break;
                }
            }

            Console.ResetColor();
            Console.Clear();
        }

        static void DrawGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[Press Q to Quit / Back to Menu]");
                Console.WriteLine("Press any other key to start drawing...");
                ConsoleKey startKey = Console.ReadKey(true).Key;
                if (startKey == ConsoleKey.Q) break;

                Console.CursorVisible = false;
                int width = 30;
                int height = 15;
                char[,] canvas = new char[height, width];
                for (int y = 0; y < height; y++)
                    for (int x = 0; x < width; x++)
                        canvas[y, x] = '.';

                int cx = width / 2;
                int cy = height / 2;

                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔═══════════════════════╗");
                    Console.WriteLine("        DRAW GAME        ");
                    Console.WriteLine("╚═══════════════════════╝\n");

                    Console.WriteLine(Pink + "WASD = move | X = draw | C = erase | Q = finish\n" + Reset);

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            if (x == cx && y == cy)
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            else
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(canvas[y, x]);
                        }
                        Console.WriteLine();
                    }

                    ConsoleKey key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.W && cy > 0) cy--;
                    else if (key == ConsoleKey.S && cy < height - 1) cy++;
                    else if (key == ConsoleKey.A && cx > 0) cx--;
                    else if (key == ConsoleKey.D && cx < width - 1) cx++;
                    else if (key == ConsoleKey.X) canvas[cy, cx] = '#';
                    else if (key == ConsoleKey.C) canvas[cy, cx] = '.';
                    else if (key == ConsoleKey.Q) break;
                }

                Console.CursorVisible = true;
                Console.Clear();

                Console.WriteLine(Pink + "[R] Try Again   [Q] Back to Menu" + Reset);
                ConsoleKey choice = Console.ReadKey(true).Key;
                playAgain = choice == ConsoleKey.R;
            }

            Console.ResetColor();
            Console.Clear();
        }

        static void TypingSurvival()
        {
            string[] words =
            {
                "tunnel", "shadow", "pixel", "comet",
                "glitch", "ember", "circuit", "echo",
                "moss", "ripple", "lantern", "vortex",
                "marble", "neon", "signal", "orbit",
                "frost", "cipher", "drift", "compass",
                "quill", "skyline", "fragment", "pulse",
                "spiral", "anchor", "haze", "beacon",
                "relic", "spark",
            };

            Random rnd = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[Press Q to Quit / Back to Menu]");
                Console.WriteLine("Press any other key to start Typing Survival...");
                ConsoleKey startKey = Console.ReadKey(true).Key;
                if (startKey == ConsoleKey.Q) break;

                int timeLeft = 30;
                int score = 0;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════╗");
                Console.WriteLine("       TYPING SURVIVAL      ");
                Console.WriteLine("╚══════════════════════════╝");

                Console.WriteLine(Pink + @"
      /\_/\  
     (- O -)   Let's type!
      > ^ <
                " + Reset);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nType the words exactly. Wrong input costs 3 seconds.");
                Console.WriteLine("Press ENTER to start...");
                Console.ReadLine();

                while (timeLeft > 0)
                {
                    string word = words[rnd.Next(words.Length)];
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.WriteLine("       TYPING SURVIVAL      ");
                    Console.WriteLine("╚══════════════════════════╝\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Time left: {timeLeft}s | Score: {score}\n");

                    Console.WriteLine(Pink + $"WORD: {word}" + Reset);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nType: ");

                    DateTime start = DateTime.Now;
                    string input = Console.ReadLine();
                    int spent = (int)(DateTime.Now - start).TotalSeconds;
                    timeLeft -= spent;

                    if (input == word)
                    {
                        score++;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Correct! +1 point");
                    }
                    else
                    {
                        timeLeft -= 3;
                        Console.WriteLine(Pink + "Wrong! -3 seconds" + Reset);
                    }

                    Thread.Sleep(700);
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════╗");
                Console.WriteLine("          GAME OVER         ");
                Console.WriteLine("╚══════════════════════════╝\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Final Score: {score}\n");
                Console.WriteLine(@"
      /\_/\  
     ( o.o )   Nice try!
      > ^ <
                ");

                Console.WriteLine(Pink + "\n[R] Try Again   [Q] Back to Menu" + Reset);

                ConsoleKey key = Console.ReadKey(true).Key;
                playAgain = key == ConsoleKey.R;
            }

            Console.ResetColor();
            Console.Clear();
        }

        static void ReactionTest()
        {
            Random rnd = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[Press Q to Quit / Back to Menu]");
                Console.WriteLine("Press any other key to start Reaction Test...");
                ConsoleKey startKey = Console.ReadKey(true).Key;
                if (startKey == ConsoleKey.Q) break;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════╗");
                Console.WriteLine("     RETRO REACTION TEST    ");
                Console.WriteLine("╚══════════════════════════╝\n");

                Console.WriteLine(Pink + "Wait for 'NOW', then press ENTER.\nPressing too early fails.\n" + Reset);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPress any key to start.");
                Console.ReadKey(true);

                int waitTime = rnd.Next(2000, 6000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("WAIT...");

                DateTime start = DateTime.Now;
                bool failedEarly = false;

                while ((DateTime.Now - start).TotalMilliseconds < waitTime)
                {
                    if (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                        Console.WriteLine(Pink + "\nToo early. You failed." + Reset);
                        failedEarly = true;
                        break;
                    }
                }

                if (!failedEarly)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nNOW!");

                    DateTime reactStart = DateTime.Now;
                    Console.ReadKey(true);
                    int reaction = (int)(DateTime.Now - reactStart).TotalMilliseconds;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nReaction time: {reaction} ms");

                    if (reaction < 250)
                        Console.WriteLine("Fast. Cat approves.");
                    else
                        Console.WriteLine("Could be faster. Cat shrugs.");
                }

                Console.WriteLine(Pink + "\n[R] Try Again   [Q] Back to Menu" + Reset);

                ConsoleKey key = Console.ReadKey(true).Key;
                playAgain = key == ConsoleKey.R;
            }

            Console.ResetColor();
            Console.Clear();
        }
    }
}

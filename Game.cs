using System;
using static System.Console;
namespace Menu
{
    public class Game
    {
        public void Start()
        {
        //     WriteLine("The Game is starting");
        //     ConsoleKeyInfo keyPressed = ReadKey();
        //     if (keyPressed.Key == ConsoleKey.Enter)
        //     {
        //         WriteLine("You pressed Enter");
        //     }
        //     else if(keyPressed.Key == ConsoleKey.UpArrow)
        //
        //     {
        //         WriteLine("you pressed Up arrow");
        //     }
        //     else
        //     {
        //         WriteLine("You pressed another key...");
        //     }


        Title = "Polish draughts";
        RunMainMenu();

        }

        private void RunMainMenu()
        {
            ForegroundColor = ConsoleColor.Red;
            string prompt =  @"
 ██▓███   ▒█████   ██▓     ██▓  ██████  ██░ ██    ▓█████▄  ██▀███   ▄▄▄       █    ██   ▄████  ██░ ██ ▄▄▄█████▓  ██████ 
▓██░  ██▒▒██▒  ██▒▓██▒    ▓██▒▒██    ▒ ▓██░ ██▒   ▒██▀ ██▌▓██ ▒ ██▒▒████▄     ██  ▓██▒ ██▒ ▀█▒▓██░ ██▒▓  ██▒ ▓▒▒██    ▒ 
▓██░ ██▓▒▒██░  ██▒▒██░    ▒██▒░ ▓██▄   ▒██▀▀██░   ░██   █▌▓██ ░▄█ ▒▒██  ▀█▄  ▓██  ▒██░▒██░▄▄▄░▒██▀▀██░▒ ▓██░ ▒░░ ▓██▄   
▒██▄█▓▒ ▒▒██   ██░▒██░    ░██░  ▒   ██▒░▓█ ░██    ░▓█▄   ▌▒██▀▀█▄  ░██▄▄▄▄██ ▓▓█  ░██░░▓█  ██▓░▓█ ░██ ░ ▓██▓ ░   ▒   ██▒
▒██▒ ░  ░░ ████▓▒░░██████▒░██░▒██████▒▒░▓█▒░██▓   ░▒████▓ ░██▓ ▒██▒ ▓█   ▓██▒▒▒█████▓ ░▒▓███▀▒░▓█▒░██▓  ▒██▒ ░ ▒██████▒▒
▒▓▒░ ░  ░░ ▒░▒░▒░ ░ ▒░▓  ░░▓  ▒ ▒▓▒ ▒ ░ ▒ ░░▒░▒    ▒▒▓  ▒ ░ ▒▓ ░▒▓░ ▒▒   ▓▒█░░▒▓▒ ▒ ▒  ░▒   ▒  ▒ ░░▒░▒  ▒ ░░   ▒ ▒▓▒ ▒ ░
░▒ ░       ░ ▒ ▒░ ░ ░ ▒  ░ ▒ ░░ ░▒  ░ ░ ▒ ░▒░ ░    ░ ▒  ▒   ░▒ ░ ▒░  ▒   ▒▒ ░░░▒░ ░ ░   ░   ░  ▒ ░▒░ ░    ░    ░ ░▒  ░ ░
░░       ░ ░ ░ ▒    ░ ░    ▒ ░░  ░  ░   ░  ░░ ░    ░ ░  ░   ░░   ░   ░   ▒    ░░░ ░ ░ ░ ░   ░  ░  ░░ ░  ░      ░  ░  ░  
             ░ ░      ░  ░ ░        ░   ░  ░  ░      ░       ░           ░  ░   ░           ░  ░  ░  ░               ░  
                                                   ░                                                                    
     
Welcome to Polish draughts. What would you like to do?:
(Use the arrow keys to cycle through options and press enter to select an option.)";
            ResetColor();

            string[] options = {"Play", "About", "Exit"};
            GameMenu mainGameMenu = new GameMenu(prompt, options);
            int selectedIndex = mainGameMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }

        }

        

            private void ExitGame()
            {
                WriteLine("\nPress any key to exit...");
                ReadKey(true);
                Environment.Exit(0);
            }

            private void DisplayAboutInfo()
            {
                Clear();
                WriteLine(@"All draughts games have the following common rules.
The game is played on a board similar to a chessboard.
At the beginning of the game, each player has equal number of pieces. This pieces are often called Men.
The aim of the game is to capture all opponent’s pieces or block them (situation where your opponent can not move).
Normal pieces (Men) can move to an adjacent unoccupied square. Mostly diagonally, but there are variants, where pieces can move on a straight line.
Capturing is made by “jumping” – moving two consecutive steps in the same line, jumping over the piece on the first step. Multiple opposing pieces may be captured in a single turn if this is done by successive jumps made by a single piece.
Capturing is mandatory – it is a very important element of Draughts that allows stronger players to sacrifice some pawns in order to achieve a more favorable position on the board. The obligation of capturing  is the basis of checkers strategy and tactics.
It’s possible to capture many enemy pieces at once, making few jumps in a row. You can change direction during such jumps.
A piece reaching the last row becomes King. We say it is crowned. It acquires additional powers (he has more options of moving).
If a game meets this criteria, it is probably a variant of Draughts. Differences between draughts games can cover various details such as…
");
                WriteLine("Press any key to return to main menu");
                ReadKey(true);
                RunMainMenu();

            }

            private void RunFirstChoice()
            {
                WriteLine("Put width of board size between 4-20");
                ReadKey(true);
                ExitGame();
                

            }
        
    }
}

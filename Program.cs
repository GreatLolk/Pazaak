using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pazaak
{
    class Program
    {
        static void Main()
        {
            int number1 = 0;
            int number2 = 0;
            int numberofhods = 0;
            int[] MainColoda = new int[3];
            int[] DopColoda = new int[3];
            int[] AIMainColoda = new int[3];
            int[] AIDopColoda = new int[3];
            Renderer renderer1 = new Renderer();
            AI ai1 = new AI();
            Cards cards1 = new Cards();
            PlayerInput playerinput1 = new PlayerInput();
            WinChecker winchecker1 = new WinChecker();

            cards1.CreateMainColoda(MainColoda);
            cards1.CreateDopColoda(DopColoda);
            cards1.CreateAIMainColoda(AIMainColoda);
            cards1.CreateAIDopColoda(AIDopColoda);

            while (winchecker1.IsWin == 0)
            {
                switch (numberofhods) // SCORE FOR 2 PLAYERS
                {
                    case 0:
                        number1 = number1 + cards1.MintCard1;
                        number2 = number2 + cards1.AIMintCard1;
                            break;
                    case 1:
                        number1 = number1 + cards1.MintCard2;
                        number2 = number2 + cards1.AIMintCard2;
                            break;
                    case 2:
                        number1 = number1 + cards1.MintCard3;
                        number2 = number2 + cards1.AIMintCard3;
                            break;
                    default:
                            break;
                }

                renderer1.RenderTable(number1, number2, numberofhods, cards1);

                if (ai1.playerAI == false) // CHECK STEP
                {
                    while (ai1.playerAI == false)
                    {
                        playerinput1.GetPlayerInput(cards1, DopColoda, ai1, winchecker1, number1, number2); // Numbers dont't work.
                        Console.Clear();
                        renderer1.RenderTable(number1, number2, numberofhods, cards1);
                    }
                }
                
                if (ai1.playerAI == true)
                {
                    do
                    {
                        ai1.AIHod(AIDopColoda, cards1, number1, number2, ai1);
                        winchecker1.CheckWin(winchecker1.IsWin, number1, number2);
                        Console.Clear();
                        renderer1.RenderTable(number1, number2, numberofhods, cards1);
                        if (winchecker1.IsWin == 2)
                            break;
                    } while (ai1.AIWork == true); // FORFEIT OF FIRST PLAYER
                } 

                numberofhods++;
                winchecker1.CheckWin(winchecker1.IsWin, number1, number2);
                Console.Clear();
            }

            winchecker1.Win(winchecker1.IsWin);
            Console.ReadKey();

        }
    }
}

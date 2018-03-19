using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pazaak
{
    class Renderer
    {
    public void RenderTable(int number1, int number2, int numberofhods, Cards cards1)
    {
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------"); // 1
	    Console.WriteLine("*                                                           Your score:               Enemy score:                                                           *");
        Console.WriteLine("*                                                               " + number1 + "                        " + number2 + "                                                                   *"); // 2
        Console.WriteLine("*                                                                                                                                                            *");
        Console.WriteLine("*           ---------     ---------     ---------                                                        ---------     ---------     ---------               *"); // 3
        Console.WriteLine("*           *       *     *       *     *       *                                                        *       *     *       *     *       *               *"); // 4
        switch(numberofhods) // 4
        {
            case 0:
                Console.WriteLine("*           *   {0}   *     *       *     *       *                                                        *       *     *       *     *       *               *", cards1.Mcard1);
            break;
            case 1:
                Console.WriteLine("*           *   {0}   *     *   {1}   *     *       *                                                        *       *     *       *     *       *               *", cards1.Mcard1, cards1.Mcard2);
            break;
            case 2:
                Console.WriteLine("*           *   {0}   *     *   {1}   *     *   {2}   *                                                        *       *     *       *     *       *               *", cards1.Mcard1, cards1.Mcard2, cards1.Mcard3);
            break;
            default:
                Console.WriteLine("*           *   {0}   *     *   {1}   *     *   {2}   *                                                        *       *     *       *     *       *               *", cards1.Mcard1, cards1.Mcard2, cards1.Mcard3);
            break;
        }
        Console.WriteLine("*           *       *     *       *     *       *                                                        *       *     *       *     *       *               *"); // 5
        Console.WriteLine("*           ---------     ---------     ---------                                                        ---------     ---------     ---------               *"); // 6
        Console.WriteLine("*                                                                                                                                                            *"); // 7
        Console.WriteLine("*                                                                                                                                                            *"); // 8
        Console.WriteLine("*                                                                                                                                                            *"); //9
        Console.WriteLine("*                      Your hand:                                                                               Enemy hand:                                  *"); // 10
        Console.WriteLine("*           ---------     ---------     ---------                                                        ---------     ---------     ---------               *"); // 11
        Console.WriteLine("*           *       *     *       *     *       *                                                        *       *     *       *     *       *               *"); // 12

        if(cards1.WasUsed1 == false && cards1.WasUsed2 == false && cards1.WasUsed3 == false)
            Console.WriteLine("*           *   {0}  *     *   {1}  *     *   {2}  *                                                        *       *     *       *     *       *               *", cards1.Dcard1, cards1.Dcard2, cards1.Dcard3); // 13

        else if(cards1.WasUsed1 == true && cards1.WasUsed2 == false && cards1.WasUsed3 == false)
            Console.WriteLine("*           *       *     *   {0}  *     *   {1}  *                                                        *       *     *       *     *       *               *", cards1.Dcard2, cards1.Dcard3); // 13

        else if(cards1.WasUsed1 == false && cards1.WasUsed2 == true && cards1.WasUsed3 == false)
            Console.WriteLine("*           *   {0}  *     *       *     *   {1}  *                                                        *       *     *       *     *       *               *", cards1.Dcard1, cards1.Dcard3); // 13

        else if (cards1.WasUsed1 == false && cards1.WasUsed2 == false && cards1.WasUsed3 == true)
            Console.WriteLine("*           *   {0}  *     *   {1}  *     *       *                                                        *       *     *       *     *       *               *", cards1.Dcard1, cards1.Dcard2); // 13

        else if (cards1.WasUsed1 == true && cards1.WasUsed2 == true && cards1.WasUsed3 == false)
            Console.WriteLine("*           *       *     *       *     *   {0}  *                                                        *       *     *       *     *       *               *", cards1.Dcard3); // 13

        else if (cards1.WasUsed1 == false && cards1.WasUsed2 == true && cards1.WasUsed3 == true)
            Console.WriteLine("*           *   {0}  *     *       *     *       *                                                        *       *     *       *     *       *               *", cards1.Dcard1); // 13

        else if (cards1.WasUsed1 == true && cards1.WasUsed2 == false && cards1.WasUsed3 == true)
            Console.WriteLine("*           *   {0}  *     *       *     *   {1}  *                                                        *       *     *       *     *       *               *", cards1.Dcard1, cards1.Dcard3); // 13

        else if (cards1.WasUsed1 == true && cards1.WasUsed2 == true && cards1.WasUsed3 == true)
            Console.WriteLine("*           *       *     *       *     *       *                                                        *       *     *       *     *       *               *"); // 13

        Console.WriteLine("*           *       *     *       *     *       *                                                        *       *     *       *     *       *               *"); // 14
        Console.WriteLine("*           ---------     ---------     ---------                                                        ---------     ---------     ---------               *"); // 15
        Console.WriteLine("*                                                                                                                                                            *"); // 16
        Console.WriteLine("*                                                         End turn                              Stand                                                        *"); // 17
        Console.WriteLine("*                                                                             Forfeit                                                                        *"); // 18
        Console.WriteLine("*                                                                                                                                                            *"); // 19
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------"); // 20
        // 0.3 – NUZNA PODGONKA
        }
    }
}

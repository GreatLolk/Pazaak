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
	    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
	    Console.WriteLine("*                                                           Your score:               Enemy score:                                  *");
        Console.WriteLine("*                                                               " + number1 + "                        " + number2 + "                                                                 *");
        Console.WriteLine("*                                                                                                                                                                                *");
        Console.WriteLine("*           ---------     ----------      ---------                                                        -----------    -------------  -------------    *");
        Console.WriteLine("*           *         *    *          *    *           *                                                     *             *  *              *  *               *  *");
        switch(numberofhods)
        {
            case 0:
            Console.WriteLine("*           *   {0}   *    *          *    *          *                                                     *            *  *             *  *              *  *", cards1.Mcard1);
            break;
            case 1:
            Console.WriteLine("*           *   {0}   *    *    {1}    *    *          *                                                     *            *  *             *  *              *  *", cards1.Mcard1, cards1.Mcard2);
            break;
            case 2:
            Console.WriteLine("*           *   {0}   *    *    {1}    *    *    {2}    *                                                     *            *  *             *  *              *  *", cards1.Mcard1, cards1.Mcard2,cards1.Mcard3);
            break;
        } 
        Console.WriteLine("*           *         *    *          *    *           *                                                     *             *  *              *  *               *  *");
        Console.WriteLine("*           ---------     ----------      ---------                                                        -----------    -------------  -------------    *");
        Console.WriteLine("*                                                                                                                                                                                *");
        Console.WriteLine("*                                                                                                                                                                                *");
        Console.WriteLine("*                                                                                                                                                                                *");
        Console.WriteLine("*                      Your hand:                                                                               Enemy hand:                                *");
        Console.WriteLine("*           ---------     ----------      ---------                                                        -----------    -------------  -------------    *");
        Console.WriteLine("*           *         *    *          *    *           *                                                     *             *  *              *  *               *  *");
        switch (numberofhods)
        {
            case 0:
                Console.WriteLine("*           *   {0}   *    *          *    *          *                                                     *            *  *             *  *              *  *", cards1.Dcard1);
                break;
            case 1:
                Console.WriteLine("*           *   {0}   *    *    {1}    *    *          *                                                     *            *  *             *  *              *  *", cards1.Dcard1, cards1.Dcard2);
                break;
            case 2:
                Console.WriteLine("*           *   {0}   *    *    {1}    *    *    {2}    *                                                     *            *  *             *  *              *  *", cards1.Dcard1, cards1.Dcard2, cards1.Dcard3);
                break;
        }
        Console.WriteLine("*           *         *    *          *    *           *                                                     *             *  *              *  *               *  *");
        Console.WriteLine("*           ---------     ----------      ---------                                                        -----------    -------------  -------------    *");
        Console.WriteLine("*                                                                                                                                                                                *");
        Console.WriteLine("*                                                         End turn                              Stand                                                               *");
        Console.WriteLine("*                                                                                 Forfeit                                                                                   *");
        Console.WriteLine("*                                                                                                                                                                                *");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        // 0.1 – NUZNA PODGONKA
        }
    }
}

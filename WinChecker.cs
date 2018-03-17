using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pazaak
{
    class WinChecker
    {
        public int IsWin = 0;

	    public void CheckWin(int IsWin, int number1, int number2)
	    {
		    if(number1 > number2 && number1 != 20 && number1 < 20 && number1 > 15)
		    {
		    IsWin = 1;
		    }

            else if (number2 > number1 && number2 != 20 && number2 < 20 && number2 > 15) 
		    {
		    IsWin = 2;
		    }
		
		    else if(number2 == 20)
		    {
		    IsWin = 1;
		    }
		
		    else if(number1 == 20)
		    {
		    IsWin = 2;
		    }
	    }

	    public void Win(int IsWin)
	    {
		    switch(IsWin)
		    {
                case 0:
                break;
			    case 1:
			    Console.WriteLine("1 player wins!!!");
			    Console.ReadKey();
			    break;
			    case 2:
			    Console.WriteLine("2 player wins!!!");
                break;
		    }
	    }
    }
}

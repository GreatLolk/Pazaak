using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pazaak
{
    class PlayerInput
    {
        public string StringPlayerInput;

	    public void GetPlayerInput(Cards cards1, int[] DopColoda, AI ai1, WinChecker winchecker1, int number1, int number2)
        {
	        StringPlayerInput = Console.ReadLine();
		        switch(StringPlayerInput)
		        {
		        case "1":
			        cards1.FirstCard(DopColoda, number1, number2, ai1);//0.1
		        break;
		        case "2":
			        cards1.SecondCard(DopColoda, number1, number2, ai1);//0.1
		        break;
		        case "3":
			        cards1.ThirdCard(DopColoda, number1, number2, ai1);//0.1
		        break;
		        case "end turn":
			        EndTurn(ai1);
		        break;
		        case "stand":
			        Stand(ai1);
		        break;
		        case "forfeit":
			        Forfeit(winchecker1);
		        break;
		        }
        }

        public void EndTurn(AI ai1)
        {
		        ai1.playerAI = true; //HOD 2 IGROKA
        }

        public void Stand(AI ai1)
        {
                ai1.playerAI = true;
		        ai1.AIWork = true; //DO KONZA IGRAET TOLKO AI
        }

        public void Forfeit(WinChecker winchecker1)
        {
		        winchecker1.IsWin = 2; //2 IGROK WIN
		        winchecker1.Win(winchecker1.IsWin);
        }
    }
}

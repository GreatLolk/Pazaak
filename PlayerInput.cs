using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pazaak
{
    class PlayerInput
    {
        public string StringPlayerInput;

	    public void GetPlayerInput(ref int number1, Cards cards1, int[] DopColoda, AI ai1, WinChecker winchecker1)
        {
	        StringPlayerInput = Console.ReadLine();
		        switch(StringPlayerInput)
		        {
		        case "1":
			        cards1.FirstCard(ref number1, DopColoda, ai1);//0.4
		        break;
		        case "2":
			        cards1.SecondCard(ref number1, DopColoda, ai1);//0.4
		        break;
		        case "3":
			        cards1.ThirdCard(ref number1, DopColoda, ai1);//0.4
		        break;
		        case "end turn":
			        EndTurn(ai1);
		        break;
		        case "stand":
			        Stand(ai1);
		        break;
		        case "forfeit":
			        Forfeit(winchecker1, ai1);
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

        public void Forfeit(WinChecker winchecker1, AI ai1)
        {
		        winchecker1.IsWin = 2; //2 IGROK WIN
                ai1.playerAI = true;
        }
    }
}

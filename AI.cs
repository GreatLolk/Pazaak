using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pazaak
{
    class AI
    {
        public bool AIWork = false;
	    public bool playerAI = false;
	    public void AIHod(ref int number2, int[] AIDopColoda, Cards cards1, AI ai1)
	{
		if( playerAI == true | AIWork == true)
			if (number2 < 20)
			{
                if (AIDopColoda[0] == 3 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 4 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 5 && cards1.AIWasUsed1 == false)
				cards1.AIFirstCard(ref number2, AIDopColoda, ai1);
                else if (AIDopColoda[0] == 3 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 4 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 5 && cards1.AIWasUsed2 == false)
                    cards1.AISecondCard(ref number2, AIDopColoda, ai1);
                else if (AIDopColoda[0] == 3 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 4 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 5 && cards1.AIWasUsed3 == false)
                    cards1.AIThirdCard(ref number2, AIDopColoda, ai1);
			}

			else if(number2 == 20)
			{
                if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed1 == false)
                    cards1.AIFirstCard(ref number2, AIDopColoda, ai1);
                else if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed2 == false)
                    cards1.AISecondCard(ref number2, AIDopColoda, ai1);
                else if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed3 == false)
                    cards1.AIThirdCard(ref number2, AIDopColoda, ai1);
			}

			else if(number2 > 20)
			{
                if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed1 == false)
                    cards1.AIFirstCard(ref number2, AIDopColoda, ai1);
                else if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed2 == false)
                    cards1.AISecondCard(ref number2, AIDopColoda, ai1);
                else if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed3 == false)
                    cards1.AIThirdCard(ref number2, AIDopColoda, ai1);
			}
		
	    }

    }
}

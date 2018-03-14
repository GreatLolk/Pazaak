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
	    public void AIHod(int[] AIDopColoda, Cards cards1, int number1, int number2, AI ai1)
	{
		if( playerAI == true | AIWork == true)
			if(number2 < 20)
			{
                if (AIDopColoda[0] == 3 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 4 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 5 && cards1.AIWasUsed1 == false)
				cards1.AIFirstCard(AIDopColoda, number1, number2, ai1);
                else if (AIDopColoda[0] == 3 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 4 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 5 && cards1.AIWasUsed2 == false)
                cards1.AISecondCard(AIDopColoda, number1, number2, ai1);
                else if (AIDopColoda[0] == 3 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 4 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 5 && cards1.AIWasUsed3 == false)
                cards1.AIThirdCard(AIDopColoda, number1, number2, ai1);
			}

			if(number2 == 20)
			{
                if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed1 == false)
                cards1.AIFirstCard(AIDopColoda, number1, number2, ai1);
                else if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed2 == false)
                cards1.AISecondCard(AIDopColoda, number1, number2, ai1);
                else if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed3 == false)
                cards1.AIThirdCard(AIDopColoda, number1, number2, ai1);
			}

			if(number2 > 20)
			{
                if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed1 == false)
                cards1.AIFirstCard(AIDopColoda, number1, number2, ai1);
                else if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed2 == false)
                cards1.AISecondCard(AIDopColoda, number1, number2, ai1);
                else if (AIDopColoda[0] == 0 && cards1.AIWasUsed1 == false || AIDopColoda[1] == 1 && cards1.AIWasUsed2 == false || AIDopColoda[2] == 2 && cards1.AIWasUsed3 == false)
                cards1.AIThirdCard(AIDopColoda, number1, number2, ai1);
			}
		
	    }

    }
}

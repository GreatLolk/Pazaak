using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pazaak
{
    class Cards
    {
	public Random rnd = new Random();
	public bool WasUsed1 = false;
	public bool AIWasUsed1 = false;
	public bool WasUsed2= false;
	public bool AIWasUsed2 = false;
	public bool WasUsed3 = false;
	public bool AIWasUsed3 =false;
	public string Mcard1;
	public string Mcard2;
	public string Mcard3;
	public string Dcard1;
	public string Dcard2;
	public string Dcard3;
	public int MintCard1;
	public int MintCard2;
	public int MintCard3;
	public int AIMintCard1;
	public int AIMintCard2;
	public int AIMintCard3;

	public void CreateMainColoda(int[] MainColoda) //GLAVNAYA
{
for(int index = 0; index < 3; index++)
{
			MainColoda[index] = rnd.Next(0,2);
            SetStringsForMainCards(MainColoda[index], index);
}
	
}

	public void CreateDopColoda(int[] DopColoda) //BOKOVAYA
    {
            for(int index = 0; index < 3; index++)
            {
			            DopColoda[index] = rnd.Next(0,5);
			            SetStringsForDopCards(DopColoda[index], index);//DLYA OTRISOVKI V Renderer
            }
    }

	public int ActionOfCard(int RandomNumber, int number, AI ai1)
	{
		switch(RandomNumber)
		{
	        case 0:
                number += 4;
                break;
            case 1:
                number += 5;
                break;
            case 2:
                number += 6;
                break;
            case 3:
                number -= 1;
                break;
            case 4:
                number -= 2;
                break;
            case 5:
                number -= 3;
                break;
		}
        return number;
	}

	public void FirstCard(ref int number1, int[] DopColoda, AI ai1)
	{
        if (WasUsed1 == false)//BILA ISPOLSOVANA ILI NET
        {
            number1 = ActionOfCard(DopColoda[0], number1, ai1);
            WasUsed1 = true;
        };
	}

    public void SecondCard(ref int number1, int[] DopColoda, AI ai1)
    {
        if (WasUsed2 == false)//BILA ISPOLSOVANA ILI NET
        {
            number1 = ActionOfCard(DopColoda[1], number1, ai1);
            WasUsed2 = true;
        }
    }

    public void ThirdCard(ref int number1, int[] DopColoda, AI ai1)
    {
        if (WasUsed3 == false)//BILA ISPOLSOVANA ILI NET
        {
            number1 = ActionOfCard(DopColoda[2], number1, ai1);
            WasUsed3 = true;
        }
    }
	
	public void SetStringsForDopCards(int RandomNumber, int index)
	{
		switch(index)
        {
	case 0:
		switch(RandomNumber)
		{
			case 0:
				Dcard1 = "+4";
				break;
			case 1:
				Dcard1 = "+5";
				break;
			case 2:
				Dcard1 = "+6";
				break;
			case 3:
				Dcard1 = "-1";
				break;
			case 4:
				Dcard1 = "-2";
				break;
			case 5:
				Dcard1 = "-3";
				break;
		}
		break;
	case 1:
		switch(RandomNumber)
		{
			case 0:
				Dcard2 = "+4";
				break;
			case 1:
				Dcard2 = "+5";
				break;
			case 2:
				Dcard2 = "+6";
				break;
			case 3:
				Dcard2 = "-1";
				break;
			case 4:
				Dcard2 = "-2";
				break;
			case 5:
				Dcard2 = "-3";
				break;
		}

		break;
	case 2:
		switch(RandomNumber)
		{
			case 0:
				Dcard3 = "+4";
				break;
			case 1:
				Dcard3 = "+5";
				break;
			case 2:
				Dcard3 = "+6";
				break;
			case 3:
				Dcard3 = "-1";
				break;
			case 4:
				Dcard3 = "-2";
				break;
			case 5:
				Dcard3 = "-3";
				break;
		}

		break;
        }
		
	}
	public void SetStringsForMainCards(int RandomNumber, int index)
	{
		switch(index)
        {
	case 0:
		switch(RandomNumber)
		{
			case 0:
				Mcard1 = "4";
				MintCard1 = 4;
				break;
			case 1:
				Mcard1 = "5";
				MintCard1 = 5;
				break;
			case 2:
				Mcard1 = "6";
				MintCard1 = 6;
				break;
		}
		break;
	case 1:
		switch(RandomNumber)
		{
			case 0:
				Mcard2 = "4";
				MintCard2 = 4;
				break;
			case 1:
				Mcard2 = "5";
				MintCard2 = 5;
				break;
			case 2:
				Mcard2 = "6";
				MintCard2 = 6;
				break;
		}

		break;
	case 2:
		switch(RandomNumber)
		{
			case 0:
				Mcard3 = "4";
				MintCard3 = 4;
				break;
			case 1:
				Mcard3 = "5";
				MintCard3 = 5;
				break;
			case 2:
				Mcard3 = "6";
				MintCard3 = 6;
				break;
		}

		break;	
	    }
    }
	public void CreateAIMainColoda(int[] AIMainColoda) //GLAVNAYA
{
for(int index = 0; index < 3; index++)
{
			AIMainColoda[index] = rnd.Next(0,2);
			SetStringsForAIMainCards(AIMainColoda[index], index);
}
	
}

	public void CreateAIDopColoda(int[] AIDopColoda) //BOKOVAYA
{
for(int index = 0; index < 3; index++)
{
			AIDopColoda[index] = rnd.Next(0,5);
}
		}

    public void AIFirstCard(ref int number2, int[] AIDopColoda, AI ai1)
    {
        if (AIWasUsed1 == false)//BILA ISPOLSOVANA ILI NET
        {
            number2 = ActionOfCard(AIDopColoda[0], number2, ai1);
            AIWasUsed1 = true;
        }
    }

    public void AISecondCard(ref int number2, int[] AIDopColoda, AI ai1)
    {
        if (AIWasUsed2 == false)//BILA ISPOLSOVANA ILI NET
        {
            number2 = ActionOfCard(AIDopColoda[1], number2, ai1);
            AIWasUsed2 = true;
        }
    }

    public void AIThirdCard(ref int number2, int[] AIDopColoda, AI ai1)
    {
        if (AIWasUsed3 == false)//BILA ISPOLSOVANA ILI NET
        {
            number2 = ActionOfCard(AIDopColoda[2], number2, ai1);
            AIWasUsed3 = true;
        }
    }
	    public void SetStringsForAIMainCards(int RandomNumber, int index)
	    {
		    switch(index)
            {
	    case 0:
		    switch(RandomNumber)
		    {
			    case 0:
				    AIMintCard1 = 4;
				    break;
			    case 1:
				    AIMintCard1 = 5;
				    break;
			    case 2:
				    AIMintCard1 = 6;
				    break;
		    }
		    break;
	    case 1:
		    switch(RandomNumber)
		    {
			    case 0:
				    AIMintCard2 = 4;
				    break;
			    case 1:
				    AIMintCard2 = 5;
				    break;
			    case 2:
				    AIMintCard2 = 6;
				    break;
		    }

		    break;
	    case 2:
		    switch(RandomNumber)
		    {
			    case 0:
				    AIMintCard3 = 4;
				    break;
			    case 1:
				    AIMintCard3 = 5;
				    break;
			    case 2:
				    AIMintCard3 = 6;
				    break;
		    }

		    break;

            }
    }
    }
    }

using System;

namespace Mechanics
{
	public class Dice 
	{
		static Random DiceResult = new Random();

		static public int RollD20() 
		{
			Console.WriteLine("Rolling Dice (D20)...\nResult: {0}", DiceResult.Next(1, 21));    
			return DiceResult.Next(1, 21);
		}
		    
		static public int RollD12()
		{
			Console.WriteLine("Rolling Dice (D12)...\nResult: {0}", DiceResult.Next(1, 13));
		    return DiceResult.Next(1, 13);
		}    
	       
		static public int RollD10()
		{
			Console.WriteLine("Rolling Dice (D10)...\nResult: {0}", DiceResult.Next(1, 11));
		   return DiceResult.Next(1, 11);
		}
		
		static public int RollD8()
		{
		   Console.WriteLine("Rolling Dice (D8)...\nResult: {0}", DiceResult.Next(1, 9)); 
		   return DiceResult.Next(1, 9);
		}
		
		static public int RollD6()
		{
		   char[] DiceResults = {'\u2680','\u2681','\u2682','\u2683','\u2684','\u2685'};
		   int DiceRoll = DiceResult.Next(1,7);			
	
		   switch(DiceRoll)
		   {
			case 1:
				Console.WriteLine("Rolling Dice (D6)...\nResult: {0}, {1}",DiceRoll, DiceResults[0]);
			break;
			case 2:
				Console.WriteLine("Rolling Dice (D6)...\nResult: {0}, {1}",DiceRoll, DiceResults[1]);	
			break;
			case 3:
				Console.WriteLine("Rolling Dice (D6)...\nResult: {0}, {1}",DiceRoll, DiceResults[2]);
			break;
			case 4:
				Console.WriteLine("Rolling Dice (D6)...\nResult: {0}, {1}",DiceRoll, DiceResults[3]);
			break;	
			case 5:
				Console.WriteLine("Rolling Dice (D6)...\nResult: {0}, {1}",DiceRoll, DiceResults[4]);	
			break;
			case 6:
				Console.WriteLine("Rolling Dice (D6)...\nResult: {0}, {1}",DiceRoll, DiceResults[5]);		
			break;
			default:
				Console.WriteLine("ERROR: D6 DiceResult is above 6!");
			break;	

		   }	
		   return DiceRoll;
		}

		static public int RollD4()
		{
			Console.WriteLine("Rolling Dice (D4)...\nResult: {0}", DiceResult.Next(1, 5));
		    return DiceResult.Next(1, 5);
		}
	}



}

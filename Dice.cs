using System;

namespace Mechanics
{
	public class Dice 
	{
		static Random DiceResult = new Random();

		static public void Main() 
		{
			int[] DiceRolls = new int[6];

           
			DiceRolls[0] = RollD4();
			DiceRolls[1] = RollD6();
			DiceRolls[2] = RollD8();
			DiceRolls[3] = RollD10();
			DiceRolls[4] = RollD12();
			DiceRolls[5] = RollD20();

			//Testing Dice
			Console.WriteLine("D4 Result : {0}",DiceRolls[0]);
			Console.WriteLine("D6 Result : {0}", DiceRolls[1]);
			Console.WriteLine("D8 Result : {0}", DiceRolls[2]);
			Console.WriteLine("D10 Result : {0}", DiceRolls[3]);
			Console.WriteLine("D12 Result : {0}", DiceRolls[4]);
			Console.WriteLine("D20 Result : {0}", DiceRolls[5]);


		}

      

		static public int RollD20() 
		{
			return DiceResult.Next(1, 21);
		}
	    
		static public int RollD12()
        {
            return DiceResult.Next(1, 13);
        }    
       
		static public int RollD10()
        {
            return DiceResult.Next(1, 11);
        }
	
		static public int RollD8()
        {
                
            return DiceResult.Next(1, 9);
        }
	
		static public int RollD6()
        {
            return DiceResult.Next(1, 7);
        }

		static public int RollD4()
        {
            return DiceResult.Next(1, 5);
        }
	}



}

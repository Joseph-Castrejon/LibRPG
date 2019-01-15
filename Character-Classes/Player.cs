using System;
using Races;

namespace Characters
{

	public class Player
	{
        //Empty race 
		Race PlayerRace;

		private byte level;

		//Ability Score
		private byte strength, dexterity, constitution, intelligence, wisdom, charisma;
		//Ability Score Experience array.
		private ulong[] experience = new ulong[6];

      
		public byte Strength
		{
			get
			{
				return strength;
			}
			set
			{
				strength = SetAbilityScore(value);
			}
		}
		public byte Dexterity
		{
			get
			{
				return dexterity;
			}
			set
			{
				dexterity = SetAbilityScore(value);
			}
		}
		public byte Constitution
		{
			get
			{
				return constitution;
			}
			set
			{
				constitution = SetAbilityScore(value);
			}
		}
		public byte Intelligence
		{
			get
			{
				return intelligence;
			}
			set
			{
				intelligence = SetAbilityScore(value);
			}
		}
		public byte Wisdom
		{
			get
			{
				return wisdom;
			}
			set
			{
				wisdom = SetAbilityScore(value);
			}
		}
		public byte Charisma
		{
			get
			{
				return charisma;
			}
			set
			{
				charisma = SetAbilityScore(value);
			}

		}
      
        /// <summary>
        /// Sets the attribute score of a character.
        /// </summary>
        /// <param name="AttributeScore">Attribute score.</param>
		private byte SetAbilityScore(byte AbilityScore)
		{
			try
			{
				

				if (AbilityScore < 0)
				{
					throw new System.ArgumentException(String.Format("EXCEPTION: AbilityScore cannot be less than 0. (SEE PAGE 15)"),"AbilityScore");
				}	
				else if (AbilityScore > 20){
					throw new System.ArgumentException(String.Format("EXCEPTION: AbilityScore cannot be greather than 20. (SEE PAGE 15)"),"AbilityScore");
				}
				else
				{
					return AbilityScore;
				}

			}
			catch (ArgumentException e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ResetColor();
			}

			return 0;
		}

        /// <summary>
        /// Adds the experience to the character class.
        /// </summary>
        /// <param name="EXP">Exp.</param>
		public void AddExperience(ulong _experience) {
			experience += _experience;
            
		}

        /// <summary>
        /// Returns the level of an ability score based on given experience.
        /// </summary>
        /// <returns>The level.</returns>
        /// <param name="exp">Exp.</param>
		public byte ReturnLevel(ulong exp) {

			if (exp >= 0 && exp < 300)
				return 1;
			else if (exp >= 300 && exp < 900)
				return 2;
			else if (exp >= 900 && exp < 2700)
				return 3;
			else if (exp >= 2700 && exp < 6500)
				return 4;
			else if (exp >= 6500 && exp < 14000)
                return 5;
			else if (exp >= 14000 && exp < 23000)
                return 6;
			else if (exp >= 23000 && exp < 34000)
                return 7;
			else if (exp >= 34000 && exp < 48000)
                return 8;
			else if (exp >= 48000 && exp < 64000)
                return 9;
			else if (exp >= 64000 && exp < 85000)
                return 10;
			else if (exp >= 85000 && exp < 100000)
                return 11;
			else if (exp >= 100000 && exp < 120000)
                return 12;
			else if (exp >= 120000 && exp < 140000)
                return 13;
			else if (exp >= 140000 && exp < 165000)
                return 14;
			else if (exp >= 165000 && exp < 195000)
                return 15;
			else if (exp >= 195000 && exp < 225000)
                return 16;
			else if (exp >= 225000 && exp < 265000)
                return 17;
			else if (exp >= 265000 && exp < 305000)
                return 18;
			else if (exp >= 305000 && exp < 355000)
                return 19;
			else if (exp >= 355000)
                return 20;

			//Error Code
			return -1;

		}
       
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Characters.Player"/> class.
        /// </summary>
		public Player() {
			Console.WriteLine("New Player Created.");
		
		}


	}
}



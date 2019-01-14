using System;

namespace Characters{

	public class Player
	{
		private byte strength, dexterity, constitution, intelligence, wisdom, charisma;
		private ulong experience;

		public byte Strength
		{
			get
			{
				return strength;
			}
			set
			{
				SetAttributeScore(value);
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
				SetAttributeScore(value);
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
				SetAttributeScore(value);
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
				SetAttributeScore(value);
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
				SetAttributeScore(value);
			}
		}
		public byte Charisma
		{
			get
			{
				return wisdom;
			}
			set
			{
				SetAttributeScore(value);
			}

		}

        /// <summary>
        /// Sets the attribute score of a character.
        /// </summary>
        /// <param name="AttributeScore">Attribute score.</param>
		private void SetAttributeScore(byte AttributeScore)
		{
			try
			{
				if (AttributeScore < 0)
					throw new System.ArgumentException("Attribute Value cannot be less than 0.");
				else if (AttributeScore > 255)
					throw new System.ArgumentException("Attribute value cannot be greather than 255.");
				else
				{
					this.strength = AttributeScore;
				}

			}
			catch (ArgumentException e)
			{

			}
		}

        /// <summary>
        /// Adds the experience to the character class.
        /// </summary>
        /// <param name="EXP">Exp.</param>
		public void AddExperience(ulong _experience) {
			experience += _experience;
            
		}
          
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Characters.Player"/> class.
        /// </summary>
		public Player() {
			Console.WriteLine("New Player Created.");
		
		}


	}
}
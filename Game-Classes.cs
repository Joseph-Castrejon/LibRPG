using System;
using System.IO;


namespace Races
{

	public static class Races	
	{
		public static void Main(string[] args)
		{
		//Class Implementations
			Human TestHuman = new Human();
			Beast TestBeast = new Beast();
		
		}
			
	}
	
		//RACE CLASS DEFINITIONS
		public abstract class Artificial
		{
			private int level;
			private int health;
			private int mass;
			
		}
		public abstract class Organic
		{
				private int level;
				private int health;
				private int stamina;
				private int mass;
						
				public int Stamina
				{
					get	
					{
						return stamina;
					}	
				}
				int Mass
				{
					get
					{
						return mass;
					}
					
				}
		}	


		public abstract class Beast : Organic
		{
		
		
			public Beast()
			{
				
				
			}
		
			public int Level
			{
				get
				{
					return level;
				}
					
			}
			
			public int SetLevel()
			{
				this.level = Level;
				
			}
			
			public int SetHealth(int HealthChange)
			{
				this.health = health + HealthChange;
			}
		}
		
		
		public abstract class Humanoid : Organic 
		{
			
			
			
		}
		
		public class Human : Humanoid
		{
			
		}
		
		public abstract class Cyborg : Humaniod
		{
			
		}
		
		
		public class Drone : Artficial
		{
			
			
		}
		
			
		
		
		
		public class Andriod : Artificial
		{
			
			public int Power
			{
				get
				{
					return Power;
				}
			}
					
					
		}
}



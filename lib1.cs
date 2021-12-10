//exercise2

using System;

 
namespace lib_exam{

	public abstract class Sportsman{
	

		public abstract int run();
		protected string name;
		
	}
	
	public class Runner : Sportsman{
		Random random = new Random();
		int time = 0;//time in seconds
		
		//Constructor
		public Runner(){
		
			this.name="normal runner";
		}
		
		public override int run(){
			time = random.Next(10,60);
			return time;
		}
	}
	
	public class ShortDistanceRunner : Runner{
		Random random = new Random();
		int time1 = 0; //time in seconds
		
		//Constructor
		public ShortDistanceRunner(){
		
			this.name="runner short distance";
			
		}
		
		public override int run(){
			time1 = random.Next(0,10);
			return time1;
		}
	}
	
}


using System;
using lib_exam;
class Program{
	public static void Main(){
		Runner run1 = new Runner();
		ShortDistanceRunner s_run1 = new ShortDistanceRunner();
		
		int time_run1 = run1.run();
		int time_short_run1 = s_run1.run();
		
		Console.WriteLine("Time to normal runner : {0}",time_run1);
		Console.WriteLine("Time to short distance runner: {0}",time_short_run1);
	}
}

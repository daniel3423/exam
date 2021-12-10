//exercise 1
using System;
 
class exercise1 {
    
    public static void Main()
    {
    	long f1=0;
    	long f2=1;
    	int n=10;
    	long divisible=0;
    	for (int i = 1; i < n; i++) {
        
        	long aux = f1 + f2;
        	f1 = f2;
        	f2 = aux;
        	if(f2%3==0){
        		divisible=f2;
        		Console.WriteLine("Divisible by 3:{0}",divisible);
        		
        	}
        	Console.WriteLine("all numbers:{0}",f2);
        	
        	
    	}
    	
    }
}

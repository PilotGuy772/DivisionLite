using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  
  public static void Main (string[] args) {
    double var1;
    double var2;
    (var1, var2) = Divide(18, 2);

    Console.WriteLine("Testing {0} / {1}", 18, 2);
    Console.WriteLine("answer:");
    Console.WriteLine(var1);
    Console.WriteLine("Remainder:");
    Console.WriteLine(var2);
    getFactors(var1);


  }
  public static (double answer, double remainder) Divide(double dividend, double divisor){
    


    double answer = dividend / divisor;
    

    //Console.WriteLine("The answer is...");
    //Console.WriteLine(answer);

    double remain = answer - Math.Truncate(answer);
    int fullNumAnswer = (int)answer; 
    
    double wholeRemainder = remain * divisor;
   
    
    return(fullNumAnswer, wholeRemainder);

    
    

  }

  public static void getFactors(double number){
    Console.WriteLine("getting factors for {0}", number);
    //List<double> factors = new List<double>();
    
    for (int i = 1; i <= number; i++ ){
      
      double truncate;
      double var3;
      (var3, truncate) = Divide(number, i);
      if (truncate == 0){
        Console.WriteLine(i);
      }
      

      

    }

    //printList(factors);

  }

  public static void printList(List<double> print){
    
    for (int i = 0; i == print.Count; i++){
      double value = print.ElementAt(i);
      Console.WriteLine(value);
    }
  }  
}
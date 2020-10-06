using System;

// Author: jotagarciaz

class WeirdNotWeirdNumbers {
  static void Main(string[] args) {
    for (int n = 1; n <=100; n++){
        if ((n>=6 && n<=50) || n % 2 != 0){
            Console.WriteLine("Weird");
        }else if( n==2 || n==4 || n>50){
            Console.WriteLine("Not Weird");
        }
    }
  }
}

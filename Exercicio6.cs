using System;

class Loops
{
     static void Main (string [] args) {

        int segundo = 10;

    while (segundo >= 0) {

     
         if(segundo == 0){

            Console.WriteLine("BOOOOOOOOM!");


        }    else if  (segundo % 2 == 0) {

              Console.WriteLine("TIC");
        }
            else{
            Console.WriteLine("TAC");
        }
        
            segundo--;


        }
    }
}
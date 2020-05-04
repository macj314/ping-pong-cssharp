using System;
/* 
A user enters a number and the application returns all numbers from 1 to the user input with the following changes:
All numbers divisible by 3 are replaced by "ping".
All numbers divisible by 5 are replaced by "pong"
All numbers divisible by both 3 and 5 are replaced by "ping-pong". 
*/
class MealTime
{
  static void Main()
  {
    Console.WriteLine("Please enter a number:");
    string stringNumber = Console.ReadLine();
    int userNumber = int.Parse(stringNumber);
    PingPong(userNumber);
  }

  static void PingPong(int num)
  {
    for (int i = 1; i < num; i++){
      if (i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("ping-pong");
      } else if (i % 3 == 0){
        Console.WriteLine("ping");
      } else if (i % 5 == 0){
        Console.WriteLine("pong");
      } else {
        Console.WriteLine(i);
      }
    }
  }
}
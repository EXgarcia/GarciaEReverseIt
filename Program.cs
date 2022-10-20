//Elizar Garcia
//10-19-22
//Mini challenge #7 "Reverse Numbers"
//In this project the console will prompt the user to input numbers and return them in reverse order.

Console.Clear();
bool playAgain = true;
string reverse;
string reverseOne = "";
string playAgainAnswer;
bool num;
int numNum = 0;
int remainder = 0;
int reverseNumber = 0;




while(playAgain == true)
{
   Console.WriteLine("Let's revers some letters and numbers");

   Console.WriteLine("Please enter letters or numbers.");
   reverse = Console.ReadLine();
   num = Int32.TryParse(reverse, out numNum);

   if(num)
   {
      while(numNum > 0)
      {
         remainder = numNum % 10;
         numNum = numNum/10;
         reverseNumber = (reverseNumber*10) + remainder;

      }
      Console.WriteLine(reverse + " <[^.^]> " + reverseNumber);
   }else
   {
      for(int i = reverse.Length -1; i >=0; i--)
      {
         reverseOne = reverseOne + reverse[i];

      }
      Console.WriteLine(reverse + " <[^.^]> " + reverseOne);
   }
   Console.WriteLine(" Would you like to reverse anything else?");
   Console.WriteLine("Type yes to play again or no to stop");
   playAgainAnswer = Console.ReadLine().ToUpper();

   if(playAgainAnswer == "YES")
   {
      playAgain = true;
   }else
   {
      Console.WriteLine(" No more for you! <[^.^]>");
      playAgain= false;
   }


}
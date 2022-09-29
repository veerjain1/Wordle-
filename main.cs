using System;
class Program {
  public static void Main (string[] args) {
    string wordle = "";
    Console.WriteLine("WELCOME TO WORDLE. YOU HAVE 6 TRIES TO GUESS A 5 LETTER WORD. EVERY TIME YOU GET THE WORD WRONG, THE COMPUTER WILL PROVIDE YOU WITH A HINT OF THE FIRST FEW LETTERS. PRESS ENTER TO BEGIN...");
    Console.ReadLine();
    wordle = WordChooser();
    bool result = CheckWord(wordle);
    if(result == true){
      Console.WriteLine("You Win!");
    }
    if(result == false){
      Console.WriteLine("You Lose!");
    }  
  }
   static string WordChooser()
  {
      string word = "";
      Console.WriteLine("Enter your secret word here: ");
      word = Console.ReadLine();
      Console.Clear();
      return word;   
  }
  static bool CheckWord(string wordle)
  {
    string userInput ="";
    string looper = "na";
    bool checker = false;
    while ( looper != "ye")
    {
    for(int i =0; i<6; i++){
      Console.WriteLine("Please Enter Your "+(i+1)+" try here: ");
      userInput = Console.ReadLine();
      if(userInput == wordle)
      {
        Console.WriteLine("Congrats! You Got The Word!");
        checker = true;
        break;
      }
      Console.WriteLine("");

      if(i<5 &&  userInput!= wordle)
      {  

        for(int j =0; j<wordle.Length; j++)
      {
        if(wordle.Substring(j,1) == userInput.Substring(j,1))
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write(userInput.Substring(j,1));
        }
        else if(wordle.IndexOf(userInput.Substring(j,1)) != -1)
        {
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.Write(userInput.Substring(j,1));
        }
        else{
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write(userInput.Substring(j,1));
        }
        
      }
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        
      }

      Console.WriteLine("");
      if(i == 5 && userInput!=wordle)
      {
        Console.WriteLine("You did not get the word in the 5 given tries! The word was "+wordle); 
        break;
      }
    }
      looper = "ye";
    }
    return checker;
  }

}
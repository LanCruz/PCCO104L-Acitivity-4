using System;

class Program {
  public static void Main (string[] args) {

    var gogo = true;
    string msg = "";
    int sum = 0;


    while(gogo)
      {
      Console.Write("Enter something: ");
      string input = Console.ReadLine().Trim();

        if(input.ToLower() == "exit"){
          Console.WriteLine("Closing program...");
          break;
        }

        if (int.TryParse(input, out int addnum))
      {
      sum += addnum;
      Console.WriteLine($"Adding {addnum} to {sum - addnum} = {sum}.");
      Console.WriteLine();

      }

        
      else{
          msg += " " + input;
          Console.WriteLine($"Current Message is: {msg}");
          Console.WriteLine();
        }

    
    }




  }


    }






using System;

class Program {
  public static void Main (string[] args) {
    //Gets rid of dotnet run message on load
    Console.Clear();

    //Create variables
    string password;
    string attempt = "";

    //Get user password and save it
    Console.WriteLine ("Type a password:");
    password = Console.ReadLine();

    //Clear the console and ask the user for their password
    Console.Clear();

    //Loop until user puts in correct password
    while(password != attempt){
      Console.WriteLine ("Hello user please enter your password.");
      attempt = Console.ReadLine();

      //Check if the password matches what the user just typed
      if(password == attempt){
        Console.WriteLine ("Welcome to the password keeper program.");
      }
      else{
        Console.WriteLine ("Password incorrect. Please try again.");
      }
      Console.WriteLine ("");
    }   
  }
}
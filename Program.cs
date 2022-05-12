// See https://aka.ms/new-console-template for more information
using System;
using Project_1;
namespace Project_1{
class Start{
    public static void Main (string[] args){
    
    var player = new Player();
    Console.Write("What is your name? ");
    player.Name = Console.ReadLine();
   bool playing = true;
var Card = new Cards();
bool correct;
   //Here is where all the methods from the other classes are called.
   while (playing == true){
Console.WriteLine();
Card.ChangeCard();
correct = Card.Guess();
if(correct == true){
    player.increasePoints();
}
else{
    player.decreasePoints();
}
playing = player.lose();
if(playing == false){
    Console.WriteLine("Man, you suck. Thanks for playing!");
}
Console.Write("Would you like to keep playing? [y/n]");
string check = Console.ReadLine();
if (check == "n"){
    Console.WriteLine("Thanks for playing!");
    break;
}





   }



    }
}
}
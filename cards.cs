using System;

namespace Project_1
{

    public class Cards
    {
        Random randomGenerator = new Random();
public string correct { get; set; }
        public int Card { get; set; }

        public void ChangeCard()
        {


             Card = randomGenerator.Next(1, 14);

        }
public void NewCard(){
int Changing = randomGenerator.Next(1, 14);
if (Changing == Card){
    Changing= randomGenerator.Next(1, 14);
}
if (Changing == Card){
    Changing= randomGenerator.Next(1, 14);
}
if (Card - Changing < 0){
    correct = "H";
}
else{
    correct = "L";
}
Console.WriteLine($"Next card was: {Changing}");
Card = Changing;


}
public bool Guess(){
    Console.WriteLine($"The card is: {Card}");
    Console.Write("Higher or Lower? [H/L] ");
    string answer = Console.ReadLine();
    NewCard();
    if(correct == answer){
return true;
    }
    else{
        return false;
    }
}




    }
}
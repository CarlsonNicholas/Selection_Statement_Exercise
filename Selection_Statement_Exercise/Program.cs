//Selection Statement Exercise 
//Exercise #1

Console.WriteLine("This is exercise 1 of 2, to move forward, the correct answer is 27");
Console.WriteLine();

bool Correct = false;
while (!Correct)
{
    var favNumber = 27;

    Console.WriteLine("Can you guess my favorite number?");
    var userInput = int.Parse(Console.ReadLine());

    if (userInput > 27)
    {
        Console.WriteLine("That number is too high!");
    }
    else if (userInput < 27)
    {
        Console.WriteLine("The inputed number is too low!");
    }
    else if (userInput == favNumber)
    {
        Console.WriteLine("You did it!");
        Correct = true;
    }
    else
    {
        Console.WriteLine("Not a valid answer");
    }

}

//Exercise #2

Console.WriteLine();

Console.WriteLine("What is your favorite school subjet?");
var favSubject = Console.ReadLine();

switch (favSubject.ToLower())
{
    case "history":
        Console.WriteLine("History is amazing, it's my favorite too!") ;
        break;

    case "math":
        Console.WriteLine("Math is a fun and complex subject!");
        break;

    case "english":
        Console.WriteLine("A thine elegant choice!");
        break;

    case "science":
        Console.WriteLine("The future is now thanks to Science!");
        break;

    case "music":
        Console.WriteLine("The study of unseeable beauty!");
        break;

    default:
        Console.WriteLine("What a great subject! Try a different subject for a more unique response!");
        break;

}
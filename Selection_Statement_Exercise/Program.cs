//Selection Statement Exercise 
//Exercise #1

Console.WriteLine("This is exercise 1 of 2 the correct answer is 27");

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
Console.WriteLine();

Console.WriteLine("What is your favorite school subjet?");
var favSubject = Console.ReadLine();
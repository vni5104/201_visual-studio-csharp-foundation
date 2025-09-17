
// Writes: "this line runs no matter what"
TryAnIf();
// Writes: "The answer is 5"
TrySomeLoops();
// Writes: "x isn't 10"
TryAnIfElse();


void TryAnIf()
{
    int someValue = 4;
    string name = "Bobbo Jr.";
    if ((someValue == 3) && (name == "Joe"))
    {
        Console.WriteLine("x is 3 and the name is Joe");
    }
    Console.WriteLine("this line runs no matter what");
}

void TrySomeLoops()
{
    int count = 0;

    // updates count to 10
    while (count < 10)
    {
        count = count + 1;
    }

    // updates count to 5
    for (int i = 0; i < 5; i++)
    {
        count = count - 1;
    }

    Console.WriteLine("The answer is " + count);
}

void TryAnIfElse()
{
    int x = 5;
    if (x == 10)
    {
        Console.WriteLine("x must be 10");
    } 
    else
    {
        Console.WriteLine("x isn't 10");
    }
}
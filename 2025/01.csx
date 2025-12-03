var lines = File.ReadLines("01-input_data.txt");
int counter = 0;
int startNumber = 50;
// var map = new List<int> { };

enum MapDirection
{
    Increment,
    Decrement
}

private void main()
{
    foreach (string line in lines)
    {
        // Console.WriteLine(line);
        if (!string.IsNullOrEmpty(line))
        {
            handleInput(line);
        }
    }
}

private void handleInput(string input)
{
    string letter = input?.Substring(0, 1);
    int number = int.Parse(input.Substring(1));
    MapDirection direction = MapDirection.Increment;

    direction = letter == "R" ? MapDirection.Increment : MapDirection.Decrement;

    // Console.WriteLine(letter);
    // Console.WriteLine(number);
    // Console.WriteLine(direction);

    // Console.WriteLine("+++++++++++++++++++++++++++++++=");
    // Console.WriteLine(startNumber);
    // Console.WriteLine("+++++++++++++++++++++++++++");

    for (int i = 0; i < number; i++)
    {
        if (direction == MapDirection.Increment)
        {
            // if (startNumber == 0)
            // {
            //     counter++;
            // }

            checkNum();

            startNumber++;



            if (startNumber == 100)
            {
                startNumber = 0;
            }

            Console.WriteLine(startNumber);
        }
        else
        {
            // Console.WriteLine(direction);
            // if (startNumber == 0)
            // {
            //     counter++;
            // }

            checkNum();

            startNumber--;


            if (startNumber == -1)
            {
                startNumber = 99;
            }

            Console.WriteLine(startNumber);

        }
    }

    // if (startNumber == 0)
    // {
    //     counter++;
    // }
}

private void checkNum()
{
    if (startNumber == 0)
    {
        counter++;
    }
}

main();
Console.WriteLine("============================");
Console.WriteLine("THE ANSWER:");
Console.WriteLine(counter);

Console.WriteLine("===========================");
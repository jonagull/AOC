var lines = File.ReadLines("01-input_data.txt");
int counter = 0;
int startNumber = 50;
// var map = new List<int> { };

enum MapDirection
{
    Increment,
    Decrement
}

main();
Console.WriteLine("============================");
Console.WriteLine("THE ANSWER:");
Console.WriteLine(counter);
Console.WriteLine("===========================");

private void main()
{
    foreach (string line in lines)
    {
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

    for (int i = 0; i < number; i++)
    {
        if (direction == MapDirection.Increment)
        {
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
            checkNum();
            startNumber--;

            if (startNumber == -1)
            {
                startNumber = 99;
            }

            Console.WriteLine(startNumber);

        }
    }
}

private void checkNum()
{
    if (startNumber == 0)
    {
        counter++;
    }
}

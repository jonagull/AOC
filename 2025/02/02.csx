var file = File.ReadLines("02-input_data.txt").First();
var ranges = file.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

List<long> invalidIds = new();
long sum = 0;

foreach (var range in ranges)
{
    var (first, second) = splitIDs(range);  // tuple destructuring

    long start = long.Parse(first);
    long end = long.Parse(second);

    for (long id = start; id <= end; id++)
    {
        if (checkIfInvalid(id.ToString()))
        {
            invalidIds.Add(id);
            sum += id;
        }
    }
}

Console.WriteLine("Invalid IDs:");
foreach (var id in invalidIds)
{
    Console.WriteLine(id);
}

Console.WriteLine("SUM:");
Console.WriteLine(sum);

(string first, string second) splitIDs(string range)
{
    string[] parts = range.Split('-');
    return (parts[0], parts[1]);  // return tuple (start, end)
}

bool checkIfInvalid(string s)
{
    if (s.Length % 2 != 0)
        return false; // must be even length

    int half = s.Length / 2;
    string left = s.Substring(0, half);
    string right = s.Substring(half, half);

    return left == right;
}
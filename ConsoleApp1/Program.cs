
Console.WriteLine("Enter first path:");
string firstPath = Console.ReadLine();

Console.WriteLine("Enter second path:");
string secondPath = Console.ReadLine();



void GetCommonLine(string path1, string path2)
{
    string[] fileA = File.ReadAllLines(path1);
    string[] fileB = File.ReadAllLines(path2);

    foreach(string lineA in fileA)
    {
        foreach(string lineB in fileB)
        {
            if(lineA == lineB)
            {
                Console.WriteLine(lineA);
                System.Environment.Exit(0);
            }
        }
    }
}

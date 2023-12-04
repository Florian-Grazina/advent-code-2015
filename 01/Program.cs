string input = File.ReadAllText("../../../input.txt");

int floor = 0;

for(int i = 0; i < input.Length; i++)
{
    switch (input[i])
    {
        case ')': floor--; break;
        case '(': floor++; break;
    };
    if(floor == -1)
        Console.WriteLine(i+1);
}

Console.WriteLine(floor);
string[] Array = { "-)", "Rows", "MEGA!", "Mobilization", "52", "235" };
string opa = string.Join(", ", Array);
Console.Write($"[{opa}] -> ");
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        if (i != Array.Length - 1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}");
        }
    }
}

Console.Write("Enter number for watch all even numbers since 1 and up to yours: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Catch it: ");
for (int i = 2; i <= n; i = i + 2)
{
    Console.Write(i);
    if (i != n & i != n - 1)
        Console.Write(", ");
}

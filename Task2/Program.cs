Console.WriteLine("How many numbers you have?");
int n = Convert.ToInt32(Console.ReadLine()) - 1;
if (n > 10)
{
Console.WriteLine("So many numbers....come on....");
Console.WriteLine("Try again (no more than ten please) ");
n = Convert.ToInt32(Console.ReadLine()) - 1;
}
else
    Console.WriteLine("Print Number ");
    double max = Convert.ToDouble(Console.ReadLine());
    for (int count = 0; count < n; count++)
    {
        Console.WriteLine("Print Number ");
        double temp = Convert.ToDouble(Console.ReadLine());
        if (temp > max)
        {
            max = temp;
        }
    }
    Console.Write("Max Number is ");
    Console.Write(max);
    Console.Write(" !!!");

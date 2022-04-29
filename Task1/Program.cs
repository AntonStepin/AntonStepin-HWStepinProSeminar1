Console.WriteLine("Write first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write second number:  ");
double number2 = Convert.ToDouble(Console.ReadLine());
double max = number1;
if (number2 > number1)
{
    max = number2;
}
Console.Write("Max number = ");
Console.WriteLine(max);
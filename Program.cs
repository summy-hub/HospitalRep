Console.WriteLine("Enter first number");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine(AddThreeIntegers(firstNumber, secondNumber, thirdNumber));
static int AddThreeIntegers(int firstNumber, int secondNumber, int thirdNumber)
{
    return firstNumber + secondNumber + thirdNumber;
}
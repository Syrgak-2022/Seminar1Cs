// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine(firstNumber + " является квадратом от " + secondNumber);
// }
// else
// {
//     Console.WriteLine(firstNumber + " НЕ является квадратом от " + secondNumber);
// }

int number = Convert.ToInt32(Console.ReadLine());

int negativeNumber = number * (-1);

while (negativeNumber <= number)
{
    Console.WriteLine(negativeNumber);
    negativeNumber = negativeNumber + 1;
}
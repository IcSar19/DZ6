Console.Clear();
Console.WriteLine("Введите колличество элементов в массиве: ");
int numbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите все значения элементов массива, используя разделитель (пробел)");
double[] array = Console.ReadLine().Split(' ').Select(х => double.Parse(х)).ToArray();

if (array.Length != numbers)
{
  Console.WriteLine("Вы ввели неверное количество элементов.");
}
else
{
  Console.WriteLine($"Количество эллементов больше 0 = {QuantityPositiveNumbers(numbers, array)}");
}

int QuantityPositiveNumbers (int numbers, double[] array)
{
  int sum = 0;
  for (int i = 0; i < numbers; i++)
  {
    if (array[i] > 0)
    {
      sum++;
    }
  }
  return sum;
}
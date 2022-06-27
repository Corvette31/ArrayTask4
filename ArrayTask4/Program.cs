using System;

namespace ArrayTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            string userInput;
            int sum = 0;
            int[] array = new int[0];

            Console.WriteLine("Вводите числа, sum - сумма всех введенных элементов, exit - выход из программы");

            while (isRun)
            {
                Console.Write("Введите число или команду: ");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "sum":
                        for (int i = 0; i < array.Length; i++)
                        {
                            sum += array[i];
                        }

                        Console.WriteLine($"Тукущая сумма введенных чисел: {sum}");
                        break;
                    case "exit":
                        isRun = false;
                        break;
                    default:
                        int[] tempArray = new int[array.Length + 1];

                        for (int i = 0; i < array.Length; i++)
                        {
                            tempArray[i] = array[i];
                        }

                        tempArray[tempArray.LongLength - 1] = Convert.ToInt32(userInput);
                        array = tempArray;
                        break;
                }
            }
        }
    }
}

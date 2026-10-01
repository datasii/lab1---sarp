using System;

namespace Lab1
{
    /// <summary>
    /// Класс с задачами лабораторной работы №1.
    /// Реализованы только чётные задания.
    /// </summary>
    public class Tasks
    {
        // ЗАДАНИЕ 1. МЕТОДЫ

        // Задача 2. Сумма двух последних цифр числа.
        public int SumLastNums(int x)
        {
            int last = Math.Abs(x) % 10;
            int prev = (Math.Abs(x) / 10) % 10;
            return last + prev;
        }

        // Задача 4. Положительное ли число.
        public bool IsPositive(int x)
        {
            return x > 0;
        }

        // Задача 6. Заглавная ли латинская буква.
        public bool IsUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        // Задача 8. Равны ли три числа.
        public bool IsEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }

        // Задача 10. Сумма цифр в разряде единиц двух чисел.
        public int LastNumSum(int a, int b)
        {
            int lastA = Math.Abs(a) % 10;
            int lastB = Math.Abs(b) % 10;
            return lastA + lastB;
        }

        //  ЗАДАНИЕ 2. УСЛОВИЯ

        // Задача 2. Безопасное деление.
        public double SafeDiv(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            return (double)x / y;
        }

        // Задача 4. Строка сравнения.
        public string MakeDecision(int x, int y)
        {
            if (x < y)
            {
                return x + " < " + y;
            }
            else if (x > y)
            {
                return x + " > " + y;
            }
            else
            {
                return x + " == " + y;
            }
        }

        // Задача 6. Тройная сумма.
        public bool Sum3(int x, int y, int z)
        {
            if (x + y == z)
            {
                return true;
            }
            if (x + z == y)
            {
                return true;
            }
            if (y + z == x)
            {
                return true;
            }
            return false;
        }

        // Задача 8. Возраст.
        public string Age(int x)
        {
            int lastTwo = x % 100;
            int last = x % 10;

            if (lastTwo >= 11 && lastTwo <= 14)
            {
                return x + " лет";
            }

            if (last == 1)
            {
                return x + " год";
            }

            if (last >= 2 && last <= 4)
            {
                return x + " года";
            }

            return x + " лет";
        }

        // Задача 10. Вывод дней недели.
        public void PrintDays(string x)
        {
            int start = 0;

            if (x == "понедельник") start = 1;
            else if (x == "вторник") start = 2;
            else if (x == "среда") start = 3;
            else if (x == "четверг") start = 4;
            else if (x == "пятница") start = 5;
            else if (x == "суббота") start = 6;
            else if (x == "воскресенье") start = 7;

            if (start == 0)
            {
                Console.WriteLine("это не день недели");
                return;
            }

            for (int i = start; i <= 7; i++)
            {
                Console.WriteLine(DayName(i));
            }
        }

        // Вспомогательный метод: возвращает название дня по номеру.
        private string DayName(int n)
        {
            if (n == 1) return "понедельник";
            if (n == 2) return "вторник";
            if (n == 3) return "среда";
            if (n == 4) return "четверг";
            if (n == 5) return "пятница";
            if (n == 6) return "суббота";
            if (n == 7) return "воскресенье";
            return "";
        }

        // ЗАДАНИЕ 3. ЦИКЛЫ 

        // Задача 2. Числа наоборот.
        public string ReverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result = result + i;
                if (i > 0)
                {
                    result = result + " ";
                }
            }
            return result;
        }

        // Задача 4. Возведение в степень.
        public int Pow(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result = result * x;
            }
            return result;
        }

        // Задача 6. Одинаковость цифр.
        public bool EqualNum(int x)
        {
            x = Math.Abs(x);
            int firstDigit = x % 10;

            while (x > 0)
            {
                int currentDigit = x % 10;
                if (currentDigit != firstDigit)
                {
                    return false;
                }
                x = x / 10;
            }
            return true;
        }

        // Задача 8. Левый треугольник.
        public void LeftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Задача 10. Угадайка.
        public void GuessGame()
        {
            Random rnd = new Random();
            int target = rnd.Next(0, 10);
            int attempts = 0;

            while (true)
            {
                Console.Write("Введите число от 0 до 9: ");
                string input = Console.ReadLine();

                int guess;
                try
                {
                    guess = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Ошибка: это не число. Попробуйте снова.");
                    continue;
                }

                if (guess < 0 || guess > 9)
                {
                    Console.WriteLine("Ошибка: число вне диапазона [0; 9].");
                    continue;
                }

                attempts = attempts + 1;

                if (guess == target)
                {
                    Console.WriteLine("Вы угадали! Число попыток: " + attempts);
                    break;
                }
                else
                {
                    Console.WriteLine("Не угадали, попробуйте снова.");
                }
            }
        }

        // ЗАДАНИЕ 4. МАССИВЫ

        // Задача 2. Поиск последнего значения.
        public int FindLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        // Задача 4. Добавление в массив.
        public int[] Add(int[] arr, int x, int pos)
        {
            int[] result = new int[arr.Length + 1];

            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }

            result[pos] = x;

            for (int i = pos; i < arr.Length; i++)
            {
                result[i + 1] = arr[i];
            }

            return result;
        }

        // Задача 6. Реверс (изменяет исходный массив).
        public void Reverse(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left = left + 1;
                right = right - 1;
            }
        }

        // Задача 8. Объединение массивов.
        public int[] Concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }

            return result;
        }

        // Задача 10. Удалить негатив.
        public int[] DeleteNegative(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    count = count + 1;
                }
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    result[index] = arr[i];
                    index = index + 1;
                }
            }

            return result;
        }

        //  ВСПОМОГАТЕЛЬНОЕ
        // Превращает массив в строку вида [1, 2, 3]
        public static string ArrToString(int[] arr)
        {
            string result = "[";
            for (int i = 0; i < arr.Length; i++)
            {
                result = result + arr[i];
                if (i < arr.Length - 1)
                {
                    result = result + ", ";
                }
            }
            result = result + "]";
            return result;
        }
    }
}
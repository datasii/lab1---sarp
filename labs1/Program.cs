using System;

namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Tasks t = new Tasks();
            // ЗАДАНИЕ 1. МЕТОДЫ
            Console.WriteLine("ЗАДАНИЕ 1. МЕТОДЫ");
            Console.WriteLine();

            //Задача 2. Сумма знаков
            Console.WriteLine(" Задача 2. Сумма знаков ");
            int x1 = ReadInt("Введите целое число (не менее двух знаков): ", -999999999, 999999999);
            Console.WriteLine("x = " + x1);
            Console.WriteLine("Результат: " + t.SumLastNums(x1));
            Console.WriteLine();

            //Задача 4. Есть ли позитив
            Console.WriteLine(" Задача 4. Есть ли позитив ");
            int x2 = ReadInt("Введите целое число x: ", -1000000, 1000000);
            Console.WriteLine("x = " + x2 + " -> " + t.IsPositive(x2));
            Console.WriteLine();

            //Задача 6. Большая буква
            Console.WriteLine(" Задача 6. Большая буква ");
            char c1 = ReadChar("Введите латинскую букву: ");
            Console.WriteLine("x = '" + c1 + "' -> " + t.IsUpperCase(c1));
            Console.WriteLine();

            //Задача 8. Равенство 
            Console.WriteLine(" Задача 8. Равенство ");
            int a = ReadInt("a = ", -1000000, 1000000);
            int b = ReadInt("b = ", -1000000, 1000000);
            int c = ReadInt("c = ", -1000000, 1000000);
            Console.WriteLine("a=" + a + " b=" + b + " c=" + c + " -> " + t.IsEqual(a, b, c));
            Console.WriteLine();

            //Задача 10. Многократный вызов
            Console.WriteLine(" Задача 10. Многократный вызов ");
            int acc = ReadInt("Введите 1-е число: ", -1000000, 1000000);
            for (int i = 2; i <= 6; i++)
            {
                int next = ReadInt("Введите " + i + "-е число: ", -1000000, 1000000);
                acc = t.LastNumSum(acc, next);
                Console.WriteLine("Промежуточная сумма: " + acc);
            }
            Console.WriteLine("Итого: " + acc);
            Console.WriteLine();
            //ЗАДАНИЕ 2. УСЛОВИЯ
            Console.WriteLine(" ЗАДАНИЕ 2. УСЛОВИЯ ");
            Console.WriteLine();

            //Задача 2. Безопасное деление 
            Console.WriteLine(" Задача 2. Безопасное деление ");
            int x3 = ReadInt("x = ", -1000000, 1000000);
            int y3 = ReadInt("y = ", -1000000, 1000000);
            Console.WriteLine("x=" + x3 + " y=" + y3 + " -> " + t.SafeDiv(x3, y3));
            Console.WriteLine();

            //Задача 4. Строка сравнения 
            Console.WriteLine(" Задача 4. Строка сравнения ");
            int x4 = ReadInt("x = ", -1000000, 1000000);
            int y4 = ReadInt("y = ", -1000000, 1000000);
            Console.WriteLine("Результат: " + t.MakeDecision(x4, y4));
            Console.WriteLine();

            //Задача 6. Тройная сумма 
            Console.WriteLine(" Задача 6. Тройная сумма ");
            int x5 = ReadInt("x = ", -1000000, 1000000);
            int y5 = ReadInt("y = ", -1000000, 1000000);
            int z5 = ReadInt("z = ", -1000000, 1000000);
            Console.WriteLine("x=" + x5 + " y=" + y5 + " z=" + z5 + " -> " + t.Sum3(x5, y5, z5));
            Console.WriteLine();

            //Задача 8. Возраст 
            Console.WriteLine(" Задача 8. Возраст ");
            int age = ReadInt("Введите возраст (0..150): ", 0, 150);
            Console.WriteLine("Результат: " + t.Age(age));
            Console.WriteLine();

            //Задача 10. Вывод дней недели 
            Console.WriteLine(" Задача 10. Вывод дней недели ");
            Console.Write("Введите день недели: ");
            string day = Console.ReadLine();
            t.PrintDays(day);
            Console.WriteLine();
            // ЗАДАНИЕ 3. ЦИКЛЫ
            Console.WriteLine(" ЗАДАНИЕ 3. ЦИКЛЫ ");
            Console.WriteLine();

            //Задача 2. Числа наоборот 
            Console.WriteLine(" Задача 2. Числа наоборот ");
            int x6 = ReadInt("Введите x (0..1000): ", 0, 1000);
            Console.WriteLine("x=" + x6 + " -> " + t.ReverseListNums(x6));
            Console.WriteLine();

            //Задача 4. Возведение в степень 
            Console.WriteLine(" Задача 4. Возведение в степень ");
            int x7 = ReadInt("Введите основание x: ", -100, 100);
            int y7 = ReadInt("Введите степень y (0..10): ", 0, 10);
            Console.WriteLine("x=" + x7 + " y=" + y7 + " -> " + t.Pow(x7, y7));
            Console.WriteLine();

            //Задача 6. Одинаковость 
            Console.WriteLine(" Задача 6. Одинаковость ");
            int x8 = ReadInt("Введите целое число: ", -1000000, 1000000);
            Console.WriteLine("x=" + x8 + " -> " + t.EqualNum(x8));
            Console.WriteLine();

            //Задача 8. Левый треугольник 
            Console.WriteLine(" Задача 8. Левый треугольник ");
            int x9 = ReadInt("Введите высоту треугольника (1..50): ", 1, 50);
            Console.WriteLine("x=" + x9 + ":");
            t.LeftTriangle(x9);
            Console.WriteLine();

            //Задача 10. Угадайка 
            Console.WriteLine(" Задача 10. Угадайка ");
            t.GuessGame();
            Console.WriteLine();

            // ЗАДАНИЕ 4. МАССИВЫ
            Console.WriteLine(" ЗАДАНИЕ 4. МАССИВЫ ");
            Console.WriteLine();

            //Задача 2. Поиск последнего значения
            Console.WriteLine(" Задача 2. Поиск последнего значения ");
            int[] arr1 = ReadArray("Введите массив целых чисел через пробел: ");
            int target1 = ReadInt("Введите x для поиска: ", -1000000, 1000000);
            Console.WriteLine("arr = " + Tasks.ArrToString(arr1) + ", x=" + target1);
            Console.WriteLine("Результат: " + t.FindLast(arr1, target1));
            Console.WriteLine();

            // Задача 4. Добавление в массив 
            Console.WriteLine(" Задача 4. Добавление в массив ");
            int[] arr2 = ReadArray("Введите массив целых чисел через пробел: ");
            int insVal = ReadInt("Введите вставляемое значение x: ", -1000000, 1000000);
            int pos = ReadInt("Введите позицию pos (0.." + arr2.Length + "): ", 0, arr2.Length);
            Console.WriteLine("arr = " + Tasks.ArrToString(arr2) + ", x=" + insVal + ", pos=" + pos);
            Console.WriteLine("Результат: " + Tasks.ArrToString(t.Add(arr2, insVal, pos)));
            Console.WriteLine();

            //Задача 6. Реверс 
            Console.WriteLine(" Задача 6. Реверс ");
            int[] arr3 = ReadArray("Введите массив целых чисел через пробел: ");
            Console.WriteLine("arr = " + Tasks.ArrToString(arr3));
            t.Reverse(arr3);
            Console.WriteLine("Результат: " + Tasks.ArrToString(arr3));
            Console.WriteLine();

            //Задача 8. Объединение
            Console.WriteLine(" Задача 8. Объединение ");
            int[] a1 = ReadArray("Первый массив: ");
            int[] a2 = ReadArray("Второй массив: ");
            Console.WriteLine("arr1 = " + Tasks.ArrToString(a1));
            Console.WriteLine("arr2 = " + Tasks.ArrToString(a2));
            Console.WriteLine("Результат: " + Tasks.ArrToString(t.Concat(a1, a2)));
            Console.WriteLine();

            //Задача 10. Удалить негатив
            Console.WriteLine(" Задача 10. Удалить негатив ");
            int[] arr4 = ReadArray("Введите массив целых чисел через пробел: ");
            Console.WriteLine("arr = " + Tasks.ArrToString(arr4));
            Console.WriteLine("Результат: " + Tasks.ArrToString(t.DeleteNegative(arr4)));
            Console.WriteLine();

            Console.WriteLine(" ВСЕ ЗАДАЧИ ВЫПОЛНЕНЫ ");
        }

        //ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ 

        // Считывает целое число и проверяет, что оно в диапазоне [min, max].
        static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Ошибка: пустой ввод.");
                    continue;
                }

                int value;
                try
                {
                    value = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Ошибка: \"" + input + "\" — это не целое число.");
                    continue;
                }

                if (value < min || value > max)
                {
                    Console.WriteLine("Ошибка: число " + value + " вне диапазона [" + min + "; " + max + "].");
                    continue;
                }

                return value;
            }
        }

        // Считывает один символ.
        static char ReadChar(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Ошибка: пустой ввод.");
                    continue;
                }

                if (input.Length != 1)
                {
                    Console.WriteLine("Ошибка: нужно ровно один символ.");
                    continue;
                }

                return input[0];
            }
        }

        // Считывает массив целых чисел из строки.
        static int[] ReadArray(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Ошибка: пустой ввод.");
                    continue;
                }

                string[] parts = input.Split(' ');

                // Считаем, сколько непустых кусков

                int count = 0;
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i] != "")
                    {
                        count = count + 1;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("Ошибка: не найдено ни одного числа.");
                    continue;
                }

                int[] arr = new int[count];
                int index = 0;
                bool ok = true;

                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i] == "")
                    {
                        continue;
                    }

                    int value;
                    try
                    {
                        value = int.Parse(parts[i]);
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка: \"" + parts[i] + "\" — это не целое число.");
                        ok = false;
                        break;
                    }

                    arr[index] = value;
                    index = index + 1;
                }

                if (ok)
                {
                    return arr;
                }
            }
        }
    }
}
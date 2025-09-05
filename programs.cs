

//using System;

//class Program
//{
//    static string GetInitials(string fullName)
//    {
//        string[] parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//        if (parts.Length < 2)
//            return "";

//        char firstInitial = char.ToUpper(parts[0][0]);
//        char secondInitial = char.ToUpper(parts[1][0]);

//        return $"{firstInitial}.{secondInitial}.";
//    }

//    static void Main()
//    {
//        Console.WriteLine(GetInitials("Иван Иванов"));  // Вывод: И.И.
//    }
//}



//using System;

//class Program
//{
//    static int Cube(int n)
//    {
//        return n * n * n;
//    }

//    static void Main()
//    {
//        Console.WriteLine(Cube(3));  // 27
//    }
//}



//using System;

//class Program
//{
//    static int GetMin(int a, int b)
//    {
//        return (a < b) ? a : b;
//    }

//    static void Main()
//    {
//        Console.WriteLine(GetMin(5, 10));  // 5
//    }
//}




//using System;

//class Program
//{
//    static int CountDigits(int n)
//    {
//        n = Math.Abs(n); // чтобы отрицательные числа тоже считались правильно
//        return n.ToString().Length;
//    }

//    static void Main()
//    {
//        Console.WriteLine(CountDigits(12345));  // 5
//    }
//}



//using System;

//class Program
//{
//    static int SumOfEven(int n)
//    {
//        int sum = 0;
//        for (int i = 2; i <= n; i += 2)
//        {
//            sum += i;
//        }
//        return sum;
//    }

//    static void Main()
//    {
//        Console.WriteLine(SumOfEven(10));  // 30
//    }
//}



//using System;

//class Program
//{
//    static char GetLastChar(string text)
//    {
//        if (string.IsNullOrEmpty(text))
//            throw new ArgumentException("Строка не должна быть пустой");

//        return text[text.Length - 1];
//    }

//    static void Main()
//    {
//        Console.WriteLine(GetLastChar("Привет"));  // т
//    }
//}





//        using System;

//class Program
//    {
//        static void Main(string[] args)
//        {
//            // === Пример использования Fibonacci ===
//            Console.Write("Введите номер числа Фибоначчи (n): ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Fibonacci({n}) = {Fibonacci(n)}");

//            Console.WriteLine();

//            // === Пример использования Palindrome ===
//            Console.Write("Введите слово или фразу для проверки на палиндром: ");
//            string text = Console.ReadLine();
//            Console.WriteLine($"Palindrome(\"{text}\") = {Palindrome(text)}");
//        }

//        // Функция: возвращает n-й элемент последовательности Фибоначчи
//        public static int Fibonacci(int n)
//        {
//            if (n < 0)
//                throw new ArgumentException("n должно быть неотрицательным");

//            if (n == 0) return 0;
//            if (n == 1) return 1;

//            int a = 0, b = 1, result = 0;

//            for (int i = 2; i <= n; i++)
//            {
//                result = a + b;
//                a = b;
//                b = result;
//            }

//            return result;
//        }

//        // Функция: проверяет, является ли строка палиндромом
//        public static bool Palindrome(string text)
//        {
//            if (string.IsNullOrWhiteSpace(text))
//                return false;

//            // Приводим к нижнему регистру и убираем пробелы
//            text = text.ToLower().Replace(" ", "");

//            int left = 0;
//            int right = text.Length - 1;

//            while (left < right)
//            {
//                if (text[left] != text[right])
//                    return false;

//                left++;
//                right--;
//            }

//            return true;
//        }
//    } }



//using System;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("=== Мини-библиотека функций ===");
//            Console.WriteLine("1. Перевод температуры (Цельсий → Фаренгейт)");
//            Console.WriteLine("2. Среднее арифметическое массива чисел");
//            Console.WriteLine("3. Подсчёт количества гласных в строке");
//            Console.WriteLine("0. Выход");
//            Console.Write("Выберите действие: ");

//            string choice = Console.ReadLine();
//            Console.WriteLine();

//            switch (choice)
//            {
//                case "1":
//                    ConvertTemperature();
//                    break;
//                case "2":
//                    CalculateAverage();
//                    break;
//                case "3":
//                    CountVowels();
//                    break;
//                case "0":
//                    Console.WriteLine("Выход из программы...");
//                    return;
//                default:
//                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
//                    break;
//            }

//            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//            Console.ReadKey();
//        }
//    }

//    // 1. Перевод температуры из Цельсия в Фаренгейты
//    static void ConvertTemperature()
//    {
//        Console.Write("Введите температуру в градусах Цельсия: ");
//        if (double.TryParse(Console.ReadLine(), out double celsius))
//        {
//            double fahrenheit = celsius * 9 / 5 + 32;
//            Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit:F2} °F");
//        }
//        else
//        {
//            Console.WriteLine("Ошибка: введите корректное число.");
//        }
//    }

//    // 2. Среднее арифметическое массива чисел
//    static void CalculateAverage()
//    {
//        Console.Write("Введите числа через пробел: ");
//        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//        double[] numbers;
//        try
//        {
//            numbers = input.Select(double.Parse).ToArray();
//        }
//        catch
//        {
//            Console.WriteLine("Ошибка: введите только числа.");
//            return;
//        }

//        if (numbers.Length == 0)
//        {
//            Console.WriteLine("Ошибка: массив пуст.");
//            return;
//        }

//        double average = numbers.Average();
//        Console.WriteLine($"Среднее арифметическое: {average:F2}");
//    }

//    // 3. Подсчёт количества гласных в строке
//    static void CountVowels()
//    {
//        Console.Write("Введите строку: ");
//        string text = Console.ReadLine().ToLower();

//        char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я',
//                          'a', 'e', 'i', 'o', 'u', 'y' };

//        int count = text.Count(c => vowels.Contains(c));

//        Console.WriteLine($"Количество гласных букв: {count}");
//    }
//}

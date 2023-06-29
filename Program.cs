using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($@"задание 1 = ");
            HomeWork1();
            Console.Write($@"задание 2 = ");
            HomeWork2();
            Console.Write($@"задание 3 = ");
            HomeWork3();
            Console.Write($@"задание 4 = ");
            DopHomeWork();


        }
        static void HomeWork1()
        {
            //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            //456-> 5
            //782-> 8
            //918-> 1
            int number = (new Random().Next(-100000, 100000));
            for (int i = -99; i < 100; i++)
            {
                if (number == i)
                {
                    Console.WriteLine($@"{number} не является трехзначным !");
                }
            }
            if (number > 100)
            {
                string numberResult = Convert.ToString(number);
                Console.WriteLine($@"Введенное число {number}
                Вторая цифра этого числа {numberResult[1]}");
            }
            if (number < -100)
            {
                string numberResult = Convert.ToString(number);
                Console.WriteLine($@"Введенное число {number}
                Вторая цифра этого числа {numberResult[2]}");
            }
        }
        static void HomeWork2()
        {
            //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
            //645-> 5
            //78->третьей цифры нет
            //32679-> 6

            int numberOone = (new Random().Next(10, 100000));


            while (numberOone > 100)
            {
                string number_two = Convert.ToString(numberOone);
                Console.WriteLine($@"Введенное число {numberOone}
                Третья цифра нашего числа {number_two[2]}");
                break;
            }
            if (numberOone < -100)
            {
                string number_two = Convert.ToString(numberOone);
                Console.WriteLine($@"Введенное число {numberOone}
                Третья цифра нашего числа {number_two[3]}");
            }
            if (numberOone < 100)
            {
                Console.WriteLine("третьей цифры нет");
            }
        }
        static void HomeWork3()
        {
            //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            //6->да
            //7->да
            //1->нет
            int numberInSeven = (new Random().Next(1, 8));
            if (numberInSeven < 8)
            {
                if (numberInSeven > 0)
                {
                    if (numberInSeven == 6 || numberInSeven == 7)
                    {
                        Console.WriteLine($@"число {numberInSeven} является номером выходного дня");
                    }
                    else
                    {
                        Console.WriteLine($@"число {numberInSeven} НЕ является номером выходного дня");
                    }
                }
            }
        }
        static void DopHomeWork()
        {
            //Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. 
            //Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл - т массива – сгенерирован случайно)
            //Пример для 1 элемента массива: 591, сумма: 5 + 9 + 1 = 15; произведение: 5 * 9 * 1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
            //[591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
            int[] array = new int[10];
            int count = 0;
            Random random = new Random();

            while (count < 10)
            {
                int numberOne = random.Next(10, 1000);
                int numberTwo = numberOne / 10;
                numberTwo = numberTwo % 10;
                int numberThird = numberTwo;

                numberTwo = numberOne / 100;
                int numberFour = numberTwo;

                numberTwo = numberOne % 10;
                int numberFive = numberTwo;

                int productOfNumbers = numberThird * numberFour * numberFive;
                int sumOfNumbers = numberThird + numberFour + numberFive;


                if (productOfNumbers % sumOfNumbers == 0)
                {
                    array[count] = numberOne;
                    count++;
                }
            }

            Console.WriteLine(string.Join(", ", array));

        }


    }
}


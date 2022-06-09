using System;
using GBStudyLib;

/*1. Написать метод, возвращающий минимальное из трёх чисел.
2.Написать метод подсчета количества цифр числа.
3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
5.
а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
7.
a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

Студент Ким Алексей 
*/

namespace Homework2
{
    internal class Program
    {
        


        static void Main()
            {
            //Меню программы
            Console.Title = "Домашнее задание 2";
            Console.WriteLine("Здравствуйте, Юзер!/nДобро пожаловать в меню выбора программ!");
            Console.WriteLine("//////////////////////////////////////////////////////////////");
            Console.WriteLine("Пожалуйста введите номер программы!");
            Console.WriteLine("//////////////////////////////////////////////////////////////");
            Console.WriteLine("1:Метод возвращающий минимальное из трех чисел");
            Console.WriteLine("2:Метод подсчета количества цифр числа");
            Console.WriteLine("3:Метод подсчета суммы всех нечетных положительных чисел.");
            Console.WriteLine("4:Программа аутентификации.");
            Console.WriteLine("5:Программа проверки веса");
            Console.WriteLine("6:Программа подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000");
            Console.WriteLine("7:Методы рекурсии");


            Console.WriteLine("//////////////////////////////////////////////////////////////");

            int menuSwitch = int.Parse(Console.ReadLine());
            switch (menuSwitch)
            {
               
                case 1: 
                    menuSwitch = 1;
                    MinFinder();
                    break;
                case 2 : 
                    menuSwitch = 2;
                    NumCount(); 
                    break;
                case 3:
                    menuSwitch = 3;
                    SumOdd();
                    break;
                case 4:
                    menuSwitch = 4; ;
                    Login();
                    break;
                case 5:
                    menuSwitch = 5;
                    MassCheck();
                    break;
                case 6:
                    menuSwitch = 6;
                    NumCheck();
                    break;
                case 7:
                    menuSwitch = 7;
                    Recurs();
                    break;
            }

            // Задание 1) Написать метод, возвращающий минимальное из трёх чисел
            static void MinFinder()
             {
                Console.Title = "1:Метод возвращающий минимальное из трех чисел";
                Console.WriteLine("Введите первое число");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите третье число");
                int c = int.Parse(Console.ReadLine());
                int min;

                min = a;
                if (b < a) min = b;
                if (c < min) min = c;

                Console.WriteLine($"Минимальное число = {min}");
                
            }
            //2. Написать метод подсчета количества цифр числа.
            static void NumCount() 
            {
                Console.Title = "2:Метод подсчета количества цифр числа";
                Console.WriteLine("Введите число от 0 до 999");
                int a = int.Parse(Console.ReadLine());
                int num;
                if (a >= 0 && a < 10) { 
                    num = 1;
                    Console.WriteLine($"Количество цифр в числе = {num}");
                }
                    
                else if (a >= 10 && a < 100) { 
                    num = 2;
                    Console.WriteLine($"Количество цифр в числе = {num}");
                }
                   
                else if (a >= 100 && a < 1000) { 
                    num = 3;
                    Console.WriteLine($"Количество цифр в числе = {num}");
                }

            }

            //Задание 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел..
            static void SumOdd() 
            {
                Console.Title = "3:Метод подсчета суммы всех нечетных положительных чисел";
                
                int a;
                int sum = 0;
                static bool NotOdd(int x)
                {
                    return x % 2 != 0;
                }

                do
                {
                    Console.WriteLine("Пожалуйста введите число, введите 0 если хотите подсчитать сумму нечетных положительных чисел");
                    a = int.Parse(Console.ReadLine());
                    if (NotOdd(a) && a > 0)
                           sum = sum + a;
                                                          
                    
                }
                while (a != 0);

                Console.WriteLine($"Сумма нечетных чисел = {sum}");



            }
            //4. Метод проверки логина и пароля.

            static void Login()
            {
                Console.Title = "Программа аутентификации";
                int count = 4;
                do
                {
                    Console.WriteLine("Введите Логин:");
                    string login = Console.ReadLine();
                    Console.WriteLine("Введите Пароль:");
                    string pass = Console.ReadLine();

                    if (login == "root" && pass == "GeekBrains")
                    {
                        Console.WriteLine($"Авторизация прошла успешно!");
                        break;
                    }

                    else if (login != "root" || pass != "GeekBrains")
                    {
                        count = count - 1;
                        Console.WriteLine($"Логин или пароль неверный!");
                    }
                }
               
                while (count > 0);
                
                Console.ReadLine();
               

            }

            //5. Метод проверки веса
            static void MassCheck()
            {
                Console.Title = "Программа расчета ИМТ и массы";
                Console.WriteLine("Пожалуйста введите свой вес (в кг)");
                string InputWeight = Console.ReadLine();
                double w;
                w = Convert.ToDouble(InputWeight);

                Console.WriteLine("Пожалуйста введите свой рост (в сантиметрах)");
                string InputHeight = Console.ReadLine();
                double h;
                h = Convert.ToDouble(InputHeight);

                double imt;
                imt = w / (h / 100 * h / 100);

                double n;


                if (imt > 0 && imt < 18.5)
                {
                    n = 18.5 * (h / 100 * h / 100) - w;
                    Console.WriteLine($"Ваш ИМТ  = {imt:F2}, наблюдается недостаток массы тела! Время навестить бабушку! необходимо набрать {n:F2} кг!");
                }
                    
                else if (imt >= 18.5 && imt <= 25)
                    Console.WriteLine($"Ваш ИМТ  = {imt:F2}, все хорошо! Так держать!");
                else
                {
                    n = w - 25 * (h / 100 * h / 100);
                    Console.WriteLine($"Ваш ИМТ  = {imt:F2}, наблюдается избыток массы тела! Худей давай! необходимо сбросить {n:F2} кг!");

                }

            }
            // метод проверки чисел
            static void NumCheck()
            {
                Console.Title = "Программа подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000";
                DateTime start = DateTime.Now;



                var mc = new Formulas();
                
                int i = 1;
                int sum = 0;
                


                    do
                    {
                    i++;

                    if (mc.IsGood(i))
                    {
                        
                        sum++;
                    }
                      

                }

                    while (i < 100000000);
                DateTime finish = DateTime.Now;
                

                Console.WriteLine($"Количество «хороших» чисел в диапазоне от 1 до 1 000 000 000 = {sum}");
                Console.WriteLine($"Время выполнения программы {finish - start}");




            }
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            static void Recurs()
            {
                Console.Title = "метод рекурсии";
                // a)
                Console.WriteLine("Введите число а");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число b");
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = b;
                CountNum(a, b);
                SumNum(a, b, sum);

                 static void CountNum(int a, int b)
                {
                    Console.WriteLine(a);

                    if (a < b)
                        CountNum(a + 1, b);
                    
                }

              

                static void SumNum(int a, int b, int sum)
                {
                    if (a < b)
                        SumNum(a + 1, b, sum + a);
                    else
                        Console.WriteLine(sum);
                }
                    




            }
        }

    }
}

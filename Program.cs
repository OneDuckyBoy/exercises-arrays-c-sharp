using System;

namespace задачи_масиви
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            zad3();
        }
        static void zad9()
        {
            //Да се напише програма,
            //която позволява да се въведе четно цяло число n(между 2 и 20)
            //и масив от n на брой цели числа,
            //и след това отпечатва броят на елементите в масива,
            //които имат стойност равна на максималната.
            //най- голямото число във масива 

            int n = int.Parse(Console.ReadLine());
            while (!(n % 2 == 0 && n >= 2 && n <= 20))
            {
                Console.WriteLine("chisloto ne e chetno i m/y 2 i 20");
                n = int.Parse(Console.ReadLine());

            }
            int[] a = new int[n];
            int count = 0;
            for(int i = 1; i < n; i++)
            {
                Console.WriteLine("chislo");
                a[i] = int.Parse(Console.ReadLine());

            }
            int max = a[0];
            for(int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            for(int i = 0; i < n; i++)
            {
                if (a[i] == max)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void zad8()
        {
            //Да се напише програма,
            //която позволява да се въведе число N
            //и после масив от N числа и извежда броят и
            //стойностите на тези от тях,
            //които са по-големи от средното аритметично на елементите на масива.

            //да се въведе N и масив със брой елементи N
            //и да изведе стойностите,
            //които са по-големи от средноаритметичното
            //на сбора на елементите на масива

            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("chislo");
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
            }
            int average = sum / n;
            for(int i = 0; i < n; i++)
            {
                if (a[i] > average)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        static void zad7()
        {
            //Да се състави програма, чрез която се въвеждат 7 естествени числа
            //от интервала [0..5000] в едномерен масив.
            //Програмата да извежда броя на цифрите на получената сума.
            //Пример: 13, 14, 25, 16, 55, 97 900
            //Изход: сума 1120 брой цифри 4
            int n = 7;
            int[] a = new int[n];
            Random k = new Random();
            int sum = 0;
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = k.Next(0, 5000);
                //Console.WriteLine("chislo");
                //a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
                //num++;
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            while (sum>0)
            {
                sum = sum / 10;
                num++;
            }
            Console.WriteLine(num);

        }
        static void zad6()
        {
            ///Да се състави програма,
            ///чрез която се въвеждат 7 цели числа от интервала в едномерен масив.
            ///Програмата да изведе числото, което е най-близко до средната стойност
            ///на въведените числа.

            //Пример: 1,2,3,4,5,6,7
            //Изход: средна стойност 4, най - близка стойност 4
            int n = 7;
            int[] a = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("chislo");
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
            }
            int average =  sum / n ;
            int smallestNum = Math.Abs(average - a[0]);
            int num = 0;
            for(int i = 1; i < n; i++)
            {
                int smallNum = Math.Abs(average-a[i]);
                if (smallestNum > smallNum)
                {
                    num = i-1;
                }
            }
            Console.WriteLine(average);
            Console.WriteLine(num);


        }
        static void zad5()
        {
            //Да се състави програма,
            //чрез която се въвеждат 7 цели числа в едномерен масив.
            //Програмата да изведе средната стойност на въведените числа.
            //Пример: 89, -123, 45, 196, 1204, 0, 112
            //Изход: 217.571

            int n = 7;
            int[] a = new int[n];
            int sum = 0;
            int average = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("chislo");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <n; i++)
            {
                sum += a[i];
            }

            average = sum / n;

            Console.WriteLine(average);
                    
        }
        static void zad4()
        {

        //Да се състави програма,
        //чрез която се въвеждат 7 цели числа от интервала  в едномерен масив.
        //Програмата да изведе най-голямото от въведените числа.
        //Пример: 89, -123, 45, 196, 1204, 0, 112
        //Изход: 1204

            int n = 7;
            int[] a = new int[n];
            int max = 0;

            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("chislo");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine(max);

            Console.ReadLine();
        }
        static void zad3()
        {
            //Да се състави програма, чрез която се въвеждат 7 цели числа
            //от интервала в едномерен масив.Програмата да изведе
            //общата сума на въведените числа.
            //Пример: 89, -123, 45, 196, 1204, 0, 112
            //Изход: 1523
            int n = 7;
            int[] a = new int[n];
            int sum = 0;
            for(int i = 0;i < n; i++)
            {
                Console.WriteLine("chislo");
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
            }
            Console.WriteLine(sum);
        }
        static void zad2()
        {
            //Имаме масив от 6 елемента, цели числа. Да се напише програма,
            //която позволява да се въведат стойности на елементите
            //и после отпечатва стойностите на:
            //през един елемент – тоест само първи, трети и пети
            //само елементите, които са четни числа
            //всички елементи на един ред,//всеки елемент ограден с кавички и разделени един от друг с запетаи
            
            int n = 6;
            int[] a = new int[n];
            for(int i = 0; i < n;i++)
            {
                Console.WriteLine("chislo");
                a[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < n; i += 2)
            {
                Console.WriteLine(a[i]);
            }


            for (int i = 1; i <= n; i += 2)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine(string.Join(", ", a));

            //всички елементи на един ред,
            //всеки елемент ограден с кавички и разделени един от друг с запетаи
            for(int i = 0; i < n; i++)
            {
                Console.Write("'{0}',", a[i]);
            }

        }
        static void zad1()
        {

            //1-  Да се напише програма, която позволява да се въведат N числа и после отпечатва:
            //2-  всички числа, едно под друго
            //3-  всички числа на един ред, разделени с запетая
            //4-  числата в ред, обратен на въведения
            //5-  първото и последното въведено число 

            //1-
            int[] a = { 1, 2, 3, 4, 5, 6 };
            //правим масив

            //2-
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            //изкарва масива като всеки елемент на нов ред

            //3-
            Console.WriteLine(string.Join(", ", a));

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i]+", ");
            //}

            //на един ред

            //4- 

            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }

            //5-  първото и последното въведено число 
            Console.WriteLine();
            Console.WriteLine(a[0]);
            Console.WriteLine(a[a.Length - 2]);
        }
    }
}

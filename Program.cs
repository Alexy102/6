using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов:");
            int m = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] mass = new int[n, m];
            Console.WriteLine("Заполненый массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = rnd.Next(0, 100);
                    Console.Write(mass[i, j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите значение k от 0 до "+(n-1));
            int k = Convert.ToInt32(Console.ReadLine());
            bool znach = true;
            if(k<n) //все элементы строки равны нулю?
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if(mass[i,j]!=0)
                        {
                            znach = false;
                        }
                    }
                }
                Console.Write("Все элементы " + k + " столбца равны 0 ? "+znach);
                znach = true;

                for (int i = 0; i < n; i++) //все элементы строки упорядочены?
                {
                    for (int j = 0; j < m-1; j++)
                    {
                        if (mass[i, j]> mass[i, j+1])
                        {
                            znach = false;
                        }
                    }
                }
                Console.Write("Все элементы " + k + " строки упорядочены ? " + znach);
                znach = true;

                for (int i = 0; i < n; i++) //строка симметрична?
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (mass[i, j] != mass[i, n-1-j])
                        {
                            znach = false;
                        }
                    }
                }
                Console.Write(k + " строка массива симметрична ? " + znach);
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение!");
            }
        }
    }
}

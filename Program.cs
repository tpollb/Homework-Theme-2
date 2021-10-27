using System;
using System.Linq;

namespace Homework_Theme_2
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            
            //блок переменных
            string name;
            int age;
            int height;
            int HistoryGrade;
            int MathGrade;
            int RusGrade;
            int AvgGrade;
            int i = 1;

            //ввод данных
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height:");
            height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter History Grade:");
            HistoryGrade = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Math Grade:");
            MathGrade = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rus Grade:");
            RusGrade = int.Parse(Console.ReadLine());

            
            //вычисление среднего балла
            int[] array = new int[3] { HistoryGrade, MathGrade, RusGrade };
            AvgGrade = (int)array.Average();

            //обычный вывод
            Console.WriteLine("обычный вывод");
            Console.WriteLine(name + age + height + HistoryGrade + MathGrade + RusGrade + AvgGrade);

            //форматированный вывод
            Console.WriteLine("форматированный вывод");
            Console.WriteLine("Имя: {0} возраст: {1} Рост: {2} Оценка по истории: {3} Оценка по математике: {4} Оценка по русскому: {5} Средний балл: {6}",
                name,
                age,
                height,
                HistoryGrade,
                MathGrade,
                RusGrade,
                AvgGrade
                );

            //интерполяция
            Console.WriteLine("Интерполяция");
            Console.WriteLine($"Имя: {name} возраст: {age} Рост: {height} Оценка по истории: {HistoryGrade} Оценка по математике: {MathGrade} Оценка по русскому: {RusGrade} Средний балл: {AvgGrade}");

            Console.WriteLine("Очистка консоли нажмите клавишу");
            Console.ReadLine();

            Console.Clear();

            //вывод по центру

            string[] array1 = new string[7] { "name: " + name, "age: " + age.ToString(), "height: " + height.ToString(), "History Grade" + HistoryGrade.ToString(), "Maths Grade: " + MathGrade.ToString(), "Rus Grade: " + RusGrade.ToString(), "Avg Grade: " + AvgGrade.ToString() };

            int left = 0;
            int top = (Console.WindowHeight / 2) - (array1.Length / 2) - 1;
            int center = Console.WindowWidth / 2;

            for (i = 0; i < array1.Length; i++)
            {
                left = center - (array1[i].Length / 2);           
                Console.SetCursorPosition(left, top);
                Console.WriteLine(array1[i]);
                top = Console.CursorTop;
            }


            Console.ReadKey();
            
        }
    }
}

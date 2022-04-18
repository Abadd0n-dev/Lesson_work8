using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_work8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = Properties.Settings.Default.nameTitle;

            Console.WindowHeight = 40;
            Console.WindowWidth = 70;

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"\t\t{Properties.Settings.Default.greeting}");

                Console.WriteLine($"\n\n{Properties.Settings.Default.name}");
                Console.WriteLine(Properties.Settings.Default.age);
                Console.WriteLine(Properties.Settings.Default.career);

                Console.Write("\n\nEnter your name:");
                Properties.Settings.Default.name = Console.ReadLine();
                Console.Write("Enter your age:");
                Properties.Settings.Default.age = int.Parse(Console.ReadLine());
                Console.Write("Enter your activity:");
                Properties.Settings.Default.career = Console.ReadLine();

                Properties.Settings.Default.Save();

                Console.WriteLine($"\n\n{Properties.Settings.Default.name}");
                Console.WriteLine(Properties.Settings.Default.age);
                Console.WriteLine(Properties.Settings.Default.career);

                Console.ReadKey(true);
            }
        }
    }
}

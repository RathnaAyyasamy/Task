using System;
using System.Threading.Tasks;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value a:");
            var s = Console.ReadLine();

            int a = Convert.ToInt32(s);
            Console.Write("Enter the value b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Task started");
            Task t1 = new Task(Loopingstatement);
            t1.Start();
            //t1.Wait();
            //Console.ReadLine();

            /*Console.WriteLine("Enter the value a:");
            var s = Console.ReadLine();

            int a = Convert.ToInt32(s);
            Console.Write("Enter the value b:");
            int b = Convert.ToInt32(Console.ReadLine());*/
            Task t2 = Task.Run(() => { Swappingvalue(a,b); }); 
            
            //Console.WriteLine("Task started");
            Console.Read();
        }
        public static void Loopingstatement()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Task Completed");
        }
        public static void Swappingvalue(int a, int b)
        {
            Console.WriteLine($"Before swapping a:{a} and b:{b}\n");
            a = a+b ;
            b = a-b;
            a = a-b;
            Console.WriteLine(@"After swapping
a:{0} and b:{1}\n", a, b);
            //Console.ReadLine();

        }

    }
}

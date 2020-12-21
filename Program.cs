using System;
using System.Collections.Generic;

namespace operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList= new List<Student>();
            Student std = new Student();
            while (true)
            {
                Console.WriteLine("enter your choice:1.Add 2.display 3.delete 4.update 5.sort 6.search");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: std.Add(); break;
                    case 2: std.Display(); break;
                    case 3: std.Delete(); break;
                    case 4: std.Update(); break;
                    case 5: std.Sort(); break;
                    case 6: std.Search(); break;
                }
            }
        }
    }
}

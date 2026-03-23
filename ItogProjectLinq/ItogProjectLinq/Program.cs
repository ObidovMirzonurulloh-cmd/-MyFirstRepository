using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Масив классов
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        //абьеденяем все классы
        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes
                .SelectMany(c => c.Students)
                .ToArray();
        }

        //класс со списком для хранение студентов
        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
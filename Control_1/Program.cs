using System;


namespace Control_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Person = new Person("Roman", "Maslov");
            student.AddExams(
                new Exam("Bebra 1", 5, DateTime.Now),
                new Exam("Bebra 2", 3, DateTime.Now),
                new Exam("GOMUNKUL 6", 6, DateTime.Now)
                );

            Console.WriteLine(student.ToShortString());







        }
    }
}

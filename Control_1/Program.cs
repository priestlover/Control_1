using System;
using System.Reflection.Metadata.Ecma335;


namespace Control_1
{
    class Program
    {
        


        public static void Main(string[] args)
        {
            Collector collector = new Collector();
            collector.StudentCollection.AddStudents(
                new Student(new Person("Ivan","Ivanov"),new Education("ohcno"),new Exam[] {new Exam("Gym",5,new DateTime(1/12/2023)),new Exam("Mat analiz",2,new DateTime(3/12/2023)), new Exam("Philosophy", 4, new DateTime(15/12/2023)) },313),
                new Student(new Person("Roman","Romanov"),new Education("ochno"), new Exam[] { new Exam("Gym", 4, new DateTime(1 / 12 / 2023)), new Exam("Mat analiz", 4, new DateTime(3 / 12 / 2023)), new Exam("Philosophy", 3, new DateTime(15 / 12 / 2023)) }, 313),
                new Student(new Person("Amogus", "Amogusov"), new Education("ohcno"), new Exam[] { new Exam("Gym", 2, new DateTime(3 / 12 / 2023)), new Exam("Statistic", 4, new DateTime(7 / 12 / 2023)), new Exam("Philosophy", 4, new DateTime(20 / 12 / 2023)) }, 311),
                new Student(new Person("Snoop", "Dogg"), new Education("online"), new Exam[] { new Exam("Gym", 3, new DateTime(5 / 12 / 2023)), new Exam("Informatika", 5, new DateTime(9 / 12 / 2023)), new Exam("Algebra", 3, new DateTime(25 / 12 / 2023)) }, 215)
                );       
            var trash = collector.StudentCollection.students.Values.ToList();
            Thread.Sleep(1000);
        }
    }
}

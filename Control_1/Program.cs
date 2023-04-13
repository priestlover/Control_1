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
                new Student(new Person("Ivan","Ivanov"),new Education("online"),new Exam[] {new Exam("Gym",5,new DateTime(2023,12,7)),new Exam("Mat analiz",2,new DateTime(2023,12,3)), new Exam("Philosophy", 4, new DateTime(2023,12,15)) },313),
                new Student(new Person("Roman","Romanov"),new Education("ochno"), new Exam[] { new Exam("Gym", 4, new DateTime(2023,12,16)), new Exam("Mat analiz", 4, new DateTime(2023,12,9)), new Exam("Philosophy", 3, new DateTime(2023,12,15)) }, 313),
                new Student(new Person("Amogus", "Amogusov"), new Education("ohcno"), new Exam[] { new Exam("Gym", 2, new DateTime(2023,12,3)), new Exam("Statistic", 4, new DateTime(2023,12,7)), new Exam("Philosophy", 4, new DateTime(2023,12,20)) }, 311),
                new Student(new Person("Snoop", "Dogg"), new Education("online"), new Exam[] { new Exam("Gym", 3, new DateTime(2023, 12,17)), new Exam("Informatika", 5, new DateTime(2023,12,7)), new Exam("Algebra", 3, new DateTime(2023,12,25)) }, 215)
                );
            var temp = collector.StudentCollection.students.Values.ToList();


            /////////////////////////////////////////////////////////////////////////////////
            foreach (var student in temp)
            {
                student.dateSort();
            }

            foreach (var student in temp)
                Console.WriteLine(student.ToString());
            Console.WriteLine("\n\n  ==========================================\n\n");
            foreach (var student in temp)
            {
                student.discSort();
            }

            foreach (var student in temp)
                Console.WriteLine(student.ToString());
            Console.WriteLine("\n\n  ==========================================\n\n");

            foreach (var student in temp)
            {
                student.gradeSort();
            }

            foreach (var student in temp)
                Console.WriteLine(student.ToString());
            Console.WriteLine("\n\n  ==========================================\n\n");
            /////////////////////////////////////////////////////////////////////////////////

            double bebra = collector.StudentCollection.avgGrade;

            Console.WriteLine(bebra);
             var something = collector.StudentCollection.EducationForm(new Education("online"));

            

        }
    }
}

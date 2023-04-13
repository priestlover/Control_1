using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_1
{
    delegate TKey KeySelector<TKey> (Student st);

    class StudentCollection<TKey>
    {
        public Dictionary<TKey, Student> students;
        private KeySelector<TKey> keySelector;

        public double avgGrade
        {
            get {
                return students.Select(x => x.Value.average).Max();
            }
        }

        public IEnumerable<IGrouping<string , KeyValuePair<TKey, Student>>> trash
        {
            get
            {
               return students.GroupBy(x => x.Value.Education.form);
            }
        }


        public StudentCollection(KeySelector<TKey> keySelector)
        {
            this.keySelector = keySelector;
            students = new Dictionary<TKey, Student>();
        }

        public void AddDefaults()
        {
            Student tempMag = new Student();
            TKey key = keySelector(tempMag);
            students.Add(key, tempMag);
        }

        public void AddStudents(params Student[] students)
        {
            foreach (Student student in students) {
                this.students.Add(keySelector(student), student);
            }
        }

        public override string ToString()
        {
            return students.Select(x => x.Key + x.Value.ToString()).ToString();
        }

        public string ToShortString()
        {
            return students.
                Select(x => x.Key + x.Value.ToShortString() + "\nTest/Exams count :" + x.Value.exams.Count + "/" + x.Value.tests.Count + "\n").ToString();
        }

        public IEnumerable<KeyValuePair<TKey, Student>> EducationForm(Education value)
        {
            return students.Where(x => x.Value.Education.form == value.form);
        }

    }
}

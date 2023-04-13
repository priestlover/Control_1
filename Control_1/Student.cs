using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Control_1
{
    class Person
    {
        public string fName { get; set; }
        public string lName { get; set; }

        public Person(string fName = "NoName", string lName = "NoName")
        {
            this.fName = fName;
            this.lName = lName;
        }

        public override string ToString()
        {
            return "First name : " + fName + "\nLast name : " + lName + "\n";
        }
    }


    class Education
    {
        public string form { get; set; }

        public Education(string form = "")
        {
            this.form = form;
        }
        public override string ToString()
        {
            return "Form : " + form + "\n";
        }
    }


    class Student
    {
        private Person _person;
        private Education _education;
        private Exam[] _exams;
        private int groupNumber;

        public List<Test> tests;
        public List<Exam> exams;

        public void dateSort()
        {
            exams.Sort(new ExamComparerByDate());    
        }

        public void discSort()
        {
            exams.Sort(new Exam().Compare);   
        }

        public void gradeSort()
        {
            exams.Sort(new ExamComparerByGrade());
        }

        public double average {
            get
            {
                double result = 0;
                for (int i = 0; i < _exams.Length; i++)
                    result = _exams[i].grade;
                return result/ _exams.Length;
            }
        }

        public bool this[string x]
        {
            get
            {
                if (x == Education.form)
                    return true;
                else
                    return false;
            }
        }

        public Person Person {
            get { return _person; }
            set { _person = value; }
        }

        public Education Education{
            get { return _education; }
            set{_education = value;}   
        }

        public Exam[] Exams
        {
            get { return _exams; }
            set { _exams = value; }
        }

        public int GroupNumber {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        public Student(Person person, Education education, Exam[] exams, int gNumber )
        {
            _person = person;
            _education = education;
            _exams = exams;
            groupNumber = gNumber;
        }

        public Student()
        {
            _person = new Person();
            _education = new Education();
            _exams = new Exam[0];
        }


        public void AddExams(params Exam[] toAdd)
        {
             Array.Resize(ref _exams, _exams.Length+toAdd.Length);
            Array.Copy(toAdd, _exams, toAdd.Length);
        }

        private string PassedExams()
        {
            string result = "";
            for(int i = 0; i < _exams.Length; i++)
            {
                result += _exams[i].ToString();
            }
            return result;
        }

        public override string ToString()
        {
            return Person.ToString() + Education.ToString() +
                "Group number : " + groupNumber + "\n\n" + PassedExams();
        }

        public virtual string ToShortString()
        {
            return Person.ToString() + Education.ToString() +
                "Group number : " + groupNumber + "\n" +
                "Average grade : " + average + "\n\n";
        }
    }
}

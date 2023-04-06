﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_1
{
    class Exam
    {
        public string disc { get; set; }
        public int grade { get; set; }
        public DateTime date { get; set; }


        public Exam(string disc, int grade, DateTime date)
        {
            this.disc = disc;
            this.grade = grade;
            this.date = date;
        }

        public Exam()
        {
            disc = "";
            grade = 0;
            date = DateTime.Now;
        }

        public override string ToString()
        {
            return "Discipline: " + disc + "\nGrade : " + grade + "\nDate :" + date.ToString("dd/MM/yyyy") + "\n";
        }

       

    }
}

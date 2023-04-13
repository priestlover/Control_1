using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_1
{
   class Collector
    {
        public StudentCollection<string> StudentCollection;

        public Collector()
        {
            StudentCollection = new StudentCollection<string>(GenerateKey);
        }
        private string GenerateKey(Student std)
        {
            return std.Person.fName + std.Person.fName;
        }

    }
}

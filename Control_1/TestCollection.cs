using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_1
{
    public delegate KeyValuePair<@int, TValue> GenerateElement<@int, TValue>(int j);

    class TestCollection<int, Student>
    {
        private List<int> keyList;
        private List<Student> valueList;
        private Dictionary<int, Student> dictionary;
        private Dictionary<string, Student> dictionary2;
        private GenerateElement<int,Student> generateElement;


    }
}
 
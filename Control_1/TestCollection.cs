using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_1
{
    public delegate KeyValuePair<TKey,TValue> GenerateElement<TKey, TValue>(int j);

    class TestCollection<TKey, TValue>
    {
        private List<TKey> keyList;
        private List<TValue> valueList;
        private Dictionary<TKey, TValue> dictionary;
        private Dictionary<string, TValue> dictionary2;
        private GenerateElement<TKey,TValue> generateElement;

        public TestCollection(int j) 
        {
            keyList = new List<TKey>(j);
            valueList = new List<TValue>(j);
            dictionary = new Dictionary<TKey, TValue>(j);
            dictionary2 = new Dictionary<string, TValue>(j);
        }

        static public KeyValuePair<int, Student> whatsIt(int a)
        {
            return new KeyValuePair<int, Student>(a, new Student());
        }

        public TestCollection(int j, GenerateElement<TKey,TValue> generateElement) 
        {
            keyList = new List<TKey>(j);
            valueList = new List<TValue>(j);
            dictionary = new Dictionary<TKey, TValue>(j);
            dictionary2 = new Dictionary<string, TValue>(j);
            generateElement(j);
        }




    }
}
 
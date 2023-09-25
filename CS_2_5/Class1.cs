using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_2_5
{
    public class CheckedElem
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        public CheckedElem() { }

        public CheckedElem(string name, string path)
        {
            Name = name;
            Path = path;
            IsChecked = false;
        }
    }

    public class CheckedElems
    {
        public DateTime Date { get; set; }
        public List<CheckedElem> Elements { get; set; }
        public List<int> Indexes { get; set; }

        public CheckedElems() { }

        public CheckedElems(DateTime date, List<CheckedElem> elements, List<int> indexes)
        {
            Date = date;
            Elements = elements;
            Indexes = indexes;
        }
    }

}

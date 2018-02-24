using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestElement
    {
        DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public override string ToString()
        {
            return date.ToString();
        }

        public TestElement(int day, int month, int year)
        {
            date = new DateTime(year,month,day);
        }
    }
}

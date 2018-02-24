using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Test
{
    public class TestList
    {
        List<TestElement> element_list;
        public List<TestElement> List
        {
            get
            {
                return element_list;
            }
        }

        public TestList()
        {
            element_list = new List<TestElement>();
            element_list.Add(new TestElement(23,04,1990));
            element_list.Add(new TestElement(8, 04, 1990));
            element_list.Add(new TestElement(5, 03, 1662));
            element_list.Add(new TestElement(20, 04, 1845));
            element_list.Add(new TestElement(19, 01, 2003));
            element_list.Add(new TestElement(15, 04, 1550));
            element_list.Add(new TestElement(23, 09, 1490));
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("List elements: ");
            foreach (TestElement elem in element_list)
            {
                str.AppendLine("Date: "+elem.ToString());
            }
            return str.ToString();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    public interface IPrintable
    {
        void Print();
    }

    public interface ISerializable
    {
        void SaveToFile();
    }

    public class Report : IPrintable, ISerializable
    {
        public void Print()
        {
            Console.WriteLine("Printing report...");
        }

        public void SaveToFile()
        {
            Console.WriteLine("Saving report to file...");
        }
    }
}

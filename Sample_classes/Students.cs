using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_classes
{
    class Students
    {
        public string Name { get; set; }
        public int Rollno { get; set; }

    }
    public class Linkexamples
    {
        public static void Main(string[] args)
        {
            List<Students> std = new List<Students>();
            //std.Add()
            std.Add(new Students() { Name = "abccc", Rollno = 1 });
            std.Add(new Students() { Name = "bcddd", Rollno = 2 });
            std.Add(new Students() { Name = "cdef", Rollno = 3 });
            std.Add(new Students() { Name = "defg", Rollno = 4 });
            std.Add(new Students() { Name = "efgh", Rollno = 5 });

            var filtervalues = from st in std
                               where st.Rollno >= 3
                               select st.Name;
            foreach (var name in filtervalues)
            {
                Console.WriteLine(name);
            }


        }
    }


}

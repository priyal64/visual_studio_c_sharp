using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkexamp1
{
    class Std
    {
            public string? Name { get; set; }
            public int Rollno { get; set; }

        }
        public class Linkexamples
        {
            public static void Main(string[] args)
            {
                List<Std> std = new List<Std>();
                //std.Add()
                std.Add(new Std() { Name = "abccc", Rollno = 1 });
                std.Add(new Std() { Name = "bcddd", Rollno = 2 });
                std.Add(new Std() { Name = "cdef", Rollno = 3 });
                std.Add(new Std() { Name = "defg", Rollno = 4 });
                std.Add(new Std() { Name = "efgh", Rollno = 5 });

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

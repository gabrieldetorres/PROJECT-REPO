using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeIn_TimeOut
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TimeSpan TimeIn { get; set; }

        public TimeSpan Timeout { get; set; }

    }
}

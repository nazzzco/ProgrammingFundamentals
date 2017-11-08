using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string a = "";
            Regex r = new Regex(@"[^a-zA-Z\-]+");

            var b = r.Match(a);
            int index = 0;
            if (r.IsMatch(a, index)) 
            {
                Console.WriteLine(r.Match(a,index));
                index = r.Match(a).Index + r.Match(a).Length + 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02.MatchPhoneNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string pattern =  @"\+359( |-)2\1\d{3}\1\d{4}\b";
            // string secondPattern = @"\+359-2\-\d{3,4}-\d{3,4}\b";
            string phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, pattern);
            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}

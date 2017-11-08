using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LadyBugss
{
    static void Main()
    {
        var fieldSize = int.Parse(Console.ReadLine());
        var ladyBugsIndexes = Console.ReadLine().Split().Select(int.Parse).Where(x => x >= 0 && x < fieldSize).ToArray();
        var ladyBugs = new int[fieldSize];

        foreach (var ladyBugIndex in ladyBugsIndexes)
        {
            ladyBugs[ladyBugIndex] = 1;
        }

        while (true)
        {
            var line = Console.ReadLine();
            if (line == "end")
                break;

            var tokens = line.Split(' ');
            var ladybugIndex = int.Parse(tokens[0]);
            var direction = int.Parse(tokens[1]);
            var count = int.Parse(tokens[2]);

            var isInsideArray = ladybugIndex >= 0 && ladybugIndex < ladyBugs.Length;

            if (!isInsideArray)
            {
                continue;
            }

            var ladybugExist = ladyBugs[ladybugIndex] == 1;
            if (!ladybugExist)
            {
                continue;
            }
        }
    }
}


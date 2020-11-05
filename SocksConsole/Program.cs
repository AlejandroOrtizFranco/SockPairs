using System;
using System.Collections.Generic;
using System.Linq;

namespace SocksConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var socks = "CABBACCCCCF";

            var result = Pairs(socks);

            Console.WriteLine(result);
        }

        static int Pairs(string socks)
        {
            var listWithoutPair = socks.Distinct().ToList();

            var socksInList = socks.ToCharArray().ToList();

            return listWithoutPair.Select(sock => socksInList.FindAll(a => a.Equals(sock))).Select(pairsFound => pairsFound.Count / 2).Sum();
        }
    }
}

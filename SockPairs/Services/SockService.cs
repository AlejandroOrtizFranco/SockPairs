using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SockPairs.Services
{
    public class SockService : ISockService
    {
        public int PostPairs(string pairs)
        {
            var cont = 0;

            var listWithoutPair = pairs.Distinct().ToList();

            var socksInList = pairs.ToCharArray().ToList();

            foreach (var sock in listWithoutPair)
            {
                var pairsFound = socksInList.FindAll(a => a.Equals(sock));
                cont += pairsFound.Count / 2;
            }

            return cont;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SockPairs.Services
{
    public interface ISockService
    {
        int PostPairs(string pairs);
    }
}

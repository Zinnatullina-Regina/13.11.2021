using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipher
{
    interface ICriper
    {
        string encode(string one);
        string decode(string two);
    }
}
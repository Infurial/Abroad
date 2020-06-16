using Abroad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abroad.Interfaces
{
    interface IComments
    {
        IEnumerable<Comments> AllComments { get; }
    }
}

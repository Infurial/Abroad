using Abroad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abroad.Interfaces
{
    interface ICitizen
    {
        IEnumerable<Citizen> AllCitizen { get; set; }
        IEnumerable<Citizen> SomeCitizen { get; }

    }
}

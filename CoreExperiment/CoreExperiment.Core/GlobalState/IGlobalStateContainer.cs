using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreExperiment.Core.GlobalState
{
    internal interface IGlobalStateContainer
    {
        ICountryGlobalState Country { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreExperiment.Core.GlobalState
{
    internal class GlobalStateContainer : IGlobalStateContainer
    {
        public ICountryGlobalState Country { get; }

        public GlobalStateContainer(ICountryGlobalState countryState)
        {
            Country = countryState;
        }
    }
}

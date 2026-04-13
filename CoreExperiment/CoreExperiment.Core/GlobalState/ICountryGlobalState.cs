using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreExperiment.Core.GlobalState
{
    internal interface ICountryGlobalState
    {
        ImmutableList<string>? GetCountryCodes();

        void SetCountryCodes(ImmutableList<string> countryCodes);
    }
}

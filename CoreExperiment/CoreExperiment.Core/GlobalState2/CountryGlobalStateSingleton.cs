using CoreExperiment.Core.GlobalState;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreExperiment.Core.GlobalState2
{
    internal class CountryGlobalStateSingleton : ICountryGlobalState
    {
        private MultiReadLockValue<List<string>> _countryCodes = new MultiReadLockValue<List<string>>(new List<string>());

        public List<string> GetCountryCodes()
        {
            return _countryCodes.Get();
        }

        public void SetCountryCodes(List<string> countryCodes)
        {
            _countryCodes.Set(countryCodes);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreExperiment.Core.GlobalState
{
    internal static class CountryGlobalStateKeys
    {
        public const string CountryCodes = nameof(CountryGlobalState) + ":" + nameof(CountryCodes);
    }

    internal class CountryGlobalState : ICountryGlobalState
    {
        private readonly IGlobalStateManager _cache;

        public CountryGlobalState(IGlobalStateManager cache)
        {
            _cache = cache;
        }

        public List<string>? GetCountryCodes()
        {
            return _cache.Get<List<string>>(CountryGlobalStateKeys.CountryCodes);
        }

        public void SetCountryCodes(List<string> countryCodes)
        {
            _cache.Set(CountryGlobalStateKeys.CountryCodes, countryCodes);
        }
    }
}

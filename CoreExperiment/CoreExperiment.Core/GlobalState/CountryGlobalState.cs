using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreExperiment.Core.GlobalState
{
    internal static class CountryGlobalStateKeys
    {
        public const string CountryCodes = "country_codes";
    }

    internal class CountryGlobalState : ICountryGlobalState
    {
        private readonly ICacheWrapper _cache;

        public CountryGlobalState(ICacheWrapper cache)
        {
            _cache = cache;
        }

        public List<string>? GetCountryCodes()
        {
            return (List<string>?)_cache.Get(CountryGlobalStateKeys.CountryCodes);
        }

        public void SetCountryCodes(List<string> countryCodes)
        {
            _cache.Set(CountryGlobalStateKeys.CountryCodes, countryCodes);
        }
    }
}

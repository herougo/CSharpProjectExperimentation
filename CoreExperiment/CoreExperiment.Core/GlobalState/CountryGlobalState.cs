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

        public ImmutableList<string>? GetCountryCodes()
        {
            return _cache.Get<ImmutableList<string>>(CountryGlobalStateKeys.CountryCodes);
        }

        public void SetCountryCodes(ImmutableList<string> countryCodes)
        {
            _cache.Set(CountryGlobalStateKeys.CountryCodes, countryCodes);
        }
    }
}

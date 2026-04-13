using Microsoft.Extensions.Caching.Memory;

namespace CoreExperiment.Core.GlobalState
{
    internal class CacheWrapper : ICacheWrapper
    {
        // Add IMemoryCache with the following: builder.Services.AddMemoryCache();

        private readonly IMemoryCache _cache;

        public CacheWrapper(IMemoryCache cache)
        {
            _cache = cache;
        }

        public object? Get(string key)
        {
            // returns null if not present
            return _cache.Get(key);
        }

        public void Set(string key, object value)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetPriority(CacheItemPriority.NeverRemove); // Prevents eviction during memory pressure

            _cache.Set(key, value, cacheEntryOptions);
        }
    }
}

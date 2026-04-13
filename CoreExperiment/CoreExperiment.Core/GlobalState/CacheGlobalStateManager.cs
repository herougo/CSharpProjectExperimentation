using Microsoft.Extensions.Caching.Memory;

namespace CoreExperiment.Core.GlobalState
{
    internal class CacheGlobalStateManager : IGlobalStateManager
    {
        /*
        Usage
          - Add IMemoryCache with the following: builder.Services.AddMemoryCache();

        Caution
          - Be careful with modifying cache values. For example, if you return a mutable List, then
            modify the list, that will affect the cache. Instead, use an ImmutableList
          - This implementation is meant for storing a manageable amount of global variables as a legacy
            replacement for static variables (it uses NeverRemove as the cache eviction policy).
        */


        private readonly IMemoryCache _cache;

        public CacheGlobalStateManager(IMemoryCache cache)
        {
            _cache = cache;
        }

        public T? Get<T>(string key)
        {
            return _cache.Get<T>(key);
        }

        public void Set<T>(string key, T value)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetPriority(CacheItemPriority.NeverRemove); // Prevents eviction during memory pressure

            _cache.Set(key, value, cacheEntryOptions);
        }
    }
}

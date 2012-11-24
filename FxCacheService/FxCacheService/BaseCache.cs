using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Infrastructure.Caching;

namespace FxCacheService
{
    public class BaseCache
    {
        protected static ICacheManager cacheService = new Fx.Infrastructure.Caching.CacheManager();
    }
}

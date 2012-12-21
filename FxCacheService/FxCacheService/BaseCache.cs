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

        protected static int cacheHalfHour = 30 * 60;

        public static int cacheOneDay = 24 * 3600;

        public static int cacheOneHour = 3600;
    }
}

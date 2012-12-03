using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.FxSite.IService;
using Fx.Entity.FxSite;

namespace FxCacheService.FxSite
{
    public class SiteCache : BaseCache
    {
        protected IPageAjax ajax;
        public SiteCache(IPageAjax ajax)
        {
            this.ajax = ajax;
        }

        public List<Area> GetArea()
        {
            if (cacheService.Get(CacheKey.SiteCacheKey.SITE_AREA) == null)
            {
                var area = ajax.GetAreas();
                cacheService.Insert(CacheKey.SiteCacheKey.SITE_AREA, area, 365 * 24 * 3600, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.SiteCacheKey.SITE_AREA) as List<Area>;
        }
    }
}

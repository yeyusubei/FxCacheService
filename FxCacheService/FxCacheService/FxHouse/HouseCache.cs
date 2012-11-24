using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Base.IService;
using Fx.Entity.FxHouse;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxHouse
{
    public class HouseCache : BaseCache
    {
        IHomeSearch<HouseTransferInfo> homeSearch;
        public HouseCache(IHomeSearch<HouseTransferInfo> homeSearch)
        {
            this.homeSearch = homeSearch;
        }

        public List<HouseTransferInfo> GetHomeLatest()
        {
            int number = 5;
            if (cacheService.Get(CacheKey.HouseKey.HOUSE_HOME_TRANSFER_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.HouseExtendKey.HOUSE_HOME_TRANSFER_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.HouseExtendKey.HOUSE_HOME_TRANSFER_LATEST_Mark).Minutes > 30)
            {
                var list = homeSearch.SearchLatestForHome(number);
                cacheService.Insert(CacheKey.HouseKey.HOUSE_HOME_TRANSFER_LATEST, list, 30, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.HouseExtendKey.HOUSE_HOME_TRANSFER_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSE_HOME_TRANSFER_LATEST) as List<HouseTransferInfo>;
        }
    }
}

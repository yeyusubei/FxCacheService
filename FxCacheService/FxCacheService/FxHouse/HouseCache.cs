using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Base.IService;
using Fx.Domain.FxAggregate.IService;
using Fx.Entity.FxHouse;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxHouse
{
    public class HouseCache : BaseCache
    {
        protected IHomeSearch<HouseTransferInfo> homeSearch;
        protected IHomeTopShow homeTopShow;
        public HouseCache(IHomeSearch<HouseTransferInfo> homeSearch,
            IHomeTopShow homeTopShow)
        {
            this.homeSearch = homeSearch;
            this.homeTopShow = homeTopShow;
        }

        public List<HouseTransferInfo> GetHomeLatest()
        {
            int number = 10;
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

        public List<HouseTransferInfo> GetHomeTopShow()
        {
            if (cacheService.Get(CacheKey.HouseKey.HOUSE_HOME_TOP_SHOW_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.HouseExtendKey.HOUSE_HOME_TOP_SHOW_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.HouseExtendKey.HOUSE_HOME_TOP_SHOW_LATEST_Mark).Minutes > 30)
            {
                var list = homeTopShow.GetHomeHouseTopShow();
                cacheService.Insert(CacheKey.HouseKey.HOUSE_HOME_TOP_SHOW_LATEST, list, 30, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.HouseExtendKey.HOUSE_HOME_TOP_SHOW_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSE_HOME_TOP_SHOW_LATEST) as List<HouseTransferInfo>;
        }
    }
}

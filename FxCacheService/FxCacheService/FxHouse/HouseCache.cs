using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Base.IService;
using Fx.Domain.FxAggregate.IService;
using Fx.Domain.FxHouse;
using Fx.Entity.FxHouse;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxHouse
{
    public class HouseCache : BaseCache
    {
        protected IHomeSearch<HouseTransferInfo> homeSearch;
        protected IHomeTopShow homeTopShow;
        protected HouseListService houseListService;
        public HouseCache(IHomeSearch<HouseTransferInfo> homeSearch,
            IHomeTopShow homeTopShow,
            HouseListService houseListService)
        {
            this.homeSearch = homeSearch;
            this.homeTopShow = homeTopShow;
            this.houseListService = houseListService;
        }

        public List<HouseTransferInfo> GetHomeLatest()
        {
            int number = 10;
            if (cacheService.Get(CacheKey.HouseKey.HOUSE_HOME_TRANSFER_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.HouseExtendKey.HOUSE_HOME_TRANSFER_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.HouseExtendKey.HOUSE_HOME_TRANSFER_LATEST_Mark).Minutes > 15)
            {
                var list = homeSearch.SearchLatestForHome(number);
                cacheService.Insert(CacheKey.HouseKey.HOUSE_HOME_TRANSFER_LATEST, list, 15, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.HouseExtendKey.HOUSE_HOME_TRANSFER_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSE_HOME_TRANSFER_LATEST) as List<HouseTransferInfo>;
        }

        public List<HouseTransferInfo> GetHomeTopShow()
        {
            if (cacheService.Get(CacheKey.HouseKey.HOUSE_HOME_TOP_SHOW_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.HouseExtendKey.HOUSE_HOME_TOP_SHOW_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.HouseExtendKey.HOUSE_HOME_TOP_SHOW_LATEST_Mark).Minutes > 15)
            {
                var list = homeTopShow.GetHomeHouseTopShow();
                cacheService.Insert(CacheKey.HouseKey.HOUSE_HOME_TOP_SHOW_LATEST, list, 15, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.HouseExtendKey.HOUSE_HOME_TOP_SHOW_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSE_HOME_TOP_SHOW_LATEST) as List<HouseTransferInfo>;
        }


        public List<HouseTransferInfo> GetHouseCommercialPropertiesList()
        {
            if (cacheService.Get(CacheKey.HouseKey.HOUSELIST_CommercialProperties) == null)
            {
                var list = houseListService.CommercialProperties();
                cacheService.Insert(CacheKey.HouseKey.HOUSELIST_CommercialProperties, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSELIST_CommercialProperties) as List<HouseTransferInfo>;
        }



        public List<HouseTransferInfo> GetHousePropertiesList()
        {
            if (cacheService.Get(CacheKey.HouseKey.HOUSELIST_Properties) == null)
            {
                var list = houseListService.Properties();
                cacheService.Insert(CacheKey.HouseKey.HOUSELIST_Properties, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSELIST_Properties) as List<HouseTransferInfo>;
        }
    }
}

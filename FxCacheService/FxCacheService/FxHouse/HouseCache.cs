using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Base.IService;
using Fx.Domain.FxAggregate.IService;
using Fx.Domain.FxHouse;
using Fx.Domain.FxHouse.Search;
using Fx.Entity.FxHouse;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxHouse
{
    public partial class HouseCache : BaseCache
    {
        protected IHomeSearch<HouseTransferInfo> homeSearch;
        protected IHomeTopShow homeTopShow;
        protected HouseListService houseListService;
        protected ITopShow topShow;
        protected HouseBuySearchService houseBuySearchService;
        protected HouseTransferSearchService houseTransferSearchService;
        public HouseCache(IHomeSearch<HouseTransferInfo> homeSearch,
            IHomeTopShow homeTopShow,
            HouseListService houseListService,
            ITopShow topShow,
            HouseBuySearchService houseBuySearchService,
            HouseTransferSearchService houseTransferSearchService)
        {
            this.homeSearch = homeSearch;
            this.homeTopShow = homeTopShow;
            this.houseListService = houseListService;
            this.houseBuySearchService = houseBuySearchService;
            this.houseTransferSearchService = houseTransferSearchService;
            this.topShow = topShow;

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


        public List<HouseTransferInfo> GetHouseTransferTopShow()
        {
            if (cacheService.Get(CacheKey.HouseKey.HOUSE_TRANSFER_TOPSHOW) == null)
            {
                var list = topShow.GetHouseTransferTopShow();
                cacheService.Insert(CacheKey.HouseKey.HOUSE_TRANSFER_TOPSHOW, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSE_TRANSFER_TOPSHOW) as List<HouseTransferInfo>;
        }

        public List<HouseBuyInfo> GetHouseBuyTopShow()
        {
            if (cacheService.Get(CacheKey.HouseKey.HOUSE_BUY_TOPSHOW) == null)
            {
                var list = topShow.GetHouseBuyTopShow();
                cacheService.Insert(CacheKey.HouseKey.HOUSE_BUY_TOPSHOW, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSE_BUY_TOPSHOW) as List<HouseBuyInfo>;
        }


        public List<HouseBuyInfo> GetMainHouseBuyALL()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.HOUSE_BUY_GetMainHouseALL) == null)
            {
                var list = houseBuySearchService.SearchByKey("", 0, count);
                cacheService.Insert(CacheKey.HouseKey.HOUSE_BUY_GetMainHouseALL, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSE_BUY_GetMainHouseALL) as List<HouseBuyInfo>;
        }


        public List<HouseTransferInfo> GetMainTransferALL()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.HOUSE_TRANSFER_GetMainHouseALL) == null)
            {
                var list = houseTransferSearchService.SearchByKey("", 0, count);
                cacheService.Insert(CacheKey.HouseKey.HOUSE_TRANSFER_GetMainHouseALL, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.HOUSE_TRANSFER_GetMainHouseALL) as List<HouseTransferInfo>;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Entity.FxHouse;

namespace FxCacheService.FxHouse
{
    public partial class HouseCache
    {
        public List<HouseTransferInfo> GetMainHouseTransferShop()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferShop) == null)
            {
                var list = houseTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Shop, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseTransferShop, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferShop) as List<HouseTransferInfo>;
        }

        public List<HouseTransferInfo> GetMainHouseTransferRestaurants()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferRestaurants) == null)
            {
                var list = houseTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Restaurants, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseTransferRestaurants, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferRestaurants) as List<HouseTransferInfo>;
        }

        public List<HouseTransferInfo> GetMainHouseTransferWarehouse()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferWarehouse) == null)
            {
                var list = houseTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Warehouse, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseTransferWarehouse, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferWarehouse) as List<HouseTransferInfo>;
        }

        public List<HouseTransferInfo> GetMainHouseTransferOffice()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferOffice) == null)
            {
                var list = houseTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Office, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseTransferOffice, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferOffice) as List<HouseTransferInfo>;
        }

        public List<HouseTransferInfo> GetMainHouseTransferHouse()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferHouse) == null)
            {
                var list = houseTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.House, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseTransferHouse, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferHouse) as List<HouseTransferInfo>;
        }

        public List<HouseTransferInfo> GetMainHouseTransferFlat()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferFlat) == null)
            {
                var list = houseTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Flat, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseTransferFlat, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferFlat) as List<HouseTransferInfo>;
        }

        public List<HouseTransferInfo> GetMainHouseTransferStudentAparment()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferStudentAparment) == null)
            {
                var list = houseTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.StudentAparment, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseTransferStudentAparment, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseTransferStudentAparment) as List<HouseTransferInfo>;
        }
    }
}

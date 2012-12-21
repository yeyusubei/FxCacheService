using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Entity.FxHouse;

namespace FxCacheService.FxHouse
{
    public partial class HouseCache
    {
        public List<HouseBuyInfo> GetMainHouseBuyShop()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyShop) == null)
            {
                var list = houseBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Shop, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseBuyShop, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyShop) as List<HouseBuyInfo>;
        }

        public List<HouseBuyInfo> GetMainHouseBuyRestaurants()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyRestaurants) == null)
            {
                var list = houseBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Restaurants, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseBuyRestaurants, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyRestaurants) as List<HouseBuyInfo>;
        }

        public List<HouseBuyInfo> GetMainHouseBuyWarehouse()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyWarehouse) == null)
            {
                var list = houseBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Warehouse, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseBuyWarehouse, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyWarehouse) as List<HouseBuyInfo>;
        }

        public List<HouseBuyInfo> GetMainHouseBuyOffice()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyOffice) == null)
            {
                var list = houseBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Office, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseBuyOffice, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyOffice) as List<HouseBuyInfo>;
        }

        public List<HouseBuyInfo> GetMainHouseBuyHouse()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyHouse) == null)
            {
                var list = houseBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.House, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseBuyHouse, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyHouse) as List<HouseBuyInfo>;
        }

        public List<HouseBuyInfo> GetMainHouseBuyFlat()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyFlat) == null)
            {
                var list = houseBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Flat, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseBuyFlat, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyFlat) as List<HouseBuyInfo>;
        }

        public List<HouseBuyInfo> GetMainHouseBuyStudentAparment()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyStudentAparment) == null)
            {
                var list = houseBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.StudentAparment, 0, count);
                cacheService.Insert(CacheKey.HouseKey.GetMainHouseBuyStudentAparment, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.HouseKey.GetMainHouseBuyStudentAparment) as List<HouseBuyInfo>;
        }
    }
}

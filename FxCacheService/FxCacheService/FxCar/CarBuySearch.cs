using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Entity.FxCar;

namespace FxCacheService.FxCar
{
    public partial class CarCache
    {
        public List<CarBuyInfo> GetMainCarBuyAudi()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyAudi) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Audi, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyAudi, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyAudi) as List<CarBuyInfo>;
        }


        public List<CarBuyInfo> GetMainCarBuyBMW()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyBMW) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.BMW, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyBMW, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyBMW) as List<CarBuyInfo>;
        }

        public List<CarBuyInfo> GetMainCarBuyBuick()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyBuick) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Buick, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyBuick, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyBuick) as List<CarBuyInfo>;
        }

        public List<CarBuyInfo> GetMainCarBuyCitroen()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyCitroen) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Citroen, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyCitroen, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyCitroen) as List<CarBuyInfo>;
        }

        public List<CarBuyInfo> GetMainCarBuyFord()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyFord) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Ford, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyFord, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyFord) as List<CarBuyInfo>;
        }

        public List<CarBuyInfo> GetMainCarBuyHonda()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyHonda) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Honda, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyHonda, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyHonda) as List<CarBuyInfo>;
        }

        public List<CarBuyInfo> GetMainCarBuyToyota()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyToyota) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Toyota, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyToyota, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyToyota) as List<CarBuyInfo>;
        }

        public List<CarBuyInfo> GetMainCarBuyNissan()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyNissan) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Nissan, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyNissan, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyNissan) as List<CarBuyInfo>;
        }

        public List<CarBuyInfo> GetMainCarBuyMINI()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyMINI) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.MINI, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyMINI, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyMINI) as List<CarBuyInfo>;
        }

        public List<CarBuyInfo> GetMainCarBuyMercedesBenz()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyMercedesBenz) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.MercedesBenz, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyMercedesBenz, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyMercedesBenz) as List<CarBuyInfo>;
        }


        public List<CarBuyInfo> GetMainCarBuyPeugeot()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyPeugeot) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Peugeot, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyPeugeot, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyPeugeot) as List<CarBuyInfo>;
        }

        public List<CarBuyInfo> GetMainCarBuyVW()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyVW) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.VW, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyVW, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyVW) as List<CarBuyInfo>;
        }
        public List<CarBuyInfo> GetMainCarBuyVolvo()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuyVolvo) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Volvo, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuyVolvo, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuyVolvo) as List<CarBuyInfo>;
        }
        public List<CarBuyInfo> GetMainCarBuySecondHandCarOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarBuySecondHandCarOther) == null)
            {
                var list = carBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.SecondHandCarOther, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarBuySecondHandCarOther, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarBuySecondHandCarOther) as List<CarBuyInfo>;
        }
    }
}



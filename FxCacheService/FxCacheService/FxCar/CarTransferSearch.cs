using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Entity.FxCar;

namespace FxCacheService.FxCar
{
    public partial class CarCache
    {
        public List<CarTransferInfo> GetMainCarTransferAudi()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferAudi) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Audi, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferAudi, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferAudi) as List<CarTransferInfo>;
        }


        public List<CarTransferInfo> GetMainCarTransferBMW()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferBMW) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.BMW, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferBMW, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferBMW) as List<CarTransferInfo>;
        }

        public List<CarTransferInfo> GetMainCarTransferBuick()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferBuick) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Buick, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferBuick, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferBuick) as List<CarTransferInfo>;
        }

        public List<CarTransferInfo> GetMainCarTransferCitroen()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferCitroen) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Citroen, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferCitroen, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferCitroen) as List<CarTransferInfo>;
        }

        public List<CarTransferInfo> GetMainCarTransferFord()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferFord) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Ford, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferFord, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferFord) as List<CarTransferInfo>;
        }

        public List<CarTransferInfo> GetMainCarTransferHonda()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferHonda) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Honda, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferHonda, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferHonda) as List<CarTransferInfo>;
        }

        public List<CarTransferInfo> GetMainCarTransferToyota()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferToyota) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Toyota, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferToyota, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferToyota) as List<CarTransferInfo>;
        }

        public List<CarTransferInfo> GetMainCarTransferNissan()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferNissan) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Nissan, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferNissan, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferNissan) as List<CarTransferInfo>;
        }

        public List<CarTransferInfo> GetMainCarTransferMINI()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferMINI) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.MINI, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferMINI, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferMINI) as List<CarTransferInfo>;
        }

        public List<CarTransferInfo> GetMainCarTransferMercedesBenz()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferMercedesBenz) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.MercedesBenz, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferMercedesBenz, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferMercedesBenz) as List<CarTransferInfo>;
        }


        public List<CarTransferInfo> GetMainCarTransferPeugeot()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferPeugeot) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Peugeot, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferPeugeot, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferPeugeot) as List<CarTransferInfo>;
        }

        public List<CarTransferInfo> GetMainCarTransferVW()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferVW) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.VW, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferVW, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferVW) as List<CarTransferInfo>;
        }
        public List<CarTransferInfo> GetMainCarTransferVolvo()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferVolvo) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Volvo, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferVolvo, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferVolvo) as List<CarTransferInfo>;
        }
        public List<CarTransferInfo> GetMainCarTransferSecondHandCarOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.CarKey.GetMainCarTransferSecondHandCarOther) == null)
            {
                var list = carTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.SecondHandCarOther, 0, count);
                cacheService.Insert(CacheKey.CarKey.GetMainCarTransferSecondHandCarOther, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.GetMainCarTransferSecondHandCarOther) as List<CarTransferInfo>;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Entity.FxGoods;

namespace FxCacheService.FxGoods
{
    public partial class GoodsCache
    {
        public List<GoodsBuyInfo> GetMainGoodsBuyPhone()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyPhone) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Phone, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyPhone, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyPhone) as List<GoodsBuyInfo>;
        }


        public List<GoodsBuyInfo> GetMainGoodsBuyComputer()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyComputer) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Computer, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyComputer, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyComputer) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyDigitalCamera()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyDigitalCamera) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.DigitalCamera, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyDigitalCamera, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyDigitalCamera) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyComputerAccessories()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyComputerAccessories) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.ComputerAccessories, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyComputerAccessories, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyComputerAccessories) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyPlayStations()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyPlayStations) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.PlayStations, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyPlayStations, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyPlayStations) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyPSAccessories()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyPSAccessories) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.PSAccessories, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyPSAccessories, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyPSAccessories) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyPhoneAccessories()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyPhoneAccessories) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.PhoneAccessories, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyPhoneAccessories, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyPhoneAccessories) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyElectronicsOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyElectronicsOther) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.ElectronicsOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyElectronicsOther, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyElectronicsOther) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyFurniture()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyFurniture) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Furniture, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyFurniture, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyFurniture) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyKitchenAppliances()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyKitchenAppliances) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.KitchenAppliances, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyKitchenAppliances, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyKitchenAppliances) as List<GoodsBuyInfo>;
        }


        public List<GoodsBuyInfo> GetMainGoodsBuyAudioAppliances()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyAudioAppliances) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.AudioAppliances, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyAudioAppliances, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyAudioAppliances) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyKitchenDinningWares()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyKitchenDinningWares) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.KitchenDinningWares, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyKitchenDinningWares, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyKitchenDinningWares) as List<GoodsBuyInfo>;
        }
        public List<GoodsBuyInfo> GetMainGoodsBuyDecoration()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyDecoration) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Decoration, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyDecoration, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyDecoration) as List<GoodsBuyInfo>;
        }


        public List<GoodsBuyInfo> GetMainGoodsBuyOtherElectronics()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyOtherElectronics) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.OtherElectronics, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyOtherElectronics, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyOtherElectronics) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyGymEquipment()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyGymEquipment) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.GymEquipment, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyGymEquipment, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyGymEquipment) as List<GoodsBuyInfo>;
        }


        public List<GoodsBuyInfo> GetMainGoodsBuyBike()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyBike) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Bike, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyBike, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyBike) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyHomeSuppliesOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyHomeSuppliesOther) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.HomeSuppliesOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyHomeSuppliesOther, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyHomeSuppliesOther) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyClothing()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyClothing) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Clothing, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyClothing, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyClothing) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyShoes()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyShoes) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Shoes, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyShoes, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyShoes) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyBag()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyBag) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Bag, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyBag, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyBag) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyAccessories()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyAccessories) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Accessories, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyAccessories, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyAccessories) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyFashionOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyFashionOther) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.FashionOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyFashionOther, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyFashionOther) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyMusicInstruments()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyMusicInstruments) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.MusicInstruments, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyMusicInstruments, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyMusicInstruments) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyBooks()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyBooks) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Books, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyBooks, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyBooks) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyToys()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyToys) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Toys, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyToys, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyToys) as List<GoodsBuyInfo>;
        }


        public List<GoodsBuyInfo> GetMainGoodsBuyStationary()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyStationary) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Stationary, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyStationary, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyStationary) as List<GoodsBuyInfo>;
        }


        public List<GoodsBuyInfo> GetMainGoodsBuyCultureLifeOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyCultureLifeOther) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.CultureLifeOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyCultureLifeOther, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyCultureLifeOther) as List<GoodsBuyInfo>;
        }

        public List<GoodsBuyInfo> GetMainGoodsBuyOtherOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyOtherOther) == null)
            {
                var list = goodsBuySearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.OtherOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsBuyOtherOther, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsBuyOtherOther) as List<GoodsBuyInfo>;
        }
    }
}

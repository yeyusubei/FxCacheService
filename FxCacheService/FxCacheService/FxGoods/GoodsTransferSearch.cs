using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Entity.FxGoods;

namespace FxCacheService.FxGoods
{
    public partial class GoodsCache
    {
        public List<GoodsTransferInfo> GetMainGoodsTransferPhone()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferPhone) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Phone, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferPhone, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferPhone) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferComputer()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferComputer) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Computer, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferComputer, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferComputer) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferDigitalCamera()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferDigitalCamera) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.DigitalCamera, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferDigitalCamera, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferDigitalCamera) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferComputerAccessories()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferComputerAccessories) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.ComputerAccessories, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferComputerAccessories, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferComputerAccessories) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferPlayStations()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferPlayStations) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.PlayStations, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferPlayStations, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferPlayStations) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferPSAccessories()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferPSAccessories) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.PSAccessories, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferPSAccessories, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferPSAccessories) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferPhoneAccessories()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferPhoneAccessories) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.PhoneAccessories, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferPhoneAccessories, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferPhoneAccessories) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferElectronicsOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferElectronicsOther) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.ElectronicsOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferElectronicsOther, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferElectronicsOther) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferFurniture()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferFurniture) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Furniture, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferFurniture, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferFurniture) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferKitchenAppliances()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferKitchenAppliances) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.KitchenAppliances, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferKitchenAppliances, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferKitchenAppliances) as List<GoodsTransferInfo>;
        }


        public List<GoodsTransferInfo> GetMainGoodsTransferAudioAppliances()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferAudioAppliances) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.AudioAppliances, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferAudioAppliances, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferAudioAppliances) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferKitchenDinningWares()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferKitchenDinningWares) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.KitchenDinningWares, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferKitchenDinningWares, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferKitchenDinningWares) as List<GoodsTransferInfo>;
        }
        public List<GoodsTransferInfo> GetMainGoodsTransferDecoration()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferDecoration) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Decoration, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferDecoration, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferDecoration) as List<GoodsTransferInfo>;
        }


        public List<GoodsTransferInfo> GetMainGoodsTransferOtherElectronics()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferOtherElectronics) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.OtherElectronics, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferOtherElectronics, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferOtherElectronics) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferGymEquipment()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferGymEquipment) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.GymEquipment, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferGymEquipment, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferGymEquipment) as List<GoodsTransferInfo>;
        }


        public List<GoodsTransferInfo> GetMainGoodsTransferBike()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferBike) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Bike, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferBike, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferBike) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferHomeSuppliesOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferHomeSuppliesOther) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.HomeSuppliesOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferHomeSuppliesOther, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferHomeSuppliesOther) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferClothing()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferClothing) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Clothing, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferClothing, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferClothing) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferShoes()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferShoes) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Shoes, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferShoes, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferShoes) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferBag()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferBag) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Bag, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferBag, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferBag) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferAccessories()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferAccessories) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Accessories, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferAccessories, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferAccessories) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferFashionOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferFashionOther) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.FashionOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferFashionOther, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferFashionOther) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferMusicInstruments()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferMusicInstruments) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.MusicInstruments, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferMusicInstruments, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferMusicInstruments) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferBooks()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferBooks) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Books, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferBooks, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferBooks) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferToys()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferToys) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Toys, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferToys, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferToys) as List<GoodsTransferInfo>;
        }


        public List<GoodsTransferInfo> GetMainGoodsTransferStationary()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferStationary) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.Stationary, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferStationary, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferStationary) as List<GoodsTransferInfo>;
        }


        public List<GoodsTransferInfo> GetMainGoodsTransferCultureLifeOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferCultureLifeOther) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.CultureLifeOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferCultureLifeOther, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferCultureLifeOther) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetMainGoodsTransferOtherOther()
        {
            int count = 100;
            if (cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferOtherOther) == null)
            {
                var list = goodsTransferSearchService.SearchByCatagroy(Fx.Entity.Catagroy.ChannelListDetailCatagroy.OtherOther, 0, count);
                cacheService.Insert(CacheKey.GoodsKey.GetMainGoodsTransferOtherOther, list, cacheHalfHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GetMainGoodsTransferOtherOther) as List<GoodsTransferInfo>;
        }
    }
}

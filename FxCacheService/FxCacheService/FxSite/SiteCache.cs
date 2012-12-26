using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Fx.Domain.FxSite.IService;
using Fx.Entity.FxSite;

namespace FxCacheService.FxSite
{
    public class SiteCache : BaseCache
    {
        protected ISite site;
        protected IChannelService channel;
        protected ICar car;
        //protected IGoods goods;
        protected IHouse house;
        public SiteCache(ISite site,
            IChannelService channel,
            ICar car,
            IGoods goods,
            IHouse house)
        {
            this.site = site;
            this.channel = channel;
            this.car = car;
            //this.goods = goods;//因goods 采用二级频道 所以使用IChannelService
            this.house = house;
        }

        public List<Area> GetArea()
        {
            if (cacheService.Get(CacheKey.SiteCacheKey.SITE_AREA) == null)
            {
                var areas = site.GetAreaDomain();
                cacheService.Insert(CacheKey.SiteCacheKey.SITE_AREA, areas, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.SiteCacheKey.SITE_AREA) as List<Area>;
        }

        public List<City> GetCity()
        {
            if (cacheService.Get(CacheKey.SiteCacheKey.SITE_CITY) == null)
            {
                var cities = site.GetCities();
                cacheService.Insert(CacheKey.SiteCacheKey.SITE_CITY, cities, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.SiteCacheKey.SITE_CITY) as List<City>;
        }




        /// <summary>
        /// 提供区域的HTML数据 用于转让/求购发布信息页的数据绑定
        /// </summary>
        /// <returns></returns>
        public List<SelectListItem> GetAreaListItems()
        {
            if (cacheService.Get(CacheKey.SiteCacheKey.SITE_AREALISTITEMS) == null)
            {
                var items = new List<SelectListItem>();
                items.Add(new SelectListItem() { Value = "0", Text = "--请选择地区--", Selected = true });
                var list = GetArea();
                list.ForEach(r => items.Add(new SelectListItem() { Value = r.AreaId.ToString(), Text = r.AreaName }));

                cacheService.Insert(CacheKey.SiteCacheKey.SITE_AREALISTITEMS, items, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.SiteCacheKey.SITE_AREALISTITEMS) as List<SelectListItem>;
        }





        public List<ChannelList> GetGoodsChannel()
        {
            if (cacheService.Get(CacheKey.SiteCacheKey.SITE_GOODSCHANNEL) == null)
            {
                var goodsChannel = channel.GetAllChannels().Where(r => r.ChannelId == 1).FirstOrDefault();
                cacheService.Insert(CacheKey.SiteCacheKey.SITE_GOODSCHANNEL, goodsChannel.ChannelLists, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.SiteCacheKey.SITE_GOODSCHANNEL) as List<ChannelList>;

        }

        public List<ChannelListDetail> GetHouseTransferChannel()
        {
            if (cacheService.Get(CacheKey.SiteCacheKey.SITE_HOUSE_TRANSFER_CHANNELLIST) == null)
            {

                var houseChannel1 = house.GetChannelTransferDetail("HouseTransfer", "CommercialProperties");
                var houseChannel2 = house.GetChannelTransferDetail("HouseTransfer", "Properties");
                if (houseChannel1 != null && houseChannel2 != null)
                {
                    houseChannel2.ForEach(r => houseChannel1.Add(r));
                }
                if (houseChannel1 != null)
                {
                    cacheService.Insert(CacheKey.SiteCacheKey.SITE_HOUSE_TRANSFER_CHANNELLIST, houseChannel1, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
                }
                else
                {
                    return new List<ChannelListDetail>();
                }
            }
            return cacheService.Get(CacheKey.SiteCacheKey.SITE_HOUSE_TRANSFER_CHANNELLIST) as List<ChannelListDetail>;

        }

        public List<ChannelListDetail> GetHouseBuyChannel()
        {
            if (cacheService.Get(CacheKey.SiteCacheKey.SITE_HOUSE_BUY_CHANNELLIST) == null)
            {
                var houseChannel1 = house.GetChannelBuyDetail("HouseBuy", "CommercialProperties");
                var houseChannel2 = house.GetChannelBuyDetail("HouseBuy", "Properties");
                if (houseChannel1 != null && houseChannel2 != null)
                {
                    houseChannel2.ForEach(r => houseChannel1.Add(r));
                }
                if (houseChannel1 != null)
                {
                    cacheService.Insert(CacheKey.SiteCacheKey.SITE_HOUSE_BUY_CHANNELLIST, houseChannel1, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
                }
                else
                {
                    return new List<ChannelListDetail>();
                }
            }
            return cacheService.Get(CacheKey.SiteCacheKey.SITE_HOUSE_BUY_CHANNELLIST) as List<ChannelListDetail>;

        }

        public List<ChannelListDetail> GetCarTransferChannel()
        {
            if (cacheService.Get(CacheKey.SiteCacheKey.SITE_CAR_TRANSFER_CHANNELLIST) == null)
            {
                var carChannel = car.GetChannelBuyDetail("CarBuy", "SecondHandCar");
                if (carChannel != null)
                {
                    cacheService.Insert(CacheKey.SiteCacheKey.SITE_CAR_TRANSFER_CHANNELLIST, carChannel, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
                }
                else
                {
                    return new List<ChannelListDetail>();
                }
            }
            return cacheService.Get(CacheKey.SiteCacheKey.SITE_CAR_TRANSFER_CHANNELLIST) as List<ChannelListDetail>;
        }

        public List<ChannelListDetail> GetCarBuyChannel()
        {
            if (cacheService.Get(CacheKey.SiteCacheKey.SITE_CAR_BUY_CHANNELLIST) == null)
            {
                var carChannel = car.GetChannelTransferDetail("CarTransfer", "SecondHandCar");
                if (carChannel != null)
                {
                    cacheService.Insert(CacheKey.SiteCacheKey.SITE_CAR_BUY_CHANNELLIST, carChannel, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
                }
                else
                {
                    return new List<ChannelListDetail>();
                }
            }
            return cacheService.Get(CacheKey.SiteCacheKey.SITE_CAR_BUY_CHANNELLIST) as List<ChannelListDetail>;
        }


    }
}

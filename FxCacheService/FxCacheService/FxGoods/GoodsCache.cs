using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Base.IService;
using Fx.Domain.FxAggregate.IService;
using Fx.Domain.FxGoods;
using Fx.Entity.FxGoods;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxGoods
{
    public class GoodsCache : BaseCache
    {
        protected IHomeSearch<GoodsTransferInfo> homeSearch;
        protected IHomeTopShow homeTopShow;
        protected GoodsListService goodsListService;
        public GoodsCache(IHomeSearch<GoodsTransferInfo> homeSearch,
            IHomeTopShow homeTopShow,
            GoodsListService goodsListService)
        {
            this.homeSearch = homeSearch;
            this.homeTopShow = homeTopShow;
            this.goodsListService = goodsListService;
        }

        public List<GoodsTransferInfo> GetHomeLatest()
        {
            int number = 10;
            if (cacheService.Get(CacheKey.GoodsKey.GOODS_HOME_TRANSFER_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.GoodsExtendKey.GOODS_HOME_TRANSFER_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.GoodsExtendKey.GOODS_HOME_TRANSFER_LATEST_Mark).Minutes > 15)
            {
                var list = homeSearch.SearchLatestForHome(number);
                cacheService.Insert(CacheKey.GoodsKey.GOODS_HOME_TRANSFER_LATEST, list, 15, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.GoodsExtendKey.GOODS_HOME_TRANSFER_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.GoodsKey.GOODS_HOME_TRANSFER_LATEST) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetHomeTopShow()
        {
            if (cacheService.Get(CacheKey.GoodsKey.GOODS_HOME_TOP_SHOW_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.GoodsExtendKey.GOODS_HOME_TOP_SHOW_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.GoodsExtendKey.GOODS_HOME_TOP_SHOW_LATEST_Mark).Minutes > 15)
            {
                var list = homeTopShow.GetHomeGoodsTopShow();
                cacheService.Insert(CacheKey.GoodsKey.GOODS_HOME_TOP_SHOW_LATEST, list, 15, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.GoodsExtendKey.GOODS_HOME_TOP_SHOW_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.GoodsKey.GOODS_HOME_TOP_SHOW_LATEST) as List<GoodsTransferInfo>;
        }


        public List<GoodsTransferInfo> GetGoodsElectronicsList()
        {
            if (cacheService.Get(CacheKey.GoodsKey.GOODSLIST_Electronics) == null)
            {
                var list = goodsListService.Electronics();
                cacheService.Insert(CacheKey.GoodsKey.GOODSLIST_Electronics, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GOODSLIST_Electronics) as List<GoodsTransferInfo>;

        }

        public List<GoodsTransferInfo> GetGoodsHomeSuppliesList()
        {
            if (cacheService.Get(CacheKey.GoodsKey.GOODSLIST_HomeSupplies) == null)
            {
                var list = goodsListService.HomeSupplies();
                cacheService.Insert(CacheKey.GoodsKey.GOODSLIST_HomeSupplies, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GOODSLIST_HomeSupplies) as List<GoodsTransferInfo>;

        }

        public List<GoodsTransferInfo> GetGoodsFashionList()
        {
            if (cacheService.Get(CacheKey.GoodsKey.GOODSLIST_Fashion) == null)
            {
                var list = goodsListService.Fashion();
                cacheService.Insert(CacheKey.GoodsKey.GOODSLIST_Fashion, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GOODSLIST_Fashion) as List<GoodsTransferInfo>;

        }

        public List<GoodsTransferInfo> GetGoodsCultureLifeList()
        {
            if (cacheService.Get(CacheKey.GoodsKey.GOODSLIST_CultureLife) == null)
            {
                var list = goodsListService.CultureLife();
                cacheService.Insert(CacheKey.GoodsKey.GOODSLIST_CultureLife, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GOODSLIST_CultureLife) as List<GoodsTransferInfo>;

        }

        public List<GoodsTransferInfo> GetGoodsOtherList()
        {
            if (cacheService.Get(CacheKey.GoodsKey.GOODSLIST_Other) == null)
            {
                var list = goodsListService.Other();
                cacheService.Insert(CacheKey.GoodsKey.GOODSLIST_Other, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.GoodsKey.GOODSLIST_Other) as List<GoodsTransferInfo>;

        }



    }
}

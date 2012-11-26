using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Base.IService;
using Fx.Domain.FxAggregate.IService;
using Fx.Entity.FxGoods;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxGoods
{
    public class GoodsCache:BaseCache
    {
        protected IHomeSearch<GoodsTransferInfo> homeSearch;
        protected IHomeTopShow homeTopShow;
        public GoodsCache(IHomeSearch<GoodsTransferInfo> homeSearch,
            IHomeTopShow homeTopShow)
        {
            this.homeSearch = homeSearch;
            this.homeTopShow = homeTopShow;
        }

        public List<GoodsTransferInfo> GetHomeLatest()
        {
            int number = 10;
            if (cacheService.Get(CacheKey.GoodsKey.GOODS_HOME_TRANSFER_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.GoodsExtendKey.GOODS_HOME_TRANSFER_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.GoodsExtendKey.GOODS_HOME_TRANSFER_LATEST_Mark).Minutes > 30)
            {
                var list = homeSearch.SearchLatestForHome(number);
                cacheService.Insert(CacheKey.GoodsKey.GOODS_HOME_TRANSFER_LATEST, list, 30, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.GoodsExtendKey.GOODS_HOME_TRANSFER_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.GoodsKey.GOODS_HOME_TRANSFER_LATEST) as List<GoodsTransferInfo>;
        }

        public List<GoodsTransferInfo> GetHomeTopShow()
        {
            if (cacheService.Get(CacheKey.GoodsKey.GOODS_HOME_TOP_SHOW_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.GoodsExtendKey.GOODS_HOME_TOP_SHOW_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.GoodsExtendKey.GOODS_HOME_TOP_SHOW_LATEST_Mark).Minutes > 30)
            {
                var list = homeTopShow.GetHomeGoodsTopShow();
                cacheService.Insert(CacheKey.GoodsKey.GOODS_HOME_TOP_SHOW_LATEST, list, 30, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.GoodsExtendKey.GOODS_HOME_TOP_SHOW_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.GoodsKey.GOODS_HOME_TOP_SHOW_LATEST) as List<GoodsTransferInfo>; 
        }
    }
}

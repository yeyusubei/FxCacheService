using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Base.IService;
using Fx.Entity.FxGoods;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxGoods
{
    public class GoodsCache:BaseCache
    {
        IHomeSearch<GoodsTransferInfo> homeSearch;
        public GoodsCache(IHomeSearch<GoodsTransferInfo> homeSearch)
        {
            this.homeSearch = homeSearch;
        }

        public List<GoodsTransferInfo> GetHomeLatest()
        {
            int number = 5;
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
    }
}

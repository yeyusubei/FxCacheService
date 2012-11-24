using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Base.IService;
using Fx.Entity.FxCar;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxCar
{
    public class CarCache:BaseCache
    {
        IHomeSearch<CarTransferInfo> homeSearch;
        public CarCache(IHomeSearch<CarTransferInfo> homeSearch)
        {
            this.homeSearch = homeSearch;
        }

        public List<CarTransferInfo> GetHomeLatest()
        {
            int number = 5;
            if (cacheService.Get(CacheKey.CarKey.CAR_HOME_TRANSFER_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.CarExtendKey.CAR_HOME_TRANSFER_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.CarExtendKey.CAR_HOME_TRANSFER_LATEST_Mark).Minutes > 30)
            {
                var list = homeSearch.SearchLatestForHome(number);
                cacheService.Insert(CacheKey.CarKey.CAR_HOME_TRANSFER_LATEST, list, 30, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.CarExtendKey.CAR_HOME_TRANSFER_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.CarKey.CAR_HOME_TRANSFER_LATEST) as List<CarTransferInfo>;
        }
    }
}

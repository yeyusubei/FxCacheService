using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Base.IService;
using Fx.Domain.FxAggregate.IService;
using Fx.Domain.FxCar;
using Fx.Entity.FxCar;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxCar
{
    public class CarCache:BaseCache
    {
        protected IHomeSearch<CarTransferInfo> homeSearch;
        protected IHomeTopShow homeTopShow;
        public CarCache(IHomeSearch<CarTransferInfo> homeSearch,
            IHomeTopShow homeTopShow)
        {
            this.homeSearch = homeSearch;
            this.homeTopShow = homeTopShow;
        }
        protected CarListService carListService;
        public CarCache(IHomeSearch<CarTransferInfo> homeSearch,
            IHomeTopShow homeTopShow,
            CarListService carListService)
        {
            this.homeSearch = homeSearch;
            this.homeTopShow = homeTopShow;
            this.carListService = carListService;
        }

        public List<CarTransferInfo> GetHomeLatest()
        {
            int number = 10;
            if (cacheService.Get(CacheKey.CarKey.CAR_HOME_TRANSFER_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.CarExtendKey.CAR_HOME_TRANSFER_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.CarExtendKey.CAR_HOME_TRANSFER_LATEST_Mark).Minutes > 15)
            {
                var list = homeSearch.SearchLatestForHome(number);
                cacheService.Insert(CacheKey.CarKey.CAR_HOME_TRANSFER_LATEST, list, 15, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.CarExtendKey.CAR_HOME_TRANSFER_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.CarKey.CAR_HOME_TRANSFER_LATEST) as List<CarTransferInfo>;
        }


        public List<CarTransferInfo> GetHomeTopShow()
        {
            if (cacheService.Get(CacheKey.CarKey.CAR_HOME_TOP_SHOW_LATEST) == null ||
                DateTime.Now.Subtract(CacheKey.CarExtendKey.CAR_HOME_TOP_SHOW_LATEST_Mark).Hours > 0 ||
                DateTime.Now.Subtract(CacheKey.CarExtendKey.CAR_HOME_TOP_SHOW_LATEST_Mark).Minutes > 30)
            {
                var list = homeTopShow.GetHomeCarTopShow();
                cacheService.Insert(CacheKey.CarKey.CAR_HOME_TOP_SHOW_LATEST, list, 15, System.Web.Caching.CacheItemPriority.Normal);
                CacheKey.CarExtendKey.CAR_HOME_TOP_SHOW_LATEST_Mark = DateTime.Now;
            }
            return cacheService.Get(CacheKey.CarKey.CAR_HOME_TOP_SHOW_LATEST) as List<CarTransferInfo>;
        }


        public List<CarTransferInfo> GetCarSecondHandCarList()
        {
            if (cacheService.Get(CacheKey.CarKey.CARLIST_SecondHandCar) == null)
            {
                var list = carListService.GetSecondHandCar();
                cacheService.Insert(CacheKey.CarKey.CARLIST_SecondHandCar, list, 30, System.Web.Caching.CacheItemPriority.Normal);
            }
            return cacheService.Get(CacheKey.CarKey.CARLIST_SecondHandCar) as List<CarTransferInfo>;
        }

    }
}

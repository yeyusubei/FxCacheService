﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fx.Domain.Account.IService;
using Fx.Domain.FxAggregate.IService;
using Fx.Domain.FxCar.IService;
using Fx.Domain.FxGoods.IService;
using Fx.Domain.FxHouse.IService;
using Fx.Infrastructure.Caching;

namespace FxCacheService.FxSite
{
    public class GlobalCache : BaseCache
    {
        protected IAccountService accountService;
        protected IDbAll dbAllService;
        IGlobalCacheCar carGlobalCache;
        IGlobalCacheGoods goodsGlobalCache;
        IGolbalCacheHouse houseGlobalCache;
        public GlobalCache(IAccountService accountService,
            IDbAll dbAllService,
            IGlobalCacheCar carGlobalCache,
            IGlobalCacheGoods goodsGlobalCache,
            IGolbalCacheHouse houseGlobalCache)
        {
            this.accountService = accountService;
            this.dbAllService = dbAllService;
            this.carGlobalCache = carGlobalCache;
            this.goodsGlobalCache = goodsGlobalCache;
            this.houseGlobalCache = houseGlobalCache;
        }

        /// <summary>
        /// 获取当前的用户数量
        /// </summary>
        /// <returns></returns>
        public int UserCount()
        {
            if (cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_USER_COUNT) == null)
            {
                int count = accountService.GetUserCount();
                cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_USER_COUNT, count, cacheOneHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return Convert.ToInt32(cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_USER_COUNT));
        }

        /// <summary>
        /// 当前用户数量+1
        /// </summary>
        public void UserCountAdd(Action clearEvent = null)
        {
            int count;
            if (DateTime.Today.ToString("yyMMdd").Equals(CacheKey.GlabalExtendKey.GLOBAL_USER_COUNT_Mark,
                StringComparison.CurrentCultureIgnoreCase))
            {
                count = UserCount() + 1;
                if (clearEvent != null)
                {
                    clearEvent();
                }
            }
            else
            {
                CacheKey.GlabalExtendKey.GLOBAL_USER_COUNT_Mark = DateTime.Today.ToString("yyMMdd");
                count = 1;
            }
            cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_USER_COUNT, count, cacheOneHour, System.Web.Caching.CacheItemPriority.NotRemovable);
        }

        /// <summary>
        /// 获取当日注册用户数量
        /// </summary>
        /// <returns></returns>
        public int UserTodayCount()
        {
            if (cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_USER_TODAY_ADD) == null)
            {
                int count = 0;
                cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_USER_TODAY_ADD, count, cacheOneHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return Convert.ToInt32(cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_USER_TODAY_ADD));
        }

        /// <summary>
        /// 当日注册用户数量+1 超过当日 移除之前的数据
        /// </summary>
        public void UserTodayCountAdd(Action clearEvent = null)
        {
            int count;
            if (DateTime.Today.ToString("yyMMdd").Equals(CacheKey.GlabalExtendKey.GLOBAL_USER_TODAY_ADD_Mark,
                StringComparison.CurrentCultureIgnoreCase))
            {
                count = UserTodayCount() + 1;
                if (clearEvent != null)
                {
                    clearEvent();
                }
            }
            else
            {
                count = 1;
                CacheKey.GlabalExtendKey.GLOBAL_USER_TODAY_ADD_Mark = DateTime.Today.ToString("yyMMdd");
            }
            cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_USER_TODAY_ADD, count, cacheOneHour, System.Web.Caching.CacheItemPriority.Normal);
        }






        /// <summary>
        /// 获取信息总发布量
        /// </summary>
        /// <returns></returns>
        public int InfoPublishAllCount()
        {
            if (cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_INFO_PUBLISH_ALL_COUNT) == null)
            {
                int count = carGlobalCache.InfoCount() + goodsGlobalCache.InfoCount() + houseGlobalCache.InfoCount();
                cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_INFO_PUBLISH_ALL_COUNT, count, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
            }
            return Convert.ToInt32(cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_INFO_PUBLISH_ALL_COUNT));
        }

        /// <summary>
        /// 当前信息总发布量+1
        /// </summary>
        public void InfoPublishAllCountAdd(Action clearEvent = null)
        {
            int count;
            if (DateTime.Today.ToString("yyMMdd").Equals(CacheKey.GlabalExtendKey.GLOBAL_INFO_PUBLISH_ALL_COUNT_Mark,
               StringComparison.CurrentCultureIgnoreCase))
            {
                count = InfoPublishAllCount() + 1;
                cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_INFO_PUBLISH_ALL_COUNT, count, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
                if (clearEvent != null)
                {
                    clearEvent();
                }
            }
            else
            {
                count = 1;
                CacheKey.GlabalExtendKey.GLOBAL_INFO_PUBLISH_ALL_COUNT_Mark = DateTime.Today.ToString("yyMMdd");
            }
        }

        /// <summary>
        /// 获取当日发布信息数量
        /// </summary>
        /// <returns></returns>
        public int InfoPublishTodayCount()
        {
            int count;
            if (cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_INFO_PUBLISH_TODAY_COUNT) == null)
            {
                count = 0;
                cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_INFO_PUBLISH_TODAY_COUNT, count, cacheOneDay, System.Web.Caching.CacheItemPriority.Normal);
            }
            return Convert.ToInt32(cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_INFO_PUBLISH_TODAY_COUNT)) + 1;
        }

        /// <summary>
        /// 当日发布信息数量+1 超过当日 移除之前的数据
        /// </summary>
        public void InfoPublishTodayAdd(Action clearEvent = null)
        {
            int count;
            if (DateTime.Today.ToString("yyMMdd").Equals(CacheKey.GlabalExtendKey.GLOBAL_INFO_PUBLISH_TODAY_COUNT_Mark,
                StringComparison.CurrentCultureIgnoreCase))
            {
                count = InfoPublishTodayCount() + 1;
                if (clearEvent != null)
                {
                    clearEvent();
                }
            }
            else
            {
                count = 1;
                CacheKey.GlabalExtendKey.GLOBAL_INFO_PUBLISH_TODAY_COUNT_Mark = DateTime.Today.ToString("yyMMdd");
            }
            cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_INFO_PUBLISH_TODAY_COUNT, count, cacheOneHour, System.Web.Caching.CacheItemPriority.Normal);
        }







        /// <summary>
        /// 当日信息成交量
        /// </summary>
        /// <returns></returns>
        public int InfoEndCount()
        {
            if (cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_INFO_END_COUNT) == null)
            {
                int count = 0;
                cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_INFO_END_COUNT, count, 24 * cacheOneHour, System.Web.Caching.CacheItemPriority.Normal);
            }
            return Convert.ToInt32(cacheService.Get(CacheKey.GlobalCacheKey.GLOBAL_INFO_END_COUNT)) + 1;
        }

        /// <summary>
        /// 当日信息成交量+1
        /// </summary>
        /// <param name="clearEvent"></param>
        public void InfoEndCountAdd(Action clearEvent = null)
        {
            int count;
            if (DateTime.Today.ToString("yyMMdd").Equals(CacheKey.GlabalExtendKey.GLOBAL_INFO_END_COUNT_Mark,
                StringComparison.CurrentCultureIgnoreCase))
            {
                count = InfoEndCount() + 1;
                if (clearEvent != null)
                {
                    clearEvent();
                }
            }
            else
            {
                count = 1;
                CacheKey.GlabalExtendKey.GLOBAL_INFO_END_COUNT_Mark = DateTime.Today.ToString("yyMMdd");
            }
            cacheService.Insert(CacheKey.GlobalCacheKey.GLOBAL_INFO_END_COUNT, count, cacheOneHour, System.Web.Caching.CacheItemPriority.Normal);
        }


        /// <summary>
        /// 站内信  缓存要短点 20分钟吧
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public int PrivateMessageCount(string email)
        {
            return 0;
        }


        public int PrivateMessageCountAdd(string email)
        {
            return 0;
        }


        /// <summary>
        /// 站内信  缓存要短点 20分钟吧
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public int PrivateMessageTodayCount(string email)
        {
            return 0;
        }


        public int PrivateMessageTodayCountAdd(string email)
        {
            return 0;
        }


    }
}

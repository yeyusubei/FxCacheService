using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FxCacheService
{
    /// <summary>
    /// 缓存Key
    /// </summary>
    public class CacheKey
    {
        public static class GlobalCacheKey
        {
            #region Global
            /// <summary>
            /// 站点全局缓存 会员总数量
            /// </summary>
            public static readonly string GLOBAL_USER_COUNT = "FXCACHE_SITE_GLOBAL_USER_COUNT";

            /// <summary>
            /// 站点全局缓存 当日新增会员数量
            /// </summary>
            public static readonly string GLOBAL_USER_TODAY_ADD = "FXCACHE_SITE_GLOBAL_TODAY_ADD_COUNT";

            /// <summary>
            /// 站点全局缓存 信息总发布量
            /// </summary>
            public static readonly string GLOBAL_INFO_PUBLISH_ALL_COUNT = "FXCACHE_SITE_GLOBAL_INFO_PUBLISH_THREE_MONTH_COUNT";

            /// <summary>
            /// 站点全局缓存 当日信息发布量
            /// </summary>
            public static readonly string GLOBAL_INFO_PUBLISH_TODAY_COUNT = "FXCACHE_SITE_GLOBAL_INFO_PUBLISH_TODAY_COUNT";


            /// <summary>
            /// 站点全局缓存 当日信息成交量
            /// </summary>
            public static readonly string GLOBAL_INFO_END_COUNT = "FXCACHE_SITE_GLOBAL_INFO_END_COUNT";

            /// <summary>
            /// 站点全局缓存 用户私信数量
            /// </summary>
            public static readonly string GLOBAL_USER_PRIVATE_MESSAGE_COUNT = "FXCACHE_SITE_USER_PRIVATE_MESSAGE_COUNT";

            /// <summary>
            /// 站点全局缓存 当日新私信数量
            /// </summary>
            public static readonly string GLOBAL_USER_PRIVATE_TODAY_MESSAGE_COUNT = "FXCACHE_SITE_USER_PRIVATE_TODAY_MESSAGE_COUNT";
            #endregion
        }

        public static class GlabalExtendKey
        {
            public static string GLOBAL_USER_COUNT_Mark = DateTime.Today.ToString("yyMMdd");

            public static string GLOBAL_USER_TODAY_ADD_Mark = DateTime.Today.ToString("yyMMdd");

            public static string GLOBAL_INFO_PUBLISH_ALL_COUNT_Mark = DateTime.Today.ToString("yyMMdd");

            public static string GLOBAL_INFO_PUBLISH_TODAY_COUNT_Mark = DateTime.Today.ToString("yyMMdd");

            public static string GLOBAL_INFO_END_COUNT_Mark = DateTime.Today.ToString("yyMMdd");
        }


        public static class GoodsKey
        {
            /// <summary>
            /// 首页最新发布二手
            /// </summary>
            public static string GOODS_HOME_TRANSFER_LATEST = "FXCACHE_GOODS_HOME_TRANSFER_LATEST";

        }

        public static class GoodsExtendKey
        {
            public static DateTime GOODS_HOME_TRANSFER_LATEST_Mark = DateTime.Now;
        }


        public static class CarKey
        {
            /// <summary>
            /// 首页最新发布汽车
            /// </summary>
            public static string CAR_HOME_TRANSFER_LATEST = "FXCACHE_CAR_HOME_TRANSFER_LATEST";
        }

        public static class CarExtendKey
        {
            public static DateTime CAR_HOME_TRANSFER_LATEST_Mark = DateTime.Now;
        }

        public static class HouseKey
        {
            /// <summary>
            /// 首页最新发布房屋
            /// </summary>
            public static string HOUSE_HOME_TRANSFER_LATEST = "FXCACHE_HOUSE_HOME_TRANSFER_LATEST";
        }

        public static class HouseExtendKey
        {
            public static DateTime HOUSE_HOME_TRANSFER_LATEST_Mark = DateTime.Now;
        }
    }
}

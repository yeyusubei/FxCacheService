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
        public static class SiteCacheKey
        {
            public static string SITE_AREA = "FXCACHE_SITE_AREA";
            public static string SITE_GOODSCHANNEL = "FXCACHE_SITE_GOODSCHANNEL";

            public static string SITE_CAR_TRANSFER_CHANNELLIST = "FXCACHE_SITE_CAR_TRANSFER_CHANNELLIST";
            public static string SITE_CAR_BUY_CHANNELLIST = "FXCACHE_SITE_CAR_BUY_CHANNELLIST";

            public static string SITE_HOUSE_TRANSFER_CHANNELLIST = "FXCACHE_SITE_HOUSE_TRANSFER_CHANNELLIST";
            public static string SITE_HOUSE_BUY_CHANNELLIST = "FXCACHE_SITE_HOUSE_BUY_CHANNELLIST";
        }


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

            /// <summary>
            /// 首页最新发布的置顶
            /// </summary>
            public static string GOODS_HOME_TOP_SHOW_LATEST = "FXCACHE_GOODS_HOME_TOP_SHOW_LATEST";






            public static string GOODSLIST_Electronics = "FXCACHE_GOODSLIST_Electronics";
            public static string GOODSLIST_HomeSupplies = "FXCACHE_GOODSLIST_HomeSupplies";
            public static string GOODSLIST_Fashion = "FXCACHE_GOODSLIST_Fashion";
            public static string GOODSLIST_CultureLife = "FXCACHE_GOODSLIST_CultureLife";
            public static string GOODSLIST_Other = "FXCACHE_GOODSLIST_Other";

            public static string GOODS_TRANSFER_TOPSHOW = "FXCACHE_GOODS_TRANSFER_TOPSHOW";
            public static string GOODS_BUY_TOPSHOW = "FXCACHE_GOODS_BUY_TOPSHOW";

            public static string GOODS_BUY_GetMainGoodsALL = "FXCACHE_GOODS_BUY_GetMainGoodsALL";
            public static string GOODS_BUY_GetMainGoodsOnlyChangeGoods = "FXCACHE_GOODS_BUY_GetMainGoodsOnlyChangeGoods";
            public static string GOODS_BUY_GetMainGoodsOnlyPrice = "FXCACHE_GOODS_BUY_GetMainGoodsOnlyPrice";
            public static string GOODS_TRANSFER_GetMainGoodsALL = "FXCACHE_GOODS_TRANSFER_GetMainGoodsALL";
            public static string GOODS_TRANSFER_GetMainGoodsOnlyChangeGoods = "FXCACHE_GOODS_TRANSFER_GetMainGoodsOnlyChangeGoods";
            public static string GOODS_TRANSFER_GetMainGoodsOnlyPrice = "FXCACHE_GOODS_TRANSFER_GetMainGoodsOnlyPrice";

            //GetMainGoodsBuy 
            //SEARCH
            public static string GetMainGoodsBuyPhone = "FXCACHE_GetMainGoodsBuyPhone";
            public static string GetMainGoodsBuyComputer = "FXCACHE_GetMainGoodsBuyComputer";
            public static string GetMainGoodsBuyDigitalCamera = "FXCACHE_GetMainGoodsBuyDigitalCamera";
            public static string GetMainGoodsBuyComputerAccessories = "FXCACHE_GetMainGoodsBuyComputerAccessories";
            public static string GetMainGoodsBuyPlayStations = "FXCACHE_GetMainGoodsBuyPlayStations";
            public static string GetMainGoodsBuyPSAccessories = "FXCACHE_GetMainGoodsBuyPSAccessories";
            public static string GetMainGoodsBuyPhoneAccessories = "FXCACHE_GetMainGoodsBuyPhoneAccessories";
            public static string GetMainGoodsBuyElectronicsOther = "FXCACHE_GetMainGoodsBuyElectronicsOther";
            public static string GetMainGoodsBuyFurniture = "FXCACHE_GetMainGoodsBuyFurniture";
            public static string GetMainGoodsBuyKitchenAppliances = "FXCACHE_GetMainGoodsBuyKitchenAppliances";
            public static string GetMainGoodsBuyAudioAppliances = "FXCACHE_GetMainGoodsBuyAudioAppliances";
            public static string GetMainGoodsBuyKitchenDinningWares = "FXCACHE_GetMainGoodsBuyKitchenDinningWares";
            public static string GetMainGoodsBuyDecoration = "FXCACHE_GetMainGoodsBuyDecoration";
            public static string GetMainGoodsBuyOtherElectronics = "FXCACHE_GetMainGoodsBuyOtherElectronics";
            public static string GetMainGoodsBuyGymEquipment = "FXCACHE_GetMainGoodsBuyGymEquipment";
            public static string GetMainGoodsBuyBike = "FXCACHE_GetMainGoodsBuyBike";
            public static string GetMainGoodsBuyHomeSuppliesOther = "FXCACHE_GetMainGoodsBuyHomeSuppliesOther";
            public static string GetMainGoodsBuyClothing = "FXCACHE_GetMainGoodsBuyClothing";
            public static string GetMainGoodsBuyShoes = "FXCACHE_GetMainGoodsBuyShoes";
            public static string GetMainGoodsBuyBag = "FXCACHE_GetMainGoodsBuyBag";
            public static string GetMainGoodsBuyAccessories = "FXCACHE_GetMainGoodsBuyAccessories";
            public static string GetMainGoodsBuyFashionOther = "FXCACHEGetMainGoodsBuyFashionOther_";
            public static string GetMainGoodsBuyMusicInstruments = "FXCACHE_GetMainGoodsBuyMusicInstruments";
            public static string GetMainGoodsBuyBooks = "FXCACHE_GetMainGoodsBuyBooks";
            public static string GetMainGoodsBuyToys = "FXCACHE_GetMainGoodsBuyToys";
            public static string GetMainGoodsBuyStationary = "FXCACHE_GetMainGoodsBuyStationary";
            public static string GetMainGoodsBuyCultureLifeOther = "FXCACHE_GetMainGoodsBuyCultureLifeOther";
            public static string GetMainGoodsBuyOtherOther = "FXCACHE_GetMainGoodsBuyOtherOther";


            public static string GetMainGoodsTransferPhone = "FXCACHE_GetMainGoodsTransferPhone";
            public static string GetMainGoodsTransferComputer = "FXCACHE_GetMainGoodsTransferComputer";
            public static string GetMainGoodsTransferDigitalCamera = "FXCACHE_GetMainGoodsTransferDigitalCamera";
            public static string GetMainGoodsTransferComputerAccessories = "FXCACHE_GetMainGoodsTransferComputerAccessories";
            public static string GetMainGoodsTransferPlayStations = "FXCACHE_GetMainGoodsTransferPlayStations";
            public static string GetMainGoodsTransferPSAccessories = "FXCACHE_GetMainGoodsTransferPSAccessories";
            public static string GetMainGoodsTransferPhoneAccessories = "FXCACHE_GetMainGoodsTransferPhoneAccessories";
            public static string GetMainGoodsTransferElectronicsOther = "FXCACHE_GetMainGoodsTransferElectronicsOther";
            public static string GetMainGoodsTransferFurniture = "FXCACHE_GetMainGoodsTransferFurniture";
            public static string GetMainGoodsTransferKitchenAppliances = "FXCACHE_GetMainGoodsTransferKitchenAppliances";
            public static string GetMainGoodsTransferAudioAppliances = "FXCACHE_GetMainGoodsTransferAudioAppliances";
            public static string GetMainGoodsTransferKitchenDinningWares = "FXCACHE_GetMainGoodsTransferKitchenDinningWares";
            public static string GetMainGoodsTransferDecoration = "FXCACHE_GetMainGoodsTransferDecoration";
            public static string GetMainGoodsTransferOtherElectronics = "FXCACHE_GetMainGoodsTransferOtherElectronics";
            public static string GetMainGoodsTransferGymEquipment = "FXCACHE_GetMainGoodsTransferGymEquipment";
            public static string GetMainGoodsTransferBike = "FXCACHE_GetMainGoodsTransferBike";
            public static string GetMainGoodsTransferHomeSuppliesOther = "FXCACHE_GetMainGoodsTransferHomeSuppliesOther";
            public static string GetMainGoodsTransferClothing = "FXCACHE_GetMainGoodsTransferClothing";
            public static string GetMainGoodsTransferShoes = "FXCACHE_GetMainGoodsTransferShoes";
            public static string GetMainGoodsTransferBag = "FXCACHE_GetMainGoodsTransferBag";
            public static string GetMainGoodsTransferAccessories = "FXCACHE_GetMainGoodsTransferAccessories";
            public static string GetMainGoodsTransferFashionOther = "FXCACHE_GetMainGoodsTransferFashionOther";
            public static string GetMainGoodsTransferMusicInstruments = "FXCACHE_GetMainGoodsTransferMusicInstruments";
            public static string GetMainGoodsTransferBooks = "FXCACHE_GetMainGoodsTransferBooks";
            public static string GetMainGoodsTransferToys = "FXCACHE_GetMainGoodsTransferToys";
            public static string GetMainGoodsTransferStationary = "FXCACHE_GetMainGoodsTransferStationary";
            public static string GetMainGoodsTransferCultureLifeOther = "FXCACHE_GetMainGoodsTransferCultureLifeOther";
            public static string GetMainGoodsTransferOtherOther = "FXCACHE_GetMainGoodsTransferOtherOther";

        }

        public static class CarKey
        {
            /// <summary>
            /// 首页最新发布汽车
            /// </summary>
            public static string CAR_HOME_TRANSFER_LATEST = "FXCACHE_CAR_HOME_TRANSFER_LATEST";

            /// <summary>
            /// 首页最新发布的置顶
            /// </summary>
            public static string CAR_HOME_TOP_SHOW_LATEST = "FXCACHE_CAR_HOME_TOP_SHOW_LATEST";



            public static string CARLIST_SecondHandCar = "FXCACHE_CARLIST_SecondHandCar";

            public static string CAR_TRANSFER_TOPSHOW = "FXCACHE_CAR_TRANSFER_TOPSHOW";
            public static string CAR_BUY_TOPSHOW = "FXCACHE_CAR_BUY_TOPSHOW";

            public static string CAR_BUY_GetMainCARALL = "FXCACHE_CAR_BUY_GetMainCARALL";
            public static string CAR_TRANSFER_GetMainCARALL = "FXCACHE_CAR_TRANSFER_GetMainCARALL";



            //Search
            public static string GetMainCarBuyAudi = "FXCACHE_GetMainCarBuyAudi";
            public static string GetMainCarBuyBMW = "FXCACHE_GetMainCarBuyBMW";
            public static string GetMainCarBuyBuick = "FXCACHE_GetMainCarBuyBuick";
            public static string GetMainCarBuyCitroen = "FXCACHE_GetMainCarBuyCitroen";
            public static string GetMainCarBuyFord = "FXCACHE_GetMainCarBuyFord";
            public static string GetMainCarBuyHonda = "FXCACHE_GetMainCarBuyHonda";
            public static string GetMainCarBuyToyota = "FXCACHE_GetMainCarBuyToyota";
            public static string GetMainCarBuyNissan = "FXCACHE_GetMainCarBuyNissan";
            public static string GetMainCarBuyMINI = "FXCACHE_GetMainCarBuyMINI";
            public static string GetMainCarBuyMercedesBenz = "FXCACHE_GetMainCarBuyMercedesBenz";
            public static string GetMainCarBuyPeugeot = "FXCACHE_GetMainCarBuyPeugeot";
            public static string GetMainCarBuyVW = "FXCACHE_GetMainCarBuyVW";
            public static string GetMainCarBuyVolvo = "FXCACHE_GetMainCarBuyVolvo";
            public static string GetMainCarBuySecondHandCarOther = "FXCACHE_GetMainCarBuySecondHandCarOther";


            public static string GetMainCarTransferAudi = "FXCACHE_GetMainCarTransferAudi";
            public static string GetMainCarTransferBMW = "FXCACHE_GetMainCarTransferBMW";
            public static string GetMainCarTransferBuick = "FXCACHE_GetMainCarTransferBuick";
            public static string GetMainCarTransferCitroen = "FXCACHE_GetMainCarTransferCitroen";
            public static string GetMainCarTransferFord = "FXCACHE_GetMainCarTransferFord";
            public static string GetMainCarTransferHonda = "FXCACHE_GetMainCarTransferHonda";
            public static string GetMainCarTransferToyota = "FXCACHE_GetMainCarTransferToyota";
            public static string GetMainCarTransferNissan = "FXCACHE_GetMainCarTransferNissan";
            public static string GetMainCarTransferMINI = "FXCACHE_GetMainCarTransferMINI";
            public static string GetMainCarTransferMercedesBenz = "FXCACHE_GetMainCarTransferMercedesBenz";
            public static string GetMainCarTransferPeugeot = "FXCACHE_GetMainCarTransferPeugeot";
            public static string GetMainCarTransferVW = "FXCACHE_GetMainCarTransferVW";
            public static string GetMainCarTransferVolvo = "FXCACHE_GetMainCarTransferVolvo";
            public static string GetMainCarTransferSecondHandCarOther = "FXCACHE_GetMainCarTransferSecondHandCarOther";

        }

        public static class HouseKey
        {
            /// <summary>
            /// 首页最新发布房屋
            /// </summary>
            public static string HOUSE_HOME_TRANSFER_LATEST = "FXCACHE_HOUSE_HOME_TRANSFER_LATEST";

            /// <summary>
            /// 首页最新发布的置顶
            /// </summary>
            public static string HOUSE_HOME_TOP_SHOW_LATEST = "FXCACHE_HOUSE _HOME_TOP_SHOW_LATEST";




            public static string HOUSELIST_CommercialProperties = "FXCACHE_HOUSELIST_CommercialProperties";
            public static string HOUSELIST_Properties = "FXCACHE_HOUSELIST_Properties";

            public static string HOUSE_TRANSFER_TOPSHOW = "FXCACHE_HOUSE_TRANSFER_TOPSHOW";
            public static string HOUSE_BUY_TOPSHOW = "FXCACHE_HOUSE_BUY_TOPSHOW";

            public static string HOUSE_BUY_GetMainHouseALL = "FXCACHE_HOUSE_BUY_GetMainHouseALL";
            public static string HOUSE_TRANSFER_GetMainHouseALL = "FXCACHE_HOUSE_TRANSFER_GetMainHouseALL";


            //SEARCH GetMainHouseBuy
            public static string GetMainHouseBuyShop = "FXCACHE_GetMainHouseBuyShop";
            public static string GetMainHouseBuyRestaurants = "FXCACHE_GetMainHouseBuyRestaurants";
            public static string GetMainHouseBuyWarehouse = "FXCACHE_GetMainHouseBuyWarehouse";
            public static string GetMainHouseBuyOffice = "FXCACHE_GetMainHouseBuyOffice";
            public static string GetMainHouseBuyHouse = "FXCACHE_GetMainHouseBuyHouse";
            public static string GetMainHouseBuyFlat = "FXCACHE_GetMainHouseBuyFlat";
            public static string GetMainHouseBuyStudentAparment = "FXCACHE_GetMainHouseBuyStudentAparment";


            public static string GetMainHouseTransferShop = "FXCACHE_GetMainHouseTransferShop";
            public static string GetMainHouseTransferRestaurants = "FXCACHE_GetMainHouseTransferRestaurants";
            public static string GetMainHouseTransferWarehouse = "FXCACHE_GetMainHouseTransferWarehouse";
            public static string GetMainHouseTransferOffice = "FXCACHE_GetMainHouseTransferOffice";
            public static string GetMainHouseTransferHouse = "FXCACHE_GetMainHouseTransferHouse";
            public static string GetMainHouseTransferFlat = "FXCACHE_GetMainHouseTransferFlat";
            public static string GetMainHouseTransferStudentAparment = "FXCACHE_GetMainHouseTransferStudentAparment";

        }
    }
}

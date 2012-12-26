
namespace FxInformationJob.Tests
{
    using System.Reflection; 
    using SimpleInjector;

    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new SimpleInjector.Container();

            InitializeContainer(container);

            //container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            //container.RegisterMvcAttributeFilterProvider();

            // Using Entity Framework? Please read this: http://simpleinjector.codeplex.com/discussions/363935
            container.Verify();

            //DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

           
        }

        private static void InitializeContainer(Container container)
        {
            InitSiteContainer(container);   
        }


        private static void InitSiteContainer(Container container)
        {
            container.Register<Fx.Domain.Account.IService.IAccountService, Fx.Domain.Account.UserAccountService>();
            container.Register<Fx.Domain.FxSite.IService.IChannelService, Fx.Domain.FxSite.ChannelService>();
            container.Register<Fx.Domain.FxSite.IService.ISite, Fx.Domain.FxSite.SiteService>();

            container.Register<Fx.Domain.FxSite.IService.IGoods, Fx.Domain.FxSite.GoodsService>();
            container.Register<Fx.Domain.FxSite.IService.ICar, Fx.Domain.FxSite.CarService>();
            container.Register<Fx.Domain.FxSite.IService.IHouse, Fx.Domain.FxSite.HouseService>();

            //FxGoods
            container.Register<Fx.Domain.FxGoods.IService.ITransferGoods, Fx.Domain.FxGoods.FxTransferGoodService>();
            container.Register<Fx.Domain.FxGoods.IService.IBuyGoods, Fx.Domain.FxGoods.FxBuyGoodsService>();

            //FxCar
            container.Register<Fx.Domain.FxCar.IService.ITransferCar, Fx.Domain.FxCar.FxTransferCarService>();
            container.Register<Fx.Domain.FxCar.IService.IBuyCar, Fx.Domain.FxCar.FxBuyCarService>();

            //FxHouse
            container.Register<Fx.Domain.FxHouse.IService.ITransferHouse, Fx.Domain.FxHouse.FxTransferHouseService>();
            container.Register<Fx.Domain.FxHouse.IService.IBuyHouse, Fx.Domain.FxHouse.FxBuyHouseService>();


            //»º´æ·þÎñ
            container.RegisterSingle<Fx.Infrastructure.Caching.ICacheManager, Fx.Infrastructure.Caching.CacheManager>();
        }
    }
}
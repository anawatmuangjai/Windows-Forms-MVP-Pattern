using AutoMapper;
using MVP.Client.Forms;
using MVP.Client.Presenters;
using MVP.Client.UserControls;
using MVP.Client.Views;
using MVP.Core.Interfaces;
using MVP.Infrastructure.Context;
using MVP.Infrastructure.Repository;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.Container
{
    public class IoCConfiguration : NinjectModule
    {
        public override void Load()
        {
            var mapperConfiguration = CreateConfiguration();
            Kernel.Bind<MapperConfiguration>().ToConstant(mapperConfiguration).InSingletonScope();
            Kernel.Bind<IMapper>().ToMethod(ctx => new Mapper(mapperConfiguration, type => ctx.Kernel.Get(type)));

            Kernel.Bind<MvpDbContext>().ToSelf().InSingletonScope();
            Kernel.Bind<IUserRepository>().To<UserRepository>().InSingletonScope();
            Kernel.Bind<IProductRepository>().To<ProductRepository>().InSingletonScope();

            Kernel.Bind<IMainView>().To<MainForm>().InSingletonScope();
            Kernel.Bind<ILoginView>().To<LoginView>().InSingletonScope();
            Kernel.Bind<IProductView>().To<ProductView>().InSingletonScope();

            Kernel.Bind<ILoginPresenter>().To<LoginPresenter>().InSingletonScope();
            Kernel.Bind<IMainPresenter>().To<MainPresenter>().InSingletonScope();
            Kernel.Bind<IProductPresenter>().To<ProductPresenter>().InSingletonScope();
        }

        private MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles(GetType().Assembly);
            });

            return config;
        }
    }
}

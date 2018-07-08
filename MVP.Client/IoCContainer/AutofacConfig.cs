using Autofac;
using MVP.Client.Forms;
using MVP.Client.MappingProfile;
using MVP.Client.Presenters;
using MVP.Client.Views;
using MVP.Core.Interfaces;
using MVP.Infrastructure.Context;
using MVP.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.IoCContainer
{
    public static class AutofacConfig
    {
        public static IContainer RegisterComponents()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new AutoMapperModule());

            builder.RegisterType<MvpDbContext>().As<DbContext>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<LoginForm>();
            builder.RegisterType<LoginPresenter>().AsSelf().SingleInstance();

            var container = builder.Build();

            return container;
        }
    }
}

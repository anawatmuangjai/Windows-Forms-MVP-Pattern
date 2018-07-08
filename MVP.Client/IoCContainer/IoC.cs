using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.IoCContainer
{
    public static class IoC
    {
        private static IContainer _container;

        public static void Initialize(IContainer container)
        {
            _container = container;
        }

        public static IContainer GetContainer()
        {
            return _container;
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}

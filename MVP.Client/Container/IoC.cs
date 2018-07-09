using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.Container
{
    public static class IoC
    {
        private static StandardKernel _kernel;

        public static T Get<T>()
        {
            return _kernel.Get<T>();
        }

        public static void Initialize(params INinjectModule[] ninjectModule)
        {
            if (_kernel == null)
            {
                _kernel = new StandardKernel(ninjectModule);
            }
        }
    }
}

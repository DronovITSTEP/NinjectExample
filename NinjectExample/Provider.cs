using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Activation;

namespace NinjectExample
{
    public abstract class Provider<T> : IProvider
    {
        protected Provider();
        public virtual Type Type { get; }
        public object Create(IContext context);
        protected abstract T CreateInstanceContext (IContext context);
    }
}

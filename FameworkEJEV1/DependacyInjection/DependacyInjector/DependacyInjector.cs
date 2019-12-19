using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace DependacyInjector
{
    public class DependacyInjector
    {
        public DependacyInjector()
        {
            UnityContainer _container = new UnityContainer();
            this.Container = _container;

        }
        public UnityContainer Container { get; set; }

        public void RegisterType<TFrom, TTo>(string name) where TTo : TFrom
        {
            Container.RegisterType<TFrom, TTo>(name, new TransientLifetimeManager());
        }

        public T GetInstance<T>(string name)
        {
            return Container.Resolve<T>(name);
        }
    }
}

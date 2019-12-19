using Models.Contracts;
using Injector = DependacyInjector.DependacyInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessProvider;

namespace ServiceProvider
{
    public class BaseService : IBaseService
    {
        public Injector dependacyInjector { get; set; }
        public BaseService()
        {
            dependacyInjector = new Injector();
            dependacyInjector.RegisterType<IBusinessProvider, BusinessProvider.BusinessProvider>("BusinessProvider");

        }
        public void TestMethod()
        {
            try
            {
                dependacyInjector.GetInstance<IBusinessProvider>("BusinessProvider").TestMethod();
            }
            catch (Exception e)
            {

            }
        }
    }
}

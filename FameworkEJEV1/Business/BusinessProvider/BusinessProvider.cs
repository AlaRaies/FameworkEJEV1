using Models.Contracts;
using Injector = DependacyInjector.DependacyInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessProvider;

namespace BusinessProvider
{
    public class BusinessProvider : IBusinessProvider
    {
        public Injector dependacyInjector { get; set; }
        public BusinessProvider()
        {
            dependacyInjector = new Injector();
            dependacyInjector.RegisterType<IDataAccessProvider, DataAccessProvider.DataAccessProvider>("DataAccessProvider");
        }
        public void TestMethod()
        {
            dependacyInjector.GetInstance<IDataAccessProvider>("DataAccessProvider").TestMethod();
        }
    }
}

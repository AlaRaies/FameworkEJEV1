using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Injector = DependacyInjector.DependacyInjector;
using System.Web.Http;
using Models.Contracts;

namespace BackEndHost.Controllers
{
    public class BaseController : ApiController
    {
        public Injector dependacyInjector { get; set; }
        public BaseController()
        {
            dependacyInjector = new Injector();
            dependacyInjector.RegisterType<IBaseService, ServiceProvider.BaseService>("ServicesProvider");
        }
        [ActionName("testMethod")]
        [HttpGet]
        public void TestMethod()
        {
            dependacyInjector.GetInstance<IBaseService>("ServicesProvider").TestMethod();
        }
    }
}

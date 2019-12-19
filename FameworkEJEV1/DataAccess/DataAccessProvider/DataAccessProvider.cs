using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessProvider
{
    public class DataAccessProvider : Models.Contracts.IDataAccessProvider
    {
        SolutionModel Model { get; set; }
        public DataAccessProvider()
        {
            Model = new SolutionModel();
        }
        public void TestMethod()
        {
            Models.Models.User user = new Models.Models.User() { UserName = "TestMethod User" };
            Model.UsersTables.Add(user);
            Model.SaveChanges();
        }
    }
}

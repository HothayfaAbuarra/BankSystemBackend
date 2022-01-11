using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using common;
using DAL;
namespace CityBank_bankend.Controllers
{
    [ApiController]
    public class EmployeeController
    {
        #region Api for Create Employee
        [HttpPost]
        [Route("/api/employee/create")]
        public Guid CreateEmployee(Employees employee)
        {
            EmployeeRepository er = new EmployeeRepository();
            var result=er.CreateAccount(employee);
            if (result == null)
            {
                return new Guid();
            }
            else
            {
                return result;
            }
        }
        #endregion

        #region Api for Login

        #endregion
    }
}

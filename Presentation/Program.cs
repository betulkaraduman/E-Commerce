using B_Commerce.Common.Repository.Concrete;
using B_Commerce.Common.UnitOfWork.Abstract;
using B_Commerce.Common.UnitOfWork.Concrete;
using B_Commerce.Login.DatabaseContext;
using B_Commerce.Login.DomainClass;
using B_Commerce.Login.Response;
using B_Commerce.Login.Service.Concrete;
using System;
using static B_Commerce.Login.Common.Constants;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            //IOC servisi yazılacak
            LoginDbContext lgDbContext = new LoginDbContext();
            ECommerceUnitOfWork unitOfWork = new ECommerceUnitOfWork(lgDbContext);
            LoginService loginService = new LoginService(unitOfWork, new EfRepository<User>(lgDbContext));


            LoginResponse loginResponse = loginService.Login(new User
            {
                Username = "emirchngr",
                Password = "123",
            });

            if (loginResponse.Code == (int)ResponseCode.SUCCESS)
            {
                Console.WriteLine(ResponseCode.SUCCESS.ToString());
            }
            else
            {
                Console.WriteLine(ResponseCode.FAILED.ToString());
            }
        }
    }
}

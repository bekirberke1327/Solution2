using Businesss.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Model);
            }

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var b in brandManager.GetAll())
            //{
            //    Console.WriteLine(b.Name);
            //}
        }
    }
}

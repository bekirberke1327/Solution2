using Core.DataAccesss.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.Id equals b.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 Model = c.Model
                                 
                                 

                             };
                return result.ToList();
            }       
        }
    }
}

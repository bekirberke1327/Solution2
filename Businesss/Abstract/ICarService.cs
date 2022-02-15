using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByDailyPrice(int id);
        List<CarDetailDto> GetCarDetails();
        void Add(Car car);  
        void Update(Car car);
        void Delete(Car car);
    }
}

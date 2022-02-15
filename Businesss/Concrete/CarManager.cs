using Businesss.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal cardal)
        {
            _carDal = cardal;
        }

        public void Add(Car car)
        {
            if (car.Model.Length >= 0 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba Eklendi");
            }
            else
            {
                Console.WriteLine("Araba Kaydı Başarısız");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId == id);
        }

        public List<Car> GetAllByDailyPrice(int id)
        {
            return _carDal.GetAll(c => c.DailyPrice == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}

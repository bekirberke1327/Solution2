//using DataAccess.Abstract;
//using Entity.Concrete;
//using Entity.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Concrete
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;

//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>()
//            {
//                new Car{Id =1,BrandId =1,Model ="Wolkswagen",DailyPrice =200,ModelYear =2013,Description ="Rent Caddy 2013"},
//                new Car{Id =1,BrandId =1,Model ="Lamborghini",CarName ="Aventador",DailyPrice =20000,ModelYear =2022,Description ="Rent Aventador 2022"},
//                new Car{Id =1,BrandId =1,Model ="Lancia",CarName ="Delta",DailyPrice =90000,ModelYear =2010,Description ="Rent Delta 2022"},
//                new Car{Id =1,BrandId =1,Model ="Ferrari",CarName ="Enzo",DailyPrice =50000,ModelYear =2022,Description ="Rent Enzo 2022"},
//                new Car{Id =1,BrandId =1,Model ="Mercedes-Benz",CarName ="Maybach",DailyPrice =70000,ModelYear =2022,Description ="Rent Maybach 2022"},
//                new Car{Id =1,BrandId =1,Model ="Pagani",CarName ="Zonda",DailyPrice =100000,ModelYear =2022,Description ="Rent Zonda 2022"},
//                new Car{Id =1,BrandId =1,Model ="Mclaren",CarName ="P1",DailyPrice =95000,ModelYear =2022,Description ="Rent MclarenP1 2022"},
//                new Car{Id =1,BrandId =1,Model ="Renault",CarName ="Megane",DailyPrice =10,ModelYear =2002,Description ="Rent Megane 2002"},
//            };
//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.FirstOrDefault(c => c.BrandId == car.BrandId);
//            _cars.Remove(carToDelete);
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetBrand(int brandId)
//        {
//            return _cars.Where(c => c.BrandId == brandId).ToList();
//        }

//        public List<CarDetailDto> GetCarDetails()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.FirstOrDefault(c => c.BrandId == car.BrandId);
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.BrandName = car.BrandName;
//            carToUpdate.CarId = car.CarId;
//            carToUpdate.CarName = car.CarName;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.Description = car.Description;
//            carToUpdate.DailyPrice = car.DailyPrice;
//        }
//    }
//}

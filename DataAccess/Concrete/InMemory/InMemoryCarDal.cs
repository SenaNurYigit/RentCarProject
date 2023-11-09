using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
         
                _car = new List<Car>
                {
                    new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 1500, ModelYear = 2022, Description = "Tesla" },
                    new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 56000, ModelYear = 2019, Description = "Bugatti" },
                    new Car { Id = 3, BrandId = 3, ColorId = 1, DailyPrice = 900, ModelYear = 2018, Description = "Audi" },
                    new Car { Id = 4, BrandId = 4, ColorId = 1, DailyPrice = 680, ModelYear = 2019, Description = "Fiat" },
                };
        }
        public void Add(Car car)
        {
           _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_car.SingleOrDefault(p=>p.Id== car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car.ToList();
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(p => p.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p=>p.Id== car.Id);
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.Description=car.Description;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.BrandId=car.BrandId;

        }
    }
    }

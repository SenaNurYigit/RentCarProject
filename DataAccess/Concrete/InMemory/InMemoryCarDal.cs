using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
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

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
    }

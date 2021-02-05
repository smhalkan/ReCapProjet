using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=500,Description="Siyah Otomatik Vites Dizel"},
                new Car{CarId=2,BrandId=1,ColorId=2,ModelYear=2019,DailyPrice=300,Description="Beyaz Manuel Vites Benzin"},
                new Car{CarId=3,BrandId=2,ColorId=3,ModelYear=2018,DailyPrice=400,Description="Kırmızı Otomatik Vites Benzin"},
                new Car{CarId=4,BrandId=3,ColorId=1,ModelYear=2017,DailyPrice=200,Description="Siyah Manuel Vites Benzin"},
                new Car{CarId=5,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=500,Description="Beyaz Otomatik Vites Dİzel"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }

        public Car GetById(int CarId)
        {
            return _cars.SingleOrDefault(c => c.CarId == CarId);
        }
    }
}

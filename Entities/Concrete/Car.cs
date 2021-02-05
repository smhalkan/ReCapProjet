using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }

        public static IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

        public List<Car> ToList()
        {
            throw new NotImplementedException();
        }
    }
}

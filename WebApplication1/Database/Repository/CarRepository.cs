using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contracts;
using WebApplication1.Database.Entities;

namespace WebApplication1.Database.Repository
{
    public class CarRepository : ICarRepository
    {
        private AppContext _ctx;
        public CarRepository(AppContext ctx)
        {
            _ctx = ctx;
        }
        public List<Car> get()
        {

            return _ctx.car.ToList();
        }
    }
}

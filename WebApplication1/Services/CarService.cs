using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contracts;
using WebApplication1.Database.Entities;

namespace WebApplication1.Services
{
    public class CarService:ICarService
    {
        private ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public List<Car> Get()
        {
            return _carRepository.get();
        }
    }
}

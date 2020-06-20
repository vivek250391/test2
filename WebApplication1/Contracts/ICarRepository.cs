using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database.Entities;

namespace WebApplication1.Contracts
{
    public interface ICarRepository
    {
        List<Car> get();
    }
}

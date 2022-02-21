using RentGermanCar.Data;
using System.Collections.Generic;

namespace RentGermanCar.Service
{
    public interface IRentCarService
    {
        void AddCar(Car carToAdd);

        List<Car> GetCar();

        Car GetById(int id);

        void EditCar(Car car);

        void DeleteCar(int id);
    }
}

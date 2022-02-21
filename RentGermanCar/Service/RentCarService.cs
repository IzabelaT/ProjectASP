using RentGermanCar.Data;
using RentGermanCar.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace RentGermanCar.Service
{
    public class RentCarService : IRentCarService
    {
        private readonly ApplicationDbContext db;

        public RentCarService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddCar(Car CarToAdd)
        {
            db.Cars.Add(CarToAdd);
            db.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var carToBeDeleted = this.GetById(id);
            this.db.Cars.Remove(carToBeDeleted);
            db.SaveChanges();
        }

        public void EditCar(Car carToEdit)
        {
            var car = this.GetById(carToEdit.Id);

            car.Brand = carToEdit.Brand;
            car.Color = carToEdit.Color;
            car.BringDate = carToEdit.BringDate;

            db.SaveChanges();
        }

        public List<Car> GetCar()
        {
            return db.Cars.ToList();
        }

        public Car GetById(int id)
        {
            return this.db.Cars.FirstOrDefault(x => x.Id == id);
        }


    }
}

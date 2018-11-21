using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL;
using Domain;

namespace CarRentalWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarService" in both code and config file together.
    public class CarService : ICarService
    {
        public void RemoveCar(string RegNr)
        {
            var carService = new CarMethods();
            carService.Remove(RegNr);
        }

        public void AddCar(Car car)
        {
            var carService = new CarMethods();

            var newCar = new Domain.Car
            {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                Year = car.Year,
                RegNr = car.RegNr
            };

            carService.Add(newCar);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL;

namespace CarRentalWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarRentalWCFService" in both code and config file together.
    public class CarRentalWCFService : ICarRentalWCFService
    {
        public void RemoveCar(string RegNr)
        {
            var carService = new CarService();
            carService.Remove(RegNr);
        }
    }
}

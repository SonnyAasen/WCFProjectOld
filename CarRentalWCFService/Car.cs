using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarRentalWCFService
{
    [DataContract]
    public class Car
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Brand { get; set; }
        [DataMember(Order = 3)]
        public string Model { get; set; }
        [DataMember(Order = 4)]
        public int Year { get; set; }
        [DataMember(Order = 5)]
        public string RegNr { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml.Linq;

namespace DAL
{
    // class which including extensiosns method toXML
    public static class ExtensiosnsMethods
    {
        public static XElement toXML(this Car car)
        {
            XElement result = new XElement("Car",
                                    new XElement("License", car.License),
                                    new XElement("typeOfCar",
                                          new XElement("Manufacturer", car.typeOfCar.Manufacturer),
                                          new XElement("Model", car.typeOfCar.model),
                                          new XElement("Enginee", car.typeOfCar.Engine)
                                          ),
                                    new XElement("Doors", car.Doors),
                                    new XElement("Faults",
                                                        from f in car.faults
                                                        select new XElement("Fault",
                                                                           new XElement("CarLicense", f.License),
                                                                           new XElement("FaultDate", f.dateOfFault),
                                                                           new XElement("Negligence", f.Negligence),
                                                                           new XElement("TypeOfFault", f.typeOfFault.ToString()))
                                                                     ),

                                    new XElement("KM", car.KM),
                                    new XElement("Passengers", car.passengers),
                                    new XElement("TypeOfGear", car.AutoOrManual.ToString()),
                                    new XElement("dateOfProduction", car.dateOfProduction.ToString()),
                                    new XElement("Branch", car.branch)
                                    );
            return result;
        }
        public static XElement toXML(this Client client)
        {
            XElement result = new XElement("Client",
                new XElement("name", client.name),
                new XElement("ID", client.ID),
                new XElement("Adress", client.Adress),
                new XElement("DateOfBirth", client.DateOfBirth.ToString()),
                new XElement("CardNumber", client.CardNumber)
                );
            return result;
        }
        public static XElement toXML(this Renting renting)
        {
            XElement result = new XElement("Renting",
                new XElement("Booking", renting.Booking),
                new XElement("start", renting.start.ToString()),
                new XElement("end", renting.end.ToString()),
                new XElement("Drivers",
                    new XElement("main_driver_id", renting.drivers.ID_firstDriver),
                    new XElement("main_driver_name", renting.drivers.name_firstDriver),
                    new XElement("secend_driver_id", renting.drivers.ID_secendDriver),
                    new XElement("secend_driver_name", renting.drivers.name_secendDriver)
                    ),
                new XElement("carLicense", renting.CarLicense),
                 new XElement("numOfdrivers", renting.numOfDrivers),
                new XElement("KM_start", renting.KM_start),
                new XElement("KM_end", renting.KM_end),
                 new XElement("total_KM", renting.total_KM),
                new XElement("status_of_renting", renting.statusOfRenting),
                new XElement("fault", renting.fault),
                new XElement("price", renting.price)
                );
            return result;
        }
        public static XElement toXML(this Fault fault)
        {
            XElement result = new XElement("fault",
                new XElement("License", fault.License),
                new XElement("dateOfFault", fault.dateOfFault.ToString()),
                new XElement("typeOfFault", fault.typeOfFault.ToString()),
                new XElement("Negligence", fault.Negligence),
                new XElement("price", fault.Price),
                new XElement("garage", fault.Garage)
                );
            return result;

        }
    }
}

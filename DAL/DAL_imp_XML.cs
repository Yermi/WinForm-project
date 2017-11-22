using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
using System.Reflection;

namespace DAL
{
    // implemation of the interface by lists
    public class DAL_imp_XML : idal
    {
        Random r = new Random();

        //private static string localPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string carPath = @"carXml.xml";
        string clientPath = @"clientXml.xml";
        string rentingPath = @"rentingXml.xml";
        string faultPath = @"faultXml.xml";

         XElement carRoot;
         XElement clientRoot;
         XElement rentingRoot;
         XElement faultRoot;

         // check if there is XML files
        public  void DAL_imp_XMLInit()
        {
            if (!File.Exists(carPath) || !File.Exists(clientPath) || !File.Exists(rentingPath) || !File.Exists(faultPath))
                CreateFiles(); //if files not exists - call the function of create files
            LoadFiles();
        }

        // load all the files of XML by calling the functions of loading evry file
        public  void LoadFiles()
        {
            try
            {
                carRoot = XElement.Load(carPath);
                clientRoot = XElement.Load(clientPath);
                rentingRoot = XElement.Load(rentingPath);
                faultRoot = XElement.Load(faultPath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }

        // load carXML file
        public  void load_car()
        {
            carRoot = XElement.Load(carPath);
        }
        // load clientXML file
        public  void load_client()
        {
            clientRoot = XElement.Load(clientPath);

        }
        // load rentingXml file
        public  void load_renting()
        {
            rentingRoot = XElement.Load(rentingPath);

        }
        // load faultXML file
        public  void load_fault()
        {
            faultRoot = XElement.Load(faultPath);

        }
        // check what file is not exists and create it
        public  void CreateFiles()
        {
            if (!File.Exists(carPath))
            {
                carRoot = new XElement("Cars");
                carRoot.Save(carPath);
            }
            if (!File.Exists(clientPath))
            {
                clientRoot = new XElement("Clients");
                clientRoot.Save(clientPath);
            }
            if (!File.Exists(rentingPath))
            {
                rentingRoot = new XElement("Renting");
                rentingRoot.Save(rentingPath);
            }
            if (!File.Exists(faultPath))
            {
                faultRoot = new XElement("Fault");
                faultRoot.Save(faultPath);
            }
        }
        
        public  void addClient(Client client)
        {
            load_client();
            clientRoot.Add(client.toXML());
            clientRoot.Save(clientPath);
        } // add client to XML file
        public  void remuveClient(Client client)
        {
            load_client();
            XElement A = (from c in clientRoot.Elements("Client")
                          where c.Element("ID").Value == client.ID.ToString()
                          select c).FirstOrDefault();
            if (A != null)
                A.Remove();
            clientRoot.Save(clientPath);
        }// remove client from XML file
        public  void updateClient(int Id, Client client)
        {
            load_client();
            Client tempC = DataSource.clientsList.Find(t => t.ID == Id);

            remuveClient(tempC);
            addClient(client);
        }// update client in XML file
        public  List<Client> getAllClients()
        {
            var clientList = (from c in clientRoot.Elements("Client")
                              select new Client
                              {
                                  name = c.Element("name").Value,
                                  ID = (int)c.Element("ID"),
                                  Adress = c.Element("Adress").Value,
                                  DateOfBirth =Convert.ToDateTime(c.Element("DateOfBirth").Value),
                                  CardNumber = (int)c.Element("CardNumber")
                              }).ToList();                              
            return clientList;
        }// get all the elements in clientXML file

        public  void addCar(Car car)
        {
            load_car();
            // check the key number 
            if (car.License == 0)
            {
                int max = 0;
                if (DataSource.carList.Count != 0)
                {
                    max = DataSource.carList.Max(c => c.License);
                    car.License = max++;
                }
                else
                {
                    car.License = 1000001;
                }
            }

            carRoot.Add(car.toXML());
            carRoot.Save(carPath);
        }// add car to the XML file
        public  void remuveCar(Car car)
        {
            load_car();

            XElement A = (from c in carRoot.Elements("Car")
                          where c.Element("License").Value == car.License.ToString()
                          select c).FirstOrDefault();
            if (A != null)
            {
                A.Remove();
            }
            carRoot.Save(carPath);
        }//remove car from the XML file
        public  void updateCar(int Id, Car car)
        {
            load_car();
            Car tempC = getAllCars().Find(t => t.License == Id);
            List<Fault> list = getAllFaults().FindAll(t => t.License == Id);// remove the car and it's faults
            tempC.faults = list;

            remuveCar(tempC);
            addCar(car);
            
            carRoot.Save(carPath);
        }// update client in the XML file
        public  List<Car> getAllCars()
        {
            var carList = (from c in carRoot.Elements("Car")
                           select new Car
                           {
                               License = (int)c.Element("License"),
                               Doors = (int)c.Element("Doors"),
                               faults = (from f in c.Elements("Fault")
                                         select new Fault
                                         {
                                             dateOfFault = (DateTime)f.Element("FaultDate"),
                                             License = (int)f.Element("CarLicense"),
                                             Negligence = (bool)f.Element("Negligence"),
                                             typeOfFault = (typeFault)Enum.Parse(typeof(typeFault), f.Element("TypeOfFault").Value),
                                             Price = (float)f.Element("price"),
                                             Garage = f.Element("Garage").Value
                                         }).ToList(),
                               KM = (int)c.Element("KM"),
                               passengers = (int)c.Element("Passengers"),
                               AutoOrManual = (Gear)Enum.Parse(typeof(Gear), c.Element("TypeOfGear").Value),
                               branch = c.Element("Branch").Value,
                               dateOfProduction = Convert.ToDateTime(c.Element("dateOfProduction").Value),
                               typeOfCar = new typeOfCar
                               {
                                   Engine = (int)c.Element("typeOfCar").Element("Enginee"),
                                   model = c.Element("typeOfCar").Element("Model").Value,
                                   Manufacturer = c.Element("typeOfCar").Element("Manufacturer").Value
                               }
                           }).ToList();
            return carList;
        }// get all the elements in carXML file

        public  void addRenting(Renting renting)
        {
            load_renting();
            //check the key number
            int max;
            if (renting.Booking < 100000 || renting.Booking > 999999)
            {
                max = DataSource.rentingsList.Max(t => t.Booking);
                renting.Booking = max++;
            }

            Renting A =getAllRentings().Find(t => t.Booking == renting.Booking);
            if (A != null)
                renting.Booking = getbookingNum(renting);

            rentingRoot.Add(renting.toXML());
            rentingRoot.Save(rentingPath);
        }//add renting to the XML file
        public  void removeRenting(Renting renting)
        {
            int carLicense = renting.CarLicense;
            load_renting();



            XElement A = (from c in rentingRoot.Elements("Renting")
                          where c.Element("carLicense").Value == carLicense.ToString()
                          select c).FirstOrDefault();
            if(A != null)
            {
                A.Remove();
            }
            rentingRoot.Save(rentingPath);
        }//remove rentong from the XML file
        public void updateRenting(Renting renting1, Renting renting2) // update renting in the XML file
        {
            load_renting();

            removeRenting(renting1);
            addRenting(renting2);
            
            rentingRoot.Save(rentingPath);
        }
        public  List<Renting> getAllRentings()
        {
            var rentigList = (from c in rentingRoot.Elements("Renting")
                              select new Renting
                              {
                                  Booking = (int)c.Element("Booking"),
                                  start = (DateTime)c.Element("start"),
                                  end = (DateTime)c.Element("end"),
                                  drivers = new Drivers
                                  {
                                      ID_firstDriver = (int)c.Element("Drivers").Element("main_driver_id"),
                                      name_firstDriver = c.Element("Drivers").Element("main_driver_name").Value,
                                      ID_secendDriver = (int)c.Element("Drivers").Element("secend_driver_id"),
                                      name_secendDriver = c.Element("Drivers").Element("secend_driver_name").Value
                                  },
                                  CarLicense = (int)c.Element("carLicense"),
                                  numOfDrivers = (int)c.Element("numOfdrivers"),
                                  KM_start = (int)c.Element("KM_start"),
                                  KM_end = (int)c.Element("KM_end"),
                                  total_KM = (int)c.Element("total_KM"),
                                  statusOfRenting = c.Element("status_of_renting").Value,
                                  fault = (bool)c.Element("fault"),
                                  price = (float)c.Element("price")
                              }).ToList();
            return rentigList;
        }// get all the elements in rentingsXML file

        public  void addFault(Fault fault)
        {
            load_fault();

            Car CurrentCar = getAllCars().Find(t => t.License == fault.License);
            List<Fault> faultLIst = getAllFaults().FindAll(t => t.License == CurrentCar.License);
            if (CurrentCar.faults == null)
                CurrentCar.faults = new List<Fault>();
            else
                CurrentCar.faults = faultLIst;
            Renting rent = getAllRentings().Find(t => t.CarLicense == fault.License);
            rent.fault = false;
            CurrentCar.faults.Add(fault);


            faultRoot.Add(fault.toXML());// add the fault also to the spicific car
            updateCar(CurrentCar.License, CurrentCar);
            updateRenting(rent, rent);
            faultRoot.Save(faultPath);
        }// add fault to XML file
        public  void removeFault(Fault fault)
        {
            load_fault();
            Car tempCar = getAllCars().Find(t => t.License == fault.License);
            if (tempCar.faults != null)
            {
                tempCar.faults.Remove(fault);
            }

            XElement A = (from c in faultRoot.Elements("fault")
                          where c.Element("License").Value == fault.License.ToString()
                          select c).FirstOrDefault();
            if (A != null)
            {
                A.Remove();
            }
            XElement B = (from x in carRoot.Elements("Car").Elements("faults")// remove fault also from the car
                         where x.Element("typeOfFault").Value == fault.typeOfFault.ToString()
                         select x).FirstOrDefault();
            if (B != null)
            {
                B.Remove();
            }

            updateCar(tempCar.License, tempCar);
            faultRoot.Save(faultPath);
        }// remove fault from XML file
        public  void updateFault(Fault fault1, Fault fault2) 
        {
            load_fault();

            removeFault(fault1);
            addFault(fault2);
           
            faultRoot.Save(faultPath);
        }// update fault in faultXML file
        public  List<Fault> getAllFaults()
        {
            var faultList = (from c in faultRoot.Elements("fault")
                             select new Fault
                             {
                                 License = (int)c.Element("License"),
                                 dateOfFault = (DateTime)c.Element("dateOfFault"),
                                 typeOfFault = (typeFault)Enum.Parse(typeof(typeFault), c.Element("typeOfFault").Value),
                                 Negligence = (bool)c.Element("Negligence"),
                                 Price = (float)c.Element("price"),
                                 Garage = c.Element("garage").Value
                             }).ToList();
            return faultList;
        }// get all elements in fault XMLfile

        // gives a number for the function 'addRenting'
        private int getbookingNum(Renting renting)
        {
            renting.Booking = r.Next(100000, 999999);
            if (DataSource.rentingsList.Find(t => t.Booking == renting.Booking) != null)
                getbookingNum(renting);
            return renting.Booking;
        }
    }
}

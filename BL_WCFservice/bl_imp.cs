using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_WCFservice
{
    public delegate bool function (Client client);

    public class bl_imp : IBL
    {
        public bl_imp()
        {
            dal = factoryDAL.getDAL();
        }

        public float profit { get; set; }
        idal dal = new DAL_imp_XML();

        public void addClient(Client client)
        {
            if (DataSource.clientsList.Find(t => t.ID == client.ID) != null)
                throw new Exception("client exists");
            if (client.DateOfBirth.AddYears(18) > DateTime.Now.Date)
                throw new Exception("can't rent a car under 18 years");
            if (client.CardNumber.ToString().Length != 8)
                throw new Exception("card number must include 8 digits");

            try
            {
                dal.addClient(client);
            }
            catch (Exception e)
            {                
                throw new Exception(e.Message);
            }
        }
        public void remuveClient(int ID)
        {
            List<Renting> ListOfRentings = dal.getAllRentings();
            if (ListOfRentings.Find(t => t.drivers.ID_firstDriver == ID || t.drivers.ID_secendDriver == ID) != null)
                throw new Exception("cannot be deleted, client renting now a car");
            else
            {
                if(ListOfRentings.Find(t => t.end.AddDays(30).Date > DateTime.Now.Date) != null)
                    throw new Exception("client cannot be deleted Because there were 30 days since the end of rent");
            }

            Client client = DataSource.clientsList.Find(t => t.ID == ID);

            try
            {
                dal.remuveClient(client);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void updateClient(int Id ,Client client)
        {     
            if (dal.getAllClients().Find(t => t.ID == Id) == null)
                throw new Exception(" client not found");
            try
            {
                dal.updateClient(Id, client);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Client> getAllClients()
        {
            return dal.getAllClients();
        }

        public void addCar(Car car)
        {
            if (car.dateOfProduction.Date > DateTime.Now.Date)
                throw new Exception(" date of prodact can't be later from now");
            if (car.Doors < 0 || car.KM < 0 || car.passengers < 0)
                throw new Exception(" invalid values, value can't be negative");
            try
            {
                dal.addCar(car);
            }
            catch(Exception e)             
            {
                throw new Exception(e.Message);
            }
        }
        public void remuveCar(int license)
        {
            List<Renting> ListOfRentings = dal.getAllRentings();
            Renting rent = ListOfRentings.Find(t => t.CarLicense == license);
            if (rent != null)
            {
                if (rent.statusOfRenting != "end")
                {
                    throw new Exception("can't be deleted, car is now rented");
                }
            }
                
                

            List<Car> ListOfCars = dal.getAllCars();
            if (getAllCars().Find(t => t.License == license) == null)
                throw new Exception(" car not exist");
            Car car = DataSource.carList.Find(t => t.License == license);
            dal.remuveCar(car);
        }
        public void updateCar(int Id, Car car)
        {
            if (dal.getAllCars().Find(t => t.License == Id) == null)
                throw new Exception("car not found");
            try
            {
                dal.updateCar(Id, car);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }            
        }
        public List<Car> getAllCars()
        {
            return dal.getAllCars();
        }

        public void addRenting(Renting renting)
        {
            int count = 0;

            if (dal.getAllCars().Find(t => t.License == renting.CarLicense) == null)
                throw new Exception(" the car you want to rent not found");
            if (dal.getAllRentings().Find(t => t.CarLicense == renting.CarLicense) != null)
            {
                Renting rent = dal.getAllRentings().Find(t => t.CarLicense == renting.CarLicense);
                if(rent.end.Date > renting.start.Date)
                    throw new Exception(" the car you want is already rented now");
            }
            
            if (dal.getAllClients().Find(t => t.ID == renting.drivers.ID_firstDriver) == null)
                throw new Exception(" the main driver is not found");

            var v = from c in dal.getAllRentings()
                    where c.fault == true
                    where c.drivers.ID_firstDriver == renting.drivers.ID_firstDriver
                    select c;

            foreach (var item in v)
            {
                count++;
            }

            if (count >= 2)
                throw new Exception("Theis driver can't rent a car because he caused tow faults to cars");

            dal.addRenting(renting);
            
        }
        public void removeRenting(Renting renting)
        {
            if (dal.getAllRentings().Find(t => t.Booking == renting.Booking)== null)
                throw new Exception("can't delete because renting is not found");
            if (renting.start.Date < DateTime.Now.Date && renting.end.Date > DateTime.Now.Date)
                throw new Exception("this renting was started already");
            dal.removeRenting(renting);            
        }
        public void updateRenting(Renting renting1, Renting renting2)
        {
            if (dal.getAllRentings().Count > 1)
            {
                if (dal.getAllRentings().Find(t => t.Booking == renting1.Booking) == null)
                    throw new Exception("the renting you want to update is not exsits");
            }

            Car A = dal.getAllCars().Find(t => t.License == renting2.CarLicense);
            
            A.KM += renting2.total_KM;
            
            if (renting2.fault == true)
            {
                List<Fault> ListOfFaults = A.faults.FindAll(t => t.dateOfFault.Date > renting1.start.Date && t.dateOfFault.Date < renting1.end.Date);
                foreach (Fault item in ListOfFaults)
                {
                    if (item.Negligence)
                        renting2.price += item.Price;
                    else
                        profit -= item.Price;

                    A.faults.Remove(item);
                    dal.removeFault(item);                  
                }
                renting2.fault = false;
            }
            dal.updateCar(A.License, A);            
            dal.updateRenting(renting1, renting2);
        }
        public List<Renting> getAllRentings()
        {
            return dal.getAllRentings();
        }

        public void addFault(Fault fault)
        {
            if (dal.getAllCars().Find(t => t.License == fault.License) == null)
                throw new Exception("car is not found");
            else
            {
                if (dal.getAllFaults().Find(t => (t.License == fault.License) && (t.typeOfFault == fault.typeOfFault)) != null)
                    throw new Exception("car with the same fault is exists");
            }
            var v = from c in getAllRentings()
                    where c.CarLicense == fault.License
                    where c.statusOfRenting == "Ongoing"
                    select c;
            if (v == null)
                throw new Exception("this car is not rented now");            
                        
            dal.addFault(fault);            
        }
        public void removeFault(Fault fault)
        {
            if (dal.getAllCars().Find(t => t.License == fault.License) == null && dal.getAllFaults().Find(t => t.typeOfFault == fault.typeOfFault) == null)    
                throw new Exception("car with this fault is not found");
            
            dal.removeFault(fault);

        }
        public void updateFault(Fault fault1, Fault fault2)
        {
            if (dal.getAllCars().Find(t => t.License == fault1.License) == null)
                throw new Exception("the car you want to update is not found");

            dal.getAllCars().Find(t => t.License == fault1.License).faults.Remove(fault1);
            dal.getAllCars().Find(t => t.License == fault2.License).faults.Add(fault2);
            dal.updateFault(fault1, fault2);
        }
        public List<Fault> getAllFaults()
        {
            return dal.getAllFaults();
        }               

        //
        public List<Renting> RentingsByClient(Client client)
        {
            List<Renting> rentingByClient = dal.getAllRentings().FindAll(t => (t.drivers.ID_firstDriver == client.ID || t.drivers.ID_secendDriver == client.ID));
            return rentingByClient;
        }
        public float CostByClient(int ID, DateTime start, DateTime end)
        {
            List<Renting> costByClient = dal.getAllRentings().FindAll(t => (t.drivers.ID_firstDriver == ID || t.drivers.ID_secendDriver == ID) && t.start >= start && t.end <= end);

            float sum = 0;
            foreach (Renting item in costByClient)
            {
                sum += item.price;
            }
            return sum;
        }
        public float ProfitByCars()
        {
            List<Car> cars = dal.getAllCars();

            float sum = 0;
            foreach (Car item in cars)
            {
                sum += ProfitByCars(item);
            }
            return sum;
        }
        public float ProfitByCars(Car car)
        {
            List<Renting> rentings = dal.getAllRentings().FindAll(t => t.CarLicense == car.License);

            float sum = 0;
            foreach (Renting item in rentings)
            {
                sum += item.price;
            }
            return sum;
        }
        //List<typeFault> FaulteByFrquency()
        //{
        //    List<typeFault> typeFaultList = new List<typeFault>();
        //    var v = from item in typeFaultList
        //            orderby dal.getAllFaults()
        //}
        public List<Client> GetClients(function func)
        {
            List<Client> gtClient = new List<Client>();
            foreach (Client item in dal.getAllClients())
            {
                if (func(item) == true)
                    gtClient.Add(item);
            }
            return gtClient;
         

        }
        public bool fault(Car car)
        {
            return car.faults == null;
        }

        public float price(Renting renting)
        {
            List<Car> cars = dal.getAllCars().FindAll(t => t.License == renting.CarLicense);
            List<Client> clients = dal.getAllClients().FindAll(t => t.ID == renting.drivers.ID_firstDriver);// || t.ID == renting.drivers.ID_secendDriver);

            float sum = 0;
            foreach (Car item in cars)
            {
                if (item.passengers <= 4)
                    renting.price = 150;
                else if (item.passengers > 4 && item.passengers <= 7)
                    renting.price = 250;
                else
                    renting.price = 350;
                if (renting.start <= DateTime.Now.Date)
                {
                    sum += renting.price * (((renting.end - renting.start).Days) + 1);
                }
                  
                if (renting.fault == true)
                    sum += costOfRepair(item.License);
            }

            foreach (Client item in clients)
            {
                if (item.DateOfBirth.AddYears(23).Date > DateTime.Now.Date)
                    sum += 50;
            }
            
            return sum;             
        }
        public float costOfRepair(int carLicense)
        {
            List<Fault> faultList = dal.getAllFaults().FindAll(t => t.License == carLicense);

            float sum = 0;
            foreach (Fault item in faultList)
            {
                if (item.Negligence == true)
                {
                    switch (item.typeOfFault)
                    {
                        case typeFault.Wheels:
                            item.Price = 100;
                            break;
                        case typeFault.Engine:
                            item.Price = 150;
                            break;
                        case typeFault.Exhaust:
                            item.Price = 130;
                            break;                       
                    }
                    sum += item.Price;
                }                
            }
            return sum;
        }
        public List<Car> getCarsWithoutFault()
        {
            List<Car> carsWithoutFaults = new List<Car>();
            var v = from item in dal.getAllCars()
                    where item.faults == null
                    select item;

            foreach (var item in v)
            {
                carsWithoutFaults.Add(item);
            }
            return carsWithoutFaults;
    
        }
        public List<string> GetAllIdByCar()
        {
            List<string> AllId = new List<string>();
            foreach (Car item in dal.getAllCars())
            {
                AllId.Add(item.License.ToString());
            }
            return AllId;
        }
        public List<string> GetAllIdByClient()
        {
            List<string> AllId = new List<string>();
            foreach (Client item in dal.getAllClients())
            {
                AllId.Add(item.ID.ToString());
            }
            return AllId;
        }
        public float priceOfFault(typeFault a)
        {
            float sum = 0;
            switch (a)
            {
                case typeFault.Wheels:
                    sum = 100;
                    break;
                case typeFault.Engine:
                    sum = 150;
                    break;
                case typeFault.Exhaust:
                    sum = 130;
                    break;
            }
            return sum;
        }
    }
}

using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public delegate bool function (Client client);

    public class bl_imp : IBL
    {
        // ctor
        public bl_imp()
        {
            dal = factoryDAL.getDAL();
        }

        public float profit { get; set; }
        idal dal;

        // add client
        public void addClient(Client client)
        {
            // check if lient exists
            if (dal.getAllClients().Find(t => t.ID == client.ID) != null)
                throw new Exception("client exists");
            // check if driver is too young
            if (client.DateOfBirth.Date.AddYears(18) > DateTime.Now.Date)
                throw new Exception("can't rent a car under 18 years");
            // check number of digits of credit card number
            if (client.CardNumber.ToString().Length != 8)
                throw new Exception("card number must include 8 digits");

            try
            {
                dal.addClient(client);//cal to function in DAL
            }
            catch (Exception e)
            {                
                throw new Exception(e.Message);
            }
        }
        // remove client
        public void remuveClient(int ID)
        {
            List<Renting> ListOfRentings = getOngoingRentings();
            //checke if client rent a car now
            if (ListOfRentings.Find(t => t.drivers.ID_firstDriver == ID || t.drivers.ID_secendDriver == ID) != null)
                throw new Exception("cannot be deleted, client renting now a car");
            else
            {
                // check if client rented a car in last 30 days
                if(ListOfRentings.Find(t => t.end.AddDays(30).Date > DateTime.Now.Date) != null)
                    throw new Exception("client cannot be deleted Because there were 30 days since the end of rent");
            }

            Client client = dal.getAllClients().Find(t => t.ID == ID);

            try
            {
                dal.remuveClient(client); //call to function in DAL
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // update client
        public void updateClient(int Id ,Client client)
        {     
            // check if client exists
            if (dal.getAllClients().Find(t => t.ID == Id) == null)
                throw new Exception(" client not found");
            try
            {
                dal.updateClient(Id, client);// call to function in DAL
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // get list of all cars
        public List<Client> getAllClients()
        {
            return dal.getAllClients(); //call to function in DAL
        }


        //add car
        public void addCar(Car car)
        {
            // check the date of production
            if (car.dateOfProduction.Date > DateTime.Now.Date)
                throw new Exception(" date of prodact can't be later from now");
            // check if doors, KM or passengers are negative
            if (car.Doors < 0 || car.KM < 0 || car.passengers < 0)
                throw new Exception(" invalid values, value can't be negative");
            try
            {
                dal.addCar(car); //call to function in DAL
            }
            catch(Exception e)             
            {
                throw new Exception(e.Message);
            }
        }
        // remove car
        public void remuveCar(int license)
        {            
            //check if car exists
            if (getAllCars().Find(t => t.License == license) == null)
                throw new Exception(" car not exist");

            Car temp = getAllCars().Find(t => t.License == license);
            List<Fault> tempList = getAllFaults().FindAll(t => t.License == license);
            List<Renting> ListOfRentings = dal.getAllRentings();
            Renting rent = ListOfRentings.Find(t => t.CarLicense == license);
            // check if car is rented now
            if (rent != null)
            {
                if (rent.statusOfRenting != "end")
                {
                    throw new Exception("can't be deleted, car is now rented");
                }
            }
            // check if the car have faults
            if (tempList.Count != 0)
                throw new Exception("can't be deleted before removing faults");
            try
            {
                dal.remuveCar(temp); // cal the function in DAL
            }
            catch (Exception e)
            {                
                throw new Exception(e.Message);
            }
            
        }
        // update car
        public void updateCar(int Id, Car car)
        {
            // check if car exists
            if (dal.getAllCars().Find(t => t.License == Id) == null)
                throw new Exception("car not found");
            try
            {
                dal.updateCar(Id, car);  // cal the function in DAL
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }            
        }
        // gat list of all cars
        public List<Car> getAllCars()
        {
            return dal.getAllCars();  // cal the function in DAL
        }


        // add renting
        public void addRenting(Renting renting)
        {
            int count = 0;
            //chek if the car is exists
            if (dal.getAllCars().Find(t => t.License == renting.CarLicense) == null)
                throw new Exception(" the car you want to rent not found");
            // check if the car is rented already now
            if (dal.getAllRentings().Find(t => t.CarLicense == renting.CarLicense) != null)
            {
                Renting rent = dal.getAllRentings().Find(t => t.CarLicense == renting.CarLicense);
                if(rent.statusOfRenting != "end")
                    throw new Exception(" the car you want is already rented now");
            }
            // check if the driver is exists
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
            // check if the driver can rent a car/ if he not caused in the past over two faults
            if (count >= 2)
                throw new Exception("Theis driver can't rent a car because he caused tow faults to cars");

            try
            {
                dal.addRenting(renting);
            }
            catch (Exception e)
            {                
                throw new Exception(e.Message);
            }
            
            
        }
        // remove renting
        public void removeRenting(Renting renting)
        {
            // check if the order number is exists
            if (dal.getAllRentings().Find(t => t.Booking == renting.Booking)== null)
                throw new Exception("can't delete because renting is not found");
            // chek if the renting is ended or not
            if (renting.start.Date < DateTime.Now.Date && renting.end.Date > DateTime.Now.Date)
                throw new Exception("this renting was started already");
            // check if there is faults in the car that is rented
            Car tempCar = dal.getAllCars().Find(t => t.License == renting.CarLicense);
            if (tempCar.faults != null)
                throw new Exception("renting cano't removed bafore removing faults");
            try
            {
                dal.removeRenting(renting);  // call to the function in DAL
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
                       
        }
        //update renting
        public void updateRenting(Renting renting1, Renting renting2)
        {
            // check if renting is exsist
            if (dal.getAllRentings().Count > 1)
            {
                if (dal.getAllRentings().Find(t => t.Booking == renting1.Booking) == null)
                    throw new Exception("the renting you want to update is not exsits");
            }

            Car A = dal.getAllCars().Find(t => t.License == renting2.CarLicense);
            //update the KM of the car
            A.KM += renting2.total_KM;
            
            // cremove faults from the cae thet is rented
            if (renting2.fault == true)
            {
                List<Fault> ListOfFaults = dal.getAllFaults().FindAll(t => t.License == A.License);
                foreach (Fault item in ListOfFaults)
                {
                    if (item.Negligence)
                        renting2.price += item.Price;
                    else
                        profit -= item.Price;

                    //A.faults.Remove(item);
                    dal.removeFault(item);                  
                }
                renting2.fault = false;
            }
            try
            {
                dal.updateCar(A.License, A); // call to the function in DAL
                dal.updateRenting(renting1, renting2); // call to the function in DAL
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // get list of all rentings
        public List<Renting> getAllRentings()
        {
            return dal.getAllRentings(); // call to the function in DAL
        }

        // add fault
        public void addFault(Fault fault)
        {
            Car currentcar = dal.getAllCars().Find(t => t.License == fault.License);
            List<Fault> faultLIst = dal.getAllFaults().FindAll(t => t.License == currentcar.License);
            currentcar.faults = faultLIst;
            // check if the car is exists
            if (currentcar == null)
                throw new Exception("car is not found");
            else
            {
                Renting v = (from c in getAllRentings()
                        where c.CarLicense == fault.License
                        where c.statusOfRenting == "Ongoing"
                        select c).FirstOrDefault();
                // chek if the car is in renting
                if (v == null)
                    throw new Exception("this car is not rented now");
                try
                {
                    dal.addFault(fault); // call to the function in DAL
                }
                catch (Exception e)
                {                    
                    throw new Exception(e.Message);
                }
                
            }
                        
        }
        // remove fault
        public void removeFault(Fault fault)
        {
            //checke if fault is exists in spicific car
            if (dal.getAllCars().Find(t => t.License == fault.License) == null && dal.getAllFaults().Find(t => t.typeOfFault == fault.typeOfFault) == null)    
                throw new Exception("car with this fault is not found");
            try
            {
                dal.removeFault(fault); // call to the function in DAL
            }
            catch (Exception e)
            {                
                throw new Exception(e.Message);
            }
            

        }
        // update fault
        public void updateFault(Fault fault1, Fault fault2)
        {
            // check if the car is exists
            if (dal.getAllCars().Find(t => t.License == fault1.License) == null)
                throw new Exception("the car you want to update is not found");

            try
            {
                dal.getAllCars().Find(t => t.License == fault1.License).faults.Remove(fault1); // call to the function in DAL
                dal.getAllCars().Find(t => t.License == fault2.License).faults.Add(fault2); // call to the function in DAL
                dal.updateFault(fault1, fault2); // call to the function in DAL
            }
            catch (Exception e)
            {                
                throw new Exception(e.Message);
            }           
           
        }
        // get all faults
        public List<Fault> getAllFaults()
        {
            return dal.getAllFaults(); // call to the function in DAL
        }               



        // return lidt of rentings of spicific client
        public List<Renting> RentingsByClient(Client client)
        {
            List<Renting> rentingByClient = dal.getAllRentings().FindAll(t => (t.drivers.ID_firstDriver == client.ID || t.drivers.ID_secendDriver == client.ID));
            return rentingByClient;
        }
        // return the payment of spicific cient in Date range
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
        // return profit of all the cars n the car list
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
        // return profit of one specific car
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

     //   public List<Client> GetClients(Func<Client, bool> func)
        // return list of clients that  sustains any terms (use the delgate that defined)
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
        // return if car have falts
        public bool fault(Car car)
        {
            return car.faults == null;
        }
        // return the pruce of a renting
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
        // return the price of faults
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
        // return list of cars withaot faults
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
        // return list of the licenses of all the cars
        public List<string> GetAllIdByCar()
        {
            List<string> AllId = new List<string>();
            foreach (Car item in dal.getAllCars())
            {
                AllId.Add(item.License.ToString());
            }
            return AllId;
        }
        // return list of the ID of all the clients
        public List<string> GetAllIdByClient()
        {
            List<string> AllId = new List<string>();
            foreach (Client item in dal.getAllClients())
            {
                AllId.Add(item.ID.ToString());
            }
            return AllId;
        }
        // return pruce of any fault, for infomation only!
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
        // return list of ongoing rentings
        public List<Renting> getOngoingRentings()
        {
            List<Renting> templist = getAllRentings().FindAll(t => t.statusOfRenting != "end");
            return templist;
        }
    }
}

using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL 
{
    // implemation of the interface IDAL
    public class Dal_imp : idal
    {
        Random r = new Random();

        // management of clientList
        public void addClient(Client client)
        {
            DataSource.clientsList.Add(client);
        }
        public void remuveClient(Client client)
        {
            DataSource.clientsList.Remove(client);            
        }
        public void updateClient(int Id, Client client)
        {
            int A = DataSource.clientsList.IndexOf(DataSource.clientsList.Find(t => t.ID == Id));
            DataSource.clientsList[A] = client;
        }          
        public List<Client> getAllClients()
        {
            return DataSource.clientsList;
        }

        // management of carList
        public void addCar(Car car)
        {
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
            Car A = DataSource.carList.Find(t => t.License == car.License);
            if (A != null)
                throw new Exception("car exsits");
            DataSource.carList.Add(car);
            //DAL_imp_XML.addCar(car);
        }
        public void remuveCar(Car car)
        {
            Car A = DataSource.carList.Find(a => a.License == car.License);

            DataSource.carList.Remove(car);
            //DAL_imp_XML.remuveCar(car);
        }
        public void updateCar(int Id, Car car)
        {
            int A = DataSource.carList.IndexOf(DataSource.carList.Find(t => t.License == Id));
            DataSource.carList[A] = car;
            //DAL_imp_XML.updateCar(Id, car);
        }
        public List<Car> getAllCars()
        {
            return DataSource.carList;
        }

        // management of faultlist
        public void addFault(Fault fault)
        {
            Car a = DataSource.carList.Find(t => t.License == fault.License);

            List<Fault> faultLIst = DataSource.faultsList.FindAll(t => t.License == a.License);
            if (a.faults == null)
            {
                a.faults = new List<Fault>();
            }
            else
            {
                a.faults = faultLIst;
            }
            Renting rent = DataSource.rentingsList.Find(t => t.CarLicense == fault.License);
            rent.fault = false;
            a.faults.Add(fault);

            DataSource.faultsList.Add(fault);

            //DAL_imp_XML.addFault(fault);
            //DAL_imp_XML.updateCar(a.License, a);
            //DAL_imp_XML.updateRenting(rent, rent);
        }
        public void removeFault(Fault fault)
        {
            Fault A = DataSource.faultsList.Find(t => t.typeOfFault == fault.typeOfFault);
            //if (A == null)
            //    throw new Exception("fault not found");

            Car a = DataSource.carList.Find(t => t.License == fault.License);
            if (a.faults != null)
            {
                a.faults.Remove(fault);
            }

            DataSource.faultsList.Remove(fault);

            //DAL_imp_XML.removeFault(fault);
            //DAL_imp_XML.updateCar(a.License, a);

        }
        public void updateFault(Fault fault1, Fault fault2)
        {
            Fault A = DataSource.faultsList.Find(t => t.License == fault1.License);

            DataSource.faultsList.Remove(fault1);
            DataSource.faultsList.Add(fault2);
           // DAL_imp_XML.updateFault(fault1, fault2);
        }
        public List<Fault> getAllFaults()
        {
            return DataSource.faultsList;
        }

        // management of rentinglist
        public void addRenting(Renting renting)
        {
            int max;
            if (renting.Booking < 100000 || renting.Booking > 999999)
            {
                max = DataSource.rentingsList.Max(t => t.Booking);
                renting.Booking = max++;
            }

            Renting A = DataSource.rentingsList.Find(t => t.Booking == renting.Booking);
            if (A != null)
                renting.Booking = getbookingNum(renting);
            
            DataSource.rentingsList.Add(renting);
            //DAL_imp_XML.addRenting(renting);
        }
        public void removeRenting(Renting renting)
        {
            DataSource.rentingsList.Remove(renting);
           
        }
        public void updateRenting(Renting renting1, Renting renting2)
        {
            DataSource.rentingsList.Remove(renting1);
            DataSource.rentingsList.Add(renting2);
           
        }
        public List<Renting> getAllRentings()
        {
            return DataSource.rentingsList;
        }

        // get a number for the function addRenting
        private int getbookingNum(Renting renting)
        {
            renting.Booking = r.Next(100000, 999999);
            if (DataSource.rentingsList.Find(t => t.Booking == renting.Booking) != null)
                getbookingNum(renting);
            return renting.Booking;
        }
    }
}

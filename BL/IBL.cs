using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    // functin that implemated the Logical layer
    public interface IBL
    {
        void addClient(Client client);
        void remuveClient(int ID);
        void updateClient(int Id ,Client client);
        List<Client> getAllClients();

        void addCar(Car car);
        void remuveCar(int license);
        void updateCar(int Id, Car car);
        List<Car> getAllCars();

        void addRenting(Renting renting);
        void removeRenting(Renting renting);
        void updateRenting(Renting renting1, Renting renting2);
        List<Renting> getAllRentings();

        void addFault(Fault fault);
        void removeFault(Fault fault);
        void updateFault(Fault fault1, Fault fault2);
        List<Fault> getAllFaults();
        
        // function 
        List<Renting> RentingsByClient(Client client);
        float CostByClient(int ID, DateTime start, DateTime end);
        float ProfitByCars();
        //List<typeFault> FaulteByFrquency();
        List<Client> GetClients(function func);
        bool fault(Car car);
        float price(Renting renting);

        //
        List<Car> getCarsWithoutFault();
        List<string> GetAllIdByCar();
        List<string> GetAllIdByClient();
        float costOfRepair(int carLicense);
        float priceOfFault(typeFault a);
        List<Renting> getOngoingRentings();
    }
}

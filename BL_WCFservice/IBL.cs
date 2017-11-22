using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BL_WCFservice
{
    [ServiceContract]
    public interface IBL
    {
        [OperationContract]
        void addClient(Client client);

        [OperationContract]
        void remuveClient(int ID);

        [OperationContract]
        void updateClient(int Id ,Client client);

        [OperationContract]
        List<Client> getAllClients();


        [OperationContract]
        void addCar(Car car);

        [OperationContract]
        void remuveCar(int license);

        [OperationContract]
        void updateCar(int Id, Car car);

        [OperationContract]
        List<Car> getAllCars();


        [OperationContract]
        void addRenting(Renting renting);

        [OperationContract]
        void removeRenting(Renting renting);

        [OperationContract]
        void updateRenting(Renting renting1, Renting renting2);

        [OperationContract]
        List<Renting> getAllRentings();


        [OperationContract]
        void addFault(Fault fault);

        [OperationContract]
        void removeFault(Fault fault);

        [OperationContract]
        void updateFault(Fault fault1, Fault fault2);

        [OperationContract]
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
    }
}

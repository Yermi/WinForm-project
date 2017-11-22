using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // list of functions which implements a data structure
    public interface idal
    {
        void addClient(Client client);
        void remuveClient(Client client);
        void updateClient(int Id, Client client);
        List<Client> getAllClients();

        void addCar(Car car);
        void remuveCar(Car car);
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
    }
}
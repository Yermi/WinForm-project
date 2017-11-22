using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataSource
    {
        public static List<Client> clientsList = new List<Client>();
        public static List<BE.Car> carList = new List<BE.Car>();
        public static List<BE.Renting> rentingsList = new List<BE.Renting>();
        public static List<BE.Fault> faultsList = new List<BE.Fault>();
    }
}

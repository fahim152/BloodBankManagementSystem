using BloodBank.Data;
using BloodBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core
{
    public class DonorsService
    {
        DonorsDataAccess donorsDataAccess = new DonorsDataAccess();

        public int Add(Donors donors)
        {
            return donorsDataAccess.Add(donors);
        }

        public int Remove(int id)
        {
            return donorsDataAccess.Remove(id);
        }

        public int Edit(Donors donors)
        {
            return donorsDataAccess.Edit(donors);
        }

        public List<Donors> GetAll()
        {
            return donorsDataAccess.GetAll();
        }

        public Donors GetById(int id)
        {
            return donorsDataAccess.GetById(id);
        }

        public bool SendDonorEmail(string donorEmail) {
            return donorsDataAccess.SendDonorEmail(donorEmail);
        }

    }
}

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

        public List<Donors> GetByName(string name)
        {
            return donorsDataAccess.GetByName(name);
        }

        public bool SendDonorEmail(string donorEmail) {
            return donorsDataAccess.SendDonorEmail(donorEmail);
        }

        public object RowCount()
        {
            return donorsDataAccess.RowCount();
        }

        public int ChangeStatus(Donors donors) {
            return donorsDataAccess.ChangeStatus(donors);
        }

        public List<Donors> getDonorListByDate(string firstDate, string secondDate) {
            return donorsDataAccess.getDonorListByDate(firstDate, secondDate);
        }

        public List<Donors> getDonorListByEmail(string email)
        {
            return donorsDataAccess.getDonorListByEmail(email);
        }

        public List<Donors> getDonorListByPhone(string phone)
        {
            return donorsDataAccess.getDonorListByPhone(phone);
        }

        public List<Donors> getDonorListByBloodGroup(string bloodGroup)
        {
            return donorsDataAccess.getDonorListByBloodGroup(bloodGroup);
        }

        public int resetDonorStatus(int id) {
            return donorsDataAccess.resetDonorStatus(id);
        }

        public int ResetDate(int id, string date) {
            return donorsDataAccess.ResetDate(id, date);
        }

    }
}

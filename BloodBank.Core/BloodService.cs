using BloodBank.Data;
using BloodBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core
{
    public class BloodService
    {
        BloodDataAccess bloodDataAccess = new BloodDataAccess();

        public int Add(Blood blood)
        {
            return bloodDataAccess.Add(blood);
        }

        public int Reduce(string bloodGroup)
        {
            return bloodDataAccess.Reduce(bloodGroup);
        }

        public List<Blood> GetAll()
        {
            return bloodDataAccess.GetAll();
        }

        public Blood GetByGroup(string bloodGroup)
        {
            return bloodDataAccess.GetByGroup(bloodGroup);
        }
    }
}

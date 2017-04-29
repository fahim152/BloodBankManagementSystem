using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Entity
{
    public class Blood
    {
        string bloodGroup;
        int quantity;

        public string BloodGroup
        {
            get
            {
                return bloodGroup;
            }

            set
            {
                bloodGroup = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}

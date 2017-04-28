using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Entity
{
    public class Blood
    {
        int id;
        string bloodGroup;
        int quantity;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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

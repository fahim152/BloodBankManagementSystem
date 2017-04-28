using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Entity
{
    public class Donors
    {
        int id;
        string name;
        string address;
        int age;
        string gender;
        string phone;
        string email;
        string bloodGroup;
        int weight;

        public int Id {
            set {this.id = value;}
            get {return id;}
        }

        public string Name {
            set { this.name = value; }
            get { return name; }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
    }
}

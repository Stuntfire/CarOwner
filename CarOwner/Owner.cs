using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarOwner
{
    public class Owner
    {
        /// <summary>
        /// Denne klasse laver en Bilejer, der skal indeholde et navn, adresse og telefonnummer.
        /// </summary>
        public string Address { get; private set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public List<Car> CarList { get; set; }

        public Owner(string adr, string name, string phone)
        {
            if (adr.Length < 6)
            {
                throw new ArgumentOutOfRangeException("Adressen skal være længere end 6 tegn.");
            }
            else
            {
                this.Address = adr; // overvej hvad der sker hvis adr ændres til 2 tegn efterfølgende...
            }

            if (name.Length < 4)
            {
                throw new ArgumentOutOfRangeException("Navn skal være længere end 4 tegn.");
            }
            else
            {
                this.Name = name;
            }

            if (!(phone.Length == 8))
            {
                throw new ArgumentOutOfRangeException("Telefonnummer skal være på præcis 8 tegn.");
            }
            if (phone.All(char.IsLetter))
            {
                throw new FormatException("Telefonnummer må ikke bestå af bogstaver.");
            }
            else
            {
                this.Phone = phone;
            }

            CarList = new List<Car>();
        }


        public string TjekAdresse()
        {
            string temp = Address;

            if (Address.Length < 6)
            {
                throw new ArgumentOutOfRangeException("Adressen skal være længere end 6 tegn.");
            }
            return temp;
        }

        public string TjekNavn()
        {
            string temp = Name;
            if (Name.Length < 4)
            {
                throw new ArgumentOutOfRangeException("Navn skal være længere end 4 tegn.");
            }
            return temp;
        }

        public string TjekTelefon()
        {
            string temp = Phone;
            if (Phone.All(char.IsLetter))
            {
                throw new FormatException("Telefonnummer må ikke bestå af bogstaver.");
            }
            if (!(Phone.Length == 8))
            {
                throw new ArgumentOutOfRangeException("Telefonnummer skal bestå af 8 tal.");
            }
            return temp;
        }
    }
}

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
        private string address;
        public string Address
        {
            get { return address; }
            private set {
                if (value.Length <= 6)
                {
                    throw new AddressException("Adressen skal være længere end 6 tegn.");
                }
                address = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set {
                if (value.Length <= 4)
                {
                    throw new NameException("Navn skal være længere end 4 tegn.");
                }
                name = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set {
                if (!(value.Length == 8))
                {
                    throw new PhoneException("Telefonnummer skal være på præcis 8 tegn.");
                }
                if (value.All(char.IsLetter))
                {
                    throw new PhoneException("Telefonnummer må ikke bestå af bogstaver.");
                }
                phone = value; }
        }

        public List<Car> CarList { get; set; }

        //Owner-klassens Constructor
        public Owner(string a, string n, string p)
        {
            this.Address = a;
            this.Name = n;
            this.Phone = p;

            //CarList = new List<Car>();
        }

        //metode der tjekker om adressen er kortere end 6 tegn.
        public string TjekAdresse()
        {
            if (!(Address.Length <= 6))
            {
                return Address;
            }
            else
            {
                throw new AddressException("Adressen skal være længere end 6 tegn.");
            }
        }

        //metode der tjekker om navnet er kortere end 4 tegn.
        public string TjekNavn()
        {
            if (!(Name.Length <= 4))
            {
                return Name;
            }
            else
            {
                throw new NameException("Navn skal være længere end 4 tegn.");
            }
        }

        //metode der tjekker om telefonnummeret indeholder bogstaver og/eller er præcis 8 tegn.
        public string TjekTelefon()
        {
            if (Phone.Any(char.IsLetter))
            {
                throw new PhoneException("Telefonnummer må ikke bestå af bogstaver.");
            }
            if (!(Phone.Length == 8))
            {
                throw new PhoneException("Telefonnummer skal bestå af 8 tal.");
            }
            return Phone;
        }
    }
}

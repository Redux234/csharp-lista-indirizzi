using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public abstract class Indirizzo
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zip;


        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            if(name == "")
            {
                throw new ArgumentOutOfRangeException("name", "uno dei nomi non è stato identificato");
            }
            else
            {
                this.name = name;
            }
           
            if(surname == "")
            {
                throw new ArgumentOutOfRangeException("suranme", "un cognome non è stato identificato");

            }
            else
            {
                this.surname = surname;
            }
        
            if(street == "")
            {
                throw new ArgumentOutOfRangeException("street", "una via non è stata identificata");

            }else
            {
                this.street = street;
            }
            
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetStreet()
        {
            return street;
        }
        public string Getcity()
        {
            return city;
        }
        public string Getprovince()
        {
            return province;
        }
        public string GetZip()
        {
            return zip;
        }

        public void SetName(string name)
        {
            if (name == "")
            {
                this.name = "";
            }
            else
            {
                this.name = name;
            }
        }
        public void SetSurname(string surname)
        {
            if (surname == "")
            {
                throw new ArgumentOutOfRangeException("suranme", "un cognome non è stato identificato");

            }
            else
            {
                this.surname = surname;
            }
        }
        public void SetStreet(string street)
        {
            if (street == "")
            {
                throw new ArgumentOutOfRangeException("street", "una via non è stata identificata");

            }
            else
            {
                this.street = street;
            }
        }
        public void SetProvince(string province)
        {
            this.province = province;
        }
        public void SetZip(string zip)
        {
            this.zip = zip;
        }

        public void StampaIndirizzo()
        {
            Console.WriteLine("Nome: " + this.name);
            Console.WriteLine("Cognome: " + this.surname);
            Console.WriteLine("Via: " + this.street);
            Console.WriteLine("Città: " + this.city);
            Console.WriteLine("Provincia di " + this.province);
            Console.WriteLine("Cap: " + this.zip);
  


        }
    }
}

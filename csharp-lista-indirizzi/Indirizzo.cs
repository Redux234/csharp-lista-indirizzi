using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zip;


        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
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
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetStreet(string street)
        {
            this.street = street;
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

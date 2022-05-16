using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        private int code;
        public int Code 
        { 
            get 
            {
                return code;
            }
            
        }
        private string name;
        public string Name 
        {
            get
            { 
                return name;
            }

            set
            {
                if (value.Length <= 0)
                    Console.WriteLine("Insert a valid name");
                else
                    name = value;
            }
        }
        private string description;
        public string Description {
            get
            {
                return description;
            }
            set
            {
                if (value.Length < 10)
                    throw new Exception("Please enter a longer description");
                else
                    description = value;    
            }
        }
        private double price;
        public double Price {
            get
            { 
                return price;
            }
            set 
            {
                if (double.IsNaN(value) || value <= 0)
                   throw new Exception("The price is Invalid");
                else
                    price = value;
            }
        }
        private double iva;
        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        private static Random random = new Random();

        public Product(string nome, string descrizione, double prezzo, double iva)
        {
            //random = new Random();
            code = random.Next(0, 100000);
            this.Name = nome;
            this.Description = descrizione;
            this.Price = prezzo;
            this.Iva = iva;
            
        }


        public double IvatoPrice()
        {
            double newPrice;
            double pIva = (this.Price* this.Iva)/100;
            return newPrice = this.Price + pIva;
        }

        public string codeName()
        {
            string slug = this.Name + this.Code;
            return slug;
        }

       

        
        public string codeLenght(int num)
        {
            string conv = num.ToString();
            int lenght = conv.Length;

            if (lenght < 8)
            {
                string tot = "";
                for (int i = 0; i < 8 - lenght; i++)
                {
                    string subS = "0";
                    tot += subS;
                }

                string totSubstring = tot + conv;
                return totSubstring;
            }
            else {
                return num.ToString();
            }

            
;        }
        
    }
}

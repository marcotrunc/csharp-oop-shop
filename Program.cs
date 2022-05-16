using csharp_oop_shop;
using System;

namespace csharp_es03_mattina 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Console.WriteLine(ran.Next(0, 10));
            try
            {
                Product prod1 = new Product("prodotto uno", "des del prod", 7.77, 10);
                Console.WriteLine("Codice: {0}", prod1.Code);
                Console.WriteLine("Nome: {0}", prod1.Name);
                Console.WriteLine("Descrizione: {0}", prod1.Description);
                Console.WriteLine(prod1.IvatoPrice());
                Console.WriteLine(prod1.codeName());
                Console.WriteLine(prod1.codeLenght(prod1.Code));
            }
            catch (Exception ex) { 
                // Fai qualcosa
            }
            
             
        }
    }
}

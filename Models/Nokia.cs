using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(modelo, imei, memoria)
        {
            Numero = numero;
        }
        
        public override void InstalarApp(string nome)
        {
            Console.WriteLine($"Instalando { nome } no Nokia. ");
        }
    }
}
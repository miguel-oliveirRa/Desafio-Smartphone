using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Smartphone
    {
        public Smartphone(string modelo, string imei, int memoria)
        {
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria; 
        }
        public string Numero { get; set; }
        private string _modelo;

        private string Modelo
        {
            get => _modelo;

            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Modelo não pode ser vazio.");
                }
                _modelo = value;
            }    
        }

        private string _imei;

        private string Imei
        {
            get => _imei;

            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Imei não pode ser vazio.");
                }
                _imei = value;
            } 
        }

        private int _memoria;

        private int Memoria
        {
            get => _memoria;

            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Memoria não pode ser vazia, igual a 0 ou menor que 0.");
                }
                _memoria = value;
            }   
        }

        public void Infos()
        {
            Console.WriteLine($"Numero: { Numero }, Modelo: { Modelo }, Imei: { Imei }, Memoria { Memoria }");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void RecebendoLigacao()
        {
            Console.WriteLine("Recabendo ligação...");
        } 

        public abstract void InstalarApp(string nome);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftVentas.Models
{
    class Auto
    {
        ///atributos
        public string modelo { get; set; }
        public int cantidadPuertas { get; set; }
        public int cantidadRuedas { get; set; }
        public int cantidadVentanas { get; set; }


        ///metodos 
        public void encenderAuto()
        {
            Console.WriteLine("El auto está encendido");
        }
        public Auto() { }
        public Auto(string modelo, int cantidadPuertas, int cantidadRuedas, int cantidadVentanas)
        {
            this.modelo = modelo;
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadVentanas = cantidadVentanas;
        }
    }
}

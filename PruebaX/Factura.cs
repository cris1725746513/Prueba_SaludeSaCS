using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Factura
    {
        private  List<entity> listOfStrings = new List<entity>();
        private float total;
        private float iva;
        private float totaldescuento;
        private float subtotal;
        public void cargar(entity entity)
        {
            listOfStrings.Add(entity);
            Console.WriteLine("Producto agregado");
        }

        
        public void calculos()
        {
            totaldescuento = 0;
            subtotal = 0;
            foreach (entity e  in listOfStrings)
            {
                totaldescuento += e.Desc;
                subtotal += e.Total;
            }
            iva = (12 * subtotal)/100; // mas iva
       //     iva = (float)(1.12 / subtotal);// incluye iva
            total = subtotal + iva;

        }
        public void mostrar()
        {
            Console.WriteLine("|Cantidad \tDetalle \tPvu \tDesc  \tTotal |");
            foreach (entity e in listOfStrings)
            {
                Console.WriteLine("| "+e.Cantidad + "\t   " + e.Detalle+ "\t    " + e.Pvu+ "\t   " + e.Desc+ "\t   "  + e.Total+" |");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Subtotal : " + subtotal);
            Console.WriteLine("Descuento :" + totaldescuento);
            Console.WriteLine("IVA : " + iva);
            Console.WriteLine("Total : " + total);
        }

        public int verificarIn(string x )
        {
            bool esNumero;
            if (!int.TryParse(x, out _))
            {
                do
                {
                    Console.WriteLine("Ingrese un valor valido");
                    x = Console.ReadLine();
                    esNumero = int.TryParse(x, out _);
                }
                while (!esNumero);
            }
          return  Int32.Parse(x);

        }
        public float verificarF(string x)
        {
           
            bool esNumero;
            if (!decimal.TryParse(x, out _))
            {
                do
                {
                    Console.WriteLine("Ingrese un valor valido");
                    x = Console.ReadLine();
                    esNumero = decimal.TryParse(x, out _);

                }
                while (!esNumero);
            }
            return (float)Convert.ToDouble(x);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class ControllerFactura
    {
        public void Ejecutar()
        {
            entity entity;
            Factura factura = new();
            string s;
            do
            {


                entity = new entity();
                Console.WriteLine("INGRESE LA CANTIDAD");
                entity.Cantidad = factura.verificarIn(Console.ReadLine());
                Console.WriteLine("INGRESE EL DETALLE DEL PRODUCTO");
                entity.Detalle = Console.ReadLine();
                Console.WriteLine("INGRESE EL PVP");
                entity.Pvu = factura.verificarF(Console.ReadLine());
                Console.WriteLine("INGRESE EL DESCUENTO");
                entity.Desc = factura.verificarF(Console.ReadLine());
                entity.Total = (entity.Pvu * entity.Cantidad) - entity.Desc;
                factura.cargar(entity);
                Console.WriteLine("¿Desea agregar mas productos? -> S = salir");
                s = Console.ReadLine();
                Console.Clear();

            } while (s.ToUpper() != "S");

            factura.calculos();
            factura.mostrar();
        
    }

    }
}

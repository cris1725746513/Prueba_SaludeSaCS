using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class entity
    {
        private int cantidad;
        private string detalle;
        private float pvu;
        private float desc;
        private float total;


        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        public float Pvu
        {
            get { return pvu; }
            set { pvu = value; }
        }
        public float Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

    }
}

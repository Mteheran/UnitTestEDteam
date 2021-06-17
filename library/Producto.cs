using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class Producto
    {
        public string Nombre {get;set;}
        public string Descripcion { get;set;}
        public decimal Precio {get;set;}

        public string FullDescripcion 
        {
            get { return Nombre + " - " + Descripcion; }
        }
        
        public decimal Impuesto 
        {
            get { return Precio * Convert.ToDecimal(0.19); }
        }
    }
}
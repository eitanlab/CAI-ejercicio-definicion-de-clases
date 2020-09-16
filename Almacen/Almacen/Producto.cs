using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    class Producto
    {
        private string _nombre;
        private int _precio;
        private int _stock;
    
        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public int precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        public int stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }

        public void sumarStock(int nuevaCantidad)
        {
            stock += nuevaCantidad;
        }

        public void vender(int cantidadVendida)
        {
            if(cantidadVendida <= stock)
            {
                stock -= cantidadVendida;
            }
        }
    }
}

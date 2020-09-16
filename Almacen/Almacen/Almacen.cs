using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    class Almacen
    {
        private List<string> _productos;
        private List<string> _proveedores;
        private int _facturacion;

        public Almacen ()
        {
            productos = new List<string>();
            proveedores = new List<string>();
            facturacion = 0;
        }
        public List<string> productos
        {
            get
            {
                return _productos;
            }
            set
            {
                _productos = value;
            }
        }
        public List<string> proveedores
        {
            get
            {
                return _proveedores;
            }
            set
            {
                _proveedores = value;
            }
        }
        public int facturacion
        {
            get
            {
                return _facturacion;
            }
            set
            {
                _facturacion = value;
            }
        }
        public void agregarProducto (string nombreProducto)
        {
            productos.Add(nombreProducto);
        }
        public void ingresarVenta(int valorVenta)
        {
            facturacion += valorVenta;
        }

    }
}

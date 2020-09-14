using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class Restaurant
    {
        private int _horarioApertura;
        private int _horarioCierre;
        private int _cantidadMesas;
        private List<string> _menu;
        private List<string> _empleados;
        private bool _abierto;

        public Restaurant(int horaApertura, int horaCierre, int mesas, bool restaurantAbierto)
        {
            horarioApertura = horaApertura;
            horarioCierre = horaCierre;
            cantidadMesas = mesas;
            menu = new List<string>();
            empleados = new List<string>();
            abierto = restaurantAbierto;
        }
        public int horarioApertura
        {
            get
            {
                return this._horarioApertura;
            }
            set
            {
                this._horarioApertura = value;
            }
        }
        public int horarioCierre
        {
            get
            {
                return this._horarioCierre;
            }
            set
            {
                this._horarioCierre = value;
            }
        }
        public int cantidadMesas
        {
            get
            {
                return this._cantidadMesas;
            }
            set
            {
                this._cantidadMesas = value;
            }
        }
        public List<string> menu
        {
            get
            {
                return this._menu;
            }
            set
            {
                this._menu = value;
            }
        }
        public List<string> empleados
        {
            get
            {
                return this._empleados;
            }
            set
            {
                this._empleados = value;
            }
        }
        public bool abierto
        {
            get
            {
                return this._abierto;
            }
            set
            {
                this._abierto = value;
            }
        }

        public void agregarMesa()
        {
            cantidadMesas += 1;
        }
        public bool quitarMesa()
        {
            if (cantidadMesas > 0)
            {
                cantidadMesas -= 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void agregarEmpleado(string nombreEmpleado)
        {
            empleados.Add(nombreEmpleado);
        }
        public bool quitarEmpleado(string nombreEmpleado)
        {
            return empleados.Remove(nombreEmpleado);
        }
    }
}

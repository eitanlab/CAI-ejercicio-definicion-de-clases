using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Veterinaria
    {
        private string _nombre;
        private List<string> _medicamentos;
        private List<string> _pacientes;
        private int _maxPacientes;
        private int _pacientesRecuperados;
        private int _pacientesMuertos;

        public Veterinaria(string nombreVeterinaria,int capacidad)
        {
            nombre = nombreVeterinaria;
            pacientes = new List<string>();
            medicamentos = new List<string>();
            maxPacientes = capacidad;
            pacientesMuertos = 0;
            pacientesRecuperados = 0;
        }
        public string nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        public List<string> medicamentos
        {
            get
            {
                return this._medicamentos;
            }
            set
            {
                this._medicamentos = value;
            }
        }
        public List<string> pacientes
        {
            get
            {
                return this._pacientes;
            }
            set
            {
                this._pacientes = value;
            }
        }
        public int maxPacientes
        {
            get
            {
                return this._maxPacientes;
            }
            set
            {
                this._maxPacientes = value;
            }
        }
        public int pacientesRecuperados
        {
            get
            {
                return this._pacientesRecuperados;
            }
            set
            {
                this._pacientesRecuperados = value;
            }
        }
        public int pacientesMuertos
        {
            get
            {
                return this._pacientesMuertos;
            }
            set
            {
                this._pacientesMuertos = value;
            }
        }
        public bool agregarPaciente(string nombrePaciente)
        {
            if(pacientes.Count < maxPacientes)
            {
                pacientes.Add(nombrePaciente);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string operarPaciente(string nombrePaciente)
        {
            if(pacientes.Contains(nombrePaciente))
            {
                Random number = new Random();
                bool sobrevive = number.Next(100) <= 50;
                if (sobrevive)
                {
                    pacientesRecuperados++;
                    pacientes.Remove(nombrePaciente);
                    return "El paciente se ha curado";
                }
                else
                {
                    pacientesMuertos++;
                    pacientes.Remove(nombrePaciente);
                    return "El paciente ha muerto";
                }
            } else
            {
                return "El paciente ingresado no existe";
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograIISebastianCastro
{
    internal class ClsEmpleado
    {
        

        public string cedula { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public double salario { get; set; }


        public ClsEmpleado(string cedula, string nombre, string direccion, string telefono, double salario)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.salario = salario;
        }


    }
}

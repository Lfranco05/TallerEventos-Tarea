using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEventos.Clases
{
    internal class Tarea
    {
        public string Nombre { get; set; }
        public string Estado { get; set; }

        public readonly DateTime FechaCreacion;

        public Tarea(string nombre, string estado)
        {
            this.FechaCreacion = DateTime.Now;
            this.Nombre = nombre;
            this.Estado = estado;
        }
    }
}

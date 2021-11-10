using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.dominio
{
     public class DetalleCarrera
    {

        public int idDetalleCarrera { get; set; }
        public string AnioCursado { get; set; }
        public string Cuatrimestre { get; set; }
        public Asignatura Materia { get; set; }
        public Carrera Carrera { get; set; }

        public DetalleCarrera()
        {
            Materia = new Asignatura();           
        }

    }
}

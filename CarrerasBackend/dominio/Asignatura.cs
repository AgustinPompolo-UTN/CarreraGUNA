using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.dominio
{
    public class Asignatura : Object

    {
        public int idAsignatura { get; set; }
        public string Nombre { get; set; }

        public Asignatura()
        { 
       
        }

        public override string ToString()
        {

            return idAsignatura.ToString() + "-" + Nombre;

        }
    
    }

   
}

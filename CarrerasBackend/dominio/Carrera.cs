using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.dominio
{
        public class Carrera
    {
        public int idCarrera { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }

        public List<DetalleCarrera> Detalles { get; }

        public Carrera()
        {
            //generar la relación 1 a muchos
            Detalles = new List<DetalleCarrera>();
        }

        public void AgregarMateria(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }


        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }
    }
}

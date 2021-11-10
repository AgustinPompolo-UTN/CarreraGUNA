using CarrerasBackend.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.servicios
{
        public interface IService
        {
        bool BorrarDetalle(int nro);

        List<Asignatura> ConsultarMaterias();

        List<Carrera> ConsultarCarreras();

        bool GrabarCarrera(Carrera oCarrera);

        List<DetalleCarrera> DetalleCarrerasById(int id);

        Carrera ObtenerCarreraPorId(int id);
        


    }
}

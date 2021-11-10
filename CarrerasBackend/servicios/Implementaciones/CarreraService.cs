using CarrerasBackend.acceso_a_datos.Implementaciones;
using CarrerasBackend.acceso_a_datos.Interfaces;
using CarrerasBackend.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.servicios
{
        class CarreraService : IService
        {
        private ICarreraDao dao;

        public CarreraService()
        {
            dao = new CarreraDao();
        }

        public bool BorrarDetalle(int nro)
        {
            return dao.Delete(nro);
        }

        public List<Asignatura> ConsultarMaterias()
        {
            return dao.GetMaterias();
        }

        public List<Carrera> ConsultarCarreras()
        {
            return dao.GetCarreras();
        }

        public bool GrabarCarrera(Carrera oCarrera)
        {
            return dao.Save(oCarrera);
        }

        public Carrera ObtenerCarreraPorId(int id)
        {
            return dao.GetById(id);
        }

        public List<DetalleCarrera> DetalleCarrerasById(int id)
        {
            return dao.GetDetalleCarrerasById(id);
        }
    }
}

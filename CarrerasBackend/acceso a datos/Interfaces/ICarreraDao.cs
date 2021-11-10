using CarrerasBackend.dominio;
using CarrerasBackend.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.acceso_a_datos.Interfaces
{
    interface ICarreraDao
    {
        bool Delete(int nro);
        List<Asignatura> GetMaterias();
        List<Carrera> GetCarreras();
        bool Save(Carrera oCarrera);
        Carrera GetById(int id);
        List<DetalleCarrera> GetDetalleCarrerasById(int id);

    }
}

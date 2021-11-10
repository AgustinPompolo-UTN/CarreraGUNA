using CarrerasBackend.acceso_a_datos.Interfaces;
using CarrerasBackend.dominio;
using CarrerasBackend.servicios;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.acceso_a_datos.Implementaciones
{
    class CarreraDao : ICarreraDao
    {
        private string strConexion = @"Data Source=EMILY\SQLEXPRESS;Initial Catalog=carrera_db;Integrated Security=True";
        public bool Delete(int nro)
        {
            SqlConnection cnn = new SqlConnection(strConexion);
            SqlTransaction t = null;
            int affected = 0;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_BAJA_CARRERA", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@carrera_nro", nro);
                affected = cmd.ExecuteNonQuery();
                t.Commit();

            }
            catch (SqlException)
            {
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return affected == 1;
        }
        public List<Asignatura> GetMaterias()
        {

            List<Asignatura> lst = new List<Asignatura>();
            SqlConnection cnn = new SqlConnection(strConexion);
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("SP_CONSULTAR_MATERIAS", cnn);

            cmd2.CommandType = CommandType.StoredProcedure;

            DataTable table = new DataTable();
            table.Load(cmd2.ExecuteReader());

            cnn.Close();

            foreach (DataRow row in table.Rows)
            {
                Asignatura oAsignatura = new Asignatura();
                oAsignatura.idAsignatura = Convert.ToInt32(row["id_asignatura"].ToString());
                oAsignatura.Nombre = row["nombre"].ToString();
               

                lst.Add(oAsignatura);
            }

            return lst;

        }


        public List<DetalleCarrera> GetDetalleCarrerasById(int id)
        {
            List<DetalleCarrera> lst = new List<DetalleCarrera>();
            SqlConnection cnn = new SqlConnection(strConexion);
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("SP_CONSULTAR_DETALLE_POR_ID", cnn);
            
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@nro", id);
            DataTable table = new DataTable();
            table.Load(cmd2.ExecuteReader());

            cnn.Close();

            foreach (DataRow row in table.Rows)
            {
                DetalleCarrera oDetalleCarrera = new DetalleCarrera();
                oDetalleCarrera.idDetalleCarrera = Convert.ToInt32(row["id_detalle_carrera"].ToString());
                oDetalleCarrera.Materia.idAsignatura= Convert.ToInt32(row["materia"].ToString());
                oDetalleCarrera.Materia.Nombre = row["nombre"].ToString();
                oDetalleCarrera.AnioCursado = row["anioCursado"].ToString();
                oDetalleCarrera.Cuatrimestre = row["cuatrimestre"].ToString();

                lst.Add(oDetalleCarrera);
            }

            return lst;
        }

        public List<Carrera> GetCarreras()
        {
            List<Carrera> lstCarreras = new List<Carrera>();
            SqlConnection cnn = new SqlConnection(strConexion);
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("SP_CONSULTAR_CARRERAS", cnn);

            cmd2.CommandType = CommandType.StoredProcedure;

            DataTable table = new DataTable();
            table.Load(cmd2.ExecuteReader());

            cnn.Close();

            foreach (DataRow row in table.Rows)
            {
                Carrera oCarrera = new Carrera();
                oCarrera.idCarrera = Convert.ToInt32(row["id_carrera"].ToString());
                oCarrera.Nombre = row["nombre"].ToString();
                oCarrera.Titulo = row["titulo"].ToString();

                lstCarreras.Add(oCarrera);
            }

            return lstCarreras;
        }

        public bool Save(Carrera oCarrera)
        {

            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(strConexion);

            bool flag = true;
            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_MAESTRO", cnn, transaccion); //Inserto en la tabla Carrera
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@nombre", oCarrera.Nombre);
                cmdMaestro.Parameters.AddWithValue("@titulo", oCarrera.Titulo);
                 
                //VER

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id_carrera"; //Me devuelve el id de carrera para cargarlo
                param.SqlDbType = SqlDbType.Int;

                param.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(param);
                cmdMaestro.ExecuteNonQuery();

                oCarrera.idCarrera = (int)param.Value;
                
                int nroDetalle = 0;

                foreach (DetalleCarrera det in oCarrera.Detalles)
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERTAR_DETALLE", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaccion;                  
                    cmd.Parameters.AddWithValue("@materia ", det.Materia.idAsignatura);
                    cmd.Parameters.AddWithValue("@id_carrera", oCarrera.idCarrera);
                    cmd.Parameters.AddWithValue("@anioCursado", det.AnioCursado);
                    cmd.Parameters.AddWithValue("@cuatrimestre", det.Cuatrimestre);

                    SqlParameter pa = new SqlParameter();
                    pa.ParameterName = "@id_carrera"; //Me devuelve el id de carrera para cargarlo
                    pa.SqlDbType = SqlDbType.Int;

                    pa.Direction = ParameterDirection.Output;
                    cmdMaestro.Parameters.Add(pa);
                    cmdMaestro.ExecuteNonQuery();

                    det.idDetalleCarrera = (int)pa.Value;

                    cmd.ExecuteNonQuery();
                }

                transaccion.Commit();

            }
            catch
            {
                transaccion.Rollback();
                flag = false;

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return flag;

        

    }
        public Carrera GetById(int id)
        {

            Carrera oCarrera = new Carrera();
            SqlConnection cnn = new SqlConnection(strConexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CONSULTAR_CARRERA_POR_ID";
            cmd.Parameters.AddWithValue("@nro", id);
            SqlDataReader reader = cmd.ExecuteReader();
            bool esPrimerRegistro = true;

            while (reader.Read())
            {               
                DetalleCarrera oDetalle = new DetalleCarrera();
                Asignatura oAsignatura = new Asignatura();
                oAsignatura.idAsignatura = Convert.ToInt32(reader["id_asignatura"].ToString());
                oAsignatura.Nombre = reader["nombre"].ToString();
                
                esPrimerRegistro = false;
                oCarrera.AgregarMateria(oDetalle);
            }
            return oCarrera;

        }


    }
}



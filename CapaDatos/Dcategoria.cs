using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Dcategoria
    {
        /*Declaracion de campo a variable */
        private int _Idcategoria;
        private string _Nombre;
        private string _Descripcion;

        /*Variable para buscar por texto (nombre)*/
        private string _TextBuscar;

        /*Encapsulamiento de la variable*/
        public int Idcategoria
        {
            get { return _Idcategoria; }
            set { _Idcategoria = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public string Textbuscar
        {
            get { return _TextBuscar; }
            set { _TextBuscar = value; }
        }

        //Cnostructor Vacio
        public Dcategoria()
        {

        }

        //Constructor con parametro
        public Dcategoria(int idcategoria, string nombre, string descripcion, string textbuscar)
        {
            this.Idcategoria = idcategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Textbuscar = textbuscar;
        }

        //Metodos Insetar
        public string Insertar(Dcategoria Categoria)
        {
            string rpta = "";
            SqlConnection Sqlcon = new SqlConnection(); // instancias
            try
            {
                // Codigo insertar registro categoria
                Sqlcon.ConnectionString = Conexion.Cn; // conectar conla clase conexion
                Sqlcon.Open();//abrir conexion

                // establecer el comando. a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Sqlcon;
                SqlCmd.CommandText = "psinsertar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //parametro que resibe
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); //cerrar conexion
            }
            return rpta;
        }
        //Metodo editar
        public string Editar(Dcategoria Categoria)
        {
            string rpta = "";
            SqlConnection Sqlcon = new SqlConnection(); // instancias
            try
            {
                // Codigo insertar registro categoria
                Sqlcon.ConnectionString = Conexion.Cn; // conectar conla clase conexion
                Sqlcon.Open();//abrir conexion

                // establecer el comando. a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Sqlcon;
                SqlCmd.CommandText = "speditar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //parametro que resibe
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizo el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); //cerrar conexion
            }
            return rpta;
        }
        //Metodo Eliminar
        public string Eliminar(Dcategoria Categoria)
        {
            string rpta = "";
            SqlConnection Sqlcon = new SqlConnection(); // instancias
            try
            {
                // Codigo insertar registro categoria
                Sqlcon.ConnectionString = Conexion.Cn; // conectar conla clase conexion
                Sqlcon.Open();//abrir conexion

                // establecer el comando. a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Sqlcon;
                SqlCmd.CommandText = "speliminar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //parametro que resibe
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);


                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); //cerrar conexion
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.CommandText = "spmostrar_categoria";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Busqueda avanzada 
        public DataTable BuscarNombre(Dcategoria Categoria)
        {
            DataTable DtResultado = new DataTable("Categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.CommandText = "spbuscar_categoria";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter PartextoBuscar = new SqlParameter();
                PartextoBuscar.ParameterName = "@textobuscar";
                PartextoBuscar.SqlDbType = SqlDbType.VarChar;
                PartextoBuscar.Size = 50;
                PartextoBuscar.Value = Categoria.Textbuscar;
                Sqlcmd.Parameters.Add(PartextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}

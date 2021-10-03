using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NCategoria
    {
        /* Metodo insertar que llama al metodo insertar de la capadatos
         * De la clase Dcategoria
         */
        public static string Insertar (string nombre, string descripcion)
        {
            Dcategoria Obj = new Dcategoria();

            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;

            return Obj.Insertar(Obj);
        }
        /* Metodo editar que llama al metodo editar de la capadatos
        * De la clase Dcategoria
        */
        public static string Editar (int idcategoria, string nombre, string descripcion)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;

            return Obj.Editar(Obj);
        }
        /* Metodo eliminar que llama al metodo eliminar de la capadatos
        * De la clase Dcategoria
        */
        public static string Eliminar(int idcategoria)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Eliminar(Obj);
        }

        /* Metodo Mostrar que llama al metodo Mostrar de la capadatos
        * De la clase Dcategoria
         */

        public static DataTable Mostrar()
        {
            return new Dcategoria() .Mostrar();
        }

        /* Metodo BuscarNombew que llama al metodo BuscarNombre de la capadatos
        * De la clase Dcategoria
         */
        public static DataTable BuscarNombre(string buscartexto)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.Textbuscar = buscartexto;
            return Obj.BuscarNombre(Obj);
        }
    }

}

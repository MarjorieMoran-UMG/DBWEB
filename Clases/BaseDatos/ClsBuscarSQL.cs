using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Web1Mamn.Clases.BaseDatos
{
    public class ClsBuscarSQL
    {
        public DataTable CargarDatosDB(string condicion = "1=1")
        {
            ClsConexion cn = new ClsConexion();
            DataTable dt = new DataTable();
            string sentencia = $"select * from tb_estudiantes1 where {condicion}";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;
        }
    }
}
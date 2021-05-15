using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web1Mamn.Clases.archivos;
using Web1Mamn.Clases.BaseDatos;

namespace Web1Mamn
{
    public partial class frminicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarArchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Desktop\crudDB.csv";
            ClsArchivo ar = new ClsArchivo();
            ClsConexion cnSQL = new ClsConexion();
            ClsConexionMysql cnMYSQL = new ClsConexionMysql();
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia = "";
            int NumeroLinea = 0;

            foreach (string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(';');
                if (NumeroLinea > 0)
                {
                    sentencia += $"insert into tb_estudiantes1 values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;
            cnSQL.EjecutaSQLDirecto(sentencia);
            cnMYSQL.EjecutaMYSQLDirecto(sentencia);
        }

        protected void ButtonCargaDatos_Click(object sender, EventArgs e)
        {
            cargarArchivoExterno();
        }

        protected void ButtonBuscarID_Click(object sender, EventArgs e)
        {
            ClsBuscarSQL bs = new ClsBuscarSQL();
            string id = TextBoxID.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt =bs.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<String>("nombre");
                TextBoxResultadoSQL.Text = nombre;
            } else
            {
                TextBoxResultadoSQL.Text = "No hay Información";
            }
        }

        protected void ButtonBuscarporNombre_Click(object sender, EventArgs e)
        {
            ClsBuscarSQL bs = new ClsBuscarSQL();
            string nombre = TextBoxNombre.Text.Trim();
            string condicion = $"nombre like ('%{nombre}%')";
            DataTable dt = bs.CargarDatosDB(condicion);
            
            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<Int32>("correlativo");
                TextBoxResultadoSQL.Text = id + "";
            }
            else
            {
                TextBoxResultadoSQL.Text = "No hay Información";
            }
        }

        protected void ButtonIDMySql_Click(object sender, EventArgs e)
        {
            ClsBuscarMySQL bs = new ClsBuscarMySQL();
            string id = TextBoxIDMySql.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = bs.CargardatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<String>("nombre");
                TextBoxResultadoMySql.Text = nombre;
            }
            else
            {
                TextBoxResultadoMySql.Text = "No hay Información";
            }
        }

        protected void ButtonBuscarporNombreMySql_Click(object sender, EventArgs e)
        {
            ClsBuscarMySQL bs = new ClsBuscarMySQL();
            string nombre = TextBoxNombreMySql.Text.Trim();
            string condicion = $"nombre like ('%{nombre}%')";
            DataTable dt = bs.CargardatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<Int32>("correlativo");
                TextBoxResultadoMySql.Text = id + "";
            }
            else
            {
                TextBoxResultadoMySql.Text = "No hay Información";
            }
        }
    }
}
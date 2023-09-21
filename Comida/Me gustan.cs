using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;


namespace Comida
{
    class Me_gustan
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;
        public Me_gustan()
        {
            

            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=DEMO.mdb");
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Megustan";

            adaptador.Fill(tabla);
        }

        public DataTable getData()
        {
            return tabla;
        }
    }
}

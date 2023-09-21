using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida
{
    public partial class Form1 : Form
    {
        Me_gustan Omegustan;
        DataTable tmegus;
        Comida Ocomida;
        DataTable tcomida;
        Personas Opersonas;
        DataTable tper;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opersonas = new Personas();
            tper = Opersonas.getData();

            Ocomida = new Comida();
            tcomida = Ocomida.getData();

            Omegustan = new Me_gustan();
            tmegus = Omegustan.getData();

            cboPersona.DisplayMember = "nombre";
            cboPersona.ValueMember = "dni";
            cboPersona.DataSource = tper;
        }

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(DataRow fGus in tmegus.Rows)
            {
                if (fGus["dni"].ToString() == cboPersona.SelectedValue.ToString())
                {
                    DataRow fCom = tcomida.Rows.Find(fGus["comida"]);
                    dataGridView1.Rows.Add(fCom["comida"], fCom["nombre"]);
                }
            }
        }
    }
}

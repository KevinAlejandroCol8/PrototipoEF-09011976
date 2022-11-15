using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaNomina
{
    public partial class EncabezadoNomina : Form
    {
        public EncabezadoNomina()
        {
            InitializeComponent();
            comboBox1.Items.Add("MENSUAL");
            comboBox1.Items.Add("QUINCENAL");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6106";
            TextBox[] Grupotextbox = { pk_id_nomina, fechaPago_nomina, tipoPago_nomina, mesPagado_nomina, anioPagado_nomina, total_nomina};
            TextBox[] Idtextbox = { pk_id_nomina, fechaPago_nomina };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_encabezadonominas;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_encabezadonominas, Grupotextbox, "colchoneria");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("MENSUAL"))
            {
                tipoPago_nomina.Text = "1";
            }
            if (comboBox1.SelectedItem.ToString().Equals("QUINCENAL"))
            {
                tipoPago_nomina.Text = "2";
            }
        }
    }
}

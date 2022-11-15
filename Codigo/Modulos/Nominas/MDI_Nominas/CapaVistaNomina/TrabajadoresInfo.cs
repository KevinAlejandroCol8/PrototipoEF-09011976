using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorNomina;

namespace CapaVistaNomina
{
    public partial class TrabajadoresInfo : Form
    {
        Controlador cn = new Controlador();
        string emp = "tbl_usuarios";

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dataGridTrabajador.DataSource = dt;

        }
        public TrabajadoresInfo()
        {
            InitializeComponent();
        }

        private void TrabajadoresInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarTrabajador b = new AgregarTrabajador();
            b.Show();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6001";
            TextBox[] Grupotextbox = { txtIDtrabajador, txtfechaAlta, txtnomTrab, txtemailTrab, txtdireccionTrab, txttelefonoTrab, txtestado };
            TextBox[] Idtextbox = { txtIDtrabajador, txtfechaAlta, txtnomTrab, txtemailTrab, txtdireccionTrab, txttelefonoTrab, txtestado };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridTrabajador;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridTrabajador, Grupotextbox, "colchoneria");
        }
    }
}

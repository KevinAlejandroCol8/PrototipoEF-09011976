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
    public partial class DepartamentoExam : Form
    {
        public DepartamentoExam()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6001";
            TextBox[] Grupotextbox = { txt1, txt2, txt3 };
            TextBox[] Idtextbox = { txt1, txt2, txt3};
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridHrsExtra;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridHrsExtra, Grupotextbox, "PrototipoEF-09011976");
        }
    }
}

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
    public partial class EmpleadosExam : Form
    {
        string table = "tbl_empleados";
        int cont = 1;

        Controlador cn = new Controlador();
        public EmpleadosExam()
        {
            InitializeComponent();
        }

        public void getId()
        {
            try
            {
                string dato;
                dato = ListaDatos.CurrentRow.Cells[0].Value.ToString();
                txtCadenas2.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el valor");
            }
        }

        public void getIds()
        {
            try
            {
                string dato;
                dato = ListaDatos.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el valor");
            }
        }

        public void actualizardatagriew()
        {
            cn.llenarListEmpleados(ListaAsignacion.Tag.ToString(), ListaAsignacion);
        }

        public void limpiar()
        {
            textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; txtCadenas2.Text = ""; textBox1.Text = "";
        }

        private void EmpleadosExam_Load(object sender, EventArgs e)
        {
            cn.llenarListPuestos(ListaDatos.Tag.ToString(), ListaDatos);
            cn.llenarListEmpleados(ListaAsignacion.Tag.ToString(), ListaAsignacion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont = 1;
            ListaDatos.Columns.Clear();
            cn.llenarListPuestos(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cont = 2;
            ListaDatos.Columns.Clear();
            cn.llenarListDepartamentos(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void ListaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cont == 1)
            {
                getId();
            }
            else if (cont == 2)
            {
                getIds();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox2, textBox3, textBox4, txtCadenas2, textBox1 };
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            actualizardatagriew();
            limpiar();
            MessageBox.Show(message);
        }
    }
}

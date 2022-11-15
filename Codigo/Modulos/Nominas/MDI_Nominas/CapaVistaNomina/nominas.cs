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
    public partial class nominas : Form
    {
        string table = "tbl_detalleNominas";
        int cont = 1;

        Controlador cn = new Controlador();
        public nominas()
        {
            InitializeComponent();
        }

        public void getId()
        {
            try
            {
                string dato;
                dato = ListaDatos.CurrentRow.Cells[0].Value.ToString();
                txtCadenas1.Text = dato;
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
                dato = ListaDatos.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el valor");
            }
        }

        public void calculo()
        {
            int horasExtra = Int32.Parse(textBox4.Text);
            int Persepciones = Int32.Parse(textBox3.Text);
            int Deduciones = Int32.Parse(textBox5.Text);
            int saliro = Int32.Parse(textBox2.Text);

            int suma = saliro + horasExtra + Persepciones - Deduciones;
            textBox6.Text = suma.ToString();
        }

        public void actualizardatagriew()
        {
            string id = txtCadenas1.Text;
            cn.llenarListAsignaciones(ListaAsignacion.Tag.ToString(), ListaAsignacion, id);
        }

        public void limpiar()
        {
            textBox1.Text = "";
            txtCadenas1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cont = 1;
            ListaDatos.Columns.Clear();
            cn.llenarListTrabajadores(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void nominas_Load(object sender, EventArgs e)
        {
            textBox6.Visible = false;
            label2.Visible = false;
            cn.llenarListTrabajadores(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void ListaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cont == 1)
            {
                //Metodo que lleva valor Unico
                getId();
            }
            else if (cont == 2)
            {
                //Metodo que lleva valor con coma 1,2,3
                getIds();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo();
            TextBox[] textbox = { textBox1, txtCadenas1, textBox2 , textBox3 , textBox5 , textBox4 , textBox6 };
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            actualizardatagriew();
            limpiar();
            MessageBox.Show(message);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cont = 2;
            ListaDatos.Columns.Clear();
            cn.llenarListContratos(ListaDatos.Tag.ToString(), ListaDatos);
            //tbl_contrato
        }
    }
}

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
    public partial class PrestacionesIndividuales : Form
    {
        Controlador cn = new Controlador();

        string table = "tbl_prestacionesindividuales";
        int cont = 1;
        public PrestacionesIndividuales()
        {
            InitializeComponent();
        }

        public void getId()
        {
            try
            {
                string dato;
                dato = ListaDatos.CurrentRow.Cells[0].Value.ToString();
                txtPuesto.Text = dato;
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
                txtTrabajador.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el valor");
            }
        }

        public void obtenerMes()
        {
            string mes = comboBox1.Text;
            if (mes == "Enero ")
            {
                txtMes.Text = "1";
            }
            if (mes == "Febrero ")
            {
                txtMes.Text = "2";
            }
            if (mes == "Marzo ")
            {
                txtMes.Text = "3";
            }
            if (mes == "Abril ")
            {
                txtMes.Text = "4";
            }
            if (mes == "Mayo ")
            {
                txtMes.Text = "5";
            }
            if (mes == "Junio ")
            {
                txtMes.Text = "6";
            }
            if (mes == "Julio ")
            {
                txtMes.Text = "7";
            }
            if (mes == "Agosto ")
            {
                txtMes.Text = "8";
            }
            if (mes == "Septiembre ")
            {
                txtMes.Text = "9";
            }
            if (mes == "Octubre ")
            {
                txtMes.Text = "10";
            }
            if (mes == "Noviembre ")
            {
                txtMes.Text = "11";
            }
            if (mes == "Diciembre ")
            {
                txtMes.Text = "12";
            }
            //textBox1.Text = mes;
        }

        public void limpiar()
        {
            txtMes.Text = "";
            txtCantidad.Text = "";
            txtPuesto.Text = "";
            txtTrabajador.Text = "";
        }

        public void actualizardatagriew()
        {
            //string id = txtPuesto.Text;
            cn.llenarListas(ListaPrestaciones.Tag.ToString(), ListaPrestaciones);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            cont = 1;
            ListaDatos.Columns.Clear();
            cn.llenarListPuestos(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont = 2;
            ListaDatos.Columns.Clear();
            cn.llenarListTrabajadores2(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void PrestacionesIndividuales_Load(object sender, EventArgs e)
        {
            cn.llenarListPuestos(ListaDatos.Tag.ToString(), ListaDatos);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerMes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] textbox = { txtMes, txtCantidad, txtPuesto, txtTrabajador };
                cn.ingresar(textbox, table);
                string message = "Registro Guardado";
                actualizardatagriew();
                limpiar();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }
    }
}

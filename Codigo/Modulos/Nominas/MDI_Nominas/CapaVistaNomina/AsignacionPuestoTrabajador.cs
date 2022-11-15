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
    public partial class AsignacionPuestoTrabajador : Form
    {
        string table = "tbl_asignacion_puestotrabajador";
        int cont = 1;

        Controlador cn = new Controlador();
        public AsignacionPuestoTrabajador()
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
                dato = ListaDatos.CurrentRow.Cells[0].Value.ToString();
                if (txtCadenas2.Text == "")
                {
                    txtCadenas2.Text = dato;
                }
                else
                {
                    string valor = txtCadenas2.Text;
                    txtCadenas2.Text = valor + "," + dato;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }

        public void actualizardatagriew()
        {
            string id = txtCadenas1.Text;
            cn.llenarListAsignaciones(ListaAsignacion.Tag.ToString(), ListaAsignacion, id);
        }

        public void limpiar()
        {
            txtCadenas1.Text = "";
            txtCadenas2.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',' };
            string text = txtCadenas2.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                txtTrabajador.Text = word;
                TextBox[] textbox = { txtCadenas1, txtTrabajador };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            actualizardatagriew();
            limpiar();
            MessageBox.Show(message);
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

        private void button3_Click(object sender, EventArgs e)
        {
            cont = 1;
            ListaDatos.Columns.Clear();
            cn.llenarListPuestos2(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont = 2;
            ListaDatos.Columns.Clear();
            cn.llenarListTrabajadores(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCadenas1.Text == "")
            {
                string message = "Campo ID Puesto sin dato";
                MessageBox.Show(message);
            }
            else
            {
                actualizardatagriew();
                //limpiar();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            RepAsigPuestoTrab b = new RepAsigPuestoTrab();
            // b.MdiParent = this;
            b.Show();
            //pictureBox1.Visible = false;
            //hideSubMenu();
        }

        private void AsignacionPuestoTrabajador_Load(object sender, EventArgs e)
        {
            txtTrabajador.Visible = false;
            cn.llenarListPuestos2(ListaDatos.Tag.ToString(), ListaDatos);
        }
    }
}

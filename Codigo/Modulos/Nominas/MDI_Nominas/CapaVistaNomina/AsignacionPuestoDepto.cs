using CapaControladorNomina;
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
    public partial class AsignacionPuestoDepto : Form
    {
        string table = "tbl_asignacion_puestodepartamento";
        int cont = 1;

        Controlador cn = new Controlador();

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

        public AsignacionPuestoDepto()
        {
            InitializeComponent();
        }

        private void AsignacionPuestoDepto_Load(object sender, EventArgs e)
        {
            txtDepartamento.Visible = false;
            cn.llenarListPuestos(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void ListaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cont == 1)
            {
                //Metodo que lleva valor Unico
                 getId();
            }else if (cont == 2)
            {
                //Metodo que lleva valor con coma 1,2,3
                getIds();
            }
            
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
            cn.llenarListDepartamentos(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',' };
            string text = txtCadenas2.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                txtDepartamento.Text = word;
                TextBox[] textbox = { txtCadenas1, txtDepartamento};
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            actualizardatagriew();
            limpiar();
            MessageBox.Show(message);
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void ListaAsignacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                String dato1 = ListaAsignacion.CurrentRow.Cells[0].Value.ToString();
                String dato2 = ListaAsignacion.CurrentRow.Cells[2].Value.ToString();

                int campo1 = int.Parse(dato1);
                string condicion1 = txtCadenas1.Tag.ToString();
                int campo2 = int.Parse(dato2);
                string condicion2 = txtDepartamento.Tag.ToString();
                cn.eliminarAsiganaciones(table, condicion1, campo1, condicion2, campo2);
                //listAplicacionPerfil.Columns.Clear();
                string id = txtCadenas1.Text;
                cn.llenarListAsignaciones(ListaAsignacion.Tag.ToString(), ListaAsignacion, id);
            }
            else
            {
                limpiar();
            }
        }

    }
}

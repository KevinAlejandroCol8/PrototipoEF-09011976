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
    public partial class PagoNomina : Form
    {
        CapaControladorNomina.Controlador controladorNomina = new CapaControladorNomina.Controlador();
        public PagoNomina()
        {
            InitializeComponent();
            pk_id_departamentos.Items.Add("TODOS");
            controladorNomina.selectNominas(pk_id_nomina);
            controladorNomina.selectDepartamentos(pk_id_departamentos);
            tbl_trabajador.DataSource = controladorNomina.llenarTbl("tbl_trabajador");
            pk_id_departamentos.Enabled = false;
        }

        private void pk_id_departamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pk_id_departamentos.SelectedItem.ToString().Equals("TODOS"))
            {
                tbl_trabajador.DataSource = controladorNomina.llenarTbl("tbl_trabajador");
            }
            else
            {
                string id = controladorNomina.queryIdDepto(pk_id_departamentos.SelectedItem.ToString());
                tbl_trabajador.DataSource = controladorNomina.selectCTrabajadores(id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float totalNomina = 0;
            if (txtCadenas.Text.Length != 0 && pk_id_departamentos.Text != null)
            {
                foreach (DataGridViewRow fila in tbl_trabajador.Rows)
                {
                    DataGridViewCell columna1 = fila.Cells[0];
                    string idContrato = controladorNomina.queryContratoTrabajador(columna1.Value.ToString());
                    float salario = idContrato != null ? float.Parse(controladorNomina.querySalarioContrato(idContrato)) : 0;
                    float deducciones = 0;
                    float prestaciones = 0;
                    float total = 0;
                    Boolean tipo = false;
                    if (salario > 0)
                    {
                        string[] cantidades = controladorNomina.selectPercepcionesContrato(idContrato);
                        if (cantidades.Length != 0)
                        {
                            for (int i = 0; i < cantidades.Length; i = i + 3)
                            {
                                if (cantidades[i].Equals("1"))
                                {
                                    tipo = true;
                                }
                                if (tipo)
                                {
                                    float temp = 0;
                                    if (float.Parse(cantidades[i + 1]) > 0)
                                    {
                                        temp = salario * float.Parse(cantidades[i + 1]);
                                    }
                                    else
                                    {
                                        temp = float.Parse(cantidades[i + 2]);
                                    }
                                    prestaciones = prestaciones + temp;
                                }
                                else
                                {
                                    float temp = 0;
                                    if (float.Parse(cantidades[i + 1]) > 0)
                                    {
                                        temp = salario * float.Parse(cantidades[i + 1]);
                                    }
                                    else
                                    {
                                        temp = float.Parse(cantidades[i + 2]);
                                    }
                                    deducciones = deducciones + temp;
                                }
                                total = salario + prestaciones - deducciones;
                            }
                        }
                        controladorNomina.pagarTrabajador(pk_id_nomina.Text.ToString() + "," + columna1.Value.ToString() + "," + salario + "," + 0 + "," + prestaciones + "," + deducciones + "," + total);
                        totalNomina += total;
                    }
                }
                tbl_detallenominas.DataSource = controladorNomina.llenarTablaQuery("tbl_detallenominas", "pk_id_nomina=" + pk_id_nomina.Text);
                controladorNomina.actualizarNomina(pk_id_nomina.Text.ToString(), totalNomina);
            }
            pk_id_departamentos.Enabled = false;
            pk_id_nomina.Items.Clear();
            pk_id_nomina.Enabled = true;
            txtCadenas.Text = "";
            controladorNomina.selectNominas(pk_id_nomina);
        }

        private void btn_buscarContrato_Click(object sender, EventArgs e)
        {
            tbl_detallenominas.DataSource = new DataTable();
            tbl_detallenominas.DataSource = controladorNomina.llenarTablaQuery("tbl_detallenominas", "pk_id_nomina="+pk_id_nomina.Text);
            txtCadenas.Text = controladorNomina.queryTotalNomian(pk_id_nomina.Text.ToString());
            pk_id_nomina.Enabled = false;
            pk_id_departamentos.Enabled = true;
        }
    }
}

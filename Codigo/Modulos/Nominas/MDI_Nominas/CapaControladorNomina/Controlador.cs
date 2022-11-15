using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModuloNomina;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.IO;

namespace CapaControladorNomina
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTablaQuery(string tabla, string clausulas)
        {
            OdbcDataAdapter dt = sn.llenarTblCustom(tabla, clausulas);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public void selectContratos(ComboBox combobox)
        {
            string campos = "pk_id_contrato, estado_contrato";
            string tabla = "tbl_contrato";
            string[] data = sn.Select(campos, tabla);

            if (data.Length > 0)
            {
                for (int i = 0; i < data.Length; i = i + 2)
                {
                    if (data[i + 1].Equals("1"))
                    {
                        combobox.Items.Add(data[i]);
                    }
                }
            }
        }

        public void selectDepartamentos(ComboBox combobox)
        {
            string campos = "nombre_departamento, estado_departamento";
            string tabla = "tbl_departamentos";
            string[] data = sn.Select(campos, tabla);

            if (data.Length > 0)
            {
                for (int i = 0; i < data.Length; i = i + 2)
                {
                    if (data[i + 1].Equals("1"))
                    {
                        combobox.Items.Add(data[i]);
                    }
                }
            }
        }

        public void selectNominas(ComboBox combobox)
        {
            string campos = "pk_id_nomina, total_nomina";
            string tabla = "tbl_encabezadonominas";
            string[] data = sn.Select(campos, tabla);

            if (data.Length > 0)
            {
                for (int i = 0; i < data.Length; i = i + 2)
                {
                    if (float.Parse(data[i + 1]) == 0)
                    {
                        combobox.Items.Add(data[i]);
                    }
                }
            }
        }

        public string selectTotalNomina(string idNomina)
        {
            string campos = "total_nomina";
            string tabla = "tbl_encabezadonominas";
            string clausula = "pk_id_nomina = " + idNomina;
            string[] data = sn.Query(campos, tabla, clausula);

            if (data.Length > 0)
            {
                return data[0];
            }
            return "";
        }


        public string queryIdDepto(string nombreDepto)
        {
            string campos = "pk_id_departamento";
            string tabla = "tbl_departamentos";
            string clausula = "nombre_departamento = '" + nombreDepto + "'";
            string[] data = sn.Query(campos, tabla, clausula);

            return data[0];
        }

        public DataTable selectCTrabajadores(string idDepto)
        {
            string tabla = "tbl_trabajador, tbl_asignacion_puestotrabajador, tbl_asignacion_puestodepartamento";
            string clausulas = "tbl_trabajador.pk_id_trabajador = tbl_asignacion_puestotrabajador.fk_id_trabajador " +
                " AND tbl_asignacion_puestotrabajador.fk_id_puesto = tbl_asignacion_puestodepartamento.fk_id_puesto" +
                " AND tbl_asignacion_puestodepartamento.fk_id_departamento = " + idDepto;
            OdbcDataAdapter dt = sn.llenarTblCustom(tabla, clausulas);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public string queryContratoTrabajador(string idTrabajador)
        {
            string campos = "fk_id_contrato";
            string tabla = "tbl_asignacion_contratotrabajador";
            string clausula = "fk_id_trabajador = " + idTrabajador;
            string[] data = sn.Query(campos, tabla, clausula);

            if (data.Length > 0)
            {
                return data[0];
            }
            return "";
        }

        public string querySalarioContrato(string idContrato)
        {
            string campos = "salario_contrato";
            string tabla = "tbl_contrato";
            string clausula = "pk_id_contrato = " + idContrato;
            string[] data = sn.Query(campos, tabla, clausula);

            if (data.Length > 0)
            {
                return data[0];
            }
            return "";
        }

        public string[] selectPercepcionesContrato(string Contrato)
        {
            string campos = "tipo_prestdeduc,porcentaje_prestdeduc,valorFijo_prestdeduc";
            string tabla = "tbl_percepciones, tbl_asignacion_contratopercepciones, tbl_asignacion_contratotrabajador";
            string clausula = "tbl_percepciones.pk_id_prestdeduc = tbl_asignacion_contratopercepciones.fk_id_prestdeduc" +
                " AND tbl_asignacion_contratopercepciones.fk_id_contrato = " + Contrato + " group by tbl_asignacion_contratopercepciones.fk_id_prestdeduc; ";
            string[] data = sn.SelectCustom(campos, tabla, clausula);

            return data;
        }

        public void queryContrato(string idContrato, TextBox[] textboxs)
        {
            string campos = "salario_contrato";
            string tabla = "tbl_contrato";
            string clausula = "pk_id_contrato = " + idContrato;
            string[] data = sn.Query(campos, tabla, clausula);

            if (data.Length > 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    textboxs[i].Text = data[i];
                }
            }
        }

        public string queryTotalNomian(string idNomina)
        {
            string campos = "total_nomina";
            string tabla = "tbl_encabezadonominas";
            string clausula = "pk_id_nomina = " + idNomina;
            string[] data = sn.Query(campos, tabla, clausula);
            return data.Length > 0 ? data[0] : "error en obtener el total de la nomina";
        }

        public void actualizarNomina(string idNomina, float total)
        {
            sn.Update("total_nomina="+total, "tbl_encabezadonominas", "pk_id_nomina="+idNomina);
        }

        public void asignarContratoPercepcion(string datos)
        {
            string campos = "fk_id_contrato, fk_id_prestdeduc";
            string tabla = "tbl_asignacion_contratopercepciones";
            if (!sn.Insert(campos, tabla, datos))
            {
                MessageBox.Show("NO SE PUDO REGISTRAR LA ASIGNACIÓN");
            }
        }

        public void pagarTrabajador(string datos)
        {
            string campos = "`pk_id_nomina`, `fk_id_trabajador`, `salario_nomina`, `totalHorasExtras_nomina`, `totalPercepciones_nomina`, `totalDeducciones_nomina`, `liquidez_nomina`";
            string tabla = "tbl_detallenominas";
            if (!sn.Insert(campos, tabla, datos))
            {
                MessageBox.Show("NO SE PUDO REGISTRAR LA ASIGNACIÓN");
            }
        }


        public void mostrarReporte(Form forma, string url)
        {
            try
            {
                Help.ShowHelpIndex(forma, Path.GetFullPath("..\\..\\..\\..\\..\\..\\..\\Ayuda\\Modulos\\Nominas\\" + url));
            }
            catch
            {
                MessageBox.Show("NO SE PUEDE CARGAR LA AYUDA");
            }
        }

        public Boolean validarRegistro(string contrato, string percepcion)
        {
            Boolean respuesta = false;
            string tabla = "tbl_asignacion_contratopercepciones";
            string clausula = "fk_id_contrato=" + contrato + " AND fk_id_prestdeduc=" + percepcion;

            respuesta = sn.CountQuery(tabla, clausula) == 0 ? true : false;

            return respuesta;
        }

        public Boolean validarReporte(string idApp)
        {
            Boolean respuesta = false;
            string tabla = "tbl_regreporteria";
            string clausula = "aplicacion='" + idApp + "' AND estado='Visible'";
            respuesta = sn.CountQuery(tabla, clausula) > 0 ? true : false;
            return respuesta;
        }
        public string buscarPathReporte(string idApp)
        {
            string path = "";
            string campos = "ruta";
            string tabla = "tbl_regreporteria";
            string clausula = "aplicacion='" + idApp + "'";
            string[] data = sn.Query(campos, tabla, clausula);
            return path = data[0];
        }

        public void eliminarContratoPercepcion(string contrato, string percepcion)
        {
            string tabla = "tbl_asignacion_contratopercepciones";
            string clausula = "fk_id_contrato=" + contrato + " AND fk_id_prestdeduc=" + percepcion;
            if (!sn.Delete(tabla, clausula))
            {
                MessageBox.Show("NO SE PUDO ELIMINADA LA ASIGNACIÓN");
            }
        }

        public void EditarTabla(string[] columnas, int[] tamaño, DataGridView tabla)//LEONEL DOMINGUEZ
        {
            for (int i = 0; i < tabla.ColumnCount; i++)
            {
                tabla.Columns[i].HeaderText = columnas[i];
                tabla.Columns[i].Width = tamaño[i];
                tabla.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            tabla.RowHeadersVisible = false;
        }

        public void llenarListPuestos(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaPuesto(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListas(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListas(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListDepartamentos(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaDepartamentos(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListPuestos2(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaPuesto2(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListTrabajadores(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaTrabajador(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListContrato(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaContratos(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListTrabajadores2(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaTrabajador2(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListContratos(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListContratos(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void ingresar(TextBox[] textbox, string tabla)
        {
            string dato = " ";
            string tipo = " ";

            for (int x = 0; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += "'" + textbox[x].Text + "'";
                    tipo += textbox[x].Tag.ToString();
                }
                else
                {
                    dato += "'" + textbox[x].Text + "',";
                    tipo += textbox[x].Tag.ToString() + ",";
                }

            }
            sn.insertar(dato, tipo, tabla);
        }

        public void llenarListAsignaciones(string ntabla, DataGridView tabla, string id)
        {
            OdbcDataAdapter dt = sn.llenarListaAsignaciones(ntabla, id);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void eliminarAsiganaciones(string tabla, string condicion1, int campo1, string condicion2, int campo2)
        {
            try
            {
                sn.eliminarAsiganaciones(tabla, condicion1, campo1, condicion2, campo2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar por permisos asignados");
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }

    }
}

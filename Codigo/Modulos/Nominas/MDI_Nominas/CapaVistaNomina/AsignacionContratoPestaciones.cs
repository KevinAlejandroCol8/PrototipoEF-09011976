using System;
using System.Windows.Forms;

namespace CapaVistaNomina
{
    public partial class AsignacionContratoPestaciones : Form
    {
        CapaControladorNomina.Controlador controladorNomina = new CapaControladorNomina.Controlador();
        Seguridad_Controlador.Controlador controladorSeguridad = new Seguridad_Controlador.Controlador();
        public AsignacionContratoPestaciones()
        {
            InitializeComponent();
            asignarPermisos();
            txt_idContrato.Items.Add("Seleccione una opcion...");
            controladorNomina.selectContratos(txt_idContrato);
            //LLENAMOS LA TABLA DE PERCEPCIONES CON LAS PERCEPCIONES QUE TENGAN UN ESTADO DE DISPONIBLE
            tbl_percepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_percepciones", "estado_prestdeduc = " + 1);
            diseñoTabla();
            this.Name = "ASIGNACIÓN DE PERCEPCIOENS A CONTRATO";
        }

        private void diseñoTabla()
        {
            //FUNCIÓN QUE LE DA DISEÑO A LA TABLA DE PERCEPCIONES EDITANDO TITULO DE LA TABLA Y TAMAÑO DE CELDA
            string[] columnas = { "ID", "NOMBRE", "TIPO", "PORCENTAJE", "CANTIDAD FIJA", "ESTADO" };
            int[] tamanio = { 40, 250, 50, 100, 100, 65 };
            controladorNomina.EditarTabla(columnas, tamanio, tbl_percepciones);
        }
        private void diseñoTabla2()
        {
            //FUNCIÓN QUE LE DA DISEÑO A LA TABLA DE ASIGNACIÓN CONTRATO A PERCEPCIÓN EDITANDO TITULO DE LA TABLA Y TAMAÑO DE CELDA
            string[] columnas = { "ID CONTRATO", "ID PERCEPCION" };
            int[] tamanio = { 100, 100 };
            controladorNomina.EditarTabla(columnas, tamanio, tbl_asignacion_contratopercepciones);
        }
        private void asignarPermisos()
        {
            //FUNCIÓN QUE VALIDA LOS PERMISOS QUE TIENE EL USUARIO CONE ESTA APLICACIÓN
            btn_buscarContrato.Enabled = false;
            btn_asignarUU.Enabled = false;
            btn_asignarUT.Enabled = false;
            btn_quitarUU.Enabled = false;
            btn_quitarUT.Enabled = false;
            btn_Reporte.Enabled = false;

            int[] permisos = controladorSeguridad.getPermisosAplicaion("6104");
            if (permisos[0] == 1)//Guardar
            {
                btn_buscarContrato.Enabled = true;
                btn_asignarUU.Enabled = true;
                btn_asignarUT.Enabled = true;
            }
            if (permisos[1] == 1)//Modifcar
            {

            }
            if (permisos[2] == 1)//Eliminar
            {
                btn_buscarContrato.Enabled = true;
                btn_quitarUU.Enabled = true;
                btn_quitarUT.Enabled = true;
            }
            if (permisos[3] == 1)//Consultar
            {
                btn_buscarContrato.Enabled = true;
            }
            if (permisos[4] == 1)//Reportes
            {
                btn_Reporte.Enabled = true;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            /* 
             * BOTON ASIGNADO PARA BUSCAR EL CONTRATO SELECCIÓNADO Y MOSTRAR EL SUELDO Y MOSTRAR SI YA HAY
             * PERCEPCIONES YA ASIGNADAS A DICHO CONTRATO 
            */
            TextBox[] textboxs = { txtCadenas };
            if (txt_idContrato.SelectedIndex > 0)
            {
                controladorNomina.queryContrato(txt_idContrato.Text, textboxs);
                tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                diseñoTabla2();
                controladorSeguridad.setBtitacora("6104", "BUSCAR ASGN PERCEP-CONTRATO");
                txt_idContrato.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* 
             * BOTÓN QUE SE UTILIZA PARA ASIGNAR LA PERCEPCION SELECCIONADA EN LA TABLA DE PERCEPCIONES Y VALIDA QUE
             * DICHA PERCEPCIÓN NO ESTE YA ASIGNADA DE LO CONTRARIÓ DEVUELVE UN AVISO AL USUARIO 
             */ 
            if (txtCadenas.Text.Length != 0)
            {
                if (tbl_percepciones.RowCount > 0)
                {
                    if (controladorNomina.validarRegistro(txt_idContrato.Text, tbl_percepciones.CurrentRow.Cells[0].Value.ToString()))
                    {
                        controladorNomina.asignarContratoPercepcion(txt_idContrato.Text + "," + tbl_percepciones.CurrentRow.Cells[0].Value.ToString());
                        tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                        diseñoTabla2(); 
                        controladorSeguridad.setBtitacora("6104", "ASGN 1:1 PERCEP-CONTRATO");
                    }
                    else
                    {
                        MessageBox.Show("ASIGNACIÓN YA EXISTE");
                    }
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios, seleccione un contrato");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* 
             * BOTÓN QUE SE UTILIZA PARA ELIMINAR TODAS LAS PERCEPCIONES EN LA TABLA DE ASIGNACIÓN PERCEPCION A CONTRATO
             * ASIGNADAS AL CONTRATO SELECCIÓNADO EN EL COMBOBOX
             */
            if (txtCadenas.Text.Length != 0)
            {
                if (tbl_asignacion_contratopercepciones.RowCount > 0)
                {
                    controladorNomina.eliminarContratoPercepcion(txt_idContrato.Text, tbl_asignacion_contratopercepciones.CurrentRow.Cells[1].Value.ToString());
                    tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                    diseñoTabla2();
                    controladorSeguridad.setBtitacora("6104", "DES-ASGN N:1 PERCEP-CONTRATO");
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios, seleccione un contrato");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /* 
             * BOTÓN QUE NOS AYUDA A LIMPIAR LOS CAMPOS Y NOS PERMITE HABILITAR EL COMBOBOX DE CONTRATO PARA ELEGIR OTRO
             */
            txt_idContrato.Enabled = true;
            txtCadenas.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 
             * BOTÓN QUE SE UTILIZA PARA ASIGNAR TODAS LAS PERCEPCIONES EN LA TABLA DE PERCEPCIONES AL CONTRATO SELECCIONADO
             * Y SI ENCUENTRA UN PERCEPCION YA ASIGNADA LO OMITE Y SIGUE CON LA SIGUIENTE
             */
            if (txtCadenas.Text.Length != 0)
            {
                foreach (DataGridViewRow fila in tbl_percepciones.Rows)
                {
                    DataGridViewCell columna1 = fila.Cells[0];
                    if (controladorNomina.validarRegistro(txt_idContrato.Text, columna1.Value.ToString()))
                    {
                        controladorNomina.asignarContratoPercepcion(txt_idContrato.Text + "," + columna1.Value.ToString());
                        tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                        diseñoTabla2();
                        controladorSeguridad.setBtitacora("6104", "ASGN N:1 PERCEP-CONTRATO");
                    }
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios, seleccione un contrato");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* 
             * BOTÓN QUE SE UTILIZA PARA ELIMINAR LA ASIGNACIÓN SELECCIONADA EN LA TABLA DE ASIGNACIÓN PERCEPCIONES A CONTRATO
            */
            if (txtCadenas.Text.Length != 0)
            {
                foreach (DataGridViewRow fila in tbl_asignacion_contratopercepciones.Rows)
                {
                    DataGridViewCell columna1 = fila.Cells[1];
                    controladorNomina.eliminarContratoPercepcion(txt_idContrato.Text, columna1.Value.ToString());
                }
                tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                diseñoTabla2(); 
                controladorSeguridad.setBtitacora("6104", "DES-ASIGN 1:1 PERCEP-CONTRATO");
            }
            else
            {
                MessageBox.Show("Existen campos vacios, seleccione un contrato");
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            /* 
             * BOTÓN QUE SE UTILIZA PARA MOSTRAR EL REPORTE ASOCIADO AL CODIGO DE DICHA APLICACIÓN
             * HACIENDO UNA CONSULTA A LA TABLA DE REPORTES Y OBTENIENDO EL PATH PARA BUSCAR EL REPORTE EN EL DIRECTORIO DE REPORTES
            */
            if (controladorNomina.validarReporte("6104"))
            {
                string path = controladorNomina.buscarPathReporte("6104");
                //CapaVistaReporteria.visualizar b = new CapaVistaReporteria.visualizar(path);
                //b.Show();
                controladorSeguridad.setBtitacora("6104", "REPORTE ASN PERCEP-CONTRATO");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             *  FUNCIÓN QUE NOS MUESTRA LA AYUDA (.CHM) EN UNA NUEVA VENTANA EMERGENTE 
             */
            controladorNomina.mostrarReporte(this, "asg_percepcionescontrato.chm");
        }
    }
}

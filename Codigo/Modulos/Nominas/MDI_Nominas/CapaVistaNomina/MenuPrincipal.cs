﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public MenuPrincipal()
        {
            InitializeComponent();
            customizeDesing();

            Button[] apps = { btnTrabajadores, btnPuestos, btnDepto,btnSegNomina,btnInfo};
            cnseg.deshabilitarApps(apps);

            cnseg.getAccesoApp(6001, apps[0]);
            cnseg.getAccesoApp(6002, apps[1]);
            cnseg.getAccesoApp(6003, apps[2]);
            cnseg.getAccesoApp(6004, apps[3]);
            cnseg.getAccesoApp(6005, apps[4]);
            /*cnseg.getAccesoApp(6006, apps[5]);
            cnseg.getAccesoApp(6007, apps[6]);

            cnseg.getAccesoApp(6101, apps[7]);
            cnseg.getAccesoApp(6102, apps[8]);
            cnseg.getAccesoApp(6103, apps[9]);
            cnseg.getAccesoApp(6104, apps[10]);
            cnseg.getAccesoApp(6105, apps[11]);
            cnseg.getAccesoApp(6106, apps[12]);

            cnseg.getAccesoApp(6201, apps[13]);
            cnseg.getAccesoApp(6202, apps[14]);
            cnseg.getAccesoApp(6203, apps[15]);

            cnseg.getAccesoApp(6301, apps[16]);
            cnseg.getAccesoApp(6401, apps[17]);

            cnseg.getAccesoApp(6009, apps[18]);*/

        }

        private void customizeDesing()
        {
            panelCatalogos.Visible = false;
            panelProcesos.Visible = false;
            panelReportes.Visible = false;
            panelSeguridad.Visible = false;
            panelAyuda.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelCatalogos.Visible == true)
                panelCatalogos.Visible = false;
            if (panelProcesos.Visible == true)
                panelProcesos.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
            if (panelSeguridad.Visible == true)
                panelSeguridad.Visible = false; 
            if (panelAyuda.Visible == true)
                panelAyuda.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCatalogos);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProcesos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAyuda);
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            //TrabajadoresInfo b = new TrabajadoresInfo();
            EmpleadosExam b = new EmpleadosExam();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            //PuestosTrabajo b = new PuestosTrabajo();
            PuestosExam b = new PuestosExam();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnDepto_Click(object sender, EventArgs e)
        {
            //Departamentos b = new Departamentos();
            DepartamentoExam b = new DepartamentoExam();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPres_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHorasX_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            
        }

        private void btnFaltas_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            
        }

        private void btnAsPuestoDepto_Click(object sender, EventArgs e)
        {
            //AsignacionPuestoDepto b = new AsignacionPuestoDepto();
            EmpleadosExam b = new EmpleadosExam();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnAsPuestoTrab_Click(object sender, EventArgs e)
        {
            AsignacionPuestoTrabajador b = new AsignacionPuestoTrabajador();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnAsContratoTrab_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAsContratoPres_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPercyDeduc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            /*nominas b = new nominas();*/
            EncabezadoNomina b = new EncabezadoNomina();
            PagoNomina c = new PagoNomina();
            b.MdiParent = this;
            b.Show();
            c.MdiParent = this;
            c.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnRplanilla_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRcontrato_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bntRtrabajador_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSegNomina_Click(object sender, EventArgs e)
        {
            Vista_Seguridad.Bitacora b = new Vista_Seguridad.Bitacora();
            //BitacoraNomina b = new BitacoraNomina();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            AyudaInfo b = new AyudaInfo();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnPrestacionesIndividuales_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}


namespace CapaVistaNomina
{
    partial class AsignacionPuestoDepto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListaDatos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCadenas2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ListaAsignacion = new System.Windows.Forms.DataGridView();
            this.txtCadenas1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDatos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAsignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 82);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiganación de Puestos a Departamentos";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ListaDatos);
            this.panel3.Location = new System.Drawing.Point(566, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 358);
            this.panel3.TabIndex = 11;
            // 
            // ListaDatos
            // 
            this.ListaDatos.AllowUserToAddRows = false;
            this.ListaDatos.AllowUserToDeleteRows = false;
            this.ListaDatos.AllowUserToResizeColumns = false;
            this.ListaDatos.AllowUserToResizeRows = false;
            this.ListaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDatos.Location = new System.Drawing.Point(16, 19);
            this.ListaDatos.MultiSelect = false;
            this.ListaDatos.Name = "ListaDatos";
            this.ListaDatos.ReadOnly = true;
            this.ListaDatos.RowHeadersVisible = false;
            this.ListaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListaDatos.ShowEditingIcon = false;
            this.ListaDatos.Size = new System.Drawing.Size(314, 320);
            this.ListaDatos.TabIndex = 0;
            this.ListaDatos.Tag = "tbl_puestosdetrabajo";
            this.ListaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDatos_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtCadenas2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDepartamento);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ListaAsignacion);
            this.panel2.Controls.Add(this.txtCadenas1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(22, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 358);
            this.panel2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 49;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCadenas2
            // 
            this.txtCadenas2.Location = new System.Drawing.Point(121, 89);
            this.txtCadenas2.Name = "txtCadenas2";
            this.txtCadenas2.Size = new System.Drawing.Size(174, 20);
            this.txtCadenas2.TabIndex = 48;
            this.txtCadenas2.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(301, 90);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(32, 20);
            this.txtDepartamento.TabIndex = 47;
            this.txtDepartamento.Tag = "fk_id_departamento";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button4.Location = new System.Drawing.Point(404, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 32);
            this.button4.TabIndex = 45;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 44;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button1.Location = new System.Drawing.Point(404, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaAsignacion
            // 
            this.ListaAsignacion.AllowUserToAddRows = false;
            this.ListaAsignacion.AllowUserToDeleteRows = false;
            this.ListaAsignacion.AllowUserToResizeColumns = false;
            this.ListaAsignacion.AllowUserToResizeRows = false;
            this.ListaAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListaAsignacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAsignacion.Location = new System.Drawing.Point(16, 125);
            this.ListaAsignacion.MultiSelect = false;
            this.ListaAsignacion.Name = "ListaAsignacion";
            this.ListaAsignacion.ReadOnly = true;
            this.ListaAsignacion.RowHeadersVisible = false;
            this.ListaAsignacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListaAsignacion.ShowEditingIcon = false;
            this.ListaAsignacion.Size = new System.Drawing.Size(492, 220);
            this.ListaAsignacion.TabIndex = 0;
            this.ListaAsignacion.Tag = "vs_Asig_Puesto";
            this.ListaAsignacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAsignacion_CellDoubleClick);
            // 
            // txtCadenas1
            // 
            this.txtCadenas1.Location = new System.Drawing.Point(121, 39);
            this.txtCadenas1.Name = "txtCadenas1";
            this.txtCadenas1.Size = new System.Drawing.Size(174, 20);
            this.txtCadenas1.TabIndex = 42;
            this.txtCadenas1.Tag = "fk_id_puesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puestos";
            // 
            // AsignacionPuestoDepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AsignacionPuestoDepto";
            this.Text = "AsignacionPuestoDepto";
            this.Load += new System.EventHandler(this.AsignacionPuestoDepto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAsignacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ListaDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ListaAsignacion;
        private System.Windows.Forms.TextBox txtCadenas1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCadenas2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartamento;
    }
}
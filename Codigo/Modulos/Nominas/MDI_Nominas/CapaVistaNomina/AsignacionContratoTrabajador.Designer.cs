
namespace CapaVistaNomina
{
    partial class AsignacionContratoTrabajador
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCadenas2 = new System.Windows.Forms.TextBox();
            this.txtTrabajador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ListaAsignacion = new System.Windows.Forms.DataGridView();
            this.txtCadenas1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListaDatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAsignacion)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 124);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiganación de Contrato a Trabajador";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtCadenas2);
            this.panel2.Controls.Add(this.txtTrabajador);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.ListaAsignacion);
            this.panel2.Controls.Add(this.txtCadenas1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(28, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 621);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Trabajador";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 30);
            this.button2.TabIndex = 48;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCadenas2
            // 
            this.txtCadenas2.Location = new System.Drawing.Point(146, 111);
            this.txtCadenas2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadenas2.Name = "txtCadenas2";
            this.txtCadenas2.Size = new System.Drawing.Size(231, 22);
            this.txtCadenas2.TabIndex = 47;
            this.txtCadenas2.Tag = "";
            // 
            // txtTrabajador
            // 
            this.txtTrabajador.Location = new System.Drawing.Point(410, 111);
            this.txtTrabajador.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrabajador.Name = "txtTrabajador";
            this.txtTrabajador.Size = new System.Drawing.Size(41, 22);
            this.txtTrabajador.TabIndex = 46;
            this.txtTrabajador.Tag = "fk_id_trabajador";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Salmon;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnBuscar.Location = new System.Drawing.Point(549, 55);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 39);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 38);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 30);
            this.button3.TabIndex = 44;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Salmon;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAgregar.Location = new System.Drawing.Point(549, 9);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 39);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.ListaAsignacion.Location = new System.Drawing.Point(21, 165);
            this.ListaAsignacion.Margin = new System.Windows.Forms.Padding(4);
            this.ListaAsignacion.MultiSelect = false;
            this.ListaAsignacion.Name = "ListaAsignacion";
            this.ListaAsignacion.ReadOnly = true;
            this.ListaAsignacion.RowHeadersVisible = false;
            this.ListaAsignacion.RowHeadersWidth = 51;
            this.ListaAsignacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListaAsignacion.ShowEditingIcon = false;
            this.ListaAsignacion.Size = new System.Drawing.Size(656, 439);
            this.ListaAsignacion.TabIndex = 0;
            this.ListaAsignacion.Tag = "vs_Asig_Contrato_Trabajador";
            this.ListaAsignacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAsignacion_CellDoubleClick);
            // 
            // txtCadenas1
            // 
            this.txtCadenas1.Location = new System.Drawing.Point(146, 41);
            this.txtCadenas1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadenas1.Name = "txtCadenas1";
            this.txtCadenas1.Size = new System.Drawing.Size(231, 22);
            this.txtCadenas1.TabIndex = 42;
            this.txtCadenas1.Tag = "fk_id_contrato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contrato";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ListaDatos);
            this.panel3.Location = new System.Drawing.Point(757, 150);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 621);
            this.panel3.TabIndex = 12;
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
            this.ListaDatos.Location = new System.Drawing.Point(21, 23);
            this.ListaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.ListaDatos.MultiSelect = false;
            this.ListaDatos.Name = "ListaDatos";
            this.ListaDatos.ReadOnly = true;
            this.ListaDatos.RowHeadersVisible = false;
            this.ListaDatos.RowHeadersWidth = 51;
            this.ListaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListaDatos.ShowEditingIcon = false;
            this.ListaDatos.Size = new System.Drawing.Size(375, 574);
            this.ListaDatos.TabIndex = 0;
            this.ListaDatos.Tag = "tbl_contrato";
            this.ListaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDatos_CellClick);
            // 
            // AsignacionContratoTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 789);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AsignacionContratoTrabajador";
            this.Text = "AsignacionContratoTrabajador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAsignacion)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCadenas2;
        private System.Windows.Forms.TextBox txtTrabajador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView ListaAsignacion;
        private System.Windows.Forms.TextBox txtCadenas1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ListaDatos;
    }
}
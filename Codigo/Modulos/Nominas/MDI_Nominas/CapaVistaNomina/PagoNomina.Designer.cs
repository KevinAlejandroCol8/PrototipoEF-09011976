
namespace CapaVistaNomina
{
    partial class PagoNomina
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
            this.label5 = new System.Windows.Forms.Label();
            this.pk_id_nomina = new System.Windows.Forms.ComboBox();
            this.btn_buscarContrato = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbl_trabajador = new System.Windows.Forms.DataGridView();
            this.pk_id_departamentos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_detallenominas = new System.Windows.Forms.DataGridView();
            this.txtCadenas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_trabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detallenominas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 93);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE DE NOMINA:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(870, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "TOTAL:";
            // 
            // pk_id_nomina
            // 
            this.pk_id_nomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pk_id_nomina.FormattingEnabled = true;
            this.pk_id_nomina.Location = new System.Drawing.Point(310, 113);
            this.pk_id_nomina.Name = "pk_id_nomina";
            this.pk_id_nomina.Size = new System.Drawing.Size(245, 28);
            this.pk_id_nomina.TabIndex = 55;
            // 
            // btn_buscarContrato
            // 
            this.btn_buscarContrato.BackColor = System.Drawing.Color.Salmon;
            this.btn_buscarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarContrato.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_buscarContrato.Location = new System.Drawing.Point(653, 101);
            this.btn_buscarContrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buscarContrato.Name = "btn_buscarContrato";
            this.btn_buscarContrato.Size = new System.Drawing.Size(152, 49);
            this.btn_buscarContrato.TabIndex = 54;
            this.btn_buscarContrato.Text = "SELECCIONAR";
            this.btn_buscarContrato.UseVisualStyleBackColor = false;
            this.btn_buscarContrato.Click += new System.EventHandler(this.btn_buscarContrato_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(582, 108);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 37);
            this.button3.TabIndex = 53;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "NOMINA:";
            // 
            // tbl_trabajador
            // 
            this.tbl_trabajador.AllowUserToAddRows = false;
            this.tbl_trabajador.AllowUserToDeleteRows = false;
            this.tbl_trabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_trabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_trabajador.Location = new System.Drawing.Point(15, 216);
            this.tbl_trabajador.Name = "tbl_trabajador";
            this.tbl_trabajador.ReadOnly = true;
            this.tbl_trabajador.RowHeadersWidth = 62;
            this.tbl_trabajador.RowTemplate.Height = 28;
            this.tbl_trabajador.Size = new System.Drawing.Size(210, 425);
            this.tbl_trabajador.TabIndex = 57;
            // 
            // pk_id_departamentos
            // 
            this.pk_id_departamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pk_id_departamentos.FormattingEnabled = true;
            this.pk_id_departamentos.Location = new System.Drawing.Point(310, 158);
            this.pk_id_departamentos.Name = "pk_id_departamentos";
            this.pk_id_departamentos.Size = new System.Drawing.Size(245, 28);
            this.pk_id_departamentos.TabIndex = 59;
            this.pk_id_departamentos.SelectedIndexChanged += new System.EventHandler(this.pk_id_departamentos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "BUSCAR POR:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button1.Location = new System.Drawing.Point(653, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 49);
            this.button1.TabIndex = 60;
            this.button1.Text = "PAGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_detallenominas
            // 
            this.tbl_detallenominas.AllowUserToAddRows = false;
            this.tbl_detallenominas.AllowUserToDeleteRows = false;
            this.tbl_detallenominas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_detallenominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_detallenominas.Location = new System.Drawing.Point(231, 214);
            this.tbl_detallenominas.Name = "tbl_detallenominas";
            this.tbl_detallenominas.ReadOnly = true;
            this.tbl_detallenominas.RowHeadersWidth = 62;
            this.tbl_detallenominas.RowTemplate.Height = 28;
            this.tbl_detallenominas.Size = new System.Drawing.Size(998, 425);
            this.tbl_detallenominas.TabIndex = 61;
            // 
            // txtCadenas
            // 
            this.txtCadenas.Enabled = false;
            this.txtCadenas.Location = new System.Drawing.Point(1028, 113);
            this.txtCadenas.Name = "txtCadenas";
            this.txtCadenas.Size = new System.Drawing.Size(166, 26);
            this.txtCadenas.TabIndex = 62;
            // 
            // PagoNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 653);
            this.Controls.Add(this.txtCadenas);
            this.Controls.Add(this.tbl_detallenominas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pk_id_departamentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbl_trabajador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pk_id_nomina);
            this.Controls.Add(this.btn_buscarContrato);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "PagoNomina";
            this.Text = "PagoNomina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_trabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detallenominas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pk_id_nomina;
        private System.Windows.Forms.Button btn_buscarContrato;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tbl_trabajador;
        private System.Windows.Forms.ComboBox pk_id_departamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tbl_detallenominas;
        private System.Windows.Forms.TextBox txtCadenas;
    }
}
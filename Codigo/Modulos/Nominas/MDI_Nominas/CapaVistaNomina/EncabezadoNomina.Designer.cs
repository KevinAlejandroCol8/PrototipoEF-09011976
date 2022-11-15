
namespace CapaVistaNomina
{
    partial class EncabezadoNomina
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
            this.label3 = new System.Windows.Forms.Label();
            this.pk_id_nomina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_encabezadonominas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoPago_nomina = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.anioPagado_nomina = new System.Windows.Forms.TextBox();
            this.mesPagado_nomina = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.fechaPago_nomina = new System.Windows.Forms.TextBox();
            this.total_nomina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_encabezadonominas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 93);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENCABEZADO DE NOMINA";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.total_nomina);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.mesPagado_nomina);
            this.panel2.Controls.Add(this.fechaPago_nomina);
            this.panel2.Controls.Add(this.anioPagado_nomina);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.tipoPago_nomina);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pk_id_nomina);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbl_encabezadonominas);
            this.panel2.Location = new System.Drawing.Point(13, 348);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 475);
            this.panel2.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "FECHA ACTUAL:";
            // 
            // pk_id_nomina
            // 
            this.pk_id_nomina.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pk_id_nomina.Location = new System.Drawing.Point(24, 38);
            this.pk_id_nomina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pk_id_nomina.Name = "pk_id_nomina";
            this.pk_id_nomina.Size = new System.Drawing.Size(286, 29);
            this.pk_id_nomina.TabIndex = 5;
            this.pk_id_nomina.Tag = "pk_id_nomina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID;";
            // 
            // tbl_encabezadonominas
            // 
            this.tbl_encabezadonominas.AllowUserToAddRows = false;
            this.tbl_encabezadonominas.AllowUserToDeleteRows = false;
            this.tbl_encabezadonominas.AllowUserToResizeColumns = false;
            this.tbl_encabezadonominas.AllowUserToResizeRows = false;
            this.tbl_encabezadonominas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_encabezadonominas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_encabezadonominas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_encabezadonominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_encabezadonominas.Location = new System.Drawing.Point(360, 25);
            this.tbl_encabezadonominas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbl_encabezadonominas.MultiSelect = false;
            this.tbl_encabezadonominas.Name = "tbl_encabezadonominas";
            this.tbl_encabezadonominas.ReadOnly = true;
            this.tbl_encabezadonominas.RowHeadersVisible = false;
            this.tbl_encabezadonominas.RowHeadersWidth = 51;
            this.tbl_encabezadonominas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbl_encabezadonominas.ShowEditingIcon = false;
            this.tbl_encabezadonominas.Size = new System.Drawing.Size(655, 439);
            this.tbl_encabezadonominas.TabIndex = 0;
            this.tbl_encabezadonominas.Tag = "tbl_encabezadonominas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "TIPO DE PAGO:";
            // 
            // tipoPago_nomina
            // 
            this.tipoPago_nomina.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tipoPago_nomina.Location = new System.Drawing.Point(159, 190);
            this.tipoPago_nomina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipoPago_nomina.Name = "tipoPago_nomina";
            this.tipoPago_nomina.Size = new System.Drawing.Size(151, 29);
            this.tipoPago_nomina.TabIndex = 18;
            this.tipoPago_nomina.Tag = "tipoPago_nomina";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(24, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "MES PAGADO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(20, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "AÑO PAGADO:";
            // 
            // anioPagado_nomina
            // 
            this.anioPagado_nomina.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.anioPagado_nomina.Location = new System.Drawing.Point(24, 331);
            this.anioPagado_nomina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anioPagado_nomina.Name = "anioPagado_nomina";
            this.anioPagado_nomina.Size = new System.Drawing.Size(286, 29);
            this.anioPagado_nomina.TabIndex = 24;
            this.anioPagado_nomina.Tag = "anioPagado_nomina";
            // 
            // mesPagado_nomina
            // 
            this.mesPagado_nomina.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.mesPagado_nomina.Location = new System.Drawing.Point(24, 262);
            this.mesPagado_nomina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mesPagado_nomina.Name = "mesPagado_nomina";
            this.mesPagado_nomina.Size = new System.Drawing.Size(286, 29);
            this.mesPagado_nomina.TabIndex = 26;
            this.mesPagado_nomina.Tag = "mesPagado_nomina";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(87, 101);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(861, 234);
            this.navegador1.TabIndex = 50;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // fechaPago_nomina
            // 
            this.fechaPago_nomina.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.fechaPago_nomina.Location = new System.Drawing.Point(24, 128);
            this.fechaPago_nomina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaPago_nomina.Name = "fechaPago_nomina";
            this.fechaPago_nomina.Size = new System.Drawing.Size(286, 29);
            this.fechaPago_nomina.TabIndex = 25;
            this.fechaPago_nomina.Tag = "fechaPago_nomina";
            // 
            // total_nomina
            // 
            this.total_nomina.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.total_nomina.Location = new System.Drawing.Point(27, 405);
            this.total_nomina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.total_nomina.Name = "total_nomina";
            this.total_nomina.Size = new System.Drawing.Size(286, 29);
            this.total_nomina.TabIndex = 28;
            this.total_nomina.Tag = "total_nomina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label7.Location = new System.Drawing.Point(23, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "TOTAL:";
            // 
            // EncabezadoNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 837);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.Name = "EncabezadoNomina";
            this.Text = "EncabezadoNomina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_encabezadonominas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tipoPago_nomina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pk_id_nomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tbl_encabezadonominas;
        private System.Windows.Forms.TextBox anioPagado_nomina;
        private System.Windows.Forms.TextBox mesPagado_nomina;
        private System.Windows.Forms.TextBox fechaPago_nomina;
        private System.Windows.Forms.TextBox total_nomina;
        private System.Windows.Forms.Label label7;
    }
}
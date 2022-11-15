
namespace CapaVistaNomina
{
    partial class PuestosExam
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridHrsExtra = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHrsExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridHrsExtra);
            this.panel2.Location = new System.Drawing.Point(12, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 322);
            this.panel2.TabIndex = 21;
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt3.Location = new System.Drawing.Point(16, 123);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(192, 22);
            this.txt3.TabIndex = 13;
            this.txt3.Tag = "estatus_puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(16, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Tag = "";
            this.label5.Text = "Estatus Puesto ";
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt2.Location = new System.Drawing.Point(16, 72);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(192, 22);
            this.txt2.TabIndex = 15;
            this.txt2.Tag = "nombre_puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre Puesto";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt1.Location = new System.Drawing.Point(16, 24);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(192, 22);
            this.txt1.TabIndex = 5;
            this.txt1.Tag = "pk_codigo_puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Puesto";
            // 
            // dataGridHrsExtra
            // 
            this.dataGridHrsExtra.AllowUserToAddRows = false;
            this.dataGridHrsExtra.AllowUserToDeleteRows = false;
            this.dataGridHrsExtra.AllowUserToResizeColumns = false;
            this.dataGridHrsExtra.AllowUserToResizeRows = false;
            this.dataGridHrsExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHrsExtra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHrsExtra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridHrsExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHrsExtra.Location = new System.Drawing.Point(214, 24);
            this.dataGridHrsExtra.MultiSelect = false;
            this.dataGridHrsExtra.Name = "dataGridHrsExtra";
            this.dataGridHrsExtra.ReadOnly = true;
            this.dataGridHrsExtra.RowHeadersVisible = false;
            this.dataGridHrsExtra.RowHeadersWidth = 51;
            this.dataGridHrsExtra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridHrsExtra.ShowEditingIcon = false;
            this.dataGridHrsExtra.Size = new System.Drawing.Size(532, 270);
            this.dataGridHrsExtra.TabIndex = 0;
            this.dataGridHrsExtra.Tag = "tbl_puestos";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(123, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 20;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // PuestosExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navegador1);
            this.Name = "PuestosExam";
            this.Text = "PuestosExam";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHrsExtra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridHrsExtra;
        private NavegadorVista.Navegador navegador1;
    }
}
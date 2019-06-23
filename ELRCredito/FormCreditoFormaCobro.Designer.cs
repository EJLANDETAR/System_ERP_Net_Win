namespace ELRCredito
{
    partial class FormCreditoFormaCobro
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFormaCobro = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbSoloNuevos = new System.Windows.Forms.RadioButton();
            this.pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Location = new System.Drawing.Point(0, 372);
            this.pnBotones.Size = new System.Drawing.Size(541, 43);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(347, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(442, 0);
            // 
            // btnSiguientePage
            // 
            this.btnSiguientePage.Location = new System.Drawing.Point(252, 0);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 120);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = " INTERESES Y POR ULTIMO CAPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "2- COBRO VERTICAL, SE COBRAN OTROS CARGOS, DEMORAS,";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "1- COBRO HORIZONTAL, CUOTAS MAS ANTIGUAS PRIMERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Forma Cobro:";
            // 
            // cboFormaCobro
            // 
            this.cboFormaCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaCobro.FormattingEnabled = true;
            this.cboFormaCobro.Items.AddRange(new object[] {
            "HORIZONTAL",
            "VERTICAL"});
            this.cboFormaCobro.Location = new System.Drawing.Point(153, 171);
            this.cboFormaCobro.Name = "cboFormaCobro";
            this.cboFormaCobro.Size = new System.Drawing.Size(306, 29);
            this.cboFormaCobro.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTodos);
            this.groupBox1.Controls.Add(this.rdbSoloNuevos);
            this.groupBox1.Location = new System.Drawing.Point(36, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(14, 85);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(351, 25);
            this.rdbTodos.TabIndex = 6;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Apliccar a Todos Prestamos Vigentes y Nuevos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbSoloNuevos
            // 
            this.rdbSoloNuevos.AutoSize = true;
            this.rdbSoloNuevos.Location = new System.Drawing.Point(14, 40);
            this.rdbSoloNuevos.Name = "rdbSoloNuevos";
            this.rdbSoloNuevos.Size = new System.Drawing.Size(264, 25);
            this.rdbSoloNuevos.TabIndex = 5;
            this.rdbSoloNuevos.TabStop = true;
            this.rdbSoloNuevos.Text = "Apliccar Solo a Prestamos Nuevos";
            this.rdbSoloNuevos.UseVisualStyleBackColor = true;
            // 
            // FormCreditoFormaCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboFormaCobro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreditoFormaCobro";
            this.SPGraba = "SP_PRESTAMOS_CAMBIA_METODO_COBRO";
            this.TablaEncabezado = "TEMPRESAS";
            this.Text = "CAMBIAR FORMA DE COBRO";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboFormaCobro, 0);
            this.Controls.SetChildIndex(this.pnBotones, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFormaCobro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbSoloNuevos;
    }
}
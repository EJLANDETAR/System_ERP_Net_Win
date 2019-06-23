namespace SysProcesosERP
{
    partial class FormSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsLunes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsMartes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsMiercoles = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsJueves = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsViernes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsSabado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsDomingo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hora_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarea_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotales.SuspendLayout();
            this.pnBusqSencilla.SuspendLayout();
            this.pnOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBusqSencilla
            // 
            this.pnBusqSencilla.Location = new System.Drawing.Point(14, 52);
            this.pnBusqSencilla.Size = new System.Drawing.Size(1023, 46);
            // 
            // pnOpcionesBusqueda
            // 
            this.pnOpcionesBusqueda.Size = new System.Drawing.Size(14, 442);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unico,
            this.Descripcion,
            this.EsLunes,
            this.EsMartes,
            this.EsMiercoles,
            this.EsJueves,
            this.EsViernes,
            this.EsSabado,
            this.EsDomingo,
            this.EsActivo,
            this.Hora_Inicio,
            this.Hora_Fin,
            this.Tarea_Id,
            this.Dia_Inicio,
            this.Dia_Fin});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 396);
            this.dataGridView1.TabIndex = 47;
            // 
            // Unico
            // 
            this.Unico.DataPropertyName = "Unico";
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            this.Unico.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // EsLunes
            // 
            this.EsLunes.DataPropertyName = "EsLunes";
            this.EsLunes.HeaderText = "LU";
            this.EsLunes.Name = "EsLunes";
            this.EsLunes.ReadOnly = true;
            this.EsLunes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsLunes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsLunes.Width = 50;
            // 
            // EsMartes
            // 
            this.EsMartes.DataPropertyName = "EsMartes";
            this.EsMartes.HeaderText = "MA";
            this.EsMartes.Name = "EsMartes";
            this.EsMartes.ReadOnly = true;
            this.EsMartes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsMartes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsMartes.Width = 50;
            // 
            // EsMiercoles
            // 
            this.EsMiercoles.DataPropertyName = "EsMiercoles";
            this.EsMiercoles.HeaderText = "MI";
            this.EsMiercoles.Name = "EsMiercoles";
            this.EsMiercoles.ReadOnly = true;
            this.EsMiercoles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsMiercoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsMiercoles.Width = 50;
            // 
            // EsJueves
            // 
            this.EsJueves.DataPropertyName = "EsJueves";
            this.EsJueves.HeaderText = "JU";
            this.EsJueves.Name = "EsJueves";
            this.EsJueves.ReadOnly = true;
            this.EsJueves.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsJueves.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsJueves.Width = 50;
            // 
            // EsViernes
            // 
            this.EsViernes.DataPropertyName = "EsViernes";
            this.EsViernes.HeaderText = "VI";
            this.EsViernes.Name = "EsViernes";
            this.EsViernes.ReadOnly = true;
            this.EsViernes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsViernes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsViernes.Width = 50;
            // 
            // EsSabado
            // 
            this.EsSabado.DataPropertyName = "EsSabado";
            this.EsSabado.HeaderText = "SA";
            this.EsSabado.Name = "EsSabado";
            this.EsSabado.ReadOnly = true;
            this.EsSabado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsSabado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsSabado.Width = 50;
            // 
            // EsDomingo
            // 
            this.EsDomingo.DataPropertyName = "EsDomingo";
            this.EsDomingo.HeaderText = "DO";
            this.EsDomingo.Name = "EsDomingo";
            this.EsDomingo.ReadOnly = true;
            this.EsDomingo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsDomingo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsDomingo.Width = 50;
            // 
            // EsActivo
            // 
            this.EsActivo.DataPropertyName = "EsActivo";
            this.EsActivo.HeaderText = "EsActivo";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.ReadOnly = true;
            this.EsActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Hora_Inicio
            // 
            this.Hora_Inicio.DataPropertyName = "Hora_Inicio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "T";
            dataGridViewCellStyle1.NullValue = null;
            this.Hora_Inicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Hora_Inicio.HeaderText = "Hora Inicio";
            this.Hora_Inicio.Name = "Hora_Inicio";
            this.Hora_Inicio.ReadOnly = true;
            // 
            // Hora_Fin
            // 
            this.Hora_Fin.DataPropertyName = "Hora_Fin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "T";
            this.Hora_Fin.DefaultCellStyle = dataGridViewCellStyle2;
            this.Hora_Fin.HeaderText = "Hora Final";
            this.Hora_Fin.Name = "Hora_Fin";
            this.Hora_Fin.ReadOnly = true;
            // 
            // Tarea_Id
            // 
            this.Tarea_Id.DataPropertyName = "Tarea_Id";
            this.Tarea_Id.HeaderText = "Tarea_Id";
            this.Tarea_Id.Name = "Tarea_Id";
            this.Tarea_Id.ReadOnly = true;
            this.Tarea_Id.Visible = false;
            // 
            // Dia_Inicio
            // 
            this.Dia_Inicio.DataPropertyName = "Dia_Inicio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.Dia_Inicio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dia_Inicio.HeaderText = "Dia Inicio";
            this.Dia_Inicio.Name = "Dia_Inicio";
            this.Dia_Inicio.ReadOnly = true;
            // 
            // Dia_Fin
            // 
            this.Dia_Fin.DataPropertyName = "Dia_Fin";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.Dia_Fin.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dia_Fin.HeaderText = "Dia Final";
            this.Dia_Fin.Name = "Dia_Fin";
            this.Dia_Fin.ReadOnly = true;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClausulaOrderBY = "Hora_Inicio, Hora_Fin, Unico";
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.dataGridView1);
            this.DataGridConsulta = this.dataGridView1;
            this.FormularioRegistro = "SysProcesosERP.FormScheduleR";
            this.Name = "FormSchedule";
            this.NombreCampoID = "Tarea_Id";
            this.TablaOVista = "TSISTEMA_PROCESOS_SCHEDULE";
            this.Text = "SCHEDULE - PROGRAMACION";
            this.Controls.SetChildIndex(this.pnTotales, 0);
            this.Controls.SetChildIndex(this.pnOpcionesBusqueda, 0);
            this.Controls.SetChildIndex(this.pnBusqSencilla, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnTotales.ResumeLayout(false);
            this.pnTotales.PerformLayout();
            this.pnBusqSencilla.ResumeLayout(false);
            this.pnBusqSencilla.PerformLayout();
            this.pnOpcionesBusqueda.ResumeLayout(false);
            this.pnOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsLunes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsMartes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsMiercoles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsJueves;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsViernes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsSabado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsDomingo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Fin;
    }
}
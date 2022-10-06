namespace Clubes_con_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.rbTemporal = new System.Windows.Forms.RadioButton();
            this.rbPermanente = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbTemporalOPerm = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.Clubes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.gbTemporalOPerm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Club Nº:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(315, 7);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(27, 29);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "1";
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.AllowUserToAddRows = false;
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clubes,
            this.Nombre,
            this.Edad,
            this.Tipo});
            this.dtgvDatos.Location = new System.Drawing.Point(22, 262);
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.RowHeadersWidth = 5;
            this.dtgvDatos.Size = new System.Drawing.Size(507, 241);
            this.dtgvDatos.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(181, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 42);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Socio";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(281, 203);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(86, 42);
            this.btnCambiar.TabIndex = 5;
            this.btnCambiar.Text = "Cambiar Club";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // rbTemporal
            // 
            this.rbTemporal.AutoSize = true;
            this.rbTemporal.Location = new System.Drawing.Point(6, 42);
            this.rbTemporal.Name = "rbTemporal";
            this.rbTemporal.Size = new System.Drawing.Size(69, 17);
            this.rbTemporal.TabIndex = 6;
            this.rbTemporal.TabStop = true;
            this.rbTemporal.Text = "Temporal";
            this.rbTemporal.UseVisualStyleBackColor = true;
            // 
            // rbPermanente
            // 
            this.rbPermanente.AutoSize = true;
            this.rbPermanente.Checked = true;
            this.rbPermanente.Location = new System.Drawing.Point(5, 19);
            this.rbPermanente.Name = "rbPermanente";
            this.rbPermanente.Size = new System.Drawing.Size(82, 17);
            this.rbPermanente.TabIndex = 7;
            this.rbPermanente.TabStop = true;
            this.rbPermanente.Text = "Permanente";
            this.rbPermanente.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(219, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // gbTemporalOPerm
            // 
            this.gbTemporalOPerm.Controls.Add(this.rbPermanente);
            this.gbTemporalOPerm.Controls.Add(this.rbTemporal);
            this.gbTemporalOPerm.Location = new System.Drawing.Point(233, 103);
            this.gbTemporalOPerm.Name = "gbTemporalOPerm";
            this.gbTemporalOPerm.Size = new System.Drawing.Size(93, 71);
            this.gbTemporalOPerm.TabIndex = 9;
            this.gbTemporalOPerm.TabStop = false;
            this.gbTemporalOPerm.Text = "Seleccionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(219, 77);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(116, 20);
            this.txtEdad.TabIndex = 11;
            // 
            // Clubes
            // 
            this.Clubes.HeaderText = "Nº Club";
            this.Clubes.Name = "Clubes";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Socio";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad Socio";
            this.Edad.Name = "Edad";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo de socio";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 150;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(177, 180);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 505);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbTemporalOPerm);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Socios Clubes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.gbTemporalOPerm.ResumeLayout(false);
            this.gbTemporalOPerm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.RadioButton rbTemporal;
        private System.Windows.Forms.RadioButton rbPermanente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbTemporalOPerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clubes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Label lblError;
    }
}


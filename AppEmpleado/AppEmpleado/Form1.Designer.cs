namespace AppEmpleado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpingreso = new System.Windows.Forms.DateTimePicker();
            this.lblsalario = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncedad = new System.Windows.Forms.Button();
            this.btncantigüedad = new System.Windows.Forms.Button();
            this.btncprestaciones = new System.Windows.Forms.Button();
            this.txtcedad = new System.Windows.Forms.TextBox();
            this.txtcantigüedad = new System.Windows.Forms.TextBox();
            this.txtcprestaciones = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpingreso);
            this.panel1.Controls.Add(this.dtpnacimiento);
            this.panel1.Controls.Add(this.cmbsexo);
            this.panel1.Controls.Add(this.txtapellido);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 123);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnmodificar);
            this.panel2.Controls.Add(this.txtsalario);
            this.panel2.Controls.Add(this.lblsalario);
            this.panel2.Location = new System.Drawing.Point(24, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 61);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtcprestaciones);
            this.panel3.Controls.Add(this.txtcantigüedad);
            this.panel3.Controls.Add(this.txtcedad);
            this.panel3.Controls.Add(this.btncprestaciones);
            this.panel3.Controls.Add(this.btncantigüedad);
            this.panel3.Controls.Add(this.btncedad);
            this.panel3.Location = new System.Drawing.Point(24, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 130);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SEXO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE NACIMIENTO ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA DE INGRESO";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(166, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(166, 27);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 6;
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "masculino",
            "femenino"});
            this.cmbsexo.Location = new System.Drawing.Point(166, 49);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(121, 21);
            this.cmbsexo.TabIndex = 7;
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.Location = new System.Drawing.Point(166, 74);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpnacimiento.TabIndex = 8;
            // 
            // dtpingreso
            // 
            this.dtpingreso.Location = new System.Drawing.Point(166, 97);
            this.dtpingreso.Name = "dtpingreso";
            this.dtpingreso.Size = new System.Drawing.Size(200, 20);
            this.dtpingreso.TabIndex = 9;
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(7, 22);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(53, 13);
            this.lblsalario.TabIndex = 0;
            this.lblsalario.Text = "SALARIO";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(68, 19);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 1;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(191, 19);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncedad
            // 
            this.btncedad.Location = new System.Drawing.Point(68, 28);
            this.btncedad.Name = "btncedad";
            this.btncedad.Size = new System.Drawing.Size(171, 23);
            this.btncedad.TabIndex = 0;
            this.btncedad.Text = "CALCULAR EDAD";
            this.btncedad.UseVisualStyleBackColor = true;
            this.btncedad.Click += new System.EventHandler(this.btncedad_Click);
            // 
            // btncantigüedad
            // 
            this.btncantigüedad.Location = new System.Drawing.Point(68, 58);
            this.btncantigüedad.Name = "btncantigüedad";
            this.btncantigüedad.Size = new System.Drawing.Size(171, 23);
            this.btncantigüedad.TabIndex = 1;
            this.btncantigüedad.Text = "CALCULAR ANTIGÜEDAD";
            this.btncantigüedad.UseVisualStyleBackColor = true;
            // 
            // btncprestaciones
            // 
            this.btncprestaciones.Location = new System.Drawing.Point(68, 87);
            this.btncprestaciones.Name = "btncprestaciones";
            this.btncprestaciones.Size = new System.Drawing.Size(171, 23);
            this.btncprestaciones.TabIndex = 2;
            this.btncprestaciones.Text = "CALCULAR PRESTACIONES";
            this.btncprestaciones.UseVisualStyleBackColor = true;
            // 
            // txtcedad
            // 
            this.txtcedad.Enabled = false;
            this.txtcedad.Location = new System.Drawing.Point(324, 28);
            this.txtcedad.Name = "txtcedad";
            this.txtcedad.Size = new System.Drawing.Size(100, 20);
            this.txtcedad.TabIndex = 3;
            // 
            // txtcantigüedad
            // 
            this.txtcantigüedad.Enabled = false;
            this.txtcantigüedad.Location = new System.Drawing.Point(324, 60);
            this.txtcantigüedad.Name = "txtcantigüedad";
            this.txtcantigüedad.Size = new System.Drawing.Size(100, 20);
            this.txtcantigüedad.TabIndex = 4;
            // 
            // txtcprestaciones
            // 
            this.txtcprestaciones.Enabled = false;
            this.txtcprestaciones.Location = new System.Drawing.Point(324, 90);
            this.txtcprestaciones.Name = "txtcprestaciones";
            this.txtcprestaciones.Size = new System.Drawing.Size(100, 20);
            this.txtcprestaciones.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppEmpleado.Properties.Resources.bart;
            this.pictureBox1.Location = new System.Drawing.Point(388, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 198);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpingreso;
        private System.Windows.Forms.DateTimePicker dtpnacimiento;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox txtcprestaciones;
        private System.Windows.Forms.TextBox txtcantigüedad;
        private System.Windows.Forms.TextBox txtcedad;
        private System.Windows.Forms.Button btncprestaciones;
        private System.Windows.Forms.Button btncantigüedad;
        private System.Windows.Forms.Button btncedad;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}


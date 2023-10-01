namespace Formulario_Proyecto5
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
            this.LBNombre = new System.Windows.Forms.Label();
            this.LBApellido = new System.Windows.Forms.Label();
            this.LBTelefono = new System.Windows.Forms.Label();
            this.LBEstatura = new System.Windows.Forms.Label();
            this.LBEdad = new System.Windows.Forms.Label();
            this.GPGenero = new System.Windows.Forms.GroupBox();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.RBHombre = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.GPGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Location = new System.Drawing.Point(43, 44);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(44, 13);
            this.LBNombre.TabIndex = 0;
            this.LBNombre.Text = "Nombre";
            // 
            // LBApellido
            // 
            this.LBApellido.AutoSize = true;
            this.LBApellido.Location = new System.Drawing.Point(43, 75);
            this.LBApellido.Name = "LBApellido";
            this.LBApellido.Size = new System.Drawing.Size(44, 13);
            this.LBApellido.TabIndex = 1;
            this.LBApellido.Text = "Apellido";
            // 
            // LBTelefono
            // 
            this.LBTelefono.AutoSize = true;
            this.LBTelefono.Location = new System.Drawing.Point(43, 114);
            this.LBTelefono.Name = "LBTelefono";
            this.LBTelefono.Size = new System.Drawing.Size(49, 13);
            this.LBTelefono.TabIndex = 2;
            this.LBTelefono.Text = "Telefono";
            // 
            // LBEstatura
            // 
            this.LBEstatura.AutoSize = true;
            this.LBEstatura.Location = new System.Drawing.Point(43, 145);
            this.LBEstatura.Name = "LBEstatura";
            this.LBEstatura.Size = new System.Drawing.Size(46, 13);
            this.LBEstatura.TabIndex = 3;
            this.LBEstatura.Text = "Estatura";
            // 
            // LBEdad
            // 
            this.LBEdad.AutoSize = true;
            this.LBEdad.Location = new System.Drawing.Point(55, 179);
            this.LBEdad.Name = "LBEdad";
            this.LBEdad.Size = new System.Drawing.Size(32, 13);
            this.LBEdad.TabIndex = 4;
            this.LBEdad.Text = "Edad";
            // 
            // GPGenero
            // 
            this.GPGenero.Controls.Add(this.RBMujer);
            this.GPGenero.Controls.Add(this.RBHombre);
            this.GPGenero.Location = new System.Drawing.Point(77, 235);
            this.GPGenero.Name = "GPGenero";
            this.GPGenero.Size = new System.Drawing.Size(193, 63);
            this.GPGenero.TabIndex = 5;
            this.GPGenero.TabStop = false;
            this.GPGenero.Text = "Genero";
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(115, 28);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 1;
            this.RBMujer.TabStop = true;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.Location = new System.Drawing.Point(6, 28);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(62, 17);
            this.RBHombre.TabIndex = 0;
            this.RBHombre.TabStop = true;
            this.RBHombre.Text = "Hombre";
            this.RBHombre.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 20);
            this.textBox5.TabIndex = 9;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(93, 328);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(165, 69);
            this.BGuardar.TabIndex = 10;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(93, 429);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(165, 71);
            this.BCancelar.TabIndex = 11;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 535);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GPGenero);
            this.Controls.Add(this.LBEdad);
            this.Controls.Add(this.LBEstatura);
            this.Controls.Add(this.LBTelefono);
            this.Controls.Add(this.LBApellido);
            this.Controls.Add(this.LBNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GPGenero.ResumeLayout(false);
            this.GPGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.Label LBApellido;
        private System.Windows.Forms.Label LBTelefono;
        private System.Windows.Forms.Label LBEstatura;
        private System.Windows.Forms.Label LBEdad;
        private System.Windows.Forms.GroupBox GPGenero;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.RadioButton RBHombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
    }
}


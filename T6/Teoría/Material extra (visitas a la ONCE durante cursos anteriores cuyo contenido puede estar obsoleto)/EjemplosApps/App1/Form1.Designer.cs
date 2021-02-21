namespace App1
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.lApellidos = new System.Windows.Forms.Label();
            this.checkBoxPubli = new System.Windows.Forms.CheckBox();
            this.checkBoxCondiciones = new System.Windows.Forms.CheckBox();
            this.rbMenor18 = new System.Windows.Forms.RadioButton();
            this.rbEntre18_60 = new System.Windows.Forms.RadioButton();
            this.rbMayor60 = new System.Windows.Forms.RadioButton();
            this.lServicios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbFacebook1 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBoxEdad = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.lDepartamento = new System.Windows.Forms.Label();
            this.groupBoxEdad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(178, 649);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(133, 44);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(358, 649);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(133, 44);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(108, 80);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(58, 17);
            this.lNombre.TabIndex = 5;
            this.lNombre.Text = "Nombre";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(212, 80);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(279, 22);
            this.tNombre.TabIndex = 4;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(212, 125);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(279, 22);
            this.tApellidos.TabIndex = 7;
            // 
            // lApellidos
            // 
            this.lApellidos.AutoSize = true;
            this.lApellidos.Location = new System.Drawing.Point(108, 125);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(65, 17);
            this.lApellidos.TabIndex = 6;
            this.lApellidos.Text = "Apellidos";
            // 
            // checkBoxPubli
            // 
            this.checkBoxPubli.AutoSize = true;
            this.checkBoxPubli.Location = new System.Drawing.Point(112, 599);
            this.checkBoxPubli.Name = "checkBoxPubli";
            this.checkBoxPubli.Size = new System.Drawing.Size(182, 21);
            this.checkBoxPubli.TabIndex = 8;
            this.checkBoxPubli.Text = "Deseo recibir publicidad";
            this.checkBoxPubli.UseVisualStyleBackColor = true;
            // 
            // checkBoxCondiciones
            // 
            this.checkBoxCondiciones.AutoSize = true;
            this.checkBoxCondiciones.Location = new System.Drawing.Point(112, 572);
            this.checkBoxCondiciones.Name = "checkBoxCondiciones";
            this.checkBoxCondiciones.Size = new System.Drawing.Size(175, 21);
            this.checkBoxCondiciones.TabIndex = 9;
            this.checkBoxCondiciones.Text = "Acepto las condiciones";
            this.checkBoxCondiciones.UseVisualStyleBackColor = true;
            // 
            // rbMenor18
            // 
            this.rbMenor18.AutoSize = true;
            this.rbMenor18.Location = new System.Drawing.Point(21, 33);
            this.rbMenor18.Name = "rbMenor18";
            this.rbMenor18.Size = new System.Drawing.Size(144, 21);
            this.rbMenor18.TabIndex = 8;
            this.rbMenor18.TabStop = true;
            this.rbMenor18.Text = "Menor de 18 años";
            this.rbMenor18.UseVisualStyleBackColor = true;
            // 
            // rbEntre18_60
            // 
            this.rbEntre18_60.AutoSize = true;
            this.rbEntre18_60.Location = new System.Drawing.Point(21, 61);
            this.rbEntre18_60.Name = "rbEntre18_60";
            this.rbEntre18_60.Size = new System.Drawing.Size(149, 21);
            this.rbEntre18_60.TabIndex = 9;
            this.rbEntre18_60.TabStop = true;
            this.rbEntre18_60.Text = "Entre 18 y 60 años";
            this.rbEntre18_60.UseVisualStyleBackColor = true;
            // 
            // rbMayor60
            // 
            this.rbMayor60.AutoSize = true;
            this.rbMayor60.Location = new System.Drawing.Point(21, 89);
            this.rbMayor60.Name = "rbMayor60";
            this.rbMayor60.Size = new System.Drawing.Size(143, 21);
            this.rbMayor60.TabIndex = 10;
            this.rbMayor60.TabStop = true;
            this.rbMayor60.Text = "Mayor de 60 años";
            this.rbMayor60.UseVisualStyleBackColor = true;
            // 
            // lServicios
            // 
            this.lServicios.AutoSize = true;
            this.lServicios.Location = new System.Drawing.Point(106, 320);
            this.lServicios.Name = "lServicios";
            this.lServicios.Size = new System.Drawing.Size(406, 17);
            this.lServicios.TabIndex = 12;
            this.lServicios.Text = "Señala con qué frecuencia utilizas los siguientes servicios web:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Facebook";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "YouTube";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "WhatsApp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Twitter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Instagram";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nunca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "A diario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Semanalmente";
            // 
            // rbFacebook1
            // 
            this.rbFacebook1.AutoSize = true;
            this.rbFacebook1.Location = new System.Drawing.Point(7, 7);
            this.rbFacebook1.Name = "rbFacebook1";
            this.rbFacebook1.Size = new System.Drawing.Size(17, 16);
            this.rbFacebook1.TabIndex = 22;
            this.rbFacebook1.TabStop = true;
            this.rbFacebook1.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(152, 7);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(17, 16);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(321, 7);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(17, 16);
            this.radioButton6.TabIndex = 24;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdad
            // 
            this.groupBoxEdad.Controls.Add(this.rbEntre18_60);
            this.groupBoxEdad.Controls.Add(this.rbMenor18);
            this.groupBoxEdad.Controls.Add(this.rbMayor60);
            this.groupBoxEdad.Location = new System.Drawing.Point(109, 163);
            this.groupBoxEdad.Name = "groupBoxEdad";
            this.groupBoxEdad.Size = new System.Drawing.Size(215, 125);
            this.groupBoxEdad.TabIndex = 25;
            this.groupBoxEdad.TabStop = false;
            this.groupBoxEdad.Text = "Edad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.rbFacebook1);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Location = new System.Drawing.Point(229, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 29);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton7);
            this.panel2.Controls.Add(this.radioButton8);
            this.panel2.Controls.Add(this.radioButton9);
            this.panel2.Location = new System.Drawing.Point(229, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 29);
            this.panel2.TabIndex = 27;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(152, 7);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(17, 16);
            this.radioButton7.TabIndex = 23;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 7);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(17, 16);
            this.radioButton8.TabIndex = 22;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(321, 7);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(17, 16);
            this.radioButton9.TabIndex = 24;
            this.radioButton9.TabStop = true;
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton10);
            this.panel3.Controls.Add(this.radioButton11);
            this.panel3.Controls.Add(this.radioButton12);
            this.panel3.Location = new System.Drawing.Point(229, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 29);
            this.panel3.TabIndex = 28;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(152, 7);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(17, 16);
            this.radioButton10.TabIndex = 23;
            this.radioButton10.TabStop = true;
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(7, 7);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(17, 16);
            this.radioButton11.TabIndex = 22;
            this.radioButton11.TabStop = true;
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(321, 7);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(17, 16);
            this.radioButton12.TabIndex = 24;
            this.radioButton12.TabStop = true;
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton13);
            this.panel4.Controls.Add(this.radioButton14);
            this.panel4.Controls.Add(this.radioButton15);
            this.panel4.Location = new System.Drawing.Point(229, 479);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 29);
            this.panel4.TabIndex = 29;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(152, 7);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(17, 16);
            this.radioButton13.TabIndex = 23;
            this.radioButton13.TabStop = true;
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(7, 7);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(17, 16);
            this.radioButton14.TabIndex = 22;
            this.radioButton14.TabStop = true;
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(321, 7);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(17, 16);
            this.radioButton15.TabIndex = 24;
            this.radioButton15.TabStop = true;
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton16);
            this.panel5.Controls.Add(this.radioButton17);
            this.panel5.Controls.Add(this.radioButton18);
            this.panel5.Location = new System.Drawing.Point(229, 509);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 29);
            this.panel5.TabIndex = 30;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(152, 7);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(17, 16);
            this.radioButton16.TabIndex = 23;
            this.radioButton16.TabStop = true;
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(7, 7);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(17, 16);
            this.radioButton17.TabIndex = 22;
            this.radioButton17.TabStop = true;
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(321, 7);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(17, 16);
            this.radioButton18.TabIndex = 24;
            this.radioButton18.TabStop = true;
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // lDepartamento
            // 
            this.lDepartamento.AutoSize = true;
            this.lDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDepartamento.Location = new System.Drawing.Point(107, 28);
            this.lDepartamento.Name = "lDepartamento";
            this.lDepartamento.Size = new System.Drawing.Size(303, 29);
            this.lDepartamento.TabIndex = 3;
            this.lDepartamento.Text = "Departamento Comercial";
            // 
            // Form1
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(681, 711);
            this.Controls.Add(this.lDepartamento);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxEdad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lServicios);
            this.Controls.Add(this.checkBoxCondiciones);
            this.Controls.Add(this.checkBoxPubli);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.lApellidos);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuestionario";
            this.groupBoxEdad.ResumeLayout(false);
            this.groupBoxEdad.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.Label lApellidos;
        private System.Windows.Forms.CheckBox checkBoxPubli;
        private System.Windows.Forms.CheckBox checkBoxCondiciones;
        private System.Windows.Forms.RadioButton rbMenor18;
        private System.Windows.Forms.RadioButton rbEntre18_60;
        private System.Windows.Forms.RadioButton rbMayor60;
        private System.Windows.Forms.Label lServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbFacebook1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBoxEdad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.Label lDepartamento;
    }
}


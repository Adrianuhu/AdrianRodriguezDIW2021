namespace AppAccesible
{
    partial class FormSalir2
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
            this.btSi = new System.Windows.Forms.Button();
            this.lSalir = new System.Windows.Forms.Label();
            this.btNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSi
            // 
            this.btSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.btSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSi.FlatAppearance.BorderSize = 6;
            this.btSi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSi.Location = new System.Drawing.Point(101, 80);
            this.btSi.Name = "btSi";
            this.btSi.Size = new System.Drawing.Size(93, 48);
            this.btSi.TabIndex = 8;
            this.btSi.Text = "SÍ";
            this.btSi.UseVisualStyleBackColor = false;
            this.btSi.Click += new System.EventHandler(this.btSi_Click);
            // 
            // lSalir
            // 
            this.lSalir.AutoSize = true;
            this.lSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSalir.Location = new System.Drawing.Point(77, 32);
            this.lSalir.Name = "lSalir";
            this.lSalir.Size = new System.Drawing.Size(280, 17);
            this.lSalir.TabIndex = 4;
            this.lSalir.Text = "¿Seguro que deseas salir de la aplicación?";
            // 
            // btNo
            // 
            this.btNo.AccessibleName = "No";
            this.btNo.BackgroundImage = global::AppAccesible.Properties.Resources.salir_no;
            this.btNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNo.FlatAppearance.BorderSize = 0;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.Location = new System.Drawing.Point(260, 80);
            this.btNo.Name = "btNo";
            this.btNo.Padding = new System.Windows.Forms.Padding(30);
            this.btNo.Size = new System.Drawing.Size(60, 60);
            this.btNo.TabIndex = 9;
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // FormSalir2
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 170);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btSi);
            this.Controls.Add(this.lSalir);
            this.Name = "FormSalir2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aviso de confirmación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSi;
        private System.Windows.Forms.Label lSalir;
        private System.Windows.Forms.Button btNo;
    }
}
namespace App1
{
    partial class FormSalir
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
            this.lSalir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxNo = new System.Windows.Forms.PictureBox();
            this.pictureBoxSi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSi)).BeginInit();
            this.SuspendLayout();
            // 
            // lSalir
            // 
            this.lSalir.AutoSize = true;
            this.lSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSalir.Location = new System.Drawing.Point(101, 30);
            this.lSalir.Name = "lSalir";
            this.lSalir.Size = new System.Drawing.Size(280, 17);
            this.lSalir.TabIndex = 0;
            this.lSalir.Text = "¿Seguro que deseas salir de la aplicación?";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::App1.Properties.Resources.salir_si;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(424, 98);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30);
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxNo
            // 
            this.pictureBoxNo.Image = global::App1.Properties.Resources.salir_no;
            this.pictureBoxNo.Location = new System.Drawing.Point(218, 98);
            this.pictureBoxNo.Name = "pictureBoxNo";
            this.pictureBoxNo.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNo.TabIndex = 1;
            this.pictureBoxNo.TabStop = false;
            this.pictureBoxNo.Click += new System.EventHandler(this.pictureBoxNo_Click);
            // 
            // pictureBoxSi
            // 
            this.pictureBoxSi.Image = global::App1.Properties.Resources.salir_si;
            this.pictureBoxSi.Location = new System.Drawing.Point(77, 98);
            this.pictureBoxSi.Name = "pictureBoxSi";
            this.pictureBoxSi.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxSi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSi.TabIndex = 0;
            this.pictureBoxSi.TabStop = false;
            this.pictureBoxSi.Click += new System.EventHandler(this.pictureBoxSi_Click);
            // 
            // FormSalir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lSalir);
            this.Controls.Add(this.pictureBoxNo);
            this.Controls.Add(this.pictureBoxSi);
            this.Name = "FormSalir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSi;
        private System.Windows.Forms.PictureBox pictureBoxNo;
        private System.Windows.Forms.Label lSalir;
        private System.Windows.Forms.Button button1;
    }
}
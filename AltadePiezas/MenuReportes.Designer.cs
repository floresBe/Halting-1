namespace AltadePiezas
{
    partial class MenuReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuReportes));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDefectos = new System.Windows.Forms.Button();
            this.buttonPruebas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(146, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 43);
            this.label4.TabIndex = 19;
            this.label4.Text = "Reporte de Pruebas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 47);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reporte de Ciclos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AltadePiezas.Properties.Resources.joniwel;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDefectos
            // 
            this.buttonDefectos.BackColor = System.Drawing.Color.Red;
            this.buttonDefectos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDefectos.BackgroundImage")));
            this.buttonDefectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDefectos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDefectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefectos.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDefectos.Location = new System.Drawing.Point(159, 135);
            this.buttonDefectos.Name = "buttonDefectos";
            this.buttonDefectos.Size = new System.Drawing.Size(88, 84);
            this.buttonDefectos.TabIndex = 18;
            this.buttonDefectos.UseVisualStyleBackColor = false;
            this.buttonDefectos.Click += new System.EventHandler(this.buttonDefectos_Click);
            // 
            // buttonPruebas
            // 
            this.buttonPruebas.BackColor = System.Drawing.Color.Red;
            this.buttonPruebas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPruebas.BackgroundImage")));
            this.buttonPruebas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPruebas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPruebas.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPruebas.Location = new System.Drawing.Point(29, 135);
            this.buttonPruebas.Name = "buttonPruebas";
            this.buttonPruebas.Size = new System.Drawing.Size(88, 84);
            this.buttonPruebas.TabIndex = 16;
            this.buttonPruebas.UseVisualStyleBackColor = false;
            this.buttonPruebas.Click += new System.EventHandler(this.buttonPruebas_Click);
            // 
            // MenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDefectos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPruebas);
            this.Name = "MenuReportes";
            this.Text = "MenuReportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDefectos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPruebas;
    }
}
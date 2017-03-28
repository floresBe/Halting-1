namespace AltadePiezas
{
    partial class reportePruebas
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
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSerie = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrueba = new System.Windows.Forms.ComboBox();
            this.textBoxHoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 31);
            this.label8.TabIndex = 55;
            this.label8.Text = "No. Serie:";
            // 
            // comboBoxSerie
            // 
            this.comboBoxSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSerie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxSerie.FormattingEnabled = true;
            this.comboBoxSerie.Items.AddRange(new object[] {
            "UM-0001-M",
            "UM-0002-M",
            "UM-0003-M",
            "UM-0004-M",
            "UM-0005-M",
            "UM-0006-M",
            "UM-0007-M"});
            this.comboBoxSerie.Location = new System.Drawing.Point(177, 175);
            this.comboBoxSerie.Name = "comboBoxSerie";
            this.comboBoxSerie.Size = new System.Drawing.Size(128, 33);
            this.comboBoxSerie.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AltadePiezas.Properties.Resources.joniwel11;
            this.pictureBox1.Location = new System.Drawing.Point(-140, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(973, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(168, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 37);
            this.label3.TabIndex = 57;
            this.label3.Text = "Pruebas realizadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "Prueba:";
            // 
            // comboBoxPrueba
            // 
            this.comboBoxPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrueba.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxPrueba.FormattingEnabled = true;
            this.comboBoxPrueba.Items.AddRange(new object[] {
            "PT CORE",
            "PT  TANK",
            "PT FLANGE Y BRACKETS"});
            this.comboBoxPrueba.Location = new System.Drawing.Point(177, 224);
            this.comboBoxPrueba.Name = "comboBoxPrueba";
            this.comboBoxPrueba.Size = new System.Drawing.Size(128, 33);
            this.comboBoxPrueba.TabIndex = 58;
            // 
            // textBoxHoney
            // 
            this.textBoxHoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoney.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxHoney.Location = new System.Drawing.Point(177, 280);
            this.textBoxHoney.Name = "textBoxHoney";
            this.textBoxHoney.Size = new System.Drawing.Size(128, 31);
            this.textBoxHoney.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 70);
            this.label9.TabIndex = 66;
            this.label9.Text = "No. Parte Honeywell:";
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxObservaciones.Location = new System.Drawing.Point(324, 206);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(234, 105);
            this.textBoxObservaciones.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(318, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 31);
            this.label7.TabIndex = 68;
            this.label7.Text = "Observaciones:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(460, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 70;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(324, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 36);
            this.button3.TabIndex = 71;
            this.button3.Text = "Exportar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reportePruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(589, 409);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxObservaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxHoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPrueba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSerie);
            this.Name = "reportePruebas";
            this.Text = "reportePruebas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSerie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPrueba;
        private System.Windows.Forms.TextBox textBoxHoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
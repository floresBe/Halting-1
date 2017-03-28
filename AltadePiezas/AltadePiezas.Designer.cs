namespace AltadePiezas
{
    partial class AltadePiezas
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCiclos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHornos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxNosParte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxNosSerie = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPiezas = new System.Windows.Forms.TextBox();
            this.segundaPosicion = new System.Windows.Forms.ListBox();
            this.primeraPosicion = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(313, 169);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(19, 38);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha brazing:";
            // 
            // comboBoxCiclos
            // 
            this.comboBoxCiclos.Enabled = false;
            this.comboBoxCiclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCiclos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxCiclos.FormattingEnabled = true;
            this.comboBoxCiclos.Items.AddRange(new object[] {
            "H0001",
            "H0002",
            "H0003"});
            this.comboBoxCiclos.Location = new System.Drawing.Point(163, 327);
            this.comboBoxCiclos.Name = "comboBoxCiclos";
            this.comboBoxCiclos.Size = new System.Drawing.Size(169, 33);
            this.comboBoxCiclos.TabIndex = 3;
            this.comboBoxCiclos.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiclos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciclo:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(351, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Números de serie:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(526, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Red;
            this.btnAgregar.Location = new System.Drawing.Point(357, 475);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 39);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(185, 176);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(80, 25);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "--/--/----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(237, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 33);
            this.label5.TabIndex = 26;
            this.label5.Text = "Alta de Ciclo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "Horno:";
            // 
            // cbHornos
            // 
            this.cbHornos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHornos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbHornos.FormattingEnabled = true;
            this.cbHornos.Items.AddRange(new object[] {
            "Aluminio1436",
            "I1806",
            "H1764"});
            this.cbHornos.Location = new System.Drawing.Point(163, 263);
            this.cbHornos.Name = "cbHornos";
            this.cbHornos.Size = new System.Drawing.Size(169, 33);
            this.cbHornos.TabIndex = 31;
            this.cbHornos.SelectedIndexChanged += new System.EventHandler(this.cbHornos_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 31);
            this.label8.TabIndex = 35;
            this.label8.Text = "No. Parte:";
            // 
            // comboBoxNosParte
            // 
            this.comboBoxNosParte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNosParte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxNosParte.FormattingEnabled = true;
            this.comboBoxNosParte.Location = new System.Drawing.Point(163, 391);
            this.comboBoxNosParte.Name = "comboBoxNosParte";
            this.comboBoxNosParte.Size = new System.Drawing.Size(169, 33);
            this.comboBoxNosParte.TabIndex = 34;
            this.comboBoxNosParte.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(351, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Posiciones:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(567, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = ">>";
            // 
            // checkedListBoxNosSerie
            // 
            this.checkedListBoxNosSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxNosSerie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkedListBoxNosSerie.FormattingEnabled = true;
            this.checkedListBoxNosSerie.Location = new System.Drawing.Point(357, 296);
            this.checkedListBoxNosSerie.Name = "checkedListBoxNosSerie";
            this.checkedListBoxNosSerie.Size = new System.Drawing.Size(302, 108);
            this.checkedListBoxNosSerie.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(352, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 32);
            this.label9.TabIndex = 42;
            this.label9.Text = "(Marcar si es rebraze)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AltadePiezas.Properties.Resources.joniwel11;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPiezas
            // 
            this.textBoxPiezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPiezas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPiezas.Location = new System.Drawing.Point(511, 169);
            this.textBoxPiezas.Name = "textBoxPiezas";
            this.textBoxPiezas.Size = new System.Drawing.Size(48, 31);
            this.textBoxPiezas.TabIndex = 43;
            // 
            // segundaPosicion
            // 
            this.segundaPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundaPosicion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.segundaPosicion.FormattingEnabled = true;
            this.segundaPosicion.ItemHeight = 25;
            this.segundaPosicion.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.segundaPosicion.Location = new System.Drawing.Point(609, 212);
            this.segundaPosicion.Name = "segundaPosicion";
            this.segundaPosicion.Size = new System.Drawing.Size(50, 29);
            this.segundaPosicion.TabIndex = 39;
            this.segundaPosicion.SelectedIndexChanged += new System.EventHandler(this.segundaPosicion_SelectedIndexChanged);
            // 
            // primeraPosicion
            // 
            this.primeraPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeraPosicion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.primeraPosicion.FormattingEnabled = true;
            this.primeraPosicion.ItemHeight = 25;
            this.primeraPosicion.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.primeraPosicion.Location = new System.Drawing.Point(511, 212);
            this.primeraPosicion.Name = "primeraPosicion";
            this.primeraPosicion.Size = new System.Drawing.Size(50, 29);
            this.primeraPosicion.TabIndex = 38;
            this.primeraPosicion.SelectedIndexChanged += new System.EventHandler(this.posicion1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(401, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 31);
            this.label10.TabIndex = 44;
            this.label10.Text = "Piezas:";
            // 
            // AltadePiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(690, 534);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPiezas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkedListBoxNosSerie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.segundaPosicion);
            this.Controls.Add(this.primeraPosicion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxNosParte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbHornos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCiclos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "AltadePiezas";
            this.Text = "Alta de Piezas";
            this.Load += new System.EventHandler(this.AltadePiezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCiclos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHornos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxNosParte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBoxNosSerie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPiezas;
        private System.Windows.Forms.ListBox segundaPosicion;
        private System.Windows.Forms.ListBox primeraPosicion;
        private System.Windows.Forms.Label label10;
    }
}


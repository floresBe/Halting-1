namespace AltadePiezas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labelPieza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDefectos = new System.Windows.Forms.Button();
            this.buttonPruebas = new System.Windows.Forms.Button();
            this.buttonAgregarPrueba = new System.Windows.Forms.Button();
            this.buttonAgregarPieza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPieza
            // 
            this.labelPieza.AutoSize = true;
            this.labelPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPieza.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPieza.Location = new System.Drawing.Point(26, 206);
            this.labelPieza.Name = "labelPieza";
            this.labelPieza.Size = new System.Drawing.Size(122, 20);
            this.labelPieza.TabIndex = 5;
            this.labelPieza.Text = "Agregar Pieza";
            this.labelPieza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(150, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Agregar Prueba";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(36, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "Catalogo de Pruebas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(160, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 43);
            this.label4.TabIndex = 9;
            this.label4.Text = "Catalogo de Defectos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AltadePiezas.Properties.Resources.joniwel;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
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
            this.buttonDefectos.Location = new System.Drawing.Point(173, 237);
            this.buttonDefectos.Name = "buttonDefectos";
            this.buttonDefectos.Size = new System.Drawing.Size(88, 84);
            this.buttonDefectos.TabIndex = 8;
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
            this.buttonPruebas.Location = new System.Drawing.Point(43, 237);
            this.buttonPruebas.Name = "buttonPruebas";
            this.buttonPruebas.Size = new System.Drawing.Size(88, 84);
            this.buttonPruebas.TabIndex = 3;
            this.buttonPruebas.UseVisualStyleBackColor = false;
            this.buttonPruebas.Click += new System.EventHandler(this.buttonPruebas_Click);
            // 
            // buttonAgregarPrueba
            // 
            this.buttonAgregarPrueba.BackColor = System.Drawing.Color.Red;
            this.buttonAgregarPrueba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAgregarPrueba.BackgroundImage")));
            this.buttonAgregarPrueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregarPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregarPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarPrueba.Location = new System.Drawing.Point(173, 119);
            this.buttonAgregarPrueba.Name = "buttonAgregarPrueba";
            this.buttonAgregarPrueba.Size = new System.Drawing.Size(88, 84);
            this.buttonAgregarPrueba.TabIndex = 1;
            this.buttonAgregarPrueba.UseVisualStyleBackColor = false;
            this.buttonAgregarPrueba.Click += new System.EventHandler(this.buttonAgregarPrueba_Click);
            // 
            // buttonAgregarPieza
            // 
            this.buttonAgregarPieza.BackColor = System.Drawing.Color.Red;
            this.buttonAgregarPieza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAgregarPieza.BackgroundImage")));
            this.buttonAgregarPieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregarPieza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregarPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarPieza.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAgregarPieza.Location = new System.Drawing.Point(43, 119);
            this.buttonAgregarPieza.Name = "buttonAgregarPieza";
            this.buttonAgregarPieza.Size = new System.Drawing.Size(88, 84);
            this.buttonAgregarPieza.TabIndex = 0;
            this.buttonAgregarPieza.UseVisualStyleBackColor = false;
            this.buttonAgregarPieza.Click += new System.EventHandler(this.buttonAgregarPieza_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(39, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reportes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(43, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 84);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(313, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDefectos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPieza);
            this.Controls.Add(this.buttonPruebas);
            this.Controls.Add(this.buttonAgregarPrueba);
            this.Controls.Add(this.buttonAgregarPieza);
            this.Name = "Menu";
            this.Text = "Menú";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarPieza;
        private System.Windows.Forms.Button buttonAgregarPrueba;
        private System.Windows.Forms.Button buttonPruebas;
        private System.Windows.Forms.Label labelPieza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDefectos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
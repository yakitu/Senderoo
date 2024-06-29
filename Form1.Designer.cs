namespace EAC2_Exercici3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewRutes = new System.Windows.Forms.ListView();
            this.groupBoxPuntuacio = new System.Windows.Forms.GroupBox();
            this.comboBoxPuntuacio = new System.Windows.Forms.ComboBox();
            this.buttonVota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxRuta = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDuracio = new System.Windows.Forms.Label();
            this.labelTotalPuntuacio = new System.Windows.Forms.Label();
            this.labelDificultat = new System.Windows.Forms.Label();
            this.labelDistancia = new System.Windows.Forms.Label();
            this.labelTipus = new System.Windows.Forms.Label();
            this.labelNomRuta = new System.Windows.Forms.Label();
            this.textBoxDescripcio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxPuntuacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 184);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // listViewRutes
            // 
            this.listViewRutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listViewRutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRutes.HideSelection = false;
            this.listViewRutes.Location = new System.Drawing.Point(12, 287);
            this.listViewRutes.Name = "listViewRutes";
            this.listViewRutes.Size = new System.Drawing.Size(404, 254);
            this.listViewRutes.TabIndex = 6;
            this.listViewRutes.UseCompatibleStateImageBehavior = false;
            this.listViewRutes.SelectedIndexChanged += new System.EventHandler(this.listViewRutes_SelectedIndexChanged);
            // 
            // groupBoxPuntuacio
            // 
            this.groupBoxPuntuacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBoxPuntuacio.Controls.Add(this.comboBoxPuntuacio);
            this.groupBoxPuntuacio.Controls.Add(this.buttonVota);
            this.groupBoxPuntuacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPuntuacio.ForeColor = System.Drawing.Color.White;
            this.groupBoxPuntuacio.Location = new System.Drawing.Point(282, 683);
            this.groupBoxPuntuacio.Name = "groupBoxPuntuacio";
            this.groupBoxPuntuacio.Size = new System.Drawing.Size(148, 148);
            this.groupBoxPuntuacio.TabIndex = 7;
            this.groupBoxPuntuacio.TabStop = false;
            this.groupBoxPuntuacio.Text = "Puntuació";
            // 
            // comboBoxPuntuacio
            // 
            this.comboBoxPuntuacio.FormattingEnabled = true;
            this.comboBoxPuntuacio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxPuntuacio.Location = new System.Drawing.Point(47, 48);
            this.comboBoxPuntuacio.Name = "comboBoxPuntuacio";
            this.comboBoxPuntuacio.Size = new System.Drawing.Size(50, 37);
            this.comboBoxPuntuacio.TabIndex = 6;
            this.comboBoxPuntuacio.SelectedIndexChanged += new System.EventHandler(this.comboBoxPuntuacio_SelectedIndexChanged);
            // 
            // buttonVota
            // 
            this.buttonVota.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonVota.Location = new System.Drawing.Point(34, 91);
            this.buttonVota.Name = "buttonVota";
            this.buttonVota.Size = new System.Drawing.Size(75, 44);
            this.buttonVota.TabIndex = 5;
            this.buttonVota.Text = "Vota";
            this.buttonVota.UseVisualStyleBackColor = false;
            this.buttonVota.Click += new System.EventHandler(this.buttonVota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(386, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 58);
            this.label2.TabIndex = 9;
            this.label2.Text = "Les millors rutes de Catalunya";
            // 
            // pictureBoxRuta
            // 
            this.pictureBoxRuta.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRuta.Location = new System.Drawing.Point(436, 214);
            this.pictureBoxRuta.Name = "pictureBoxRuta";
            this.pictureBoxRuta.Size = new System.Drawing.Size(917, 465);
            this.pictureBoxRuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRuta.TabIndex = 10;
            this.pictureBoxRuta.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Controls.Add(this.labelDuracio);
            this.groupBox1.Controls.Add(this.labelTotalPuntuacio);
            this.groupBox1.Controls.Add(this.labelDificultat);
            this.groupBox1.Controls.Add(this.labelDistancia);
            this.groupBox1.Controls.Add(this.labelTipus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 547);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 369);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informació de la ruta";
            // 
            // labelDuracio
            // 
            this.labelDuracio.AutoSize = true;
            this.labelDuracio.Location = new System.Drawing.Point(6, 259);
            this.labelDuracio.Name = "labelDuracio";
            this.labelDuracio.Size = new System.Drawing.Size(163, 25);
            this.labelDuracio.TabIndex = 5;
            this.labelDuracio.Text = "Duració estimada";
            // 
            // labelTotalPuntuacio
            // 
            this.labelTotalPuntuacio.AutoSize = true;
            this.labelTotalPuntuacio.Location = new System.Drawing.Point(6, 317);
            this.labelTotalPuntuacio.Name = "labelTotalPuntuacio";
            this.labelTotalPuntuacio.Size = new System.Drawing.Size(140, 25);
            this.labelTotalPuntuacio.TabIndex = 4;
            this.labelTotalPuntuacio.Text = "Puntuació total";
            // 
            // labelDificultat
            // 
            this.labelDificultat.AutoSize = true;
            this.labelDificultat.Location = new System.Drawing.Point(6, 196);
            this.labelDificultat.Name = "labelDificultat";
            this.labelDificultat.Size = new System.Drawing.Size(85, 25);
            this.labelDificultat.TabIndex = 2;
            this.labelDificultat.Text = "Dificultat";
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Location = new System.Drawing.Point(6, 124);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(92, 25);
            this.labelDistancia.TabIndex = 1;
            this.labelDistancia.Text = "Distància";
            // 
            // labelTipus
            // 
            this.labelTipus.AutoSize = true;
            this.labelTipus.Location = new System.Drawing.Point(6, 56);
            this.labelTipus.Name = "labelTipus";
            this.labelTipus.Size = new System.Drawing.Size(61, 25);
            this.labelTipus.TabIndex = 0;
            this.labelTipus.Text = "Tipus";
            // 
            // labelNomRuta
            // 
            this.labelNomRuta.AutoSize = true;
            this.labelNomRuta.BackColor = System.Drawing.Color.ForestGreen;
            this.labelNomRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomRuta.ForeColor = System.Drawing.Color.White;
            this.labelNomRuta.Location = new System.Drawing.Point(415, 157);
            this.labelNomRuta.Name = "labelNomRuta";
            this.labelNomRuta.Size = new System.Drawing.Size(239, 39);
            this.labelNomRuta.TabIndex = 0;
            this.labelNomRuta.Text = "Nom de la ruta";
            // 
            // textBoxDescripcio
            // 
            this.textBoxDescripcio.BackColor = System.Drawing.Color.ForestGreen;
            this.textBoxDescripcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcio.ForeColor = System.Drawing.Color.White;
            this.textBoxDescripcio.Location = new System.Drawing.Point(436, 685);
            this.textBoxDescripcio.Multiline = true;
            this.textBoxDescripcio.Name = "textBoxDescripcio";
            this.textBoxDescripcio.Size = new System.Drawing.Size(917, 231);
            this.textBoxDescripcio.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1365, 928);
            this.Controls.Add(this.textBoxDescripcio);
            this.Controls.Add(this.labelNomRuta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPuntuacio);
            this.Controls.Add(this.listViewRutes);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Senderoo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxPuntuacio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewRutes;
        private System.Windows.Forms.GroupBox groupBoxPuntuacio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxRuta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNomRuta;
        private System.Windows.Forms.TextBox textBoxDescripcio;
        private System.Windows.Forms.Label labelTipus;
        private System.Windows.Forms.Label labelDificultat;
        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.Label labelDuracio;
        private System.Windows.Forms.Label labelTotalPuntuacio;
        private System.Windows.Forms.Button buttonVota;
        private System.Windows.Forms.ComboBox comboBoxPuntuacio;
    }
}


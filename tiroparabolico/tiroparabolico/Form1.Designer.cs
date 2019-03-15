namespace tiroparabolico
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelAlcance = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelAlturaMaxima = new System.Windows.Forms.Label();
            this.labelAlcanceMaximo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelmidwidth = new System.Windows.Forms.Label();
            this.labelwidth = new System.Windows.Forms.Label();
            this.labelheight = new System.Windows.Forms.Label();
            this.labelmidheight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(10, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 650);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(669, 12);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(297, 23);
            this.buttonIniciar.TabIndex = 1;
            this.buttonIniciar.Text = "Iniciar Simulacion";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonDatos
            // 
            this.buttonDatos.Location = new System.Drawing.Point(669, 42);
            this.buttonDatos.Name = "buttonDatos";
            this.buttonDatos.Size = new System.Drawing.Size(297, 23);
            this.buttonDatos.TabIndex = 2;
            this.buttonDatos.Text = "Mostrar Tabla de Puntos";
            this.buttonDatos.UseVisualStyleBackColor = true;
            this.buttonDatos.Click += new System.EventHandler(this.buttonDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velocidad: (metros/segundo)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(672, 115);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(294, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Angulo (grados):";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(672, 155);
            this.trackBar1.Maximum = 90;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(294, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "--";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(669, 589);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(297, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Salir";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(669, 556);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(297, 27);
            this.buttonInfo.TabIndex = 9;
            this.buttonInfo.Text = "Ver informacion del programa";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Altura Maxima:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(666, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alcance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(666, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tiempo de Vuelo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(666, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Altura Maxima (90 grados):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(669, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Alcance Maximo (45 grados):";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(748, 203);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(13, 13);
            this.labelAltura.TabIndex = 16;
            this.labelAltura.Text = "--";
            // 
            // labelAlcance
            // 
            this.labelAlcance.AutoSize = true;
            this.labelAlcance.Location = new System.Drawing.Point(722, 226);
            this.labelAlcance.Name = "labelAlcance";
            this.labelAlcance.Size = new System.Drawing.Size(13, 13);
            this.labelAlcance.TabIndex = 17;
            this.labelAlcance.Text = "--";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(763, 250);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(13, 13);
            this.labelTiempo.TabIndex = 18;
            this.labelTiempo.Text = "--";
            // 
            // labelAlturaMaxima
            // 
            this.labelAlturaMaxima.AutoSize = true;
            this.labelAlturaMaxima.Location = new System.Drawing.Point(805, 272);
            this.labelAlturaMaxima.Name = "labelAlturaMaxima";
            this.labelAlturaMaxima.Size = new System.Drawing.Size(13, 13);
            this.labelAlturaMaxima.TabIndex = 19;
            this.labelAlturaMaxima.Text = "--";
            // 
            // labelAlcanceMaximo
            // 
            this.labelAlcanceMaximo.AutoSize = true;
            this.labelAlcanceMaximo.Location = new System.Drawing.Point(820, 299);
            this.labelAlcanceMaximo.Name = "labelAlcanceMaximo";
            this.labelAlcanceMaximo.Size = new System.Drawing.Size(13, 13);
            this.labelAlcanceMaximo.TabIndex = 20;
            this.labelAlcanceMaximo.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 676);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "0 Metros";
            // 
            // labelmidwidth
            // 
            this.labelmidwidth.AutoSize = true;
            this.labelmidwidth.Location = new System.Drawing.Point(325, 679);
            this.labelmidwidth.Name = "labelmidwidth";
            this.labelmidwidth.Size = new System.Drawing.Size(13, 13);
            this.labelmidwidth.TabIndex = 22;
            this.labelmidwidth.Text = "--";
            // 
            // labelwidth
            // 
            this.labelwidth.AutoSize = true;
            this.labelwidth.Location = new System.Drawing.Point(643, 676);
            this.labelwidth.Name = "labelwidth";
            this.labelwidth.Size = new System.Drawing.Size(13, 13);
            this.labelwidth.TabIndex = 23;
            this.labelwidth.Text = "--";
            // 
            // labelheight
            // 
            this.labelheight.AutoSize = true;
            this.labelheight.Location = new System.Drawing.Point(-2, 12);
            this.labelheight.Name = "labelheight";
            this.labelheight.Size = new System.Drawing.Size(13, 13);
            this.labelheight.TabIndex = 24;
            this.labelheight.Text = "--";
            // 
            // labelmidheight
            // 
            this.labelmidheight.AutoSize = true;
            this.labelmidheight.Location = new System.Drawing.Point(-2, 350);
            this.labelmidheight.Name = "labelmidheight";
            this.labelmidheight.Size = new System.Drawing.Size(13, 13);
            this.labelmidheight.TabIndex = 25;
            this.labelmidheight.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 701);
            this.Controls.Add(this.labelmidheight);
            this.Controls.Add(this.labelheight);
            this.Controls.Add(this.labelwidth);
            this.Controls.Add(this.labelmidwidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAlcanceMaximo);
            this.Controls.Add(this.labelAlturaMaxima);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.labelAlcance);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDatos);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelAlcance;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelAlturaMaxima;
        private System.Windows.Forms.Label labelAlcanceMaximo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelmidwidth;
        private System.Windows.Forms.Label labelwidth;
        private System.Windows.Forms.Label labelheight;
        private System.Windows.Forms.Label labelmidheight;
    }
}


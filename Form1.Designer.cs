﻿namespace CalculadoraProb
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoverCalculadora = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelCalculadoraBinominal = new System.Windows.Forms.Panel();
            this.btnRemoveList = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtrangofin = new System.Windows.Forms.TextBox();
            this.lbrangohasta = new System.Windows.Forms.Label();
            this.txtrangoin = new System.Windows.Forms.TextBox();
            this.btnBorrarS = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listhistorial = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValorX = new System.Windows.Forms.TextBox();
            this.resultadototal = new System.Windows.Forms.Label();
            this.txtValorP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorN = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelDEN = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txtu = new System.Windows.Forms.TextBox();
            this.txto = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCalculadoraBinominal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PanelDEN.SuspendLayout();
            this.panel5.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 56);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 148);
            this.panel3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(13, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Calculadora de Probabilidad Binominal";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(907, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(936, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MoverCalculadora
            // 
            this.MoverCalculadora.Fixed = true;
            this.MoverCalculadora.Horizontal = true;
            this.MoverCalculadora.TargetControl = this.panel1;
            this.MoverCalculadora.Vertical = true;
            // 
            // panelCalculadoraBinominal
            // 
            this.panelCalculadoraBinominal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCalculadoraBinominal.BackColor = System.Drawing.Color.White;
            this.panelCalculadoraBinominal.Controls.Add(this.btnRemoveList);
            this.panelCalculadoraBinominal.Controls.Add(this.checkBox1);
            this.panelCalculadoraBinominal.Controls.Add(this.txtrangofin);
            this.panelCalculadoraBinominal.Controls.Add(this.lbrangohasta);
            this.panelCalculadoraBinominal.Controls.Add(this.txtrangoin);
            this.panelCalculadoraBinominal.Controls.Add(this.btnBorrarS);
            this.panelCalculadoraBinominal.Controls.Add(this.label11);
            this.panelCalculadoraBinominal.Controls.Add(this.label10);
            this.panelCalculadoraBinominal.Controls.Add(this.label9);
            this.panelCalculadoraBinominal.Controls.Add(this.listhistorial);
            this.panelCalculadoraBinominal.Controls.Add(this.groupBox1);
            this.panelCalculadoraBinominal.Controls.Add(this.button1);
            this.panelCalculadoraBinominal.Controls.Add(this.txtValorX);
            this.panelCalculadoraBinominal.Controls.Add(this.resultadototal);
            this.panelCalculadoraBinominal.Controls.Add(this.txtValorP);
            this.panelCalculadoraBinominal.Controls.Add(this.label5);
            this.panelCalculadoraBinominal.Controls.Add(this.label1);
            this.panelCalculadoraBinominal.Controls.Add(this.btnCalcular);
            this.panelCalculadoraBinominal.Controls.Add(this.label2);
            this.panelCalculadoraBinominal.Controls.Add(this.label3);
            this.panelCalculadoraBinominal.Controls.Add(this.txtValorN);
            this.panelCalculadoraBinominal.Location = new System.Drawing.Point(50, 40);
            this.panelCalculadoraBinominal.Name = "panelCalculadoraBinominal";
            this.panelCalculadoraBinominal.Size = new System.Drawing.Size(610, 350);
            this.panelCalculadoraBinominal.TabIndex = 15;
            this.panelCalculadoraBinominal.Visible = false;
            this.panelCalculadoraBinominal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveList.Location = new System.Drawing.Point(373, 317);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(87, 23);
            this.btnRemoveList.TabIndex = 25;
            this.btnRemoveList.Text = "Borrar Lista";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            this.btnRemoveList.Click += new System.EventHandler(this.btnRemoveList_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(182, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Rango de numeros?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtrangofin
            // 
            this.txtrangofin.Location = new System.Drawing.Point(247, 64);
            this.txtrangofin.Name = "txtrangofin";
            this.txtrangofin.Size = new System.Drawing.Size(100, 20);
            this.txtrangofin.TabIndex = 23;
            this.txtrangofin.Text = "0";
            this.txtrangofin.Visible = false;
            this.txtrangofin.TextChanged += new System.EventHandler(this.txtrangofin_TextChanged);
            // 
            // lbrangohasta
            // 
            this.lbrangohasta.AutoSize = true;
            this.lbrangohasta.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrangohasta.ForeColor = System.Drawing.Color.White;
            this.lbrangohasta.Location = new System.Drawing.Point(205, 68);
            this.lbrangohasta.Name = "lbrangohasta";
            this.lbrangohasta.Size = new System.Drawing.Size(38, 13);
            this.lbrangohasta.TabIndex = 22;
            this.lbrangohasta.Text = "Hasta";
            this.lbrangohasta.Visible = false;
            // 
            // txtrangoin
            // 
            this.txtrangoin.Location = new System.Drawing.Point(93, 65);
            this.txtrangoin.Name = "txtrangoin";
            this.txtrangoin.Size = new System.Drawing.Size(100, 20);
            this.txtrangoin.TabIndex = 21;
            this.txtrangoin.Text = "0";
            this.txtrangoin.Visible = false;
            this.txtrangoin.TextChanged += new System.EventHandler(this.txtrangoin_TextChanged);
            // 
            // btnBorrarS
            // 
            this.btnBorrarS.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarS.Location = new System.Drawing.Point(466, 317);
            this.btnBorrarS.Name = "btnBorrarS";
            this.btnBorrarS.Size = new System.Drawing.Size(119, 23);
            this.btnBorrarS.TabIndex = 17;
            this.btnBorrarS.Text = "Borrar seleccion";
            this.btnBorrarS.UseVisualStyleBackColor = true;
            this.btnBorrarS.Click += new System.EventHandler(this.btnBorrarS_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(187, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ingrese decimal con coma.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(242, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "|";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(242, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "^";
            // 
            // listhistorial
            // 
            this.listhistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listhistorial.BackColor = System.Drawing.SystemColors.Window;
            this.listhistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listhistorial.FormattingEnabled = true;
            this.listhistorial.HorizontalScrollbar = true;
            this.listhistorial.Location = new System.Drawing.Point(373, 12);
            this.listhistorial.Name = "listhistorial";
            this.listhistorial.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listhistorial.Size = new System.Drawing.Size(226, 299);
            this.listhistorial.TabIndex = 13;
            this.listhistorial.SelectedIndexChanged += new System.EventHandler(this.listhistorial_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(182, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conceptos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "P = Probabilidad de exito.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "N = Numero de eventos.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "X = Numero de exitos.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Borrar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValorX
            // 
            this.txtValorX.Location = new System.Drawing.Point(49, 24);
            this.txtValorX.Name = "txtValorX";
            this.txtValorX.Size = new System.Drawing.Size(104, 20);
            this.txtValorX.TabIndex = 0;
            this.txtValorX.TextChanged += new System.EventHandler(this.txtValorX_TextChanged);
            // 
            // resultadototal
            // 
            this.resultadototal.AutoSize = true;
            this.resultadototal.ForeColor = System.Drawing.Color.White;
            this.resultadototal.Location = new System.Drawing.Point(113, 197);
            this.resultadototal.Name = "resultadototal";
            this.resultadototal.Size = new System.Drawing.Size(13, 13);
            this.resultadototal.TabIndex = 10;
            this.resultadototal.Text = "0";
            // 
            // txtValorP
            // 
            this.txtValorP.Location = new System.Drawing.Point(208, 112);
            this.txtValorP.Name = "txtValorP";
            this.txtValorP.Size = new System.Drawing.Size(100, 20);
            this.txtValorP.TabIndex = 3;
            this.txtValorP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado prob =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X =";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(58, 256);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "P =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "N =";
            // 
            // txtValorN
            // 
            this.txtValorN.Location = new System.Drawing.Point(49, 113);
            this.txtValorN.Name = "txtValorN";
            this.txtValorN.Size = new System.Drawing.Size(100, 20);
            this.txtValorN.TabIndex = 2;
            this.txtValorN.TextChanged += new System.EventHandler(this.txtValorN_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.PanelDEN);
            this.panel4.Controls.Add(this.panelCalculadoraBinominal);
            this.panel4.Location = new System.Drawing.Point(277, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(693, 438);
            this.panel4.TabIndex = 16;
            // 
            // PanelDEN
            // 
            this.PanelDEN.Controls.Add(this.pictureBox3);
            this.PanelDEN.Controls.Add(this.txto);
            this.PanelDEN.Controls.Add(this.txtu);
            this.PanelDEN.Controls.Add(this.txtx);
            this.PanelDEN.Controls.Add(this.label14);
            this.PanelDEN.Controls.Add(this.label13);
            this.PanelDEN.Controls.Add(this.label12);
            this.PanelDEN.Controls.Add(this.listBox1);
            this.PanelDEN.Controls.Add(this.button2);
            this.PanelDEN.Location = new System.Drawing.Point(50, 40);
            this.PanelDEN.Name = "PanelDEN";
            this.PanelDEN.Size = new System.Drawing.Size(610, 350);
            this.PanelDEN.TabIndex = 16;
            this.PanelDEN.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.label8;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel5.Controls.Add(this.bunifuGradientPanel2);
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 438);
            this.panel5.TabIndex = 17;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuFlatButton2);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(12, 9);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(259, 413);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   Distribucion Normal Estandar";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(5, 72);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(245, 48);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "   Distribucion Normal Estandar";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Probabilidad Binominal";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(5, 18);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(245, 48);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "   Probabilidad Binominal";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "x:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "u:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(188, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "o:";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(209, 197);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 20);
            this.txtx.TabIndex = 5;
            // 
            // txtu
            // 
            this.txtu.Location = new System.Drawing.Point(208, 238);
            this.txtu.Name = "txtu";
            this.txtu.Size = new System.Drawing.Size(100, 20);
            this.txtu.TabIndex = 6;
            // 
            // txto
            // 
            this.txto.Location = new System.Drawing.Point(210, 276);
            this.txto.Name = "txto";
            this.txto.Size = new System.Drawing.Size(100, 20);
            this.txto.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(198, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(377, 160);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 487);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCalculadoraBinominal.ResumeLayout(false);
            this.panelCalculadoraBinominal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.PanelDEN.ResumeLayout(false);
            this.PanelDEN.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl MoverCalculadora;
        private System.Windows.Forms.Panel panelCalculadoraBinominal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listhistorial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValorX;
        private System.Windows.Forms.Label resultadototal;
        private System.Windows.Forms.TextBox txtValorP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnBorrarS;
        private System.Windows.Forms.TextBox txtrangofin;
        private System.Windows.Forms.Label lbrangohasta;
        private System.Windows.Forms.TextBox txtrangoin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnRemoveList;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Panel PanelDEN;
        private System.Windows.Forms.TextBox txto;
        private System.Windows.Forms.TextBox txtu;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


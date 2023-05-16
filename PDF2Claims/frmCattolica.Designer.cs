namespace PDF2Claims
{
    partial class frmCattolica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPDF = new System.Windows.Forms.Label();
            this.cmdOpenPDF = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSinistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataIncarico = new System.Windows.Forms.TextBox();
            this.txtDataEvento = new System.Windows.Forms.TextBox();
            this.txtGaranzia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuogoAccadimento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescrAccadimento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPIVA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAssicuratoInd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAssicurato = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContraenteInd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContraente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAgenzia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPolizza = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtStima = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDanni = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDanneggiatoInd = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDanneggiato = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDataEffettoPolizza = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtEnte = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAutorita = new System.Windows.Forms.TextBox();
            this.txtVerbale = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblPDF);
            this.groupBox1.Controls.Add(this.cmdOpenPDF);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestione files";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Visualizza PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPDF
            // 
            this.lblPDF.AutoSize = true;
            this.lblPDF.Location = new System.Drawing.Point(15, 52);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(16, 13);
            this.lblPDF.TabIndex = 1;
            this.lblPDF.Text = "...";
            // 
            // cmdOpenPDF
            // 
            this.cmdOpenPDF.Location = new System.Drawing.Point(15, 17);
            this.cmdOpenPDF.Name = "cmdOpenPDF";
            this.cmdOpenPDF.Size = new System.Drawing.Size(75, 23);
            this.cmdOpenPDF.TabIndex = 0;
            this.cmdOpenPDF.Text = "Apri PDF";
            this.cmdOpenPDF.UseVisualStyleBackColor = true;
            this.cmdOpenPDF.Click += new System.EventHandler(this.cmdOpenPDF_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(442, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 37);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDataEvento);
            this.groupBox2.Controls.Add(this.txtDataIncarico);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPL);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPerito);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 71);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intestazione:";
            // 
            // txtPL
            // 
            this.txtPL.Location = new System.Drawing.Point(272, 30);
            this.txtPL.Name = "txtPL";
            this.txtPL.Size = new System.Drawing.Size(29, 20);
            this.txtPL.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Autorizz. PL";
            // 
            // txtPerito
            // 
            this.txtPerito.Location = new System.Drawing.Point(61, 30);
            this.txtPerito.Name = "txtPerito";
            this.txtPerito.Size = new System.Drawing.Size(108, 20);
            this.txtPerito.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Perito";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescrAccadimento);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtLuogoAccadimento);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtGaranzia);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtRamo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtSinistro);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(28, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 141);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dati evento:";
            // 
            // txtRamo
            // 
            this.txtRamo.Location = new System.Drawing.Point(227, 29);
            this.txtRamo.Name = "txtRamo";
            this.txtRamo.Size = new System.Drawing.Size(309, 20);
            this.txtRamo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ramo";
            // 
            // txtSinistro
            // 
            this.txtSinistro.Location = new System.Drawing.Point(69, 29);
            this.txtSinistro.Name = "txtSinistro";
            this.txtSinistro.Size = new System.Drawing.Size(100, 20);
            this.txtSinistro.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sinistro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data incarico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(585, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data evento";
            // 
            // txtDataIncarico
            // 
            this.txtDataIncarico.Location = new System.Drawing.Point(460, 30);
            this.txtDataIncarico.Name = "txtDataIncarico";
            this.txtDataIncarico.Size = new System.Drawing.Size(76, 20);
            this.txtDataIncarico.TabIndex = 15;
            // 
            // txtDataEvento
            // 
            this.txtDataEvento.Location = new System.Drawing.Point(657, 30);
            this.txtDataEvento.Name = "txtDataEvento";
            this.txtDataEvento.Size = new System.Drawing.Size(76, 20);
            this.txtDataEvento.TabIndex = 16;
            // 
            // txtGaranzia
            // 
            this.txtGaranzia.Location = new System.Drawing.Point(69, 55);
            this.txtGaranzia.Name = "txtGaranzia";
            this.txtGaranzia.Size = new System.Drawing.Size(467, 20);
            this.txtGaranzia.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Garanzia";
            // 
            // txtLuogoAccadimento
            // 
            this.txtLuogoAccadimento.Location = new System.Drawing.Point(69, 78);
            this.txtLuogoAccadimento.Name = "txtLuogoAccadimento";
            this.txtLuogoAccadimento.Size = new System.Drawing.Size(467, 20);
            this.txtLuogoAccadimento.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Luogo";
            // 
            // txtDescrAccadimento
            // 
            this.txtDescrAccadimento.Location = new System.Drawing.Point(69, 101);
            this.txtDescrAccadimento.Name = "txtDescrAccadimento";
            this.txtDescrAccadimento.Size = new System.Drawing.Size(467, 20);
            this.txtDescrAccadimento.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Descr";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDataEffettoPolizza);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtPolizza);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtAgenzia);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtPIVA);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtAssicuratoInd);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtAssicurato);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtContraenteInd);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtContraente);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(28, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(900, 162);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dati Polizza:";
            // 
            // txtPIVA
            // 
            this.txtPIVA.Location = new System.Drawing.Point(69, 90);
            this.txtPIVA.Name = "txtPIVA";
            this.txtPIVA.Size = new System.Drawing.Size(180, 20);
            this.txtPIVA.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "C.F./P.IVA";
            // 
            // txtAssicuratoInd
            // 
            this.txtAssicuratoInd.Location = new System.Drawing.Point(568, 58);
            this.txtAssicuratoInd.Name = "txtAssicuratoInd";
            this.txtAssicuratoInd.Size = new System.Drawing.Size(309, 20);
            this.txtAssicuratoInd.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Indirizzo";
            // 
            // txtAssicurato
            // 
            this.txtAssicurato.Location = new System.Drawing.Point(69, 55);
            this.txtAssicurato.Name = "txtAssicurato";
            this.txtAssicurato.Size = new System.Drawing.Size(348, 20);
            this.txtAssicurato.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Assicurato";
            // 
            // txtContraenteInd
            // 
            this.txtContraenteInd.Location = new System.Drawing.Point(568, 26);
            this.txtContraenteInd.Name = "txtContraenteInd";
            this.txtContraenteInd.Size = new System.Drawing.Size(309, 20);
            this.txtContraenteInd.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(491, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Indirizzo";
            // 
            // txtContraente
            // 
            this.txtContraente.Location = new System.Drawing.Point(69, 29);
            this.txtContraente.Name = "txtContraente";
            this.txtContraente.Size = new System.Drawing.Size(348, 20);
            this.txtContraente.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Contraente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(491, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Agenzia";
            // 
            // txtAgenzia
            // 
            this.txtAgenzia.Location = new System.Drawing.Point(568, 87);
            this.txtAgenzia.Name = "txtAgenzia";
            this.txtAgenzia.Size = new System.Drawing.Size(309, 20);
            this.txtAgenzia.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Polizza";
            // 
            // txtPolizza
            // 
            this.txtPolizza.Location = new System.Drawing.Point(69, 118);
            this.txtPolizza.Name = "txtPolizza";
            this.txtPolizza.Size = new System.Drawing.Size(180, 20);
            this.txtPolizza.TabIndex = 22;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtStima);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.txtDanni);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txtDanneggiatoInd);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.txtDanneggiato);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Location = new System.Drawing.Point(28, 492);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(900, 108);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dati Danneggiato:";
            // 
            // txtStima
            // 
            this.txtStima.Location = new System.Drawing.Point(83, 83);
            this.txtStima.Name = "txtStima";
            this.txtStima.Size = new System.Drawing.Size(83, 20);
            this.txtStima.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Stima danno";
            // 
            // txtDanni
            // 
            this.txtDanni.Location = new System.Drawing.Point(83, 55);
            this.txtDanni.Name = "txtDanni";
            this.txtDanni.Size = new System.Drawing.Size(348, 20);
            this.txtDanni.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Danni";
            // 
            // txtDanneggiatoInd
            // 
            this.txtDanneggiatoInd.Location = new System.Drawing.Point(568, 26);
            this.txtDanneggiatoInd.Multiline = true;
            this.txtDanneggiatoInd.Name = "txtDanneggiatoInd";
            this.txtDanneggiatoInd.Size = new System.Drawing.Size(309, 70);
            this.txtDanneggiatoInd.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(491, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "Indirizzo";
            // 
            // txtDanneggiato
            // 
            this.txtDanneggiato.Location = new System.Drawing.Point(83, 29);
            this.txtDanneggiato.Name = "txtDanneggiato";
            this.txtDanneggiato.Size = new System.Drawing.Size(348, 20);
            this.txtDanneggiato.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Danneggiato";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(439, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Data EffettoPolizza";
            // 
            // txtDataEffettoPolizza
            // 
            this.txtDataEffettoPolizza.Location = new System.Drawing.Point(568, 118);
            this.txtDataEffettoPolizza.Name = "txtDataEffettoPolizza";
            this.txtDataEffettoPolizza.Size = new System.Drawing.Size(76, 20);
            this.txtDataEffettoPolizza.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(403, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 54);
            this.panel1.TabIndex = 20;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(180, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Drag && Drop ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtVerbale);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.txtAutorita);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.txtEnte);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(28, 606);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(900, 89);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Varie";
            // 
            // txtEnte
            // 
            this.txtEnte.Location = new System.Drawing.Point(58, 63);
            this.txtEnte.Name = "txtEnte";
            this.txtEnte.Size = new System.Drawing.Size(348, 20);
            this.txtEnte.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Ente";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Autorità";
            // 
            // txtAutorita
            // 
            this.txtAutorita.Location = new System.Drawing.Point(58, 24);
            this.txtAutorita.Name = "txtAutorita";
            this.txtAutorita.Size = new System.Drawing.Size(348, 20);
            this.txtAutorita.TabIndex = 18;
            // 
            // txtVerbale
            // 
            this.txtVerbale.Location = new System.Drawing.Point(541, 24);
            this.txtVerbale.Name = "txtVerbale";
            this.txtVerbale.Size = new System.Drawing.Size(348, 20);
            this.txtVerbale.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(493, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 13);
            this.label25.TabIndex = 19;
            this.label25.Text = "Verbale";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmdInsert);
            this.groupBox7.Controls.Add(this.cmdExit);
            this.groupBox7.Location = new System.Drawing.Point(28, 701);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(900, 76);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Esegui";
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(790, 19);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(87, 40);
            this.cmdExit.TabIndex = 0;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdInsert
            // 
            this.cmdInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdInsert.Location = new System.Drawing.Point(20, 19);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(87, 40);
            this.cmdInsert.TabIndex = 1;
            this.cmdInsert.Text = "Inserisci dati";
            this.cmdInsert.UseVisualStyleBackColor = false;
            // 
            // frmCattolica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 789);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCattolica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCattolica";
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmCattolica_DragOver);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdOpenPDF;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSinistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataEvento;
        private System.Windows.Forms.TextBox txtDataIncarico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescrAccadimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLuogoAccadimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGaranzia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAgenzia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPIVA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAssicuratoInd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAssicurato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtContraenteInd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtContraente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPolizza;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtStima;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDanni;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDanneggiatoInd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDanneggiato;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtDataEffettoPolizza;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtEnte;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAutorita;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtVerbale;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdInsert;
    }
}
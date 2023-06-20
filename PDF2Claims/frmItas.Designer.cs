namespace PDF2Claims
{
    partial class frmItas
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
            this.cmdClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPDF = new System.Windows.Forms.Label();
            this.cmdOpenPDF = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataLimite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDanneggiato = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDatiIncarico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataPresaInCarico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataChisura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUbicazione = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiduciario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataIncarico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodiceIncarico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDataInserimento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCompagnia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLocEvento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDataEvento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDataDenuncia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRamo = new System.Windows.Forms.TextBox();
            this.Ramo = new System.Windows.Forms.Label();
            this.txtSinistro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAgenzia = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGaranzieColpite = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPolizza = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdClear);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblPDF);
            this.groupBox1.Controls.Add(this.cmdOpenPDF);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestione files";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(236, 17);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 21;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
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
            this.groupBox2.Controls.Add(this.txtPL);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDataLimite);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDanneggiato);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDatiIncarico);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDataPresaInCarico);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDataChisura);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtUbicazione);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFiduciario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDataIncarico);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodiceIncarico);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 143);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estremi incarico :";
            // 
            // txtPL
            // 
            this.txtPL.Location = new System.Drawing.Point(647, 73);
            this.txtPL.Name = "txtPL";
            this.txtPL.Size = new System.Drawing.Size(29, 20);
            this.txtPL.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "PL";
            // 
            // txtDataLimite
            // 
            this.txtDataLimite.Location = new System.Drawing.Point(647, 99);
            this.txtDataLimite.Name = "txtDataLimite";
            this.txtDataLimite.Size = new System.Drawing.Size(100, 20);
            this.txtDataLimite.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Data limite";
            // 
            // txtDanneggiato
            // 
            this.txtDanneggiato.Location = new System.Drawing.Point(124, 73);
            this.txtDanneggiato.Name = "txtDanneggiato";
            this.txtDanneggiato.Size = new System.Drawing.Size(429, 20);
            this.txtDanneggiato.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Danneggiato";
            // 
            // txtDatiIncarico
            // 
            this.txtDatiIncarico.Location = new System.Drawing.Point(588, 17);
            this.txtDatiIncarico.Name = "txtDatiIncarico";
            this.txtDatiIncarico.Size = new System.Drawing.Size(281, 20);
            this.txtDatiIncarico.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dati incarico ";
            // 
            // txtDataPresaInCarico
            // 
            this.txtDataPresaInCarico.Location = new System.Drawing.Point(588, 46);
            this.txtDataPresaInCarico.Name = "txtDataPresaInCarico";
            this.txtDataPresaInCarico.Size = new System.Drawing.Size(100, 20);
            this.txtDataPresaInCarico.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data presa in carico";
            // 
            // txtDataChisura
            // 
            this.txtDataChisura.Location = new System.Drawing.Point(345, 47);
            this.txtDataChisura.Name = "txtDataChisura";
            this.txtDataChisura.Size = new System.Drawing.Size(100, 20);
            this.txtDataChisura.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data chiusura";
            // 
            // txtUbicazione
            // 
            this.txtUbicazione.Location = new System.Drawing.Point(124, 99);
            this.txtUbicazione.Name = "txtUbicazione";
            this.txtUbicazione.Size = new System.Drawing.Size(429, 20);
            this.txtUbicazione.TabIndex = 7;
            this.txtUbicazione.TextChanged += new System.EventHandler(this.txtUbicazione_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ubicazione";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFiduciario
            // 
            this.txtFiduciario.Location = new System.Drawing.Point(345, 17);
            this.txtFiduciario.Name = "txtFiduciario";
            this.txtFiduciario.Size = new System.Drawing.Size(100, 20);
            this.txtFiduciario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiduciario";
            // 
            // txtDataIncarico
            // 
            this.txtDataIncarico.Location = new System.Drawing.Point(124, 43);
            this.txtDataIncarico.Name = "txtDataIncarico";
            this.txtDataIncarico.Size = new System.Drawing.Size(100, 20);
            this.txtDataIncarico.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data incarico";
            // 
            // txtCodiceIncarico
            // 
            this.txtCodiceIncarico.Location = new System.Drawing.Point(124, 17);
            this.txtCodiceIncarico.Name = "txtCodiceIncarico";
            this.txtCodiceIncarico.Size = new System.Drawing.Size(100, 20);
            this.txtCodiceIncarico.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice incarico";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDataInserimento);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtCompagnia);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtLocEvento);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtDataEvento);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtDataDenuncia);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtRamo);
            this.groupBox3.Controls.Add(this.Ramo);
            this.groupBox3.Controls.Add(this.txtSinistro);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(14, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(897, 194);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dati SINISTRO:";
            // 
            // txtDataInserimento
            // 
            this.txtDataInserimento.Location = new System.Drawing.Point(579, 59);
            this.txtDataInserimento.Name = "txtDataInserimento";
            this.txtDataInserimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataInserimento.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(485, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Data inserimento";
            // 
            // txtCompagnia
            // 
            this.txtCompagnia.Location = new System.Drawing.Point(122, 129);
            this.txtCompagnia.Name = "txtCompagnia";
            this.txtCompagnia.Size = new System.Drawing.Size(429, 20);
            this.txtCompagnia.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Compagnia";
            // 
            // txtLocEvento
            // 
            this.txtLocEvento.Location = new System.Drawing.Point(122, 97);
            this.txtLocEvento.Name = "txtLocEvento";
            this.txtLocEvento.Size = new System.Drawing.Size(429, 20);
            this.txtLocEvento.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Località evento";
            // 
            // txtDataEvento
            // 
            this.txtDataEvento.Location = new System.Drawing.Point(343, 55);
            this.txtDataEvento.Name = "txtDataEvento";
            this.txtDataEvento.Size = new System.Drawing.Size(100, 20);
            this.txtDataEvento.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Data evento";
            // 
            // txtDataDenuncia
            // 
            this.txtDataDenuncia.Location = new System.Drawing.Point(122, 55);
            this.txtDataDenuncia.Name = "txtDataDenuncia";
            this.txtDataDenuncia.Size = new System.Drawing.Size(100, 20);
            this.txtDataDenuncia.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Data denuncia";
            // 
            // txtRamo
            // 
            this.txtRamo.Location = new System.Drawing.Point(343, 23);
            this.txtRamo.Name = "txtRamo";
            this.txtRamo.Size = new System.Drawing.Size(100, 20);
            this.txtRamo.TabIndex = 5;
            // 
            // Ramo
            // 
            this.Ramo.AutoSize = true;
            this.Ramo.Location = new System.Drawing.Point(268, 26);
            this.Ramo.Name = "Ramo";
            this.Ramo.Size = new System.Drawing.Size(35, 13);
            this.Ramo.TabIndex = 4;
            this.Ramo.Text = "Ramo";
            // 
            // txtSinistro
            // 
            this.txtSinistro.Location = new System.Drawing.Point(122, 23);
            this.txtSinistro.Name = "txtSinistro";
            this.txtSinistro.Size = new System.Drawing.Size(100, 20);
            this.txtSinistro.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Sinistro";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAgenzia);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtGaranzieColpite);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtPolizza);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(14, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(898, 100);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Soggetti coinvolti";
            // 
            // txtAgenzia
            // 
            this.txtAgenzia.Location = new System.Drawing.Point(122, 59);
            this.txtAgenzia.Name = "txtAgenzia";
            this.txtAgenzia.Size = new System.Drawing.Size(100, 20);
            this.txtAgenzia.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Agenzia";
            // 
            // txtGaranzieColpite
            // 
            this.txtGaranzieColpite.Location = new System.Drawing.Point(369, 28);
            this.txtGaranzieColpite.Multiline = true;
            this.txtGaranzieColpite.Name = "txtGaranzieColpite";
            this.txtGaranzieColpite.Size = new System.Drawing.Size(498, 51);
            this.txtGaranzieColpite.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(275, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Gar.colpite";
            // 
            // txtPolizza
            // 
            this.txtPolizza.Location = new System.Drawing.Point(122, 28);
            this.txtPolizza.Name = "txtPolizza";
            this.txtPolizza.Size = new System.Drawing.Size(100, 20);
            this.txtPolizza.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Polizza";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel2);
            this.groupBox7.Controls.Add(this.cmdInsert);
            this.groupBox7.Controls.Add(this.cmdExit);
            this.groupBox7.Location = new System.Drawing.Point(12, 562);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(900, 76);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Esegui";
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label27);
            this.panel2.Location = new System.Drawing.Point(205, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 54);
            this.panel2.TabIndex = 21;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(162, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(208, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "Drag && Drop  ZIP file";
            // 
            // cmdInsert
            // 
            this.cmdInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdInsert.Location = new System.Drawing.Point(58, 21);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(87, 40);
            this.cmdInsert.TabIndex = 1;
            this.cmdInsert.Text = "Inserisci dati";
            this.cmdInsert.UseVisualStyleBackColor = false;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
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
            // frmItas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 643);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmItas";
            this.Text = "frmItas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.Button cmdOpenPDF;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodiceIncarico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataIncarico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiduciario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUbicazione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataPresaInCarico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDataChisura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatiIncarico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDanneggiato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDataLimite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDataDenuncia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRamo;
        private System.Windows.Forms.Label Ramo;
        private System.Windows.Forms.TextBox txtSinistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDataEvento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLocEvento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCompagnia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDataInserimento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPolizza;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGaranzieColpite;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAgenzia;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdExit;
    }
}
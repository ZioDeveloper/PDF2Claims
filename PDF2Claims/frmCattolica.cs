using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using System.Diagnostics;
using System.Reflection;

using System.Net;
using iText.Kernel.Pdf.Canvas.Parser.Filter;
using iText.Kernel.Geom;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;

namespace PDF2Claims
{
    public partial class frmCattolica : Form
    {
        #region
        string myPDFText = "";
        string input = "";
        string pattern = "";
        string Perito = "";
        string Autorizzazione = "";
        string DataIncarico = "";
        string DataEvento = "";
        string Sinistro = "";
        string Ramo = "";
        string GaranziaColpita = "";
        string LuogoAccadimento = "";
        string DescrizioneEvento = "";
        string Contraente = "";
        string Assicurato = "";
        string Indirizzo = "";
        string IndirizzoAssicurato = "";
        string CodFiscale = "";
        string Telefono = "";
        string Polizza = "";
        string Agenzia = "";
        string DataeffettoPolizza = "";
        string Danneggiato = "";
        string IndirizzoDanneggiato = "";
        string Danni = "";
        string Danno = "";
        string Verbale = "";
        string Intervento = "";
        string Garanzia = "";
        string Autorita = "";
        string Ente = "";
        bool max = false;
        string myPathPDF = "";
        string myFileNamePDF = "";
        string myGestione = "";
        string LastID = "";
        string aNewFolder = "";
        string myIDRamo = "";

        #endregion
        public frmCattolica()
        {
            InitializeComponent();
            panel1.AllowDrop = true;
            panel2.AllowDrop = true;
            
            comboBox1.Items.Add("Rami elementari");
            comboBox1.Items.Add("Trasporti");

            // Imposta l'indice predefinito del ComboBox
            comboBox1.SelectedIndex = 0;
            panel2.Visible = false;
        }

        private void cmdOpenPDF_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona un elemento!");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File PDF (*.pdf)|*.pdf";
            openFileDialog.InitialDirectory = @"C:\Test";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor; // Imposta il cursore come WaitCursor
                                                     // Esegui l'operazione che richiede tempo
                

                string selectedFilePath = openFileDialog.FileName;
                // Fai qualcosa con il percorso del file selezionato
                // ad esempio, apri il file utilizzando il lettore di PDF predefinito del sistema:
                //System.Diagnostics.Process.Start(selectedFilePath);
                lblPDF.Text = selectedFilePath;
                myPDFText = ExtractTextFromDoc();
                if (myPDFText == "")
                    return;

                richTextBox1.Text = myPDFText;
                Refresh();
                DecodePDF(myPDFText);
                Cursor.Current = Cursors.Default; // Ripristina il cursore predefinito
                Refresh();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            System.Diagnostics.Process.Start(lblPDF.Text);
        }

        public string ExtractTextFromDoc()
        {
            if(lblPDF.Text.Right(3).ToUpper() != "PDF")
            {
                MessageBox.Show("Tipo file errato !");
                return "";
            }

            StringBuilder builder = new StringBuilder();

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(lblPDF.Text));
            int i = 1;

            // Rectangle(0, 0, 595, 842)


            int aX = 0, aY =0, aW = 1000, aH=1000;
            //bool success = false;
            //success = Int32.TryParse(X.Text, out aX);
            //success = Int32.TryParse(Y.Text, out aY);
            //success = Int32.TryParse(W.Text, out aW);
            //success = Int32.TryParse(H.Text, out aH);

            iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(aX, aY, aW, aH);



            //iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(85, 715, 10, 30); 640


            TextRegionEventFilter regionFilter = new TextRegionEventFilter(rect);
            PageSize mediabox = pdfDoc.GetDefaultPageSize();


            for (int page = 1; page <= 1 /*pdfDoc.GetNumberOfPages()*/; page++)
            {
                ITextExtractionStrategy strategy = new FilteredTextEventListener(new LocationTextExtractionStrategy(), regionFilter);
                String str = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy) + "\n\n";
                builder.Append(str);
            }

            
            pdfDoc.Close();
            
            return builder.ToString();
        }

        public void DecodePDF(string PDFText)
        {
            input = richTextBox1.Lines[0].ToString();

            pattern = @"Perito: (.+?)\b";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                Perito = match.Groups[1].Value;
                txtPerito.Text = Perito;
            }

            if(String.IsNullOrEmpty(Perito))
            {
                MessageBox.Show("File non corretto !");
                return;
            }

            pattern = @"Autorizzazione alla PL: (.+)$";
            match = Regex.Match(input, pattern);

            if (match.Success)
            {
                Autorizzazione = match.Groups[1].Value;
                txtPL.Text = Autorizzazione;
                
            }

            input = richTextBox1.Lines[1].ToString();
            pattern = @"\b\d{2}-\d{2}-\d{4}\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            int prog = 0;
            foreach (Match matchD in matches)
            {
                if (prog == 0)
                    DataIncarico = matchD.Value;
                else
                    DataEvento = matchD.Value;
                prog++;
            }

            txtDataIncarico.Text = DataIncarico;
            txtDataEvento.Text = DataEvento;

            input = richTextBox1.Lines[3].ToString();
            pattern = @"Sinistro n\. (\d+)\b";
            match = Regex.Match(input, pattern);

            if (match.Success)
            {
                Sinistro = match.Groups[1].Value;
                txtSinistro.Text = Sinistro;

            }

            pattern = @"Ramo: (.+)";
            match = Regex.Match(input, pattern);

            if (match.Success)
            {
                Ramo = match.Groups[1].Value;
                txtRamo.Text = Ramo;

            }

            input = richTextBox1.Lines[4].ToString();
            pattern = @"Garanzia colpita(.+?) Indice Anomalia:";
            match = Regex.Match(input, pattern);

            if (match.Success)
            {
                GaranziaColpita = match.Groups[1].Value;
                txtGaranzia.Text = GaranziaColpita;

            }

            input = richTextBox1.Lines[5].ToString();
            pattern = @"Luogo accadimento: (.+)$";
            match = Regex.Match(input, pattern);

            if (match.Success)
            {
                LuogoAccadimento = match.Groups[1].Value;
                txtLuogoAccadimento.Text = LuogoAccadimento;

            }

            input = richTextBox1.Lines[6].ToString();
            pattern = @"Descrizione evento:((.|\n)+)DATI POLIZZA";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                DescrizioneEvento = match.Groups[1].Value;
                txtDescrAccadimento.Text = DescrizioneEvento;

            }

            //input = richTextBox1.Lines[8].ToString();
            pattern = @"Contraente: (.+?) Indirizzo: ";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Contraente = match.Groups[1].Value;
                txtContraente.Text = Contraente;

            }

            pattern = @"Assicurato: (.+?) Indirizzo: ";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Assicurato = match.Groups[1].Value;
                txtAssicurato.Text = Assicurato;

            }


            pattern = @"Indirizzo: ([\s\S]+?)\r?\nAssicurato:";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Indirizzo = match.Groups[1].Value;
                txtContraenteInd.Text = Indirizzo;

            }

            pattern = @"Indirizzo: ([\s\S]+?)\r?\nAssicurato:";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                IndirizzoAssicurato = match.Groups[1].Value;
                txtAssicuratoInd.Text = IndirizzoAssicurato;

            }



            pattern = @"Cod\.Fisc \/ P\.IVA: (.+?) Telefono:";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                CodFiscale = match.Groups[1].Value;
                txtPIVA.Text = CodFiscale;

            }

            
            pattern = @"Telefono: (.+?)\r?\nPolizza n\.";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Telefono = match.Groups[1].Value;

            }

            pattern = @"Polizza n\. (.+?) Agenzia:";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Polizza = match.Groups[1].Value;
                txtPolizza.Text = Polizza;

            }

            pattern = @"Agenzia: (.+?)\(";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Agenzia = match.Groups[1].Value;
                txtAgenzia.Text = Agenzia;

            }

            pattern = @"Data effetto Polizza: (\d{2}-\d{2}-\d{4})";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                DataeffettoPolizza = match.Groups[1].Value;
                txtDataEffettoPolizza.Text = DataeffettoPolizza;

            }

            
            pattern = @"Danneggiato: (.+?) Telefono:";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Danneggiato = match.Groups[1].Value;
                txtDanneggiato.Text = Danneggiato;

            }

            
            pattern = @"Indirizzo (.+?[\n])*sopralluogo";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                IndirizzoDanneggiato = match.Groups[1].Value;
                txtDanneggiatoInd.Text = IndirizzoDanneggiato;
            }

            
            pattern = @"Danni:(.+) * Stima";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Danni = match.Groups[1].Value;
                txtDanni.Text = Danni;
            }
            
            pattern = @"Stima Danno:(.+)*";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Danno = match.Groups[1].Value;
                txtStima.Text = Danno;
            }

            
            pattern = @"Garanzia - Natura Danno(.+) *";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Garanzia = match.Groups[1].Value;
            }

            
            
            pattern = @"Intervento:(.+) * Verbale";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Intervento = match.Groups[1].Value;
            }

           
            pattern = @"Verbale:(.+) *";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Verbale = match.Groups[1].Value;
                txtVerbale.Text = Verbale;
            }

            pattern = @"Autorità: (.+) * Comune";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Autorita = match.Groups[1].Value;
                txtAutorita.Text = Autorita;
            }

            pattern = @"Ente di Trattazione: (.+) * Liquidatore";
            match = Regex.Match(PDFText, pattern);

            if (match.Success)
            {
                Ente = match.Groups[1].Value;
                txtEnte.Text = Ente;
            }

            



        }

        public void SavePDF(string aFile)
        {
            string directoryPath = @"\\gefilesrv01\Disco_R\CATTOLICA\SX CATTOLICA 2022- 2023\@TEMP\";
            
            string myFileName = txtSinistro.Text.ToUpper() + " - " + txtContraente.Text.ToUpper().Replace(".", "") + ".PDF";
            string myFolderName = myFileName;

            //Process process = Process.Start(aFile);
            //if (process != null && !process.HasExited)
            //{
            //    process.CloseMainWindow();
            //    process.WaitForExit(); // Aspetta che l'applicazione venga chiusa
            //    process.Dispose();
            //    //Console.WriteLine("File PDF chiuso correttamente.");
            //}



            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                
            }

            aNewFolder = directoryPath + txtSinistro.Text.ToUpper() + " - " + txtContraente.Text.ToUpper().Replace(".","");

            if (!Directory.Exists(aNewFolder))
            {
                Directory.CreateDirectory(aNewFolder);

            }

            File.Copy(aFile, aNewFolder.TrimEnd() + @"\" + myFileName,true);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            panel2.Visible = false;
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona un elemento!");
                return;
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Gestisci i file qui, ad esempio:
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string myFile = "";

            foreach (var item in fileList)
            {
                Cursor.Current = Cursors.WaitCursor;
                myFile = item.ToString();
                lblPDF.Text = myFile;
                
                myPDFText = ExtractTextFromDoc();
                if (myPDFText == "")
                    return;
                richTextBox1.Text = myPDFText;
                Refresh();
                
                DecodePDF(myPDFText);
                Cursor.Current = Cursors.Default; // Ripristina il cursore predefinito
                //SavePDF(myFile);
                Refresh();

            }
        }


        private void cmdInsert_Click(object sender, EventArgs e)
        {
            bool CanInsertStatus = false;
            int lastInsertedId = 0;

            string dateString = "";
            
            string cs = Utils.GetConnectionStringByName("CLAIMSITC");
            cs += "User ID=" + Utils.AppUser + ";Password=" + Utils.AppPassword;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        //string sqlstm = " INSERT INTO Pratiche(numeroSinistroCompagnia, numeroSinistroCompagnia_PROG, ID_ramo, ID_gestione,ID_gruppoAssicurativo ,ID_compagniaAssicurativa , dataAffidamentoIncarico, "
                        //               + " dataAccadimento, indirizzoAccadimento_indirizzoCompletoDaFlussoGenerali, descrizioneSinistro,ID_modalitaAssegnazione, "
                        //               + " importoStimato, numeroPolizza, contraente_cognome, contraente_ragioneSociale,contraente_codiceFiscale_partitaIva, "
                        //               + " contraente_indirizzoCompletoDaFlussoGenerali, beneficiario_cognome, beneficiario_indirizzoCompletoDaFlussoGenerali) "
                        //               + " VALUES(@numeroSinistroCompagnia,@numeroSinistroCompagnia_PROG, @ID_ramo, @ID_gestione, @ID_gruppoAssicurativo ,@ID_compagniaAssicurativa , @dataAffidamentoIncarico, @ID_modalitaAssegnazione , "
                        //               + " @dataAccadimento, @indirizzoAccadimento_indirizzoCompletoDaFlussoGenerali, @descrizioneSinistro, "
                        //               + " @importoStimato, @numeroPolizza, @contraente_cognome, @contraente_ragioneSociale, @contraente_codiceFiscale_partitaIva, "
                        //               + " @contraente_indirizzoCompletoDaFlussoGenerali, @beneficiario_cognome, @beneficiario_indirizzoCompletoDaFlussoGenerali) ";



                        string sqlstm = " INSERT INTO Pratiche(numeroSinistroCompagnia, numeroSinistroCompagnia_PROG, ID_ramo, ID_gestione,ID_gruppoAssicurativo , "
                                + " ID_compagniaAssicurativa, insertUser, updUSer,dataAffidamentoIncarico, dataAccadimento, indirizzoAccadimento_indirizzoCompletoDaFlussoGenerali ," 
                                + " descrizioneSinistro,ID_modalitaAssegnazione,importoStimato, numeroPolizza,contraente_cognome,contraente_ragioneSociale,contraente_codiceFiscale_partitaIva, "
                                + " contraente_indirizzoCompletoDaFlussoGenerali,beneficiario_cognome,beneficiario_indirizzoCompletoDaFlussoGenerali,noteSinistro) "
                                + " OUTPUT INSERTED.ID VALUES(@numeroSinistroCompagnia,@numeroSinistroCompagnia_PROG, @ID_ramo, @ID_gestione, @ID_gruppoAssicurativo , "
                                + " @ID_compagniaAssicurativa, @insertUser, @updUSer, @dataAffidamentoIncarico, @dataAccadimento, @indirizzoAccadimento_indirizzoCompletoDaFlussoGenerali, " 
                                + " @descrizioneSinistro, @ID_modalitaAssegnazione, @importoStimato, @numeroPolizza,@contraente_cognome,@contraente_ragioneSociale,@contraente_codiceFiscale_partitaIva, "
                                + " @contraente_indirizzoCompletoDaFlussoGenerali,@beneficiario_cognome,@beneficiario_indirizzoCompletoDaFlussoGenerali,@noteSinistro) ";

                        cmd.CommandText = sqlstm;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@numeroSinistroCompagnia", txtSinistro.Text); //txtSinistro.Text;
                        cmd.Parameters.AddWithValue("@numeroSinistroCompagnia_PROG", 1);
                        myIDRamo = FindIDRamo(txtRamo.Text.Left(2), myGestione);
                        if( myIDRamo == "")
                        {
                            MessageBox.Show("Scelta Gestione non corretta !");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@ID_ramo", myIDRamo);
                        cmd.Parameters.AddWithValue("@ID_gestione", myGestione);
                        cmd.Parameters.AddWithValue("@ID_gruppoAssicurativo", 2);

                        // I sinistri che iniziano con 4 sono di TUA Assicurazioni (ID = 12)
                        if (txtSinistro.Text.Left(1)!= "4")
                            cmd.Parameters.AddWithValue("@ID_compagniaAssicurativa", 9);
                        else
                            cmd.Parameters.AddWithValue("@ID_compagniaAssicurativa", 12);

                        cmd.Parameters.AddWithValue("@insertUser", "BOT");
                        cmd.Parameters.AddWithValue("@updUSer", "BOT");
                        
                        dateString =  txtDataIncarico.Text;
                        DateTime dtDataIncarico = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
                        string myDate = dtDataIncarico.Year.ToString("0000") + dtDataIncarico.Month.ToString("00") + dtDataIncarico.Day.ToString("00");
                        cmd.Parameters.AddWithValue("@dataAffidamentoIncarico", dtDataIncarico);

                        
                        dateString = txtDataEvento.Text;
                        DateTime dtDataAccadimento = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
                        myDate = dtDataAccadimento.Year.ToString("0000") + dtDataAccadimento.Month.ToString("00") + dtDataAccadimento.Day.ToString("00");
                        cmd.Parameters.AddWithValue("@dataAccadimento", dtDataAccadimento);
                       

                        cmd.Parameters.AddWithValue("@indirizzoAccadimento_indirizzoCompletoDaFlussoGenerali", txtLuogoAccadimento.Text);
                        cmd.Parameters.AddWithValue("@descrizioneSinistro",txtDescrAccadimento.Text);
                       
                       if (txtPL.Text.ToUpper() == "NO")
                           cmd.Parameters.AddWithValue("@ID_modalitaAssegnazione", "2");
                       else if (txtPL.Text.ToUpper() == "SI")
                           cmd.Parameters.AddWithValue("@ID_modalitaAssegnazione", "1");
                       

                       string currencyValue = txtStima.Text;
                       string converted = Regex.Replace(currencyValue, @"\D", "");
                        //currencyValue.Replace("$","").Replace("€","").Replace(",","").Replace(".","");
                        try
                        {
                            double Importo = double.Parse(converted);
                            cmd.Parameters.AddWithValue("@importoStimato", Importo);
                        }
                        catch { cmd.Parameters.AddWithValue("@importoStimato", DBNull.Value); }
                       
                       cmd.Parameters.AddWithValue("@numeroPolizza", txtPolizza.Text);

                       
                       // Verifico se CF o PIVA
                       if(txtPIVA.Text.Length == 11)
                       {
                           cmd.Parameters.AddWithValue("@contraente_cognome", "");
                           cmd.Parameters.AddWithValue("@contraente_ragioneSociale", txtContraente.Text);
                           cmd.Parameters.AddWithValue("@contraente_codiceFiscale_partitaIva", txtPIVA.Text);
                       }
                       else
                       {
                           cmd.Parameters.AddWithValue("@contraente_cognome", txtContraente.Text);
                           cmd.Parameters.AddWithValue("@contraente_ragioneSociale", "");
                           cmd.Parameters.AddWithValue("@contraente_codiceFiscale_partitaIva", txtPIVA.Text);
                       }

                      
                       cmd.Parameters.AddWithValue("@contraente_indirizzoCompletoDaFlussoGenerali", txtContraenteInd.Text);
                       cmd.Parameters.AddWithValue("@beneficiario_cognome", txtDanneggiato.Text);
                       cmd.Parameters.AddWithValue("@beneficiario_indirizzoCompletoDaFlussoGenerali", txtDanneggiatoInd.Text);
                       cmd.Parameters.AddWithValue("@noteSinistro", txtDanneggiatoInd.Text);
                        lastInsertedId = (int)cmd.ExecuteScalar();
                        CanInsertStatus = true;
                        panel2.Visible = true;
                    }
                    catch (SqlException exc)
                    {

                        MessageBox.Show(exc.Message);

                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    }
                }
            }

            if (CanInsertStatus)
            {
                ;
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            string sqlstm = " INSERT INTO statiStorico  (ID_stato ,ID_pratica ,dataInserimentoStato ,insertUser) " +
                                            " VALUES(@ID_stato ,@ID_pratica ,@dataInserimentoStato ,@insertUser)";

                            cmd.Parameters.AddWithValue("@ID_stato", "98");
                            cmd.Parameters.AddWithValue("@ID_pratica", lastInsertedId);
                            cmd.Parameters.AddWithValue("@dataInserimentoStato", DateTime.Now);
                            cmd.Parameters.AddWithValue("@insertUser", "BOT");
                            cmd.CommandText = sqlstm;
                            cmd.Connection = conn;
                            int rowsAffected = cmd.ExecuteNonQuery();
                            MessageBox.Show("Pratica : " + lastInsertedId.ToString() +  " inserita correttamente !");
                            SavePDF(lblPDF.Text);

                            if (txtSinistro.Text.Left(1) != "4")
                                myPathPDF = @"\\gewisfsrv\disco_y\CLAIMSITC\" + myGestione + @"\2\9" + @"\";
                            else
                                myPathPDF = @"\\gewisfsrv\disco_y\CLAIMSITC\" + myGestione + @"\2\12" + @"\";

                            myFileNamePDF = myPathPDF + lastInsertedId + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + "001" + "_" + "Denuncia" + "_" + "36";
                            myFileNamePDF += ".PDF";

                            File.Copy(lblPDF.Text, myFileNamePDF,true);
                            LastID = lastInsertedId.ToString();
                            SalvaFileDoc(LastID, "36", myFileNamePDF, "0");
                        }
                        catch (SqlException exc)
                        {

                            MessageBox.Show(exc.Message);

                        }
                    }
                }
            }

            
        }


        private static void SalvaFileDoc(string IDPratica, string IDTipoDoc, string path, string FileLen)
        {
            string csLocal = Utils.GetConnectionStringByName("CLAIMSITC");
            csLocal += "User ID=" + Utils.AppUser + ";Password=" + Utils.AppPassword;
            int ins = 0;
            string SQL = "";
            using (SqlConnection connLocal = new SqlConnection(csLocal))
            {
                connLocal.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, connLocal))
                {
                    try
                    {
                        SQL = " INSERT INTO dbo.documenti \n"
                            + "           (ID_pratica \n"
                            + "           ,ID_tipoDocumento \n"
                            + "           ,percorsoFile \n"
                            + "           ,fileSize \n"
                            + "           ,insertUser \n"
                            + "           ,dataScaricoITC, Is_DaRestituire) \n"
                            + " VALUES( @ID_pratica, @ID_tipoDocumento, @percorsoFile,  @fileSize, @insertUser, @dataScaricoITC, @Is_DaRestituire)";

                        cmd.CommandText = SQL;
                        cmd.Parameters.AddWithNullableValue("ID_pratica", IDPratica);
                        cmd.Parameters.AddWithNullableValue("ID_tipoDocumento", IDTipoDoc);
                        cmd.Parameters.AddWithNullableValue("percorsoFile", path);
                        cmd.Parameters.AddWithNullableValue("fileSize", FileLen);
                        cmd.Parameters.AddWithNullableValue("insertUser", "bot");
                        cmd.Parameters.AddWithNullableValue("dataScaricoITC", DateTime.Now);
                        cmd.Parameters.AddWithNullableValue("Is_DaRestituire", 1);
                        ins = cmd.ExecuteNonQuery();

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
        }

        private string FindIDRamo (string CodiceRamo, string ID_gestione)
        {
            string myID = "";
            string dateString = "";
            string cs = Utils.GetConnectionStringByName("CLAIMSITC");
            cs += "User ID=" + Utils.AppUser + ";Password=" + Utils.AppPassword;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.Connection = conn;
                        string SQL = " SELECT ID FROM  rami WHERE ID_gestione = @ID_gestione AND CodiceRamo = @CodiceRamo";
                        cmd.Parameters.AddWithValue("@CodiceRamo", CodiceRamo);
                        cmd.Parameters.AddWithValue("@ID_gestione", ID_gestione);

                        cmd.CommandText = SQL;
                        myID = cmd.ExecuteScalar().ToString();
                    }
                    catch { }

                }
            }

            return myID;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = comboBox1.SelectedItem.ToString();
            //MessageBox.Show("Hai selezionato: " + selectedText);
            comboBox1.BackColor = SystemColors.Window;

            if (comboBox1.SelectedIndex == 0)
                myGestione = "1";
            else
                myGestione = "3";
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (childControl.HasChildren)
                {
                    ClearTextBoxes(childControl);
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            ClearTextBoxes(this);
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {

            int cnt = 0;
            
            // Gestisci i file qui, ad esempio:
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //MessageBox.Show(fileList[0]);
            foreach (var item in fileList)
            {

                string directoryPath = @"\\gefilesrv01\Disco_R\CATTOLICA\SX CATTOLICA 2022- 2023\@TEMP\Unzip";

                string[] files = Directory.GetFiles(directoryPath);

                foreach (string filePath in files)
                {
                    File.Delete(filePath);
                }

                ZipFile.ExtractToDirectory(item, directoryPath);
                File.Copy(item, System.IO.Path.Combine(aNewFolder.TrimEnd(), System.IO.Path.GetFileName(item)) , true);


                files = Directory.GetFiles(directoryPath);

                foreach (string filePath in files)
                {
                    // Esegui le operazioni desiderate su ogni file
                    cnt++;

                    if (txtSinistro.Text.Left(1) != "4")
                        myPathPDF = @"\\gewisfsrv\disco_y\CLAIMSITC\" + myGestione + @"\2\9" + @"\";
                    else
                        myPathPDF = @"\\gewisfsrv\disco_y\CLAIMSITC\" + myGestione + @"\2\12" + @"\";


                    //myPathPDF = @"\\gewisfsrv\disco_y\CLAIMSITC\1\2\9" + @"\";
                    myFileNamePDF = myPathPDF + LastID + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + cnt.ToString("000") + "_" +  "_Documenti_Del_Sinistro" + "_" + "16";
                    myFileNamePDF += ".PDF";
                    //MessageBox.Show(filePath);
                    //MessageBox.Show(myFileNamePDF);
                    File.Copy(filePath, myFileNamePDF, true);
                    SalvaFileDoc(LastID, "16", myFileNamePDF, "0");
                    
                }


                panel2.Visible = false;

            }
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

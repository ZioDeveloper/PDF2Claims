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

namespace PDF2Claims
{
    public partial class frmItas : Form
    {
        string myPDFText = "";
        string input = "";
        string pattern = "";
        string Incarico = "";
        string Fiduciario = "";
        string DataIncarico = "";
        string DataChiusura = "";
        string DataPresa = "";

        string myGestione = "";
        string LastID = "";
        string aNewFolder = "";
        public frmItas()
        {
            InitializeComponent();
            panel1.AllowDrop = true;
        }

        private void cmdOpenPDF_Click(object sender, EventArgs e)
        {

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
                richTextBox1.Text = myPDFText;
                Refresh();
                DecodePDF(myPDFText);
                Cursor.Current = Cursors.Default; // Ripristina il cursore predefinito
                Refresh();

            }
        }

        public void DecodePDF(string PDFText)
        {
            input = richTextBox1.Text.ToString();
            pattern = @"Codice Incarico: (.+)Fiduciario:(.+)";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                txtCodiceIncarico.Text = match.Groups[1].Value;
                txtFiduciario.Text = match.Groups[2].Value;
            }

            pattern = @"Incarico: (.+)Data chiusura:(.+)Data presa in carico:(.+) "; // spazio in fondo per prendere solo la data senza l'ora....
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                txtDataIncarico.Text = match.Groups[1].Value;
                txtDataChisura.Text = match.Groups[2].Value;
                txtDataPresaInCarico.Text = match.Groups[3].Value;
            }

            pattern = @"Tipo Perito:(.+)";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                txtDatiIncarico.Text = match.Groups[1].Value;
            }

            pattern = @"Danneggiato:(.+)Contatto danneggiato:";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                txtDanneggiato.Text = match.Groups[1].Value;
            }

            pattern = @"Ubicazione oggetto:(.+)Importo Perizia:"; 
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtUbicazione.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Data limite:(.+)";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtDataLimite.Text = match.Groups[1].Value;
                }
            }

            pattern = @"PL Peritale:(.+)";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    string res = match.Groups[1].Value;
                    //MessageBox.Show("'" + res + "'");
                    if(res == " Assente")
                        txtPL.Text = "NO";
                    else
                        txtPL.Text = "SI";
                }
            }

            pattern = @"Sinistro:(.+) Ramo:";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtSinistro.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Ramo: (.+) Stato";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtRamo.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Data denuncia:(.+)Data perv.:";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtDataDenuncia.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Data evento:(.+)";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtDataEvento.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Località evento:(.+)";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtLocEvento.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Compagnia:(.+)SINISTRI(.+)";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtCompagnia.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Data inserimento:(.+)";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtDataInserimento.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Polizza:(.+)Gar. colpite";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtPolizza.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Agenzia:(.+)";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtAgenzia.Text = match.Groups[1].Value;
                }
            }

            pattern = @"Gar. colpite:(.+)";
            match = Regex.Match(input, pattern);
            if (match.Success)
            {
                if (match.Success)
                {
                    txtGaranzieColpite.Text = match.Groups[1].Value;
                }
            }


        }

        public string ExtractTextFromDoc()
        {
            if (lblPDF.Text.Right(3).ToUpper() != "PDF")
            {
                MessageBox.Show("Tipo file errato !");
                return "";
            }

            StringBuilder builder = new StringBuilder();

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(lblPDF.Text));
            int i = 1;

            // Rectangle(0, 0, 595, 842)


            int aX = 0, aY = 0, aW = 1000, aH = 1000;
            //bool success = false;
            //success = Int32.TryParse(X.Text, out aX);
            //success = Int32.TryParse(Y.Text, out aY);
            //success = Int32.TryParse(W.Text, out aW);
            //success = Int32.TryParse(H.Text, out aH);

            iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(aX, aY, aW, aH);



            //iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(85, 715, 10, 30); 640


            TextRegionEventFilter regionFilter = new TextRegionEventFilter(rect);
            PageSize mediabox = pdfDoc.GetDefaultPageSize();


            for (int page = 1; page <=1 /*pdfDoc.GetNumberOfPages()*/; page++)
            {
                ITextExtractionStrategy strategy = new FilteredTextEventListener(new LocationTextExtractionStrategy(), regionFilter);
                String str = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy) + "\n\n";
                builder.Append(str);
            }


            pdfDoc.Close();

            return builder.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lblPDF.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUbicazione_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            ClearTextBoxes(this);
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

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            
            bool CanInsertStatus = false;
            int lastInsertedId = 0;

            string dateString = "";
            string myIDRamo = "";
            string cs = Utils.GetConnectionStringByName("CLAIMSITC");
            cs += "User ID=" + Utils.AppUser + ";Password=" + Utils.AppPassword;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {


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
                        if (myIDRamo == "")
                        {
                            MessageBox.Show("Scelta Gestione non corretta !");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@ID_ramo", myIDRamo);
                        cmd.Parameters.AddWithValue("@ID_gestione", 1);
                        cmd.Parameters.AddWithValue("@ID_gruppoAssicurativo", 2);

                        // I sinistri che iniziano con 4 sono di TUA Assicurazioni (ID = 12)
                       
                       cmd.Parameters.AddWithValue("@ID_compagniaAssicurativa", 17);
                       

                        cmd.Parameters.AddWithValue("@insertUser", "BOT");
                        cmd.Parameters.AddWithValue("@updUSer", "BOT");

                        dateString = txtDataIncarico.Text;
                        DateTime dtDataIncarico = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
                        string myDate = dtDataIncarico.Year.ToString("0000") + dtDataIncarico.Month.ToString("00") + dtDataIncarico.Day.ToString("00");
                        cmd.Parameters.AddWithValue("@dataAffidamentoIncarico", dtDataIncarico);


                        dateString = txtDataEvento.Text;
                        DateTime dtDataAccadimento = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
                        myDate = dtDataAccadimento.Year.ToString("0000") + dtDataAccadimento.Month.ToString("00") + dtDataAccadimento.Day.ToString("00");
                        cmd.Parameters.AddWithValue("@dataAccadimento", dtDataAccadimento);


                        cmd.Parameters.AddWithValue("@indirizzoAccadimento_indirizzoCompletoDaFlussoGenerali", txtLuogoAccadimento.Text);
                        cmd.Parameters.AddWithValue("@descrizioneSinistro", txtDescrAccadimento.Text);

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
                        if (txtPIVA.Text.Length == 11)
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
                            MessageBox.Show("Pratica : " + lastInsertedId.ToString() + " inserita correttamente !");
                            SavePDF(lblPDF.Text);

                            myPathPDF = @"\\gewisfsrv\disco_y\CLAIMSITC\1\2\9" + @"\";
                            myFileNamePDF = myPathPDF + lastInsertedId + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + "001" + "_" + "Denuncia" + "_" + "36";
                            myFileNamePDF += ".PDF";

                            File.Copy(lblPDF.Text, myFileNamePDF, true);
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

        private string FindIDRamo(string CodiceRamo, string ID_gestione)
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
    }
}

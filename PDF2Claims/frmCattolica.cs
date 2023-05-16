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
        #endregion
        public frmCattolica()
        {
            InitializeComponent();
            panel1.AllowDrop = true;
            //lblPDF.Text = @"C:\Test\C.PDF";
            //myPDFText = ExtractTextFromDoc();
            //richTextBox1.Text = myPDFText;
            //Refresh();
            //DecodePDF(myPDFText);
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lblPDF.Text);
        }

        public string ExtractTextFromDoc()
        {


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
            pattern = @"Descrizione evento: (.+)*";
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

            pattern = @"Agenzia: (.+)";
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

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
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
                richTextBox1.Text = myPDFText;
                Refresh();
                DecodePDF(myPDFText);
                Cursor.Current = Cursors.Default; // Ripristina il cursore predefinito
                Refresh();

            }
        }

        private void frmCattolica_DragOver(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //    e.Effect = DragDropEffects.Link;
            //else
            //    e.Effect = DragDropEffects.None;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

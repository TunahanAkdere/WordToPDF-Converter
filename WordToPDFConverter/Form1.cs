using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordToPDFConverter
{
    public partial class Form1 : Form
    {
        private string wordFilePath;
        private string pdfFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        public void ConvertToPDF(string wordFilePath, string pdfFilePath)
        {
            // Word uygulamas�n� olu�tur
            Microsoft.Office.Interop.Word.Application wordApplication = new Microsoft.Office.Interop.Word.Application();
            // Word belgesini a�
            Document wordDocument = wordApplication.Documents.Open(wordFilePath);

            // PDF format� i�in kaydetme se�eneklerini belirle
            WdExportFormat exportFormat = WdExportFormat.wdExportFormatPDF;

            // PDF dosyas�n� kaydet
            wordDocument.ExportAsFixedFormat(pdfFilePath, exportFormat);

            wordDocument.Close();
            wordApplication.Quit();

            // Nesneleri yok et
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDocument);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApplication);
        }


        private void convertbtn_Click(object sender, EventArgs e)
        {

            //Word dosyas�n�n se�
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents (*.docx)|*.docx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                wordFilePath = openFileDialog.FileName;
            }
            if (string.IsNullOrEmpty(wordFilePath))
            {
                MessageBox.Show("L�tfen bir Word dosyas� se�in.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(pdfFilePath))
            {
                //PDF dosyas�n�n kaydedilece�i konum
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(wordFilePath) + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfFilePath = saveFileDialog.FileName; ;
                }
                else
                {
                    return;
                }
            }

            // Word belgesini PDF'e d�n��t�r
            ConvertToPDF(wordFilePath, pdfFilePath);

            pdfFilePath = null;
            wordFilePath = null;
            MessageBox.Show("PDF dosyas� ba�ar�yla olu�turuldu.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Tunahan Akdere taraf�ndan yap�lm��t�r.", "Hakk�mda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
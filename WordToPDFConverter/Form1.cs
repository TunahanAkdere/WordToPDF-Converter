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
            // Word uygulamasýný oluþtur
            Microsoft.Office.Interop.Word.Application wordApplication = new Microsoft.Office.Interop.Word.Application();
            // Word belgesini aç
            Document wordDocument = wordApplication.Documents.Open(wordFilePath);

            // PDF formatý için kaydetme seçeneklerini belirle
            WdExportFormat exportFormat = WdExportFormat.wdExportFormatPDF;

            // PDF dosyasýný kaydet
            wordDocument.ExportAsFixedFormat(pdfFilePath, exportFormat);

            wordDocument.Close();
            wordApplication.Quit();

            // Nesneleri yok et
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDocument);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApplication);
        }


        private void convertbtn_Click(object sender, EventArgs e)
        {

            //Word dosyasýnýn seç
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents (*.docx)|*.docx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                wordFilePath = openFileDialog.FileName;
            }
            if (string.IsNullOrEmpty(wordFilePath))
            {
                MessageBox.Show("Lütfen bir Word dosyasý seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(pdfFilePath))
            {
                //PDF dosyasýnýn kaydedileceði konum
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

            // Word belgesini PDF'e dönüþtür
            ConvertToPDF(wordFilePath, pdfFilePath);

            pdfFilePath = null;
            wordFilePath = null;
            MessageBox.Show("PDF dosyasý baþarýyla oluþturuldu.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Tunahan Akdere tarafýndan yapýlmýþtýr.", "Hakkýmda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
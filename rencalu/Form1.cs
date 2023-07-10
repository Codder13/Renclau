using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
using Rectangle = iTextSharp.text.Rectangle;

namespace rencalu
{
    public partial class Form1 : Form
    {
        public const string Path = "data.txt";
        List<string> addr = new List<string>();
        List<string> tel = new List<string>();

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);



        public Form1()
        {
            InitializeComponent();
            read_file();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void write2pdf(string Address, string Tel)
        {
            string oldFile = "chitanta.pdf";
            string newFile = desktopPath + @"\chitanta.pdf";

            // open the reader
            PdfReader reader = new PdfReader(oldFile);
            Rectangle size = reader.GetPageSizeWithRotation(1);
            Document document = new Document(size);

            // open the writer
            FileStream fs = new FileStream(newFile, FileMode.OpenOrCreate, FileAccess.Write);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            // add content
            PdfContentByte cb = writer.DirectContent;
            PdfImportedPage page = writer.GetImportedPage(reader, 1);
            cb.AddTemplate(page, 0, 0);
            cb.BeginText();
            cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12);
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Address, 36, 370, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Tel, 36, 327, 0);
            cb.EndText();

            document.NewPage();

            PdfContentByte cb2 = writer.DirectContentUnder;
            PdfImportedPage page2 = writer.GetImportedPage(reader, 2);
            cb2.AddTemplate(page2, 0, 0);
            cb2.BeginText();
            cb2.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12);
            cb2.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Address, 36, 370, 0);
            cb2.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Tel, 36, 327, 0);
            cb2.EndText();

            // close the document and writer
            document.Close();
            writer.Close();
            fs.Close();

        }


        public void read_file()
        {
            addr.Clear();
            tel.Clear();
            string[] lines = File.ReadAllLines(Path);

            foreach (string line in lines)
            {
                string[] parts = line.Split("@");
                addr.Add(parts[0].Trim());
                tel.Add(parts[1].Trim());
            }
        }

        private void bt_cauta_Click(object sender, EventArgs e)
        {
            read_file();

            var search = textBox1.Text;
            int index = -1;

            if (tel.Contains(search))
            {
                index = tel.IndexOf(search);
            }
            else
            {
                Form2 form_addr = new Form2(search);
                form_addr.ShowDialog();
                if (form_addr.saved)
                {
                    read_file();
                    addr.Add(form_addr.addr);
                    tel.Add(search);
                    index = tel.Count - 1;
                }
            }


            if (index != -1)
            {
                write2pdf(addr[index], tel[index]);
                MessageBox.Show("PDF generat cu succes");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void copy_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "data.txt";


            if (save.ShowDialog() == DialogResult.OK)
            {

                File.Copy("data.txt", save.FileName, true);
            }



        }

        private void modifica_Click(object sender, EventArgs e)
        {
            read_file();

            var search = textBox1.Text;


            if (tel.Contains(search))
            {
                Form3 form_addr = new Form3(search, addr, tel);
                form_addr.ShowDialog();
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_cauta.PerformClick();
            }
        }

    }
}
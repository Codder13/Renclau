using iTextSharp.text.pdf;
using System.Numerics;
using Document = iTextSharp.text.Document;
using Rectangle = iTextSharp.text.Rectangle;

namespace rencalu
{
    public partial class Form1 : Form
    {
        public const string Path = @"C:\All the stuff\Programing\data.txt";
        List<string> addr = new List<string>();
        List<string> tel = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
        public static List<string> make_lists(string filePath, string sheetName, string columnName)
        {
            List<string> columnValues = new List<string>();

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets[sheetName];
            Excel.Range range = worksheet.UsedRange;

            int columnIndex = 0;
            for (int i = 1; i <= range.Columns.Count; i++)
            {
                if (range.Cells[1, i].Value2.ToString() == columnName)
                {
                    columnIndex = i;
                    break;
                }
            }

            for (int i = 2; i <= range.Rows.Count; i++)
            {
                columnValues.Add(range.Cells[i, columnIndex].Value2.ToString());
            }

            workbook.Close();
            excelApp.Quit();

            return columnValues;
        }

        */

        private void write2pdf(string Address, string Tel)
        {
            string oldFile = @"C:\All the stuff\Programing\Chitanta.pdf";
            string newFile = @"C:\All the stuff\Programing\Chitanta2.pdf";

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


            // close the document and writer
            document.Close();
            writer.Close();
            fs.Close();

        }
        
        private void read_file()
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

            if (tel.Contains(search)){
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
                    index = tel.Count-1;
                }
                
            }


            if(index != -1)
            {
                write2pdf(addr[index], tel[index]);
                MessageBox.Show("PDF generat cu succes");
            }
            




            /*
            var search = textBox1.Text;

            Task<List<string>> task1 = Task.Run(() => make_lists(ExcelPath, "data", "Address"));

            Task<List<string>> task2 = Task.Run(() => make_lists(ExcelPath, "data", "Tel"));



            List<string> address = await task1;
            List<string> numbers = await task2;


            if (!numbers.Contains(search))
            {
                Form2 add_address = new Form2(search);
                add_address.ShowDialog();

                Task<List<string>> task3 = Task.Run(() => make_lists(ExcelPath, "data", "Address"));

                Task<List<string>> task4 = Task.Run(() => make_lists(ExcelPath, "data", "Tel"));

                address = await task3;
                numbers = await task4;

                var index = numbers.IndexOf(search);
                write2pdf(address[index+1], numbers[index+1]);
            }
            else
            {
                var index = numbers.IndexOf(search);
                write2pdf(address[index], numbers[index]);
            }
            */


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
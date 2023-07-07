namespace rencalu
{
    public partial class Form2 : Form
    {

        string telefon;
        public string addr;
        public bool saved = false;

        public Form2(string tel)
        {
            InitializeComponent();
            
            this.telefon = tel;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            addr = textBox1.Text;

            //add_customer(Form1.ExcelPath, "data", "Tel","Address", telefon, addr); 

            string text = addr.ToString() + " @ " + telefon + '\n';

            File.AppendAllTextAsync(Form1.Path, text);

            saved = true;

            this.Close();
            
        }

        public static void add_customer(string filePath, string sheetName, string NameTel, string NameAddr, string tel, string addr)
        {


            /*
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets[sheetName];
            Excel.Range range = worksheet.UsedRange;

            int columnIndex = 0;
            for (int i = 1; i <= range.Columns.Count; i++)
            {
                if (range.Cells[1, i].Value2.ToString() == NameTel)
                {
                    columnIndex = i;
                    break;
                }
            }
            
            range.Cells[range.Rows.Count+1][columnIndex].Value2 = tel;

            columnIndex = 0;
            for (int i = 1; i <= range.Columns.Count; i++)
            {
                if (range.Cells[1, i].Value2.ToString() == NameAddr)
                {
                    columnIndex = i;
                    break;
                }
            }
            range.Cells[range.Rows.Count+1][columnIndex].Value2 = addr;

            
            workbook.Close(true);
            workbook.SaveAs(filePath);
            excelApp.Quit();
            */
        }
    }
}

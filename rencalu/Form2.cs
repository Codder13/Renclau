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


            string text = '\n' + addr + " @ " + telefon;

            File.AppendAllTextAsync(Form1.Path, text);

            saved = true;

            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

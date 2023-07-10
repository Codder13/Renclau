namespace rencalu
{
    public partial class Form3 : Form
    {

        string telefon;
        List<string> addr;
        List<string> tel;
        public Form3(string telefon, List<string> addr, List<string> tel)
        {
            InitializeComponent();
            this.telefon = telefon;
            this.addr = addr;
            this.tel = tel;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void rewrite_data()
        {
            using (StreamWriter sw = new StreamWriter(Form1.Path, false))
            {
                sw.Write(string.Empty);
            }
            for (int i = 0; i < tel.Count; i++)
            {
                string text = addr[i] + " @ " + tel[i] + '\n';
                File.AppendAllTextAsync(Form1.Path, text);
            }



        }

        private void switch_btn_Click(object sender, EventArgs e)
        {
            var index = tel.IndexOf(telefon);

            if (textBox1.Text != null)
            {
                addr[index] = textBox1.Text;
            }

            rewrite_data();

            this.Close();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch_btn.PerformClick();
            }
        }

    }
}

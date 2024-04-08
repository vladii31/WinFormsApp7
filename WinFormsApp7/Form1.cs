namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int k = x.Next(1,2);
            if (k == (int.Parse(textBox1.Text)))
            {
                MessageBox.Show(" du gissade rätt");

            }
            else 
            {
                MessageBox.Show("mindre tal försök igen ");

            }
            
;
        }
    }
}
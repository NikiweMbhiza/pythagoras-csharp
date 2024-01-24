namespace pythagoras_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b ,c;
            a=double.Parse(textBox1.Text);
            b=double.Parse(textBox2.Text);
            c = Math.Pow(a, 2) + Math.Pow(b, 2);
            double hyp=Math.Pow(c,0.5);
            textBox3.Text=hyp.ToString();

        }
    }
}
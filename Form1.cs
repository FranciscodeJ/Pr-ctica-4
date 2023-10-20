namespace Práctica__4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;                                 // se declararon las variables a b c d
            a = int.Parse(textBox1.Text);                   // se declaró quea cada varible se le asigne el valor que se le escriba a cada una
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            d = int.Parse(textBox4.Text);

            textBox5.Text = d.ToString();         // se declaró que en cada caja de texto de la derecha se muestre cada varible en orden inverso (de abajo hacia arriba).
            textBox6.Text = c.ToString();         
            textBox7.Text = b.ToString();
            textBox8.Text = a.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

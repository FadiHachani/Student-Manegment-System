namespace sahar
{
    public partial class Form1 : Form
    {
        etudient E1 = new etudient();
        public Form1()
        {
            InitializeComponent();
            button2.Enabled= false;
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
          var info = new Classe("info1");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            E1.SGnom = tnom.Text;
            E1.Ex = double.Parse(tn1.Text);
            E1.Tp = double.Parse(tn3.Text);
            E1.Ds = double.Parse(tn2.Text);
            textBox1.AppendText(E1.moy().ToString());
                button1.Enabled = true;
            button2.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classe c = new Classe();
            c.remplissage(listView1, E1.SGnom, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(0);
        }
    }
}
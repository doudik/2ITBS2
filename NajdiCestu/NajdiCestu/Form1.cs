namespace NajdiCestu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player p1 = new Player(this, "Tomáš");
            Enemy.CreateEnemy(10, this);
            Finish f = new Finish(this);
        }

    }
}
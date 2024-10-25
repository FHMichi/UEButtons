namespace INF_UE1_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // button1.Location.X = 200;  geht nicht
            button1.Location = new Point(200, button1.Location.Y);
             this.BackColor = Color.FromArgb(255,0,255);
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //andere Methode gleiche Wirkung 
            button2.Left = button2.Left + 3; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                button3.Left += 3;
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                timer1.Enabled = true;
               
        }
    }
}
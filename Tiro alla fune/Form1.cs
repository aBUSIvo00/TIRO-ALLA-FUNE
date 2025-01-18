namespace Tiro_alla_fune
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        //creazione variabili di gioco
        bool Gioco = false;
        bool win = false;   

        private void Form1_Load(object sender, EventArgs e)
        {
            //posizionado la corda ondulata e dura al centro
            //definimento posizione iniziale e di reset
            Corda_Ondulata.Location = new Point((ClientSize.Width - Corda_Ondulata.Width) / 2, (ClientSize.Height - Corda_Ondulata.Height) / 2);
            Corda_Dura.Location = new Point((ClientSize.Width - Corda_Dura.Width) / 2, (ClientSize.Height - Corda_Dura.Height) / 2);
            Start.Location = new Point(((ClientSize.Width - Start.Width) / 2), 50);
            Reset.Location = new Point(((ClientSize.Width - Start.Width) / 2), 110);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //funzione del pulsante che avvia la partita
        private void Start_Click(object sender, EventArgs e)
        {
            Gioco = false;
            win = false;
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false) { return; }
            Thread.Sleep(1000);
            Corda_Ondulata.Hide();
            Corda_Dura.Show();

            if (radioButton1.Checked == true)
            {
                Thread CPU = new Thread(Easy);
                CPU.Start();
            }
            if (radioButton2.Checked == true)
            {
                Thread CPU = new Thread(Medium);
                CPU.Start();
            }
            if (radioButton3.Checked == true)
            {
                Thread CPU = new Thread(Hard);
                CPU.Start();
            }
            if (radioButton4.Checked == true)
            {
                Thread CPU = new Thread(Impossible);
                CPU.Start();
            }

        }

        //difficolta easy
        private void Easy()
        {
            while (!(Corda_Dura.Location.X > ClientSize.Width / 2) && Corda_Dura.Location.X + Corda_Dura.Width > ClientSize.Width / 2)
            {
                Corda_Dura.Location = new Point(Corda_Dura.Location.X - 5, Corda_Dura.Location.Y);
                Thread.Sleep(225);
            }
            //controllo vittoria lvl easy
            Gioco = true;
            if (Corda_Dura.Location.X > ClientSize.Width / 2) win = true;
            if (win == true) MessageBox.Show("Level easy completed!, Press reset button and select an harder level.");
            else MessageBox.Show("You lost!");
        }

        //difficolta medium
        private void Medium()
        {
            while (!(Corda_Dura.Location.X > ClientSize.Width / 2) && Corda_Dura.Location.X + Corda_Dura.Width > ClientSize.Width / 2)
            {
                Corda_Dura.Location = new Point(Corda_Dura.Location.X - 5, Corda_Dura.Location.Y);
                Thread.Sleep(175);
            }
            //controllo vittoria lvl medium
            Gioco = true;
            if (Corda_Dura.Location.X > ClientSize.Width/2) win = true;
            if (win == true) MessageBox.Show("Level medium completed!, Press reset button and select an harder level.");
            else MessageBox.Show("You lost!");
        }

        //difficolta hard
        private void Hard()
        {
            while (!(Corda_Dura.Location.X > ClientSize.Width / 2) && Corda_Dura.Location.X + Corda_Dura.Width > ClientSize.Width / 2)
            {
                Corda_Dura.Location = new Point(Corda_Dura.Location.X - 5, Corda_Dura.Location.Y);
                Thread.Sleep(125);
            }
            //controllo vittoria lvl hard
            Gioco = true;
            if (Corda_Dura.Location.X > ClientSize.Width / 2) win = true;
            if (win == true) MessageBox.Show("Level hard completed!, Press reset button and select an harder level.");
            else MessageBox.Show("You lost!");
        }

        //difficolta impossible
        private void Impossible()
        {
            while (!(Corda_Dura.Location.X > ClientSize.Width / 2) && Corda_Dura.Location.X + Corda_Dura.Width > ClientSize.Width / 2)
            {
                Corda_Dura.Location = new Point(Corda_Dura.Location.X - 5, Corda_Dura.Location.Y);
                Thread.Sleep(75);
            }
            //controllo vittoria lvl impossible
            Gioco = true;
            if (Corda_Dura.Location.X > ClientSize.Width / 2) win = true;
            if (win == true) MessageBox.Show("Level impossible completed!, Press reset button and select an harder level.");
            else MessageBox.Show("You lost!.");
        }

        //comandi giocatore
        private void Form1_Click(object sender, EventArgs e)
        {
            if (Gioco == false)
            {
                Corda_Dura.Location = new Point(Corda_Dura.Location.X + 25, Corda_Dura.Location.Y);
            }

        }

        private void Corda_Dura_LocationChanged(object sender, EventArgs e)
        {

        }
        
        //button reset del gioco
        private void button1_Click_1(object sender, EventArgs e)
        {
            Corda_Ondulata.Location = new Point((ClientSize.Width - Corda_Ondulata.Width) / 2, (ClientSize.Height - Corda_Ondulata.Height) / 2);
            Corda_Dura.Location = new Point((ClientSize.Width - Corda_Dura.Width) / 2, (ClientSize.Height - Corda_Dura.Height) / 2);
            Start.Location = new Point(((ClientSize.Width - Start.Width) / 2), 50);
            Corda_Dura.Hide();
            Corda_Ondulata.Show();
        }

    }
}
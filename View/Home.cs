using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.IO;
using System;

using LiveCharts;
using LiveCharts.Wpf;



namespace TP1.View
{
    public partial class Home : Form
    {
        Color Cold = Color.FromArgb(3, 252, 223);
        Color Normal = Color.FromArgb(3, 252, 107);
        Color Hot = Color.FromArgb(240, 24, 31);

        private int NumGraphs = 1;
        private String CurExample = "TILED_VERTICAL_AUTO";
        private Model.PrecisionTimer.Timer mTimer = null;
        private DateTime lastTimerTick = DateTime.Now;

        public Home()
        {
            InitializeComponent();
            
            string[] emg_txt = File.ReadAllLines(@"C:\Users\happycode1\source\repos\hackingrio\saude-2020-e2u\TP1\DataSet\emg.txt", Encoding.UTF8);
            var nums = new ChartValues<double>();

            for (int i = 0; i < emg_txt.Length; i++)
            {
                if (!emg_txt[i].Contains("#"))
                {
                    nums.Add(double.Parse(emg_txt[i]));
                }
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void CheckTemp()
        {
            if (Temprature.Value < 34)
            {
                Temprature.BarColor1 = Cold;
                Temprature.BarColor2 = Cold;
            }

            if (Temprature.Value > 34)
            {
                Temprature.BarColor1 = Normal;
                Temprature.BarColor2 = Normal;
            }

            if (Temprature.Value > 38)
            {
                Temprature.BarColor1 = Hot;
                Temprature.BarColor2 = Hot;
            }
        }

        private void Temprature_Click(object sender, EventArgs e)
        {
            Temprature.Value += 0.5f;
            CheckTemp();
        }        

        private void Plotter_Graph_EMG_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainForm Main = new MainForm();
            this.Hide();
        }

        private void BunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

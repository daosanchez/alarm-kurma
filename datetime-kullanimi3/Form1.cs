using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetime_kullanimi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer player = new SoundPlayer();

        private void btnKur_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblMesaj.Text = "Alarm Kuruldu.";
            btnKur.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime alarmTime = dtpZaman.Value;

            if (dateTime.Hour == alarmTime.Hour && dateTime.Minute == alarmTime.Minute && dateTime.Second == alarmTime.Second)
            {
                timer1.Stop();
                lblMesaj.Text = "Alarm Çalıyor...";


                player.SoundLocation = @"D:\Downloads\Music\alarm.wav";
                player.PlayLooping();
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            player.Stop();
            lblMesaj.Text = "Alarm Durduruldu.";
            btnDurdur.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMesaj.Text = "...";
        }
    }   
}
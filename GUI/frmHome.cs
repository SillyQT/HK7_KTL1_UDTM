using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHome : Form
    {
        public int remainingTime = 10; // 10 giây
        
        public frmHome()
        {
            InitializeComponent();
            runTimer();

        }
        public void runTimer()
        {
            timer_timeLambai.Start();
            UpdateTimerDisplay();
            timer_timeLambai.Tick += Timer_timeLambai_Tick;
        }

        private void Timer_timeLambai_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--; // Giảm thời gian mỗi khi Tick
                UpdateTimerDisplay();
            }
            else
            {
                timer_timeLambai.Stop(); // Dừng timer khi hết giờ
                MessageBox.Show("Hết thời gian!");
            }
        }

        private void UpdateTimerDisplay()
        {
            int minutes = remainingTime / 60; // Lấy số phút
            int seconds = remainingTime % 60; // Lấy số giây

            // Hiển thị theo định dạng mm:ss (vd: 02:15)
            txtTimer.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace 두더쥐게임_winform1
{
    public partial class Form1 : Form
    {
        int count = 0;
        double remain_time = 0;
        private bool isHitImage = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            remain_time = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (isHitImage)
                {
                    btn_groundRat.BackgroundImage = Image.FromFile("src/nomal.png");
                    isHitImage = false;
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("이미지 파일을 찾을 수 없습니다: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지를 로드하는 중 오류가 발생했습니다: " + ex.Message);
            }

            Random random = new Random();

                int x = random.Next(Width - btn_groundRat.Width);
                int y = random.Next((Height-10) - btn_groundRat.Height + 10);
                btn_groundRat.Location = new Point(x, y);

                remain_time++;
                lblTime.Text = $"{remain_time}초 지났습니다.";
        }

        private void btn_groundRat_Click(object sender, EventArgs e)
        {

            try
            {
                if (isHitImage)
                {
                    btn_groundRat.BackgroundImage = Image.FromFile("src/nomal.png");
                    isHitImage = false;
                }
                else
                {
                    btn_groundRat.BackgroundImage = Image.FromFile("src/hit.png");
                    isHitImage = true;
                }
                btn_groundRat.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("이미지 파일을 찾을 수 없습니다: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지를 로드하는 중 오류가 발생했습니다: " + ex.Message);
            }

            if (!timer1.Enabled)
                {
                    timer1.Start();
                }
                if (count < 5)
                {
                    count++;
                    label1.Text = $"점수 : {count}";
                }
                else
                {
                    timer1.Stop();
                    label1.Text = "성~~~~~~~~공";
                    label2.Visible = true;
                    btn_close.Visible = true;
                    btn_restart.Visible = true;
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            btn_restart.Visible = false;
            btn_close.Visible = false;

            timer1.Start();
            remain_time = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 쉬움ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
        }

        private void 보통ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void 어려움ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }


    }
}

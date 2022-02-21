using System;
using System.Drawing;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;


namespace ResourceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(new object[] {
                "1.- fronten1",
                "2.- fronten2",
                "3.- fronten3",
                "4.- fronten3"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("https://raw.githubusercontent.com/KaizerHind/DemoResourceTest/master/Version.txt").Contains("1.2"))
                {
                    //if (MessageBox.Show("Existe una nueva actualizacion! ¿Quieres descargar esta?", "ResourceTest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    using (var client = new WebClient())
                    {
                        MessageBox.Show("Existe una nueva actualizacion! Espera que se actuaice.");
                        Process.Start("UpdateDemo.exe");
                        Close();
                    }
                }
            }
            catch { }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.FindString(listBox1.SelectedItem.ToString()))
            {
                case 0:

                    PictureBox1.Image = Image.FromFile(@".\Sprites\fronten1\arrow.png");
                    pictureBox2.Image = Image.FromFile(@".\Sprites\fronten1\radio_bounce.png");
                    pictureBox3.Image = Image.FromFile(@".\Sprites\fronten1\radio_csr.png");
                    pictureBox4.Image = Image.FromFile(@".\Sprites\fronten1\radio_KDST.png");
                    pictureBox5.Image = Image.FromFile(@".\Sprites\fronten1\radio_kjah.png");
                    pictureBox6.Image = Image.FromFile(@".\Sprites\fronten1\radio_krose.png");
                    PictureBox1.Show();
                    pictureBox2.Show();
                    pictureBox3.Show();
                    pictureBox4.Show();
                    pictureBox5.Show();
                    pictureBox6.Show();
                    break;
                case 1:
                    PictureBox1.Image = Image.FromFile(@".\Sprites\fronten2\back2.png");
                    pictureBox3.Image = Image.FromFile(@".\Sprites\fronten2\back3.png");
                    pictureBox2.Image = Image.FromFile(@".\Sprites\fronten2\back4.png");
                    pictureBox4.Image = Image.FromFile(@".\Sprites\fronten2\back5.png");
                    pictureBox5.Image = Image.FromFile(@".\Sprites\fronten2\back6.png");
                    PictureBox1.Show();
                    pictureBox2.Show();
                    pictureBox3.Show();
                    pictureBox4.Show();
                    pictureBox5.Show();
                    pictureBox6.Hide();
                    break;
                case 2:
                    PictureBox1.Image = Image.FromFile(@".\Sprites\fronten3\back8_right.png");
                    pictureBox2.Image = Image.FromFile(@".\Sprites\fronten3\back8_top.png");
                    PictureBox1.Show();
                    pictureBox2.Show();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    break;
            }
        }

        private void btn_Center_Click(object sender, EventArgs e)
        {
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btn_Default_Click(object sender, EventArgs e)
        {
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox3.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox4.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox5.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btn_Stretch_Click(object sender, EventArgs e)
        {
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}

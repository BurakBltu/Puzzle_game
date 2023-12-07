using System;
using System.Collections;
using System.Drawing.Text;
using System.Windows.Forms;

namespace frm_puzzle
{
    public partial class Form1 : Form
    {
        int sn, dk;
        private PictureBox[] designPictureBoxes; // PictureBox dizisi
        private Point[] lokasyonlar;
        private Random random = new Random();
        private List<Image> availableImages;

       
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            designPictureBoxes = new PictureBox[]
      {
        pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12
  };
            // resim1.jpg yerine kendi resim dosyanýzýn yolunu kullanýn
            


            lokasyonlar = new Point[]
        {
            new Point(49, 49),
            new Point(170, 49),
            new Point(291, 49),
            new Point(412, 49),

            new Point(49, 158),
            new Point(170, 158),
            new Point(291, 158),
            new Point(412, 158),

            new Point(49, 267),
            new Point(170, 267),
            new Point(291, 267),
            new Point(412, 267)
        };

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;


            timer1.Enabled = false;
            timer1.Interval = 1000;
            sn = 0;
            dk = 0;
        }


        private void KaristirResimler()
        {
            List<Image> images = designPictureBoxes.Select(pb => pb.Image).ToList();
            images = images.OrderBy(x => random.Next()).ToList();

            for (int i = 0; i < designPictureBoxes.Length; i++)
            {
                designPictureBoxes[i].Image = images[i];
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = true;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;

                sn++;
                lbl_dk.Text = sn.ToString();
                if (sn == 1)
                {
                    dk = dk + 1;
                    lbl_dk.Text = dk.ToString();
                    sn = 00;
                    lbl_sn.Text = sn.ToString();
                }
            }
        }

        private void btn_Baþlat_devamet_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            KaristirResimler();
        }


        private void btn_Cýk_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        //PictureBox'a týkladýðý zaman boþ olarak yerine pictureBox25 geçiyor
        //PictureBox'larý yerine gelebicelecek þekilde eþitliyoruz.
        {
            if (pictureBox5.Image == pictureBox25.Image)
            {
                pictureBox5.Image = pictureBox1.Image;
                pictureBox1.Image = pictureBox25.Image;

            }
            if (pictureBox2.Image == pictureBox25.Image)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox1.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)

        //PictureBox'a týkladýðý zaman boþ olarak yerine pictureBox25 geçiyor

        //PictureBox'larý yerine gelebicelecek þekilde eþitliyoruz.
        {
            if (pictureBox1.Image == pictureBox25.Image)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox2.Image = pictureBox25.Image;
            }

            if (pictureBox6.Image == pictureBox25.Image)
            {
                pictureBox6.Image = pictureBox2.Image;
                pictureBox2.Image = pictureBox25.Image;
            }

            if (pictureBox3.Image == pictureBox25.Image)
            {
                pictureBox3.Image = pictureBox2.Image;
                pictureBox2.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private bool CheckPuzzles()
        {
            bool img = true;
            Image pictureBoxImage1 = pictureBox1.Image;
            Image pictureBoxImage2 = pictureBox2.Image;
            Image pictureBoxImage3 = pictureBox3.Image;
            Image pictureBoxImage4 = pictureBox4.Image;
            Image pictureBoxImage5 = pictureBox5.Image;
            Image pictureBoxImage6 = pictureBox6.Image;
            Image pictureBoxImage7 = pictureBox7.Image;
            Image pictureBoxImage8 = pictureBox8.Image;
            Image pictureBoxImage9 = pictureBox9.Image;
            Image pictureBoxImage10 = pictureBox10.Image;
            Image pictureBoxImage11 = pictureBox11.Image;
            Image pictureBoxImage12 = pictureBox12.Image;

            // Karþýlaþtýrmak istediðiniz resmi projenizden yükleyin
            string imagePath1 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\1.png";
            string imagePath2 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\2.png";
            string imagePath3 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\3.png";
            string imagePath5 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\5.png";
            string imagePath6 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\6.png";
            string imagePath7 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\7.png";
            string imagePath8 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\8.png";
            string imagePath9 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\9.png";
            string imagePath10 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\10.png";
            string imagePath11 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\11.png";
            string imagePath12 = "C:\\visual_studio_code_attempt\\frm_puzzle\\frm_puzzle\\Ýmage\\12.png";
            // Resmin yolunu projenize göre ayarlayýn
            Image compareImage1 = Image.FromFile(imagePath1);
            Image compareImage2 = Image.FromFile(imagePath2);
            Image compareImage3 = Image.FromFile(imagePath3);
            Image compareImage5 = Image.FromFile(imagePath5);
            Image compareImage6 = Image.FromFile(imagePath6);
            Image compareImage7 = Image.FromFile(imagePath7);
            Image compareImage8 = Image.FromFile(imagePath8);
            Image compareImage9 = Image.FromFile(imagePath9);
            Image compareImage10 = Image.FromFile(imagePath10);
            Image compareImage11 = Image.FromFile(imagePath11);
            Image compareImage12 = Image.FromFile(imagePath12);

            // Resimleri karþýlaþtýrýn
            if (!ImageEquals(pictureBoxImage1, compareImage1))
            {
                img = false;

            }
            if (!ImageEquals(pictureBoxImage2, compareImage2))
            {
                img = false;

            }
            if (!ImageEquals(pictureBoxImage3, compareImage3))
            {
                img = false;

            }
            if (!ImageEquals(pictureBoxImage5, compareImage5))
            {
                img = false;

            }
            if (!ImageEquals(pictureBoxImage6, compareImage6))
            {
                img = false;
            }
            if (!ImageEquals(pictureBoxImage7, compareImage7))
            {
                img = false;

            }
            if (!ImageEquals(pictureBoxImage8, compareImage8))
            {
                img = false;

            }
            if (!ImageEquals(pictureBoxImage9, compareImage9))
            {
                img = false;

            }
            if (!ImageEquals(pictureBoxImage10, compareImage10))
            {
                img = false;

            }
            if (!ImageEquals(pictureBoxImage11, compareImage11))
            {
                img = false;

            }
            if (!ImageEquals(pictureBoxImage12, compareImage12))
            {
                img = false;
            }

            return img;
        }

        private bool ImageEquals(Image image1, Image image2)
        {
            if (image1 == null || image2 == null)
            {
                return false;
            }

            if (image1.Width != image2.Width || image1.Height != image2.Height)
            {
                return false;
            }

            using (Bitmap bmp1 = new Bitmap(image1))
            using (Bitmap bmp2 = new Bitmap(image2))
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    for (int y = 0; y < bmp1.Height; y++)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        //PictureBox'a týkladýðý zaman boþ olarak yerine pictureBox25 geçiyor
        //PictureBox'larý yerine gelebicelecek þekilde eþitliyoruz.
        {

            if (pictureBox2.Image == pictureBox25.Image)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox3.Image = pictureBox25.Image;
            }

            if (pictureBox7.Image == pictureBox25.Image)
            {
                pictureBox7.Image = pictureBox3.Image;
                pictureBox3.Image = pictureBox25.Image;
            }

            if (pictureBox4.Image == pictureBox25.Image)
            {
                pictureBox4.Image = pictureBox3.Image;
                pictureBox3.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == pictureBox25.Image)
            {
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = pictureBox25.Image;
            }

            if (pictureBox8.Image == pictureBox25.Image)
            {
                pictureBox8.Image = pictureBox4.Image;
                pictureBox4.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == pictureBox25.Image)
            {
                pictureBox1.Image = pictureBox5.Image;
                pictureBox5.Image = pictureBox25.Image;
            }

            if (pictureBox6.Image == pictureBox25.Image)
            {
                pictureBox6.Image = pictureBox5.Image;
                pictureBox5.Image = pictureBox25.Image;
            }

            if (pictureBox9.Image == pictureBox25.Image)
            {
                pictureBox9.Image = pictureBox5.Image;
                pictureBox5.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == pictureBox25.Image)
            {
                pictureBox5.Image = pictureBox6.Image;
                pictureBox6.Image = pictureBox25.Image;
            }

            if (pictureBox2.Image == pictureBox25.Image)
            {
                pictureBox2.Image = pictureBox6.Image;
                pictureBox6.Image = pictureBox25.Image;
            }

            if (pictureBox7.Image == pictureBox25.Image)
            {
                pictureBox7.Image = pictureBox6.Image;
                pictureBox6.Image = pictureBox25.Image;
            }

            if (pictureBox10.Image == pictureBox25.Image)
            {
                pictureBox10.Image = pictureBox6.Image;
                pictureBox6.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == pictureBox25.Image)
            {
                pictureBox6.Image = pictureBox7.Image;
                pictureBox7.Image = pictureBox25.Image;
            }

            if (pictureBox11.Image == pictureBox25.Image)
            {
                pictureBox11.Image = pictureBox7.Image;
                pictureBox7.Image = pictureBox25.Image;
            }

            if (pictureBox8.Image == pictureBox25.Image)
            {
                pictureBox8.Image = pictureBox7.Image;
                pictureBox7.Image = pictureBox25.Image;
            }

            if (pictureBox3.Image == pictureBox25.Image)
            {
                pictureBox3.Image = pictureBox7.Image;
                pictureBox7.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image == pictureBox25.Image)
            {
                pictureBox7.Image = pictureBox8.Image;
                pictureBox8.Image = pictureBox25.Image;
            }

            if (pictureBox4.Image == pictureBox25.Image)
            {
                pictureBox4.Image = pictureBox8.Image;
                pictureBox8.Image = pictureBox25.Image;
            }

            if (pictureBox12.Image == pictureBox25.Image)
            {
                pictureBox12.Image = pictureBox8.Image;
                pictureBox8.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == pictureBox25.Image)
            {
                pictureBox5.Image = pictureBox9.Image;
                pictureBox9.Image = pictureBox25.Image;
            }

            if (pictureBox10.Image == pictureBox25.Image)
            {
                pictureBox10.Image = pictureBox9.Image;
                pictureBox9.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image == pictureBox25.Image)
            {
                pictureBox9.Image = pictureBox10.Image;
                pictureBox10.Image = pictureBox25.Image;
            }

            if (pictureBox11.Image == pictureBox25.Image)
            {
                pictureBox11.Image = pictureBox10.Image;
                pictureBox10.Image = pictureBox25.Image;
            }

            if (pictureBox6.Image == pictureBox25.Image)
            {
                pictureBox6.Image = pictureBox10.Image;
                pictureBox10.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Image == pictureBox25.Image)
            {
                pictureBox10.Image = pictureBox11.Image;
                pictureBox11.Image = pictureBox25.Image;
            }

            if (pictureBox12.Image == pictureBox25.Image)
            {
                pictureBox12.Image = pictureBox11.Image;
                pictureBox11.Image = pictureBox25.Image;
            }

            if (pictureBox7.Image == pictureBox25.Image)
            {
                pictureBox7.Image = pictureBox11.Image;
                pictureBox11.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Image == pictureBox25.Image)
            {
                pictureBox11.Image = pictureBox12.Image;
                pictureBox12.Image = pictureBox25.Image;
            }

            if (pictureBox8.Image == pictureBox25.Image)
            {
                pictureBox8.Image = pictureBox12.Image;
                pictureBox12.Image = pictureBox25.Image;
            }
            if (CheckPuzzles())
            {
                // Oyun kazanýldý
                MessageBox.Show("Tebrikler, oyunu kazandýnýz!");
            }
        }
        //burak
        private void btn_Duraklat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            MessageBox.Show("Duraklattýnýz...");
        }

    }
}

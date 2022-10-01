using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class OnePlace : Form
    {
        public OnePlace()
        {
            InitializeComponent();
        }

       private Form cliForm;
       public clientForm form
        {
            set { cliForm = value; }
        }

       private string _ten;
       public string ten
        {
            set { _ten = value; }
        }
        private string _ma_so;
        public string ma_so
        {
            set { _ma_so = value; }
        }
        private string _kinh_do;
        public string kinh_do
        {
            set { _kinh_do = value; }
        }
        private string _vi_do;
        public string vi_do
        {
            set { _vi_do = value; }
        }
        private string _mo_ta;
        public string mo_ta
        {
            set { _mo_ta = value; }
        }
        private string[] _pic;
        public string[] pic
        {
            set { _pic = value; }
        }

        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        PictureBox org;
        private void OneObj_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

            this.DoubleBuffered = true; //minimize the strutter

            byte[] NewBytes1 = Convert.FromBase64String(_pic[0]);
            MemoryStream ms1 = new MemoryStream(NewBytes1);
            Image image1 = Image.FromStream(ms1);
            pictureBox2.Image = new Bitmap(image1, pictureBox2.Width, pictureBox2.Height);

            byte[] NewBytes2 = Convert.FromBase64String(_pic[1]);
            MemoryStream ms2 = new MemoryStream(NewBytes2);
            Image image2 = Image.FromStream(ms2);
            pictureBox3.Image = new Bitmap(image2, pictureBox3.Width, pictureBox3.Height);

            byte[] NewBytes3 = Convert.FromBase64String(_pic[2]);
            MemoryStream ms3 = new MemoryStream(NewBytes3);
            Image image3 = Image.FromStream(ms3);
            pictureBox4.Image = new Bitmap(image3, pictureBox4.Width, pictureBox4.Height);

            org = new PictureBox();
            org.Image=pictureBox1.Image;

            textBox1.Text = _ma_so;
            textBox2.Text = _kinh_do;
            textBox3.Text = _vi_do;
            richTextBox1.Text = _mo_ta;
            textBox4.Text = _ten;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value!=0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(org.Image, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox2.Image,pictureBox1.Width,pictureBox1.Height);
            org.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox3.Image, pictureBox1.Width, pictureBox1.Height);
            org.Image = pictureBox3.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox4.Image, pictureBox1.Width, pictureBox1.Height);
            org.Image = pictureBox4.Image;
        }
    }
}

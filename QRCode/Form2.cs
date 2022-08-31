using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;

namespace QRCode
{
    public partial class Form2 : Form
    {
        QRCodeEncoder code = new QRCodeEncoder();
        Image resim;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resim = code.Encode(textBox1.Text);
            pictureBox1.Image = resim;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 ekle = new Form1();
            //ekle.Show();
            //this.Hide();
        }
    }
}

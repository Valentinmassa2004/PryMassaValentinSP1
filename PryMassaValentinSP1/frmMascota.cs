using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMassaValentinSP1
{
    public partial class frmMascota : Form
    {
        public frmMascota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox omnitorrinco = new PictureBox();
            PictureBox perro = new PictureBox();
            PictureBox caballo = new PictureBox();

            omnitorrinco.Image = Properties.Resources.omnitorrinco;
            omnitorrinco.SizeMode = PictureBoxSizeMode.StretchImage;
            omnitorrinco.Location = new Point(500, 10);

            perro.Image = Properties.Resources.Perro;
            perro.SizeMode = PictureBoxSizeMode.StretchImage;  
            perro.Location = new Point(500, 60);

            caballo.Image = Properties.Resources.Caballo;
            caballo.SizeMode = PictureBoxSizeMode.StretchImage;
            caballo.Location = new Point(500, 110);
             
            Controls.Add(omnitorrinco);
            Controls.Add(perro);
            Controls.Add(caballo);

        }

        private void frmMascota_Load(object sender, EventArgs e)
        {

        }
    }
}

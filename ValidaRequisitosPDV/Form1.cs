using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidaRequisitosPDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] pictures;
        int contadorPictures = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(contadorPictures == 0)
            { pictureVerWindows.Image = ValidaRequisitosPDV.Properties.Resources.emblemok_103757;  }

            if (contadorPictures == 1)
            { pictureVerJava.Image = ValidaRequisitosPDV.Properties.Resources.emblemok_103757; }

            if (contadorPictures == 2)
            { pictureVerDotNet.Image = ValidaRequisitosPDV.Properties.Resources.emblemok_103757; }

            if (contadorPictures == 3)
            { pictureVerAgenteNDD.Image = ValidaRequisitosPDV.Properties.Resources.emblemok_103757; }

            if (contadorPictures == 4)
            { pictureBemaComm.Image = ValidaRequisitosPDV.Properties.Resources.kisspng_ok_symbol_clip_art_cancel_cliparts; }

            if (contadorPictures == 5)
            { pictureImpressora.Image = ValidaRequisitosPDV.Properties.Resources.emblemok_103757; }

            if (contadorPictures == 6)
            { pictureSat.Image = ValidaRequisitosPDV.Properties.Resources.kisspng_ok_symbol_clip_art_cancel_cliparts; }

            if (contadorPictures == 07)
            { 
              pictureMFE.Image = ValidaRequisitosPDV.Properties.Resources.emblemok_103757;
              timer1.Stop();
              lblStatus.Text = "Concluído!";
            }

            contadorPictures++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictures[0] = "pictureVerWindows";
            //pictures[1] = "pictureVerJava";
            //pictures[2] = "pictureVerDotNet";
            //pictures[3] = "pictureVerAgenteNDD";
            //pictures[4] = "pictureBemaComm";
            //pictures[5] = "pictureImpressora";
            //pictures[6] = "pictureSat";
            //pictures[7] = "pictureMFE";
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            lblStatus.Text = "Em Execução...";
            lblStatus.Visible = true;
            pictureVerWindows.Visible = true;
            pictureVerJava.Visible = true;
            pictureVerDotNet.Visible = true;
            pictureVerAgenteNDD.Visible = true;
            pictureBemaComm.Visible = true;
            pictureImpressora.Visible = true;
            pictureSat.Visible = true;
            pictureMFE.Visible = true;

            timer1.Start();
        }
    }
}

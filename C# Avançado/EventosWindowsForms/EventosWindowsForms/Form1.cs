using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventosWindowsForms.Lib;
using EventosWindowsForms.Lib.Mensageiro;

namespace EventosWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnVideoEncode.Click += EventoClick;
        }

        private void EventoClick(object sender, EventArgs e)
        {
            VideoEncode videoEncode = new VideoEncode();
            //Erro:
            //videoEncode.Encoded(new Video());
            videoEncode.Encoded += new Email().EnviarMensagem;
            videoEncode.Encoded += new SMS().EnviarMensagem;
            Video video = new Video() {Nome = "Video.mp4"};
            videoEncode.Encode(video);
        }
    }
}
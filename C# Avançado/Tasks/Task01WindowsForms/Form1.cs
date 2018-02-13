using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {

            string site = txtSite.Text;
            WebClient webClient = new WebClient();

            /*
             * //Sem Task
            string html = webClient.DownloadString(site);
            txtResultado.Text = html;
            */

            string html = await webClient.DownloadStringTaskAsync(new Uri(site));
            txtResultado.Text = html;

        }
    }
}

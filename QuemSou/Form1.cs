using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace QuemSou
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nomeComputador = System.Net.Dns.GetHostName();
            string nomeUser = System.Environment.UserName;
            System.Net.IPAddress[] ip = System.Net.Dns.GetHostAddresses(nomeComputador);
            
            labelNomeComputador.Text = nomeComputador;
            labelUserWindows.Text = nomeUser;
            if(ip.Length > 2)
            {
                labelIPLocal.Text = ip[2].ToString();
            }
            else
            {
                labelIPLocal.Text = ip[1].ToString();
            }

            var ping = new Ping();
            var reply = ping.Send("172.31.1.1");
            if (reply.Status == IPStatus.Success)
            {
                RedeLocalTeste.Text = ("Rede Local Online");
                RedeLocalTeste.ForeColor = Color.Green;
            }
            else
            {
                RedeLocalTeste.Text = ("Rede Local Offline");
                RedeLocalTeste.ForeColor = Color.Red;
            }
            var ping2 = new Ping();
            var reply2 = ping2.Send("nidio.dev");
            if (reply2.Status == IPStatus.Success)
            {
                InternetTest.Text = ("Internet Online");
                InternetTest.ForeColor = Color.Green;
            }
            else
            {
                InternetTest.Text = ("Internet Offline");
                InternetTest.ForeColor = Color.Red;
            }
        }

    }
}

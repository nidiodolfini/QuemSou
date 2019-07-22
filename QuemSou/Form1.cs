using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            labelIPLocal.Text = ip[1].ToString();
           
        }

    }
}

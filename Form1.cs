using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
namespace GUIPing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingOptions options = new PingOptions();
            
            string buffer = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            int timeout = 100;
            byte[] bytes = Encoding.UTF8.GetBytes(buffer);
            try {
                options.Ttl = int.Parse(ttlbox.Text);
                string host = hostbox.Text;
                PingReply reply = ping.Send(host, timeout, bytes, options);
                if (reply.Status == 0) lbl4.Text = "Host is up!";
                else if (reply.Status == IPStatus.DestinationHostUnreachable) lbl4.Text = "Host Unreachable!";
                else lbl4.Text = "Unknown Host/Unknown Error!";
            }
            catch
            {
                lbl4.Text = "Invalid given input. \n Please restart and try again!";
            }
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void label3_Click(object sender, EventArgs e) {
        
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    
    }
}
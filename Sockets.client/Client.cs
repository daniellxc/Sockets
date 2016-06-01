using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sockets.client
{
    public partial class Client : Form
    {

        TcpClient clientSocket = new TcpClient();

        public Client()
        {
            InitializeComponent();

            msg("Client iniciado");
            clientSocket.Connect("autorizador1.paysmart.com.br", 8887);
            lblStatus.Text = "Client Socket Program - Conectado ao servidor...";
        }

        public  void EnviarMensagem()
        {
            try
            {
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(txtMsg.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] inStream = new byte[10025];
                serverStream.Read(inStream, 0, inStream.Length);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                msg(returndata);
                txtMsg.Text = "";
                txtMsg.Focus();
             
            }
            catch
            {
               throw;
            }
        }

        private void btnEnviarMsg_Click(object sender, EventArgs e)
        {
            try
            {
                EnviarMensagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void msg(string mesg)
        {
            txtFormServer.Text = txtFormServer.Text + Environment.NewLine + " >> " + mesg;
        } 
    }
}

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
using System.Threading;
using System.Windows.Forms;

namespace Sockets.server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }


       
        IPEndPoint ipEnd_servidor;
        Socket sock_Servidor;
        Socket handler;
        SocketPermission permission;
       // public static string caminhoRecepcaoArquivos = @"M:\";



        public  void IniciarServidor()
        {
            try
            {
                
                // setando permissões do socket
                permission = new SocketPermission(
                NetworkAccess.Accept,     // permite conexoes 
                TransportType.Tcp,        // define tipo de transporte
                "10.5.3.32",                       // IP
                SocketPermission.AllPorts // para todas as portas
                );

                string strEnderecoIP = "10.5.3.32";

                ipEnd_servidor = new IPEndPoint(IPAddress.Parse(strEnderecoIP), 5656);
                sock_Servidor = new Socket(
                    ipEnd_servidor.AddressFamily,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );

                sock_Servidor.Bind(ipEnd_servidor);
            
                //iniciando escuta
                sock_Servidor.Listen(10);
                sock_Servidor.Accept();
               
            }
            catch (SocketException ex)
            {
                throw;
            }
        }


      

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {

                IniciarServidor();
                txtRecebidas.Text += "Servidor inciado" + Environment.NewLine;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

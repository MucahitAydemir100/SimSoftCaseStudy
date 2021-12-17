using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimSoftCaseClient
{
	public partial class Form1 : Form
	{

		private TcpClient client;
		public StreamReader reader;
		public StreamWriter writer;
		public string recieve;
		public string[] coords;
		Form2 form2;
		bool showed = false;

		Thread th1;

		public Form1()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
		}


		private  void ConnectionButton_Click(object sender, EventArgs e)
		{
			form2 = new Form2(0, 0, 30, 20);
			form2.Show();
		    th1 = new Thread(ExecuteClient);
			th1.Start();
			
		}

        void ExecuteClient()
        {
			while(true)
			{
            try
            {
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(IpTextField.Text), int.Parse(PortTextField.Text));

                Socket sender = new Socket(SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(localEndPoint);

                    Console.WriteLine("Socket connected to -> {0} ",
                                  sender.RemoteEndPoint.ToString());

                    byte[] messageReceived = new byte[1024];


                    int byteRecv = sender.Receive(messageReceived);
					string receivedMessage = Encoding.Default.GetString(messageReceived);
					Console.WriteLine("Message from Server -> {0}",receivedMessage);
					coords = receivedMessage.Split('~');
				
					form2.NewCoordValue(int.Parse(coords[0]), int.Parse(coords[1]));

                }

                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {

                    Console.WriteLine("SocketException : {0}", se.ToString());
                }

                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
			}
		}

		private  void SendData()
		{


		}

		private void button1_Click(object sender, EventArgs e)
		{
			SendData();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			th1.Abort();
		}
	}
}

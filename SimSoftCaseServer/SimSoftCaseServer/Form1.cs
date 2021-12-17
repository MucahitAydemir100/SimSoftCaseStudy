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


namespace SimSoftCaseServer
{
	public partial class Form1 : Form, INotifyPropertyChanged
	{
		
		public Form2 form2 = new Form2();
		private Thread thSrv;
		public event PropertyChangedEventHandler PropertyChanged;

		public Form1()
		{

			InitializeComponent();
			this.IsMdiContainer = true;
			IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
			
			foreach (IPAddress address  in localIP)
			{
				if(address.AddressFamily == AddressFamily.InterNetwork)
				{
					IpTextBox.Text = address.ToString();
				}
			}
		}
	
		private  void button1_Click(object sender, EventArgs e)
		{
			form2.Show();
			thSrv = new Thread(ExecuteServer);
			thSrv.Start();
		}

        public  void ExecuteServer()
        {
			while (true)
			{
				IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
				IPAddress ipAddr = ipHost.AddressList[0];
				IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, int.Parse(portTextBox.Text));


				Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp);

				try
				{
					listener.Bind(localEndPoint);
					listener.Listen(10);
					while (true)
					{
						Console.WriteLine("Waiting connection ... ");

						Socket clientSocket = listener.Accept();
			
						string messageToSend = form2._x.ToString() + "~" + form2._y.ToString();
						byte[] message = Encoding.ASCII.GetBytes(messageToSend);


						clientSocket.Send(message);

						clientSocket.Shutdown(SocketShutdown.Both);
						clientSocket.Close();
					}
				}

				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				Thread.Sleep(20);
			}
        }


		public void show()
		{
				form2.Show();
		}

	}
}

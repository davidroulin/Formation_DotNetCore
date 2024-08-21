using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;


public class ExempleReseau1
{

	public const int DEFAULT_PORT = 8888;

	public const string addresse1 = "192.168.0.1"; 
	public const string addresse2 = "192.168.0.2";

	public static class UDPSender
	{
		public static void Send(string message = "hello", string address = "127.0.0.1", int port = DEFAULT_PORT)
		{
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			IPAddress ip = IPAddress.Parse(address);
			byte[] packet = Encoding.ASCII.GetBytes(message);
			IPEndPoint endpoint = new IPEndPoint(ip, port);
			socket.SendTo(packet, endpoint); 
		}

		//string input;
		//Console.WriteLine("Message ?");
		//	input = Console.ReadLine();
		//	Console.WriteLine(input);
	}

	public abstract class GenericUDPListener
	{

		public int Port { get { return endpoint.Port; } }

		protected UdpClient udpClient;
		protected IPEndPoint endpoint;

		public void OnReceivedBytes(byte[] b_packet)
		{
			string s_packet = Encoding.ASCII.GetString(b_packet);
			Console.WriteLine($"Received: {s_packet}");
		}

		public GenericUDPListener(
			int port = DEFAULT_PORT
		)
		{
			// TODO parse arg if provided
			IPAddress ip = IPAddress.Any;

			udpClient = new UdpClient(port);
			endpoint = new IPEndPoint(ip, port);
		}
	}

	public class UDPListenerAsync : GenericUDPListener
	{
		public bool pleaseClose;


		public async Task Receive()
		{
			while (!pleaseClose)
			{
				UdpReceiveResult result = await udpClient.ReceiveAsync();
				OnReceivedBytes(result.Buffer);
			}
		}


		public UDPListenerAsync(
			int port = DEFAULT_PORT
		) : base(port)
		{

		}


	}

	public class UDPListenerBlocking : GenericUDPListener
	{

		public void Receive()
		{
			try
			{
				while (true)
				{
					byte[] b_packet = udpClient.Receive(ref endpoint);
					OnReceivedBytes(b_packet);
				}
			} catch (SocketException e)
			{
				Console.WriteLine(e);
			} finally
			{
				udpClient?.Close();
			}
		}

		public UDPListenerBlocking(
			int port = DEFAULT_PORT
		) : base(port)
		{
			
		}

	}

}

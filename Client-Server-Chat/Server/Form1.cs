using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class serverGUI : Form
    {
        TcpClient client;
        TcpListener listener;
        List<TcpClient> clientsList = new List<TcpClient>();

        public serverGUI()
        {
            InitializeComponent();

            // Start server with random port
            initiateListener();


        }


        /// <summary>
        /// Starts the TCPListener and assigns it a port number. The IP = IPAddress.Any
        /// </summary>
        /// <param name="port">Any port number between 1 and 65535. If set as 0 or not defined it leaves the port assigning to the OS</param>
        /// <returns>True if listener initiated, otherwise false.</returns>
        public bool initiateListener(int port = 0)
        {
            if(port < 0 || port > 65535)
            {
                Console.WriteLine("The port number chosen is too big.");
                return false;
            }

            string hostName = Dns.GetHostName();
            IPAddress[] hostAddresses = Dns.GetHostAddresses(hostName);
            foreach (IPAddress address in hostAddresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    try
                    {
                        // A port of '0' means the OS chooses the port
                        listener = new TcpListener(address, 0);
                        listener.Start();

                        // Prints the IP and the port # separated by a colon
                        tbxLoginInfo.Text = address.ToString() + ":" + ((IPEndPoint)listener.LocalEndpoint).Port.ToString(); ;

                        startListening();
                        return true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                        return false;
                    }
                }
            }

            // The program should never reach this point
            return false;
        }


        /// <summary>
        /// Starts an async listener. When information is incoming start parsing it. It also adds the client to the connected clientlist. 
        /// </summary>
        public async void startListening()
        {
            try
            {
                client = await listener.AcceptTcpClientAsync();
                updateClientList(client);


                startReading(client);
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

            
        }


        /// <summary>
        /// Forwards the incoming message to the other connected clients
        /// </summary>
        /// <param name="c">The client from whom we're recieveing data. </param>
        public async void startReading(TcpClient c)
        {
            byte[] message = new byte[256];
            int n = 0;
            try
            {
                n = await c.GetStream().ReadAsync(message, 0, message.Length);
            }
            catch (Exception error) {
                Console.WriteLine("Server: Something went wrong while reading incoming message. Error: " + error.Message);
                return;
            }


            // Forward the message to connected clients
            forwardMessage(message);
            startReading(c);
        }

        /// <summary>
        /// Sends the incoming message to all connected clients defined in clientsList List.
        /// </summary>
        /// <param name="message">The message to be sent.</param>
        public async void forwardMessage(byte[] message)
        {
            foreach(TcpClient c in clientsList)
            {
                try
                {
                    await c.GetStream().WriteAsync(message, 0, message.Length);
                }
                catch (Exception exception) {
                    Console.WriteLine("Something went wrong when sending data to client. Error data: "+ exception.Message);
                    return;
                }
            }
        }

        /// <summary>
        /// Appends client to clientsList and populates the ListBox with new content
        /// </summary>
        /// <param name="client">The new TcpClient to add</param>
        public void updateClientList(TcpClient client)
        {
            clientsList.Add(client);
            foreach(TcpClient c in clientsList)
            {
                // Adds list of connected IPs along with their respective ports(e.g. 127.0.0.1:5001)
                lbxConnectedClients.Items.Add(tbxLoginInfo.Text = ((IPEndPoint)c.Client.RemoteEndPoint).Address.ToString() + ":" + ((IPEndPoint)c.Client.RemoteEndPoint).Port.ToString());
            }
        }

        private void btnStopListening_Click(object sender, EventArgs e)
        {
            foreach(TcpClient c in clientsList)
            {
                c.Close();
            }
            listener.Stop();
            clientsList.Clear();
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            initiateListener();
        }
    }
}

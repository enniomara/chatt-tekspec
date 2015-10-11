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

namespace Client
{
    public partial class Form1 : Form
    {

        TcpClient client;
        TcpListener listener;
        const string splitSeparator = "¤%&splitSeparator¤%&";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (tbxConnectInformation.Text != "")
            {
                string[] loginInfo = tbxConnectInformation.Text.Split(':');
                IPAddress IP;
                int port;

                if(IPAddress.TryParse(loginInfo[0], out IP) && int.TryParse(loginInfo[1], out port))
                {

                    client = new TcpClient(loginInfo[0], port);

                    gbxChatMain.Enabled = true;
                    startReading();

                }
                else
                {
                    Console.WriteLine("Client: Failed parsing login IP or Port Number. Make sure you have entered correct connect information(e.g. 127.0.0.1:8080).");
                }



            }
        }


        /// <summary>
        /// Starts an async listener. When information is incoming start parsing it. It also adds the client to the connected clientlist. 
        /// </summary>
        public async void startListening()
        {
            try
            {
                client = await listener.AcceptTcpClientAsync();
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

            startReading();
        }


        /// <summary>
        /// Reads the message and outputs it to the chat.
        /// </summary>
        public async void startReading()
        {

            byte[] buffer = new byte[256];

            int n = 0;
            try
            {
                n = await client.GetStream().ReadAsync(buffer, 0, 256);
                //n = client.GetStream().Read(buffer, 0, 256);
            }
            catch (Exception error)
            {
                MessageBox.Show("What" + error.Message);
                return;
            }

            // [0] => IP Address
            // [1] => Message
            // http://stackoverflow.com/questions/2245442/c-sharp-split-a-string-by-another-string
            string[] messageData = Encoding.Unicode.GetString(buffer, 0, n).Split(new string[] { splitSeparator }, StringSplitOptions.None);


            tbxChatLogs.Text += messageData[0] + "\r\n" + messageData[1] + "\r\n \r\n";
            startReading();
        }

        /// <summary>
        /// Sends the message back to the server.
        /// </summary>
        /// <param name="message">The message to be sent(tbxMessage.Text)</param>
        public async void startSending(string message)
        {
            if (client.Connected)
            {
                byte[] messageByte = Encoding.Unicode.GetBytes(message);

                try
                {
                    await client.GetStream().WriteAsync(messageByte, 0, messageByte.Length);
                }
                catch(Exception error)
                {
                    Console.WriteLine("Something went wrong when sending message");
                    return;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            startSending(tbxMessage.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Stop();
            client.Close();
        }
    }
}

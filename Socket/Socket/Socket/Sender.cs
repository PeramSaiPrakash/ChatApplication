using System;
using System.Net.Sockets;
using System.Text;
using serverdll;

namespace Client
{
    public partial class Sender : Form
    {
        private TcpClient client;
        private bool conn = false;
        public Sender()
        {
            InitializeComponent();
            client= new TcpClient();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Send_click(object sender, EventArgs e)
        {
            string message=inputBox.Text;
            string receivedMessage = serverdll.SendClick.SendMessage(message, client);
            Display.Text += (message == "") ? "<Empty>" : message;
            Display.Text += "\r\n";
            this.Invoke((MethodInvoker)delegate
            {
                Display.Text += receivedMessage + "\r\n";
            });

        }
        private void close_click(object sender, EventArgs e)
        {

            //WindowSettings settings = new WindowSettings();
            this.Close();
            //settings.Close();
        }
        private void IpAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void PortNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void Display_TextChanged(object sender, EventArgs e)
        {

        }
        private void clear_Click(object sender, EventArgs e)
        {
            Display.Text = string.Empty;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            if (!conn)
             {
                 try
                 {
                     try
                     {
                         int portNumber = int.Parse(PortNumber.Text);
                         string IpAddress = this.IpAddress.Text;
                         client = new TcpClient(IpAddress, portNumber);
                         conn = true;
                         Display.Text = "Connection Established Successufully" + "\r\n";
                         Connect.Text = "Disconnect";
                     }
                     catch (FormatException)
                     {
                         Display.Text = "Invalid port number entered." + "\r\n";
                     }
                     catch (ArgumentNullException)
                     {
                         Display.Text = "IP address cannot be empty" + "\r\n";
                     }
                     catch (SocketException)
                     {
                         Display.Text = "Failed to connect the server" + "\r\n";
                     }
                     catch (Exception ex)
                     {
                         Display.Text = ex.ToString();
                     }
                 }
                 catch (Exception ex)
                 {
                     Display.Text = "connection failed" + "\r\n";
                 }
             }
             else
             {
                 if (client != null && client.Connected)
                 {
                     NetworkStream stream = client.GetStream();
                     stream.Close();
                     client.Close();
                 }
                 client = null;
                 Connect.Text = "Connect";
                 Display.Text = "Disconnected"+ "\r\n";
                 conn = false;
             }
        }
    }
}

using System.Net.Sockets;
using System.Text;

namespace serverdll
{
    public class SendClick
    {
        public static string SendMessage(string message, TcpClient client)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                stream.Flush();
                byte[] receivedData = new byte[1024];
                int bytesRead = stream.Read(receivedData, 0, receivedData.Length);
                string receivedMessage = Encoding.ASCII.GetString(receivedData, 0, bytesRead);
                return receivedMessage;
            }
            catch (FormatException)
            {
                return "Invalid part number entered.";
            }
            catch (ArgumentNullException)
            {
                return "IP address cannot be empty.";
            }
            catch (SocketException)
            {
                return "Failed to connect to the server.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}



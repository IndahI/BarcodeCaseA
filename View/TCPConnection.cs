using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using BarcodeCaseA.Properties;

namespace BarcodeCaseA.View
{
    public class TCPConnection
    {
        private Action<string> updateUiCallback;
        private TcpClient client;
        private NetworkStream stream;

        public TCPConnection(Action<string> updateUiCallback) // Added updateUiCallback2 as a parameter
        {
            this.updateUiCallback = updateUiCallback;
        }

        public async Task ConnectToServerAsync()
        {
            string serverIp = Settings.Default.ServerIP; // Retrieve IP from user settings
            int port = Settings.Default.Port;

            CloseConnection();

            client = new TcpClient();
            try
            {
                await client.ConnectAsync(serverIp, port);
                //await SendMessageToServerAsync(client, "Hello from client!");

                await HandleServerResponseAsync(client);
            }
            catch (Exception ex)
            {
                //updateUiCallback?.Invoke($"Error connecting to server: {ex.Message}");
            }
        }

        public void CloseConnection()
        {
            if (stream != null)
            {
                stream.Close();
                stream = null;
            }
            if (client != null)
            {
                client.Close();
                client = null;
            }
        }

        private async Task HandleServerResponseAsync(TcpClient client)
        {
            try
            {
                stream = client.GetStream();
                byte[] buffer = new byte[1024];
                string incomingData = "";

                while (true)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        // Connection closed by server
                        break;
                    }

                    incomingData += Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Process all complete messages in incomingData
                    while (incomingData.Contains("<p>"))
                    {
                        int startIdx = incomingData.IndexOf("<p>");
                        int endIdx = incomingData.IndexOf("</p>");

                        if (endIdx != -1) // Ensure end tag exists
                        {
                            string message = incomingData.Substring(startIdx + 3, endIdx - startIdx - 3);
                            incomingData = incomingData.Substring(endIdx + 4);

                            ProcessMessage(message);
                        }
                        else
                        {
                            // Incomplete message, wait for more data
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //updateUiCallback?.Invoke($"Error handling server response: {ex.Message}");
            }
        }

        private void ProcessMessage(string message)
        {
            string cleanedData = Regex.Replace(message, "<.*?>", "");
            updateUiCallback?.Invoke(cleanedData);
        }
    }
}
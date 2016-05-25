using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Comunication
{
   //communication class code, this class contains a mutual code both to the server side and the client side.
    public class Comm :IDisposable
    {
        Socket socket;
        NetworkStream networkStrem;
        BinaryFormatter binary;
        Thread thread;
        public event EventHandler<MessageEventArgs> GotMessage;
       
        public Comm(Socket socket)
        {
            this.socket = socket;
            networkStrem = new NetworkStream(socket);
            binary = new BinaryFormatter();
            thread = new Thread(Recive);
            thread.IsBackground = true;
            thread.Start();
        }
        //the role of this function is rise the the got message evant
        public void Recive()
        {
            while (true)
            {
                try
                {
                    BaseMessage message = (BaseMessage)binary.Deserialize(networkStrem);
                    GotMessage(this, new MessageEventArgs(message));
                }
                catch (SerializationException) { break; }
                catch (IOException) { break; }
            }
        }

        public void Send(BaseMessage massege)
        {
            binary.Serialize(networkStrem, massege);
        }
       

        public void Dispose()
        {
            thread.Abort();
            networkStrem.Dispose();
            socket.Close();
        }
      
    }
}

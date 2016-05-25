using Comunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    //the server side class
    public partial class Server_form : Form
    {
       
        bool connected = false;       
        public  string[] oneLine = new string[3];
        private Thread threadNewClient;
        private TcpListener tcpListener;
        public List<Comm> allClients;
        
     

        
        public Server_form()
        {
            InitializeComponent();
          
            
        }

        //this Code belongs to the Connect button of the server form. 
        private void button1_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                MessageBox.Show("you are allready connected");


            }
            else
            {
                tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8090);
                tcpListener.Start();
                allClients = new List<Comm>();
                threadNewClient = new Thread(ListenToNewClients);
                threadNewClient.IsBackground = true;
                threadNewClient.Start();
                connected = true;
            }
           
           
           
        }
        public void ListenToNewClients()
        {
            while (true)
            {
                Socket socket = tcpListener.AcceptSocket();
                Comm comm = new Comm(socket);
                comm.GotMessage += comm_GotMessage;
                allClients.Add(comm);
                


            }
        }


        //Whenever the evant of "comm got message " occurs, this function will begin it's role.
        void comm_GotMessage(object sender, MessageEventArgs e)
        {
            

            Invoke((Action<BaseMessage>)UpdateUI, e.Message);
            

            for (int i = allClients.Count - 1; i >= 0; i--)
            {
                try
                {
                    allClients[i].Send(e.Message);
                   
                }
                catch
                {

                    allClients.RemoveAt(i);


                }
            }
            

                    


               
            

        }

            
                              
         //the role of this function is to update the ui whenever the message contains base message inside.                                                                                                                                                        
        public void UpdateUI(BaseMessage msg)
        {
            if (msg is connectMessage)
            {
                oneLine[0] = (msg as connectMessage).NickName;
                oneLine[1] = (msg as connectMessage).Text = "Connected";
                oneLine[2] = (msg as connectMessage).time.ToString();
                ListViewItem item = new ListViewItem(oneLine);

                listViewServer.Items.Add(item);
                    if (!comboBox_showclients.Items.Contains(oneLine[0]))
                    {
                        comboBox_showclients.Items.Add(oneLine[0]);
                        


                    }
                
                
                if (!comboBox_all_onlines.Items.Contains(oneLine[0]))
                {
                    comboBox_all_onlines.Items.Add(oneLine[0]);
                    textBox_count.Text = (comboBox_all_onlines.Items.Count).ToString();
                }
                

            }
            else if (msg is ClientMessage)
            {
                oneLine[0] = (msg as ClientMessage).NickName;
                oneLine[1] = (msg as ClientMessage).Text;
                oneLine[2] = (msg as ClientMessage).time.ToString();
                ListViewItem item = new ListViewItem(oneLine);

                item.ForeColor = (msg as ClientMessage).Colors;
                listViewServer.Items.Add(item);
                this.listViewServer.Items[this.listViewServer.Items.Count - 1].EnsureVisible();
            }
            else if (msg is DisconnectMessage)
            {
                oneLine[0] = (msg as DisconnectMessage).NickName;
                oneLine[1] = (msg as DisconnectMessage).Text = "Disconnected";
                oneLine[2] = (msg as DisconnectMessage).time.ToString();
                ListViewItem item = new ListViewItem(oneLine);
                listViewServer.Items.Add(item);
                comboBox_all_onlines.Items.Remove(oneLine[0]);
                textBox_count.Text = (comboBox_all_onlines.Items.Count).ToString();
               
            }
            
                                                                         
        }
        //here you can see the code for the exit button
        private void button_close_Click(object sender, EventArgs e)
        {

            Dispose();
        }

        
                                 
            }
   
}

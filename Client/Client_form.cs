using Comunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartWindow
{
   
    //Client side class
    public partial class Client_form : Form
    {
        

        bool connected = false;
        string[] oneLine = new string[3];
        static registration_form reg = new registration_form();
        int count;
        private TcpClient tcpClient;
        private Comm comm;
        string status = "Off Line";
        int is_hide;
        public Client_form()
        {
            InitializeComponent();
            pictureBox_con.Hide();
            notifyIcon1.Text = string.Format(reg.nikname.Text + " " + status); 
            notifyIcon1.BalloonTipText = string.Format("Welcome to nir's chat");
            notifyIcon1.ShowBalloonTip(1);
        }          
      //Whenever the evant of "com got message " occurs, this function will begin working.
        void comm_GotMessage(object sender, MessageEventArgs e)
        {
                                
                Invoke((Action)(() =>
                {
                    string[] oneLine = new string[3];

                   
                        oneLine[0] = (e.Message as TextMessage).NickName;
                        oneLine[1] = (e.Message as TextMessage).Text;
                        oneLine[2] = (e.Message as TextMessage).time.ToString();
                       
                        ListViewItem item = new ListViewItem(oneLine);
                        
                        item.ForeColor = (e.Message as TextMessage).Colors;
                        listViewClient.Items.Add(item);
                       
                       
                        if (is_hide == 1)
                        {
                            notifyIcon1.BalloonTipText = "New messages";
                            notifyIcon1.ShowBalloonTip(1);
                            count++;
                            
                        }

                        
                }

                )

                );
                this.listViewClient.Items[this.listViewClient.Items.Count - 1].EnsureVisible();  
        }

        //the send button of the client form
        public void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                ClientMessage clientMessage = new ClientMessage { NickName = reg.nikname.Text, Text = textBox1.Text, Colors = Globals.FontColor, font = Globals.font };
                if (textBox1.Text != "")
                {
                    comm.Send(clientMessage);
                    textBox1.Text = "";
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(textBox1, "You cannot send an empty message");
                }
            }
            catch
            {
                MessageBox.Show("The Server is of line. please try again later.");
                
            }
           
           
                                                  
        }

        //below this line you can see the code of disconnect button in the client form.
        public void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {

           
            if (connected == true)
            {
               
                DisconnectMessage dis = new DisconnectMessage { NickName = reg.nikname.Text, Text = "disconnected" };
                comm.Send(dis);
                
                tcpClient.Close();
                comm.Dispose();               
                connected = false;
                pictureBox_con.Hide();
                pictureBox_dis.Show();
                status = "Off Line";
                notifyIcon1.Text = string.Format(reg.nikname.Text + " " + status);

                
            }
            else
            {
                MessageBox.Show("you have allready discconected");
                
            }
            }
            catch 
            {

                tcpClient.Close();
                comm.Dispose();
                connected = false;
                pictureBox_con.Hide();
                pictureBox_dis.Show();
                status = "Off Line";
                notifyIcon1.Text = string.Format(reg.nikname.Text + " " + status);
            }
                                
        }

        //here you can see the code of the connect button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (connected == false)
                {

                    tcpClient = new TcpClient();
                    tcpClient.Connect("127.0.0.1", 8090);
                    comm = new Comm(tcpClient.Client);
                    comm.GotMessage += comm_GotMessage;
                    reg.GotRegisterd += reg_GotRegisterd;

                    status = "On Line";
                    pictureBox_dis.Hide();
                    pictureBox_con.Show();
                    connected = true;

                    reg.ShowDialog();
                    Text = reg.nikname.Text;
                    connected = true;




                }
                else
                {
                    MessageBox.Show("you have allready cconected");
                }

                notifyIcon1.Text = string.Format(reg.nikname.Text + " " + status);




            }
            catch
            {
                MessageBox.Show("The server is of line");
            }
        }

        //Whenever the evant of "Got Registerd" occurs, this function will begin working.
        void reg_GotRegisterd(object sender, GotRegisterdEventArgs e)
        {
          
                comm.Send(e.Message);

                reg.GotRegisterd -= reg_GotRegisterd;
            
            
                                                                         
        }
       
        //the exit button on client form.
        private void button_EXIT_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                buttonDisconnect.PerformClick();
                Close();
            }  Close();
            
            
        }
        //those tree functions below, are the code of buttons: close,hide and show in the Tool Strip Menu of the client form.  
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            is_hide = 0;
            
        }

        private void cLOSEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buttonDisconnect.PerformClick();
            Application.Exit();
        }

        private void hIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            is_hide = 1;
            
        }
        
        }
                                                
    }


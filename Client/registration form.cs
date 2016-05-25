using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comunication;
namespace StartWindow
{
    //registration class
    public partial class registration_form : Form
    {
        public event EventHandler<GotRegisterdEventArgs> GotRegisterd;
        public registration_form()
        {
           
            InitializeComponent();
           
        }

        //this is the code for the save button of this Form. it's role is also to do some validation and rise the evant of got registration.
        public void SAVE_Click(object sender, EventArgs e)
        {

            
            if (nikname.Text == "")
            {
                errorProvider1.SetError(nikname, "in order to register successfully, you must choose a name or a nikname");
               
            }
            else if (nikname.Text != "")
            {
                errorProvider1.Clear();
                connectMessage c_msg = new connectMessage() { NickName = nikname.Text, Colors = colorDialog1.Color, Text = "Is On Line" };
                GotRegisterd(this, new GotRegisterdEventArgs(c_msg));
                nikname.ReadOnly = true;
                Close();   
            }
            

        }
        //here you can see the code for the color button
        private void buttonColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Globals.FontColor = colorDialog1.Color;
            }




        }
        //here you can see the code for the font button in the form.

        private void buttonFont_Click(object sender, EventArgs e)
        {
            DialogResult resoult_1 = fontDialog1.ShowDialog();
            if (resoult_1 == DialogResult.OK)
            {
                Globals.font = fontDialog1.Font;
            }
        }

      

       
    }
}

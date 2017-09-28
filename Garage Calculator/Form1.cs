using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage_Calculator
{
    public partial class MainPage : Form
    {
        int width;
        int legnth;
        int height;
        int overhangin;
        int overhang;
        public MainPage()
        {
           
              
            
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt32(TBwidth.Text);
            legnth = Convert.ToInt32(TBlegnth.Text);


            if (CBheight.SelectedItem.ToString() == "8'")
            {
                debugheight.Text = "8 Foot";
                height = 8;
            }

            if (CBheight.SelectedItem.ToString() == "10'")
            {
                debugheight.Text = "10 Foot";
                height = 10;
            }

            if (CBheight.SelectedItem.ToString() == "12'")
            {
                debugheight.Text = "12 Foot";
                height = 12;
            }

            if (CBheight.SelectedItem.ToString() == "14'")
            {
                debugheight.Text = "14 Foot";
                height = 14;
            }

            if (CBheight.SelectedItem.ToString() == "16'")
            {
                debugheight.Text = "16 Foot";
                height = 16;
            }




            //SetDebug Labels

            debugwidth.Text = Convert.ToString(width);
            debuglegnth.Text = Convert.ToString(legnth);
            debugheightt.Text = Convert.ToString(legnth);




        }
    }
}

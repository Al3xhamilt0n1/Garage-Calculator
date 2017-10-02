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
        //Basic Sizes
        int width;
        int legnth;
        int height;
        double overhangin;
        double overhang;
        int studs;
        int pitch;
        double gablearea;


        //Conversions
        int perimiter;
        double factor75 = 0.75;

        //Windows
        double Window1widthin;
        double Window1heightin;
        double Window1Height;
        double Window1Width;
        
      

        double Window2widthin;
        double Window2heightin;
        double Window2Height;
        double Window2Width;

        double Window3widthin;
        double Window3heightin;
        double Window3Height;
        double Window3Width;

        double Window4widthin;
        double Window4heightin;
        double Window4Height;
        double Window4Width;

        double Window1Area;
        double Window2Area;
        double Window3Area;
        double Window4Area;



        double totalWindowHeader;

        //Doors
        double Door1Widthin;
        double Door1heightin;
        double Door1Width;
        double Door1height;

        double Door2Widthin;
        double Door2heightin;
        double Door2Width;
        double Door2height;

        double Door3Widthin;
        double Door3heightin;
        double Door3Width;
        double Door3height;

        double Door4Widthin;
        double Door4heightin;
        double Door4Width;
        double Door4height;

        double door1Area;
        double door2Area;
        double door3Area;
        double door4Area;

        double totalDoorHeader;

        //Garage Doors
        double Garage1Widthin;
        double Garage1Heightin;
        double Garage1Width;
        double Garage1Height;

        double Garage2Widthin;
        double Garage2Heightin;
        double Garage2Width;
        double Garage2Height;

        double garaged1Area;
        double garaged2Area;

        // Presets
        double sillgasketlegnth = 82;
        double sillplatelegnth = 16;
        double sillplatex3;
        double sillplatex3w;
        double waste = 1.10;
        double anchorboltspacing = 6;
        double extraWheader = 0.66;
        double extraDheader = 0.66;
        double extraGheader = 0.66;
        double plysize = 32;
        double rollventlegnth = 20;
        double steelwidth = 36;


        //estiamte
        double Estuds;
        string studssize;
        string studheight;
        double Esillgasket;
        double sillgasket;
        double sillplate;
        double anchorbolts;

        // Bpartname is before waste
        double Bwindowheader;
        double Bdoorheader;
        double Bgarageheader;
        double Bwallareafinal;
        // Wpartname is after waste
        double Wwindowheader;
        double Wdoorheader;
        double WGarageheader;
        double Wwallareafinal;

        // Epartname is final
        double Ewindowheader;
        double EDoorheader;
        double EGarageheader;
        double Ewallply;



        //Gable Parts
        double gableheight;
        double gableheightin;
        double halfgablewidth;
        double halfgablewidthin;

        //Wall Area
        double wallarea;
        double wallandgable;
        double doorwindowarea;
        double halfdoorwindowarea;
        double wallareafinal;

        //Roof Areas
        double legnthwov;
        double widthov;
        double subfascia;
        double overhang4x;
        double subfasciaw;

        double roofside1;
        double roofside2;
        double roofareabefore;
        double roofareaafter;
        double roofareafinal;
        double rooffactor;
        double Eroofply;

        //Shingles
        double eaves;
        double lfperbundle = 35;
        double capshingle;
        double Ecapshingle;
        double rollvent;
        double Erollvent;

        //Steel Roof
        double eaveinches;
        double ridgeinches;
        double side1;
        double side2;
        double angle;
        double steelsheets;


        public MainPage()
        {
           
              
            
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
            width = Convert.ToInt32(TBwidth.Text);
            legnth = Convert.ToInt32(TBlegnth.Text);
            Window1widthin = Convert.ToInt32(TBW1width.Text);
            Window1heightin = Convert.ToInt32(TBW1Height.Text);
            Window2widthin = Convert.ToInt32(TBW2Width.Text);
            Window2heightin = Convert.ToInt32(TBW2Height.Text);
            Window3widthin = Convert.ToInt32(TBW3width.Text);
            Window3heightin = Convert.ToInt32(TBW3Height.Text);
            Window4widthin = Convert.ToInt32(TBW4width.Text);
            Window4heightin = Convert.ToInt32(TBW4Height.Text);

            Door1Widthin = Convert.ToInt32(TBD1width.Text);
            Door1heightin = Convert.ToInt32(TBD1height.Text);
            Door2Widthin = Convert.ToInt32(TBD2width.Text);
            Door2heightin = Convert.ToInt32(TBD2height.Text);
            Door3Widthin = Convert.ToInt32(TBD3width.Text);
            Door3heightin = Convert.ToInt32(TBD3height.Text);
            Door4Widthin = Convert.ToInt32(TBD4width.Text);
            Door4heightin = Convert.ToInt32(TBD4height.Text);

            Garage1Widthin = Convert.ToInt32(TBG1width.Text);
            Garage1Heightin = Convert.ToInt32(TBG1height.Text);
            Garage2Widthin = Convert.ToInt32(TBG2width.Text);
            Garage2Heightin = Convert.ToInt32(TBG2height.Text);



            // Height Selection
            if (CBheight.SelectedItem.ToString() == "8'")
            {
                height = 8;
                studheight = "8'";
            }

            if (CBheight.SelectedItem.ToString() == "10'")
            {

                height = 10;
                studheight = "10'";
            }

            if (CBheight.SelectedItem.ToString() == "12'")
            {

                height = 12;
                studheight = "12'";
            }

            if (CBheight.SelectedItem.ToString() == "14'")
            {

                height = 14;
                studheight = "14'";
            }

            if (CBheight.SelectedItem.ToString() == "16'")
            {

                height = 16;
                studheight = "16'";
            }

            //OverHang
            overhangin = Convert.ToInt32(TBoverhang.Text);
            overhang = overhangin / 12;


            // Wall Stud Selection
            if (CBstud.SelectedItem.ToString() == "2x4")
            {
                studssize = "2x4";
                studs = 4;
            }

            if (CBstud.SelectedItem.ToString() == "2x6")
            {

                studssize = "2x6";
                studs = 6;
            }

            if (CBstud.SelectedItem.ToString() == "2x8")
            {

                studssize = "2x8";
                studs = 8;
            }


            //Roof Pitch
            if (CBroofpitch.SelectedItem.ToString() == "1/12")
            {
                angle = 4.78;
                pitch = 1;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "2/12")
            {
                angle = 9.46;
                pitch = 2;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "3/12")
            {

                pitch = 3;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "4/12")
            {

                pitch = 4;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "5/12")
            {

                pitch = 5;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "6/12")
            {
 
                pitch = 6;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "7/12")
            {

                pitch = 7;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "8/12")
            {

                pitch = 8;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "9/12")
            {

                pitch = 9;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "10/12")
            {
   
                pitch = 10;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "11/12")
            {

                pitch = 11;
            }
            else if (CBroofpitch.SelectedItem.ToString() == "12/12")
            {

                pitch = 12;
            }



            perimiter = legnth + width + legnth + width;
            //Window Conversion
            Window1Width = Window1widthin / 12;
            Window1Height = Window1heightin / 12;
            Window2Width = Window2widthin / 12;
            Window2Height = Window2heightin / 12;
            Window3Width = Window3widthin / 12;
            Window3Height = Window4heightin / 12;
            Window4Width = Window4widthin / 12;
            Window4Height = Window4heightin / 12;

            //Door Converstion
            Door1height = Door1heightin / 12;
            Door1Width = Door1Widthin / 12;
            Door2height = Door2heightin / 12;
            Door2Width = Door2Widthin / 12;
            Door3height = Door3heightin / 12;
            Door3Width = Door3Widthin / 12;
            Door4height = Door4heightin / 12;
            Door4Width = Door4Widthin / 12;



            //Garage Door Conversion
            Garage1Height = Garage1Heightin / 12;
            Garage1Width = Garage1Widthin / 12;
            Garage2Height = Garage1Heightin / 12;
            Garage2Width = Garage1Widthin / 12;




            // Gable Area Calc
            halfgablewidthin = width / 2;
            gableheightin = pitch * halfgablewidthin;

            gableheight = gableheightin / 12;

            gablearea = gableheight * width;


            //Caluclate window/door area
            Window1Area = Window1Width * Window1Height;
            Window2Area = Window2Width * Window2Height;
            Window3Area = Window3Width * Window3Height;
            Window4Area = Window4Width * Window4Height;

            door1Area = Door1Width * Door1height;
            door1Area = Door1Width * Door1height;
            door1Area = Door1Width * Door1height;
            door1Area = Door1Width * Door1height;

            garaged1Area = Garage1Height * Garage1Width;
            garaged2Area = Garage2Height * Garage2Width;

            doorwindowarea = Window1Area + Window2Area + Window3Area + Window4Area + door1Area + door2Area + door3Area + door4Area + garaged1Area + garaged2Area;
            halfdoorwindowarea = doorwindowarea / 2;
            wallarea = perimiter * height;
            wallareafinal = wallarea - halfdoorwindowarea;
            wallandgable = wallareafinal + gablearea;
            Wwallareafinal = wallandgable * waste;
            Ewallply = Wwallareafinal / plysize;
            int Rwallply = Convert.ToInt32(Ewallply);

            //Trusses
            double Etrusses = legnth / 2;

            //Roof
            double widthin = width * 12;
            double legnthin = legnth * 12;
            side1 = widthin / 2;
            side2 = gableheight;

            double side3 = Math.Sqrt(side1 * side1 + side2 * side2 - 2 * side1 * side2 * Math.Cos(angle * (Math.PI / 180)));

            int Rsteellegnth = Convert.ToInt32(side3);


            ridgeinches = legnth * 12;
            overhang4x = overhang + overhang + overhang + overhang;
            subfascia = perimiter + overhang4x;
            subfasciaw = subfascia * waste;
            int Rsubfascia = Convert.ToInt32(subfasciaw);

            roofside1 = legnth + overhang + overhang;
            roofside2 = width + overhang + overhang;
            roofareabefore = roofside1 * roofside2;
            roofareaafter = roofareabefore * waste;

            if (pitch == 1)
            {
                rooffactor = 1.0033;
            }
            else if (pitch == 2)
            {
                rooffactor = 1.0138;
            }
            else if (pitch == 3)
            {
                rooffactor = 1.0308;
            }
            else if (pitch == 4)
            {
                rooffactor = 1.0541;
            }
            else if (pitch == 5)
            {
                rooffactor = 1.0833;
            }
            else if (pitch == 6)
            {
                rooffactor = 1.1180;
            }
            else if (pitch == 7)
            {
                rooffactor = 1.1577;
            }
            else if (pitch == 8)
            {
                rooffactor = 1.2019;
            }
            else if (pitch == 9)
            {
                rooffactor = 1.2500;
            }
            else if (pitch == 10)
            {
                rooffactor = 1.3017;
            }
            else if (pitch == 11)
            {
                rooffactor = 1.3566;
            }
            else if (pitch == 12)
            {
                rooffactor = 1.4142;
            }


            roofareafinal = roofareaafter * rooffactor;
            Eroofply = roofareafinal / plysize;
            int Rroofply = Convert.ToInt32(Eroofply);



           

           labelEstuds.Text = Convert.ToString(perimiter);

            //Calculation
            anchorbolts = perimiter / anchorboltspacing;
            int Ranchorbolts = Convert.ToInt32(anchorbolts);

            sillgasket = perimiter/sillgasketlegnth;
            int Rsillgasket = Convert.ToInt32(sillgasket);
        

            sillplatex3 = perimiter * 3;
            sillplatex3w = sillplatex3 * waste;
            sillplate = sillplatex3w/sillplatelegnth;
            int Rsillplate = Convert.ToInt32(sillplate);

        


            Bwindowheader = Window1Width + extraWheader + Window2Width + extraWheader + Window3Width + extraWheader + Window4Width + extraWheader;
            Wwindowheader = Bwindowheader * waste;
            int RtotalWindowHeader = Convert.ToInt32(Wwindowheader);

            Bdoorheader = Door1Width + extraDheader + Door2Width + extraDheader + Door3Width + extraDheader + Door4Width + extraDheader;
            Wdoorheader = Bdoorheader * waste;
            int RtotalDoorHeader = Convert.ToInt32(Wdoorheader);


            Bgarageheader = Garage1Width + extraGheader + Garage2Width + extraGheader;
            WGarageheader = Bgarageheader * waste;
            int RtotalGarageheader = Convert.ToInt32(WGarageheader);


            // If shingles Selected
            if (CBroofing.SelectedItem.ToString() == "Shingles")
            {
                labelErooftype.Text = "Bundle Of Shingles";
                labelEroofingamount.Text = Convert.ToString(Rroofply);
                eaves = legnth + overhang + legnth + overhang;
                labelEeave.Text = Convert.ToString(eaves);
                capshingle = legnth + overhang;
                Ecapshingle = capshingle / lfperbundle;
                int Rcapshingle = Convert.ToInt32(Ecapshingle);
                labelEcaptype.Text = "Bundles of Cap Shingles";
             
                labelEcapshingles.Text = Convert.ToString(Rcapshingle);
                labelEridgeventtype.Text = "Rolls 20' Rollvent";
                rollvent = legnth / rollventlegnth;
                int Rrollvent = Convert.ToInt32(rollvent);
                labelEshinglestarter.Text = "LF Starter Shingle";
                labelErollvent.Text = Convert.ToString(Rrollvent);
              
            }

            // If Steel Roofing Selected
            if (CBroofing.SelectedItem.ToString() == "Steel 36 Inch")
            {
               steelsheets = legnthin / steelwidth;
                int Rsteelsheets = Convert.ToInt32(steelsheets);

               

                labelErooftype.Text = Convert.ToString(Rsteellegnth);

                labelEroofingamount.Text = Convert.ToString(Rsteelsheets);
                labelesteel.Text = "Inch Sheets Of Steel";


            }




                // Esitmate 
                labelEstudheight.Text = studheight;
            labelEstudsize.Text = studssize;
            labelEstudsize2.Text = studssize;
            labelEsillgasket.Text = Convert.ToString(Rsillgasket);
            Estuds = perimiter * factor75;
            labelEstuds.Text = Convert.ToString(Estuds);
            labelEsillplates.Text = Convert.ToString(Rsillplate);
            labelEanchorbolts.Text = Convert.ToString(Ranchorbolts);
            labelEwindowheader.Text = Convert.ToString(RtotalWindowHeader);
            labelEdoorheader.Text = Convert.ToString(RtotalDoorHeader);
            labelEgarageheader.Text = Convert.ToString(RtotalGarageheader);
            labelEwallply.Text = Convert.ToString(Rwallply);
            labelEtrusses.Text = Convert.ToString(Etrusses);
            labelEsubfascia.Text = Convert.ToString(Rsubfascia);
            labelEroofply.Text = Convert.ToString(Rroofply);





            //Test Label
            debugtest.Text = Convert.ToString(steelsheets);



        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            About settingsForm = new About();

            // Show the settings form
            settingsForm.Show();
        }


        private void MainPage_Load(object sender, EventArgs e)
        {
            CBwaste.SelectedIndex = 0;
            CBheight.SelectedIndex = 0;
            CBstud.SelectedIndex = 0;
            CBroofpitch.SelectedIndex = 0;
            CBsiding.SelectedIndex = 0;
            CBroofing.SelectedIndex = 0;
        }

        private void CBwaste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBwaste.SelectedItem.ToString() == "5%")
            { waste = 1.05; }
            if (CBwaste.SelectedItem.ToString() == "7%")
            { waste = 1.07; }
            if (CBwaste.SelectedItem.ToString() == "10%")
            { waste = 1.10; }
            if (CBwaste.SelectedItem.ToString() == "15%")
            { waste = 1.15; }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


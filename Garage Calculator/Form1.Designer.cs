namespace Garage_Calculator
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBoverhang = new System.Windows.Forms.TextBox();
            this.CBheight = new System.Windows.Forms.ComboBox();
            this.TBlegnth = new System.Windows.Forms.TextBox();
            this.TBwidth = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.debugwidth = new System.Windows.Forms.Label();
            this.debuglegnth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.debugheight = new System.Windows.Forms.Label();
            this.debugheightt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TBoverhang);
            this.tabPage1.Controls.Add(this.CBheight);
            this.tabPage1.Controls.Add(this.TBlegnth);
            this.tabPage1.Controls.Add(this.TBwidth);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Overhang  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Legnth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // TBoverhang
            // 
            this.TBoverhang.Location = new System.Drawing.Point(71, 85);
            this.TBoverhang.Name = "TBoverhang";
            this.TBoverhang.Size = new System.Drawing.Size(100, 20);
            this.TBoverhang.TabIndex = 3;
            this.TBoverhang.Text = "Inches";
            // 
            // CBheight
            // 
            this.CBheight.FormattingEnabled = true;
            this.CBheight.Items.AddRange(new object[] {
            "8\'",
            "10\'",
            "12\'",
            "14\'",
            "16\'"});
            this.CBheight.Location = new System.Drawing.Point(71, 58);
            this.CBheight.Name = "CBheight";
            this.CBheight.Size = new System.Drawing.Size(100, 21);
            this.CBheight.TabIndex = 2;
            this.CBheight.Text = "Foot";
            // 
            // TBlegnth
            // 
            this.TBlegnth.Location = new System.Drawing.Point(71, 32);
            this.TBlegnth.Name = "TBlegnth";
            this.TBlegnth.Size = new System.Drawing.Size(100, 20);
            this.TBlegnth.TabIndex = 1;
            this.TBlegnth.Text = "Foot";
            // 
            // TBwidth
            // 
            this.TBwidth.Location = new System.Drawing.Point(71, 6);
            this.TBwidth.Name = "TBwidth";
            this.TBwidth.Size = new System.Drawing.Size(100, 20);
            this.TBwidth.TabIndex = 0;
            this.TBwidth.Text = "Foot";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.debugheight);
            this.tabPage2.Controls.Add(this.debugheightt);
            this.tabPage2.Controls.Add(this.debuglegnth);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.debugwidth);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(990, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estimate";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // debugwidth
            // 
            this.debugwidth.AutoSize = true;
            this.debugwidth.Location = new System.Drawing.Point(62, 15);
            this.debugwidth.Name = "debugwidth";
            this.debugwidth.Size = new System.Drawing.Size(35, 13);
            this.debugwidth.TabIndex = 1;
            this.debugwidth.Text = "label6";
            // 
            // debuglegnth
            // 
            this.debuglegnth.AutoSize = true;
            this.debuglegnth.Location = new System.Drawing.Point(62, 43);
            this.debuglegnth.Name = "debuglegnth";
            this.debuglegnth.Size = new System.Drawing.Size(35, 13);
            this.debuglegnth.TabIndex = 3;
            this.debuglegnth.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // debugheight
            // 
            this.debugheight.AutoSize = true;
            this.debugheight.Location = new System.Drawing.Point(62, 71);
            this.debugheight.Name = "debugheight";
            this.debugheight.Size = new System.Drawing.Size(35, 13);
            this.debugheight.TabIndex = 5;
            this.debugheight.Text = "label9";
            // 
            // debugheightt
            // 
            this.debugheightt.AutoSize = true;
            this.debugheightt.Location = new System.Drawing.Point(6, 71);
            this.debugheightt.Name = "debugheightt";
            this.debugheightt.Size = new System.Drawing.Size(41, 13);
            this.debugheightt.TabIndex = 4;
            this.debugheightt.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "label12";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 583);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainPage";
            this.Text = "Garage Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoverhang;
        private System.Windows.Forms.ComboBox CBheight;
        private System.Windows.Forms.TextBox TBlegnth;
        private System.Windows.Forms.TextBox TBwidth;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label debugheight;
        private System.Windows.Forms.Label debugheightt;
        private System.Windows.Forms.Label debuglegnth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label debugwidth;
        private System.Windows.Forms.Label label5;
    }
}


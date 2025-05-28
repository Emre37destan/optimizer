using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            OptionsHelper.ApplyTheme(this);

            pictureBox1.BackColor = OptionsHelper.CurrentOptions.Theme;
        }

        private void About_Load(object sender, EventArgs e)
        {
            t1.Interval = 50;
            t2.Interval = 50;

            t1.Start();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            string s0 = "";
            string s1 = "O";
            string s2 = "Op";
            string s3 = "Opt";
            string s4 = "Opti";
            string s5 = "Optim";
            string s6 = "Optimi";
            string s7 = "Optimiz";
            string s8 = "Optimize";
            string s9 = "Optimizer";

            switch (l1.Text)
            {
                case "":
                    l1.Text = s1;
                    break;
                case "O":
                    l1.Text = s2;
                    break;
                case "Op":
                    l1.Text = s3;
                    break;
                case "Opt":
                    l1.Text = s4;
                    break;
                case "Opti":
                    l1.Text = s5;
                    break;
                case "Optim":
                    l1.Text = s6;
                    break;
                case "Optimi":
                    l1.Text = s7;
                    break;
                case "Optimiz":
                    l1.Text = s8;
                    break;
                case "Optimize":
                    l1.Text = s9;
                    t1.Stop();
                    t2.Start();
                    break;
                case "Optimizer":
                    l1.Text = s0;
                    break;
            }
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            string s0 = "";
            string s1 = "E";
            string s2 = "Em";
            string s3 = "Emr";
            string s4 = "Emre";
            string s5 = "Emre3";
            string s6 = "Emre37";
            string s7 = "Emre37d";
            string s8 = "Emre37de";
            string s9 = "Emre37des";
            string s10 = "Emre37dest";
            string s11 = "Emre37desta";
            string s12 = "Emre37destan";

            switch (l2.Text)
            {
                case "":
                    l2.Text = s1;
                    break;
                case "E":
                    l2.Text = s2;
                    break;
                case "Em":
                    l2.Text = s3;
                    break;
                case "Emr":
                    l2.Text = s4;
                    break;
                case "Emre":
                    l2.Text = s5;
                    break;
                case "Emre3":
                    l2.Text = s6;
                    break;
                case "Emre37":
                    l2.Text = s7;
                    break;
                case "Emre37d":
                    l2.Text = s8;
                    break;
                case "Emre37de":
                    l2.Text = s9;
                    break;
                case "Emre37des":
                    l2.Text = s10;
                    break;
                case "Emre37dest":
                    l2.Text = s11;
                    break;
                case "Emre37desta":
                    l2.Text = s12;
                    t2.Stop();
                    break;
                case "Emre37destan":
                    l2.Text = s0;
                    break;
            }
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Emre37destan/optimizer");
        }
    }
}

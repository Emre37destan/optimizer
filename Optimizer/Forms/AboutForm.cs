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
            string s1 = "k";
            string s2 = "kr";
            string s3 = "kra";
            string s4 = "kral";
            string s5 = "krald";
            string s6 = "kralde";
            string s7 = "kraldev";
            string s8 = "kraldev0";
            string s9 = "kraldev0 © ";
            string s10 = "kraldev0 © ∞";

            switch (l2.Text)
            {
                case "":
                    l2.Text = s1;
                    break;
                case "k":
                    l2.Text = s2;
                    break;
                case "kr":
                    l2.Text = s3;
                    break;
                case "kra":
                    l2.Text = s4;
                    break;
                case "kral":
                    l2.Text = s5;
                    break;
                case "krald":
                    l2.Text = s6;
                    break;
                case "kralde":
                    l2.Text = s7;
                    break;
                case "kraldev":
                    l2.Text = s8;
                    break;
                case "kraldev0":
                    l2.Text = s9;
                    break;
                case "kraldev0 © ":
                    l2.Text = s10;
                    t2.Stop();
                    break;
                case "kraldev0 © ∞":
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

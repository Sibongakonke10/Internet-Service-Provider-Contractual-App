using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Service_Provider_Contractual_App
{
    public partial class Form1 : Form
    {
        decimal totalcharge;
        decimal servicecharge = 20;
        decimal airtime;
        decimal data;
        decimal talktime;
        public Form1()
        {
            InitializeComponent();
        }

        private void payuButton_CheckedChanged(object sender, EventArgs e)
        {
            if(payuButton.Checked==true)
            {
                TalkBox.Enabled = false;
                TalkBox.Text = "0";
                DataBox.Enabled = false;
                DataBox.Text = "0";
            }
        }

        private void ChatterButton_CheckedChanged(object sender, EventArgs e)
        {
            if(ChatterButton.Checked==true)
            {
                AirtimeBox.Enabled = false;
                AirtimeBox.Text = "0";
                DataBox.Enabled = false;
                DataBox.Text = "0";
            }
        }

        private void DDButton_CheckedChanged(object sender, EventArgs e)
        {
            if(DDButton.Checked==true)
            {
                TalkBox.Enabled = false;
                TalkBox.Text = "0";
                AirtimeBox.Enabled = false;
                AirtimeBox.Text = "0";
            }
        }

        private void MixMaxButton_CheckedChanged(object sender, EventArgs e)
        {
            if(MixMaxButton.Checked==true)
            {
                AirtimeBox.Enabled = false;
                AirtimeBox.Text = "0";
            }
        }

        private void TandCBox_CheckedChanged(object sender, EventArgs e)
        {
            if(TandCBox.Checked==true)
            {
                OKbutton.Enabled = true;
            }
            else
            {
                OKbutton.Enabled = false;
            }
        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure you want to clear all the contents", "Caution", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                TalkBox.Clear();
                DataBox.Clear();
                AirtimeBox.Clear();
                CellTextBox.Clear();
                maskedTextBox1.Clear();
                NameBox.Clear();

                payuButton.Checked = false;
                ChatterButton.Checked = false;
                DDButton.Checked = false;
                MixMaxButton.Checked = false;
                TandCBox.Checked = false;

                OKbutton.Enabled = false;

                TalkBox.Text = "0";
                DataBox.Text = "0";
                AirtimeBox.Text = "0";
                CellTextBox.Text = "0";

                TalkBox.Enabled = true;
                DataBox.Enabled = true;
                AirtimeBox.Enabled = true;
                CellTextBox.Enabled = true;


            }
        }

        private void EXITbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if((NameBox.Text==""))
            {
                NameBox.BackColor = Color.Red;
            }
            if(maskedTextBox1.Text == "")
            {
                maskedTextBox1.BackColor = Color.Red;
            }
            //if(CellTextBox.Text == "")
            //{
            //    CellTextBox.BackColor = Color.Red;
            //}

            try
            {
                airtime = decimal.Parse(AirtimeBox.Text);
                data = decimal.Parse(DataBox.Text) * 20;
                talktime = decimal.Parse(TalkBox.Text) * 0.5m;
            }
            catch
            {
                MessageBox.Show("Enter the correct input");
            }

            totalcharge = servicecharge + airtime + data + talktime;

            MessageBox.Show("Total charge is"+totalcharge.ToString("n2"));
            MessageBox.Show("Airtime: R" + AirtimeBox.Text + Environment.NewLine + "Data: " + DataBox.Text + " GB" + Environment.NewLine + "TalkTime: " + TalkBox.Text + " minutes");
        }
    }

}



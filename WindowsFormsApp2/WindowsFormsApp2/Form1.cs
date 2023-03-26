using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double usd, euro, usdChange = 0.02, euroChange = 0.07;

        bool startStatus = true;

        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            usd = usd * (1 + usdChange * (rnd.NextDouble() - 0.5));
            euro = euro * (1 + euroChange * (rnd.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(0, usd);
            chart1.Series[1].Points.AddXY(0, euro);
        }

        private void btPredict_Click(object sender, EventArgs e)
        {

            usd = (double)NumEuro.Value;
            euro = (double)NumUsd.Value;

            if (startStatus)
            {
                startStatus = false;
                timer1.Start();
            }
            else
            {
                startStatus = true;
                timer1.Stop();
            }

        }
    }
    }


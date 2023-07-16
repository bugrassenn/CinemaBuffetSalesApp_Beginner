using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBuffetSalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int casetotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int corn, ticket, water, tea, sum;
            corn = Convert.ToInt16(TxtCorn.Text);
            ticket = Convert.ToInt16(TxtTicket.Text);
            water = Convert.ToInt16(TxtWater.Text);
            tea = Convert.ToInt16(TxtTea.Text);

            sum = corn * 40 + water * 4 + tea * 12 + ticket * 90;
            LblTotal.Text = sum.ToString() +  " ₺ ";


            casetotal = casetotal + sum;
            LblCaseTotal.Text = casetotal.ToString() + " ₺ ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtCorn.Text = "";
            TxtTea.Text = "";
            TxtTicket.Text = "";
            TxtWater.Text = "";
            LblTotal.Text = "0 ₺";
            TxtCorn.Focus();
        }
    }
}

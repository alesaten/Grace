using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraceApp
{
    public partial class SellerForm : Form
    {
        int TimerCounter = 0;

        public SellerForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Timer_label.Text = "Сеанс: " + (++TimerCounter).ToString() + " сек.";
        }
    }
}

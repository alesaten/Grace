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
    public partial class ChiefOfficerForm : Form
    {
        int TimerCounter = 0;

        public ChiefOfficerForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Timer_label.Text = "Сеанс: " + (++TimerCounter).ToString() + " сек.";
        }
    }
}

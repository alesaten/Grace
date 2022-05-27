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
    public partial class AdministratorForm : Form
    {
        int TimerCounter = 0;
        
        public AdministratorForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            //LogIn_Form LogIn = new LogIn_Form();
            //LogIn.Show();

            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Timer_label.Text = "Сеанс: " + (++TimerCounter).ToString() + " сек.";
        }
    }
}

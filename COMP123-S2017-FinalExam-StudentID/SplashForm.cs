/*
 * Name:Kirandeeep Kaur
 * Date:17/August/2017
 * StudentID:300915966
 * Description:Created Splash Form and shows splash form first.
 * Version:0.2
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for the "tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormtimer_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pickhighestcardform = new PickHighestCardForm();
             pickhighestcardform.Show();
            this.Hide();
            SplashFormtimer.Enabled = false;

        }
    }
}

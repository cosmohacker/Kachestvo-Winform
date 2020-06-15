using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kachestvo.Forms.Database;
using Kachestvo.Sharp.Model;
using Kachestvo.Sharp.Utils;

namespace Kachestvo.Forms.Admin
{
    public partial class Admin : Form
    {

        PropTheme _prop = new PropTheme();

        public Admin()
        {
            InitializeComponent();

            getServerDelayTimeValues();

        }

        #region Server Delay Times

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            _prop.ServerDelayTime = 0;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            _prop.ServerDelayTime = 1000;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            _prop.ServerDelayTime = 1500;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _prop.ServerDelayTime = 2000;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _prop.ServerDelayTime = 2500;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _prop.ServerDelayTime = 3000;
        }
        #endregion

        #region Background Colors

        private void radioBlackBG_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.BackColor = Color.Black;
            _prop.BackgroundColor = Convert.ToString(Color.Black);
        }

        private void radioWhiteBG_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.BackColor = Color.White;
            _prop.BackgroundColor = Convert.ToString(Color.White);
        }

        private void radioGreenBG_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.BackColor = Color.Green;
            _prop.BackgroundColor = Convert.ToString(Color.Green);
        }

        private void radioYellowBG_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.BackColor = Color.Yellow;
            _prop.BackgroundColor = Convert.ToString(Color.Yellow);
        }

        private void radioOrangeBG_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.BackColor = Color.Orange;
            _prop.BackgroundColor = Convert.ToString(Color.Orange);
        }

        private void radioPinkBG_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.BackColor = Color.Pink;
            _prop.BackgroundColor = Convert.ToString(Color.Pink);
        }

        private void radioBlueBG_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.BackColor = Color.Blue;
            _prop.BackgroundColor = Convert.ToString(Color.Blue);
        }

        private void radioGrayBG_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.BackColor = Color.Gray;
            _prop.BackgroundColor = Convert.ToString(Color.Gray);
        }

        private void radioRedBG_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.BackColor = Color.Red;
            _prop.BackgroundColor = Convert.ToString(Color.Red);
        }

        #endregion

        #region Text Colors
        private void radioBlackText_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.ForeColor = Color.Black;
            _prop.TextColor = Convert.ToString(Color.Black);
        }

        private void radioWhiteText_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.ForeColor = Color.White;
            _prop.TextColor = Convert.ToString(Color.White);
        }

        private void radioGreenText_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.ForeColor = Color.Green;
            _prop.TextColor = Convert.ToString(Color.Green);
        }

        private void radioYellowText_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.ForeColor = Color.Yellow;
            _prop.TextColor = Convert.ToString(Color.Yellow);
        }

        private void radioOrangeText_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.ForeColor = Color.Orange;
            _prop.TextColor = Convert.ToString(Color.Orange);
        }

        private void radioPinkText_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.ForeColor = Color.Pink;
            _prop.TextColor = Convert.ToString(Color.Pink);
        }

        private void radioBlueText_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.ForeColor = Color.Blue;
            _prop.TextColor = Convert.ToString(Color.Blue);
        }

        private void radioGrayText_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.ForeColor = Color.Gray;
            _prop.TextColor = Convert.ToString(Color.Gray);
        }

        private void radioRedText_CheckedChanged(object sender, EventArgs e)
        {
            customizableBtn.ForeColor = Color.Red;
            _prop.TextColor = Convert.ToString(Color.Red);
        }


        #endregion

        private void getServerDelayTimeValues()
        {
            string _delay = Convert.ToString(_prop.ServerDelayTime);

            if (_prop.ServerDelayTime.ToString().Equals("1000"))
            {
                radioButton8.Checked = true;
            }

        }

        private void customizableBtn_Click(object sender, EventArgs e)
        {
            string bg =  _prop.BackgroundColor;
            string txt = _prop.TextColor;
            string ser = _prop.ServerDelayTime.ToString();

            MessageBox.Show(bg + ", " + txt + ", " + ser, "Values");
        }
    }
}

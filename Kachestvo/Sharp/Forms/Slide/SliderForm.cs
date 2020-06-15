using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kachestvo.Sharp.Model;

namespace Kachestvo.Forms.Slide
{
    public partial class SliderForm : Form
    {
        PropTheme _values = new PropTheme();

        public SliderForm()
        {
            InitializeComponent();
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {

        }
    }
}

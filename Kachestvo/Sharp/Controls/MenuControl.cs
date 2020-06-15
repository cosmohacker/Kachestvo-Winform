using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kachestvo.Sharp.Utils;
using Kachestvo.Forms.Admin;
using Kachestvo.Forms.Slide;
using Kachestvo.Forms.Database;

namespace Kachestvo.Sharp.Controls
{
    public partial class MenuControl : UserControl
    {
        FormIntents _context = new FormIntents();
        private Form currentForm = null;

        public MenuControl()
        {
            InitializeComponent();
            getChildView(new SliderForm());
        }

        private void defaultVisibility()
        {

            if (databasePanel.Visible)
            {
                menuPanel.Visible = false;
            }

            if (menuPanel.Visible)
            {
                databasePanel.Visible = false;
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            getChildView(new Admin());
        }

        private void btnPresentation_Click(object sender, EventArgs e)
        {
            getChildView(new SliderForm());
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            getChildView(new DatabaseTest());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            databasePanel.Visible = false;
            menuPanel.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            databasePanel.Visible = true;
        }

        private void getChildView(Form fragment)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = fragment;
            fragment.TopLevel = false;
            fragment.FormBorderStyle = FormBorderStyle.None;
            fragment.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(fragment);
            panelChildForm.Tag = fragment;
            fragment.BringToFront();
            fragment.Show();
        }
    }
}

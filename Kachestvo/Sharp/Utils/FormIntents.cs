using Kachestvo.Forms.Admin;
using Kachestvo.Forms.Database;
using Kachestvo.Forms.Slide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kachestvo.Sharp.Utils
{
    public class FormIntents : ApplicationContext
    {
        public void goToAdmin()
        {
            Admin _admin = new Admin();
            _admin.Show();
        }

        public void goToDatabase()
        {
            DatabaseTest _database = new DatabaseTest();
            _database.Show();
        }

        public void goToPresentation()
        {
            SliderForm _presentation = new SliderForm();
            _presentation.Show();
        }
    }
}

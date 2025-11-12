using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMe_
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int nDay)
        {
            lbDays.Text = nDay + "";
            ClearTime();
            ClearIdentifier();
        }
        public void SetTime(string time)
        {
            lblTime.Text = time;
            lblTime.Visible = true;
        }

        // --- ADD THIS NEW METHOD ---
        public void ClearTime()
        {
            lblTime.Text = "";
            lblTime.Visible = false;
        }
        public void SetIdentifier(string text)
        {
            lblIdentifier.Text = text;
            lblIdentifier.Visible = true;
        }

        public void ClearIdentifier()
        {
            lblIdentifier.Text = "";
            lblIdentifier.Visible = false;
        }
    }
}

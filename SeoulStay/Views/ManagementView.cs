using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeoulStay.Views
{
    public partial class ManagementView : UserControl
    {
        private int userType;
        public ManagementView()
        {
            InitializeComponent();
        }

        public void setType(int type)
        {
            userType = type;
        }

        private void controlTab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (userType == 0)
            {
                if (e.TabPageIndex == 1)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
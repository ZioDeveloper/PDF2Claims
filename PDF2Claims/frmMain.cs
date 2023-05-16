using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF2Claims
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuHelp_Info_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmSplash))
                {
                    form.Activate();
                    return;
                }
            }
            frmSplash myfrmSplash = new frmSplash();
            myfrmSplash.Show();
            myfrmSplash.MdiParent = this;
        }

        private void cattolicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmCattolica))
                {
                    form.Activate();
                    return;
                }
            }
            frmCattolica myfrmCattolica = new frmCattolica();
            myfrmCattolica.Show();
            myfrmCattolica.MdiParent = this;
        }
    }
}

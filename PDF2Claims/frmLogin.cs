using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF2Claims
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblMessage.Text = "";
            if (Environment.MachineName.ToUpper() == "PC073")
            {
                txtUser.Text = Environment.UserName.ToUpper();
                txtPassword.Text = "vespa";
            }
            else
            {
                txtUser.Text = Environment.UserName.ToUpper();
            }

            cmdOk.Focus();
        }
        private void cmdOk_Click(object sender, EventArgs e)
        {
            string cs = Utils.GetConnectionStringByName("WiseDB");
            cs += "User ID=" + txtUser.Text + ";Password=" + txtPassword.Text;

            SqlConnection cn = new SqlConnection(cs);
            try
            {
                cn.Open();
                Utils.AppUser = txtUser.Text;
                Utils.AppPassword = txtPassword.Text;
                lblMessage.Text = "";
                this.Hide();
                // Una volta autenticato, apro il form
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmMain))
                    {
                        form.Activate();
                        return;
                    }
                }

                frmMain myfrmMain = new frmMain();
                myfrmMain.Show();



            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = ex.Message;
                //MessageBox.Show(ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }

        private void cmdEsci_Click(object sender, EventArgs e)
        {
            // Termino applicazione
            Application.Exit();
        }
    }
}

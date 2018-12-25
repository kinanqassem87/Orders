using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Columbus_Order.BL
{
    public partial class FRM_SignIN : Form
    {
        string stateEnter = "";
        public FRM_SignIN()
        {
            InitializeComponent();
        }
        private void btnSignin_Click_1(object sender, EventArgs e)
        {
            DataTable dt = Orders.sp_SelectAllUser();
            if (txtUserName.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تعبئة كل الحقول");
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][1].Equals(txtUserName.Text))
                    {
                        if (dt.Rows[i][2].Equals(txtPassword.Text))
                        {
                            Close();
                            stateEnter = "1";
                            Frm_Main.FullName = dt.Rows[i][3].ToString();
                            Frm_Main.UserName = dt.Rows[i][1].ToString();
                            Frm_Main.U_Password = dt.Rows[i][2].ToString();
                            Frm_Main.u_id = dt.Rows[i][0].ToString();
                            Frm_Main.User_Type = dt.Rows[i][5].ToString();

                            if (dt.Rows[i][4].Equals("admin"))
                            {
                                Frm_Main.Per = "admin";

                            }
                            if (dt.Rows[i][4].Equals("user"))
                            {
                                Frm_Main.Per = "user";
                            }
                        }

                    }
                }
                if (!stateEnter.Equals("1"))
                {
                    MessageBox.Show("اسم المستخدم أو كلمة السر غير صحيحة");
                    txtUserName.Text = txtPassword.Text = "";
                }

            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

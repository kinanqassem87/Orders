using Columbus_Order.PL;
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
    public partial class Frm_Main : Form
    {
        public static string FullName = "";
        public static string UserName = "";
        public static string U_Password = "";
        public static string u_id = "";
        public static string Per = "";
        public static string User_Type = "";
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SignIN a = new FRM_SignIN();
            a.ShowDialog();
        }

        private void Frm_Main_Activated(object sender, EventArgs e)
        {
            if (Per.Equals("admin"))
            {
                تسجيلالخروجToolStripMenuItem.Enabled = عرضالطلبياتToolStripMenuItem.Enabled = إدارةالطلبياتToolStripMenuItem.Enabled = true;
                تسجيلالدخولToolStripMenuItem.Enabled = false;
            }
            if (Per.Equals("user"))
            {

                تسجيلالخروجToolStripMenuItem.Enabled = عرضالطلبياتToolStripMenuItem.Enabled = true;
                تسجيلالدخولToolStripMenuItem.Enabled = false;
            }
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Per = "out";
            تسجيلالخروجToolStripMenuItem.Enabled = عرضالطلبياتToolStripMenuItem.Enabled = إدارةالطلبياتToolStripMenuItem.Enabled = false;
            تسجيلالدخولToolStripMenuItem.Enabled = true;
            FRM_SignIN s = new FRM_SignIN();
            s.ShowDialog();
        }

        private void إدخالطلبيةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NewOrder frm = new Frm_NewOrder();
            frm.ShowDialog();
        }

        private void عرضالطلبياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderView frm = new Frm_OrderView();
            frm.ShowDialog();
        }

        private void جدولالارشيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderArchive frm = new Frm_OrderArchive("Archive");
            frm.ShowDialog();
        }

        private void إدارةالطلبياتالحاليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderArchive frm = new Frm_OrderArchive("View");
            frm.ShowDialog();
        }
    }
}

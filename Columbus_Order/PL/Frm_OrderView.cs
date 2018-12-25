using Columbus_Order.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Columbus_Order.PL
{
    public partial class Frm_OrderView : Form
    {
        private Timer timer1;
        int orderId;

        public Frm_OrderView()
        {
            InitializeComponent();
            display();
           // InitTimer();
        }

        void display()
        {
            try
            {

                dgvOrderView.DataSource = Orders.SelectOrderView();
                dgvOrderView.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvOrderView.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch { MessageBox.Show("لم يتم تحميل الداتا من السيرفر"); }
        }

        private void dgvOrderView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow Myrow in dgvOrderView.Rows)
                {

                    if (DateTime.Parse(Myrow.Cells[6].Value.ToString()) < DateTime.Now.AddDays(7) || Myrow.Cells[5].Value.ToString().Equals("مستعجلة"))
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (DateTime.Parse(Myrow.Cells[6].Value.ToString()) >= DateTime.Now.AddDays(7) && DateTime.Parse(Myrow.Cells[6].Value.ToString()) < DateTime.Now.AddDays(30))
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (DateTime.Parse(Myrow.Cells[6].Value.ToString()) >= DateTime.Now.AddDays(30))
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.YellowGreen;
                    }
                }
            }
            catch { MessageBox.Show("حدث خطأ عند الاتصال بقاعدة البيانات"); }
        }

        
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            display();
        }

        private void dgvOrderView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                orderId = int.Parse(dgvOrderView.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
            //Add Permission of user to send to  Frm_ImgOrder as third variable

            if (Frm_Main.Per != "admin")
                {
                    Frm_ImgOrder frm = new Frm_ImgOrder(orderId, "Report", Frm_Main.User_Type);
                    frm.ShowDialog();
                }
                else
                {

                    if (MessageBox.Show("1-   عرض الطلبية اضغط نعم \n\n  2-   ترحيل الطلبية اضغط لا", "ما هو نوع الاجراء الذي تريد :", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        if (Frm_Main.User_Type == "no") { MessageBox.Show("ليس لديك سماحية للقيام بهذا الاجراء"); }
                        else
                        {
                            Frm_ImgOrder frm = new Frm_ImgOrder(orderId, "Report", Frm_Main.User_Type);
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        if (Frm_Main.User_Type == "all" && Frm_Main.Per == "admin")
                        {
                            if (MessageBox.Show("هل تريد بالتأكيد ترحيل هذه الطلبية؟", "ترحيل طلبية", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                try
                                {
                                    int i = Orders.updateDoneOrder(orderId);
                                    MessageBox.Show("تمت عملية الترحيل بنجاح ");
                                    dgvOrderView.DataSource = Orders.SelectOrderView();
                                    dgvOrderView.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                                    dgvOrderView.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

                                }
                                catch { MessageBox.Show("لا يمكن الوصول الى قاعدة البيانات"); }
                            }
                        }
                        else { MessageBox.Show("ليس لديك السماحية للقيام بهذا الاجراء"); }

                    }
                }
            }

        private void dgvOrderView_Click(object sender, EventArgs e)
        {
            try
            {
                orderId = int.Parse(dgvOrderView.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
        }

        private void dgvOrderView_MouseClick(object sender, MouseEventArgs e)
        {
            if(Frm_Main.User_Type == "all") {
                if (e.Button == MouseButtons.Right)
                {
                    Frm_QuteView frm = new Frm_QuteView(orderId);
                    frm.ShowDialog();
                }
                else { }
            }
        }
    }
}

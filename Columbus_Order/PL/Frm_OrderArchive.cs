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
using System.Data;

namespace Columbus_Order.PL
{
    public partial class Frm_OrderArchive : Form
    {
        string state = ""; 
        public Frm_OrderArchive(string tableOrder)
        {
            InitializeComponent();
            try
            {
                if (tableOrder == "Archive") { displayArchive(); state = tableOrder; }
                else { displayView(); state = tableOrder; }
            }
            catch { MessageBox.Show("لا يمكن الاتصال بالسيرفر"); }
        }
        void displayArchive()
        {
            dgvOrder.DataSource = Orders.SelectOrderArchive();
            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            
        }
        void displayView()
        {
            dgvOrder.DataSource = Orders.SelectOrderView();
            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.Text = "إدارة الطلبيات الحالية";
            this.gboxOrder.Text = "الطلبيات الحالية";
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvOrder.CurrentRow.Cells[0].Value.ToString();
                dtpCreater.Value =DateTime.Parse(dgvOrder.CurrentRow.Cells[1].Value.ToString());
                txtClient.Text = dgvOrder.CurrentRow.Cells[2].Value.ToString();
                txtDesc.Text = dgvOrder.CurrentRow.Cells[3].Value.ToString();
                txtFollwo.Text = dgvOrder.CurrentRow.Cells[4].Value.ToString();
                if (dgvOrder.CurrentRow.Cells[5].Value.ToString() != "") { chbState.Checked = true; }
                else { chbState.Checked = false; }
                dtpDeadLine.Value = DateTime.Parse(dgvOrder.CurrentRow.Cells[6].Value.ToString());
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
              if (state == "Archive")
               {
                   dgvOrder.DataSource = Orders.SearchOrderArchive(txtSearch.Text);
                   dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                   dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
               }
               else
               {
                   dgvOrder.DataSource = Orders.SearchOrderView(txtSearch.Text);
                   dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                   dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
               }
           }

        private void btnViewImg_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("")) { MessageBox.Show("الرجاء اختيار طلبية محددة"); }
            else
            {
                try
                {
                    Frm_ImgOrder a = new Frm_ImgOrder(int.Parse(txtID.Text), "Management", "all");
                    a.ShowDialog();
                }
                catch (Exception) { }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Equals("")||txtClient.Text.Equals("")||txtDesc.Text.Equals("")||txtFollwo.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء اختيار طلبية و ملىء الحقول المطلوبة");
                }
                else
                {
                    if (MessageBox.Show("هل تريد بالتأكيد تعديل هذه الطلبية", "تعديل طلبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string s = "";
                        if (chbState.Checked == true) { s = "مستعجلة"; }
                        int i = Orders.UpdateOrder(int.Parse(txtID.Text),dtpCreater.Value, txtClient.Text, txtDesc.Text, txtFollwo.Text, dtpDeadLine.Value,s);
                        txtClient.Text = txtDesc.Text = txtFollwo.Text = txtID.Text = txtSearch.Text = "";
                        chbState.Checked = false;
                        MessageBox.Show("تمت عملية التعديل بنجاح");
                        if (state == "Archive")
                        {
                            dgvOrder.DataSource = Orders.SearchOrderArchive(txtSearch.Text);
                            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                        else
                        {
                            dgvOrder.DataSource = Orders.SearchOrderView(txtSearch.Text);
                            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عملية التعديل");
                        txtClient.Text = txtDesc.Text = txtFollwo.Text = txtID.Text = txtSearch.Text = "";
                        chbState.Checked = false;

                    }
                }
            }
            catch (Exception) { MessageBox.Show("حدث خطأ عند الاتصال بقاعدة البيانات"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء اختيار طلبية محدد");
                }
                else
                {
                    if (MessageBox.Show("هل تريد بالتأكيد حذف هذه الطلبية", "حذف طلبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //  int DelImgWith = ClassDocument.DeleteImgWithDelDoc(int.Parse(txtID.Text));
                        //  int i = ClassDocument.DeleteDoc(int.Parse(txtID.Text));

                        int i = Orders.deleteImgOrder(int.Parse(txtID.Text));
                        int ii = Orders.deleteOrder(int.Parse(txtID.Text));

                        txtClient.Text = txtDesc.Text = txtFollwo.Text = txtID.Text = txtSearch.Text = "";
                        MessageBox.Show("تمت عملية الحذف بنجاح");
                        if (state == "Archive")
                        {
                            dgvOrder.DataSource = Orders.SearchOrderArchive(txtSearch.Text);
                            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                        else
                        {
                            dgvOrder.DataSource = Orders.SearchOrderView(txtSearch.Text);
                            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                    }
                    else {
                        MessageBox.Show("تم الغاء عملية الحذف");
                        txtClient.Text = txtDesc.Text = txtFollwo.Text = txtID.Text = txtSearch.Text = "";
                        chbState.Checked = false;
                    }
                }
            }
            catch (Exception) { MessageBox.Show("حدث خطأ عند الاتصال بقاعدة البيانات"); }
        }
    }
    }

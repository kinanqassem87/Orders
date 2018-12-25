using Columbus_Order.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Columbus_Order.PL
{
    public partial class Frm_QuteView : Form
    {
        DataTable dt = new DataTable();
        public Frm_QuteView(int Id)
        {
            InitializeComponent();
            try
            {
                dt = Orders.selectImgForOneDocOrders(Id, "اسعار");
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picQuteImg.Image = Image.FromStream(ms);
            }
            catch { }
        }
    }
}

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
    public partial class Frm_ImgZoom : Form
    {
        
        public Frm_ImgZoom(Image imgZ)
        {
            
            InitializeComponent();
            try
            {
                PicZoom.Image = imgZ;
            }
            catch { }
        }
    }
}

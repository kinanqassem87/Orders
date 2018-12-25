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
    public partial class Frm_NewOrder : Form
    {
        
        int NumOfImage = 0;
        List<byte[]> images = new List<byte[]>();

        int NumOfImageQute = 0;
        List<byte[]> imagesQute = new List<byte[]>();

        public Frm_NewOrder()
        {
            InitializeComponent();
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            try
            {
                
                PictureBox img = new PictureBox();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                // ofd.Multiselect = true;
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string[] files = ofd.FileNames;
                    foreach (string fileName in files)
                    {
                        img.Image = Image.FromFile(ofd.FileName);

                        MemoryStream ms = new MemoryStream();
                        img.Image.Save(ms, img.Image.RawFormat);
                        byte[] arr = ms.ToArray();
                        images.Add(arr);

                        NumOfImage++;
                    }
                }
                lbNumIMG.Text = NumOfImage.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            lbNumIMG.Text = "0";
            NumOfImage = 0;
            images.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClientName.Text.Equals("") || txtDesc.Text.Equals("") || txtFollower.Text.Equals("") || NumOfImage == 0 || NumOfImageQute == 0 )
                {
                    MessageBox.Show("الرجاء ملئ الحقول الضرورية وكذلك تحميل صور الطلبية");
                }
                else
                {
                    
                    string Order_State = "";
                    if (chbState.Checked == true) { Order_State = "مستعجلة"; }
                    int addDoc = Orders.InsertOrder(dtpCreater.Value, txtClientName.Text, txtDesc.Text, txtFollower.Text, dtpDeadLine.Value, Order_State);
                    DataTable LastOne = Orders.lastOrderId();
                    if (NumOfImage > 0)
                    {
                        for (int i = 0; i < images.Count; i++)
                        {
                            int AddImg = Orders.InsertImg(images[i], int.Parse(LastOne.Rows[0][0].ToString()),"طلبية");
                        }
                    }


                    if (NumOfImageQute > 0)
                    {
                        for (int i = 0; i < imagesQute.Count; i++)
                        {
                            int AddImg = Orders.InsertImg(imagesQute[i], int.Parse(LastOne.Rows[0][0].ToString()), "اسعار");
                        }
                    }


                    txtClientName.Text = txtDesc.Text = txtFollower.Text = "";
                    chbState.Checked = false;
                    lbNumIMG.Text = "0";
                    lbNumQuteImg.Text = "0";
                    NumOfImage = 0;
                    NumOfImageQute = 0;
                    images.Clear();
                    imagesQute.Clear();
                    MessageBox.Show("تمت عملية الحفظ بنجاح");
                }
            }
            catch { MessageBox.Show("حدث خطأ !! العملية لم تحفظ. "); }
        }

        private void btnChoosQutemg_Click(object sender, EventArgs e)
        {
            try
            {

                PictureBox img = new PictureBox();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                // ofd.Multiselect = true;
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string[] files = ofd.FileNames;
                    foreach (string fileName in files)
                    {
                        img.Image = Image.FromFile(ofd.FileName);

                        MemoryStream ms = new MemoryStream();
                        img.Image.Save(ms, img.Image.RawFormat);
                        byte[] arr = ms.ToArray();
                        imagesQute.Add(arr);

                        NumOfImageQute++;
                    }
                }
                lbNumQuteImg.Text = NumOfImageQute.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnUndoQute_Click(object sender, EventArgs e)
        {
            lbNumQuteImg.Text = "0";
            NumOfImageQute = 0;
            imagesQute.Clear();
        }
    }
}

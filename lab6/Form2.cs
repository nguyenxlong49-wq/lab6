using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class frmXuat : Form
    {
        public int SoDong { get; set; }
        public int SoCot { get; set; }

        //Field 
        int h = 35, margin = 5;
        public frmXuat(int dong = 1, int cot = 1)
        {
            InitializeComponent();
            this.SoDong = dong;
            this.SoCot = cot;
            Button btn = null;
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    btn = new Button();
                    btn.Width = h; btn.Height = h;


                    btn.Text = (i * SoCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;
                    //gắn sự kiện cho button 
                    btn.Click += btn_Click;
                    btn.MouseHover += HoChuotLenButton;
                    btn.Tag = string.Format("Dòng {0} cột {1}", i, j);
                    this.Controls.Add(btn);
                }
            }
            this.ClientSize = new Size(SoCot * (h + margin + 1), SoDong * (h + margin +
1));
        }
        private void HoChuotLenButton(object sender, EventArgs e)
        {
            this.Text = (sender as Button).Tag.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }

        private void frmXuat_Load(object sender, EventArgs e)
        {

        }
    }
}

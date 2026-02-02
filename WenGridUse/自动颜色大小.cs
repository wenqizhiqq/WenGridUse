using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WenGridUse
{
    public partial class 自动颜色大小 : Form
    {
        public 自动颜色大小()
        {
            InitializeComponent();
        }

        private void 自动颜色大小_Load(object sender, EventArgs e)
        {

            new WenGrid.resize_all_controls().InitControlLayout(this);

            new WenGrid.WinFormAutoLayout().InitControlLayout(this);
        }
    }
}

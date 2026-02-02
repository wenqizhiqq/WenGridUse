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
using WenGrid;

namespace WenGridUse
{
    public partial class 自动生成界面 : Form
    {
        public 自动生成界面()
        {
            InitializeComponent();
        }

        private AxisInfo2 _cfg = new AxisInfo2();
        private string _csv = Path.Combine(Application.StartupPath, "Config.csv");
        private void 自动生成界面_Load(object sender, EventArgs e)
        { 
            autoFieldPanel1.BindStaticList(_cfg, _csv);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //_cfg.CardNo++;
            _cfg.bOpen = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cfg.bOpen = false;
        }
    }

    [Serializable]
    /// <summary>
    /// /////轴参数 
    /// </summary> 
    public class AxisInfo2
    {
        [DisplayName("卡号")]
        public int CardNo { get; set; }

        [DisplayName("轴号")]
        public int AxisNo { get; set; }

        //[DisplayName("序号")]
        //public int Index { get; set; }

        [DisplayName("轴-名称   ")]
        public string AxisName { get; set; }

        [DisplayName("回原模式")]
        public string ZeroReturnMode { get; set; }

        [DisplayName("脉冲当量")]
        public double PulseEquivalent { get; set; }

        [DisplayName("速度")]
        public double Speed { get; set; }

        [DisplayName("加速度")]
        public double Acceleration { get; set; }

        [DisplayName("减速度")]
        public double Deceleration { get; set; }

        [DisplayName("位置")]
        public double Pos { get; set; } = 0;

        [DisplayName("极限")]
        public string Limit { get; set; } = "原点";//正极限，负极限，原点

        [DisplayName("使能")]
        public string Enable { get; set; } = "开";//开，关
        [DisplayName("开启")]
        public bool bOpen { get; set; }
    }
}

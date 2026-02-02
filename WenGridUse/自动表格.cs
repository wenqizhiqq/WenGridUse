using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WenGrid;

namespace WenGridUse
{
    public partial class 自动表格 : Form
    {
        public 自动表格()
        {
            InitializeComponent();
        }

        private void 自动表格_Load(object sender, EventArgs e)
        {
            dgvAXis.BindStaticList(axisList, "存档\\轴.csv");

            string[][] strings = new string[][] {
                  new string []{  "0", "1", "2", "3", },
                  new string []{ "0", "1", "2", "3",},
                  new string []{  "(自定义命名)", },
                  new string[] { "0(不回原)", "1+(正方向一次回原)", "1-(负方向一次回原)","2+(正方向二次回原)","2-(负方向二次回原)" },
                  new string[] { "2(2个脉冲=1毫米)" },
                  new string[] { "100(100个毫米每秒)" },
                  new string[] { "3" },
                  new string[] { "3" },
                  new string[] { "(不需要填)" },
                  new string[] { "(不需要填)" },
                  new string[] { "(不需要填)" },
                  new string[] { "(不需要填)" },
                  new string[] { "(不需要填)" },
            };
        }
        public static List<AxisInfo> axisList = new List<AxisInfo>();
    }
    [Serializable]
    /// <summary>
    /// /////轴参数
    /// </summary> 
    public class AxisInfo
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

        [DisplayName("状态")]
        public string Moving { get; set; } = "-";//运动中 
    }
}

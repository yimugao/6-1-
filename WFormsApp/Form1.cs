using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormsApp
{
    public partial class Form1 : Form
    {

        private selector objSelector = new selector();//创建选号器对象

        private PrintDocument printDoc = new PrintDocument();//创建打印对象

        public Form1()
        {
            InitializeComponent();
            //禁用相关的按钮
            this.btnstart.Enabled = false;
            this.btnprint.Enabled = false;
            this.btnclear.Enabled = false;
            this.btndel.Enabled = false;

            //关联打印对象的事件
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.LotteryPrintPage);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Maximized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region  拖动窗体的实现

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }


        #endregion
        //定时生成随机号码
        private void Randomtimer_Tick(object sender, EventArgs e)
        {
            string[] numList = objSelector.CreateNum();//生成随机号
            //显示随机号码
            this.lbnum1.Text = numList[0];
            this.lbnum2.Text = numList[1];
            this.lbnum3.Text = numList[2];
            this.lbnum4.Text = numList[3];
            this.lbnum5.Text = numList[4];
            this.lbnum6.Text = numList[5];
            this.lbnum7.Text = numList[6];
        }
        //开始随机选号
        private void btnselect_Click(object sender, EventArgs e)
        {
            this.Randomtimer.Start();

            this.btnselect.Enabled = false;
            this.btnstart.Enabled = true;
        }
        //确认选号
        private void btnstart_Click(object sender, EventArgs e)
        {
            this.Randomtimer.Stop();//定时器停止
            string[] selectedNum ={
                                 this.lbnum1.Text ,
                                 this.lbnum2.Text ,
                                 this.lbnum3.Text ,
                                 this.lbnum4.Text ,
                                 this.lbnum5.Text ,
                                 this.lbnum6.Text ,
                                 this.lbnum7.Text ,
                                 };//如果使用暂存号码，可以直接读取
            objSelector.SelectedNums.Add(selectedNum);//保存当前选中的号码

            ShowSeletedNums();//显示选中的号码
        }
        private void ShowSeletedNums()
        {
            this.lBnumberlist.Items.Clear();
            this.lBnumberlist.Items.AddRange(this.objSelector.GetPrintedNums().ToArray());

            //按钮启用
            this.btnselect.Enabled = true;
            this.btnprint.Enabled = this.btnclear.Enabled = this.btndel.Enabled = true;
        }
        //手写号码
        private void btnwrite_Click(object sender, EventArgs e)
        {
            //首先验证每个文本框必须是单个数字...

            string[] selectedNum ={
                                 this.tb1 .Text ,
                                 this.tb2 .Text ,
                                 this.tb3 .Text ,
                                 this.tb4 .Text ,
                                 this.tb5 .Text ,
                                 this.tb6 .Text ,
                                 this.tb7 .Text ,
                                 };//如果使用暂存号码，可以直接读取
            objSelector.SelectedNums.Add(selectedNum);//保存当前选中的号码
            ShowSeletedNums();//显示选中的号码
        }

        private void btngroupselect_Click(object sender, EventArgs e)
        {
            this.Randomtimer.Stop();//定时器停止（有可能在随机选号状态）
            //验证...
            this.objSelector.CreatGroupNums(Convert.ToInt32(this.textBox1.Text.Trim()));
            ShowSeletedNums();//显示选中的号码
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (this.lBnumberlist.Items.Count == 0 || this.lBnumberlist.SelectedItem == null) return;

            int index = this.lBnumberlist.SelectedIndex;//获取选中的索引
            objSelector.SelectedNums.RemoveAt(index);
            if (objSelector.SelectedNums.Count == 0)//如果一个一个全部删掉
            {
                this.btnclear.Enabled = false;
                this.btndel.Enabled = false;
                this.btnprint.Enabled = false;
            }
            ShowSeletedNums();//显示选中的号码
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.lBnumberlist.Items.Clear(); //从界面中清除显示
            this.objSelector.SelectedNums.Clear();//从选号器对象集合中清空

            //号码复位
            this.lbnum1.Text = "0";
            this.lbnum2.Text = "0";
            this.lbnum3.Text = "0";
            this.lbnum4.Text = "0";
            this.lbnum5.Text = "0";
            this.lbnum6.Text = "0";
            this.lbnum7.Text = "0";

            this.tb1.Text = "0";
            this.tb2.Text = "0";
            this.tb3.Text = "0";
            this.tb4.Text = "0";
            this.tb5.Text = "0";
            this.tb6.Text = "0";
            this.tb7.Text = "0";

            //禁用相关的按钮
            this.btnstart.Enabled = false;
            this.btnprint.Enabled = false;
            this.btnstart.Enabled = false;
            this.btnclear.Enabled = false;
            this.btndel.Enabled = false;
        }
        //打印
        private void btnprint_Click(object sender, EventArgs e)
        {
            this.printDoc.Print();
        }
        //具体打印实现过程
        private void LotteryPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string serialNum = DateTime.Now.ToString("yyyyMMddHHmmssms");//流水号（生成条码使用）
            this.objSelector.PrintLottery(e, serialNum, objSelector.GetPrintedNums());//调用前面编写的打印方法

            objSelector.Save(serialNum);//同时保存所选号码

            btnclear_Click(null, null);//打印完毕后清空
        }
    }
}

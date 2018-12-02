using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace DispenserCOMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialzeCOMcombox();
            

        }
        //串口操作
        private void InitialzeCOMcombox()
        {
            //读取当前存在的所有串口
            string[] ArrayComPortsNames = SerialPort.GetPortNames();
            //handle no port
            if (ArrayComPortsNames.Length==0)
            {
                statuslabel.Text = "没有发现串口";
            }
            else
            {
                //列出所有存在的串口
                Array.Sort(ArrayComPortsNames);
                //将存在的串口添加到下拉列表
                for(int i=0;i<ArrayComPortsNames.Length;i++)
                {
                    comboBox1.Items.Add(ArrayComPortsNames[i]);   
                }
                comboBox1.Text = ArrayComPortsNames[0];
            }

        }

        private void CommCheck_Click(object sender, EventArgs e)
        {
            String sendText = sendtbx.Text;
            bool flag = false;
            if (sendText==null)
            {
                return;
            }

        }
    }
}

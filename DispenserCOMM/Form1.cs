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
    public interface IView
    {
        void SetController(IControler controller);
        //open serial port event
        void OpenComEvent(Object sender, SerialPortEventArgs e);
        //close serial port event
        void CloseComEvent(Object sender, SerialPortEventArgs e);
        //serial port receive data event
        void ComReceiveDataEvent(Object sender, SerialPortEventArgs e);
    }



    public partial class Form1 : Form
    {
        private IControler controller;
        private int sendByteCount = 0;
        private int receiveByteCount = 0;
        public Form1()
        {
            InitializeComponent();
            InitialzeCOMcombox();
           
            

        }

        public void SetController(IControler controller)
        {
            this.controller = controller;
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
        /// <summary>
        /// Send Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommCheck_Click(object sender, EventArgs e)
        {
            String sendText = sendtbx.Text;
            bool flag = false;
            if (sendText==null)
            {
                return;
            }

            //
            sendtbx.SelectionStart = sendtbx.TextLength;                                              
        }
        /// <summary>
        /// open or close serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openCloseSpbtn_Click(object sender, EventArgs e)
        {
            if(openCloseSpbtn.Text=="打开串口")
            {
                controller.OpenSerialPort(comboBox1.Text,"9600","8","1","0","None");
                sendtbx.Text = comboBox1.Text;
            }
            else
            {
                controller.CloseSerialPort();
            }
        }

        private void clearSendData_Click(object sender, EventArgs e)
        {
            sendtbx.Text = "";

        }

        private void SendReceiveData_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

        }
    }
}

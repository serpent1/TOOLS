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


namespace SPTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialzeCOMcombox();
            //initlization
            SerialPortHandler();

            ReceiveData();
           


        }


        private void ReceiveData()
        {
            SerialPort mySerialPort = new SerialPort(comboBox1.Text);
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private  void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            textBox1.AppendText(indata);
            
            
        }

        //串口操作
        private void InitialzeCOMcombox()
        {
            //读取当前存在的所有串口
            string[] ArrayComPortsNames = SerialPort.GetPortNames();
            //handle no port
            if (ArrayComPortsNames.Length == 0)
            {
                //statuslabel.Text = "没有发现串口";
            }
            else
            {
                //列出所有存在的串口
                Array.Sort(ArrayComPortsNames);
                //将存在的串口添加到下拉列表
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    comboBox1.Items.Add(ArrayComPortsNames[i]);
                }
                comboBox1.Text = ArrayComPortsNames[0];
            }
        }            
        private void button1_Click(object sender, EventArgs e)
        {           
            using (var sp = new SerialPort(comboBox1.Text, 9600, Parity.None, 8, StopBits.One))
            {
                //sp.Open();
                //第一组地址
                byte[] byte1tosend = { 0x50, 0x20, 0xfa };
                sp.Write(byte1tosend, 0, byte1tosend.Length); 
                
                
                //第二组地址
                byte[] byte2tosend = { 0x51, 0x20, 0xfa };
                sp.Write(byte2tosend, 0, byte2tosend.Length);


                // 第三组地址
                byte[] byte3tosend = { 0x52, 0x20, 0xfa };
                sp.Write(byte3tosend, 0, byte3tosend.Length);


                // 第四组地址
                byte[] byte4tosend = { 0x53, 0x20, 0xfa };
                sp.Write(byte4tosend, 0, byte4tosend.Length);


                // 第五组地址
                byte[] byte5tosend = { 0x54, 0x20, 0xfa };
                sp.Write(byte5tosend, 0, byte5tosend.Length);


                // 第六组地址
                byte[] byte6tosend = { 0x55, 0x20, 0xfa };
                sp.Write(byte6tosend, 0, byte6tosend.Length);



                // 第七组地址
                byte[] byte7tosend = { 0x56, 0x20, 0xfa };
                sp.Write(byte7tosend, 0, byte7tosend.Length);



                // 第八组地址
                byte[] byte8tosend = { 0x57, 0x20, 0xfa };
                sp.Write(byte8tosend, 0, byte8tosend.Length);
             

                //关闭串口
                //sp.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var sp = new SerialPort(comboBox1.Text, 9600, Parity.None, 8, StopBits.One))
            {
                sp.Open();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(var sp = new SerialPort(comboBox1.Text, 9600, Parity.None, 8, StopBits.One))
            {
                sp.Close();
            }

        }

        private void SerialPortHandler()
        {

            var _serialPort = new SerialPort();
            _serialPort.PortName = comboBox1.Text;
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = 0;
            _serialPort.DataBits = 8;
            _serialPort.StopBits =StopBits.One ; 
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace DispenserCOMM
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void SerialPortEventHandler(object sender, SerialPortEventArgs e); 
    
    public class SerialPortEventArgs : EventArgs
    {
        public bool isOpend = false;
        public Byte[] receivedBytes = null;
    }

    public class ComModel
    {
        private SerialPort sp = new SerialPort();
        
        public event SerialPortEventHandler comReceiveDataEvent = null;
        public event SerialPortEventHandler comOpenEvent = null;
        public event SerialPortEventHandler comCloseEvent = null;

        private Object thisLock = new object();
        
        //serial port receive data handle method
        private void DataReceived(object sender,SerialDataReceivedEventArgs e)
        {
            //get ReceiveData number
            if (sp.BytesToRead<=0)
            {
                return;
            }

            lock(thisLock)
            {
                //read serialdata length
                int len = sp.BytesToRead;
                //define the receivedata array
                Byte[] data = new byte[len];
                try
                {
                    //read serialData and write to specified array   
                    sp.Read(data, 0, len);
                }
                catch(System.Exception)
                {
                    //catch Exception
                }
                SerialPortEventArgs args = new SerialPortEventArgs();
                args.receivedBytes = data;
                if(comReceiveDataEvent!=null)
                {
                    comReceiveDataEvent.Invoke(this, args);
                }               
            }
        }
        //send data handle
        public bool Send(Byte[] bytes)
        {
            if (!sp.IsOpen)
            {
                return false;
            }
            try
            {
                sp.Write(bytes, 0, bytes.Length);
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="portname"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <param name="parity"></param>
        /// <param name="handshake"></param>
        public void Open(string portname,String baudRate,
            string dataBits,string stopBits,string parity,string handshake)
        {
            if (sp.IsOpen)
            {
                Close();   
            }
            sp.PortName = portname;
            sp.BaudRate = Convert.ToInt32(baudRate);
            sp.DataBits = Convert.ToInt16(dataBits);


            if (handshake=="None")
            {
                sp.RtsEnable = true;
                sp.DtrEnable = true;
            }

            SerialPortEventArgs args = new SerialPortEventArgs();
            try
            {
                sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);
                sp.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
                sp.Handshake = (Handshake)Enum.Parse(typeof(Handshake), handshake);
                sp.WriteTimeout = 1000;
                sp.Open();
                sp.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
                args.isOpend = true;
            }
            catch(System.Exception)
            {
                args.isOpend = false;
            }
            if(comOpenEvent!=null)
            {
                comOpenEvent.Invoke(this, args);
            }
        }
        /// <summary>
        /// 
        /// close serial port thread
        /// </summary>
        public void Close()
        {
            Thread closeThread = new Thread(new ThreadStart(CloseSpThread));
            closeThread.Start();
        }
        /// <summary>
        /// close serial port thread
        /// </summary>
        public void CloseSpThread()
        {
            SerialPortEventArgs args = new SerialPortEventArgs();
            args.isOpend = false;
            try
            {
                sp.Close();
                sp.DataReceived -= new SerialDataReceivedEventHandler(DataReceived);
            }
            catch(Exception)
            {
                args.isOpend = true;
            }
            if(comCloseEvent!=null)
            {
                comCloseEvent.Invoke(this, args);
            }
        }
        
    }
}

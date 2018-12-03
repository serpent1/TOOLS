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
        public event SerialPortEventHandler comOpenEnent = null;
        public event SerialPortEventHandler comCloseEvent = null;

        


        private Object thisLock = new object();
        
        //serial port receive data handle method
        private void DataReceived(object sender,SerialDataReceivedEventArgs e)
        {

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
    }
}

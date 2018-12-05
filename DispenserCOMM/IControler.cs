using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenserCOMM
{
    public class IControler
    {
        ComModel comModel = new ComModel();

        IView view;

        public IControler(IView view)
        {
            this.view = view;
            view.SetController(this);
            comModel.comCloseEvent += new SerialPortEventHandler(view.CloseComEvent);
            comModel.comOpenEvent += new SerialPortEventHandler(view.OpenComEvent);
            comModel.comReceiveDataEvent += new SerialPortEventHandler(view.ComReceiveDataEvent);
        }

       //hex to string converter
       /// <summary>
       /// hex to byte
       /// </summary>
       /// <param name="hex"></param>
       /// <returns></returns>
       private static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++) 
            {
                try
                {
                    raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
                catch(System.Exception)
                {
                    //Do Nothing
                }
            }
            return raw;
        }
        /// <summary>
        /// hex string to string 
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static String Hex2String(String hex)
        {
            byte[] data = FromHex(hex);
            return Encoding.Default.GetString(data);
        }
        /// <summary>
        /// String to hex strng
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String String2Hex(String str)
        {
            Byte[] data = Encoding.Default.GetBytes(str);
            return BitConverter.ToString(data);
        }
        /// <summary>
        /// hex string to bytes
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static Byte[] Hex2Byte(String hex)
        {
            return FromHex(hex);
        }
        /// <summary>
        /// byte to hex string
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static String Byte2Hex(Byte[] bytes)
        {
            return BitConverter.ToString(bytes);
        }
        /// <summary>
        /// send bytes to serial port
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SendDataToCom(Byte[] data)
        {
            return comModel.Send(data);
        }
        /// <summary>
        /// send string to serial port
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool SendDataToCom(String str)
        {
            if (str !=null&&str!="")
            {
                return comModel.Send(Encoding.Default.GetBytes(str));
            }
            return true;
        }
        /// <summary>
        /// Open serial port in comModel
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBite"></param>
        /// <param name="parity"></param>
        /// <param name="handshake"></param>
        
        public void OpenSerialPort(string portName,String baudRate,
            string dataBits,string stopBite,string parity,string handshake)
        {
            if(portName!=null&&portName!="")
            {
                comModel.Open(portName, baudRate, dataBits, stopBite, parity, handshake);
            }
        }
        /// <summary>
        /// close serial port in comModel
        /// </summary>
        public void CloseSerialPort()
        {
            comModel.Close();
        }
    }
}

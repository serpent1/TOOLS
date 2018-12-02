using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateGUID
{
    public partial class GUID : Form
    {
        public GUID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guid = Guid.NewGuid().ToString();
            string GUID = guid.ToUpper();
            textBox1.AppendText(GUID+ "\r\n");           
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            try
            {
                Clipboard.SetText(textBox1.Text);
            }
            catch(Exception ex)
            {
                System.Console.Write(ex);                         
                StringBuilder messageBuilder = new StringBuilder(200);
                messageBuilder.Append("请检查GUID生成框是否为空");                
                MessageBox.Show(messageBuilder.ToString());               
            }                  
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            textBox1.Clear();
        }
    }
}

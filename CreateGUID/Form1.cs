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
            /*  if(textBox1==null)
              {
                  StringBuilder messageBuilder = new StringBuilder(200);
                  messageBuilder.Append("To continue, please select one of the actions below:");
                  messageBuilder.Append(Environment.NewLine);
                  messageBuilder.Append(Environment.NewLine);
                  messageBuilder.Append("\t\u2022 Click Button A to do this action.");
                  messageBuilder.Append(Environment.NewLine);
                  messageBuilder.Append("\t\u2022 Click Button B to do this action.");
                  MessageBox.Show(messageBuilder.ToString());

              }
              else
              {
                  Clipboard.SetText(textBox1.Text);
              }*/
            try
            {
                Clipboard.SetText(textBox1.Text);
            }
            catch(Exception ex)
            {
                System.Console.Write(ex);
            }                  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
        }
    }
}

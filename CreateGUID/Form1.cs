using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite.CodeFirst;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CreateGUID
{

    public partial class GUID : Form
    {
        private LogWriter logger;

        public GUID()
        {
            InitializeComponent();          
            logger = new LogWriter("Logger");
            logger.LogWrite("\r\n");
            logger.LogWrite("\r\n");
            logger.LogWrite("程序启动\r\n-------------------------------------------------------------");
        }
        // public int i = 0;
        /// <summary>
        /// create a new GUID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string guid = Guid.NewGuid().ToString();
                string GUID = guid.ToUpper();
                logger.LogWrite($"生成新的GUID：{GUID}！");
                textBox1.AppendText(GUID + "\r\n");
                logger.LogWrite($"开始将GUID:{GUID}写入数据库！");
                using (var db = new MyDbContext())
                {
                    db.Notes.Add(new Note { Text = GUID,date= DateTime.Now.ToLongDateString(),time = DateTime.Now.ToLongTimeString() });                  
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }
        /// <summary>
        /// copy GUID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {  
                logger.LogWrite("复制文本框内的内容！");
                Clipboard.SetText(textBox1.Text);
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
                StringBuilder messageBuilder = new StringBuilder(200);
                messageBuilder.Append("请检查GUID生成框是否为空！");
                MessageBox.Show(messageBuilder.ToString());
            }
        }
        /// <summary>
        /// clear the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogWrite("清空文本框！");
                textBox1.Clear();
            }
            catch
            {
                logger.LogWrite("文本框已经为空！");
            }
        }
    }

    public class Datetime
    {
        public string date()
        {
            return (DateTime.Now.ToLongDateString());
        }

        public string time()
        {
            return (DateTime.Now.ToLongTimeString());
        }

    }
    /// <summary>
    /// model 
    /// </summary>
    public class Note
    {
        public long NoteId { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string Text { get; set; }      
    }
  
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyDBContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

        public DbSet<Note> Notes { get; set; }
    }

}

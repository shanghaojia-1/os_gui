using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 操作系统界面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1_PID.Text=="" || textBox_SID.Text=="" || textBox_PageID.Text=="")
            {
                MessageBox.Show("请正确输入各个参数");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateProcessForm form = new CreateProcessForm();
            form.ShowDialog();
        }
    }
}

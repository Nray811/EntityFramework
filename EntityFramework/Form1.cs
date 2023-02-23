using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e) //修改
        {
            var form = new ReviseForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e) //刪除
        {
            var form = new DeleteForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e) //查詢
        {
            var form = new SearchForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new ViewForm();
            form.Show();
        }
    }
}

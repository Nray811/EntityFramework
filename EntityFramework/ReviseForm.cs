using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFramework
{
    public partial class ReviseForm : Form
    {
        public ReviseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsModel context = new ContactsModel();
            var data = context.Table.ToList().Where(x => x.Po == int.Parse(textBox5.Text.Trim())).First();
            try
            {
                data.Name = textBox1.Text.Trim();
                data.Quantity = int.Parse(textBox2.Text);
                data.Price = int.Parse(textBox3.Text);
                data.Category = textBox4.Text.Trim();
                context.Table.AddOrUpdate(data);
                context.SaveChanges();
                MessageBox.Show("更新完成!");
                ClearTextBoxes();
            }
            catch (Exception ex)
            { MessageBox.Show($"Something Wrong {ex.ToString()}"); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

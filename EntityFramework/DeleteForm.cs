using EntityFramework.Models;
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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ContactsModel context = new ContactsModel();
            var data = context.Table.Find(int.Parse(textBox1.Text));
            try
            {
                if (data != null)
                {
                    context.Table.Remove(data);
                    context.SaveChanges();
                    MessageBox.Show($"品項: {data.Name} 刪除成功");
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("查無此Po");
                }

            }
            catch (Exception ex)
            { MessageBox.Show($"Something Wrong {ex.ToString()}"); }



        }


        private void ClearTextBoxes()
        {
            textBox1.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

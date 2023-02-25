using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ContactsModel();
            var list = context.Table.ToList();
            var data = list.Where((x) => x.Po == int.Parse((textBox1.Text.Trim())));

            try
            {
                if (data.Any())
                {
                    foreach (var d in data) { label2.Text = $"Po: {d.Po}\n品項: {d.Name}\n數量: {d.Quantity}\n價格: {d.Price}\n類別: {d.Category}";}
                    
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
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

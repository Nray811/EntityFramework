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
            foreach (var item in data)
            {
                label2.Text = ($" Po: {item.Po} \n Name: {item.Name} \n Quantity:{item.Quantity} \n Price: {item.Price} \n Category: {item.Category}");
                
            }


        }
    }
}

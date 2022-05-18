using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Деловые_дамы1
{
    public partial class AddService : Form
    {
        public DataGridView tableAdd;
        public AddService()
        {
            InitializeComponent();
        }
        Bd com = new Bd();

       public string id, title,cost,time,descript, discount, img;
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            com.command($"Insert into Service Values ('{textBox1.Text}',{textBox2.Text},{textBox3.Text},'{textBox4.Text}',{textBox5.Text},'{textBox6.Text}')");
            com.View("Select * From Service", tableAdd);
        }

        private void AddService_Load(object sender, EventArgs e)
        {
            textBox1.Text = title;
            textBox2.Text = cost;
            textBox3.Text = time;
            textBox4.Text = descript;
            textBox5.Text = discount;
            textBox6.Text = img;
           // com.command($"Update service Set Title = '{}', Cost ='' Where ID =");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

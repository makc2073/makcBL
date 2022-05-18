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
    public partial class Form1 : Form
    {
        Bd BdView = new Bd();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BdView.View("Select * From Service", dataGridView1);
        }

       
        /*int rowIndex = e.RowIndex;
        DataGridViewRow row = dataGridView1.Rows[rowIndex];
        string a = dataGridView1.Rows[0].Cells[0].Value.ToString();// row.Cells[1].Value;
        ID.Text = a;*/

        private void AddFrom_Click(object sender, EventArgs e)
        {
            AddService add = new AddService();
            add.tableAdd = dataGridView1;
            add.ShowDialog();
        }

        string id;
        string title;
        string cost;
        string time;
        string descript;
        string discount;
        string img;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];            
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();// row.Cells[1].Value;
            title = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();// row.Cells[1].Value;
            cost = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();// row.Cells[1].Value;
            time = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();// row.Cells[1].Value;
            descript = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();// row.Cells[1].Value;
            discount = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();// row.Cells[1].Value;
            img = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();// row.Cells[1].Value;
            ID.Text = id;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Bd dell = new Bd();
            dell.command($"Delete from  service where ID ={ID.Text}");
            BdView.View("Select * From Service", dataGridView1);
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            AddService add = new AddService();
            add.id = id;
            add.title = title;
            add.cost = cost;
            add.time = time;
            add.descript = descript;
            add.discount = discount;
            add.img = img;
            add.tableAdd = dataGridView1;
            add.ShowDialog();
        }
    }
}

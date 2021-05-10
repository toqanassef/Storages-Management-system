using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_project
{
    public partial class itemEdit : Form
    {
        projectEFEnt ent = new projectEFEnt();
        public itemEdit()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            var itemdata = (from it in ent.items
                            select new { it.code, it.name, it.measure_unit }).ToList();
            dataGridView1.DataSource = itemdata;
            foreach (var tbox in this.Controls.OfType<TextBox>())
            { tbox.Text = ""; }
        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value != null)
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            else
                textBox3.Text = "";

        }

        private void edit_Click(object sender, EventArgs e)
        {                      
            try
            {
                int Itemcode = int.Parse(textBox1.Text);
                item Item = (from it in ent.items
                            where it.code == Itemcode
                           select it).First();
                Item.name = textBox2.Text;
                Item.measure_unit = textBox3.Text;

                ent.SaveChanges();
                MessageBox.Show("Data updated");
                loadData();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                item it = new item();
                it.code = int.Parse(textBox1.Text);
                it.name = textBox2.Text;

                it.measure_unit = textBox3.Text;
                ent.items.Add(it);
                ent.SaveChanges();
                MessageBox.Show("Data added");
                loadData();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}

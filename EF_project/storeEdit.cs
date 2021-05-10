using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EF_project
{
    public partial class storeEdit : Form
    {
        projectEFEnt ent = new projectEFEnt();
        public storeEdit()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            var storedata = (from s in ent.stores
                            select new { s.name, s.address,s.manager }).ToList();
            dataGridView1.DataSource = storedata;
            foreach (var tbox in this.Controls.OfType<TextBox>())
            { tbox.Text = ""; }

        }


        private void done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                store st = (from s in ent.stores
                            where s.name == name
                            select s).First();
                st.name = textBox1.Text;
                st.address = textBox2.Text;
                st.manager = textBox3.Text;
                              
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
                store st = new store();
                st.name = textBox1.Text;
                st.address = textBox2.Text;
                st.manager= textBox3.Text;

                ent.stores.Add(st);
                ent.SaveChanges();
                MessageBox.Show("Data added");
                loadData();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
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

        
    }
}

﻿using System;
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
    public partial class supplyEdit : Form
    {
        projectEFEnt ent = new projectEFEnt();
        public supplyEdit()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            var supplierdata = (from s in ent.supplies
                             select new { s.id , s.name , s.telephone ,s.fax ,s.mobile , s.email ,s.web }).ToList();
            dataGridView1.DataSource = supplierdata;
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
                int id = (int) dataGridView1.CurrentRow.Cells[0].Value;
                supply st = (from s in ent.supplies
                            where s.id == id
                            select s).First();
                st.name = textBox1.Text;
                st.telephone = int.Parse(textBox2.Text);
                st.fax = int.Parse(textBox3.Text);
                st.mobile = int.Parse(textBox4.Text);
                st.email = textBox5.Text;
                st.web = textBox6.Text;

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
                supply st = new supply();
                st.name = textBox1.Text;
                st.telephone = int.Parse(textBox2.Text);
                st.fax = int.Parse(textBox3.Text);
                st.mobile = int.Parse(textBox4.Text);
                st.email = textBox5.Text;
                st.web = textBox6.Text;

                ent.supplies.Add(st);
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
            
            var tbox = this.Controls.OfType<TextBox>().ToList();
            
            for (int i=0; i<6; i++)
            {
                if (dataGridView1.CurrentRow.Cells[i+1].Value != null)
                    tbox[5-i].Text = dataGridView1.CurrentRow.Cells[i+1].Value.ToString();
                else
                    tbox[5-i].Text = "";
            }
        }
    }
}

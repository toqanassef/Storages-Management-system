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
    public partial class Form1 : Form
    {
        projectEFEnt ent = new projectEFEnt();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            storeload();
        }
        void storeload()
        {
            var storesdate = (from st in ent.stores
                       select  new {st.storeid , st.name , st.address , st.manager}).ToList();
            
            dataGridView1.DataSource = storesdate;

            int id = storesdate[0].storeid;
            var itemdata = (from it in ent.store_product
                            where it.storeid == id
                            select new { it.item.code, it.item.name, it.quantity, it.expiredate }).ToList();
            dataGridView2.DataSource = itemdata;

        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

            //var itemdata2 = (from it in ent.store_product
            //                       where it.storeid == id
            //                 group it by new {it.item.code , it.item.name } into g
            //                 select new {g.Key.name, g.Key.code , quantity = g.Sum(x => x.quantity) }).ToList();

            var itemdata = (from it in ent.store_product
                            where it.storeid == id
                            select new { it.item.code, it.item.name, it.quantity, it.expiredate }).ToList();
            dataGridView2.DataSource = itemdata;

        }

        private void store_edit_Click(object sender, EventArgs e)
        {
            storeEdit storedialog = new storeEdit();
            storedialog.ShowDialog();
            storeload();

        }
        private void edititem_Click(object sender, EventArgs e)
        {
            itemEdit itemdialog = new itemEdit();
            itemdialog.ShowDialog();
            storeload();
        }

        private void editsuppliers_Click(object sender, EventArgs e)
        {
            supplyEdit suplydialog = new supplyEdit();
            suplydialog.ShowDialog();
        }

        private void editcustomers_Click(object sender, EventArgs e)
        {
            customerEdit cusdialog = new customerEdit();
            cusdialog.ShowDialog();
        }

        private void in_resEdit_Click(object sender, EventArgs e)
        {
            inRes inresdialog = new inRes();
            inresdialog.ShowDialog();
        }

        private void out_resEdit_Click(object sender, EventArgs e)
        {
            outRes outresdialog = new outRes();
            outresdialog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = File.CreateText(@"..\..\..\store.txt");
            var storedata = (from s in ent.stores
                             select new {s.storeid, s.name, s.address, s.manager }).ToList();
            foreach (var i in storedata)
            {
                writer.WriteLine(i.ToString());
                var itemdata = (from it in ent.store_product
                                            where it.storeid == i.storeid
                                            select new { it.item.code, it.item.name, it.quantity, it.expiredate }).ToList();
                foreach(var t in itemdata)
                { writer.WriteLine(t.ToString()); }
                writer.WriteLine("");

            }
            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = File.CreateText(@"..\..\..\product.txt");

            int id = int.Parse(textBox1.Text);
            var itemdata = (from it in ent.store_product
                            where it.storeid == id
                            select new { it.item.code, it.item.name, it.quantity, it.expiredate }).ToList();
            foreach (var t in itemdata)
            { writer.WriteLine(t.ToString()); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.ParseExact(textBox2.Text,
                                     "yyyy-MM-dd",
                                      System.Globalization.CultureInfo.InvariantCulture);
            StreamWriter writer = File.CreateText(@"..\..\..\product_expired.txt");

            var itemdata = (from it in ent.store_product
                            where it.expiredate <= d
                            select new { it.item.code , it.item.name, storename = it.store.name, it.quantity, it.expiredate }).ToList();
            foreach (var t in itemdata)
            { writer.WriteLine(t.ToString()); }
        }
    }
}

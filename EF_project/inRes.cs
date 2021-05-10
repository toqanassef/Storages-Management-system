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
    public partial class inRes : Form
    {
        projectEFEnt ent = new projectEFEnt();
        public inRes()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            var data = (from s in ent.suplyResets
                        join p in ent.in_product                        
                        on s.num equals p.inresiet_num into temp
                        from p in temp.DefaultIfEmpty()
                        select new
                        {
                            num = s.num,
                            s.date,
                            supply_name = s.supply.name,
                            store_name = s.store.name,
                            product = p != null ? p.item.name : default ,
                            quantity = p != null ? p.quantity : default ,
                            production_date = p != null ? p.production_date : default,
                            validity = p != null ? p.validity : default ,
                            expired_date = p != null ? p.expired_date : default
                        }).OrderBy(s => s.num).ToList();
            dataGridView1.DataSource = data;
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
                int num = (int)dataGridView1.CurrentRow.Cells[0].Value;
                in_product resiet =( from s in ent.in_product
                                     where  s.inresiet_num == num 
                                     select s).First();
                int oldquan = (int)resiet.quantity;
                resiet.quantity = int.Parse(textBox2.Text);

                //DateTime d = resiet.production_date;
                //if (textBox3.Text != null)
                //{
                //    d = DateTime.ParseExact(textBox3.Text,
                //                    "yyyy-MM-dd",
                //                     System.Globalization.CultureInfo.InvariantCulture);
                //    resiet.production_date = d;
                //}
                //resiet.validity = int.Parse(textBox4.Text);
                //resiet.expired_date = d.AddMonths(int.Parse(textBox4.Text));
                   
                //// change product in store
                if (oldquan != resiet.quantity)
                {
                    int dif = (int)resiet.quantity - oldquan;
                    var iteem = (from i in ent.store_product
                                 where (i.itemcode == resiet.item_code &&
                                        i.storeid == resiet.suplyReset.store_id &&
                                        i.expiredate == resiet.expired_date)
                                 select i).FirstOrDefault();
                    iteem.quantity = iteem.quantity + dif;

                }


                ent.SaveChanges();
                MessageBox.Show("Data updated");
                loadData();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                suplyReset st = new suplyReset();
                st.store_id = (from x in ent.stores
                               where x.name == textBox6.Text
                               select x.storeid).First();
                st.supplier_id = (from x in ent.supplies
                                  where x.name == textBox7.Text
                                  select x.id).First();
                st.date = default; //MessageBox.Show( DateTime.Today.ToString("yyyy-MM-dd"));
                ent.suplyResets.Add(st);
                ent.SaveChanges();
                MessageBox.Show("Data added");
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
                in_product resiet = new in_product();

                resiet.inresiet_num = (int)dataGridView1.CurrentRow.Cells[0].Value;
                resiet.item_code = (from x in ent.items
                                   where x.name == textBox1.Text
                                   select x.code).First();
                
                resiet.quantity = int.Parse(textBox2.Text);
                DateTime d = DateTime.ParseExact(textBox3.Text,
                                    "yyyy-MM-dd",
                                     System.Globalization.CultureInfo.InvariantCulture);
                resiet.production_date = d;

                resiet.validity = int.Parse(textBox4.Text);
                resiet.expired_date = d.AddMonths(int.Parse(textBox4.Text));

                


                ent.in_product.Add(resiet);

                ent.SaveChanges();
                //MessageBox.Show("Data added");
                string sname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //MessageBox.Show(sname);
                int storeId = (from xx in ent.stores
                               where xx.name == sname
                               select xx.storeid).First();

                int dif = (int)resiet.quantity;
                var iteem = (from i in ent.store_product
                             where (i.itemcode == resiet.item_code &&
                                    i.storeid == storeId &&
                                    i.expiredate == resiet.expired_date)
                             select i).FirstOrDefault();
                //MessageBox.Show("Data added");
                if (iteem != null)
                {
                    //MessageBox.Show("in");
                    iteem.quantity = iteem.quantity + dif;
                }
                else
                {
                    //MessageBox.Show("else");
                    store_product i = new store_product();
                    i.itemcode = resiet.item_code;
                    i.storeid = storeId;
                    i.expiredate = (System.DateTime)resiet.expired_date;
                    i.quantity = dif;
                    ent.store_product.Add(i);
                }


                //ent.in_product.Add(resiet);

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
           // DateTime d = DateTime.Now; 
            //if (dataGridView1.CurrentRow.Cells[6].Value.ToString() != null)
            //{
            //    d = DateTime.ParseExact(dataGridView1.CurrentRow.Cells[6].Value.ToString(),
            //                          "yyyy-MM-dd",
            //                           System.Globalization.CultureInfo.InvariantCulture);
            //}
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value != null ? dataGridView1.CurrentRow.Cells[4].Value.ToString() : "";
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value != null ? dataGridView1.CurrentRow.Cells[5].Value.ToString() : "";
             
            //textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString() != null ? d.ToString("yyyy-MM-dd") : "";
           textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value != null ? dataGridView1.CurrentRow.Cells[7].Value.ToString() : "";

        }
    }
}

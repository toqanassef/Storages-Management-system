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
    public partial class outRes : Form
    {
        projectEFEnt ent = new projectEFEnt();
        public outRes()
        {
            InitializeComponent();
        }
        void loadData()
        {
            var data = (from s in ent.outResiets
                        join p in ent.out_product
                        on s.num equals p.outresiet_num into temp
                        from p in temp.DefaultIfEmpty()
                        select new
                        {
                            num = s.num,
                            s.date,
                            customer_name = s.custom.name,
                            store_name = s.store.name,
                            product = p != null ? p.item.name : default,
                            quantity = p != null ? p.quantity : default,
                            
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
                    out_product resiet = (from s in ent.out_product
                                         where s.outresiet_num == num
                                         select s).First();
                    int oldquan = (int)resiet.quantity;
                    resiet.quantity = int.Parse(textBox2.Text);

                    
                    //// change product in store
                    if (oldquan != resiet.quantity)
                    {
                        int dif = (int)resiet.quantity - oldquan;
                        var iteem = (from i in ent.store_product
                                     where (i.itemcode == resiet.item_code &&
                                            i.storeid == resiet.outResiet.store_id 
                                            )
                                     select i).OrderBy(i => i.expiredate).FirstOrDefault();

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

        private void add_Click(object sender, EventArgs e)
        {
            
                try
                {
                    out_product resiet = new out_product();

                    resiet.outresiet_num = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    resiet.item_code = (from x in ent.items
                                        where x.name == textBox1.Text
                                        select x.code).First();

                    resiet.quantity = int.Parse(textBox2.Text);
                    



                    ent.out_product.Add(resiet);

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
                                        i.storeid == storeId )
                                 select i).OrderBy(i => i.expiredate).FirstOrDefault();
                    //MessageBox.Show("Data added");
                    if (iteem != null)
                    {
                        //MessageBox.Show("in");
                        iteem.quantity = iteem.quantity + dif;
                    }
                    else
                    {
                        MessageBox.Show("no item found in store");
                        
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
    }
}

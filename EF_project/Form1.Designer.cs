
namespace EF_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.store_edit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.edititem = new System.Windows.Forms.Button();
            this.editsuppliers = new System.Windows.Forms.Button();
            this.editcustomers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.in_resEdit = new System.Windows.Forms.Button();
            this.out_resEdit = new System.Windows.Forms.Button();
            this.transitem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // store_edit
            // 
            this.store_edit.Location = new System.Drawing.Point(595, 80);
            this.store_edit.Name = "store_edit";
            this.store_edit.Size = new System.Drawing.Size(85, 37);
            this.store_edit.TabIndex = 1;
            this.store_edit.Text = "stores edit";
            this.store_edit.UseVisualStyleBackColor = true;
            this.store_edit.Click += new System.EventHandler(this.store_edit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(58, 395);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(466, 203);
            this.dataGridView2.TabIndex = 2;
            // 
            // edititem
            // 
            this.edititem.Location = new System.Drawing.Point(725, 81);
            this.edititem.Name = "edititem";
            this.edititem.Size = new System.Drawing.Size(85, 36);
            this.edititem.TabIndex = 3;
            this.edititem.Text = "product edit";
            this.edititem.UseVisualStyleBackColor = true;
            this.edititem.Click += new System.EventHandler(this.edititem_Click);
            // 
            // editsuppliers
            // 
            this.editsuppliers.Location = new System.Drawing.Point(595, 139);
            this.editsuppliers.Name = "editsuppliers";
            this.editsuppliers.Size = new System.Drawing.Size(85, 36);
            this.editsuppliers.TabIndex = 4;
            this.editsuppliers.Text = "suppliers edit";
            this.editsuppliers.UseVisualStyleBackColor = true;
            this.editsuppliers.Click += new System.EventHandler(this.editsuppliers_Click);
            // 
            // editcustomers
            // 
            this.editcustomers.Location = new System.Drawing.Point(725, 139);
            this.editcustomers.Name = "editcustomers";
            this.editcustomers.Size = new System.Drawing.Size(85, 36);
            this.editcustomers.TabIndex = 5;
            this.editcustomers.Text = "customers edit";
            this.editcustomers.UseVisualStyleBackColor = true;
            this.editcustomers.Click += new System.EventHandler(this.editcustomers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "stores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "products in selected store";
            // 
            // in_resEdit
            // 
            this.in_resEdit.Location = new System.Drawing.Point(595, 197);
            this.in_resEdit.Name = "in_resEdit";
            this.in_resEdit.Size = new System.Drawing.Size(85, 40);
            this.in_resEdit.TabIndex = 10;
            this.in_resEdit.Text = "supply resiet edit";
            this.in_resEdit.UseVisualStyleBackColor = true;
            this.in_resEdit.Click += new System.EventHandler(this.in_resEdit_Click);
            // 
            // out_resEdit
            // 
            this.out_resEdit.Location = new System.Drawing.Point(725, 195);
            this.out_resEdit.Name = "out_resEdit";
            this.out_resEdit.Size = new System.Drawing.Size(85, 45);
            this.out_resEdit.TabIndex = 11;
            this.out_resEdit.Text = "customer resiet edit";
            this.out_resEdit.UseVisualStyleBackColor = true;
            this.out_resEdit.Click += new System.EventHandler(this.out_resEdit_Click);
            // 
            // transitem
            // 
            this.transitem.Location = new System.Drawing.Point(659, 262);
            this.transitem.Name = "transitem";
            this.transitem.Size = new System.Drawing.Size(85, 36);
            this.transitem.TabIndex = 12;
            this.transitem.Text = "transform product";
            this.transitem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Reports";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "store";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 43);
            this.button2.TabIndex = 15;
            this.button2.Text = "product in store";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 56);
            this.button3.TabIndex = 16;
            this.button3.Text = "product will expired by";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(748, 473);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(748, 552);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "store id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 671);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transitem);
            this.Controls.Add(this.out_resEdit);
            this.Controls.Add(this.in_resEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editcustomers);
            this.Controls.Add(this.editsuppliers);
            this.Controls.Add(this.edititem);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.store_edit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button store_edit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button edititem;
        private System.Windows.Forms.Button editsuppliers;
        private System.Windows.Forms.Button editcustomers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button in_resEdit;
        private System.Windows.Forms.Button out_resEdit;
        private System.Windows.Forms.Button transitem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}


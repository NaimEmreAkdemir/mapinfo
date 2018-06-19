using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class cizgisecim : Form
    {
        private ListView listView1;
        private ColumnHeader ilksecim;
        private Button kapamabutonu;
        private ColumnHeader ikincisecim;

        public cizgisecim()
        {
            InitializeComponent();
        }
        public void yenikayit()
        {
            try
            {
                Form1.mi.Do("undim o as object");
            }
            catch { }

            Form1.mi.Do("dim o as object");
            Form1.mi.Do("o=CreateLine(commandinfo(1),commandinfo(2),commandinfo(5),commandinfo(6))");
            Form1.mi.Do("insert into cizgisecim (obj) values(o)");
            Form1.mi.Do("fetch last from cizgisecim");//tablo belirle
            bilgigoster();
            this.ShowDialog(); /////////////////////////////////////////
        }

        public void bilgigoster()
        {
            labelId.Text = Form1.mi.Eval("cizgisecim.rowid");
            TextboxId.Text = Form1.mi.Eval("cizgisecim.tip");
            TextboxName.Text = Form1.mi.Eval("line.adi");
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cizgisecim));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ilksecim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ikincisecim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kapamabutonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ilksecim,
            this.ikincisecim});
            this.listView1.Location = new System.Drawing.Point(8, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(212, 67);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // kapamabutonu
            // 
            this.kapamabutonu.Image = ((System.Drawing.Image)(resources.GetObject("kapamabutonu.Image")));
            this.kapamabutonu.Location = new System.Drawing.Point(247, 56);
            this.kapamabutonu.Name = "kapamabutonu";
            this.kapamabutonu.Size = new System.Drawing.Size(67, 67);
            this.kapamabutonu.TabIndex = 1;
            this.kapamabutonu.UseVisualStyleBackColor = true;
            // 
            // cizgisecim
            // 
            this.ClientSize = new System.Drawing.Size(400, 171);
            this.Controls.Add(this.kapamabutonu);
            this.Controls.Add(this.listView1);
            this.Name = "cizgisecim";
            this.ResumeLayout(false);

        }
    }
}

using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;



namespace MyProject
{
    public partial class infolist : Form
    {

        
        public infolist (Form _anaform)
            {
            InitializeComponent();
            anaform = _anaform;
            }
        string tabloadi = "";
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btn_kapat;
        public string get_tablename()
        {
            return tabloadi;
        }
        public int listcount()
        {
            return listView1.Items.Count;
        }
        Form anaform;
        public void listeye_ekle(string info, string rowid, string xx)
        {
            ListViewItem lvi = new ListViewItem(new string[] { info, rowid, xx });
            lvi.Tag = rowid;
            listView1.Items.Add(lvi);
            
        }
        public void listeyi_temizle()
        {
            listView1.Items.Clear();
            tabloadi = "";
            
        }
       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infolist));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(12, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(313, 211);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tablo Adı";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipi";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 175;
            // 
            // btn_kapat
            // 
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.Location = new System.Drawing.Point(335, 35);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(52, 49);
            this.btn_kapat.TabIndex = 1;
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // infolist
            // 
            this.ClientSize = new System.Drawing.Size(399, 296);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.listView1);
            this.Name = "infolist";
            this.Load += new System.EventHandler(this.infolist_Load_1);
            this.ResumeLayout(false);

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void infolist_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
      

        private void infolist_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {


                if (listView1.SelectedItems.Count > 0) //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    tabloadi = listView1.SelectedItems[0].Text;
                    Form1.mi.Do("Fetch rec " + listView1.SelectedItems[0].Tag.ToString() + " From " + tabloadi);
                    ((Form1)anaform).bilgi_goster(tabloadi);

                }   //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
            catch { MessageBox.Show("Lütfen Formu kapatıp tekrar bilgi almayı deneyiniz!", "Dikkat"); }
        }

        private void infolist_Load_1(object sender, EventArgs e)
        {

        }
    }


}


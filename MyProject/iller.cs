using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MapInfo;

namespace MyProject
{
    public partial class iller : Form
    {


        public iller()
        {
            InitializeComponent();
        }
        public void bilgigoster()
        {
            string rw = Form1.mi.Eval("Iller.rowid");
            Form1.mi.Do("select Area(obj, \"sq km\") from Iller where rowid="+ rw + "into alan noselect");
            lbl_rowid.Text = Form1.mi.Eval("iller.rowid");
            txt_ilAdi.Text = Form1.mi.Eval("iller.il_adi");
            txt_plakaNo.Text = Form1.mi.Eval("iller.plaka_no");
            txt_nufus90.Text = Form1.mi.Eval("iller.nufus_1990");
            txt_nufus97.Text = Form1.mi.Eval("iller.nufus_1997");
            txt_alan.Text = Form1.mi.Eval("alan.col1") + " km²";

        }

        private Button btn_kapat;
        private Label lbl_rowid;
        private TextBox txt_ilAdi;
        private TextBox txt_plakaNo;
        private TextBox txt_nufus90;
        private TextBox txt_nufus97;
        private TextBox txt_alan;
        private bool onay = false;
        private void vazgec()
        {
            if(onay == false)
            {
                Form1.mi.Do("rollback table line");
            }
            onay = false;
            this.Hide();
        }

        private void updateinfo()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("update iller set il_adi=\"" + txt_ilAdi.Text + "\"");
                sb.Append(", plaka_no=\"" + txt_plakaNo.Text + "\"");
                sb.Append(", nufus_1990=\"" + txt_nufus90.Text + "\"");
                sb.Append(", nufus_1997=\"" + txt_nufus97.Text + "\"");
                sb.Append(" where rowid=" + lbl_rowid.Text);
                Form1.mi.Do(sb.ToString());
                Form1.mi.Do("commit table iller");
                onay = true;
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InitializeComponent()
        {
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_rowid = new System.Windows.Forms.Label();
            this.txt_ilAdi = new System.Windows.Forms.TextBox();
            this.txt_plakaNo = new System.Windows.Forms.TextBox();
            this.txt_nufus90 = new System.Windows.Forms.TextBox();
            this.txt_nufus97 = new System.Windows.Forms.TextBox();
            this.txt_alan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(122, 30);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(122, 84);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(75, 23);
            this.btn_kapat.TabIndex = 1;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_rowid
            // 
            this.lbl_rowid.AutoSize = true;
            this.lbl_rowid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_rowid.Location = new System.Drawing.Point(49, 14);
            this.lbl_rowid.Name = "lbl_rowid";
            this.lbl_rowid.Size = new System.Drawing.Size(35, 13);
            this.lbl_rowid.TabIndex = 2;
            this.lbl_rowid.Text = "label1";
            // 
            // txt_ilAdi
            // 
            this.txt_ilAdi.Location = new System.Drawing.Point(16, 30);
            this.txt_ilAdi.Name = "txt_ilAdi";
            this.txt_ilAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_ilAdi.TabIndex = 3;
            this.txt_ilAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_plakaNo
            // 
            this.txt_plakaNo.Location = new System.Drawing.Point(16, 57);
            this.txt_plakaNo.Name = "txt_plakaNo";
            this.txt_plakaNo.Size = new System.Drawing.Size(100, 20);
            this.txt_plakaNo.TabIndex = 4;
            this.txt_plakaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nufus90
            // 
            this.txt_nufus90.Location = new System.Drawing.Point(16, 84);
            this.txt_nufus90.Name = "txt_nufus90";
            this.txt_nufus90.Size = new System.Drawing.Size(100, 20);
            this.txt_nufus90.TabIndex = 5;
            this.txt_nufus90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nufus97
            // 
            this.txt_nufus97.Location = new System.Drawing.Point(16, 111);
            this.txt_nufus97.Name = "txt_nufus97";
            this.txt_nufus97.Size = new System.Drawing.Size(100, 20);
            this.txt_nufus97.TabIndex = 6;
            this.txt_nufus97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_alan
            // 
            this.txt_alan.Location = new System.Drawing.Point(16, 138);
            this.txt_alan.Name = "txt_alan";
            this.txt_alan.Size = new System.Drawing.Size(100, 20);
            this.txt_alan.TabIndex = 7;
            this.txt_alan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iller
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(223, 186);
            this.Controls.Add(this.txt_alan);
            this.Controls.Add(this.txt_nufus97);
            this.Controls.Add(this.txt_nufus90);
            this.Controls.Add(this.txt_plakaNo);
            this.Controls.Add(this.txt_ilAdi);
            this.Controls.Add(this.lbl_rowid);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "iller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btn_kaydet;

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            updateinfo();
        }
        private void iller_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            vazgec();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            vazgec();
        }
    }




    }











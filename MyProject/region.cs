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
    public partial class region : Form
    {
        public region()
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
            Form1.mi.Do("insert into region (obj) values(commandinfo(1))");
            Form1.mi.Do("fetch last from region");

            string rowid = Form1.mi.Eval("region.rowid");
            Form1.mi.Do("select*from region where rowid=" + rowid + " into secim noselect");
            Form1.mi.Do("o=secim.obj");
            Form1.mi.Do("alter object o info 3, makebrush(46, 11796288,-1)");
            Form1.mi.Do("update secim set obj=o");
            bilgigoster();
            this.ShowDialog();
        }

        public void bilgigoster()
        {
            labelId.Text = Form1.mi.Eval("region.rowid");
            TextboxId.Text = Form1.mi.Eval("region.tip");
            TextboxName.Text = Form1.mi.Eval("region.adi");
        }

        private void updateinfo()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("update region set tip=\"" + TextboxId.Text + "\"");
                sb.Append(", adi=\"" + TextboxName.Text + "\"");
                sb.Append(" where rowid=" + labelId.Text);
                Form1.mi.Do(sb.ToString());
                Form1.mi.Do("commit table region automatic applyupdates");
                onay = true;
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void vazgec()
        {
            if (onay == false)
            {
                Form1.mi.Do("rollback table region");
            }
            onay = false;
            this.Hide();
        }
        private bool onay = false;
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyor musunuz", "Dikkat",
            MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                Form1.mi.Do("delete from region where rowid=" + labelId.Text);
                Form1.mi.Do("commit table region automatic applyupdates");
                this.Hide();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            updateinfo();
        }

        private void region_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            updateinfo();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyormusunuz?", "Dikkat",
            MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                Form1.mi.Do("delete from region where rowid=" + labelId.Text);
                Form1.mi.Do("commit table region automatic applyupdates");
                this.Hide();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1.mi.Do("rollback table region");
            this.Close();
        }
    }
}

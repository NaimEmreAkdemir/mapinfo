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
    public partial class noktaAt : Form
    {
        public noktaAt()
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
            Form1.mi.Do("o=CreatePoint(commandinfo(1),commandinfo(2))");
            Form1.mi.Do("insert into point (obj) values(o)");
            Form1.mi.Do("fetch last from point");

            string rowid = Form1.mi.Eval("point.rowid");
            Form1.mi.Do("select*from point where rowid=" + rowid + " into secim noselect");
            Form1.mi.Do("o=secim.obj");
            Form1.mi.Do("alter object o info 2, makesymbol(34, 16776960, 12)");
            Form1.mi.Do("update secim set obj=o");
            bilgigoster();
            onay = true;
            this.ShowDialog();
            
        }

        public void bilgigoster()
        {
            labelId.Text = Form1.mi.Eval("point.rowid");
            TextboxId.Text = Form1.mi.Eval("point.tipi");
            TextboxName.Text = Form1.mi.Eval("point.adi");
        }

        private void updateinfo()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("update point set tipi=\"" + TextboxId.Text + "\"");
                sb.Append(", adi=\"" + TextboxName.Text + "\"");
                sb.Append(" where rowid=" + labelId.Text);
                Form1.mi.Do(sb.ToString());
                Form1.mi.Do("commit table point automatic applyupdates");
                this.Hide(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyor musunuz", "Dikkat",
            MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                Form1.mi.Do("delete from point where rowid=" + labelId.Text);
                Form1.mi.Do("commit table point automatic applyupdates");
                this.Hide();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            updateinfo();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1.mi.Do("rollback table point");
            this.Close();
        }

        private void TextboxId_TextChanged(object sender, EventArgs e)
        {

        }
        private bool onay = false;
        private void vazgec()
        {
            if (onay == false)
            {
                Form1.mi.Do("rollback table point");
            }
            onay = false;
            this.Close();
        }
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyor musunuz", "Dikkat",
            MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                Form1.mi.Do("delete from point where rowid=" + labelId.Text);
                Form1.mi.Do("commit table point automatic applyupdates");
                this.Hide();
            }
        }
    }
}

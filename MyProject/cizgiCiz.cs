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
    public partial class cizgiCiz : Form
    {
        public static string ilkşehir, sonşehir;
        public cizgiCiz()
        {
            InitializeComponent();
        }
        Form1 anaform;   // 5 eyl
        public void yenikayit()
        {
            
            try
            {
                Form1.mi.Do("undim o as object");
            }
            catch { }

            Form1.mi.Do("dim o as object");
            Form1.mi.Do("o=CreateLine(commandinfo(1),commandinfo(2),commandinfo(5),commandinfo(6))");
            Form1.mi.Do("insert into line (obj) values(o)");
            Form1.mi.Do("fetch last from line");

            string rowid = Form1.mi.Eval("line.rowid");

            Form1.mi.Do("select*from line where rowid=" + rowid + " into secim noselect");
            Form1.mi.Do("o=secim.obj");
            Form1.mi.Do("alter object o info 2, makepen (2,2,16711680)");
            Form1.mi.Do("update secim set obj=o");

            string x = Form1.mi.Eval("format$(commandinfo(1), \",#######.###########\")").Replace(',', '.');
            string y = Form1.mi.Eval("format$(commandinfo(2), \",#######.###########\")").Replace(',', '.');

            string x2 = Form1.mi.Eval("format$(commandinfo(5), \",#######.###########\")").Replace(',', '.'); 
            string y2 = Form1.mi.Eval("format$(commandinfo(6), \",#######.###########\")").Replace(',', '.');


            Form1.mi.Do("select * from Iller where obj contains createcircle  (" + x + "," + y + ",1 ) into sel ");
            label1.Text = ilkşehir = Form1.mi.Eval("sel.il_adi");

            Form1.mi.Do("select * from Iller where obj contains createcircle  (" + x2 + "," + y2 + ",1 ) into sel ");
            label2.Text = sonşehir = Form1.mi.Eval("sel.il_adi");

            bilgigoster();
            this.ShowDialog(); 

        }

        public void bilgigoster()
        {
            labelId.Text = Form1.mi.Eval("line.rowid");
            TextboxId.Text = Form1.mi.Eval("line.tip");
            TextboxName.Text = Form1.mi.Eval("line.adi");
           
            
        }

        private void updateinfo()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("update line set tip=\"" + TextboxId.Text + "\"");
                sb.Append(", adi=\"" + TextboxName.Text + "\"");
                sb.Append(", xstart=objectgeography(obj,1)");
                sb.Append(", ystart=objectgeography(obj,2)");
                sb.Append(", xend=objectgeography(obj,3)");
                sb.Append(", yend=objectgeography(obj,4)");
                sb.Append(" where rowid=" + labelId.Text);
                
                Form1.mi.Do(sb.ToString());
                Form1.mi.Do("commit table line");

                this.Close(); 
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
                Form1.mi.Do("delete from line where rowid=" + labelId.Text);
                Form1.mi.Do("commit table line");
                this.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            updateinfo();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1.mi.Do("rollback table line");
            this.Close();
        }

        private void cizgiCiz_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
